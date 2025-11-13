using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Android.App;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Java.Interop;
using Java.Lang;
using JetBrains.Annotations;
using MugenMvvm.Android;
using MugenMvvm.Android.Bindings;
using MugenMvvm.Android.Members;
using MugenMvvm.Android.Native;
using MugenMvvm.Android.Native.Interfaces;
using MugenMvvm.Android.Native.Interfaces.Views;
using MugenMvvm.Android.Native.Views;
using MugenMvvm.Android.Native.Views.Support;
using MugenMvvm.Android.Templating;
using MugenMvvm.Android.Templating.Interfaces;
using MugenMvvm.Android.Views;
using MugenMvvm.Api;
using MugenMvvm.Api.Interfaces;
using MugenMvvm.App;
using MugenMvvm.App.Api.Interfaces;
using MugenMvvm.App.Enums;
using MugenMvvm.App.Interfaces;
using MugenMvvm.Bindings;
using MugenMvvm.Bindings.Attributes;
using MugenMvvm.Bindings.Enums;
using MugenMvvm.Bindings.Interfaces;
using MugenMvvm.Bindings.Members;
using MugenMvvm.Bindings.Parsing.Expressions;
using MugenMvvm.Bindings.Parsing.Interfaces;
using MugenMvvm.Busy;
using MugenMvvm.Busy.Api;
using MugenMvvm.Busy.Enums;
using MugenMvvm.Busy.Interfaces;
using MugenMvvm.Collections;
using MugenMvvm.Collections.Api;
using MugenMvvm.Collections.Decorators;
using MugenMvvm.Collections.Interfaces;
using MugenMvvm.Collections.Internal;
using MugenMvvm.Commands;
using MugenMvvm.Commands.Api;
using MugenMvvm.Commands.Interfaces;
using MugenMvvm.Common;
using MugenMvvm.Common.Api;
using MugenMvvm.Common.Interfaces;
using MugenMvvm.Common.Keys;
using MugenMvvm.Components;
using MugenMvvm.Components.Interfaces;
using MugenMvvm.CompositeUI.Api;
using MugenMvvm.CompositeUI.Api.Interfaces;
using MugenMvvm.CompositeUI.App;
using MugenMvvm.CompositeUI.App.Interfaces;
using MugenMvvm.CompositeUI.Bindings;
using MugenMvvm.CompositeUI.Commands;
using MugenMvvm.CompositeUI.Common;
using MugenMvvm.CompositeUI.Common.Interfaces;
using MugenMvvm.CompositeUI.Debugging;
using MugenMvvm.CompositeUI.Delegates;
using MugenMvvm.CompositeUI.Enums;
using MugenMvvm.CompositeUI.Extensions;
using MugenMvvm.CompositeUI.Sections;
using MugenMvvm.CompositeUI.Sections.Interfaces;
using MugenMvvm.CompositeUI.Sections.Modifiers;
using MugenMvvm.CompositeUI.Sections.Modifiers.Interfaces;
using MugenMvvm.CompositeUI.Sections.Renderers;
using MugenMvvm.CompositeUI.Sections.Renderers.Interfaces;
using MugenMvvm.CompositeUI.Sections.Visuals;
using MugenMvvm.CompositeUI.Sections.Visuals.Interfaces;
using MugenMvvm.CompositeUI.Templating;
using MugenMvvm.CompositeUI.Templating.Interfaces;
using MugenMvvm.CompositeUI.ViewModels;
using MugenMvvm.CompositeUI.Views;
using MugenMvvm.Debugging;
using MugenMvvm.Delegates;
using MugenMvvm.Enums;
using MugenMvvm.Extensions;
using MugenMvvm.Logging.Interfaces;
using MugenMvvm.Metadata;
using MugenMvvm.Metadata.Interfaces;
using MugenMvvm.Navigation;
using MugenMvvm.Navigation.Api;
using MugenMvvm.Navigation.Enums;
using MugenMvvm.Navigation.Interfaces;
using MugenMvvm.Observation;
using MugenMvvm.Observation.Interfaces;
using MugenMvvm.Reflection.Enums;
using MugenMvvm.Reflection.Interfaces;
using MugenMvvm.Reflection.Members;
using MugenMvvm.Templating;
using MugenMvvm.Templating.Interfaces;
using MugenMvvm.Validation;
using MugenMvvm.Validation.Api;
using MugenMvvm.Validation.Interfaces;
using MugenMvvm.ViewModels;
using MugenMvvm.ViewModels.Api;
using MugenMvvm.ViewModels.Enums;
using MugenMvvm.ViewModels.Interfaces;
using MugenMvvm.Views;
using MugenMvvm.Views.Enums;
using MugenMvvm.Views.Interfaces;
using _Microsoft.Android.Resource.Designer;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")]
[assembly: InternalsVisibleTo("MugenMvvm.UnitTests")]
[assembly: AssemblyMetadata("IsTrimmable", "True")]
[assembly: AssemblyCompany("MugenMvvm.CompositeUI")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0+fc1d71bd461bd016b12f5d0d6432956e844f51de")]
[assembly: AssemblyProduct("MugenMvvm.CompositeUI")]
[assembly: AssemblyTitle("MugenMvvm.CompositeUI")]
[assembly: TargetPlatform("Android35.0")]
[assembly: SupportedOSPlatform("Android21.0")]
[assembly: AssemblyVersion("1.0.0.0")]
[module: RefSafetyRules(11)]
namespace MugenMvvmCompositeUI
{
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class MugenMvvmCompositeUIGeneratedApiProviderRegistration
	{
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static MugenApplicationConfiguration MugenMvvmCompositeUIGeneratedApiProviderRegistrationConfiguration(this MugenApplicationConfiguration configuration)
		{
			return GeneratedApiProviderRegistrationConfigurationImpl(configuration);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		private static MugenApplicationConfiguration GeneratedApiProviderRegistrationConfigurationImpl(MugenApplicationConfiguration configuration)
		{
			return configuration;
		}
	}
}
namespace MugenMvvm.CompositeUI
{
	internal sealed class HasVisibilityBindableMembersDescriptor
	{
		public SectionVisibility? Visibility { get; set; }

		private HasVisibilityBindableMembersDescriptor()
		{
		}
	}
	internal sealed class LayoutSectionBindableMembersDescriptor
	{
		public event EventHandler? TryGetModifierChanged;

		private LayoutSectionBindableMembersDescriptor()
		{
		}
	}
	internal sealed class TextInputSectionBindableMembersDescriptor
	{
		public string? Text { get; set; }

		private TextInputSectionBindableMembersDescriptor()
		{
		}
	}
	internal sealed class TextLayoutSectionBindableMembersDescriptor
	{
		public FormattedText Text { get; set; }

		private TextLayoutSectionBindableMembersDescriptor()
		{
		}
	}
	internal sealed class ButtonLayoutSectionBindableMembersDescriptor
	{
		public FormattedText Text { get; set; }

		public ImageSource Icon { get; set; }

		private ButtonLayoutSectionBindableMembersDescriptor()
		{
		}
	}
	internal sealed class ImageLayoutSectionBindableMembersDescriptor
	{
		public ImageSource Source { get; set; }

		private ImageLayoutSectionBindableMembersDescriptor()
		{
		}
	}
	public readonly struct CacheSectionResult<T> where T : class, ISection
	{
		public readonly T Section;

		private readonly ISection _sectionRaw;

		public CacheSectionResult(T section)
			: this(section, section)
		{
		}

		public CacheSectionResult(T section, ISection sectionRaw)
		{
			Should.NotBeNull(section, "section");
			Should.NotBeNull(sectionRaw, "sectionRaw");
			Section = section;
			_sectionRaw = sectionRaw;
		}

		public ISection ToSection()
		{
			return _sectionRaw;
		}
	}
	public static class CompositeUIExtensions
	{
		private sealed class CompositeSectionHeaderFooter : HeaderFooterCollectionDecorator
		{
			private SectionVisibility? _visibility;

			public CompositeSectionHeaderFooter UpdateVisibility(ISection section, SectionVisibility visibility)
			{
				if (_visibility == visibility)
				{
					return this;
				}
				_visibility = visibility;
				if (visibility.IsHidden())
				{
					SetHeader(default(ItemOrIReadOnlyList<object>));
				}
				else if (visibility.IsVisible())
				{
					SetHeader(ItemOrIReadOnlyList.FromItem((object?)section));
				}
				else
				{
					IReadOnlyList<object> header = base.Header;
					if (header == null || header.Count != 1 || !(header[0] is IInvisibleSection))
					{
						SetHeader(ItemOrIReadOnlyList.FromItem((object?)section.AsInvisibleSection()));
					}
				}
				return this;
			}
		}

		private sealed class SelectManyErrorRetryHandler : IAppErrorRetryHandler
		{
			private readonly SelectManyAsyncHandler _handler;

			public object? ErrorSource => _handler.ObservableCollection;

			public SelectManyErrorRetryHandler(SelectManyAsyncHandler handler)
			{
				_handler = handler;
			}

			public ValueTask<bool?> RetryAsync(IAppErrorInfo error, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				return _handler.ReloadAsync().AsValueTask();
			}
		}

		public const string ReloadSectionArgsName = "$Reload";

		internal static readonly Func<string, object?> GetReloadArgs = GetReloadArgsImpl;

		public static readonly PropertyChangedEventArgs ReloadSectionArgs = new PropertyChangedEventArgs("$Reload");

		internal static readonly PropertyChangedEventArgs LayoutArgs = new PropertyChangedEventArgs("Layout");

		internal static readonly PropertyChangedEventArgs SectionsArgs = new PropertyChangedEventArgs("Sections");

		internal static readonly PropertyChangedEventArgs ChildrenArgs = new PropertyChangedEventArgs("Children");

		internal static readonly PropertyChangedEventArgs ModifiersArgs = new PropertyChangedEventArgs("Modifiers");

		internal static readonly PropertyChangedEventArgs TextArgs = new PropertyChangedEventArgs("Text");

		internal static readonly PropertyChangedEventArgs IconArgs = new PropertyChangedEventArgs("Icon");

		internal static readonly PropertyChangedEventArgs SourceArgs = new PropertyChangedEventArgs("Source");

		internal static readonly PropertyChangedEventArgs TemplateKeyArgs = new PropertyChangedEventArgs("TemplateKey");

		internal static readonly PropertyChangedEventArgs ResetLayoutArgs = new PropertyChangedEventArgs("ResetLayout");

		internal static readonly PropertyChangedEventArgs TabTypeArgs = new PropertyChangedEventArgs("TabType");

		internal static readonly PropertyChangedEventArgs ViewsAwareSectionArgs = new PropertyChangedEventArgs("ViewsAwareSection");

		internal static readonly PropertyChangedEventArgs UpdateSectionsInBatchArgs = new PropertyChangedEventArgs("UpdateSectionsInBatch");

		internal static readonly PropertyChangedEventArgs CanClearOnFirstItemArgs = new PropertyChangedEventArgs("CanClearOnFirstItem");

		internal static readonly PropertyChangedEventArgs SwitchToBackgroundOnAsyncLoadArgs = new PropertyChangedEventArgs("SwitchToBackgroundOnAsyncLoad");

		internal static readonly PropertyChangedEventArgs SwitchToBackgroundItemsThresholdArgs = new PropertyChangedEventArgs("SwitchToBackgroundItemsThreshold");

		internal static readonly PropertyChangedEventArgs ShellArgs = new PropertyChangedEventArgs("Shell");

		internal static readonly PropertyChangedEventArgs SectionArgs = new PropertyChangedEventArgs("Section");

		internal static readonly PropertyChangedEventArgs VisibilityArgs = new PropertyChangedEventArgs("Visibility");

		internal static readonly PropertyChangedEventArgs HasItemsArgs = new PropertyChangedEventArgs("HasItems");

		internal static readonly PropertyChangedEventArgs SelectedTabArgs = new PropertyChangedEventArgs("SelectedTab");

		internal static readonly PropertyChangedEventArgs CommandArgs = new PropertyChangedEventArgs("Command");

		internal static readonly PropertyChangedEventArgs ParameterArgs = new PropertyChangedEventArgs("Parameter");

		internal static readonly PropertyChangedEventArgs MaxArgs = new PropertyChangedEventArgs("Max");

		internal static readonly PropertyChangedEventArgs MinArgs = new PropertyChangedEventArgs("Min");

		internal static readonly PropertyChangedEventArgs FormatArgs = new PropertyChangedEventArgs("Format");

		internal static readonly PropertyChangedEventArgs CultureInfoArgs = new PropertyChangedEventArgs("CultureInfo");

		internal static readonly PropertyChangedEventArgs IsUserInputArgs = new PropertyChangedEventArgs("IsUserInput");

		internal static readonly PropertyChangedEventArgs AnimateArgs = new PropertyChangedEventArgs("Animate");

		internal static readonly PropertyChangedEventArgs ContentArgs = new PropertyChangedEventArgs("Content");

		private static readonly Lock TemplateIdLock = new Lock();

		private static DictionarySlim<string, object?> _templateIdCache = new DictionarySlim<string, object>(27);

		private static Expression<Func<IVisualSection, IAppErrorsAwareSection?>>? _bindCache1;

		private static Expression<Func<IVisualSection, IValidationErrorsAwareSection?>>? _bindCache2;

		private static Expression<Func<IVisualSection, IViewsAwareSection?>>? _bindCache4;

		private static Expression<Func<ICompositeLayoutSection, bool>>? _bindCache7;

		private static Expression<Func<ITextInputSection, string?>>? _bindCache9;

		public const string HiddenMember = "-";

		private static IExpressionNode? _visibilityExpression;

		private static Expression<Func<IShellAware, IShell?>>? _bindCache8;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache11;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache12;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache13;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache14;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache15;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache16;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache17;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache18;

		private static Expression<Func<IShellAware, ICompositeCommand?>>? _bindCache19;

		private static Expression<Func<View, object?>>? _bindCache6;

		public static MugenApplicationConfiguration EnableCompositeUIDebugging(this MugenApplicationConfiguration configuration)
		{
			if (configuration.ConfigurationIds.Contains("cuid"))
			{
				return configuration;
			}
			return configuration.AddConfigurationId("cuid").WithComponent(new DebugExceptionLoggerCompositeUI());
		}

		public static MugenApplicationConfiguration UseCompositeUIShell(this MugenApplicationConfiguration configuration, IApiProviderComponent<IMugenApplication>? shellHandlerProvider = null, ISectionApiRequest? mainSectionRequest = null, bool mainViewModelSingleton = true, bool addDefaultErrorHandler = true, IServiceProvider? serviceProvider = null)
		{
			if (configuration.ConfigurationIds.Contains("cuis"))
			{
				return configuration;
			}
			return configuration.AddConfigurationId("cuis").UsePlatformShell(serviceProvider).AddCompositeUI(shellHandlerProvider ?? new ShellHandlerProvider(), mainSectionRequest, mainViewModelSingleton, addDefaultErrorHandler);
		}

		public static MugenApplicationConfiguration AddCompositeUI(this MugenApplicationConfiguration configuration, ISectionApiRequest? mainSectionRequest = null, bool mainViewModelSingleton = true, bool addDefaultErrorHandler = true)
		{
			return configuration.AddCompositeUI(new ShellHandlerProvider(), mainSectionRequest, mainViewModelSingleton, addDefaultErrorHandler);
		}

		public static MugenApplicationConfiguration AddCompositeUI(this MugenApplicationConfiguration configuration, IApiProviderComponent<IMugenApplication>? shellHandlerProvider, ISectionApiRequest? mainSectionRequest = null, bool mainViewModelSingleton = true, bool addDefaultErrorHandler = true)
		{
			if (configuration.ConfigurationIds.Contains("cui"))
			{
				return configuration;
			}
			return configuration.AddConfigurationId("cui").AddCompositeUICore().WithComponent(new CompositeApplicationInitializer())
				.WithComponent(new SystemInsetsProvider())
				.WithComponent(new EnvironmentMetricsProvider())
				.WithComponent(shellHandlerProvider)
				.WithComponent(new ShellSectionPresenter())
				.WithComponent(new AppErrorTracker())
				.WithComponent(new DefaultCommandBusySectionHandler())
				.WithComponent(new AppActionInvokerCommandProvider())
				.WithComponent(addDefaultErrorHandler ? new DefaultAppErrorHandler() : null)
				.ServiceConfiguration<IViewModelManager>()
				.WithComponent(new MainViewModelProvider(mainSectionRequest ?? MainSectionRequest.Instance, mainViewModelSingleton))
				.ServiceConfiguration<IViewManager>()
				.WithComponent(new CompositeUIViewBehavior());
		}

		public static MugenApplicationConfiguration AddCompositeUICore(this MugenApplicationConfiguration configuration)
		{
			if (configuration.ConfigurationIds.Contains("cuic"))
			{
				return configuration;
			}
			if (MugenFeature.IsDebug)
			{
				MugenService.GetAppErrors = (object v) => IMugenService<IMugenApplication>.Instance.GetAppErrors(v).ToArrayDispose();
			}
			MugenExtensions.RegisterTypeConverter(delegate(SectionVisibility v, out bool r)
			{
				r = v;
				return true;
			});
			MugenExtensions.RegisterTypeConverter(delegate(bool v, out SectionVisibility r)
			{
				r = v;
				return true;
			});
			MugenExtensions.RegisterTypeConverter(delegate(SectionVisibility v, out bool? r)
			{
				r = v;
				return true;
			});
			MugenExtensions.RegisterTypeConverter(delegate(bool? v, out SectionVisibility r)
			{
				r = v == true;
				return true;
			});
			MugenExtensions.RegisterTypeConverter(delegate(ImmutableArray<IVisualSection> value, out ImmutableArray<object> result)
			{
				object[] array = ImmutableCollectionsMarshal.AsArray(value);
				result = ImmutableCollectionsMarshal.AsImmutableArray(array);
				return true;
			});
			MugenExtensions.RegisterTypeConverter(delegate(MediaSource v, out ImageSource r)
			{
				if (!v.IsInitialized)
				{
					r = default(ImageSource);
					return true;
				}
				return v.TryToImage(out r);
			});
			configuration.GetExtensionMethodProvider().AddIgnoreLinker(typeof(CompositeUIExtensions));
			AttachedMemberProvider attachedMemberProvider = configuration.GetAttachedMemberProvider();
			EventBuilder<IVisualSection> eventBuilder = IVisualSectionBaseBindableMembers.TryGetModifierChangedEventBuilder();
			eventBuilder = eventBuilder.Handler((INotifiableMemberInfo _, IVisualSection s, IEventListener e, IReadOnlyMetadataContext? m) => PropertyChangedObserverProvider.TryGetMemberObserver("Modifiers", s.GetType()).TryObserve(s, e, m));
			eventBuilder.Build(attachedMemberProvider);
			RegisterAttachedMembers(attachedMemberProvider);
			return configuration.RegisterRenderers().AddConfigurationId("cuic");
		}

		public static SectionModifierRendererRegistry GetSectionModifierRendererRegistry(this MugenApplicationConfiguration configuration)
		{
			return configuration.GetService<IMugenApplication>().GetOrAddComponent<SectionModifierRendererRegistry>();
		}

		private static MugenApplicationConfiguration RegisterRenderers(this MugenApplicationConfiguration configuration)
		{
			SectionModifierRendererRegistry sectionModifierRendererRegistry = configuration.GetSectionModifierRendererRegistry();
			sectionModifierRendererRegistry.Register<IMarginSectionModifier, MarginSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IPaddingSectionModifier, PaddingSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ISizeSectionModifier, SizeSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ISizeLimitsSectionModifier, SizeLimitsSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IGravitySectionModifier, GravitySectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<StretchSectionModifier, StretchSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IVisibilitySectionModifier, VisibilitySectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IBackgroundColorSectionModifier, BackgroundColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITextAlignmentSectionModifier, TextAlignmentSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITextColorSectionModifier, TextColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITintColorSectionModifier, TintColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITapSectionModifier, TapSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITapThroughSectionModifier, TapThroughSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IBorderColorSectionModifier, BorderColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IBorderWidthSectionModifier, BorderWidthSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ICornerRadiusSectionModifier, CornerRadiusSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IElevationSectionModifier, ElevationSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IMaxLinesSectionModifier, MaxLinesSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IImageStretchModeSectionModifier, ImageStretchModeSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IKeyboardTypeSectionModifier, KeyboardTypeSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IFocusSectionModifier, FocusSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IPressedSectionModifier, PressedSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IEnabledSectionModifier, EnableSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IFontSectionModifier, FontSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IPlaceholderSectionModifier, PlaceholderSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IPlaceholderColorSectionModifier, PlaceholderColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ICursorColorSectionModifier, CursorColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IOrientationSectionModifier, OrientationSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IAlignmentSectionModifier, AlignmentSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IAnimateLayoutChangesSectionModifier, AnimateLayoutChangesSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ResetScrollSectionModifier, ResetScrollSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<NativeViewSectionModifier, NativeViewSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ILoadMoreSectionModifier, LoadMoreSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IRefreshSectionModifier, RefreshSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IAttachStateSectionModifier, AttachStateSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IClipToPaddingSectionModifier, ClipToPaddingSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IThumbTintColorSectionModifier, ThumbTintColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<ITrackTintColorSectionModifier, TrackTintColorSectionModifierRenderer>();
			sectionModifierRendererRegistry.Register<IZIndexSectionModifier, ZIndexSectionModifierRenderer>();
			return configuration;
		}

		public static FormattedText AsFormatted(this string? source)
		{
			return source;
		}

		public static FormattedText AsFormatted(this string? source, TextFormat? format)
		{
			return new FormattedText(format ?? TextFormat.Raw, source);
		}

		[return: NotNull]
		public static T AsField<T>(this T value, [NotNull] out T outValue)
		{
			return outValue = value;
		}

		public static async ValueTask<IAppErrorInfo?> OnAppErrorAsync(this IMugenApplication apiProvider, object source, Exception exception, string? actionId, IAppErrorRetryHandler? retryHandler, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			try
			{
				return await apiProvider.TryInvoke<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo>>(new OnAppErrorRequest(source, exception, actionId, retryHandler), metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception exception2)
			{
				IMugenService<IMugenApplication>.Instance.OnUnhandledException(exception2, UnhandledExceptionType.System, source, metadata);
				return null;
			}
		}

		[MustDisposeResource]
		public static ActionToken BindSafe<T, TState>(this Bindable<T> bindable, object source, TState state, Action<T?, TState> setter, bool initialSync = true, bool ignoreConstantError = true)
		{
			Should.NotBeNull(source, "source");
			return bindable.WithAppErrorHandler(source, ignoreConstantError).Bind(state, setter, initialSync);
		}

		public static Bindable<T> WithAppErrorHandler<T>(this Bindable<T> bindable, object source, bool ignoreConstant = true)
		{
			if (!bindable.IsInitialized || (ignoreConstant && bindable.IsConstant))
			{
				return bindable;
			}
			return new Bindable<T>(bindable._target, new SafeBindableWrapper<T>(source, bindable._expression, bindable.Constant));
		}

		internal static IAsyncEnumerator<ISection>? TryGetSections(this IMugenApplication apiProvider, IShellSection shell, object? request, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return ((request as GetSectionsRequestBase) ?? (request as ISectionApiRequest)?.GetSectionsRequest(shell, metadata))?.GetSections(apiProvider, metadata, cancellationToken);
		}

		private static object? GetReloadArgsImpl(string arg)
		{
			bool flag;
			switch (arg)
			{
			case "TemplateKey":
			case "Modifiers":
			case "$Reload":
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (!flag)
			{
				return null;
			}
			return CollectionMetadata.ReloadArgs;
		}

		public static void ApplyWithParentNotification<TView>(this ISectionModifierRenderer<TView> renderer, object container, TView view, ref TView hostView, ref TView anchorView, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata) where TView : class
		{
			Should.NotBeNull(renderer, "renderer");
			TView val = hostView;
			renderer.Apply(container, view, ref hostView, ref anchorView, renderers, metadata);
			if (val != hostView)
			{
				(ObjectInternalBindableMembers.TryGetParentAccessorMember(val) as INotifiableMemberInfo)?.Raise(val, null, metadata);
			}
		}

		public static ModifierSet Add(this ModifierSet set, ISectionModifier modifier)
		{
			Should.NotBeNull(modifier, "modifier");
			ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
			if (readOnlySpan.Length == 0)
			{
				return new ModifierSet(modifier);
			}
			int num = FindInsertIndex(readOnlySpan, modifier.Priority);
			ISectionModifier[] array = new ISectionModifier[readOnlySpan.Length + 1];
			readOnlySpan.Slice(0, num).CopyTo(array);
			array[num] = modifier;
			int num2 = num;
			readOnlySpan.Slice(num2, readOnlySpan.Length - num2).CopyTo(array.AsSpan(num + 1));
			return array;
		}

		public static ModifierSet AddRange(this ModifierSet set, [ParamCollection] scoped ReadOnlySpan<ISectionModifier> modifiers)
		{
			if (modifiers.IsEmpty)
			{
				return set;
			}
			ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
			if (readOnlySpan.Length == 0)
			{
				if (modifiers.Length != 1)
				{
					return modifiers.ToArray();
				}
				return new ModifierSet(modifiers[0]);
			}
			ISectionModifier[] array = new ISectionModifier[readOnlySpan.Length + modifiers.Length];
			readOnlySpan.CopyTo(array);
			int num = readOnlySpan.Length;
			for (int i = 0; i < modifiers.Length; i++)
			{
				ISectionModifier sectionModifier = modifiers[i];
				int num2 = FindInsertIndex(array.AsSpan(0, num), sectionModifier.Priority);
				if (num2 < num)
				{
					Array.Copy(array, num2, array, num2 + 1, num - num2);
				}
				array[num2] = sectionModifier;
				num++;
			}
			return array;
		}

		public static ModifierSet Remove(this ModifierSet set, ISectionModifier? modifier)
		{
			if (modifier == null)
			{
				return set;
			}
			ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
			if (readOnlySpan.Length == 0)
			{
				return set;
			}
			int num = -1;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				if (readOnlySpan[i] == modifier)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return set;
			}
			switch (readOnlySpan.Length)
			{
			case 1:
				return default(ModifierSet);
			case 2:
				return new ModifierSet(readOnlySpan[(num == 0) ? 1 : 0]);
			default:
			{
				ISectionModifier[] array = new ISectionModifier[readOnlySpan.Length - 1];
				readOnlySpan.Slice(0, num).CopyTo(array);
				int num2 = num + 1;
				readOnlySpan.Slice(num2, readOnlySpan.Length - num2).CopyTo(array.AsSpan(num));
				return array;
			}
			}
		}

		public static T? TryGet<T>(this ModifierSet set) where T : class, ISectionModifier
		{
			ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				if (readOnlySpan[i] is T result)
				{
					return result;
				}
			}
			return null;
		}

		public static TModifier GetOrAddModifier<TModifier>(this IVisualSection section) where TModifier : class, ISectionModifier, new()
		{
			Should.NotBeNull(section, "section");
			(ISectionModifier, ISectionModifier) state = default((ISectionModifier, ISectionModifier));
			section.UpdateModifiers<(ISectionModifier, ISectionModifier)>(ref state, delegate(ModifierSet set, ref (ISectionModifier? added, ISectionModifier? current) s)
			{
				TModifier val = set.TryGet<TModifier>();
				if (val == null)
				{
					s.current = null;
					ref ISectionModifier item = ref s.added;
					if (item == null)
					{
						item = new TModifier();
					}
					return set.Add(s.added);
				}
				s.current = val;
				return set;
			});
			ISectionModifier sectionModifier = state.Item2;
			if (sectionModifier == null)
			{
				(sectionModifier, _) = state;
			}
			return (TModifier)sectionModifier;
		}

		public static TModifier GetOrAddSingleModifier<TBaseModifier, TModifier>(this IVisualSection section) where TBaseModifier : class, ISectionModifier where TModifier : class, TBaseModifier, new()
		{
			Should.NotBeNull(section, "section");
			(ISectionModifier, ISectionModifier) state = default((ISectionModifier, ISectionModifier));
			section.UpdateModifiers<(ISectionModifier, ISectionModifier)>(ref state, delegate(ModifierSet set, ref (ISectionModifier? added, ISectionModifier? current) s)
			{
				TModifier val = null;
				ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					ISectionModifier sectionModifier2 = readOnlySpan[i];
					if (sectionModifier2 is TBaseModifier && sectionModifier2 is TModifier val2 && val == null)
					{
						val = val2;
						break;
					}
				}
				if (val == null)
				{
					s.current = null;
					ref ISectionModifier item = ref s.added;
					if (item == null)
					{
						item = new TModifier();
					}
					return set.Add(s.added);
				}
				s.current = val;
				return set;
			});
			ISectionModifier sectionModifier = state.Item2;
			if (sectionModifier == null)
			{
				(sectionModifier, _) = state;
			}
			return (TModifier)sectionModifier;
		}

		public static T WithModifier<T>(this T section, ISectionModifier? modifier) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			if (modifier != null)
			{
				section.UpdateModifiers(ref modifier, Add);
			}
			return section;
		}

		public static T WithOrReplaceModifier<T, TModifier>(this T section, ImmutableSectionModifierBase<TModifier>? modifier) where T : class, IVisualSection where TModifier : class, ISectionModifier
		{
			return section.WithOrReplaceModifier<T, TModifier>((ISectionModifier?)modifier);
		}

		public static T WithOrReplaceModifier<T, TModifier>(this T section, SectionModifierBase<TModifier>? modifier) where T : class, IVisualSection where TModifier : class, ISectionModifier
		{
			return section.WithOrReplaceModifier<T, TModifier>((ISectionModifier?)modifier);
		}

		public static T WithOrReplaceModifier<T, TModifier>(this T section, ISectionModifier? modifierRaw) where T : class, IVisualSection where TModifier : class, ISectionModifier
		{
			Should.NotBeNull(section, "section");
			if (modifierRaw != null)
			{
				section.UpdateModifiers<ISectionModifier>(ref modifierRaw, delegate(ModifierSet set, ref ISectionModifier modifier)
				{
					ReadOnlySpan<ISectionModifier> readOnlySpan = set.ReadOnlySpan;
					for (int i = 0; i < readOnlySpan.Length; i++)
					{
						ISectionModifier sectionModifier = readOnlySpan[i];
						if (sectionModifier is TModifier)
						{
							set = set.Remove(sectionModifier);
						}
					}
					return set.Add(modifier);
				});
			}
			return section;
		}

		public static T WithModifiers<T>(this T section, [ParamCollection] scoped ReadOnlySpan<ISectionModifier> modifiers) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			if (!modifiers.IsEmpty)
			{
				section.UpdateModifiers(ref modifiers, AddRange);
			}
			return section;
		}

		public static T RemoveModifier<T>(this T section, ISectionModifier? modifier) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			if (modifier != null)
			{
				section.UpdateModifiers(ref modifier, Remove);
			}
			return section;
		}

		public static IVisualSection RemoveModifiers<T>(this IVisualSection section) where T : class, ISectionModifier
		{
			Should.NotBeNull(section, "section");
			ReadOnlySpan<ISectionModifier> readOnlySpan = section.Modifiers.ReadOnlySpan;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ISectionModifier sectionModifier = readOnlySpan[i];
				if (sectionModifier is T)
				{
					section.RemoveModifier(sectionModifier);
				}
			}
			return section;
		}

		[BindingExtensionMethod]
		public static TModifier? TryGetModifier<TModifier>(this IVisualSection? section) where TModifier : class, ISectionModifier
		{
			if (section == null)
			{
				return null;
			}
			return section.Modifiers.TryGet<TModifier>();
		}

		public static string GetTemplateId(IImmutableLayoutSection section)
		{
			Span<char> initialBuffer = stackalloc char[256];
			ValueSpanBuilder<char> builder = new ValueSpanBuilder<char>(initialBuffer);
			Lock.Scope scope = default(Lock.Scope);
			try
			{
				builder.AppendCompact(Default.GetIdByType(section.GetType()));
				if (section is IHasTemplateSelectorKey hasTemplateSelectorKey)
				{
					builder.Append(hasTemplateSelectorKey.TemplateKey?.ToString());
				}
				ImmutableArray<IVisualSection>.Enumerator enumerator = section.Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IVisualSection current = enumerator.Current;
					builder.AppendCompact(Default.GetIdByType(current.GetType()));
					if (current is IHasTemplateSelectorKey hasTemplateSelectorKey2)
					{
						builder.Append(hasTemplateSelectorKey2.TemplateKey?.ToString());
						if (current is IImmutableVisualSection)
						{
							continue;
						}
					}
					GetModifiersId(current, ref builder);
				}
				ReadOnlySpan<char> key = builder.ToDictionaryKey();
				scope = TemplateIdLock.EnterScope();
				bool hasValue;
				return CollectionSlimExtensions.GetOrAddEntryRefAlternate(ref _templateIdCache, key, out hasValue).Key;
			}
			finally
			{
				scope.Dispose();
				builder.Dispose();
			}
		}

		public static ISectionModifierRenderer<TView>[]? GetLayoutRenderersId<TView>(object? container, object item, ref ValueSpanBuilder<char> templateId, ref DictionarySlim<string, ISectionModifierRenderer<TView>[]> cache, IReadOnlyMetadataContext? metadata) where TView : class
		{
			InlineList<ISectionModifierRenderer<TView>> list = default(InlineList<ISectionModifierRenderer<TView>>);
			try
			{
				CollectModifierRenderers(item, ref list, metadata);
				Span<ISectionModifierRenderer<TView>> span = list.Span;
				if (span.IsEmpty)
				{
					return null;
				}
				Span<ISectionModifierRenderer<TView>> span2 = span;
				for (int i = 0; i < span2.Length; i++)
				{
					span2[i].GetLayoutRendererId(container, item, ref templateId, metadata);
				}
				ref ISectionModifierRenderer<TView>[] orAddValueRefAlternate = ref CollectionSlimExtensions.GetOrAddValueRefAlternate(ref cache, templateId.ToDictionaryKey());
				return orAddValueRefAlternate ?? (orAddValueRefAlternate = span.ToArray());
			}
			finally
			{
				list.Dispose();
			}
		}

		public static void GetModifiersId(object item, ref ValueSpanBuilder<char> builder)
		{
			InlineList<ISectionModifier> modifiers = default(InlineList<ISectionModifier>);
			try
			{
				Span<ISectionModifier> span = CollectModifiers(item, ref modifiers);
				for (int i = 0; i < span.Length; i++)
				{
					ISectionModifier sectionModifier = span[i];
					if (!sectionModifier.Flags.HasFlag(SectionModifierFlags.Marker))
					{
						builder.AppendCompact(sectionModifier.Id);
					}
				}
			}
			finally
			{
				modifiers.Dispose();
			}
		}

		internal static void CollectModifierRenderers<TView>(object item, ref InlineList<ISectionModifierRenderer<TView>> list, IReadOnlyMetadataContext? metadata) where TView : class
		{
			InlineList<ISectionModifier> modifiers = default(InlineList<ISectionModifier>);
			PooledDictionarySlim<object, int> priorities = new PooledDictionarySlim<object, int>();
			try
			{
				bool flag = false;
				Span<ISectionModifier> span = CollectModifiers(item, ref modifiers);
				for (int i = 0; i < span.Length; i++)
				{
					ISectionModifier sectionModifier = span[i];
					ISectionModifierRenderer<TView> sectionModifierRenderer = sectionModifier.TryGetRenderer<TView>(item, metadata);
					if (sectionModifierRenderer != null)
					{
						list.Add(sectionModifierRenderer);
						if (sectionModifierRenderer is IHasPrioritySectionModifierRenderer hasPrioritySectionModifierRenderer)
						{
							flag = true;
							priorities.GetOrAddValueRef(sectionModifierRenderer) = hasPrioritySectionModifierRenderer.Priority;
						}
						else
						{
							priorities.GetOrAddValueRef(sectionModifierRenderer) = sectionModifier.Priority;
						}
					}
				}
				if (!flag)
				{
					return;
				}
				Span<ISectionModifierRenderer<TView>> span2 = list.Span;
				if (span2.Length > 1)
				{
					span2.Sort(delegate(ISectionModifierRenderer<TView> m1, ISectionModifierRenderer<TView> m2)
					{
						int orAddValueRef = priorities.GetOrAddValueRef(m1);
						int orAddValueRef2 = priorities.GetOrAddValueRef(m2);
						return orAddValueRef2.CompareTo(orAddValueRef);
					});
				}
			}
			finally
			{
				priorities.Dispose();
				modifiers.Dispose();
			}
		}

		internal static Span<ISectionModifier> CollectModifiers(object context, ref InlineList<ISectionModifier> modifiers)
		{
			object current = context;
			Span<int> initialBuffer = stackalloc int[32];
			ValueSpanBuilder<int> valueSpanBuilder = new ValueSpanBuilder<int>(initialBuffer);
			try
			{
				do
				{
					if (!(current is IVisualSection { Modifiers: var modifiers2 }))
					{
						continue;
					}
					ReadOnlySpan<ISectionModifier> readOnlySpan = modifiers2.ReadOnlySpan;
					for (int i = 0; i < readOnlySpan.Length; i++)
					{
						ISectionModifier sectionModifier = readOnlySpan[i];
						int id = sectionModifier.Id;
						if (!valueSpanBuilder.Span.Contains(id))
						{
							valueSpanBuilder.Append(id);
							modifiers.Add(sectionModifier);
						}
					}
				}
				while (MugenExtensions.TryStepNext<ISection>(ref current));
				Span<ISectionModifier> span = modifiers.Span;
				if (span.Length > 1)
				{
					span.Sort((ISectionModifier x1, ISectionModifier x2) => x2.Priority.CompareTo(x1.Priority));
				}
				return span;
			}
			finally
			{
				valueSpanBuilder.Dispose();
			}
		}

		private static ModifierSet Add(this ModifierSet set, ref ISectionModifier modifier)
		{
			return set.Add(modifier);
		}

		private static ModifierSet AddRange(this ModifierSet set, ref ReadOnlySpan<ISectionModifier> modifiers)
		{
			return set.AddRange(modifiers);
		}

		private static ModifierSet Remove(this ModifierSet set, ref ISectionModifier? modifier)
		{
			return set.Remove(modifier);
		}

		private static int FindInsertIndex(ReadOnlySpan<ISectionModifier> source, int priority)
		{
			int num = 0;
			int num2 = source.Length - 1;
			while (num <= num2)
			{
				int num3 = num + num2 >> 1;
				int num4 = priority.CompareTo(source[num3].Priority);
				if (num4 > 0)
				{
					num2 = num3 - 1;
					continue;
				}
				if (num4 < 0)
				{
					num = num3 + 1;
					continue;
				}
				return num3;
			}
			return num;
		}

		public static T WithBackgroundColor<T>(this T section, out BackgroundColorSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IBackgroundColorSectionModifier, BackgroundColorSectionModifier>();
			return section;
		}

		public static T WithBackgroundColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IBackgroundColorSectionModifier, BackgroundColorSectionModifier, BackgroundColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithBorderWidth<T>(this T section, out BorderWidthSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IBorderWidthSectionModifier, BorderWidthSectionModifier>();
			return section;
		}

		public static T WithBorderWidth<T>(this T section, Bindable<float> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IBorderWidthSectionModifier, BorderWidthSectionModifier, BorderWidthImmutableSectionModifier, float>(section, value);
			return section;
		}

		public static T WithBorderColor<T>(this T section, out BorderColorSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IBorderColorSectionModifier, BorderColorSectionModifier>();
			return section;
		}

		public static T WithBorderColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IBorderColorSectionModifier, BorderColorSectionModifier, BorderColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithCornerRadius<T>(this T section, out CornerRadiusSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<ICornerRadiusSectionModifier, CornerRadiusSectionModifier>();
			return section;
		}

		public static T WithCornerRadius<T>(this T section, Bindable<CornerRadius> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<ICornerRadiusSectionModifier, CornerRadiusSectionModifier, CornerRadiusImmutableSectionModifier, CornerRadius>(section, value);
			return section;
		}

		public static T WithElevation<T>(this T section, out ElevationSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IElevationSectionModifier, ElevationSectionModifier>();
			return section;
		}

		public static T WithElevation<T>(this T section, Bindable<float> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IElevationSectionModifier, ElevationSectionModifier, ElevationImmutableSectionModifier, float>(section, value);
			return section;
		}

		public static T WithEnabled<T>(this T section, out EnableSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IEnabledSectionModifier, EnableSectionModifier>();
			return section;
		}

		public static T WithFocus<T>(this T section, out FocusSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IFocusSectionModifier, FocusSectionModifier>();
			return section;
		}

		public static T WithFont<T>(this T section, out FontSectionModifier modifier) where T : class, IVisualSection, ISupportFontStyleSection
		{
			modifier = section.GetOrAddSingleModifier<IFontSectionModifier, FontSectionModifier>();
			return section;
		}

		public static T WithFont<T>(this T section, Bindable<FontSpec> value) where T : class, IVisualSection, ISupportFontStyleSection
		{
			AddValueModifierIgnoreDefaultValue<IFontSectionModifier, FontSectionModifier, FontImmutableSectionModifier, FontSpec>(section, value);
			return section;
		}

		public static T WithGravity<T>(this T section, out GravitySectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IGravitySectionModifier, GravitySectionModifier>();
			return section;
		}

		public static T WithGravity<T>(this T section, Bindable<EnumFlags<GravityFlags>> flags) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IGravitySectionModifier, GravitySectionModifier, GravityImmutableSectionModifier, EnumFlags<GravityFlags>>(section, flags);
			return section;
		}

		public static T WithKeyboardType<T>(this T section, out KeyboardTypeSectionModifier modifier) where T : class, IVisualSection, ITextInputSection
		{
			modifier = section.GetOrAddSingleModifier<IKeyboardTypeSectionModifier, KeyboardTypeSectionModifier>();
			return section;
		}

		public static T WithKeyboardType<T>(this T section, Bindable<KeyboardType?> value) where T : class, IVisualSection, ITextInputSection
		{
			AddValueModifierIgnoreDefaultValue<IKeyboardTypeSectionModifier, KeyboardTypeSectionModifier, KeyboardTypeImmutableSectionModifier, KeyboardType>(section, value);
			return section;
		}

		public static T WithMargin<T>(this T section, out MarginSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IMarginSectionModifier, MarginSectionModifier>();
			return section;
		}

		public static T WithMargin<T>(this T section, Bindable<Thickness> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IMarginSectionModifier, MarginSectionModifier, MarginImmutableSectionModifier, Thickness>(section, value);
			return section;
		}

		public static T WithMaxLines<T>(this T section, out MaxLinesSectionModifier modifier) where T : class, IVisualSection, ITextSectionBase
		{
			modifier = section.GetOrAddSingleModifier<IMaxLinesSectionModifier, MaxLinesSectionModifier>();
			return section;
		}

		public static T WithMaxLines<T>(this T section, Bindable<int> value) where T : class, IVisualSection, ITextSectionBase
		{
			AddValueModifier<IMaxLinesSectionModifier, MaxLinesSectionModifier, MaxLinesImmutableSectionModifier, int>(section, value);
			return section;
		}

		public static T WithAnimateLayoutChanges<T>(this T section, out AnimateLayoutChangesSectionModifier modifier) where T : class, ILayoutSection
		{
			modifier = section.GetOrAddSingleModifier<IAnimateLayoutChangesSectionModifier, AnimateLayoutChangesSectionModifier>();
			return section;
		}

		public static T WithAnimateLayoutChanges<T>(this T section, Bindable<bool> value) where T : class, ILayoutSection
		{
			AddValueModifier<IAnimateLayoutChangesSectionModifier, AnimateLayoutChangesSectionModifier, AnimateLayoutChangesImmutableSectionModifier, bool>(section, value);
			return section;
		}

		public static T WithClipToPadding<T>(this T section, out ClipToPaddingSectionModifier modifier) where T : class, ILayoutSection
		{
			modifier = section.GetOrAddSingleModifier<IClipToPaddingSectionModifier, ClipToPaddingSectionModifier>();
			return section;
		}

		public static T WithClipToPadding<T>(this T section, Bindable<bool> value) where T : class, ILayoutSection
		{
			AddValueModifier<IClipToPaddingSectionModifier, ClipToPaddingSectionModifier, ClipToPaddingImmutableSectionModifier, bool>(section, value);
			return section;
		}

		public static T WithPadding<T>(this T section, out PaddingSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IPaddingSectionModifier, PaddingSectionModifier>();
			return section;
		}

		public static T WithPadding<T>(this T section, Bindable<Thickness> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IPaddingSectionModifier, PaddingSectionModifier, PaddingImmutableSectionModifier, Thickness>(section, value);
			return section;
		}

		public static T WithPlaceholder<T>(this T section, out PlaceholderSectionModifier modifier) where T : class, IVisualSection, ITextInputSection
		{
			modifier = section.GetOrAddSingleModifier<IPlaceholderSectionModifier, PlaceholderSectionModifier>();
			return section;
		}

		public static T WithPlaceholder<T>(this T section, Bindable<FormattedText> value) where T : class, IVisualSection, ITextInputSection
		{
			AddValueModifierIgnoreDefaultValue<IPlaceholderSectionModifier, PlaceholderSectionModifier, PlaceholderImmutableSectionModifier, FormattedText>(section, value);
			return section;
		}

		public static T WithPressed<T>(this T section, out PressedSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IPressedSectionModifier, PressedSectionModifier>();
			return section;
		}

		public static T WithAttachState<T>(this T section, out AttachStateSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IAttachStateSectionModifier, AttachStateSectionModifier>();
			return section;
		}

		public static T WithSize<T>(this T section, out SizeSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<ISizeSectionModifier, SizeSectionModifier>();
			return section;
		}

		public static T WithSize<T>(this T section, Bindable<SizeF> value) where T : class, IVisualSection
		{
			AddValueModifier<ISizeSectionModifier, SizeSectionModifier, SizeImmutableSectionModifier, SizeF>(section, value);
			return section;
		}

		public static T WithSizeLimits<T>(this T section, out SizeLimitsSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<ISizeLimitsSectionModifier, SizeLimitsSectionModifier>();
			return section;
		}

		public static T WithSizeLimits<T>(this T section, Bindable<SizeLimits> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<ISizeLimitsSectionModifier, SizeLimitsSectionModifier, SizeLimitsImmutableSectionModifier, SizeLimits>(section, value);
			return section;
		}

		public static T WithImageStretchMode<T>(this T section, out ImageStretchModeSectionModifier modifier) where T : class, IVisualSection, ISupportImageStretchModeSection
		{
			modifier = section.GetOrAddSingleModifier<IImageStretchModeSectionModifier, ImageStretchModeSectionModifier>();
			return section;
		}

		public static T WithImageStretchMode<T>(this T section, Bindable<ImageStretchMode?> value) where T : class, IVisualSection, ISupportImageStretchModeSection
		{
			AddValueModifierIgnoreDefaultValue<IImageStretchModeSectionModifier, ImageStretchModeSectionModifier, ImageStretchModeImmutableSectionModifier, ImageStretchMode>(section, value);
			return section;
		}

		public static T WithStretch<T>(this T section) where T : class, IVisualSection
		{
			return section.WithOrReplaceModifier(StretchSectionModifier.Instance);
		}

		[OverloadResolutionPriority(1)]
		public static T WithTap<T>(this T section, Disposable<ICompositeCommand> command, object? parameter = null) where T : class, IVisualSection
		{
			AddCommandModifier<ITapSectionModifier, TapImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		public static T WithTap<T>(this T section, out TapSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<ITapSectionModifier, TapSectionModifier>();
			return section;
		}

		public static T WithTap<T>(this T section, Bindable<ICompositeCommand?> command, Bindable<object?> parameter = default(Bindable<object?>)) where T : class, IVisualSection
		{
			AddCommandModifier<ITapSectionModifier, TapSectionModifier, TapImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		[OverloadResolutionPriority(1)]
		public static T WithTapThrough<T>(this T section, Disposable<ICompositeCommand> command, object? parameter = null) where T : class, IVisualSection
		{
			AddCommandModifier<ITapThroughSectionModifier, TapThroughImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		public static T WithTapThrough<T>(this T section, out TapThroughSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<ITapThroughSectionModifier, TapThroughSectionModifier>();
			return section;
		}

		public static T WithTapThrough<T>(this T section, Bindable<ICompositeCommand?> command, Bindable<object?> parameter = default(Bindable<object?>)) where T : class, IVisualSection
		{
			AddCommandModifier<ITapThroughSectionModifier, TapThroughSectionModifier, TapThroughImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		[OverloadResolutionPriority(1)]
		public static T WithLoadMore<T>(this T section, Disposable<ICompositeCommand> command, object? parameter = null) where T : class, ICollectionLayoutSection
		{
			AddCommandModifier<ILoadMoreSectionModifier, LoadMoreImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		public static T WithLoadMore<T>(this T section, out LoadMoreSectionModifier modifier) where T : class, ICollectionLayoutSection
		{
			modifier = section.GetOrAddSingleModifier<ILoadMoreSectionModifier, LoadMoreSectionModifier>();
			return section;
		}

		public static T WithLoadMore<T>(this T section, Bindable<ICompositeCommand?> command, Bindable<object?> parameter = default(Bindable<object?>)) where T : class, ICollectionLayoutSection
		{
			AddCommandModifier<ILoadMoreSectionModifier, LoadMoreSectionModifier, LoadMoreImmutableSectionModifier>(section, command, parameter);
			return section;
		}

		public static T WithRefresh<T>(this T section, out RefreshSectionModifier modifier) where T : class, ILayoutSection
		{
			modifier = section.GetOrAddSingleModifier<IRefreshSectionModifier, RefreshSectionModifier>();
			return section;
		}

		public static T WithRefresh<T>(this T section, Bindable<ICompositeCommand?> command, Bindable<object?> parameter = default(Bindable<object?>), Bindable<bool> isRefreshing = default(Bindable<bool>)) where T : class, ILayoutSection
		{
			if (!command.IsInitialized || (command.IsConstant && command.Constant == null))
			{
				section.RemoveModifiers<IRefreshSectionModifier>();
				return section;
			}
			RefreshSectionModifier orAddSingleModifier = section.GetOrAddSingleModifier<IRefreshSectionModifier, RefreshSectionModifier>();
			if (command.IsConstant)
			{
				if (command.Constant != null)
				{
					if (command.Constant.Metadata.Get(CompositeUIMetadata.ActionInvokerSourceCommand) == null)
					{
						command.Constant.DisposeWith(section, orAddSingleModifier.Name);
					}
					command.Constant.WithActionInvokerSource(section);
				}
				section.WithAppErrorListener();
				orAddSingleModifier.Command = command.Constant;
				if (!isRefreshing.IsInitialized || isRefreshing.IsConstant)
				{
					isRefreshing = command.Constant.Bind(() => (ICompositeCommand c) => c.IsExecuting(), _: false).BusyWithGrace();
				}
			}
			else
			{
				section.BindModifier(command, orAddSingleModifier);
				if (!isRefreshing.IsInitialized || isRefreshing.IsConstant)
				{
					isRefreshing = command.Bind(() => (IHasReadOnlyValue<ICompositeCommand> c) => c.Value.IsExecuting(), _: false).BusyWithGrace();
				}
			}
			return section.BindModifier<T, object, RefreshSectionModifier>(parameter, orAddSingleModifier, delegate(object? v, RefreshSectionModifier s)
			{
				s.Parameter = v;
			}, "WithRefreshParameter").BindModifier(isRefreshing, orAddSingleModifier, delegate(bool v, RefreshSectionModifier s)
			{
				s.Value = v;
			}, "WithRefreshValue");
		}

		public static T WithTextAlignment<T>(this T section, out TextAlignmentSectionModifier modifier) where T : class, IVisualSection, ITextSectionBase
		{
			modifier = section.GetOrAddSingleModifier<ITextAlignmentSectionModifier, TextAlignmentSectionModifier>();
			return section;
		}

		public static T WithTextAlignment<T>(this T section, Bindable<TextAlignment?> value) where T : class, IVisualSection, ITextSectionBase
		{
			AddValueModifierIgnoreDefaultValue<ITextAlignmentSectionModifier, TextAlignmentSectionModifier, TextAlignmentImmutableSectionModifier, TextAlignment>(section, value);
			return section;
		}

		public static T WithAlignment<T>(this T section, out AlignmentSectionModifier modifier) where T : class, IVisualSection, ISupportAlignmentSection
		{
			modifier = section.GetOrAddSingleModifier<IAlignmentSectionModifier, AlignmentSectionModifier>();
			return section;
		}

		public static T WithAlignment<T>(this T section, Bindable<Alignment?> value) where T : class, IVisualSection, ISupportAlignmentSection
		{
			AddValueModifierIgnoreDefaultValue<IAlignmentSectionModifier, AlignmentSectionModifier, AlignmentImmutableSectionModifier, Alignment>(section, value);
			return section;
		}

		public static T WithOrientation<T>(this T section, out OrientationSectionModifier modifier) where T : class, IVisualSection, ISupportOrientationSection
		{
			modifier = section.GetOrAddSingleModifier<IOrientationSectionModifier, OrientationSectionModifier>();
			return section;
		}

		public static T WithOrientation<T>(this T section, Bindable<OrientationType?> value) where T : class, IVisualSection, ISupportOrientationSection
		{
			AddValueModifierIgnoreDefaultValue<IOrientationSectionModifier, OrientationSectionModifier, OrientationImmutableSectionModifier, OrientationType>(section, value);
			return section;
		}

		public static T WithTextColor<T>(this T section, out TextColorSectionModifier modifier) where T : class, IVisualSection, ISupportTextColorSection
		{
			modifier = section.GetOrAddSingleModifier<ITextColorSectionModifier, TextColorSectionModifier>();
			return section;
		}

		public static T WithTextColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ISupportTextColorSection
		{
			AddValueModifier<ITextColorSectionModifier, TextColorSectionModifier, TextColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithTintColor<T>(this T section, out TintColorSectionModifier modifier) where T : class, IVisualSection, ISupportTintColorSection
		{
			modifier = section.GetOrAddSingleModifier<ITintColorSectionModifier, TintColorSectionModifier>();
			return section;
		}

		public static T WithTintColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ISupportTintColorSection
		{
			AddValueModifierIgnoreDefaultValue<ITintColorSectionModifier, TintColorSectionModifier, TintColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithTrackTintColor<T>(this T section, out TrackTintColorSectionModifier modifier) where T : class, IVisualSection, ISupportTrackTintColorSection
		{
			modifier = section.GetOrAddSingleModifier<ITrackTintColorSectionModifier, TrackTintColorSectionModifier>();
			return section;
		}

		public static T WithTrackTintColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ISupportTrackTintColorSection
		{
			AddValueModifier<ITrackTintColorSectionModifier, TrackTintColorSectionModifier, TrackTintColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithThumbTintColor<T>(this T section, out ThumbTintColorSectionModifier modifier) where T : class, IVisualSection, ISupportThumbTintColorSection
		{
			modifier = section.GetOrAddSingleModifier<IThumbTintColorSectionModifier, ThumbTintColorSectionModifier>();
			return section;
		}

		public static T WithThumbTintColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ISupportThumbTintColorSection
		{
			AddValueModifierIgnoreDefaultValue<IThumbTintColorSectionModifier, ThumbTintColorSectionModifier, ThumbTintColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithVisibility<T>(this T section, out VisibilitySectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IVisibilitySectionModifier, VisibilitySectionModifier>();
			return section;
		}

		public static T WithVisibility<T>(this T section, Bindable<SectionVisibility> value) where T : class, IVisualSection
		{
			if (!value.IsInitialized || (value.IsConstant && value.Constant == null))
			{
				section.RemoveModifiers<IVisibilitySectionModifier>();
				return section;
			}
			return section.BindModifier(value, section.GetOrAddSingleModifier<IVisibilitySectionModifier, VisibilitySectionModifier>());
		}

		public static T WithVisibility<T>(this T section, Bindable<bool> value) where T : class, IVisualSection
		{
			return section.WithVisibility(value.Select((Func<bool, SectionVisibility>)((bool b) => b)));
		}

		public static T WithCursorColor<T>(this T section, out CursorColorSectionModifier modifier) where T : class, IVisualSection, ITextInputSection
		{
			modifier = section.GetOrAddSingleModifier<ICursorColorSectionModifier, CursorColorSectionModifier>();
			return section;
		}

		public static T WithCursorColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ITextInputSection
		{
			AddValueModifier<ICursorColorSectionModifier, CursorColorSectionModifier, CursorColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithPlaceholderColor<T>(this T section, out PlaceholderColorSectionModifier modifier) where T : class, IVisualSection, ITextInputSection
		{
			modifier = section.GetOrAddSingleModifier<IPlaceholderColorSectionModifier, PlaceholderColorSectionModifier>();
			return section;
		}

		public static T WithPlaceholderColor<T>(this T section, Bindable<Color> value) where T : class, IVisualSection, ITextInputSection
		{
			AddValueModifier<IPlaceholderColorSectionModifier, PlaceholderColorSectionModifier, PlaceholderColorImmutableSectionModifier, Color>(section, value);
			return section;
		}

		public static T WithZIndex<T>(this T section, out ZIndexSectionModifier modifier) where T : class, IVisualSection
		{
			modifier = section.GetOrAddSingleModifier<IZIndexSectionModifier, ZIndexSectionModifier>();
			return section;
		}

		public static T WithZIndex<T>(this T section, Bindable<float> value) where T : class, IVisualSection
		{
			AddValueModifierIgnoreDefaultValue<IZIndexSectionModifier, ZIndexSectionModifier, ZIndexImmutableSectionModifier, float>(section, value);
			return section;
		}

		public static T AsPrimaryToolbar<T>(this T section, ToolbarType type) where T : class, IVisualSection
		{
			return section.AsToolbarItem(type, ToolbarSectionFlags.Toolbar | ToolbarSectionFlags.Primary);
		}

		public static T AsToolbar<T>(this T section, ToolbarType type, EnumFlags<ToolbarSectionFlags> flags = default(EnumFlags<ToolbarSectionFlags>)) where T : class, IVisualSection
		{
			return section.AsToolbarItem(type, (FlagsEnumBase<ToolbarSectionFlags, int>?)ToolbarSectionFlags.Toolbar | flags);
		}

		public static T AsToolbarMenuItem<T>(this T section, Bindable<FormattedText> title, ToolbarType type, EnumFlags<ToolbarSectionFlags> flags = default(EnumFlags<ToolbarSectionFlags>)) where T : class, IVisualSection
		{
			return section.WithOrReplaceModifier<T, IToolbarItemSectionModifier>(new ToolbarMenuSectionModifier(title, type, flags));
		}

		public static T AsToolbarItem<T>(this T section, ToolbarType type, EnumFlags<ToolbarSectionFlags> flags) where T : class, IVisualSection
		{
			return section.WithOrReplaceModifier<T, IToolbarItemSectionModifier>(ToolbarItemSectionModifier.Get(type, flags));
		}

		public static T WithScrollReset<T>(this T section, out ResetScrollSectionModifier modifier) where T : class, ISupportScrollSection
		{
			modifier = section.GetOrAddModifier<ResetScrollSectionModifier>();
			return section;
		}

		public static T WithScrollReset<T>(this T section, Bindable<int> trigger, Bindable<bool> animate = default(Bindable<bool>)) where T : class, ISupportScrollSection
		{
			if (!trigger.IsInitialized && !animate.IsInitialized)
			{
				return section;
			}
			ResetScrollSectionModifier orAddModifier = section.GetOrAddModifier<ResetScrollSectionModifier>();
			return section.BindModifier(trigger, orAddModifier).BindModifier(animate, orAddModifier, delegate(bool v, ResetScrollSectionModifier s)
			{
				s.Animate = v;
			}, "WithScrollResetAnimate");
		}

		public static T WithSectionPriority<T>(this T section, int priority) where T : class, IVisualSection
		{
			return section.WithOrReplaceModifier((PriorityImmutableSectionModifier)CacheableValueImmutableSectionModifierBase<PriorityImmutableSectionModifier, IPrioritySectionModifier, int, int>.Get(priority));
		}

		public static T WithDisposeToken<T>(this T section, ActionToken token, string? id = null) where T : class, IVisualSection
		{
			token.DisposeWith(section, id);
			return section;
		}

		public static T WithAction<T, TValue>(this T section, Bindable<TValue> bindable, Action<T, TValue> action) where T : class, IVisualSection
		{
			Should.NotBeNull(action, "action");
			section.Bind().Combine<T, TValue, Action<T, TValue>, object>(bindable, action.Bind(), delegate(T s, TValue v, Action<T, TValue> a)
			{
				a(s, v);
				return (object)null;
			}).WithAppErrorHandler(section)
				.Subscribe()
				.DisposeWith(section);
			return section;
		}

		public static T WithText<T>(this T section, FormattedText value) where T : class, ISupportFormattedTextSection
		{
			section.Text = value;
			return section;
		}

		public static T WithText<T>(this T section, Bindable<FormattedText> value) where T : class, ISupportFormattedTextSection
		{
			return section.Bind(value, section, delegate(FormattedText v, T s)
			{
				s.Text = v;
			}, "Text");
		}

		public static T WithText<T>(this T section, Bindable<string?> value, bool twoWay = true) where T : class, ITextInputSection
		{
			if (twoWay)
			{
				section.BTarget(_bindCache9 ?? (_bindCache9 = (ITextInputSection c) => c.Text)).To(value, (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
				{
					c.TwoWay();
				}, (IReadOnlyMetadataContext?)null);
				return section;
			}
			return section.Bind<T, string, T>(value, section, delegate(string? v, T s)
			{
				s.Text = v;
			}, "Text");
		}

		public static T WithValue<T, TValue>(this T section, Bindable<TValue> value, bool twoWay = true) where T : class, IValueInputSection<TValue>
		{
			if (twoWay)
			{
				section.BindValueTarget().To(value, (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
				{
					c.TwoWay();
				}, (IReadOnlyMetadataContext?)null);
				return section;
			}
			return section.Bind(value, section, delegate(TValue? v, T s)
			{
				s.Value = v;
			}, "Value");
		}

		public static T WithIcon<T>(this T section, Bindable<ImageSource> value) where T : class, ISupportIconSection
		{
			return section.Bind(value, section, delegate(ImageSource v, T s)
			{
				s.Icon = v;
			}, "Icon");
		}

		public static T WithSource<T>(this T section, Bindable<ImageSource> value) where T : class, IImageSection
		{
			return section.Bind(value, section, delegate(ImageSource v, T s)
			{
				s.Source = v;
			}, "Source");
		}

		public static T WithMax<T, TNumber>(this T section, Bindable<TNumber> value) where T : class, ISupportMaxValueSection<TNumber> where TNumber : INumber<TNumber>
		{
			return section.Bind(value, section, delegate(TNumber? v, T s)
			{
				s.Max = v;
			}, "Max");
		}

		public static T WithMin<T, TNumber>(this T section, Bindable<TNumber> value) where T : class, ISupportMinValueSection<TNumber> where TNumber : INumber<TNumber>
		{
			return section.Bind(value, section, delegate(TNumber? v, T s)
			{
				s.Min = v;
			}, "Min");
		}

		public static T WithFormat<T>(this T section, Bindable<string?> format, Bindable<CultureInfo> cultureInfo) where T : class, ISupportFormatSection
		{
			if (!format.IsInitialized && !cultureInfo.IsInitialized)
			{
				return section;
			}
			return section.Bind(cultureInfo, section, delegate(CultureInfo? v, T s)
			{
				s.CultureInfo = v;
			}, "CultureInfo").Bind<T, string, T>(format, section, delegate(string? v, T s)
			{
				s.Format = v;
			}, "Format");
		}

		public static T WithAppErrorListener<T>(this T section) where T : class, IVisualSection
		{
			if (!IMugenService<IMugenApplication>.Instance.GetDisposeTokens(section, "#@eal").IsEmptyWithDispose())
			{
				return section;
			}
			section.B(_bindCache1 ?? (_bindCache1 = (IVisualSection s) => s.RootSection<IAppErrorsAwareSection>().Section)).UseLatest<IAppErrorsAwareSection, T>(section, (IAppErrorsAwareSection errors, T s) => (errors != null && errors.Register(s, null)) ? ActionToken.FromDelegate(delegate(object? obj, object? section2)
			{
				((IAppErrorsAwareSection)obj).Unregister(section2, null);
			}, errors, s) : default(ActionToken)).Subscribe()
				.DisposeWith(section, "#@eal");
			return section;
		}

		public static T WithValidator<T>(this T section, out IValidator validator) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			(IVisualSection, ValidatorSectionModifier, bool) state = (section, null, false);
			section.UpdateModifiers<(IVisualSection, ValidatorSectionModifier, bool)>(ref state, delegate(ModifierSet set, ref (IVisualSection section, ValidatorSectionModifier? item, bool isAdded) s)
			{
				ValidatorSectionModifier validatorSectionModifier = set.TryGet<ValidatorSectionModifier>();
				if (validatorSectionModifier == null)
				{
					ref ValidatorSectionModifier item = ref s.item;
					if (item == null)
					{
						item = new ValidatorSectionModifier(s.section);
					}
					s.isAdded = true;
					return set.Add(s.item);
				}
				if (s.isAdded)
				{
					s.item?.Dispose();
				}
				s.item = validatorSectionModifier;
				s.isAdded = false;
				return set;
			});
			validator = state.Item2.Service;
			if (state.Item3)
			{
				section.B(_bindCache2 ?? (_bindCache2 = (IVisualSection s) => s.RootSection<IValidationErrorsAwareSection>().Section)).UseLatest<IValidationErrorsAwareSection, IValidator>(validator, (IValidationErrorsAwareSection s, IValidator v) => (s == null || !s.AddChildValidator(v)) ? default(ActionToken) : ActionToken.FromDelegate(delegate(object? obj, object? obj2)
				{
					((IValidationErrorsAwareSection)obj).RemoveChildValidator((IValidator)obj2);
				}, s, v)).Subscribe()
					.DisposeWith(section);
			}
			return section;
		}

		public static T WithValidationRule<T, TError>(this T section, Bindable<bool> isValid, Bindable<TError> errorBindable, string member = "Value") where T : class, IVisualSection where TError : class
		{
			section.WithValidator(out IValidator validator);
			validator.WithValidationRule(isValid, errorBindable, section, member);
			return section;
		}

		public static T WithValidationRule<T, TError>(this T section, Bindable<TError?> errorBindable, string member = "Value") where T : class, IVisualSection where TError : class
		{
			section.WithValidator(out IValidator validator);
			validator.WithValidationRule(errorBindable, section, member);
			return section;
		}

		public static T WithChild<T>(this T section, IVisualSection child) where T : class, IEditableCompositeLayoutSection
		{
			Should.NotBeNull(section, "section");
			section.Add(child);
			return section;
		}

		public static T WithRootViewComponent<T>(this T section, IComponent<IView> component) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			Should.NotBeNull(component, "component");
			return section.WithRootViewHandler(component, delegate(IView v, IComponent<IView> c)
			{
				v.Components.TryAdd(c);
			}, delegate(IView v, IComponent<IView> c)
			{
				v.Components.Remove(c);
			});
		}

		public static T WithRootViewHandler<T, TState>(this T section, TState state, Action<IView, TState> onAdded, Action<IView, TState> onRemoved) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			Should.NotBeNull(onAdded, "onAdded");
			Should.NotBeNull(onRemoved, "onRemoved");
			section.B(_bindCache4 ?? (_bindCache4 = (IVisualSection s) => s.Shell.RootSection<IViewsAwareSection>().Section)).UseLatest<IViewsAwareSection, (Action<IView, TState>, Action<IView, TState>, TState)>((onAdded, onRemoved, state), (IViewsAwareSection sections, (Action<IView, TState> onAdded, Action<IView, TState> onRemoved, TState state) st) => sections?.Views.Configure().WithState(st.state).TrackItems(st.onAdded, st.onRemoved)
				.Bind()
				.AsActionToken() ?? default(ActionToken)).Subscribe()
				.DisposeWith(section);
			return section;
		}

		public static T TapNativeView<T>(this T section, out Bindable<object?> nativeView) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			nativeView = Bindable.FromValue(section.GetOrAddModifier<NativeViewSectionModifier>());
			return section;
		}

		public static T TapSystemInsets<T>(this T section, SystemInsetType type, out Bindable<Thickness> value, bool relative = true) where T : class, IVisualSection
		{
			value = section.SystemInsets(type, relative);
			return section;
		}

		public static T TapLayoutDirection<T>(this T section, out Bindable<LayoutDirType> value, bool relative = true) where T : class, IVisualSection
		{
			value = section.LayoutDirection(relative);
			return section;
		}

		public static T TapScreenMetrics<T>(this T section, out Bindable<ScreenMetrics> value, bool relative = true) where T : class, IVisualSection
		{
			value = section.ScreenMetrics(relative);
			return section;
		}

		public static T ShowWhen<T>(this T section, Bindable<bool> bindable) where T : class, IVisualSection
		{
			return section.WithVisibility(bindable);
		}

		public static T EnableWhen<T>(this T section, Bindable<bool> bindable) where T : class, IVisualSection
		{
			if (!bindable.IsInitialized)
			{
				return section;
			}
			EnableSectionModifier modifier;
			return section.WithEnabled(out modifier).BindModifier(bindable, modifier);
		}

		public static T HideWhen<T>(this T section, Bindable<bool> bindable) where T : class, IVisualSection
		{
			return section.WithVisibility(bindable.Not());
		}

		public static T HideWhenEmpty<T>(this T section) where T : class, ICompositeLayoutSection
		{
			return section.ShowWhen(section.B(_bindCache7 ?? (_bindCache7 = (ICompositeLayoutSection s) => s.HasItems)));
		}

		public static T ShowKeyboardWhenAttached<T>(this T section, bool once) where T : class, ITextInputSection
		{
			section.WithAttachState(out AttachStateSectionModifier modifier);
			return section.ShowKeyboardWhen(modifier.BindValue(), once);
		}

		public static T ShowKeyboardWhen<T>(this T section, Bindable<bool> bindable, bool once) where T : class, ITextInputSection
		{
			section.WithFocus(out FocusSectionModifier modifier);
			if (once)
			{
				modifier.BindTarget().ToAction(bindable, MugenMvvm.Bindings.Bind.Binding(), delegate(FocusSectionModifier m, bool isAttached, IBinding bind)
				{
					if (isAttached)
					{
						m.Value = true;
						bind.Dispose();
					}
				});
			}
			else
			{
				modifier.BindValueTarget().To(bindable, (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			return section;
		}

		public static T TapValue<T>(this T section, Bindable<T> bindable, out IHasReadOnlyValue<T?> value) where T : class, IVisualSection
		{
			value = bindable.ToValue(out var disposeToken);
			return section.WithDisposeToken(disposeToken);
		}

		public static T Bind<T, TValue>(this T section, Bindable<TValue> bindable, Action<TValue?, T> setter, string? id = null) where T : class, IVisualSection
		{
			return section.Bind(bindable, section, setter, id);
		}

		public static T Bind<T, TValue, TState>(this T section, Bindable<TValue> bindable, TState state, Action<TValue?, TState> setter, string? id = null) where T : class, IVisualSection
		{
			Should.NotBeNull(section, "section");
			if (Bindable.TrySetConstant<TValue, TState>(bindable, state, setter, null))
			{
				return section;
			}
			bindable.BindSafe(section, state, setter).DisposeWith(section, id);
			return section;
		}

		public static T BindModifier<T, TValue, TModifier>(this T section, Bindable<TValue> bindable, TModifier modifier, string? id = null) where T : class, IVisualSection where TModifier : class, ISectionModifier, IHasDisposeCallback, IFastBindableListener<TValue>
		{
			Should.NotBeNull(section, "section");
			if (!bindable.IsInitialized)
			{
				return section;
			}
			bindable.WithAppErrorHandler(section).Bind(modifier).DisposeWith(modifier, id ?? modifier.Name);
			return section;
		}

		public static T BindModifier<T, TValue, TModifier>(this T section, Bindable<TValue> bindable, TModifier modifier, Action<TValue?, TModifier> setter, string? id = null) where T : class, IVisualSection where TModifier : class, ISectionModifier, IHasDisposeCallback
		{
			Should.NotBeNull(section, "section");
			if (Bindable.TrySetConstant<TValue, TModifier>(bindable, modifier, setter, null))
			{
				return section;
			}
			bindable.BindSafe(section, modifier, setter).DisposeWith(modifier, id ?? modifier.Name);
			return section;
		}

		public static void AddValueModifierIgnoreDefaultValue<TModifierBase, TModifier, TImmutableModifier, TValue>(IVisualSection section, Bindable<TValue?> value) where TModifierBase : class, IReadOnlyValueSectionModifier<TValue> where TModifier : class, TModifierBase, IValueSectionModifier<TValue>, IHasDisposeCallback, IBindableListener<TValue>, new() where TImmutableModifier : class, TModifierBase, IImmutableValueSectionModifier<TValue> where TValue : IEquatable<TValue>
		{
			if (!value.IsInitialized || (value.IsConstant && EqualityComparer<TValue>.Default.Equals(default(TValue), value.Constant)))
			{
				section.RemoveModifiers<TModifierBase>();
			}
			else
			{
				AddValueModifierCommon<TModifierBase, TModifier, TImmutableModifier, TValue>(section, value);
			}
		}

		public static void AddValueModifier<TModifierBase, TModifier, TImmutableModifier, TValue>(IVisualSection section, Bindable<TValue?> value) where TModifierBase : class, IReadOnlyValueSectionModifier<TValue> where TModifier : class, TModifierBase, IValueSectionModifier<TValue>, IHasDisposeCallback, IBindableListener<TValue>, new() where TImmutableModifier : class, TModifierBase, IImmutableValueSectionModifier<TValue>
		{
			if (!value.IsInitialized)
			{
				section.RemoveModifiers<TModifierBase>();
			}
			else
			{
				AddValueModifierCommon<TModifierBase, TModifier, TImmutableModifier, TValue>(section, value);
			}
		}

		public static void AddCommandModifier<TModifierBase, TModifier, TImmutableModifier>(IVisualSection section, Bindable<ICompositeCommand?> command, Bindable<object?> parameter) where TModifierBase : class, ICommandSectionModifier where TModifier : CommandSectionModifierBase<TModifierBase>, TModifierBase, IHasDisposeCallback, new() where TImmutableModifier : class, TModifierBase, IImmutableCommandSectionModifier
		{
			if (!command.IsInitialized || (command.IsConstant && command.Constant == null))
			{
				section.RemoveModifiers<TModifierBase>();
				return;
			}
			if (command.IsConstant && parameter.IsConstant)
			{
				CompositeUIExtensions.AddCommandModifier<TModifierBase, TImmutableModifier>(section, Disposable.Get(command.Constant, command.Constant.Metadata.Get(CompositeUIMetadata.ActionInvokerSourceCommand) == null), parameter.Constant);
				return;
			}
			TModifier orAddSingleModifier = section.GetOrAddSingleModifier<TModifierBase, TModifier>();
			if (command.IsConstant)
			{
				if (command.Constant != null)
				{
					if (command.Constant.Metadata.Get(CompositeUIMetadata.ActionInvokerSourceCommand) == null)
					{
						command.Constant.DisposeWith(section, orAddSingleModifier.Name);
					}
					command.Constant.WithActionInvokerSource(section);
				}
				section.WithAppErrorListener();
				orAddSingleModifier.Command = command.Constant;
			}
			else
			{
				section.BindModifier(command, orAddSingleModifier);
			}
			section.BindModifier<IVisualSection, object, TModifier>(parameter, orAddSingleModifier, delegate(object? v, TModifier s)
			{
				s.Parameter = v;
			}, orAddSingleModifier.Name + "Parameter");
		}

		public static void AddCommandModifier<TModifierBase, TImmutableModifier>(IVisualSection section, Disposable<ICompositeCommand> command, object? parameter) where TModifierBase : class, ICommandSectionModifier where TImmutableModifier : class, TModifierBase, IImmutableCommandSectionModifier
		{
			IImmutableCommandSectionModifier immutableCommandSectionModifier = TImmutableModifier.Get(command.Target, parameter);
			if (command.IsDisposable)
			{
				command.Target.DisposeWith(section, immutableCommandSectionModifier.Name);
			}
			command.Target.WithActionInvokerSource(section);
			section.WithAppErrorListener().WithOrReplaceModifier<IVisualSection, TModifierBase>(immutableCommandSectionModifier);
		}

		private static void AddValueModifierCommon<TModifierBase, TModifier, TImmutableModifier, TValue>(IVisualSection section, Bindable<TValue?> value) where TModifierBase : class, IReadOnlyValueSectionModifier<TValue> where TModifier : class, TModifierBase, IValueSectionModifier<TValue>, IHasDisposeCallback, IBindableListener<TValue>, new() where TImmutableModifier : class, TModifierBase, IImmutableValueSectionModifier<TValue>
		{
			if (value.IsConstant)
			{
				section.WithOrReplaceModifier<IVisualSection, TModifierBase>(TImmutableModifier.Get(value.Constant));
				return;
			}
			TModifier orAddSingleModifier = section.GetOrAddSingleModifier<TModifierBase, TModifier>();
			value.WithAppErrorHandler(section).Bind(orAddSingleModifier).DisposeWith(section, orAddSingleModifier.Name);
		}

		public static T WithEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => EqualityComparer<TValue>.Default.Equals(v, vc)), errorBindable, member);
		}

		public static T WithNotEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => !EqualityComparer<TValue>.Default.Equals(v, vc)), errorBindable, member);
		}

		public static T WithGreaterValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => Comparer<TValue>.Default.Compare(v, vc) > 0), errorBindable, member);
		}

		public static T WithGreaterOrEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => Comparer<TValue>.Default.Compare(v, vc) >= 0), errorBindable, member);
		}

		public static T WithLessValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => Comparer<TValue>.Default.Compare(v, vc) < 0), errorBindable, member);
		}

		public static T WithLessOrEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, bool>(value, (TValue v, TValue vc) => Comparer<TValue>.Default.Compare(v, vc) <= 0), errorBindable, member);
		}

		public static T WithBetweenInclusiveValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, TValue, bool>(min, max, (TValue v, TValue a, TValue b) => Comparer<TValue>.Default.Compare(v, a) >= 0 && Comparer<TValue>.Default.Compare(v, b) <= 0), errorBindable, member);
		}

		public static T WithBetweenExclusiveValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, TValue, TValue, bool>(min, max, (TValue v, TValue a, TValue b) => Comparer<TValue>.Default.Compare(v, a) > 0 && Comparer<TValue>.Default.Compare(v, b) < 0), errorBindable, member);
		}

		public static T WithMinValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithGreaterOrEqualValidationRule(min, errorBindable, member);
		}

		public static T WithMaxValidationRule<T, TValue, TError>(this T section, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TValue : IComparable<TValue> where TError : class
		{
			return section.WithLessOrEqualValidationRule(max, errorBindable, member);
		}

		public static T WithMinLengthValidationRule<T, TError>(this T section, Bindable<int> min, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, int, bool>(min, (string v, int m) => (v ?? string.Empty).Length >= m), errorBindable, member);
		}

		public static T WithMaxLengthValidationRule<T, TError>(this T section, Bindable<int> max, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, int, bool>(max, (string v, int m) => (v ?? string.Empty).Length <= m), errorBindable, member);
		}

		public static T WithLengthRangeValidationRule<T, TError>(this T section, Bindable<int> min, Bindable<int> max, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, int, int, bool>(min, max, delegate(string v, int a, int b)
			{
				int length = (v ?? string.Empty).Length;
				return length >= a && length <= b;
			}), errorBindable, member);
		}

		public static T WithContainsValidationRule<T, TError>(this T section, Bindable<string> substring, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, string, bool>(substring, (string v, string s) => (v ?? string.Empty).Contains(s)), errorBindable, member);
		}

		public static T WithStartsWithValidationRule<T, TError>(this T section, Bindable<string> prefix, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, string, bool>(prefix, (string v, string p) => (v ?? string.Empty).StartsWith(p)), errorBindable, member);
		}

		public static T WithEndsWithValidationRule<T, TError>(this T section, Bindable<string> suffix, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, string, bool>(suffix, (string v, string s) => (v ?? string.Empty).EndsWith(s)), errorBindable, member);
		}

		public static T WithRegexValidationRule<T, TError>(this T section, Bindable<Regex> regex, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<string, Regex, bool>(regex, (string v, Regex rx) => string.IsNullOrEmpty(v) || rx.IsMatch(v)), errorBindable, member);
		}

		public static T WithUrlValidationRule<T, TError>(this T section, Bindable<bool> requireAbsolute, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			Uri result;
			return section.WithValidationRule(section.BindValue().Combine<string, bool, bool>(requireAbsolute, (string v, bool abs) => string.IsNullOrEmpty(v) || Uri.TryCreate(v, abs ? UriKind.Absolute : UriKind.RelativeOrAbsolute, out result)), errorBindable, member);
		}

		public static T WithInSetValidationRule<T, TValue, TError>(this T section, Bindable<IReadOnlyCollection<TValue>> set, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, IReadOnlyCollection<TValue>, bool>(set, (TValue v, IReadOnlyCollection<TValue> s) => s.Contains(v)), errorBindable, member);
		}

		public static T WithNotInSetValidationRule<T, TValue, TError>(this T section, Bindable<IReadOnlyCollection<TValue>> set, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine<TValue, IReadOnlyCollection<TValue>, bool>(set, (TValue v, IReadOnlyCollection<TValue> s) => !s.Contains(v)), errorBindable, member);
		}

		public static T WithNotDefaultHiddenValidationRule<T, TValue, TError>(this T section, Bindable<TError> errorBindable, string member = "-", TValue? infer = default(TValue?)) where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithNotDefaultValidationRule(errorBindable, member, infer);
		}

		public static T WithNotNullValidationRule<T, TValue, TError>(this T section, Bindable<TError> errorBindable, string member = "Value", TValue? infer = null) where T : class, IValueInputSection<TValue?> where TValue : class? where TError : class
		{
			return section.WithValidationRule(from v in section.BindValue()
				select v != null, errorBindable, member);
		}

		public static T WithNotNullValidationRule<T, TValue, TError>(this T section, Bindable<TError> errorBindable, string member = "Value", bool _ = false, TValue? infer = null) where T : class, IValueInputSection<TValue?> where TValue : struct where TError : class
		{
			return section.WithValidationRule(from v in section.BindValue()
				select v.HasValue, errorBindable, member);
		}

		public static T WithNotDefaultValidationRule<T, TValue, TError>(this T section, Bindable<TError> errorBindable, string member = "Value", TValue? infer = default(TValue?)) where T : class, IValueInputSection<TValue?> where TError : class
		{
			return section.WithValidationRule(from v in section.BindValue()
				select !EqualityComparer<TValue>.Default.Equals(v, default(TValue)), errorBindable, member);
		}

		public static T WithNotNullOrWhiteSpaceHiddenValidationRule<T>(this T section) where T : class, IValueInputSection<string?>
		{
			return section.WithNotNullOrWhiteSpaceValidationRule(default(Bindable<object>), "-");
		}

		public static T WithNotNullOrEmptyValidationRule<T, TError>(this T section, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(from v in section.BindValue()
				select !string.IsNullOrEmpty(v), errorBindable, member);
		}

		public static T WithNotNullOrWhiteSpaceValidationRule<T, TError>(this T section, Bindable<TError> errorBindable, string member = "Value") where T : class, IValueInputSection<string?> where TError : class
		{
			return section.WithValidationRule(from v in section.BindValue()
				select !string.IsNullOrWhiteSpace(v), errorBindable, member);
		}

		public static T WithGreaterValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(value, (TValue? v, TValue vc) => !v.HasValue || Comparer<TValue>.Default.Compare(v.Value, vc) > 0), errorBindable, member);
		}

		public static T WithGreaterOrEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(value, (TValue? v, TValue vc) => !v.HasValue || Comparer<TValue>.Default.Compare(v.Value, vc) >= 0), errorBindable, member);
		}

		public static T WithLessValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(value, (TValue? v, TValue vc) => !v.HasValue || Comparer<TValue>.Default.Compare(v.Value, vc) < 0), errorBindable, member);
		}

		public static T WithLessOrEqualValidationRule<T, TValue, TError>(this T section, Bindable<TValue> value, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(value, (TValue? v, TValue vc) => !v.HasValue || Comparer<TValue>.Default.Compare(v.Value, vc) <= 0), errorBindable, member);
		}

		public static T WithBetweenInclusiveValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(min, max, (TValue? v, TValue a, TValue b) => !v.HasValue || (Comparer<TValue>.Default.Compare(v.Value, a) >= 0 && Comparer<TValue>.Default.Compare(v.Value, b) <= 0)), errorBindable, member);
		}

		public static T WithBetweenExclusiveValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithValidationRule(section.BindValue().Combine(min, max, (TValue? v, TValue a, TValue b) => !v.HasValue || (Comparer<TValue>.Default.Compare(v.Value, a) > 0 && Comparer<TValue>.Default.Compare(v.Value, b) < 0)), errorBindable, member);
		}

		public static T WithMinValidationRule<T, TValue, TError>(this T section, Bindable<TValue> min, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithGreaterOrEqualValidationRule(min, errorBindable, member, _);
		}

		public static T WithMaxValidationRule<T, TValue, TError>(this T section, Bindable<TValue> max, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : class, IValueInputSection<TValue?> where TValue : struct, IComparable<TValue> where TError : class
		{
			return section.WithLessOrEqualValidationRule(max, errorBindable, member, _);
		}

		public static TextInputSectionBase<T> WithNotDefaultHiddenValidationRule<T>(this TextInputSectionBase<T> section)
		{
			return section.WithNotDefaultValidationRule(default(Bindable<object>), "-");
		}

		public static TextInputSectionBase<T> WithNotNullValidationRule<T, TError>(this TextInputSectionBase<T> section, Bindable<TError> errorBindable, string member = "Value") where T : class? where TError : class
		{
			return section.WithNotNullValidationRule<TextInputSectionBase<T>, T, TError>(errorBindable, member);
		}

		public static TextInputSectionBase<T?> WithNotNullValidationRule<T, TError>(this TextInputSectionBase<T?> section, Bindable<TError> errorBindable, string member = "Value", bool _ = false) where T : struct where TError : class
		{
			return section.WithNotNullValidationRule<TextInputSectionBase<T?>, T, TError>(errorBindable, member);
		}

		public static TextInputSectionBase<T> WithNotDefaultValidationRule<T, TError>(this TextInputSectionBase<T> section, Bindable<TError> errorBindable, string member = "Value") where TError : class
		{
			return section.WithNotDefaultValidationRule(errorBindable, member, default(T));
		}

		public static IReadOnlyObservableCollection<ISection> BindSections<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration) where T : class, ISection
		{
			return configuration.BindTyped<ISection>();
		}

		public static ICompositeSection ToCompositeSection<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, bool disposeSections) where T : class, ISection
		{
			return configuration.BindTyped<ISection>().ToCompositeSection(disposeSections);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<IVisualSection, UnitRef> ToToolbarMenuItems<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, ToolbarType type, Bindable<int> limit, IVisualSection moreSection, out IReadOnlyObservableCollection<IVisualSection> hiddenItems) where T : class, ISection
		{
			return configuration.ToToolbarMenuItems(type, limit, Disposable.Get(moreSection), out hiddenItems);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<IVisualSection, UnitRef> ToToolbarMenuItems<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, ToolbarType type, Bindable<int> limit, Disposable<IVisualSection> moreSection, out IReadOnlyObservableCollection<IVisualSection> hiddenItems) where T : class, ISection
		{
			Should.NotBeNull(type, "type");
			Should.NotBeNull(moreSection.Target, "moreSection");
			Should.BeValid(limit.IsInitialized, "limit");
			ToolbarMenuItemsClosure toolbarMenuItemsClosure = new ToolbarMenuItemsClosure();
			IReadOnlyObservableCollection<IVisualSection> readOnlyObservableCollection = configuration.ToToolbarMenuItems(type).BindTyped<IVisualSection>();
			hiddenItems = readOnlyObservableCollection.Configure().WithState(toolbarMenuItemsClosure).Where((IVisualSection s, ToolbarMenuItemsClosure c) => c.IsHidden(s))
				.DisposeSource()
				.BindTyped<IVisualSection>();
			LimitCollectionDecoratorBase component2;
			HeaderFooterCollectionDecorator component3;
			ObservableCollectionConfiguration<IVisualSection, ToolbarMenuItemsClosure> component = readOnlyObservableCollection.Configure().WithState(toolbarMenuItemsClosure).Count(delegate(IReadOnlyObservableCollection _, int c, ToolbarMenuItemsClosure s)
			{
				s.Count = c;
			}, delegate(IVisualSection s, ToolbarMenuItemsClosure _)
			{
				IToolbarItemSectionModifier? toolbarItemSectionModifier = s.TryGetModifier<IToolbarItemSectionModifier>();
				return toolbarItemSectionModifier == null || !toolbarItemSectionModifier.ToolbarFlags.HasFlag(ToolbarSectionFlags.AlwaysVisible);
			})
				.Any(delegate(IReadOnlyObservableCollection _, bool v, ToolbarMenuItemsClosure s)
				{
					s.HasHidden = v;
				}, (IVisualSection s, ToolbarMenuItemsClosure _) => s.TryGetModifier<IToolbarItemSectionModifier>()?.ToolbarFlags.HasFlag(ToolbarSectionFlags.Hidden) ?? false)
				.NoState()
				.Where(delegate(IVisualSection s, UnitRef _)
				{
					IToolbarItemSectionModifier? toolbarItemSectionModifier = s.TryGetModifier<IToolbarItemSectionModifier>();
					return toolbarItemSectionModifier == null || !toolbarItemSectionModifier.ToolbarFlags.HasFlag(ToolbarSectionFlags.Hidden);
				})
				.Take(0, delegate(IVisualSection s, UnitRef _)
				{
					IToolbarItemSectionModifier? toolbarItemSectionModifier = s.TryGetModifier<IToolbarItemSectionModifier>();
					return toolbarItemSectionModifier == null || !toolbarItemSectionModifier.ToolbarFlags.HasFlag(ToolbarSectionFlags.AlwaysVisible);
				})
				.GetComponent(out component2)
				.WithState(toolbarMenuItemsClosure)
				.Count(delegate(IReadOnlyObservableCollection _, int c, ToolbarMenuItemsClosure s)
				{
					s.CountVisible = c;
				}, (IVisualSection s, ToolbarMenuItemsClosure _) => s.TryGetModifier<IToolbarItemSectionModifier>()?.ToolbarFlags.HasFlag(ToolbarSectionFlags.AlwaysVisible) ?? false)
				.Subscribe(Default.Selector<IVisualSection>(), (Action<TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure>, IVisualSection>?)ToolbarMenuItemsClosure.OnAdded, (Action<TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure>, IVisualSection>?)ToolbarMenuItemsClosure.OnRemoved, (Action<TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure>, IVisualSection, object?>?)null, (Action<TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure>>?)null, (ActionRef<IReadOnlyObservableCollection, ToolbarMenuItemsClosure>?)null, (IEqualityComparer<IVisualSection>?)ReferenceEqualityComparer.Instance)
				.WithHeaderFooter(null)
				.GetComponent(out component3);
			toolbarMenuItemsClosure.Initialize(limit, moreSection, component2, component3, readOnlyObservableCollection);
			return toolbarMenuItemsClosure.DisposeWith(component).NoState();
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<IVisualSection, UnitRef> ToToolbarMenuItems<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, ToolbarType type) where T : class, ISection
		{
			Should.NotBeNull(type, "type");
			return configuration.WithState(type).Where(delegate(T v, ToolbarType t)
			{
				IToolbarItemSectionModifier toolbarItemSectionModifier = v.TryUnwrap<IVisualSection>().TryGetModifier<IToolbarItemSectionModifier>();
				return toolbarItemSectionModifier != null && toolbarItemSectionModifier.ToolbarType == t && toolbarItemSectionModifier.ToolbarFlags.HasFlag(ToolbarSectionFlags.MenuItem);
			}).NoState()
				.ForWrapper<ISection, IVisualSection>()
				.SelectImmutable();
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<IVisualSection, UnitRef> ToToolbars<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, ToolbarType type) where T : class, ISection
		{
			Should.NotBeNull(type, "type");
			return configuration.WithState(type).Where(delegate(T v, ToolbarType t)
			{
				IToolbarItemSectionModifier toolbarItemSectionModifier = v.TryUnwrap<ISection, IVisualSection>()?.TryGetModifier<IToolbarItemSectionModifier>();
				return toolbarItemSectionModifier != null && toolbarItemSectionModifier.ToolbarType == t && toolbarItemSectionModifier.ToolbarFlags.HasFlag(ToolbarSectionFlags.Toolbar);
			}).NoState()
				.Take(1, (T v, UnitRef _) => (v.TryUnwrap<ISection, IVisualSection>()?.TryGetModifier<IToolbarItemSectionModifier>())?.ToolbarFlags.HasFlag(ToolbarSectionFlags.Primary) ?? false)
				.ForWrapper<ISection, IVisualSection>()
				.SelectImmutable();
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> ForRootSection<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration) where T : class, ISection
		{
			return configuration.For(ObservableCollectionSectionPredicate.Root<T>());
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> TrackVisualSections<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, Action<IVisualSection, TState> onAdded, Action<IVisualSection, TState> onRemoved) where T : class, ISection
		{
			Should.NotBeNull(onAdded, "onAdded");
			Should.NotBeNull(onRemoved, "onRemoved");
			return configuration.TrackVisualSections(new Tuple<Action<IVisualSection, TState>, Action<IVisualSection, TState>, TState>(onAdded, onRemoved, configuration.Predicate.State));
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> LayoutConfig<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, bool includePriority) where T : class, ISection
		{
			ObservableCollectionConfiguration<T, TState> configuration2 = configuration.AutoRefreshOnPropertyChangedSection(EditableLayoutSectionBase.ObservablePropertiesComposite, GetReloadArgs).AutoRefreshOnVisualSectionVisibilityChanged().WithSectionVisibilityFilter(includeInvisible: false);
			if (includePriority)
			{
				configuration2 = configuration2.WithSectionPriority();
			}
			return configuration2.For<INestedCompositeLayoutSection>().SelectMany((INestedCompositeLayoutSection t, ICollectionDecorator<TState> _) => t.Children).For(configuration.Predicate);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<TItem, TState> SelectManyAsync<T, TState, TItem>(this ObservableCollectionConfiguration<T, TState> configuration, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, object source, Action<T, TState, IEnumerable<TItem>?>? cleanup = null, TItem? itemGeneric = null) where T : class? where TItem : class?
		{
			return configuration.SelectManyInternalAsync(selector, source, cleanup);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<TItem, TState> SelectManyAsync<T, TState, TItem>(this ObservableCollectionConfiguration<T, TState> configuration, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, Func<T, TState, object> getSource, Action<T, TState, IEnumerable<TItem>?>? cleanup = null) where T : class? where TItem : class?
		{
			return configuration.SelectManyInternalAsync(selector, getSource, cleanup);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<ISection, UnitRef> FlattenCompositeSection<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, bool checkVisibility = false) where T : class, ISection
		{
			ObservableCollectionConfiguration<ISection, UnitRef> observableCollectionConfiguration = configuration.NoState().For<ISection>();
			return (checkVisibility ? observableCollectionConfiguration.For(FlattenCompositeSectionVisibilityPredicateImpl) : observableCollectionConfiguration.For(FlattenCompositeSectionPredicateImpl)).SelectMany<ISection>(FlattenCompositeSectionSelectorImpl, FlattenCompositeSectionCleanupImpl);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> WithSectionPriority<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration) where T : class, ISection
		{
			return configuration.NoState().For(delegate(object? v)
			{
				ISection section = MugenExtensions.TryUnwrap<ISection, IHasPrioritySection>(v);
				return Optional.Get(section ?? MugenExtensions.TryUnwrap<ISection, IVisualSection>(v));
			}).OrderBy((ISection s, UnitRef _) => (s is IHasPrioritySection hasPrioritySection) ? hasPrioritySection.Priority : (((IVisualSection)s).TryGetModifier<IPrioritySectionModifier>()?.Priority ?? 0), SortingComparerBuilder.DescendingComparer<int>.Instance)
				.For(configuration.Predicate);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> WithSectionVisibilityFilter<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, bool includeInvisible) where T : class, ISection
		{
			return configuration.WithState(includeInvisible ? UnitRef.Value : null).For(delegate(object? v)
			{
				ISection section = MugenExtensions.TryUnwrap<ISection, IHasReadOnlyVisibilitySection>(v);
				return Optional.Get(section ?? MugenExtensions.TryUnwrap<ISection, IVisualSection>(v));
			}).Where((Func<ISection, UnitRef, bool>)WithSectionVisibilityFilterImpl)
				.For(configuration.Predicate);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<IVisualSection, TState> WithVisibleVisualSectionFilter<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration) where T : class, ISection
		{
			return configuration.For<object>().NoState().Where((Func<object, UnitRef, bool>)WithVisibleVisualSectionFilterImpl)
				.ForWrapper<ISection, IVisualSection>()
				.SelectImmutable()
				.WithState(configuration.Predicate.State);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> AutoRefreshOnPropertyChangedSection<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, ItemOrArray<string> members, Func<string, object?>? getArgs = null) where T : class, ISection
		{
			return configuration.WithState(configuration.Predicate, AutoRefreshOnPropertyChangedSectionPredicateImpl).AutoRefreshOnPropertyChanged(members, AutoRefreshOnPropertyChangedSectionSubscribeImpl, AutoRefreshOnPropertyChangedSectionUnsubscribeImpl, getArgs).For(configuration.Predicate);
		}

		[MustUseReturnValue]
		public static ObservableCollectionConfiguration<T, TState> AutoRefreshOnVisualSectionVisibilityChanged<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration) where T : class, ISection
		{
			return configuration.NoState().ForWrapper<ISection, IVisualSection>().AutoRefreshOnBindable(delegate(IVisualSection s, UnitRef _)
			{
				IExpressionNode expression = _visibilityExpression ?? (_visibilityExpression = new MemberExpressionNode(new MethodCallExpressionNode(MemberExpressionNode.Empty, "TryGetModifier", default(ItemOrIReadOnlyList<IExpressionNode>), typeof(IVisibilitySectionModifier).AssemblyQualifiedName), "Value"));
				return new Bindable<SectionVisibility>(s, expression);
			})
				.For(configuration.Predicate);
		}

		internal static bool WithSectionVisibilityFilterImpl(ISection section, object? s)
		{
			if (section is IHasReadOnlyVisibilitySection hasReadOnlyVisibilitySection)
			{
				if (s != null)
				{
					return !hasReadOnlyVisibilitySection.Visibility.IsHidden();
				}
				return hasReadOnlyVisibilitySection.Visibility.IsVisible();
			}
			IVisibilitySectionModifier visibilitySectionModifier = section.TryUnwrap<IVisualSection>().TryGetModifier<IVisibilitySectionModifier>();
			if (visibilitySectionModifier != null)
			{
				if (s != null)
				{
					return !visibilitySectionModifier.Value.IsHidden();
				}
				return visibilitySectionModifier.Value.IsVisible();
			}
			return true;
		}

		private static ObservableCollectionConfiguration<T, TState> TrackVisualSections<T, TState>(this ObservableCollectionConfiguration<T, TState> configuration, Tuple<Action<IVisualSection, TState>, Action<IVisualSection, TState>, TState> state) where T : class, ISection
		{
			return configuration.ForWrapper<ISection, IVisualSection>().WithState(state).Subscribe<IDisposable>(OnAddedLayoutSection, OnRemovedLayoutSection, null, null, null, ReferenceEqualityComparer.Instance)
				.For(configuration.Predicate);
		}

		private static void OnAddedLayoutSection<TState>(TrackerCollectionDecorator<IVisualSection, IVisualSection, IDisposable?, Tuple<Action<IVisualSection, TState>, Action<IVisualSection, TState>, TState>> tracker, TrackerCollectionItemInfo<IVisualSection, IVisualSection> itemInfo, ref IDisposable? state)
		{
			if (itemInfo.Count != 1)
			{
				return;
			}
			if (itemInfo.Item is IImmutableLayoutSection)
			{
				PooledItemOrList<IDisposable> tokens = default(PooledItemOrList<IDisposable>);
				OnAddedCompositeLayoutSection(itemInfo.Item, tracker, ref tokens);
				state = ActionToken.FromDisposables<IDisposable>(tokens.ToItemOrArray());
				tokens.Dispose();
			}
			else if (itemInfo.Item is ICompositeLayoutSection compositeLayoutSection)
			{
				tracker.State.Item1(itemInfo.Item, tracker.State.Item3);
				bool value = false;
				IReadOnlyObservableCollection<ISection> readOnlyObservableCollection = compositeLayoutSection.Children as IReadOnlyObservableCollection<ISection>;
				if (readOnlyObservableCollection == null)
				{
					readOnlyObservableCollection = new ObservableList<ISection>(compositeLayoutSection.Children);
					value = true;
				}
				state = readOnlyObservableCollection.Configure().WithState(tracker.State.Item3).TrackVisualSections(tracker.State)
					.DisposeSource(value)
					.Bind();
			}
			else
			{
				tracker.State.Item1(itemInfo.Item, tracker.State.Item3);
			}
		}

		private static void OnRemovedLayoutSection<TState>(TrackerCollectionDecorator<IVisualSection, IVisualSection, IDisposable?, Tuple<Action<IVisualSection, TState>, Action<IVisualSection, TState>, TState>> tracker, IVisualSection item, int count, ref IDisposable? state)
		{
			if (count == 0)
			{
				state?.Dispose();
				if (item is IImmutableLayoutSection)
				{
					OnRemovedCompositeLayoutSection(item, tracker.State.Item2, tracker.State.Item3);
				}
				else
				{
					tracker.State.Item2(item, tracker.State.Item3);
				}
			}
		}

		private static void OnAddedCompositeLayoutSection<TState>(IVisualSection section, TrackerCollectionDecorator<IVisualSection, IVisualSection, IDisposable?, Tuple<Action<IVisualSection, TState>, Action<IVisualSection, TState>, TState>> tracker, ref PooledItemOrList<IDisposable> tokens)
		{
			tracker.State.Item1(section, tracker.State.Item3);
			if (section is IImmutableLayoutSection immutableLayoutSection)
			{
				ImmutableArray<IVisualSection>.Enumerator enumerator = immutableLayoutSection.Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					OnAddedCompositeLayoutSection(enumerator.Current, tracker, ref tokens);
				}
			}
			else
			{
				if (!(section is ICompositeLayoutSection compositeLayoutSection))
				{
					return;
				}
				if (!(compositeLayoutSection.Children is IReadOnlyObservableCollection<ISection> collection))
				{
					foreach (ISection child in compositeLayoutSection.Children)
					{
						if (child is IVisualSection section2)
						{
							OnAddedCompositeLayoutSection(section2, tracker, ref tokens);
						}
					}
					return;
				}
				tokens.Add(collection.Configure().WithState(tracker.State.Item3).TrackVisualSections(tracker.State)
					.Bind());
			}
		}

		private static void OnRemovedCompositeLayoutSection<TState>(IVisualSection section, Action<IVisualSection, TState> callback, TState state)
		{
			if (section is IImmutableLayoutSection immutableLayoutSection)
			{
				ImmutableArray<IVisualSection>.Enumerator enumerator = immutableLayoutSection.Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					OnRemovedCompositeLayoutSection(enumerator.Current, callback, state);
				}
			}
			else if (section is ICompositeLayoutSection compositeLayoutSection && !(compositeLayoutSection.Children is IReadOnlyObservableCollection))
			{
				foreach (ISection child in compositeLayoutSection.Children)
				{
					if (child is IVisualSection section2)
					{
						OnRemovedCompositeLayoutSection(section2, callback, state);
					}
				}
			}
			callback(section, state);
		}

		private static void FlattenCompositeSectionCleanupImpl(ISection section, IEnumerable<ISection>? objects, ICollectionDecorator<UnitRef> collectionDecorator)
		{
			if (objects is IReadOnlyObservableCollection readOnlyObservableCollection && readOnlyObservableCollection.TryGetComponent<CompositeSectionHeaderFooter>() != null)
			{
				readOnlyObservableCollection.Dispose();
			}
		}

		private static IEnumerable<ISection>? FlattenCompositeSectionSelectorImpl(CollectionPredicateItem<ISection> item, IEnumerable<ISection>? oldItems, ICollectionDecorator<UnitRef> _)
		{
			ISection item2 = item.Item;
			ICompositeSection compositeSection = item2.TryUnwrap<ISection, ICompositeSection>();
			if (!compositeSection.Flatten)
			{
				return null;
			}
			SectionVisibility compositeSectionVisibility = compositeSection.CompositeSectionVisibility;
			IReadOnlyCollection<ISection> sections = compositeSection.Sections;
			if (oldItems is IReadOnlyObservableCollection readOnlyObservableCollection && readOnlyObservableCollection.NextDecorator() == sections)
			{
				CompositeSectionHeaderFooter compositeSectionHeaderFooter = readOnlyObservableCollection.TryGetComponent<CompositeSectionHeaderFooter>();
				if (compositeSectionHeaderFooter != null)
				{
					compositeSectionHeaderFooter.UpdateVisibility(item2, compositeSectionVisibility);
					return oldItems;
				}
			}
			if (compositeSectionVisibility.IsHidden())
			{
				return sections;
			}
			if (sections is IReadOnlyObservableCollection<ISection> readOnlyObservableCollection2)
			{
				if (readOnlyObservableCollection2.IsDisposed)
				{
					return null;
				}
				return readOnlyObservableCollection2.Configure().Add(new CompositeSectionHeaderFooter().UpdateVisibility(item2, compositeSectionVisibility)).BindTyped<ISection>();
			}
			ISection element;
			if (!compositeSectionVisibility.IsVisible())
			{
				ISection section = item2.AsInvisibleSection();
				element = section;
			}
			else
			{
				element = item2;
			}
			return sections.Prepend(element);
		}

		private static Optional<ISection> FlattenCompositeSectionPredicateImpl(object? o)
		{
			if (!MugenExtensions.IsWrappedAs<ISection, ICompositeSection>(o))
			{
				return default(Optional<ISection>);
			}
			return Optional.Get(o as ISection);
		}

		private static Optional<ISection> FlattenCompositeSectionVisibilityPredicateImpl(object? o)
		{
			if (!MugenExtensions.IsWrappedAs<ISection, ICompositeSection>(o) || !(o is ISection section) || section.GetVisibility().IsHidden())
			{
				return default(Optional<ISection>);
			}
			return Optional.Get(section);
		}

		private static SectionVisibility GetVisibility(this ISection section)
		{
			if (section.TryUnwrap<ISection, IHasReadOnlyVisibilitySection>(out IHasReadOnlyVisibilitySection value))
			{
				return value.Visibility;
			}
			IVisibilitySectionModifier visibilitySectionModifier = section.TryUnwrap<IVisualSection>().TryGetModifier<IVisibilitySectionModifier>();
			if (visibilitySectionModifier != null)
			{
				return visibilitySectionModifier.Value;
			}
			return SectionVisibility.Visible;
		}

		private static bool WithVisibleVisualSectionFilterImpl(object section, UnitRef state)
		{
			IHasReadOnlyVisibilitySection hasReadOnlyVisibilitySection = MugenExtensions.TryUnwrap<ISection, IHasReadOnlyVisibilitySection>(section);
			if (hasReadOnlyVisibilitySection != null && !hasReadOnlyVisibilitySection.Visibility.IsVisible())
			{
				return false;
			}
			IVisualSection visualSection = MugenExtensions.TryUnwrap<ISection, IVisualSection>(section);
			if (visualSection == null)
			{
				return false;
			}
			return visualSection.Modifiers.TryGet<IVisibilitySectionModifier>()?.Value.IsVisible() ?? true;
		}

		private static void AutoRefreshOnPropertyChangedSectionUnsubscribeImpl<T, TState>(object itemRaw, object? target, PropertyChangedEventHandler h, ObservableCollectionPredicate<T, TState> _, ref DictionarySlim<object, object> map) where T : class
		{
			if (target is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= h;
			}
			do
			{
				if (target is INotifyPropertyChanged notifyPropertyChanged2 && map.Remove(notifyPropertyChanged2))
				{
					notifyPropertyChanged2.PropertyChanged -= h;
				}
			}
			while (MugenExtensions.TryStepNext<ISection>(ref target));
		}

		private static void AutoRefreshOnPropertyChangedSectionSubscribeImpl<T, TState>(object rawItem, T i, PropertyChangedEventHandler h, ObservableCollectionPredicate<T, TState> _, ref DictionarySlim<object, object> map) where T : class
		{
			object current = i;
			if (current is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged += h;
				if (notifyPropertyChanged != rawItem)
				{
					map.GetOrAddValueRef(notifyPropertyChanged) = rawItem;
				}
			}
			do
			{
				if (current is INotifyPropertyChanged notifyPropertyChanged2)
				{
					map.GetOrAddValueRef(notifyPropertyChanged2, out var hasValue) = rawItem;
					if (!hasValue)
					{
						notifyPropertyChanged2.PropertyChanged += h;
					}
				}
			}
			while (MugenExtensions.TryStepNext<ISection>(ref current));
		}

		private static Optional<T> AutoRefreshOnPropertyChangedSectionPredicateImpl<T, TState>(object? o, ObservableCollectionPredicate<T, TState> s) where T : class
		{
			if (!MugenExtensions.IsWrappedAs<ISection, INotifyPropertyChanged>(o))
			{
				return default(Optional<T>);
			}
			return s.GetItem(o);
		}

		[MustUseReturnValue]
		private static ObservableCollectionConfiguration<TItem, TState> SelectManyInternalAsync<T, TState, TItem>(this ObservableCollectionConfiguration<T, TState> configuration, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, object getSourceOrSource, Action<T, TState, IEnumerable<TItem>?>? cleanup = null) where T : class? where TItem : class?
		{
			Should.NotBeNull(selector, "selector");
			Should.NotBeNull(getSourceOrSource, "source");
			return configuration.WithState<(ObservableCollectionPredicate<T, TState>, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>>>, Action<T, TState, IEnumerable<TItem>>, object, string, SelectManyErrorRetryHandler)>((configuration.Predicate, selector, cleanup, getSourceOrSource, null, null), SelectManyAsyncPredicate).SelectManyAsync<TItem>(SelectManyAsyncSelectorImpl, SelectManyAsyncGetErrorImpl, null, SelectManyAsyncCleanupImpl).WithState(configuration.Predicate.State);
		}

		private static void SelectManyAsyncCleanupImpl<T, TItem, TState>(T item, (ObservableCollectionPredicate<T, TState> Predicate, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, Action<T, TState, IEnumerable<TItem>?>? cleanup, object getSourceOrSource, string? actionId, SelectManyErrorRetryHandler? handler) s, IEnumerable<TItem>? items) where T : class? where TItem : class?
		{
			s.cleanup?.Invoke(item, s.Predicate.State, items);
			SelectManyAsyncHandler<T, (ObservableCollectionPredicate<T, TState>, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>>>, Action<T, TState, IEnumerable<TItem>>, object, string, SelectManyErrorRetryHandler), TItem> selectManyAsyncHandler = SelectManyAsyncHandler.TryGet<T, (ObservableCollectionPredicate<T, TState>, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>>>, Action<T, TState, IEnumerable<TItem>>, object, string, SelectManyErrorRetryHandler), TItem>(items, item, s, null);
			if (selectManyAsyncHandler != null && selectManyAsyncHandler.State.Item5 != null)
			{
				object source = ((s.getSourceOrSource is Func<T, TState, object> func) ? func(item, s.Predicate.State) : s.getSourceOrSource);
				IMugenService<IMugenApplication>.Instance.OnCancelAppErrorById(source, selectManyAsyncHandler.State.Item5);
			}
		}

		private static async ValueTask<object?> SelectManyAsyncGetErrorImpl<T, TItem, TState>(SelectManyAsyncHandler<T, (ObservableCollectionPredicate<T, TState> Predicate, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, Action<T, TState, IEnumerable<TItem>?>? cleanup, object getSourceOrSource, string? actionId, SelectManyErrorRetryHandler? handler), TItem> s, Exception e, CancellationToken c) where T : class? where TItem : class?
		{
			if (!s.IsDisposed)
			{
				object source = ((s.State.getSourceOrSource is Func<T, TState, object> func) ? func(s.Item, s.State.Predicate.State) : s.State.getSourceOrSource);
				if (s.State.actionId == null)
				{
					Interlocked.CompareExchange(ref s.State.actionId, "a" + Default.NextCounter(), null);
				}
				ref SelectManyErrorRetryHandler item = ref s.State.handler;
				if (item == null)
				{
					item = new SelectManyErrorRetryHandler(s);
				}
				IAppErrorInfo appErrorInfo = await IMugenService<IMugenApplication>.Instance.OnAppErrorAsync(source, e, s.State.actionId, s.State.handler, null, c).ConfigureAwait(continueOnCapturedContext: false);
				if (appErrorInfo != null && s.IsDisposed)
				{
					IMugenService<IMugenApplication>.Instance.OnCancelAppError(appErrorInfo);
				}
			}
			return null;
		}

		private static ValueTask<IEnumerable<TItem>?> SelectManyAsyncSelectorImpl<T, TItem, TState>(SelectManyAsyncHandler<T, (ObservableCollectionPredicate<T, TState> Predicate, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, Action<T, TState, IEnumerable<TItem>?>? cleanup, object getSourceOrSource, string? actionId, SelectManyErrorRetryHandler? handler), TItem> s, CancellationToken c) where T : class? where TItem : class?
		{
			object source = ((s.State.getSourceOrSource is Func<T, TState, object> func) ? func(s.Item, s.State.Predicate.State) : s.State.getSourceOrSource);
			if (s.State.actionId != null)
			{
				IMugenService<IMugenApplication>.Instance.OnCancelAppErrorById(source, s.State.actionId);
			}
			return s.State.selector(s.Item, s.State.Predicate.State, c);
		}

		private static Optional<T> SelectManyAsyncPredicate<T, TItem, TState>(object? o, (ObservableCollectionPredicate<T, TState> Predicate, Func<T, TState, CancellationToken, ValueTask<IEnumerable<TItem>?>> selector, Action<T, TState, IEnumerable<TItem>?>? cleanup, object getSourceOrSource, string? actionId, SelectManyErrorRetryHandler? handler) s) where T : class? where TItem : class?
		{
			return s.Predicate.GetItem(o);
		}

		public static Bindable<LayoutDirType> LayoutDirection(this IShellAware layout, bool relative = false)
		{
			Should.NotBeNull(layout, "layout");
			return IMugenService<IMugenApplication>.Instance.TryGetLayoutDirection(layout, relative);
		}

		public static Bindable<ScreenMetrics> ScreenMetrics(this IShellAware layout, bool relative = false)
		{
			Should.NotBeNull(layout, "layout");
			return IMugenService<IMugenApplication>.Instance.TryGetScreenMetrics(layout, relative);
		}

		public static Bindable<Thickness> SystemInsets(this IShellAware layout, SystemInsetType type, bool relative = false)
		{
			Should.NotBeNull(layout, "layout");
			Should.NotBeNull(type, "type");
			return IMugenService<IMugenApplication>.Instance.TryGetSystemInsets(layout, type, relative);
		}

		public static bool IsWrappedAs<T>(this IInner<ISection>? section) where T : class?
		{
			return MugenExtensions.IsWrappedAs<ISection, T>((object?)section);
		}

		public static T? TryUnwrap<T>(this IInner<ISection>? section) where T : class?
		{
			return MugenExtensions.TryUnwrap<ISection, T>((object?)section);
		}

		public static bool TryUnwrap<T>(this IInner<ISection>? section, [NotNullWhen(true)] out T? value) where T : class?
		{
			value = MugenExtensions.TryUnwrap<ISection, T>((object?)section);
			return value != null;
		}

		[MustDisposeResource]
		public static IReadOnlyObservableCollection<T> BindShellSections<T, TState>(this IShellAware shell, TState state, Func<ObservableCollectionConfiguration<ISection, UnitRef>, IShell, TState, ObservableCollectionConfiguration<T, UnitRef>> configure) where T : class, ISection
		{
			HeaderFooterCollectionDecorator component;
			IReadOnlyObservableCollection<T> readOnlyObservableCollection = new ObservableList<ISection>().Configure().WithHeaderFooter(null).GetComponent(out component)
				.For<IEnumerable<object>>()
				.SelectMany((IEnumerable<object> objects, ICollectionDecorator<UnitRef> _) => objects)
				.DisposeSource()
				.BindTyped<T>();
			shell.B(_bindCache8 ?? (_bindCache8 = (IShellAware s) => s.Shell)).UseLatest<IShell, (HeaderFooterCollectionDecorator, Func<ObservableCollectionConfiguration<ISection, UnitRef>, IShell, TState, ObservableCollectionConfiguration<T, UnitRef>>, TState)>((component, configure, state), delegate(IShell sh, (HeaderFooterCollectionDecorator decorator, Func<ObservableCollectionConfiguration<ISection, UnitRef>, IShell, TState, ObservableCollectionConfiguration<T, UnitRef>> configure, TState state) tuple)
			{
				if (sh == null)
				{
					return default(ActionToken);
				}
				IReadOnlyObservableCollection<T> readOnlyObservableCollection2 = tuple.configure(sh.Sections.Configure(), sh, tuple.state).BindTyped<T>();
				tuple.decorator.SetHeader(ItemOrIReadOnlyList.FromItem((object?)readOnlyObservableCollection2));
				return ActionToken.FromDisposable(readOnlyObservableCollection2);
			}).Subscribe()
				.DisposeWith(readOnlyObservableCollection);
			return readOnlyObservableCollection;
		}

		public static T? TryGetRootSection<T>(this IShellAware shellAware) where T : class
		{
			Should.NotBeNull(shellAware, "shellAware");
			IShell shell = shellAware.Shell;
			if (shell == null)
			{
				return null;
			}
			foreach (ISection section in shell.Sections)
			{
				if (section.IsWrappedAs<ISection, IRootSection>())
				{
					T val = section.TryUnwrap<ISection, T>();
					if (val != null)
					{
						return val;
					}
				}
			}
			return null;
		}

		[BindingExtensionMethod]
		public static RootSectionWatcher<T> RootSection<T>(this IShellAware shellAware) where T : class, ISection
		{
			return RootSectionWatcher<T>.GetOrAdd(shellAware, typeof(T).Name);
		}

		public static bool IsHidden(this SectionVisibility? visibility)
		{
			if (!(visibility == null))
			{
				return visibility.IsHidden;
			}
			return true;
		}

		public static bool IsVisible(this SectionVisibility? visibility)
		{
			if (visibility != null)
			{
				return visibility.IsVisible;
			}
			return false;
		}

		public static bool IsInvisible(this SectionVisibility? visibility)
		{
			return visibility == SectionVisibility.Invisible;
		}

		public static CompositeCommandConfiguration<T> WithActionInvokerSource<T>(this CompositeCommandConfiguration<T> configuration, object source, bool force = false)
		{
			configuration.Command.WithActionInvokerSource(source, force);
			return configuration;
		}

		public static Disposable<ICompositeCommand?> WithActionInvokerSource(this Disposable<ICompositeCommand?> command, object source, bool force = false)
		{
			if (command.IsDisposable || force)
			{
				command.Target.WithActionInvokerSource(source, force);
			}
			return command;
		}

		[return: NotNullIfNotNull("command")]
		public static ICompositeCommand? WithActionInvokerSource(this ICompositeCommand? command, object source, bool force = false)
		{
			if (command == null)
			{
				return null;
			}
			if (force || MugenExtensions.TryUnwrap<ISection, ISection>(command.Metadata.Get(CompositeUIMetadata.ActionInvokerSourceCommand)) == null)
			{
				command.Metadata.Set(CompositeUIMetadata.ActionInvokerSourceCommand, (source as ISection)?.Inner ?? source);
			}
			return command;
		}

		public static CompositeCommandConfiguration<T> WithSectionBusyMessage<T>(this CompositeCommandConfiguration<T> configuration, Func<IReadOnlyMetadataContext?, (int delay, object? message)?> getMessage)
		{
			configuration.Command.Metadata.Set(CommandMetadata.BusyMessageHandler, getMessage);
			return configuration;
		}

		public static ValueTask<bool?> TryCloseAsync(this IShellAware? shell, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return (shell?.TryGetRootCloseCommand()?.ExecuteAsync(metadata, cancellationToken)).GetValueOrDefault();
		}

		public static ValueTask<bool?> TryGoBackAsync(this IShellAware? shell, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return (shell?.TryGetRootCloseCommand()?.ExecuteAsync(metadata.WithValue(NavigationMetadata.IsBackNavigationClose, value: true), cancellationToken)).GetValueOrDefault();
		}

		public static bool TryClose(this IShellAware? shell, IReadOnlyMetadataContext? metadata = null)
		{
			ICompositeCommand compositeCommand = shell?.TryGetRootCloseCommand();
			if (compositeCommand == null)
			{
				return false;
			}
			compositeCommand.Execute(null, metadata);
			return true;
		}

		public static bool TryGoBack(this IShellAware? shell, IReadOnlyMetadataContext? metadata = null)
		{
			ICompositeCommand compositeCommand = shell?.TryGetRootCloseCommand();
			if (compositeCommand == null)
			{
				return false;
			}
			compositeCommand.Execute(null, metadata.WithValue(NavigationMetadata.IsBackNavigationClose, value: true));
			return true;
		}

		public static void ResetLayout(this IViewsAwareSection? section, IReadOnlyMetadataContext? metadata = null)
		{
			if (section == null)
			{
				return;
			}
			foreach (IView view in section.Views)
			{
				view.ResetLayoutAsync(metadata).LogException(UnhandledExceptionType.View);
			}
		}

		public static void HideKeyboard(this IViewsAwareSection? section, IReadOnlyMetadataContext? metadata = null)
		{
			if (section == null)
			{
				return;
			}
			foreach (IView view in section.Views)
			{
				view.HideKeyboardAsync(metadata).LogException(UnhandledExceptionType.View);
			}
		}

		public static SelectableSectionRaw ToSelectableSection<T>(this CompositeCommandConfiguration<T> configuration)
		{
			return new SelectableSectionRaw
			{
				SelectCommand = configuration
			};
		}

		public static RefreshableSectionRaw ToRefreshableSection<T>(this CompositeCommandConfiguration<T> configuration)
		{
			return new RefreshableSectionRaw
			{
				RefreshCommand = configuration
			};
		}

		public static LoadMoreSectionRaw ToLoadMoreSection<T>(this CompositeCommandConfiguration<T> configuration, bool isVertical = true)
		{
			return new LoadMoreSectionRaw(isVertical)
			{
				LoadMoreCommand = configuration
			};
		}

		public static ReloadableSectionRaw ToReloadableSection<T>(this CompositeCommandConfiguration<T> configuration, bool refreshBusy = false)
		{
			return new ReloadableSectionRaw(refreshBusy)
			{
				ReloadCommand = configuration
			};
		}

		public static RemovableSectionRaw ToRemovableSection<T>(this CompositeCommandConfiguration<T> configuration)
		{
			return new RemovableSectionRaw
			{
				RemoveCommand = configuration
			};
		}

		public static ResultSection<TResult> GetResultSection<TResult>(this ISectionApiRequest<TResult> request)
		{
			return new ResultSection<TResult>();
		}

		public static WorkflowSuspendableSectionRaw ToWorkflowSuspendable<T>(this CompositeCommandConfiguration<T> configuration, bool refreshBusy)
		{
			return configuration.Command.ToWorkflowSuspendable(refreshBusy);
		}

		public static WorkflowSuspendableSectionRaw ToWorkflowSuspendable(this ICompositeCommand command, bool refreshBusy)
		{
			return new WorkflowSuspendableSectionRaw(ItemOrIEnumerable.FromItem(command), refreshBusy);
		}

		public static WorkflowSuspendableSectionRaw ToWorkflowSuspendable(this ItemOrIEnumerable<ICompositeCommand> commands, bool refreshBusy)
		{
			return new WorkflowSuspendableSectionRaw(commands, refreshBusy);
		}

		public static ISection GetOrAddWorkflowResultHandler<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult>(this GetWorkflowStepSectionsRequest<TRequest> request, [RequireStaticDelegate] Func<TRequest, UnitRef, IReadOnlyMetadataContext?, CancellationToken, ValueTask<Optional<TResult>>> getResult, [RequireStaticDelegate] Func<CompositeCommandConfiguration<object?>, UnitRef, CompositeCommandConfiguration<object?>>? configureCommand = null) where TRequest : class, IWorkflowSectionApiRequest<TRequest, TResult>
		{
			return request.GetOrAddWorkflowResultHandler(UnitRef.Value, getResult, configureCommand);
		}

		public static ISection GetOrAddWorkflowResultHandler<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult, TState>(this GetWorkflowStepSectionsRequest<TRequest> request, TState state, [RequireStaticDelegate] Func<TRequest, TState, IReadOnlyMetadataContext?, CancellationToken, ValueTask<Optional<TResult>>> getResult, [RequireStaticDelegate] Func<CompositeCommandConfiguration<object?>, TState, CompositeCommandConfiguration<object?>>? configureCommand = null) where TRequest : class, IWorkflowSectionApiRequest<TRequest, TResult>
		{
			Should.NotBeNull(request, "request");
			Should.NotBeNull(getResult, "getResult");
			AttachedValueStorage attachedValueStorage = request.Shell.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet((ReadOnlySpan<char>)"!#rr", out ISection value))
				{
					value = new WorkflowSectionResult<TRequest, TResult, TState>(request.Request, state, getResult, configureCommand);
					request.Shell.RegisterDisposeToken(ActionToken.FromDisposable(value));
					value = value.SuppressDispose();
					attachedValueStorage.Set("!#rr", value);
				}
				return value;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		public static CacheSectionResult<T> GetOrAddSection<TRequest, T>(this GetSectionsRequestBase<TRequest> request, string? key = null) where TRequest : class where T : class, ISection, new()
		{
			return request.GetOrAddSection(null, (GetSectionsRequestBase<TRequest> _, object? _, IReadOnlyMetadataContext? _) => new T(), key);
		}

		public static CacheSectionResult<T> GetOrAddSection<TRequest, T, TState>(this GetSectionsRequestBase<TRequest> request, TState state, Func<GetSectionsRequestBase<TRequest>, TState, IReadOnlyMetadataContext?, T> getSection, string? key = null, IReadOnlyMetadataContext? metadata = null) where TRequest : class where T : class, ISection
		{
			Should.NotBeNull(request, "request");
			if (key == null)
			{
				key = typeof(T).FullName + (request.Request as IHasId<string>)?.Id;
			}
			AttachedValueStorage attachedValueStorage = request.Shell.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet(key, out object value))
				{
					T val = getSection(request, state, metadata);
					if (!(val is SuppressDisposeSectionWrapper))
					{
						request.Shell.RegisterDisposeToken(ActionToken.FromDisposable(val));
						value = new SuppressDisposeSectionWrapper(val);
					}
					else
					{
						value = val;
					}
					attachedValueStorage.Set(key, value);
				}
				if (value is SuppressDisposeSectionWrapper suppressDisposeSectionWrapper)
				{
					return new CacheSectionResult<T>((T)suppressDisposeSectionWrapper.Section, suppressDisposeSectionWrapper);
				}
				return new CacheSectionResult<T>((T)value);
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		public static bool TryGetSection<T>(this GetSectionsRequestBase request, string key, [NotNullWhen(true)] out T? value) where T : class
		{
			Should.NotBeNull(request, "request");
			return request.Shell.AttachedValues().TryGet((ReadOnlySpan<char>)key, out value);
		}

		public static void SetSection<T>(this GetSectionsRequestBase request, string key, T section) where T : class
		{
			Should.NotBeNull(request, "request");
			request.Shell.AttachedValues().Set(key, section);
		}

		public static T SetSection<T>(this T section, string key, GetSectionsRequestBase request) where T : class, ISection
		{
			Should.NotBeNull(section, "section");
			request.SetSection(key, section);
			return section;
		}

		public static ISection GetCloseShellSection(this GetSectionsRequestBase request)
		{
			return CloseShellSectionAction.Instance;
		}

		public static CompositeSectionRaw ToCompositeSection(this IReadOnlyCollection<ISection> sections, bool disposeSections = false)
		{
			return new CompositeSectionRaw(sections, disposeSections);
		}

		public static CollectionHostLayoutSection ToCollectionLayout(this IReadOnlyObservableCollection<IVisualSection> sections, bool disposeSource = true, OrientationType? orientation = null)
		{
			return SectionKit.Collection(sections, disposeSource, orientation);
		}

		public static StakeHostSection ToStackLayout(this IReadOnlyObservableCollection<IVisualSection> sections, bool disposeSource = true, OrientationType? orientation = null)
		{
			return SectionKit.Stack(sections, disposeSource, orientation);
		}

		public static FrameHostSection ToFrameLayout(this IReadOnlyObservableCollection<IVisualSection> sections, bool disposeSource = true)
		{
			return SectionKit.Frame(sections, disposeSource);
		}

		public static InvisibleSection ToInvisibleSection(this ISection section)
		{
			return new InvisibleSection(section);
		}

		public static HiddenDisposableSection ToHiddenDisposableSection(this IDisposable section)
		{
			return new HiddenDisposableSection(section);
		}

		public static SuppressDisposeSectionWrapper SuppressDispose(this ISection section)
		{
			return new SuppressDisposeSectionWrapper(section);
		}

		public static SuppressDisposeSectionWrapper SuppressDispose(this ISection section, GetSectionsRequestBase request)
		{
			return section.SuppressDispose(request.Shell);
		}

		public static SuppressDisposeSectionWrapper SuppressDispose(this ISection section, ISupportDisposeCallback source)
		{
			source.RegisterDisposeToken(section.Inner);
			return section.SuppressDispose();
		}

		public static VisibilitySectionWrapper WithVisibility(this ISection section, SectionVisibility? visibility = null)
		{
			return new VisibilitySectionWrapper(section)
			{
				Visibility = visibility
			};
		}

		public static DataContextTargetAwareSection WithViewAwareSection(this ISection section, SectionVisibility? visibility = null)
		{
			return new DataContextTargetAwareSection(section);
		}

		public static SectionPriorityWrapper WithSectionPriority(this ISection section, int priority)
		{
			return new SectionPriorityWrapper(section, priority);
		}

		public static ImmutableValueSection<IWorkflowStepInfo> ToValueSection(this IWorkflowStepInfo value)
		{
			Should.NotBeNull(value, "value");
			return new ImmutableValueSection<IWorkflowStepInfo>(value);
		}

		public static ImmutableValueSection<ITabSectionApiRequest> ToValueSection(this ITabSectionApiRequest value)
		{
			Should.NotBeNull(value, "value");
			return new ImmutableValueSection<ITabSectionApiRequest>(value);
		}

		public static ISection ToTemporarySection(this ISection section)
		{
			return new TemporarySectionWrapper(section);
		}

		[MustDisposeResource]
		public static ActionToken ShowOverlay(this IMugenApplication apiProvider, ISectionApiRequest<Unit> request, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return apiProvider.ShowOverlay(request, 0, metadata, cancellationToken);
		}

		[MustDisposeResource]
		public static ActionToken ShowOverlay(this IMugenApplication apiProvider, ISectionApiRequest<Unit> request, int delay, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			if (delay == 0)
			{
				ShowOverlayCore(apiProvider, request, cts, metadata);
			}
			else
			{
				Task.Delay(delay, cts.Token).ContinueWith(delegate
				{
					ShowOverlayCore(apiProvider, request, cts, metadata);
				}, cts.Token, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Current).LogException(UnhandledExceptionType.Navigation);
			}
			return ActionToken.FromDelegate(cts, delegate(CancellationTokenSource s)
			{
				s.Cancel();
			});
		}

		public static Bindable<ICompositeCommand?> BindRootCloseCommand(this IShellAware shell)
		{
			return shell.B(_bindCache11 ?? (_bindCache11 = (IShellAware s) => s.RootSection<ICloseableSection>().Section.CloseCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootReloadCommand(this IShellAware shell)
		{
			return shell.B(_bindCache12 ?? (_bindCache12 = (IShellAware s) => s.RootSection<IReloadableSection>().Section.ReloadCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootGoNextCommand(this IShellAware shell)
		{
			return shell.B(_bindCache13 ?? (_bindCache13 = (IShellAware s) => s.RootSection<IWorkflowHandlerSection>().Section.GoNextCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootGoBackCommand(this IShellAware shell)
		{
			return shell.B(_bindCache14 ?? (_bindCache14 = (IShellAware s) => s.RootSection<IWorkflowHandlerSection>().Section.GoBackCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootCompleteCommand(this IShellAware shell)
		{
			return shell.B(_bindCache15 ?? (_bindCache15 = (IShellAware s) => s.RootSection<IWorkflowHandlerSection>().Section.CompleteCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootLoadMoreCommand(this IShellAware shell)
		{
			return shell.B(_bindCache16 ?? (_bindCache16 = (IShellAware s) => s.RootSection<ILoadMoreSupportSection>().Section.LoadMoreCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootRefreshCommand(this IShellAware shell)
		{
			return shell.B(_bindCache17 ?? (_bindCache17 = (IShellAware s) => s.RootSection<IRefreshableSection>().Section.RefreshCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootSelectCommand(this IShellAware shell)
		{
			return shell.B(_bindCache18 ?? (_bindCache18 = (IShellAware s) => s.RootSection<ISelectableSection>().Section.SelectCommand));
		}

		public static Bindable<ICompositeCommand?> BindRootRemoveCommand(this IShellAware shell)
		{
			return shell.B(_bindCache19 ?? (_bindCache19 = (IShellAware s) => s.RootSection<IRemovableSection>().Section.RemoveCommand));
		}

		public static ICompositeCommand? TryGetRootCloseCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<ICloseableSection>()?.CloseCommand;
		}

		public static ICompositeCommand? TryGetRootReloadCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IReloadableSection>()?.ReloadCommand;
		}

		public static ICompositeCommand? TryGetRootGoNextCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IWorkflowHandlerSection>()?.GoNextCommand;
		}

		public static ICompositeCommand? TryGetRootGoBackCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IWorkflowHandlerSection>()?.GoBackCommand;
		}

		public static ICompositeCommand? TryGetRootCompleteCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IWorkflowHandlerSection>()?.CompleteCommand;
		}

		public static ICompositeCommand? TryGetRootLoadMoreCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<ILoadMoreSupportSection>()?.LoadMoreCommand;
		}

		public static ICompositeCommand? TryGetRootRefreshCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IRefreshableSection>()?.RefreshCommand;
		}

		public static ICompositeCommand? TryGetRootSelectCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<ISelectableSection>()?.SelectCommand;
		}

		public static ICompositeCommand? TryGetRootRemoveCommand(this IShellAware shell)
		{
			return shell.TryGetRootSection<IRemovableSection>()?.RemoveCommand;
		}

		internal static IInvisibleSection AsInvisibleSection(this ISection section)
		{
			return section.TryUnwrap<ISection, IInvisibleSection>() ?? new InvisibleSection(section);
		}

		internal static void WithDefaultGravity(this IVisualSection section)
		{
			if (section.TryGetModifier<IGravitySectionModifier>() == null)
			{
				section.WithModifier(CacheableValueImmutableSectionModifierBase<GravityImmutableSectionModifier, IGravitySectionModifier, EnumFlags<GravityFlags>, EnumFlags<GravityFlags>>.Get(GravityFlags.Default));
			}
		}

		private static void ShowOverlayCore(IMugenApplication apiProvider, ISectionApiRequest<Unit> request, CancellationTokenSource cts, IReadOnlyMetadataContext? metadata)
		{
			if (metadata == null || !metadata.Contains(NavigationMetadata.AnimateClose))
			{
				metadata = metadata.WithValue(NavigationMetadata.AnimateClose, value: false);
			}
			request.OpenAsync(apiProvider, metadata, cts.Token).LogException(UnhandledExceptionType.Navigation);
		}

		public static void InitShellView(this Activity activity, IResourceTemplateSelector? templateSelector = null)
		{
			activity.FindViewById(16908290)?.InitShellView(templateSelector);
		}

		public static void InitShellView(this View view, IResourceTemplateSelector? templateSelector = null)
		{
			view = NativeBindableMemberMugenExtensions.GetShellView(view);
			view.SetContentTemplateSelector((IContentTemplateSelector<View, Object>?)new RecyclableContentTemplateSelectorWrapper(templateSelector ?? new CompositeUITemplateSelectorBase()));
			view.BindContentTarget<View>().To(view.B(_bindCache6 ?? (_bindCache6 = (View e) => ((Object)e).DataContext<IShell>().Layout.Content)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}

		public static SectionModifierRendererRegistry Register<TModifier, TRenderer>(this SectionModifierRendererRegistry registry) where TModifier : class, ISectionModifier where TRenderer : class, ISectionModifierRenderer<View>, new()
		{
			Should.NotBeNull(registry, "registry");
			return registry.Register<TModifier, View>(new TRenderer());
		}

		public static SectionModifierRendererRegistry Register<TModifier>(this SectionModifierRendererRegistry registry, SectionModifierRendererBase renderer) where TModifier : class, ISectionModifier
		{
			Should.NotBeNull(registry, "registry");
			return registry.Register<TModifier, View>(renderer);
		}

		public static SectionVisibility ToVisibility(this ViewStates visibility)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)visibility == 0)
			{
				return SectionVisibility.Visible;
			}
			if ((int)visibility == 8)
			{
				return SectionVisibility.Hidden;
			}
			return SectionVisibility.Invisible;
		}

		public static ViewStates ToNative(this SectionVisibility? visibility)
		{
			if (!(visibility == null) && !visibility.IsVisible)
			{
				if (!visibility.IsHidden)
				{
					return (ViewStates)4;
				}
				return (ViewStates)8;
			}
			return (ViewStates)0;
		}

		public static bool TryGetResourceId(this ImageSource imageSource, out int resourceId)
		{
			resourceId = imageSource.ResourceId;
			return imageSource.ImageSourceType.IsResource;
		}

		public static InputTypes ToInputTypes(this KeyboardType? k)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			if (k == KeyboardType.Email)
			{
				return (InputTypes)33;
			}
			if (k == KeyboardType.Integer)
			{
				return (InputTypes)4098;
			}
			if (k == KeyboardType.Decimal)
			{
				return (InputTypes)12290;
			}
			if (k == KeyboardType.Phone)
			{
				return (InputTypes)3;
			}
			if (k == KeyboardType.Url)
			{
				return (InputTypes)17;
			}
			if (k == KeyboardType.Password)
			{
				return (InputTypes)129;
			}
			if (k == KeyboardType.TextMultiline)
			{
				return (InputTypes)131073;
			}
			return (InputTypes)1;
		}

		public static KeyboardType ToKeyboardType(this InputTypes it)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)131072))
			{
				return KeyboardType.TextMultiline;
			}
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)32))
			{
				return KeyboardType.Email;
			}
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)2))
			{
				if (!((Enum)it).HasFlag((Enum)(object)(InputTypes)8192))
				{
					return KeyboardType.Integer;
				}
				return KeyboardType.Decimal;
			}
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)3))
			{
				return KeyboardType.Phone;
			}
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)16))
			{
				return KeyboardType.Url;
			}
			if (((Enum)it).HasFlag((Enum)(object)(InputTypes)128) || ((Enum)it).HasFlag((Enum)(object)(InputTypes)144))
			{
				return KeyboardType.Password;
			}
			return KeyboardType.Default;
		}

		public static int ToScaleType(this ImageStretchMode? mode)
		{
			if (mode == ImageStretchMode.Fill)
			{
				return 1;
			}
			if (mode == ImageStretchMode.AspectFit)
			{
				return 3;
			}
			if (mode == ImageStretchMode.AspectFill)
			{
				return 6;
			}
			if (mode == ImageStretchMode.Center)
			{
				return 5;
			}
			return 0;
		}

		public static Alignment ToAlignment(this GravityFlags gravity)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if (gravity.HasFlagEx((GravityFlags)1) || gravity.HasFlagEx((GravityFlags)16))
			{
				return Alignment.Center;
			}
			if (gravity.HasFlagEx((GravityFlags)8388611) || gravity.HasFlagEx((GravityFlags)80))
			{
				return Alignment.Start;
			}
			if (gravity.HasFlagEx((GravityFlags)8388613) || gravity.HasFlagEx((GravityFlags)48))
			{
				return Alignment.End;
			}
			return Alignment.Fill;
		}

		public static GravityFlags ToNative(this Alignment value, bool isVertical)
		{
			if (value == Alignment.Start)
			{
				if (isVertical)
				{
					return (GravityFlags)8388611;
				}
				return (GravityFlags)48;
			}
			if (value == Alignment.Center)
			{
				if (isVertical)
				{
					return (GravityFlags)1;
				}
				return (GravityFlags)16;
			}
			if (value == Alignment.End)
			{
				if (isVertical)
				{
					return (GravityFlags)8388613;
				}
				return (GravityFlags)80;
			}
			return (GravityFlags)119;
		}

		public static int ToNative(this TextAlignment? alignment)
		{
			if (alignment == TextAlignment.Start)
			{
				return 8388611;
			}
			if (alignment == TextAlignment.End)
			{
				return 8388613;
			}
			if (alignment == TextAlignment.Center)
			{
				return 17;
			}
			return 0;
		}

		public static GravityFlags ToNative(this EnumFlags<GravityFlags> flags)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			GravityFlags val = (GravityFlags)0;
			if (flags.HasFlag(GravityFlags.Start))
			{
				val = (GravityFlags)(val | 0x800003);
			}
			if (flags.HasFlag(GravityFlags.CenterHorizontal))
			{
				val = (GravityFlags)(val | 1);
			}
			if (flags.HasFlag(GravityFlags.End))
			{
				val = (GravityFlags)(val | 0x800005);
			}
			if (flags.HasFlag(GravityFlags.FillHorizontal))
			{
				val = (GravityFlags)(val | 7);
			}
			if (flags.HasFlag(GravityFlags.Top))
			{
				val = (GravityFlags)(val | 0x30);
			}
			if (flags.HasFlag(GravityFlags.CenterVertical))
			{
				val = (GravityFlags)(val | 0x10);
			}
			if (flags.HasFlag(GravityFlags.Bottom))
			{
				val = (GravityFlags)(val | 0x50);
			}
			if (flags.HasFlag(GravityFlags.FillVertical))
			{
				val = (GravityFlags)(val | 0x70);
			}
			return val;
		}

		internal static ImageStretchMode FromScaleType(this int mode)
		{
			return mode switch
			{
				1 => ImageStretchMode.Fill, 
				3 => ImageStretchMode.AspectFit, 
				6 => ImageStretchMode.AspectFill, 
				5 => ImageStretchMode.Center, 
				_ => ImageStretchMode.None, 
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool HasFlagEx(this GravityFlags gravityFlags, GravityFlags flag)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			return (GravityFlags)(gravityFlags & flag) == flag;
		}

		private static MugenApplicationConfiguration UsePlatformShell(this MugenApplicationConfiguration configuration, IServiceProvider? serviceProvider)
		{
			configuration = configuration.UseAndroid(null, serviceProvider);
			ViewMappingProvider viewMappingProvider = configuration.GetViewMappingProvider();
			BindViewCallback.Instance.BindShellViewHandler = delegate(View view)
			{
				view.InitShellView();
			};
			MugenAndroidUtils.InitializeCompositeUI();
			viewMappingProvider.AddMapping(new ResourceViewMapping(Layout.mugen_main_shell, typeof(MainViewModel), typeof(IActivityView)), exactlyEqual: false);
			viewMappingProvider.AddMapping(new ResourceViewMapping(Layout.mugen_shell, typeof(ShellViewModel), typeof(IActivityView)), exactlyEqual: false);
			return configuration;
		}

		private static void RegisterAttachedMembers(AttachedMemberProvider memberProvider)
		{
			PropertyBuilder<View, OrientationType> propertyBuilder = CompositeUIViewBaseBindableMembers.OrientationPropertyBuilder();
			propertyBuilder = propertyBuilder.Priority(-2000);
			CustomPropertyBuilder<View, OrientationType> customPropertyBuilder = propertyBuilder.Getter((IAccessorMemberInfo<View, OrientationType?> _, View v, IReadOnlyMetadataContext? _) => (!NativeBindableMemberMugenExtensions.IsVertical(v)) ? OrientationType.Horizontal : OrientationType.Vertical);
			customPropertyBuilder = customPropertyBuilder.Setter(delegate(IAccessorMemberInfo<View, OrientationType?> member, View v, OrientationType? newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetOrientation(v, newV == OrientationType.Vertical))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				if (!RecyclerViewMugenExtensions.IsSupported(v))
				{
					v.SetAlignment(v.Alignment());
				}
			});
			customPropertyBuilder = customPropertyBuilder.Observable();
			customPropertyBuilder.Build(memberProvider);
			PropertyBuilder<View, Alignment> propertyBuilder2 = CompositeUIViewBaseBindableMembers.AlignmentPropertyBuilder();
			propertyBuilder2 = propertyBuilder2.Priority(-2000);
			CustomPropertyBuilder<View, Alignment> customPropertyBuilder2 = propertyBuilder2.Getter(delegate(IAccessorMemberInfo<View, Alignment?> member, View s, IReadOnlyMetadataContext? _)
			{
				int gravity = NativeBindableMemberMugenExtensions.GetGravity(s);
				if (gravity == int.MinValue)
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
				return ((GravityFlags)gravity).ToAlignment();
			});
			customPropertyBuilder2 = customPropertyBuilder2.Setter(delegate(IAccessorMemberInfo<View, Alignment?> member, View s, Alignment? v, IReadOnlyMetadataContext? _)
			{
				//IL_0011: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Unknown result type (might be due to invalid IL or missing references)
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Expected I4, but got Unknown
				if (!(v == null))
				{
					GravityFlags val = v.ToNative(NativeBindableMemberMugenExtensions.IsVertical(s));
					if (!NativeBindableMemberMugenExtensions.SetGravity(s, (int)val))
					{
						ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
					}
				}
			});
			customPropertyBuilder2.Build(memberProvider);
			PropertyBuilder<View, ImageStretchMode> propertyBuilder3 = CompositeUIViewBaseBindableMembers.StretchModePropertyBuilder();
			propertyBuilder3 = propertyBuilder3.Priority(-2000);
			CustomPropertyBuilder<View, ImageStretchMode> customPropertyBuilder3 = propertyBuilder3.Getter(delegate(IAccessorMemberInfo<View, ImageStretchMode?> member, View s, IReadOnlyMetadataContext? _)
			{
				int scaleType = NativeBindableMemberMugenExtensions.GetScaleType(s);
				if (scaleType == int.MinValue)
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
				return scaleType.FromScaleType();
			});
			customPropertyBuilder3 = customPropertyBuilder3.Setter(delegate(IAccessorMemberInfo<View, ImageStretchMode?> member, View s, ImageStretchMode? v, IReadOnlyMetadataContext? _)
			{
				if (!(v == null) && !NativeBindableMemberMugenExtensions.SetScaleType(s, v.ToScaleType()))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
			});
			customPropertyBuilder3.Build(memberProvider);
			PropertyBuilder<View, ImageSource> propertyBuilder4 = CompositeUIViewBaseBindableMembers.IconPropertyBuilder();
			propertyBuilder4 = propertyBuilder4.Priority(-2000);
			propertyBuilder4 = propertyBuilder4.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, ImageSource> member, View v, ImageSource _, ImageSource newV, IReadOnlyMetadataContext? _)
			{
				if (newV.TryGetResourceId(out var resourceId) && !NativeBindableMemberMugenExtensions.SetResourceIcon(v, resourceId))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder4.Build(memberProvider);
			PropertyBuilder<View, Color> propertyBuilder5 = CompositeUIViewBaseBindableMembers.BackgroundColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> _, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetBackground(v, newV.ToInt32());
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.TextColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> member, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetTextColor(v, newV.ToInt32()))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			PropertyBuilder<View, TextAlignment> propertyBuilder6 = CompositeUIViewBaseBindableMembers.TextAlignmentPropertyBuilder();
			propertyBuilder6 = propertyBuilder6.Priority(-2000);
			propertyBuilder6 = propertyBuilder6.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, TextAlignment?> member, View v, TextAlignment? _, TextAlignment? newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetTextAlignment(v, newV.ToNative()))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder6.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.TintColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> member, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetTint(v, newV.ToInt32()))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			PropertyBuilder<View, FormattedText> propertyBuilder7 = CompositeUIViewBaseBindableMembers.FormattedTextPropertyBuilder();
			propertyBuilder7 = propertyBuilder7.Priority(-2000);
			propertyBuilder7 = propertyBuilder7.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, FormattedText> member, View v, FormattedText _, FormattedText newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetText(v, newV.ValueString, newV.Format == TextFormat.Html))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder7.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.StrokeColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> _, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetStroke(v, newV, v.StrokeWidth());
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			PropertyBuilder<View, float> propertyBuilder8 = ViewBaseBindableMembers.StrokeWidthPropertyBuilder();
			propertyBuilder8 = propertyBuilder8.Priority(-2000);
			propertyBuilder8 = propertyBuilder8.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, float> _, View v, float _, float newV, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetStroke(v, v.StrokeColor(), newV);
				return newV;
			});
			propertyBuilder8.Build(memberProvider);
			PropertyBuilder<View, KeyboardType> propertyBuilder9 = CompositeUIViewBaseBindableMembers.KeyboardTypePropertyBuilder();
			propertyBuilder9 = propertyBuilder9.Priority(-2000);
			CustomPropertyBuilder<View, KeyboardType> customPropertyBuilder4 = propertyBuilder9.Getter(delegate(IAccessorMemberInfo<View, KeyboardType?> member, View s, IReadOnlyMetadataContext? _)
			{
				int inputType = NativeBindableMemberMugenExtensions.GetInputType(s);
				if (inputType == int.MinValue)
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
				return ((InputTypes)inputType).ToKeyboardType();
			});
			customPropertyBuilder4 = customPropertyBuilder4.Setter(delegate(IAccessorMemberInfo<View, KeyboardType?> member, View s, KeyboardType? v, IReadOnlyMetadataContext? _)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Expected I4, but got Unknown
				if (!NativeBindableMemberMugenExtensions.SetInputType(s, (int)v.ToInputTypes()))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
			});
			customPropertyBuilder4 = customPropertyBuilder4.Observable();
			customPropertyBuilder4.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.TrackTintColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			CustomPropertyBuilder<View, Color> customPropertyBuilder5 = propertyBuilder5.Getter(delegate(IAccessorMemberInfo<View, Color> member, View s, IReadOnlyMetadataContext? _)
			{
				int trackTintColor = NativeBindableMemberMugenExtensions.GetTrackTintColor(s);
				if (trackTintColor == int.MinValue)
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
				return trackTintColor;
			});
			customPropertyBuilder5 = customPropertyBuilder5.Setter(delegate(IAccessorMemberInfo<View, Color> member, View s, Color v, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetTrackTintColor(s, v))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
			});
			customPropertyBuilder5 = customPropertyBuilder5.Observable();
			customPropertyBuilder5.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.ThumbTintColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			customPropertyBuilder5 = propertyBuilder5.Getter(delegate(IAccessorMemberInfo<View, Color> member, View s, IReadOnlyMetadataContext? _)
			{
				int thumbTintColor = NativeBindableMemberMugenExtensions.GetThumbTintColor(s);
				if (thumbTintColor == int.MinValue)
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
				return thumbTintColor;
			});
			customPropertyBuilder5 = customPropertyBuilder5.Setter(delegate(IAccessorMemberInfo<View, Color> member, View s, Color v, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetThumbTintColor(s, v))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)s).GetType(), member.Name);
				}
			});
			customPropertyBuilder5 = customPropertyBuilder5.Observable();
			customPropertyBuilder5.Build(memberProvider);
			PropertyBuilder<View, FontSpec> propertyBuilder10 = CompositeUIViewBaseBindableMembers.FontSpecPropertyBuilder();
			propertyBuilder10 = propertyBuilder10.Priority(-2000);
			propertyBuilder10 = propertyBuilder10.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, FontSpec> member, View v, FontSpec _, FontSpec newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetFont(v, newV.Family, newV.Size, newV.Weight.Weight, newV.Style == FontStyle.Italic))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder10.Build(memberProvider);
			propertyBuilder7 = CompositeUIViewBaseBindableMembers.PlaceholderPropertyBuilder();
			propertyBuilder7 = propertyBuilder7.Priority(-2000);
			propertyBuilder7 = propertyBuilder7.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, FormattedText> member, View v, FormattedText _, FormattedText newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetPlaceholder(v, newV.ValueString, newV.Format == TextFormat.Html))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder7.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.PlaceholderTextColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> member, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetPlaceholderColor(v, newV))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			propertyBuilder5 = CompositeUIViewBaseBindableMembers.CursorColorPropertyBuilder();
			propertyBuilder5 = propertyBuilder5.Priority(-2000);
			propertyBuilder5 = propertyBuilder5.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, Color> member, View v, Color _, Color newV, IReadOnlyMetadataContext? _)
			{
				if (!NativeBindableMemberMugenExtensions.SetCursorColor(v, newV))
				{
					ExceptionManager.ThrowInvalidPathMember(((object)v).GetType(), member.Name);
				}
				return newV;
			});
			propertyBuilder5.Build(memberProvider);
			PropertyBuilder<View, Thickness> propertyBuilder11 = CompositeUIViewBaseBindableMembers.PaddingPropertyBuilder();
			propertyBuilder11 = propertyBuilder11.Priority(-2000);
			propertyBuilder11.Setter(delegate(IAccessorMemberInfo<View, Thickness> _, View v, Thickness m, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetPadding(v, m.Left, m.Top, m.Right, m.Bottom);
			}).Build(memberProvider);
			propertyBuilder11 = CompositeUIViewBaseBindableMembers.MarginPropertyBuilder();
			propertyBuilder11 = propertyBuilder11.Priority(-2000);
			propertyBuilder11.Setter(delegate(IAccessorMemberInfo<View, Thickness> _, View v, Thickness m, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetMargin(v, m.Left, m.Top, m.Right, m.Bottom);
			}).Build(memberProvider);
			PropertyBuilder<View, SectionVisibility> propertyBuilder12 = CompositeUIViewBaseBindableMembers.VisibilityPropertyBuilder();
			propertyBuilder12 = propertyBuilder12.Priority(-2000);
			CustomPropertyBuilder<View, SectionVisibility> customPropertyBuilder6 = propertyBuilder12.Getter((IAccessorMemberInfo<View, SectionVisibility?> _, View v, IReadOnlyMetadataContext? _) => v.Visibility.ToVisibility());
			customPropertyBuilder6 = customPropertyBuilder6.Setter(delegate(IAccessorMemberInfo<View, SectionVisibility?> _, View v, SectionVisibility? m, IReadOnlyMetadataContext? _)
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				v.Visibility = m.ToNative();
			});
			customPropertyBuilder6 = customPropertyBuilder6.Observable();
			customPropertyBuilder6.Build(memberProvider);
			PropertyBuilder<View, CornerRadius> propertyBuilder13 = CompositeUIViewBaseBindableMembers.CornerRadiiPropertyBuilder();
			propertyBuilder13 = propertyBuilder13.Priority(-2000);
			propertyBuilder13 = propertyBuilder13.PropertyChangedHandler(delegate(IAccessorMemberInfo<View, CornerRadius> member, View v, CornerRadius _, CornerRadius newV, IReadOnlyMetadataContext? _)
			{
				NativeBindableMemberMugenExtensions.SetCornerRadius(v, newV.TopLeft, newV.TopRight, newV.BottomRight, newV.BottomLeft);
				return newV;
			});
			propertyBuilder13.Build(memberProvider);
		}
	}
	public static class CompositeUIMetadata
	{
		private static IMetadataContextKey<object?>? _actionInvokerSourceCommand;

		private static IMetadataContextKey<Func<ICompositeCommand, IReadOnlyMetadataContext?, object?>>? _actionInvokerSourceProviderCommand;

		private static IMetadataContextKey<ISectionApiRequest?>? _sectionRequest;

		public static IMetadataContextKey<object?> ActionInvokerSourceCommand
		{
			get
			{
				return _actionInvokerSourceCommand ?? (_actionInvokerSourceCommand = GetBuilder(_actionInvokerSourceCommand, "ActionInvokerSourceCommand").Build());
			}
			[param: AllowNull]
			set
			{
				_actionInvokerSourceCommand = value;
			}
		}

		public static IMetadataContextKey<Func<ICompositeCommand, IReadOnlyMetadataContext?, object?>> ActionInvokerSourceProviderCommand
		{
			get
			{
				return _actionInvokerSourceProviderCommand ?? (_actionInvokerSourceProviderCommand = GetBuilder(_actionInvokerSourceProviderCommand, "ActionInvokerSourceProviderCommand").Build());
			}
			[param: AllowNull]
			set
			{
				_actionInvokerSourceProviderCommand = value;
			}
		}

		public static IMetadataContextKey<ISectionApiRequest?> SectionRequest
		{
			get
			{
				return _sectionRequest ?? (_sectionRequest = GetBuilder(_sectionRequest, "SectionRequest").Build());
			}
			[param: AllowNull]
			set
			{
				_sectionRequest = value;
			}
		}

		private static MetadataContextKey.Builder<T> GetBuilder<T>(IMetadataContextKey<T>? _, string name)
		{
			return MetadataContextKey.Create<T>(typeof(CompositeUIMetadata), name);
		}
	}
	internal sealed class DebugExceptionLoggerCompositeUI : IApiHandlerDecorator<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, OnAppErrorRequest>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, OnAppErrorRequest>
	{
		public ApiProviderDecoratedComponents<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>> Components { get; set; }

		public int Priority => int.MaxValue;

		public IMugenApplication? Owner { get; set; }

		public ValueTask<IAppErrorInfo?> TryInvoke(OnAppErrorRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IMugenService<ILogger>.Optional.Error()?.Log($"{request.ActionId}: source={request.Source}", request.Exception, metadata);
			return Components.TryInvoke(request, apiProvider, metadata, cancellationToken);
		}
	}
	public class ObservableCollectionSectionPredicate
	{
		private sealed class Impl<T> where T : class?
		{
			private static readonly Impl<T> Instance = new Impl<T>();

			public static readonly Func<object?, Optional<T>> Root = Instance.GetRoot;

			private Impl()
			{
			}

			private Optional<T> GetRoot(object? arg)
			{
				if (!MugenExtensions.IsWrappedAs<ISection, IRootSection>(arg))
				{
					return default(Optional<T>);
				}
				return Optional.Get(MugenExtensions.TryUnwrap<ISection, T>(arg));
			}
		}

		public static Func<object?, Optional<T>> Root<T>() where T : class?
		{
			return Impl<T>.Root;
		}
	}
	public sealed class RootSectionWatcher<T> : BindableModelBase, IDisposable where T : class
	{
		private readonly IShellAware _shellAware;

		private IReadOnlyObservableCollection<object>? _bind;

		private T? _section;

		private IShell? _shell;

		public T? Section
		{
			get
			{
				return _section;
			}
			set
			{
				if (!EqualityComparer<T>.Default.Equals(value, _section))
				{
					_section = value;
					OnPropertyChanged(CompositeUIExtensions.SectionArgs);
				}
			}
		}

		public IShell? Shell
		{
			get
			{
				return _shell;
			}
			private set
			{
				if (!object.Equals(value, _shell))
				{
					_shell = value;
					_bind?.Dispose();
					_bind = value?.Sections.Configure().WithState(this).For(ObservableCollectionSectionPredicate.Root<T>())
						.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<T> v, RootSectionWatcher<T> d)
						{
							d.Section = v.Item;
						})
						.Bind();
					OnPropertyChanged(CompositeUIExtensions.ShellArgs);
				}
			}
		}

		public RootSectionWatcher(IShellAware shellAware)
		{
			Should.NotBeNull(shellAware, "shellAware");
			_shellAware = shellAware;
			Shell = shellAware.Shell;
			if (!(shellAware is IShell) && shellAware is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged += OnPropertyChanged;
			}
		}

		public static RootSectionWatcher<T> GetOrAdd(IShellAware shell, string path)
		{
			Should.NotBeNull(shell, "shell");
			AttachedValueStorage attachedValueStorage = shell.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet((ReadOnlySpan<char>)path, out RootSectionWatcher<T> value))
				{
					value = new RootSectionWatcher<T>(shell);
					attachedValueStorage.Set(path, value);
				}
				return value;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		public void Dispose()
		{
			_bind?.Dispose();
			ClearPropertyChangedSubscribers();
			if (!(_shellAware is IShell) && _shellAware is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= OnPropertyChanged;
			}
		}

		private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Shell")
			{
				Shell = _shellAware.Shell;
			}
		}
	}
	public static class SectionKit
	{
		private sealed class VisualShellLayoutSection : ContentLayoutSection, IShellLayoutSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IShellAware
		{
			private ActionToken _token;

			object? IShellLayoutSection.Content => base.Content;

			public Bindable<IShell?> ShellBindable => from shell in this.Bind<ContentLayoutSection, IShell>("Shell")
				where shell != null
				select shell;

			public VisualShellLayoutSection(IVisualSection content)
			{
				base.Content = content;
				_token = content.AsActionToken();
			}

			public VisualShellLayoutSection()
			{
			}

			public VisualShellLayoutSection Init(Bindable<IVisualSection?> bindable)
			{
				_token = bindable.WithAppErrorHandler(this).Bind(this);
				return this;
			}

			protected override void OnDispose(bool disposing)
			{
				if (disposing)
				{
					_token.Dispose();
				}
				base.OnDispose(disposing);
			}
		}

		private sealed class ViewHostSectionWrapper : ContentLayoutSection, INestedCompositeLayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICompositeSection
		{
			private ActionToken _token;

			private IReadOnlyCollection<IVisualSection> _children;

			public IReadOnlyCollection<ISection> Sections => Children;

			public SectionVisibility CompositeSectionVisibility => SectionVisibility.Invisible;

			public IReadOnlyCollection<IVisualSection> Children
			{
				get
				{
					return _children;
				}
				private set
				{
					if (!object.Equals(value, _children))
					{
						_children = value;
						OnPropertyChanged(CompositeUIExtensions.ChildrenArgs);
						OnPropertyChanged(CompositeUIExtensions.SectionsArgs);
					}
				}
			}

			[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ViewHostSectionWrapper))]
			public ViewHostSectionWrapper(Bindable<IVisualSection?> bindable)
			{
				_children = (IReadOnlyCollection<IVisualSection>)(object)Array.Empty<IVisualSection>();
				_token = bindable.WithAppErrorHandler(this).Bind(this);
			}

			protected override void OnDispose(bool disposing)
			{
				if (disposing)
				{
					_token.Dispose();
				}
				base.OnDispose(disposing);
			}

			protected override void OnContentChanged(IVisualSection? oldContent, IVisualSection? newContent)
			{
				base.OnContentChanged(oldContent, newContent);
				IReadOnlyCollection<IVisualSection> children;
				if (newContent != null)
				{
					IReadOnlyCollection<IVisualSection> readOnlyCollection = new DecompiledReadOnlySingleElementList<IVisualSection>(newContent);
					children = readOnlyCollection;
				}
				else
				{
					IReadOnlyCollection<IVisualSection> readOnlyCollection = (IReadOnlyCollection<IVisualSection>)(object)Array.Empty<IVisualSection>();
					children = readOnlyCollection;
				}
				Children = children;
			}
		}

		public static IStackLayoutSectionBase HStack([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			return Stack(OrientationType.Horizontal, children);
		}

		public static IStackLayoutSectionBase VStack([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			return Stack(OrientationType.Vertical, children);
		}

		public static IStackLayoutSectionBase Stack(OrientationType? orientation, [ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			bool isDynamic;
			ImmutableArray<IVisualSection> children2 = children.ToImmutableArray(out isDynamic);
			IStackLayoutSectionBase section;
			if (!isDynamic)
			{
				IStackLayoutSectionBase stackLayoutSectionBase = new StackImmutableSection(children2);
				section = stackLayoutSectionBase;
			}
			else
			{
				IStackLayoutSectionBase stackLayoutSectionBase = new StackSection(children);
				section = stackLayoutSectionBase;
			}
			return section.WithOrientation(orientation ?? OrientationType.Horizontal);
		}

		public static StackSection HStack()
		{
			return Stack(OrientationType.Horizontal);
		}

		public static StackSection VStack()
		{
			return Stack(OrientationType.Vertical);
		}

		public static StackSection Stack(OrientationType? orientation)
		{
			return new StackSection(default(ReadOnlySpan<IVisualSection>)).WithOrientation(orientation ?? OrientationType.Horizontal);
		}

		public static StakeHostSection HStack(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource)
		{
			return Stack(children, disposeSource, OrientationType.Horizontal);
		}

		public static StakeHostSection VStack(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource)
		{
			return Stack(children, disposeSource, OrientationType.Vertical);
		}

		public static StakeHostSection Stack(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, OrientationType? orientation)
		{
			return new StakeHostSection(children, disposeSource).WithOrientation(orientation ?? OrientationType.Horizontal);
		}

		public static CollectionLayoutSection HCollection([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			return new CollectionLayoutSection(children).WithOrientation(OrientationType.Horizontal);
		}

		public static CollectionLayoutSection VCollection([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			return new CollectionLayoutSection(children).WithOrientation(OrientationType.Vertical);
		}

		public static CollectionLayoutSection Collection(OrientationType? orientation)
		{
			return new CollectionLayoutSection(default(ReadOnlySpan<IVisualSection>)).WithOrientation(orientation ?? OrientationType.Horizontal);
		}

		public static CollectionHostLayoutSection Collection(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, OrientationType? orientation = null)
		{
			return new CollectionHostLayoutSection(children, disposeSource).WithOrientation(orientation ?? OrientationType.Vertical);
		}

		public static IFrameLayoutSectionBase Frame([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
		{
			bool isDynamic;
			ImmutableArray<IVisualSection> children2 = children.ToImmutableArray(out isDynamic);
			if (!isDynamic)
			{
				return new FrameImmutableSection(children2);
			}
			return new FrameSection(children);
		}

		public static FrameSection Frame()
		{
			return new FrameSection(default(ReadOnlySpan<IVisualSection>));
		}

		public static FrameHostSection Frame(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource)
		{
			return new FrameHostSection(children, disposeSource);
		}

		public static IVisualSection Content<T>(Bindable<T> bindable) where T : class?, IVisualSection?
		{
			return new ContentLayoutSection().Bind<ContentLayoutSection, IVisualSection>(bindable.AsVisualSection(), delegate(IVisualSection? c, ContentLayoutSection s)
			{
				s.Content = c;
			});
		}

		public static TextSection Text(FormattedText text = default(FormattedText), Bindable<TextAlignment?> textAlignment = default(Bindable<TextAlignment?>), Bindable<Color> textColor = default(Bindable<Color>), Bindable<FontSpec> font = default(Bindable<FontSpec>))
		{
			return Text(Bindable.Constant(text), textAlignment, textColor, font);
		}

		public static TextSection Text(Bindable<FormattedText> text = default(Bindable<FormattedText>), Bindable<TextAlignment?> textAlignment = default(Bindable<TextAlignment?>), Bindable<Color> textColor = default(Bindable<Color>), Bindable<FontSpec> font = default(Bindable<FontSpec>))
		{
			return new TextSection().WithText(text).WithFont(font).WithTextColor(textColor)
				.WithTextAlignment(textAlignment);
		}

		public static ButtonSection Button(FormattedText text = default(FormattedText), Bindable<ImageSource> icon = default(Bindable<ImageSource>), Bindable<FontSpec> font = default(Bindable<FontSpec>))
		{
			return Button(Bindable.Constant(text), icon, font);
		}

		public static ButtonSection Button(Bindable<FormattedText> text = default(Bindable<FormattedText>), Bindable<ImageSource> icon = default(Bindable<ImageSource>), Bindable<FontSpec> font = default(Bindable<FontSpec>))
		{
			return new ButtonSection().WithText(text).WithFont(font).WithIcon(icon);
		}

		public static ImageSection Image(Bindable<ImageSource> source = default(Bindable<ImageSource>), Bindable<ImageStretchMode?> stretchMode = default(Bindable<ImageStretchMode?>), Bindable<SizeF> size = default(Bindable<SizeF>), Bindable<CornerRadius> cornerRadius = default(Bindable<CornerRadius>))
		{
			return new ImageSection().WithSource(source).WithCornerRadius(cornerRadius).WithSize(size)
				.WithImageStretchMode(stretchMode);
		}

		public static NumberInputSection<T> NumberInput<T>(Bindable<KeyboardType?> keyboardType = default(Bindable<KeyboardType?>), Bindable<T> max = default(Bindable<T>), Bindable<T> min = default(Bindable<T>), Bindable<TextAlignment?> textAlignment = default(Bindable<TextAlignment?>), Bindable<Color> textColor = default(Bindable<Color>), Bindable<FontSpec> font = default(Bindable<FontSpec>), Bindable<FormattedText> placeholder = default(Bindable<FormattedText>)) where T : struct, INumber<T>, IMinMaxValue<T>
		{
			return new NumberInputSection<T>().WithFont(font).WithPlaceholder(placeholder).WithTextColor(textColor)
				.WithTextAlignment(textAlignment)
				.WithMax(max)
				.WithMin(min)
				.WithKeyboardType(keyboardType.GetValueOrDefault(KeyboardType.Integer));
		}

		public static TextInputSection TextInput(Bindable<KeyboardType?> keyboardType = default(Bindable<KeyboardType?>), Bindable<TextAlignment?> textAlignment = default(Bindable<TextAlignment?>), Bindable<Color> textColor = default(Bindable<Color>), Bindable<FontSpec> font = default(Bindable<FontSpec>), Bindable<FormattedText> placeholder = default(Bindable<FormattedText>))
		{
			return new TextInputSection().WithFont(font).WithPlaceholder(placeholder).WithTextColor(textColor)
				.WithTextAlignment(textAlignment)
				.WithKeyboardType(keyboardType.GetValueOrDefault(KeyboardType.Text));
		}

		public static SwitchSection Switch(Bindable<Color> trackTintColor = default(Bindable<Color>), Bindable<Color> thumbTintColor = default(Bindable<Color>))
		{
			return new SwitchSection().WithTrackTintColor(trackTintColor).WithThumbTintColor(thumbTintColor);
		}

		public static SpaceSection Space(Bindable<SizeF> size = default(Bindable<SizeF>))
		{
			return new SpaceSection().WithSize(size);
		}

		public static ImmutableArray<IVisualSection> ToImmutableArray(this ReadOnlySpan<IVisualSection?> children, out bool isDynamic)
		{
			bool flag = false;
			ReadOnlySpan<IVisualSection> readOnlySpan = children;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				IVisualSection obj = readOnlySpan[i];
				if (obj == null)
				{
					flag = true;
				}
				if (obj is INestedCompositeLayoutSection)
				{
					isDynamic = true;
					return default(ImmutableArray<IVisualSection>);
				}
			}
			isDynamic = false;
			if (!flag)
			{
				return ImmutableArray.Create(children);
			}
			PooledItemOrList<IVisualSection> pooledItemOrList = new PooledItemOrList<IVisualSection>(children.Length - 1);
			readOnlySpan = children;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				IVisualSection visualSection = readOnlySpan[i];
				if (visualSection != null)
				{
					pooledItemOrList.Add(visualSection);
				}
				if (!isDynamic && visualSection is INestedCompositeLayoutSection)
				{
					isDynamic = true;
				}
			}
			ImmutableArray<IVisualSection> result = ImmutableArray.Create(pooledItemOrList.ReadOnlySpan);
			pooledItemOrList.Dispose();
			return result;
		}

		public static IShellLayoutSection ShellLayout(IVisualSection section)
		{
			Should.NotBeNull(section, "section");
			return new VisualShellLayoutSection(section);
		}

		public static IShellLayoutSection ShellLayout<T>(Bindable<T> bindable) where T : class?, IVisualSection?
		{
			return new VisualShellLayoutSection().Init(bindable.AsVisualSection());
		}

		public static IShellLayoutSection ShellLayout<T>(Func<Bindable<IShell?>, Bindable<T>> getContent) where T : class?, IVisualSection?
		{
			Should.NotBeNull(getContent, "getContent");
			VisualShellLayoutSection visualShellLayoutSection = new VisualShellLayoutSection();
			return visualShellLayoutSection.Init(getContent(visualShellLayoutSection.ShellBindable).AsVisualSection());
		}

		public static IShellLayoutSection ShellLayout<T, TState>(TState state, Func<Bindable<IShell?>, TState, Bindable<T>> getContent) where T : class?, IVisualSection?
		{
			Should.NotBeNull(getContent, "getContent");
			VisualShellLayoutSection visualShellLayoutSection = new VisualShellLayoutSection();
			return visualShellLayoutSection.Init(getContent(visualShellLayoutSection.ShellBindable, state).AsVisualSection());
		}

		public static IVisualSection ViewHost<T>(Bindable<T> bindable) where T : class?, IVisualSection?
		{
			return new ViewHostSectionWrapper(bindable.AsVisualSection());
		}

		public static IVisualSection When(Bindable<bool> cond, [ParamCollection] scoped ReadOnlySpan<IVisualSection> then)
		{
			return new NestedCompositeLayoutsSection((IReadOnlyCollection<IVisualSection>)(object)then.ToArray(), disposeSections: false).WithVisibility(cond);
		}

		public static IVisualSection WhenNot(Bindable<bool> cond, [ParamCollection] scoped ReadOnlySpan<IVisualSection> then)
		{
			return When(cond.Not(), then);
		}

		public static IVisualSection WhenElse(Bindable<bool> cond, IVisualSection then, IVisualSection @else)
		{
			return ViewHost(cond.Transform((then, @else), (bool b, (IVisualSection then, IVisualSection @else) s, IDisposable? _, IBindableListener _) => (!b) ? s.@else : s.then)).WithDisposeToken(then.AsActionToken()).WithDisposeToken(@else.AsActionToken());
		}

		public static IVisualSection ForEach<T>(Bindable<IEnumerable<T>> bindable, Func<T, IVisualSection> template, IEqualityComparer<T>? keyComparer = null) where T : class
		{
			Should.NotBeNull(template, "template");
			if (bindable.IsConstantOrUninitialized())
			{
				IEnumerable<T> constant = bindable.Constant;
				if (constant == null)
				{
					return new SpaceSection();
				}
				if (constant is IReadOnlyObservableCollection<T> items)
				{
					return ForEach(items, template, keyComparer);
				}
				using PooledItemOrList<IVisualSection> items2 = default(PooledItemOrList<IVisualSection>);
				foreach (T item in constant)
				{
					items2.Add(template(item));
				}
				return new NestedCompositeLayoutsSection((IReadOnlyCollection<IVisualSection>)(object)items2.ToArray(), disposeSections: true);
			}
			ObservableList<T> observableList = new ObservableList<T>();
			bindable.Bind<IEnumerable<T>, ObservableList<T>>(observableList, delegate(IEnumerable<T>? i, ObservableList<T> c)
			{
				c.Reset(i);
			}).DisposeWith(observableList);
			return ForEach(observableList, template, keyComparer);
		}

		public static IVisualSection ForEach<T>(IReadOnlyObservableCollection<T> items, Func<T, IVisualSection> template, IEqualityComparer<T>? keyComparer = null) where T : class
		{
			Should.NotBeNull(items, "items");
			Should.NotBeNull(template, "template");
			return new NestedCompositeLayoutsSection(items.Configure().WithState(template).Select((CollectionPredicateItem<T> item, IVisualSection? recycledItem, Func<T, IVisualSection> state) => recycledItem ?? state(item.Item), delegate(T _, IVisualSection s, Func<T, IVisualSection> _)
			{
				s.Dispose();
			}, keyComparer ?? ReferenceEqualityComparer.Instance)
				.BindTyped<IVisualSection>(), disposeSections: true);
		}

		public static IVisualSection IfNotEmpty<T>(IReadOnlyObservableCollection<T> items, IVisualSection content, IVisualSection? empty = null) where T : class
		{
			Should.NotBeNull(items, "items");
			Should.NotBeNull(content, "content");
			return new ViewHostSectionWrapper(items.BindAny().Transform((content, empty), (bool b, (IVisualSection content, IVisualSection empty) s, IDisposable? _, IBindableListener _) => (!b) ? s.empty : s.content)).WithDisposeToken(content.AsActionToken()).WithDisposeToken(empty.AsActionToken());
		}

		internal static Bindable<IVisualSection?> AsVisualSection<T>(this Bindable<T> bindable) where T : class?, IVisualSection?
		{
			return bindable.As<T, IVisualSection>();
		}
	}
	internal sealed class SectionReferenceEqualityComparer : IEqualityComparer<ISection>
	{
		public static readonly SectionReferenceEqualityComparer Instance = new SectionReferenceEqualityComparer();

		private SectionReferenceEqualityComparer()
		{
		}

		public bool Equals(ISection? x, ISection? y)
		{
			return x?.Inner == y?.Inner;
		}

		public int GetHashCode(ISection obj)
		{
			return RuntimeHelpers.GetHashCode(obj.Inner);
		}
	}
	public class ShellHandlerProvider : IApiHandlerComponent<IMugenApplication, GetShellHandlersRequest, PooledReadOnlyList<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetShellHandlersRequest>, IHasPriority
	{
		private readonly IBusyManager? _busyManager;

		public int Priority { get; init; } = 2147483637;

		public ShellHandlerProvider(IBusyManager? busyManager = null)
		{
			_busyManager = busyManager;
		}

		public PooledReadOnlyList<ISection> TryInvoke(GetShellHandlersRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			PooledListSlim<ISection> sections = new PooledListSlim<ISection>();
			try
			{
				AddShellSections(request.Request, apiProvider, metadata, ref sections);
				AddRequestSections(request.Request, apiProvider, metadata, ref sections);
				return sections;
			}
			catch
			{
				sections.Dispose();
				throw;
			}
		}

		protected virtual void AddRequestSections(ISectionApiRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections)
		{
		}

		protected virtual void AddShellSections(ISectionApiRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections)
		{
			sections.Add(new ShellSectionHandler());
			sections.Add(new CloseConditionSectionHandler());
			sections.Add(new CommandSynchronizerSection());
			sections.Add(new AppErrorsAwareSection());
			sections.Add(new BusyTokensAwareSection());
			sections.Add(new ValidationErrorsAwareSection());
			sections.Add(new ViewsAwareSection());
			sections.Add(new CommandBusySectionHandler(_busyManager));
			if (request is IHasShellSectionsSectionApiRequest hasShellSectionsSectionApiRequest)
			{
				hasShellSectionsSectionApiRequest.AddShellSections(apiProvider, metadata, ref sections);
			}
			if (request is IWorkflowSectionApiRequest state)
			{
				sections.Add(new WorkflowSectionHandler(state, out var stepsSection));
				sections.Add(stepsSection);
			}
		}
	}
	public sealed class ShellSectionPresenter : IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISectionApiRequestHandler, IHasPriority
	{
		public int Priority { get; init; } = -1000;

		public TResponse TryInvoke<TRequest, TResponse>(TRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken) where TRequest : IApiRequestBase<IMugenApplication, TRequest, TResponse>
		{
			return ((ISectionApiRequest)(object)request).TryInvoke<TResponse>(this, apiProvider, metadata, cancellationToken);
		}

		public async ValueTask<Optional<TResult>> HandleGeneric<TResult>(ISectionApiRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = null;
			try
			{
				metadata = metadata.WithValue(CompositeUIMetadata.SectionRequest, request);
				Optional<TResult> response = default(Optional<TResult>);
				if (request is IHasOpenConditionSectionApiRequest hasOpenConditionSectionApiRequest && !(await hasOpenConditionSectionApiRequest.CanOpenAsync(apiProvider, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
				{
					response = Optional.Default;
				}
				if (!response.IsInitialized)
				{
					Optional<Optional<TResult>> optional = ((!(request is IHasOpenHandlerSectionApiRequest<TResult> hasOpenHandlerSectionApiRequest)) ? default(Optional<Optional<TResult>>) : (await hasOpenHandlerSectionApiRequest.HandleAsync(apiProvider, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
					if (optional.HasValue)
					{
						response = optional.Value;
					}
					else
					{
						(IShell, Task) tuple = ShowShell(request, metadata, cancellationToken);
						(shell, _) = tuple;
						await tuple.Item2.ConfigureAwait(continueOnCapturedContext: false);
						response = TryGetResponse<TResult>(shell);
					}
				}
				if (request is IHasCloseHandlerSectionApiRequest<TResult> hasCloseHandlerSectionApiRequest)
				{
					return await hasCloseHandlerSectionApiRequest.HandleAsync(apiProvider, shell, response, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				return response;
			}
			finally
			{
				shell?.Dispose();
			}
		}

		public bool IsRequestSupported(IMugenApplication owner, ComponentDescriptor descriptor)
		{
			return typeof(ISectionApiRequest).IsAssignableFrom(descriptor.RequestType);
		}

		private static Optional<TResult> TryGetResponse<TResult>(IShell shell)
		{
			if (typeof(TResult) != typeof(UnitRef) && typeof(TResult) != typeof(Unit))
			{
				foreach (ISection section in shell.Sections)
				{
					IHasResult<Optional<TResult>> hasResult = section.TryUnwrap<ISection, IHasResult<Optional<TResult>>>();
					if (hasResult != null)
					{
						Optional<TResult> result = hasResult.Result;
						if (result.IsInitialized)
						{
							return result;
						}
					}
				}
			}
			return default(Optional<TResult>);
		}

		private static (IShell, Task) ShowShell(ISectionApiRequest request, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			PooledReadOnlyList<NavigationResult> values = default(PooledReadOnlyList<NavigationResult>);
			IShell shell = null;
			try
			{
				if (request is IModalSectionRequest modalSectionRequest)
				{
					metadata = metadata.WithValue(NavigationMetadata.Modal, modalSectionRequest.IsModal);
				}
				shell = IMugenService<IViewModelManager>.Instance.TryInvoke<IViewModelManager, GetShellViewModelRequest, IShell>(new GetShellViewModelRequest(request), metadata, cancellationToken) ?? new ShellViewModel(IMugenService<IMugenApplication>.Instance.GetShellHandlers(request, metadata, cancellationToken).ToItemOrArrayDispose(), metadata);
				bool flag = false;
				if (shell is IMetadataOwner<IMetadataContext> metadataOwner)
				{
					flag = metadataOwner.Metadata.Contains(CompositeUIMetadata.SectionRequest);
					metadataOwner.Metadata.Set(CompositeUIMetadata.SectionRequest, request);
				}
				if (!flag || request.IsReloadOnReopen)
				{
					shell.TryGetRootReloadCommand()?.ExecuteAsync(request.GetSectionsRequest(shell, metadata), metadata, cancellationToken);
				}
				values = IMugenService<INavigationDispatcher>.Instance.TryInvoke<INavigationDispatcher, ShowShellRequest, PooledReadOnlyList<NavigationResult>>(new ShowShellRequest(shell, request), metadata, cancellationToken);
				if (values.Count == 0)
				{
					values = IMugenService<INavigationDispatcher>.Instance.ShowViewModel(shell, null, metadata, cancellationToken);
				}
				return (shell, values.WaitCloseAsync(metadata, cancellationToken));
			}
			catch
			{
				shell?.Dispose();
				throw;
			}
			finally
			{
				values.Dispose();
			}
		}
	}
	public class Resource : Resource
	{
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class IHasVisibilityBaseBindableMembers
	{
		public const string VisibilityPropertyName = "Visibility";

		public static Type TargetType => typeof(IHasVisibilitySection);

		public static Type VisibilityPropertyType => typeof(SectionVisibility);

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetVisibilityAccessorMember(IHasVisibilitySection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetVisibilityAccessorMember(IHasVisibilitySection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata);
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetVisibilityAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetVisibilityAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<IHasVisibilitySection, SectionVisibility?> VisibilityPropertyBuilder()
		{
			return new PropertyBuilder<IHasVisibilitySection, SectionVisibility>("Visibility", typeof(IHasVisibilitySection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, SectionVisibility?> VisibilityPropertyBuilder<T>() where T : class, IHasVisibilitySection
		{
			return new PropertyBuilder<T, SectionVisibility>("Visibility", typeof(T));
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<SectionVisibility?> BindVisibility<T>(this T target) where T : class, IHasVisibilitySection
		{
			return target.Bind<T, SectionVisibility>("Visibility");
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, SectionVisibility?> BindVisibilityTarget<T>(this T target) where T : class, IHasVisibilitySection
		{
			return target.BindTarget<T, SectionVisibility>("Visibility");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		public static BindingSyntax<T, SectionVisibility?> BindVisibilityTarget<T>(this BindingResult<T> target) where T : class, IHasVisibilitySection
		{
			return target.Target.BindTarget<T, SectionVisibility>("Visibility");
		}

		[DynamicDependency("Visibility", typeof(IHasVisibilitySection))]
		[BindingMember("Visibility")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static SectionVisibility? Visibility(this IBindingSyntaxExtension<IHasVisibilitySection> target)
		{
			throw new NotSupportedException();
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class IVisualSectionBaseBindableMembers
	{
		public const string TryGetModifierChangedEventName = "TryGetModifierChanged";

		private static Expression? _TryGetModifierChangedE;

		public static Type TargetType => typeof(IVisualSection);

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IObservableMemberInfo? TryGetTryGetModifierChangedEventMember(IVisualSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Event, MemberFlags.InstanceAll, "TryGetModifierChanged", metadata) as IObservableMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IObservableMemberInfo GetTryGetModifierChangedEventMember(IVisualSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IObservableMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Event, MemberFlags.InstanceAll, "TryGetModifierChanged", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IObservableMemberInfo? TryGetTryGetModifierChangedEventMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Event, MemberFlags.InstanceAll, "TryGetModifierChanged", metadata) as IObservableMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IObservableMemberInfo GetTryGetModifierChangedEventMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IObservableMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Event, MemberFlags.InstanceAll, "TryGetModifierChanged", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static EventBuilder<IVisualSection> TryGetModifierChangedEventBuilder()
		{
			return new EventBuilder<IVisualSection>("TryGetModifierChanged", typeof(IVisualSection), typeof(EventHandler));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static EventBuilder<T> TryGetModifierChangedEventBuilder<T>() where T : class, IVisualSection
		{
			return new EventBuilder<T>("TryGetModifierChanged", typeof(T), typeof(EventHandler));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, BindingSyntaxEvent> BindTryGetModifierChanged<T>(this T target) where T : class, IVisualSection
		{
			return new BindingSyntax<T, BindingSyntaxEvent>(target, _TryGetModifierChangedE ?? (_TryGetModifierChangedE = Expression.Constant(new MemberExpressionNode(null, "TryGetModifierChanged"))));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, BindingSyntaxEvent> BindTryGetModifierChanged<T>(this BindingResult<T> target) where T : class, IVisualSection
		{
			return new BindingSyntax<T, BindingSyntaxEvent>(target.Target, _TryGetModifierChangedE ?? (_TryGetModifierChangedE = Expression.Constant(new MemberExpressionNode(null, "TryGetModifierChanged"))));
		}

		[BindingMember("TryGetModifierChanged")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntaxEvent TryGetModifierChangedEvent(this IBindingSyntaxExtension<IVisualSection> target)
		{
			throw new NotSupportedException();
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ActionToken SubscribeToTryGetModifierChanged(this IVisualSection item, IEventListener listener, IReadOnlyMetadataContext? metadata = null)
		{
			return GetTryGetModifierChangedEventMember(item, metadata).TryObserve(item, listener, metadata);
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class ITextInputLayoutSSectionBaseBindableMembers
	{
		public const string TextPropertyName = "Text";

		public static Type TargetType => typeof(ITextInputSection);

		public static Type TextPropertyType => typeof(string);

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(ITextInputSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(ITextInputSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<ITextInputSection, string?> TextPropertyBuilder()
		{
			return new PropertyBuilder<ITextInputSection, string>("Text", typeof(ITextInputSection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, string?> TextPropertyBuilder<T>() where T : class, ITextInputSection
		{
			return new PropertyBuilder<T, string>("Text", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<string?> BindText<T>(this T target) where T : class, ITextInputSection
		{
			return target.Bind<T, string>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, string?> BindTextTarget<T>(this T target) where T : class, ITextInputSection
		{
			return target.BindTarget<T, string>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, string?> BindTextTarget<T>(this BindingResult<T> target) where T : class, ITextInputSection
		{
			return target.Target.BindTarget<T, string>("Text");
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static string? Text(this IBindingSyntaxExtension<ITextInputSection> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static string? Text(this ITextInputSection item, IReadOnlyMetadataContext? metadata)
		{
			return GetTextAccessorMember(item, metadata).GetValue<string>(item, metadata);
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static string? Text(this ITextInputSection item)
		{
			return item.Text(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ITextInputSection SetText(this ITextInputSection item, string? value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTextAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class ITextLayoutSectionBaseBindableMembers
	{
		public const string TextPropertyName = "Text";

		public static Type TargetType => typeof(ITextSection);

		public static Type TextPropertyType => typeof(FormattedText);

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(ITextSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(ITextSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<ITextSection, FormattedText> TextPropertyBuilder()
		{
			return new PropertyBuilder<ITextSection, FormattedText>("Text", typeof(ITextSection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, FormattedText> TextPropertyBuilder<T>() where T : class, ITextSection
		{
			return new PropertyBuilder<T, FormattedText>("Text", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<FormattedText> BindText<T>(this T target) where T : class, ITextSection
		{
			return target.Bind<T, FormattedText>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, FormattedText> BindTextTarget<T>(this T target) where T : class, ITextSection
		{
			return target.BindTarget<T, FormattedText>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, FormattedText> BindTextTarget<T>(this BindingResult<T> target) where T : class, ITextSection
		{
			return target.Target.BindTarget<T, FormattedText>("Text");
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this IBindingSyntaxExtension<ITextSection> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this ITextSection item, IReadOnlyMetadataContext? metadata)
		{
			return GetTextAccessorMember(item, metadata).GetValue<FormattedText>(item, metadata);
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this ITextSection item)
		{
			return item.Text(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ITextSection SetText(this ITextSection item, FormattedText value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTextAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class IButtonLayoutSectionBaseBindableMembers
	{
		public const string TextPropertyName = "Text";

		public const string IconPropertyName = "Icon";

		public static Type TargetType => typeof(IButtonSection);

		public static Type TextPropertyType => typeof(FormattedText);

		public static Type IconPropertyType => typeof(ImageSource);

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(IButtonSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(IButtonSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Text", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<IButtonSection, FormattedText> TextPropertyBuilder()
		{
			return new PropertyBuilder<IButtonSection, FormattedText>("Text", typeof(IButtonSection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, FormattedText> TextPropertyBuilder<T>() where T : class, IButtonSection
		{
			return new PropertyBuilder<T, FormattedText>("Text", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<FormattedText> BindText<T>(this T target) where T : class, IButtonSection
		{
			return target.Bind<T, FormattedText>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, FormattedText> BindTextTarget<T>(this T target) where T : class, IButtonSection
		{
			return target.BindTarget<T, FormattedText>("Text");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, FormattedText> BindTextTarget<T>(this BindingResult<T> target) where T : class, IButtonSection
		{
			return target.Target.BindTarget<T, FormattedText>("Text");
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this IBindingSyntaxExtension<IButtonSection> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this IButtonSection item, IReadOnlyMetadataContext? metadata)
		{
			return GetTextAccessorMember(item, metadata).GetValue<FormattedText>(item, metadata);
		}

		[BindingMember("Text")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static FormattedText Text(this IButtonSection item)
		{
			return item.Text(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IButtonSection SetText(this IButtonSection item, FormattedText value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTextAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetIconAccessorMember(IButtonSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetIconAccessorMember(IButtonSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetIconAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetIconAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<IButtonSection, ImageSource> IconPropertyBuilder()
		{
			return new PropertyBuilder<IButtonSection, ImageSource>("Icon", typeof(IButtonSection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, ImageSource> IconPropertyBuilder<T>() where T : class, IButtonSection
		{
			return new PropertyBuilder<T, ImageSource>("Icon", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<ImageSource> BindIcon<T>(this T target) where T : class, IButtonSection
		{
			return target.Bind<T, ImageSource>("Icon");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, ImageSource> BindIconTarget<T>(this T target) where T : class, IButtonSection
		{
			return target.BindTarget<T, ImageSource>("Icon");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, ImageSource> BindIconTarget<T>(this BindingResult<T> target) where T : class, IButtonSection
		{
			return target.Target.BindTarget<T, ImageSource>("Icon");
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ImageSource Icon(this IBindingSyntaxExtension<IButtonSection> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ImageSource Icon(this IButtonSection item, IReadOnlyMetadataContext? metadata)
		{
			return GetIconAccessorMember(item, metadata).GetValue<ImageSource>(item, metadata);
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ImageSource Icon(this IButtonSection item)
		{
			return item.Icon(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IButtonSection SetIcon(this IButtonSection item, ImageSource value, IReadOnlyMetadataContext? metadata = null)
		{
			GetIconAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class IImageLayoutSectionBaseBindableMembers
	{
		public const string SourcePropertyName = "Source";

		public static Type TargetType => typeof(IImageSection);

		public static Type SourcePropertyType => typeof(ImageSource);

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetSourceAccessorMember(IImageSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Source", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetSourceAccessorMember(IImageSection item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(item.GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Source", metadata);
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetSourceAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Source", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetSourceAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Source", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<IImageSection, ImageSource> SourcePropertyBuilder()
		{
			return new PropertyBuilder<IImageSection, ImageSource>("Source", typeof(IImageSection));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, ImageSource> SourcePropertyBuilder<T>() where T : class, IImageSection
		{
			return new PropertyBuilder<T, ImageSource>("Source", typeof(T));
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<ImageSource> BindSource<T>(this T target) where T : class, IImageSection
		{
			if (!RuntimeFeature.IsDynamicCodeSupported)
			{
				PropertyAccessorMemberInfoBase.LinkerInclude<ImageSource>();
			}
			return target.Bind<T, ImageSource>("Source");
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, ImageSource> BindSourceTarget<T>(this T target) where T : class, IImageSection
		{
			if (!RuntimeFeature.IsDynamicCodeSupported)
			{
				PropertyAccessorMemberInfoBase.LinkerInclude<ImageSource>();
			}
			return target.BindTarget<T, ImageSource>("Source");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		[DynamicDependency("Source", typeof(IImageSection))]
		public static BindingSyntax<T, ImageSource> BindSourceTarget<T>(this BindingResult<T> target) where T : class, IImageSection
		{
			if (!RuntimeFeature.IsDynamicCodeSupported)
			{
				PropertyAccessorMemberInfoBase.LinkerInclude<ImageSource>();
			}
			return target.Target.BindTarget<T, ImageSource>("Source");
		}

		[DynamicDependency("Source", typeof(IImageSection))]
		[BindingMember("Source")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static ImageSource Source(this IBindingSyntaxExtension<IImageSection> target)
		{
			if (!RuntimeFeature.IsDynamicCodeSupported)
			{
				PropertyAccessorMemberInfoBase.LinkerInclude<ImageSource>();
			}
			throw new NotSupportedException();
		}
	}
}
namespace MugenMvvm.CompositeUI.Extensions
{
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class MugenMvvmCompositeUIApiExtensions
	{
		[MustDisposeResource]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PooledReadOnlyList<IAppErrorInfo> GetAppErrors(this IMugenApplication apiProvider, object source, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetAppErrorsRequest request = new GetAppErrorsRequest(source);
			return apiProvider.TryInvoke<IMugenApplication, GetAppErrorsRequest, PooledReadOnlyList<IAppErrorInfo>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<LayoutDirType> GetLayoutDirection(this IMugenApplication apiProvider, IShellAware section, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetLayoutDirectionRequest request = new GetLayoutDirectionRequest(section, relative);
			return apiProvider.Invoke<IMugenApplication, GetLayoutDirectionRequest, Bindable<LayoutDirType>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<LayoutDirType> TryGetLayoutDirection(this IMugenApplication apiProvider, IShellAware section, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetLayoutDirectionRequest request = new GetLayoutDirectionRequest(section, relative);
			return apiProvider.TryInvoke<IMugenApplication, GetLayoutDirectionRequest, Bindable<LayoutDirType>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<ScreenMetrics> GetScreenMetrics(this IMugenApplication apiProvider, IShellAware section, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetScreenMetricsRequest request = new GetScreenMetricsRequest(section, relative);
			return apiProvider.Invoke<IMugenApplication, GetScreenMetricsRequest, Bindable<ScreenMetrics>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<ScreenMetrics> TryGetScreenMetrics(this IMugenApplication apiProvider, IShellAware section, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetScreenMetricsRequest request = new GetScreenMetricsRequest(section, relative);
			return apiProvider.TryInvoke<IMugenApplication, GetScreenMetricsRequest, Bindable<ScreenMetrics>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PooledReadOnlyList<ISection> GetShellHandlers(this IMugenApplication apiProvider, ISectionApiRequest request, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetShellHandlersRequest request2 = new GetShellHandlersRequest(request);
			return apiProvider.TryInvoke<IMugenApplication, GetShellHandlersRequest, PooledReadOnlyList<ISection>>(request2, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<Thickness> GetSystemInsets(this IMugenApplication apiProvider, IShellAware section, SystemInsetType type, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetSystemInsetsRequest request = new GetSystemInsetsRequest(section, type, relative);
			return apiProvider.Invoke<IMugenApplication, GetSystemInsetsRequest, Bindable<Thickness>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<Thickness> TryGetSystemInsets(this IMugenApplication apiProvider, IShellAware section, SystemInsetType type, bool relative, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			GetSystemInsetsRequest request = new GetSystemInsetsRequest(section, type, relative);
			return apiProvider.TryInvoke<IMugenApplication, GetSystemInsetsRequest, Bindable<Thickness>>(request, metadata, cancellationToken);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Task HideKeyboardAsync(this IView apiProvider, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			HideKeyboardViewRequest instance = HideKeyboardViewRequest.Instance;
			return apiProvider.TryInvoke<IView, HideKeyboardViewRequest, Task>(instance, metadata, cancellationToken) ?? Task.CompletedTask;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static bool OnCancelAppErrorById(this IMugenApplication apiProvider, object source, string actionId, IReadOnlyMetadataContext? metadata = null)
		{
			OnCancelAppErrorByIdRequest request = new OnCancelAppErrorByIdRequest(source, actionId);
			return apiProvider.TryInvoke<IMugenApplication, OnCancelAppErrorByIdRequest, bool?>(request, metadata) == true;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static bool OnCancelAppError(this IMugenApplication apiProvider, IAppErrorInfo error, IReadOnlyMetadataContext? metadata = null)
		{
			OnCancelAppErrorRequest request = new OnCancelAppErrorRequest(error);
			return apiProvider.TryInvoke<IMugenApplication, OnCancelAppErrorRequest, bool?>(request, metadata) == true;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static bool RegisterAppErrorListener(this IMugenApplication apiProvider, object source, IAppErrorListener listener, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			RegisterAppErrorListenerRequest request = new RegisterAppErrorListenerRequest(source, listener);
			return apiProvider.TryInvoke<IMugenApplication, RegisterAppErrorListenerRequest, bool?>(request, metadata, cancellationToken) == true;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Task ResetLayoutAsync(this IView apiProvider, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ResetLayoutViewRequest instance = ResetLayoutViewRequest.Instance;
			return apiProvider.TryInvoke<IView, ResetLayoutViewRequest, Task>(instance, metadata, cancellationToken) ?? Task.CompletedTask;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static bool UnregisterAppErrorListener(this IMugenApplication apiProvider, object source, IAppErrorListener listener, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			UnregisterAppErrorListenerRequest request = new UnregisterAppErrorListenerRequest(source, listener);
			return apiProvider.TryInvoke<IMugenApplication, UnregisterAppErrorListenerRequest, bool?>(request, metadata, cancellationToken) == true;
		}
	}
}
namespace MugenMvvm.CompositeUI.ViewModels
{
	public class MainViewModel : ShellViewModel
	{
		private readonly bool _singleton;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(MainViewModel))]
		public MainViewModel(bool singleton, ItemOrIReadOnlyList<ISection> handlers, IReadOnlyMetadataContext? metadata = null)
			: base(handlers, metadata)
		{
			_singleton = singleton;
		}

		public override void Dispose()
		{
			if (!_singleton)
			{
				base.Dispose();
			}
		}
	}
	public sealed class MainViewModelProvider : IApiHandlerComponent<IViewModelManager, GetShellViewModelRequest, IShell>, IApiHandlerComponent<IViewModelManager>, IApiProviderComponent<IViewModelManager>, IApiProviderComponent, IComponent, ISupportRequestComponent<IViewModelManager>, IComponent<IViewModelManager>, ISupportApiHandlerComponent<IViewModelManager, GetShellViewModelRequest>, IApiHandlerComponent<IViewModelManager, GetViewModelByTypeRequest, object>, ISupportApiHandlerComponent<IViewModelManager, GetViewModelByTypeRequest>, IHasPriority
	{
		private readonly ISectionApiRequest _mainSection;

		private readonly bool _singleton;

		private MainViewModel? _mainViewModel;

		public int Priority { get; init; }

		public MainViewModelProvider(ISectionApiRequest mainSection, bool singleton = true)
		{
			Should.NotBeNull(mainSection, "mainSection");
			_mainSection = mainSection;
			_singleton = singleton;
		}

		public IShell? TryInvoke(GetShellViewModelRequest request, IViewModelManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (!(request.Request is MainSectionRequest))
			{
				return null;
			}
			return GetViewModel(metadata, cancellationToken);
		}

		public object? TryInvoke(GetViewModelByTypeRequest request, IViewModelManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.ViewModelType == typeof(MainViewModel))
			{
				return GetViewModel(metadata, cancellationToken);
			}
			return null;
		}

		private MainViewModel CreateMainViewModel(bool singleton, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			ItemOrArray<ISection> itemOrArray = IMugenService<IMugenApplication>.Instance.GetShellHandlers(_mainSection, metadata, cancellationToken).ToItemOrArrayDispose();
			MainViewModel mainViewModel = new MainViewModel(singleton, itemOrArray, metadata);
			((IMetadataOwner<ICompositeMetadataContext>)mainViewModel).Metadata.Set(CompositeUIMetadata.SectionRequest, _mainSection);
			ICompositeCommand? compositeCommand = mainViewModel.TryGetRootReloadCommand();
			if (compositeCommand != null)
			{
				compositeCommand.Execute(_mainSection, metadata);
				return mainViewModel;
			}
			return mainViewModel;
		}

		private MainViewModel GetViewModel(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (!_singleton)
			{
				return CreateMainViewModel(singleton: false, metadata, cancellationToken);
			}
			if (_mainViewModel == null)
			{
				lock (this)
				{
					if (_mainViewModel == null)
					{
						_mainViewModel = CreateMainViewModel(singleton: true, metadata, CancellationToken.None);
					}
				}
			}
			return _mainViewModel;
		}
	}
	[DebuggerTypeProxy(typeof(ShellDebugView))]
	public class ShellViewModel : CompositeSectionBase, IShell, INotifyPropertyChanged, IShellSection, IShellAware, IHasDisposeCallback, IHasDisposedState, IDisposable, ISupportDisposeCallback, ICompositeMetadataOwner, ILazyMetadataOwner<ICompositeMetadataContext>, IMetadataOwner<ICompositeMetadataContext>
	{
		public static readonly string[] ObservablePropertiesComposite = new string[8] { "Visibility", "Sections", "Flatten", "CompositeSectionVisibility", "Priority", "TemplateKey", "Modifiers", "$Reload" };

		public static readonly string[] ObservableProperties = new string[5] { "Visibility", "Priority", "TemplateKey", "Modifiers", "$Reload" };

		private readonly object? _handlers;

		private ICompositeMetadataContext? _metadata;

		private IShellLayoutSection? _layout;

		private HeaderFooterCollectionDecorator? _handlersDecorator;

		public IShellLayoutSection? Layout
		{
			get
			{
				return _layout;
			}
			private set
			{
				if (!object.Equals(value, _layout))
				{
					_layout = value;
					OnPropertyChanged(CompositeUIExtensions.LayoutArgs);
				}
			}
		}

		protected override bool RaisePendingNotifications => true;

		ref ICompositeMetadataContext? ICompositeMetadataOwner.MetadataRaw => ref _metadata;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ShellViewModel))]
		public ShellViewModel(ItemOrIReadOnlyList<ISection> handlers, IReadOnlyMetadataContext? metadata = null)
		{
			_handlers = handlers.GetRawValue();
			IMugenService<IViewModelManager>.Instance.OnLifecycleChanged(this, ViewModelLifecycleState.Created, metadata);
		}

		protected override void OnDispose(bool disposing)
		{
			if (!disposing)
			{
				IMugenService<IViewModelManager>.Instance.OnLifecycleChanged(this, ViewModelLifecycleState.Finalized);
				base.OnDispose(disposing: false);
				return;
			}
			IMugenService<IViewModelManager>.Instance.OnLifecycleChanged(this, ViewModelLifecycleState.Disposing);
			base.OnDispose(disposing: true);
			foreach (ISection item in ItemOrIReadOnlyList.FromRawValue<ISection>(_handlers))
			{
				item.Dispose();
			}
			IMugenService<IViewModelManager>.Instance.OnLifecycleChanged(this, ViewModelLifecycleState.Disposed);
		}

		protected override ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			ItemOrIReadOnlyList<object> headers = ItemOrIReadOnlyList.FromRawValue<object>(_handlers);
			bool flag = false;
			if (!headers.IsEmpty)
			{
				configuration = configuration.WithHeadersFooters(headers).GetComponent(out _handlersDecorator);
				foreach (object item in headers)
				{
					if (item is IShellConfigurationHandlerSection shellConfigurationHandlerSection)
					{
						flag = true;
						configuration = shellConfigurationHandlerSection.OnConfiguring(configuration);
					}
				}
			}
			configuration = configuration.AutoRefreshOnPropertyChangedSection(ObservablePropertiesComposite, CompositeUIExtensions.GetReloadArgs).AutoRefreshOnVisualSectionVisibilityChanged().GetComponent(out ITrackerCollectionDecorator<ISection, ISection> component)
				.WithSectionPriority()
				.WithSectionVisibilityFilter(includeInvisible: true)
				.FlattenCompositeSection(checkVisibility: true)
				.WithState(component, delegate(object? o, ITrackerCollectionDecorator<ISection, ISection> t)
				{
					ISection section = (ISection)o;
					return Optional.Get(section, !t.ContainsKey(section));
				})
				.AutoRefreshOnPropertyChangedSection(ObservableProperties, CompositeUIExtensions.GetReloadArgs)
				.AutoRefreshOnVisualSectionVisibilityChanged()
				.WithState(component, delegate(object? o, ITrackerCollectionDecorator<ISection, ISection> t)
				{
					ISection section = (ISection)o;
					if (!t.ContainsKey(section))
					{
						return Optional.None;
					}
					ISection section2 = section.TryUnwrap<ISection, IHasReadOnlyVisibilitySection>();
					return Optional.Get(section2 ?? section.TryUnwrap<ISection, IVisualSection>());
				})
				.Where((Func<ISection, ITrackerCollectionDecorator<ISection, ISection>, bool>)CompositeUIExtensions.WithSectionVisibilityFilterImpl)
				.WithState(component, delegate(object? o, ITrackerCollectionDecorator<ISection, ISection> t)
				{
					ISection section = (ISection)o;
					return Optional.Get(section, !t.ContainsKey(section));
				})
				.WithSectionPriority()
				.For<ISection>()
				.WithState(this)
				.TrackItems(OnSectionAdded, OnSectionRemoved, SectionReferenceEqualityComparer.Instance)
				.ForWrapper<ISection, IShellLayoutSection>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IShellLayoutSection> v, ShellViewModel d)
				{
					d.Layout = v.Item;
				})
				.For<ISection>()
				.NoState();
			if (flag)
			{
				foreach (object item2 in headers)
				{
					if (item2 is IShellConfigurationHandlerSection shellConfigurationHandlerSection2)
					{
						configuration = shellConfigurationHandlerSection2.OnConfigured(configuration);
					}
				}
			}
			else
			{
				_handlersDecorator = null;
			}
			return configuration;
		}

		protected override void OnSectionInitialized()
		{
			if (_handlersDecorator == null)
			{
				return;
			}
			PooledItemOrList<ISection> additionalSections = default(PooledItemOrList<ISection>);
			try
			{
				foreach (object item in ItemOrIReadOnlyList.FromRawValue<object>(_handlers))
				{
					if (item is IShellConfigurationHandlerSection shellConfigurationHandlerSection)
					{
						shellConfigurationHandlerSection.OnInitialized(this, ref additionalSections);
					}
				}
				Span<ISection> span = additionalSections.Span;
				if (span.Length == 1)
				{
					_handlersDecorator.SetFooter(ItemOrIReadOnlyList.FromItem((object?)span[0]));
				}
				else if (span.Length != 0)
				{
					HeaderFooterCollectionDecorator? handlersDecorator = _handlersDecorator;
					object[] array = span.ToArray();
					handlersDecorator.SetFooter(ItemOrIReadOnlyList.FromList(array));
				}
			}
			finally
			{
				additionalSections.Dispose();
			}
		}

		private static void OnSectionAdded(ISection section, ShellViewModel state)
		{
			section.Attach(state);
		}

		private static void OnSectionRemoved(ISection section, ShellViewModel state)
		{
			section.Detach(state);
		}
	}
}
namespace MugenMvvm.CompositeUI.Templating
{
	public abstract class CompositeUIContentTemplateSelectorBase<TContainer, TView> : ContentTemplateSelectorBase<TContainer, TView>, IRenderersAwareTemplateSelector<TContainer, TView> where TContainer : class where TView : class
	{
		private DictionarySlim<string, SectionModifierRendererTemplateState<TView>> _rendersCache = new DictionarySlim<string, SectionModifierRendererTemplateState<TView>>(11);

		private DictionarySlim<int, SectionModifierRendererTemplateState<TView>> _templateToRenderer = new DictionarySlim<int, SectionModifierRendererTemplateState<TView>>();

		public override void OnAttached(TContainer container, TView view, object? item, IReadOnlyMetadataContext? metadata)
		{
			base.OnAttached(container, view, item, metadata);
			if (_templateToRenderer.TryGetValue(GetReuseId(container, view, metadata), out SectionModifierRendererTemplateState<TView> value) && value.HasAttachable)
			{
				value.OnAttached(container, view, metadata);
			}
		}

		public override void OnDetached(TContainer container, TView view, object? item, IReadOnlyMetadataContext? metadata)
		{
			base.OnDetached(container, view, item, metadata);
			if (_templateToRenderer.TryGetValue(GetReuseId(container, view, metadata), out SectionModifierRendererTemplateState<TView> value) && value.HasAttachable)
			{
				value.OnDetached(container, view, metadata);
			}
		}

		public override void SetDataContext(TContainer container, TView template, object? dataContext, IReadOnlyMetadataContext? metadata)
		{
			if (!_templateToRenderer.TryGetValue(GetReuseId(container, template, metadata), out SectionModifierRendererTemplateState<TView> value) || !value.HasDataContextAware)
			{
				base.SetDataContext(container, template, dataContext, metadata);
				return;
			}
			object oldDataContext = template.DataContextRaw();
			base.SetDataContext(container, template, dataContext, metadata);
			value.OnDataContextChanged(container, template, oldDataContext, dataContext, metadata);
		}

		public ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderers(TContainer container, TView? template, object? item, object? state, IReadOnlyMetadataContext? metadata)
		{
			if (state is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				return sectionModifierRendererTemplateState.Renderers;
			}
			if (template != null)
			{
				return TryGetRenderersByTemplate(container, template, metadata);
			}
			return ImmutableArray<ISectionModifierRenderer<TView>>.Empty;
		}

		protected internal override int GetReuseId(TContainer container, TView view, IReadOnlyMetadataContext? metadata)
		{
			return CompositeUIContentTemplateSelectorHelper.GetReuseId(container, view, metadata);
		}

		protected internal override void SetReuseId(TContainer container, TView view, int id, IReadOnlyMetadataContext? metadata)
		{
			CompositeUIContentTemplateSelectorHelper.SetReuseId(container, view, id, metadata);
		}

		protected abstract IViewTemplateConfiguration<TContainer, TView> SelectTemplateCore(TContainer container, object? item, object? key, string? wrapperId, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata);

		protected sealed override object? GetTemplateId(TContainer container, object? item, ref ValueSpanBuilder<char> templateId, IReadOnlyMetadataContext? metadata)
		{
			if (item != null)
			{
				return SectionModifierRendererTemplateState<TView>.TryGet(container, item, ref templateId, ref _rendersCache, metadata);
			}
			return null;
		}

		protected sealed override IViewTemplateConfiguration<TContainer, TView> SelectTemplate(TContainer container, object? item, object? key, string? wrapperId, object? templateIdState, IReadOnlyMetadataContext? metadata)
		{
			SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState = templateIdState as SectionModifierRendererTemplateState<TView>;
			if (sectionModifierRendererTemplateState != null && sectionModifierRendererTemplateState.HasTemplateProvider && sectionModifierRendererTemplateState.TrySelectTemplate<IViewTemplateConfiguration<TContainer, TView>>(container, item, metadata, out IViewTemplateConfiguration<TContainer, TView> template))
			{
				return template;
			}
			return SelectTemplateCore(container, item, key, wrapperId, sectionModifierRendererTemplateState?.Renderers ?? ImmutableArray<ISectionModifierRenderer<TView>>.Empty, metadata);
		}

		protected override TView CreateCore(IViewTemplateConfiguration<TContainer, TView> configuration, TContainer container, object? item, object? dataContext, string? wrapperId, object? key, object? templateIdState, IReadOnlyMetadataContext? metadata)
		{
			TView val = base.CreateCore(configuration, container, item, dataContext, wrapperId, key, templateIdState, metadata);
			if (templateIdState is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				return sectionModifierRendererTemplateState.ApplyWithParentNotification(val, container, metadata);
			}
			return val;
		}

		protected override void OnTemplateAdded(TContainer container, object? item, object? key, string? wrapperId, object? templateIdState, IViewTemplateConfiguration<TContainer, TView> template, IReadOnlyMetadataContext? metadata)
		{
			base.OnTemplateAdded(container, item, key, wrapperId, templateIdState, template, metadata);
			if (templateIdState is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				_templateToRenderer.GetOrAddValueRef(template.Id) = sectionModifierRendererTemplateState;
			}
		}

		protected ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderersByTemplate(TContainer container, TView view, IReadOnlyMetadataContext? metadata)
		{
			return TryGetRenderersByTemplateId(GetReuseId(container, view, metadata));
		}

		protected ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderersByTemplateId(int templateId)
		{
			if (_templateToRenderer.TryGetValue(templateId, out SectionModifierRendererTemplateState<TView> value))
			{
				return value.Renderers;
			}
			return ImmutableArray<ISectionModifierRenderer<TView>>.Empty;
		}
	}
	internal static class CompositeUIContentTemplateSelectorHelper
	{
		public static int GetReuseId(object container, object view, IReadOnlyMetadataContext? metadata)
		{
			View val = (View)((view is View) ? view : null);
			if (val != null)
			{
				return ViewMugenExtensions.GetTemplateId(val);
			}
			ExceptionManager.ThrowNotSupported();
			return 0;
		}

		public static void SetReuseId(object container, object view, int id, IReadOnlyMetadataContext? metadata)
		{
			View val = (View)((view is View) ? view : null);
			if (val != null)
			{
				ViewMugenExtensions.SetTemplateId(val, id);
			}
			else
			{
				ExceptionManager.ThrowNotSupported();
			}
		}
	}
	public abstract class CompositeUIRecyclableContentTemplateSelectorBase<TContainer, TView> : RecyclableContentTemplateSelectorBase<TContainer, TView>, IRenderersAwareTemplateSelector<TContainer, TView> where TContainer : class where TView : class
	{
		private DictionarySlim<string, SectionModifierRendererTemplateState<TView>> _rendersCache = new DictionarySlim<string, SectionModifierRendererTemplateState<TView>>(11);

		private DictionarySlim<int, SectionModifierRendererTemplateState<TView>> _templateToRenderer = new DictionarySlim<int, SectionModifierRendererTemplateState<TView>>();

		public override void OnAttached(TContainer container, TView view, object? item, IReadOnlyMetadataContext? metadata)
		{
			base.OnAttached(container, view, item, metadata);
			if (_templateToRenderer.TryGetValue(GetReuseId(container, view, metadata), out SectionModifierRendererTemplateState<TView> value))
			{
				value.OnAttached(container, view, metadata);
			}
		}

		public override void OnDetached(TContainer container, TView view, object? item, IReadOnlyMetadataContext? metadata)
		{
			base.OnDetached(container, view, item, metadata);
			if (_templateToRenderer.TryGetValue(GetReuseId(container, view, metadata), out SectionModifierRendererTemplateState<TView> value))
			{
				value.OnDetached(container, view, metadata);
			}
		}

		public override void SetDataContext(TContainer container, TView template, object? dataContext, IReadOnlyMetadataContext? metadata)
		{
			if (!_templateToRenderer.TryGetValue(GetReuseId(container, template, metadata), out SectionModifierRendererTemplateState<TView> value) || !value.HasDataContextAware)
			{
				base.SetDataContext(container, template, dataContext, metadata);
				return;
			}
			object oldDataContext = template.DataContextRaw();
			base.SetDataContext(container, template, dataContext, metadata);
			value.OnDataContextChanged(container, template, oldDataContext, dataContext, metadata);
		}

		public ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderers(TContainer container, TView? template, object? item, object? state, IReadOnlyMetadataContext? metadata)
		{
			if (state is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				return sectionModifierRendererTemplateState.Renderers;
			}
			if (template != null)
			{
				return TryGetRenderersByTemplate(container, template, metadata);
			}
			return ImmutableArray<ISectionModifierRenderer<TView>>.Empty;
		}

		protected internal override int GetReuseId(TContainer container, TView view, IReadOnlyMetadataContext? metadata)
		{
			return CompositeUIContentTemplateSelectorHelper.GetReuseId(container, view, metadata);
		}

		protected internal override void SetReuseId(TContainer container, TView view, int id, IReadOnlyMetadataContext? metadata)
		{
			CompositeUIContentTemplateSelectorHelper.SetReuseId(container, view, id, metadata);
		}

		protected abstract IViewTemplateConfiguration<TContainer, TView> SelectTemplateCore(TContainer container, object? item, object? key, string? wrapperId, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata);

		protected sealed override object? GetTemplateId(TContainer container, object? item, ref ValueSpanBuilder<char> templateId, IReadOnlyMetadataContext? metadata)
		{
			if (item != null)
			{
				return SectionModifierRendererTemplateState<TView>.TryGet(container, item, ref templateId, ref _rendersCache, metadata);
			}
			return null;
		}

		protected sealed override IViewTemplateConfiguration<TContainer, TView> SelectTemplate(TContainer container, object? item, object? key, string? wrapperId, object? templateIdState, IReadOnlyMetadataContext? metadata)
		{
			SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState = templateIdState as SectionModifierRendererTemplateState<TView>;
			if (sectionModifierRendererTemplateState != null && sectionModifierRendererTemplateState.TrySelectTemplate<IViewTemplateConfiguration<TContainer, TView>>(container, item, metadata, out IViewTemplateConfiguration<TContainer, TView> template))
			{
				return template;
			}
			return SelectTemplateCore(container, item, key, wrapperId, sectionModifierRendererTemplateState?.Renderers ?? ImmutableArray<ISectionModifierRenderer<TView>>.Empty, metadata);
		}

		protected override TView CreateCore(IViewTemplateConfiguration<TContainer, TView> configuration, TContainer container, object? item, object? dataContext, string? wrapperId, object? key, object? templateIdState, IReadOnlyMetadataContext? metadata)
		{
			TView val = base.CreateCore(configuration, container, item, dataContext, wrapperId, key, templateIdState, metadata);
			if (templateIdState is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				return sectionModifierRendererTemplateState.ApplyWithParentNotification(val, container, metadata);
			}
			return val;
		}

		protected override void OnTemplateAdded(TContainer container, object? item, object? key, string? wrapperId, object? templateIdState, IViewTemplateConfiguration<TContainer, TView> template, IReadOnlyMetadataContext? metadata)
		{
			base.OnTemplateAdded(container, item, key, wrapperId, templateIdState, template, metadata);
			if (templateIdState is SectionModifierRendererTemplateState<TView> sectionModifierRendererTemplateState)
			{
				_templateToRenderer.GetOrAddValueRef(template.Id) = sectionModifierRendererTemplateState;
			}
		}

		protected ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderersByTemplate(TContainer container, TView view, IReadOnlyMetadataContext? metadata)
		{
			return TryGetRenderersByTemplateId(GetReuseId(container, view, metadata));
		}

		protected ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderersByTemplateId(int templateId)
		{
			if (_templateToRenderer.TryGetValue(templateId, out SectionModifierRendererTemplateState<TView> value))
			{
				return value.Renderers;
			}
			return ImmutableArray<ISectionModifierRenderer<TView>>.Empty;
		}
	}
	public sealed class SectionModifierRendererTemplateState<TView> where TView : class
	{
		private readonly ISectionModifierRenderer<TView>[] _renderers;

		private readonly int[] _attachableIndexes;

		private readonly int[] _dataContextIndexes;

		private readonly int[] _templateProviderIndexes;

		public bool HasDataContextAware => _dataContextIndexes.Length != 0;

		public bool HasAttachable => _attachableIndexes.Length != 0;

		public bool HasTemplateProvider => _templateProviderIndexes.Length != 0;

		public ImmutableArray<ISectionModifierRenderer<TView>> Renderers => ImmutableCollectionsMarshal.AsImmutableArray(_renderers);

		private SectionModifierRendererTemplateState(ISectionModifierRenderer<TView>[] renderers, int[] attachableIndexes, int[] dataContextIndexes, int[] templateProviderIndexes)
		{
			_renderers = renderers;
			_attachableIndexes = attachableIndexes;
			_dataContextIndexes = dataContextIndexes;
			_templateProviderIndexes = templateProviderIndexes;
		}

		public static SectionModifierRendererTemplateState<TView>? TryGet(object container, object? item, ref ValueSpanBuilder<char> templateId, ref DictionarySlim<string, SectionModifierRendererTemplateState<TView>> cache, IReadOnlyMetadataContext? metadata)
		{
			if (item == null)
			{
				return null;
			}
			InlineList<ISectionModifierRenderer<TView>> list = default(InlineList<ISectionModifierRenderer<TView>>);
			try
			{
				CompositeUIExtensions.CollectModifierRenderers(item, ref list, metadata);
				Span<ISectionModifierRenderer<TView>> span = list.Span;
				if (span.IsEmpty)
				{
					return null;
				}
				Span<ISectionModifierRenderer<TView>> span2 = span;
				for (int i = 0; i < span2.Length; i++)
				{
					span2[i].GetLayoutRendererId(container, item, ref templateId, metadata);
				}
				ref SectionModifierRendererTemplateState<TView> orAddValueRefAlternate = ref CollectionSlimExtensions.GetOrAddValueRefAlternate(ref cache, (ReadOnlySpan<char>)templateId.Span);
				return orAddValueRefAlternate ?? (orAddValueRefAlternate = Get(span.ToArray()));
			}
			finally
			{
				list.Dispose();
			}
		}

		public TView Apply(TView template, object container, IReadOnlyMetadataContext? metadata)
		{
			TView hostView = template;
			TView anchorView = template;
			ImmutableArray<ISectionModifierRenderer<TView>> renderers = Renderers;
			ISectionModifierRenderer<TView>[] renderers2 = _renderers;
			for (int i = 0; i < renderers2.Length; i++)
			{
				renderers2[i].Apply(container, template, ref hostView, ref anchorView, renderers, metadata);
			}
			return hostView;
		}

		public TView ApplyWithParentNotification(TView template, object container, IReadOnlyMetadataContext? metadata)
		{
			TView hostView = template;
			TView anchorView = template;
			ImmutableArray<ISectionModifierRenderer<TView>> renderers = Renderers;
			ISectionModifierRenderer<TView>[] renderers2 = _renderers;
			for (int i = 0; i < renderers2.Length; i++)
			{
				renderers2[i].ApplyWithParentNotification(container, template, ref hostView, ref anchorView, renderers, metadata);
			}
			return hostView;
		}

		public void OnAttached(object container, TView view, IReadOnlyMetadataContext? metadata)
		{
			int[] attachableIndexes = _attachableIndexes;
			foreach (int num in attachableIndexes)
			{
				((IAttachableSectionModifierRenderer<TView>)_renderers[num]).OnAttached(container, view, metadata);
			}
		}

		public void OnDetached(object container, TView view, IReadOnlyMetadataContext? metadata)
		{
			int[] attachableIndexes = _attachableIndexes;
			foreach (int num in attachableIndexes)
			{
				((IAttachableSectionModifierRenderer<TView>)_renderers[num]).OnDetached(container, view, metadata);
			}
		}

		public void OnDataContextChanged(object container, TView view, object? oldDataContext, object? newDataContext, IReadOnlyMetadataContext? metadata)
		{
			int[] dataContextIndexes = _dataContextIndexes;
			foreach (int num in dataContextIndexes)
			{
				((IDataContextAwareSectionModifierRenderer<TView>)_renderers[num]).OnDataContextChanged(container, view, oldDataContext, newDataContext, metadata);
			}
		}

		public bool TrySelectTemplate<TTemplate>(object container, object? item, IReadOnlyMetadataContext? metadata, [NotNullWhen(true)] out TTemplate? template)
		{
			int[] templateProviderIndexes = _templateProviderIndexes;
			foreach (int num in templateProviderIndexes)
			{
				if (_renderers[num] is ITemplateProviderSectionModifierRenderer<TTemplate> templateProviderSectionModifierRenderer && templateProviderSectionModifierRenderer.TrySelectTemplate(container, item, metadata, out template))
				{
					return true;
				}
			}
			template = default(TTemplate);
			return false;
		}

		private static SectionModifierRendererTemplateState<TView> Get(ISectionModifierRenderer<TView>[] renderers)
		{
			PooledItemOrList<int> items = default(PooledItemOrList<int>);
			PooledItemOrList<int> items2 = default(PooledItemOrList<int>);
			PooledItemOrList<int> items3 = default(PooledItemOrList<int>);
			try
			{
				for (int i = 0; i < renderers.Length; i++)
				{
					ISectionModifierRenderer<TView> obj = renderers[i];
					if (obj is ITemplateProviderSectionModifierRenderer)
					{
						items3.Add(i);
					}
					if (obj is IAttachableSectionModifierRenderer<TView>)
					{
						items.Add(i);
					}
					if (obj is IDataContextAwareSectionModifierRenderer<TView>)
					{
						items2.Add(i);
					}
				}
				return new SectionModifierRendererTemplateState<TView>(renderers, items.ToArray(), items2.ToArray(), items3.ToArray());
			}
			finally
			{
				items.Dispose();
				items2.Dispose();
				items3.Dispose();
			}
		}
	}
	public abstract class CompositeUIResourceTemplateSelectorBase : ResourceTemplateSelectorBase, IAttachableTemplateSelector<View, View>, IRenderersAwareTemplateSelector<View, View>, IDataContextBinderTemplateSelector<View, View>
	{
		private DictionarySlim<string, SectionModifierRendererTemplateState<View>> _rendersCache = new DictionarySlim<string, SectionModifierRendererTemplateState<View>>(11);

		private DictionarySlim<int, SectionModifierRendererTemplateState<View>> _templateToRenderer = new DictionarySlim<int, SectionModifierRendererTemplateState<View>>(11);

		public override View Initialize(View container, View template, int templateId, IReadOnlyMetadataContext? metadata)
		{
			if (_templateToRenderer.TryGetValue(templateId, out SectionModifierRendererTemplateState<View> value))
			{
				template = value.ApplyWithParentNotification(template, container, metadata);
				ViewMugenExtensions.SetTemplateId(template, templateId);
			}
			return template;
		}

		public virtual void OnAttached(View container, View view, object? item, IReadOnlyMetadataContext? metadata)
		{
			if (_templateToRenderer.TryGetValue(ViewMugenExtensions.GetTemplateId(view), out SectionModifierRendererTemplateState<View> value) && value.HasAttachable)
			{
				value.OnAttached(container, view, metadata);
			}
		}

		public virtual void OnDetached(View container, View view, object? item, IReadOnlyMetadataContext? metadata)
		{
			if (_templateToRenderer.TryGetValue(ViewMugenExtensions.GetTemplateId(view), out SectionModifierRendererTemplateState<View> value) && value.HasAttachable)
			{
				value.OnDetached(container, view, metadata);
			}
		}

		public virtual void SetDataContext(View container, View template, object? dataContext, IReadOnlyMetadataContext? metadata)
		{
			if (!_templateToRenderer.TryGetValue(ViewMugenExtensions.GetTemplateId(template), out SectionModifierRendererTemplateState<View> value) || !value.HasDataContextAware)
			{
				template.SetDataContext(dataContext, metadata);
				return;
			}
			object oldDataContext = template.DataContextRaw();
			template.SetDataContext(dataContext, metadata);
			value.OnDataContextChanged(container, template, oldDataContext, dataContext, metadata);
		}

		public ImmutableArray<ISectionModifierRenderer<View>> TryGetRenderers(View container, View? template, object? item, object? state, IReadOnlyMetadataContext? metadata)
		{
			if (state is SectionModifierRendererTemplateState<View> sectionModifierRendererTemplateState)
			{
				return sectionModifierRendererTemplateState.Renderers;
			}
			if (template != null)
			{
				return TryGetRenderersByTemplate(template);
			}
			return ImmutableArray<ISectionModifierRenderer<View>>.Empty;
		}

		protected abstract int SelectTemplateCore(View container, object? item, object? key, string? wrapperId, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata);

		protected sealed override int SelectTemplateCore(View container, object? item, object? key, string? wrapperId, object? templateIdState, IReadOnlyMetadataContext? metadata)
		{
			SectionModifierRendererTemplateState<View> sectionModifierRendererTemplateState = templateIdState as SectionModifierRendererTemplateState<View>;
			if (sectionModifierRendererTemplateState != null && sectionModifierRendererTemplateState.TrySelectTemplate<int>(container, item, metadata, out var template))
			{
				return template;
			}
			return SelectTemplateCore(container, item, key, wrapperId, sectionModifierRendererTemplateState?.Renderers ?? ImmutableArray<ISectionModifierRenderer<View>>.Empty, metadata);
		}

		protected sealed override object? GetTemplateId(View container, object? item, ref ValueSpanBuilder<char> templateId, IReadOnlyMetadataContext? metadata)
		{
			if (item != null)
			{
				return SectionModifierRendererTemplateState<View>.TryGet(container, item, ref templateId, ref _rendersCache, metadata);
			}
			return null;
		}

		protected override void OnTemplateAdded(View container, object? item, object? key, string? wrapperId, object? templateIdState, int template, IReadOnlyMetadataContext? metadata)
		{
			if (wrapperId != null && templateIdState is SectionModifierRendererTemplateState<View> sectionModifierRendererTemplateState)
			{
				_templateToRenderer.GetOrAddValueRef(template) = sectionModifierRendererTemplateState;
			}
		}

		protected ImmutableArray<ISectionModifierRenderer<View>> TryGetRenderersByTemplate(View template)
		{
			return GetRenderersByTemplateId(ViewMugenExtensions.GetTemplateId(template));
		}

		protected ImmutableArray<ISectionModifierRenderer<View>> GetRenderersByTemplateId(int templateId)
		{
			if (_templateToRenderer.TryGetValue(templateId, out SectionModifierRendererTemplateState<View> value))
			{
				return value.Renderers;
			}
			return ImmutableArray<ISectionModifierRenderer<View>>.Empty;
		}
	}
	public class CompositeUITemplateSelectorBase : CompositeUIResourceTemplateSelectorBase
	{
		private static Expression<Func<View, FormattedText>>? _bindCache1;

		private static Expression<Func<View, string?>>? _bindCache8;

		private static Expression<Func<View, FormattedText>>? _bindCache2;

		private static Expression<Func<View, ImageSource>>? _bindCache3;

		private static Expression<Func<View, ImageSource>>? _bindCache4;

		private static Expression<Func<View, ImmutableArray<IVisualSection>>>? _bindCache5;

		private static Expression<Func<View, IReadOnlyCollection<ISection>>>? _bindCache6;

		private static Expression<Func<View, object?>>? _bindCache7;

		private static Expression<Func<View, bool>>? _bindCache9;

		private static Expression<Func<View, IVisualSection?>>? _bindCache10;

		private IContentTemplateSelector<View, View>? _contentTemplateWrapper;

		public override View Initialize(View container, View view, int templateId, IReadOnlyMetadataContext? metadata)
		{
			NativeBindableMemberMugenExtensions.SetDefaultSize(container, view);
			int num = TrySelectTemplateById(container, templateId, metadata);
			if (num == Layout.mugen_text_section)
			{
				view.BindFormattedTextTarget<View>().To(view.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<ITextSection>().Text)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_text_input_section)
			{
				ViewBaseBindableMembers.BindTextTarget<View>(view).To(view.B(_bindCache8 ?? (_bindCache8 = (View c) => ((Object)c).DataContext<ITextInputSection>().Text)), (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
				{
					c.TwoWay();
				}, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_button_section)
			{
				view.BindFormattedTextTarget<View>().To(view.B(_bindCache2 ?? (_bindCache2 = (View c) => ((Object)c).DataContext<IButtonSection>().Text)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
				CompositeUIViewBaseBindableMembers.BindIconTarget<View>(view).To(view.B(_bindCache3 ?? (_bindCache3 = (View c) => ((Object)c).DataContext<IButtonSection>().Icon)), (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
				{
					c.Optional();
				}, (IReadOnlyMetadataContext?)null);
				NativeBindableMemberMugenExtensions.RemoveInset(view);
			}
			else if (num == Layout.mugen_image_section || num == Layout.mugen_image_material_section)
			{
				view.BindImageTarget<View>().To(view.B(_bindCache4 ?? (_bindCache4 = (View c) => ((Object)c).DataContext<IImageSection>().Source)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_immutable_stack_section || num == Layout.mugen_stack_section || num == Layout.mugen_immutable_frame_section || num == Layout.mugen_frame_section)
			{
				bool flag = num == Layout.mugen_immutable_stack_section || num == Layout.mugen_immutable_frame_section;
				view.SetItemTemplateSelector(GetContainerTemplateSelector(container, view, num, flag, metadata));
				if (flag)
				{
					ViewBaseBindableMembers.BindImmutableItemsSourceTarget<View>(view).To(view.B(_bindCache5 ?? (_bindCache5 = (View c) => ((Object)c).DataContext<IImmutableLayoutSection>().Children)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
				}
				else
				{
					ViewBaseBindableMembers.BindItemsSourceTarget<View>(view).To(view.B(_bindCache6 ?? (_bindCache6 = (View c) => ((Object)c).DataContext<ICompositeLayoutSection>().Children)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
				}
			}
			else if (num == Layout.mugen_collection_section)
			{
				InitializeCollectionLayout(container, view, templateId, metadata);
				view.SetItemTemplateSelector(GetResourceTemplateSelector(container, view, num, metadata, out var sharePool));
				if (sharePool)
				{
					NativeBindableMemberMugenExtensions.SharePool(container, view);
				}
				ViewBaseBindableMembers.BindItemsSourceTarget<View>(view).To(view.B(_bindCache6 ?? (_bindCache6 = (View c) => ((Object)c).DataContext<ICompositeLayoutSection>().Children)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_content_section)
			{
				view.SetContentTemplateSelector((IContentTemplateSelector<View, Object>)GetContainerTemplateSelector(container, view, num, immutable: false, metadata));
				view.BindContentTarget<View>().To(view.B(_bindCache10 ?? (_bindCache10 = (View c) => ((Object)c).DataContext<IContentLayoutSection>().Content)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_switch_section)
			{
				view.BindCheckedTarget<View>().To(view.B(_bindCache9 ?? (_bindCache9 = (View c) => ((Object)c).DataContext<ISwitchSection>().Value)), (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
				{
					c.TwoWay();
				}, (IReadOnlyMetadataContext?)null);
			}
			else if (num == Layout.mugen_missing_section)
			{
				ViewBaseBindableMembers.BindTextTarget<View>(view).To(view.B(_bindCache7 ?? (_bindCache7 = (View c) => ((Object)c).DataContext())), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
			}
			return base.Initialize(container, view, templateId, metadata);
		}

		protected virtual void InitializeCollectionLayout(View container, View template, int templateId, IReadOnlyMetadataContext? metadata)
		{
			NativeBindableMemberMugenExtensions.SetDefaultCollectionLayout(template);
		}

		protected virtual object GetContentTemplateSelector(View container, View template, int templateId, IReadOnlyMetadataContext? metadata)
		{
			return _contentTemplateWrapper ?? (_contentTemplateWrapper = new ContentTemplateSelectorWrapper(this, useViewModel: false));
		}

		protected virtual object GetRecyclableContentTemplateSelector(View container, View template, int templateId, IReadOnlyMetadataContext? metadata)
		{
			return new RecyclableContentTemplateSelectorWrapper(this);
		}

		protected override int SelectTemplateCore(View container, object? item, object? key, string? wrapperId, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			if (item is IButtonSection)
			{
				return Layout.mugen_button_section;
			}
			if (item is ITextInputSection)
			{
				return Layout.mugen_text_input_section;
			}
			if (item is ITextSection)
			{
				return Layout.mugen_text_section;
			}
			if (item is IImageSection)
			{
				if (AndroidMugenExtensions.IsMaterialSupported)
				{
					ImmutableArray<ISectionModifierRenderer<View>>.Enumerator enumerator = renderers.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current is IMaterialImageRequiredRenderer)
						{
							return Layout.mugen_image_material_section;
						}
					}
				}
				return Layout.mugen_image_section;
			}
			if (item is ICollectionLayoutSection)
			{
				return Layout.mugen_collection_section;
			}
			if (item is IStackLayoutSection)
			{
				return Layout.mugen_stack_section;
			}
			if (item is IImmutableStackLayoutSection)
			{
				return Layout.mugen_immutable_stack_section;
			}
			if (item is IImmutableFrameLayoutSection)
			{
				return Layout.mugen_immutable_frame_section;
			}
			if (item is IFrameLayoutSection)
			{
				return Layout.mugen_frame_section;
			}
			if (item is IContentLayoutSection)
			{
				return Layout.mugen_content_section;
			}
			if (item is ISwitchSection && AndroidMugenExtensions.IsMaterialSupported)
			{
				return Layout.mugen_switch_section;
			}
			if (item is SpaceSection)
			{
				return Layout.mugen_space_section;
			}
			return Layout.mugen_missing_section;
		}

		protected virtual IResourceTemplateSelector GetResourceTemplateSelector(View container, View template, int templateId, IReadOnlyMetadataContext? metadata, out bool sharePool)
		{
			sharePool = true;
			return this;
		}

		protected object GetContainerTemplateSelector(View container, View template, int templateId, bool immutable, IReadOnlyMetadataContext? metadata)
		{
			if (immutable)
			{
				return GetContentTemplateSelector(container, template, templateId, metadata);
			}
			View val = NativeBindableMemberMugenExtensions.FindRecyclerView(container);
			if (val != null)
			{
				AttachedValueStorage attachedValueStorage = val.AttachedValues<View>(metadata);
				if (!attachedValueStorage.TryGet<object>((ReadOnlySpan<char>)"`ctc", out object value))
				{
					value = GetRecyclableContentTemplateSelector(container, template, templateId, metadata);
					attachedValueStorage.Set("`ctc", value);
				}
				return value;
			}
			return GetRecyclableContentTemplateSelector(container, template, templateId, metadata);
		}
	}
}
namespace MugenMvvm.CompositeUI.Templating.Interfaces
{
	public interface IRenderersAwareTemplateSelector<in TContainer, TView> where TContainer : class where TView : class
	{
		ImmutableArray<ISectionModifierRenderer<TView>> TryGetRenderers(TContainer container, TView? template, object? item, object? state, IReadOnlyMetadataContext? metadata);
	}
}
namespace MugenMvvm.CompositeUI.States
{
	public class ScreenState : DisposableBindableModelBase, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private static Expression<Func<ScreenState, IReadOnlyObservableCollection<IAppErrorInfo>?>>? _bindCache1;

		private static Expression<Func<ScreenState, IReadOnlyObservableCollection<IBusyToken>?>>? _bindCache2;

		private static Expression<Func<ScreenState, IReadOnlyObservableCollection<ValidationErrorInfoRef>?>>? _bindCache3;

		private static Expression<Func<ScreenState, IReadOnlyObservableCollection<IView>?>>? _bindCache4;

		private static Expression<Func<ScreenState, bool>>? _bindCache5;

		private static Expression<Func<ScreenState, bool>>? _bindCache6;

		private DictionarySlim<string, (object, object)> _sharedBindable;

		private readonly BindableValue<IShell?> _shell = new BindableValue<IShell>();

		public Bindable<IShell?> Shell => _shell.BindValue();

		public Bindable<EnumFlags<ApplicationLifecycleState>> AppLifecycleState => GetSharedBindable((object? _) => IMugenService<IMugenApplication>.Instance.BindLifecycleState(IMugenService<IMugenApplication>.Instance), "AppLifecycleState");

		public Bindable<EnumFlags<ViewModelLifecycleState>> ShellLifecycleState => GetSharedBindable(this, (ScreenState s) => IMugenService<IViewModelManager>.Instance.BindLifecycleState(s), "ShellLifecycleState");

		public Bindable<ImmutableList<IAppErrorInfo>> AppErrors => GetSharedBindable(this, (ScreenState s) => (from infos in s.B(_bindCache1 ?? (_bindCache1 = (ScreenState v) => v.RootSection<IAppErrorsAwareSection>().Section.Errors))
			select infos?.BindItems() ?? default(Bindable<ImmutableList<IAppErrorInfo>>)).Unwrap(), "AppErrors");

		public Bindable<ImmutableList<IBusyToken>> BusyTokens => GetSharedBindable(this, (ScreenState s) => (from infos in s.B(BindCache2)
			select infos?.BindItems() ?? default(Bindable<ImmutableList<IBusyToken>>)).Unwrap(), "BusyTokens");

		public Bindable<ImmutableList<ValidationErrorInfoRef>> ValidationErrors => GetSharedBindable(this, (ScreenState s) => (from infos in s.B(_bindCache3 ?? (_bindCache3 = (ScreenState v) => v.RootSection<IValidationErrorsAwareSection>().Section.Errors))
			select infos?.BindItems() ?? default(Bindable<ImmutableList<ValidationErrorInfoRef>>)).Unwrap(), "ValidationErrors");

		public Bindable<ImmutableList<IView>> Views => GetSharedBindable(this, (ScreenState s) => (from infos in s.B(_bindCache4 ?? (_bindCache4 = (ScreenState v) => v.RootSection<IViewsAwareSection>().Section.Views))
			select infos?.BindItems() ?? default(Bindable<ImmutableList<IView>>)).Unwrap(), "Views");

		public Bindable<bool> IsRefreshing => GetSharedBindable(this, (ScreenState s) => (from t in s.B(BindCache2)
			select t?.BindAny((IBusyToken token, object? _) => token.Message is IRefreshBusyMessage) ?? default(Bindable<bool>)).Unwrap().Combine(s.B(_bindCache5 ?? (_bindCache5 = (ScreenState v) => v.RootSection<IRefreshableSection>().Section.RefreshCommand.IsExecuting())), (bool hasTokens, bool isExecuting) => hasTokens || isExecuting), "IsRefreshing");

		public Bindable<bool> IsLoadingMore => GetSharedBindable(this, (ScreenState s) => (from t in s.B(BindCache2)
			select t?.BindAny((IBusyToken token, object? _) => token.Message is ILoadMoreBusyMessage) ?? default(Bindable<bool>)).Unwrap().Combine(s.B(_bindCache6 ?? (_bindCache6 = (ScreenState v) => v.RootSection<ILoadMoreSupportSection>().Section.LoadMoreCommand.IsExecuting())), (bool hasTokens, bool isExecuting) => hasTokens || isExecuting), "IsLoadingMore");

		public Bindable<ICompositeCommand?> RootCloseCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootCloseCommand(), "RootCloseCommand");

		public Bindable<ICompositeCommand?> RootReloadCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootReloadCommand(), "RootReloadCommand");

		public Bindable<ICompositeCommand?> RootGoNextCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootGoNextCommand(), "RootGoNextCommand");

		public Bindable<ICompositeCommand?> RootGoBackCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootGoBackCommand(), "RootGoBackCommand");

		public Bindable<ICompositeCommand?> RootCompleteCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootCompleteCommand(), "RootCompleteCommand");

		public Bindable<ICompositeCommand?> RootLoadMoreCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootLoadMoreCommand(), "RootLoadMoreCommand");

		public Bindable<ICompositeCommand?> RootRefreshCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootRefreshCommand(), "RootRefreshCommand");

		public Bindable<ICompositeCommand?> RootSelectCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootSelectCommand(), "RootSelectCommand");

		public Bindable<ICompositeCommand?> RootRemoveCommand => GetSharedBindable(this, (ScreenState s) => s.BindRootRemoveCommand(), "RootRemoveCommand");

		private static Expression<Func<ScreenState, IReadOnlyObservableCollection<IBusyToken>?>> BindCache2 => _bindCache2 ?? (_bindCache2 = (ScreenState v) => v.RootSection<IBusyTokensAwareSection>().Section.BusyTokens);

		IShell? IShellAware.Shell => _shell.Value;

		IShell? IShellAwareSection.Shell
		{
			get
			{
				return _shell.Value;
			}
			set
			{
				if (_shell.Value != value)
				{
					_shell.Value = value;
					OnPropertyChanged(CompositeUIExtensions.ShellArgs);
				}
			}
		}

		protected Bindable<T> GetSharedBindable<T>(Func<object?, Bindable<T>> getBindable, [CallerMemberName] string? id = null)
		{
			return GetSharedBindable(null, getBindable, id);
		}

		protected Bindable<T> GetSharedBindable<T, TState>(TState state, Func<TState, Bindable<T>> getBindable, [CallerMemberName] string? id = null)
		{
			Should.NotBeNull(id, "id");
			Should.NotBeNull(getBindable, "getBindable");
			lock (this)
			{
				if (_sharedBindable.IsInitialized && _sharedBindable.TryGetValue(id, out (object, object) value))
				{
					return new Bindable<T>(value.Item1, value.Item2, default(T));
				}
			}
			return AddBindable(getBindable(state), id);
		}

		private Bindable<T> AddBindable<T>(Bindable<T> bindable, string id)
		{
			if (!bindable.IsConstantOrUninitialized())
			{
				lock (this)
				{
					if (!_sharedBindable.IsInitialized)
					{
						_sharedBindable = new DictionarySlim<string, (object, object)>(3);
					}
					if (_sharedBindable.TryGetValue(id, out (object, object) value))
					{
						return new Bindable<T>(value.Item1, value.Item2, default(T));
					}
					bindable = bindable.Share();
					_sharedBindable.GetOrAddValueRef(id) = (bindable._target, bindable._expression);
				}
			}
			return bindable;
		}
	}
}
namespace MugenMvvm.CompositeUI.Sections
{
	public sealed class AppErrorsAwareSection : RootSectionBase, IAppErrorsAwareSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IAppErrorListener, ISuppressAppErrorsListenerSection
	{
		private readonly ObservableSet<IAppErrorInfo> _errors;

		private readonly Lock _externalLock;

		private readonly HashSet<object> _externalItems;

		private ITrackerCollectionDecorator<object, object>? _trackedItems;

		private IReadOnlyObservableCollection<object>? _bind;

		public IReadOnlyObservableCollection<IAppErrorInfo> Errors => _errors;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(AppErrorsAwareSection))]
		public AppErrorsAwareSection()
		{
			_externalLock = new Lock();
			_errors = new ObservableSet<IAppErrorInfo>(ReferenceEqualityComparer.Instance);
			_externalItems = new HashSet<object>(ReferenceEqualityComparer.Instance);
		}

		public void OnAdded(IAppErrorInfo error, IReadOnlyMetadataContext? metadata)
		{
			_errors.Add(error);
			if (!Contains(error.Source))
			{
				_errors.Remove(error);
			}
		}

		public void OnRemoved(IAppErrorInfo error, IReadOnlyMetadataContext? metadata)
		{
			_errors.Remove(error);
		}

		public bool Register(object section, IReadOnlyMetadataContext? metadata)
		{
			Should.NotBeNull(section, "section");
			if (section is ISection section2)
			{
				section = section2.Inner;
			}
			using (_bind?.Lock(null))
			{
				using (_externalLock.EnterScope())
				{
					if (_externalItems.Contains(section))
					{
						return false;
					}
					ITrackerCollectionDecorator<object, object> trackedItems = _trackedItems;
					if (trackedItems != null && trackedItems.ContainsKey(section))
					{
						return false;
					}
					if (!IMugenService<IMugenApplication>.Instance.RegisterAppErrorListener(section, this))
					{
						return false;
					}
					_externalItems.Add(section);
				}
				AddErrors(section);
				return true;
			}
		}

		public bool Unregister(object section, IReadOnlyMetadataContext? metadata)
		{
			Should.NotBeNull(section, "section");
			if (section is ISection section2)
			{
				section = section2.Inner;
			}
			using (_bind?.Lock(null))
			{
				using (_externalLock.EnterScope())
				{
					if (!_externalItems.Remove(section))
					{
						return false;
					}
					if (!IMugenService<IMugenApplication>.Instance.UnregisterAppErrorListener(section, this))
					{
						return false;
					}
				}
				RemoveErrors(section);
				return true;
			}
		}

		public void OnAttached(IShell shell)
		{
			if (_bind != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_bind = shell.Sections.Configure().For(delegate(object? o)
			{
				ISection section = (ISection)o;
				return (!section.IsWrappedAs<ISection, ISuppressAppErrorsListenerSection>()) ? Optional.Get((object?)section.Inner) : default(Optional<object>);
			}).WithState(this)
				.TrackItems(Register, Unregister)
				.GetComponent(out _trackedItems)
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			using (_externalLock.EnterScope())
			{
				foreach (object externalItem in _externalItems)
				{
					IMugenService<IMugenApplication>.Instance.UnregisterAppErrorListener(externalItem, this);
				}
				_externalItems.Clear();
			}
			_bind?.Dispose();
			_bind = null;
			_trackedItems = null;
			_errors.Clear();
		}

		public void Dispose()
		{
			_errors.Dispose();
		}

		private static void Register(object section, AppErrorsAwareSection state)
		{
			if (!state.ContainsExternal(section) && IMugenService<IMugenApplication>.Instance.RegisterAppErrorListener(section, state))
			{
				state.AddErrors(section);
			}
		}

		private static void Unregister(object section, AppErrorsAwareSection state)
		{
			if (!state.ContainsExternal(section) && IMugenService<IMugenApplication>.Instance.UnregisterAppErrorListener(section, state))
			{
				state.RemoveErrors(section);
			}
		}

		private void AddErrors(object section)
		{
			using PooledReadOnlyList<IAppErrorInfo> pooledReadOnlyList = IMugenService<IMugenApplication>.Instance.GetAppErrors(section);
			using ((pooledReadOnlyList.Count > 1) ? _errors.BatchUpdate() : default(ActionToken))
			{
				foreach (IAppErrorInfo item in pooledReadOnlyList)
				{
					_errors.Add(item);
				}
			}
		}

		private void RemoveErrors(object section)
		{
			using PooledReadOnlyList<IAppErrorInfo> pooledReadOnlyList = IMugenService<IMugenApplication>.Instance.GetAppErrors(section);
			using ((pooledReadOnlyList.Count > 1) ? _errors.BatchUpdate() : default(ActionToken))
			{
				foreach (IAppErrorInfo item in pooledReadOnlyList)
				{
					_errors.Remove(item);
				}
			}
		}

		private bool Contains(object source)
		{
			using (_bind?.Lock(null))
			{
				using (_externalLock.EnterScope())
				{
					if (_externalItems.Contains(source))
					{
						return true;
					}
					return _trackedItems?.ContainsKey(source) ?? false;
				}
			}
		}

		private bool ContainsExternal(object source)
		{
			using (_externalLock.EnterScope())
			{
				return _externalItems.Contains(source);
			}
		}
	}
	public sealed class BusyManagerSection : ApiProviderBase<IBusyManager>, IBusyManager, IApiProvider<IBusyManager>, IComponentOwner<IBusyManager>, IComponentOwner, IApiProvider, IHasService<IBusyManager>, IHasOptionalService<IBusyManager>, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, ISuppressAppErrorsListenerSection
	{
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(BusyManagerSection))]
		public BusyManagerSection(bool addDefaultComponents = true)
		{
			if (addDefaultComponents)
			{
				this.AddComponent(new BusyTokenHandler());
				this.AddComponent(new BusyTokenDelayHandler());
				this.AddComponent(new BusyTokenNotificationDecorator());
			}
		}
	}
	public sealed class BusyTokensAwareSection : RootSectionBase, IBusyTokensAwareSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IApiHandlerComponent<IBusyManager, OnAddedBusyTokenRequest, Unit>, IApiHandlerComponent<IBusyManager>, IApiProviderComponent<IBusyManager>, IApiProviderComponent, IComponent, ISupportRequestComponent<IBusyManager>, IComponent<IBusyManager>, ISupportApiHandlerComponent<IBusyManager, OnAddedBusyTokenRequest>, IApiHandlerComponent<IBusyManager, OnCompletedBusyTokenRequest, Unit>, ISupportApiHandlerComponent<IBusyManager, OnCompletedBusyTokenRequest>, ISuppressAppErrorsListenerSection
	{
		private readonly ObservableSet<IBusyToken> _tokens = new ObservableSet<IBusyToken>(ReferenceEqualityComparer.Instance);

		private IReadOnlyObservableCollection<object>? _bind;

		public IReadOnlyObservableCollection<IBusyToken> BusyTokens => _tokens;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(BusyTokensAwareSection))]
		public BusyTokensAwareSection()
		{
		}

		public Unit TryInvoke(OnAddedBusyTokenRequest request, IBusyManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (apiProvider.TryGetComponent<BusyTokensAwareSection>() == this)
			{
				_tokens.Add(request.Token);
				if (apiProvider.TryGetComponent<BusyTokensAwareSection>() == null)
				{
					_tokens.Remove(request.Token);
				}
			}
			return default(Unit);
		}

		public Unit TryInvoke(OnCompletedBusyTokenRequest request, IBusyManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			_tokens.Remove(request.Token);
			return default(Unit);
		}

		public bool Register(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			Should.NotBeNull(busyManager, "busyManager");
			if (!busyManager.Components.TryAdd(this))
			{
				return false;
			}
			using PooledReadOnlyList<IBusyToken> pooledReadOnlyList = busyManager.GetBusyTokens();
			using ((pooledReadOnlyList.Count > 1) ? _tokens.BatchUpdate() : default(ActionToken))
			{
				foreach (IBusyToken item in pooledReadOnlyList)
				{
					if (item.IsActive)
					{
						_tokens.Add(item);
					}
				}
				return true;
			}
		}

		public bool Unregister(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			Should.NotBeNull(busyManager, "busyManager");
			if (!busyManager.Components.Remove(this))
			{
				return false;
			}
			using PooledReadOnlyList<IBusyToken> pooledReadOnlyList = busyManager.GetBusyTokens();
			using ((pooledReadOnlyList.Count > 1) ? _tokens.BatchUpdate() : default(ActionToken))
			{
				foreach (IBusyToken item in pooledReadOnlyList)
				{
					_tokens.Remove(item);
				}
				return true;
			}
		}

		public void OnAttached(IShell shell)
		{
			if (_bind != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_bind = shell.Sections.Configure().WithState(this).For((object? o) => Optional.Get(MugenExtensions.TryUnwrap<ISection, IHasService<IBusyManager>>(o)?.Service))
				.TrackItems(Register, Unregister)
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
		}

		public void Dispose()
		{
			_tokens.Dispose();
		}

		private static void Register(IBusyManager busyManager, BusyTokensAwareSection state)
		{
			state.Register(busyManager, (IReadOnlyMetadataContext?)null);
		}

		private static void Unregister(IBusyManager busyManager, BusyTokensAwareSection state)
		{
			state.Unregister(busyManager, (IReadOnlyMetadataContext?)null);
		}
	}
	public sealed class CloseConditionSectionHandler : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IApiHandlerComponent<INavigationDispatcher, OnNavigatingAsyncRequest, ValueTask<bool?>>, IApiHandlerComponent<INavigationDispatcher>, IApiProviderComponent<INavigationDispatcher>, IApiProviderComponent, IComponent, ISupportRequestComponent<INavigationDispatcher>, IComponent<INavigationDispatcher>, ISupportApiHandlerComponent<INavigationDispatcher, OnNavigatingAsyncRequest>, ISuppressAppErrorsListenerSection
	{
		private IShell? _shell;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CloseConditionSectionHandler))]
		public CloseConditionSectionHandler()
		{
		}

		public async ValueTask<bool?> TryInvoke(OnNavigatingAsyncRequest request, INavigationDispatcher apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell == null || !request.NavigationContext.NavigationMode.IsClose || request.NavigationContext.Target != shell)
			{
				return null;
			}
			if (request.NavigationContext.NavigationMode == NavigationMode.Back)
			{
				foreach (ISection section in shell.Sections)
				{
					if (section.TryUnwrap<ISection, IHasCloseConditionSection>(out IHasCloseConditionSection value) && !(await value.OnBackNavigationAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
					{
						return false;
					}
				}
			}
			foreach (ISection section2 in shell.Sections)
			{
				if (section2.TryUnwrap<ISection, IHasCloseConditionSection>(out IHasCloseConditionSection value2) && !(await value2.OnClosingAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)))
				{
					return false;
				}
			}
			return true;
		}

		public void OnAttached(IShell shell)
		{
			if (shell != _shell)
			{
				if (_shell != null)
				{
					ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
				}
				_shell = shell;
				IMugenService<INavigationDispatcher>.Instance.AddComponent(this);
			}
		}

		public void OnDetached(IShell shell)
		{
			IMugenService<INavigationDispatcher>.Instance.RemoveComponent(this);
			_shell = null;
		}
	}
	public sealed class CloseShellSectionAction : ISection, IInner<ISection>, IDisposable
	{
		public static readonly CloseShellSectionAction Instance = new CloseShellSectionAction();

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CloseShellSectionAction))]
		private CloseShellSectionAction()
		{
		}

		public void Attach(IShell shell)
		{
			shell.TryGetRootCloseCommand()?.ForceExecute();
		}
	}
	public sealed class CommandBusySectionHandler : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, ISuppressAppErrorsListenerSection, IHasService<IBusyManager>, IHasOptionalService<IBusyManager>
	{
		private readonly Lock _locker;

		private DictionarySlim<CommandBusyHandlerType, IMetadataContextKey<IComponent<ICompositeCommand>?>> _keys;

		private IReadOnlyObservableCollection<object>? _bind;

		public IBusyManager Service { get; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CommandBusySectionHandler))]
		public CommandBusySectionHandler(IBusyManager? busyManager = null)
		{
			_locker = new Lock();
			_keys = new DictionarySlim<CommandBusyHandlerType, IMetadataContextKey<IComponent<ICompositeCommand>>>(7);
			Service = busyManager ?? BusyManager.CreateDefault();
		}

		public void OnAttached(IShell shell)
		{
			if (_bind != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_bind = shell.Sections.Configure().WithState(this).For((object? o) => (!(o is ISection section) || (!section.IsWrappedAs<ISection, IWorkflowSection>() && !section.IsWrappedAs<ISection, IRefreshableSection>() && !section.IsWrappedAs<ISection, IReloadableSection>() && !section.IsWrappedAs<ISection, ILoadMoreSupportSection>() && !section.IsWrappedAs<ISection, IRemovableSection>() && !section.IsWrappedAs<ISection, IBusyManagerAwareSection>())) ? default(Optional<ISection>) : Optional.Get(section, hasValue: true))
				.TrackItems(Register, Unregister)
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
		}

		public void Dispose()
		{
			using PooledReadOnlyList<IBusyToken> pooledReadOnlyList = Service.GetBusyTokens();
			foreach (IBusyToken item in pooledReadOnlyList)
			{
				item.Dispose();
			}
		}

		private IMetadataContextKey<IComponent<ICompositeCommand>?> GetKey(CommandBusyHandlerType type)
		{
			using (_locker.EnterScope())
			{
				ref IMetadataContextKey<IComponent<ICompositeCommand>> orAddValueRef = ref _keys.GetOrAddValueRef(type);
				return orAddValueRef ?? (orAddValueRef = MetadataContextKey.FromKey<IComponent<ICompositeCommand>>($"{"$#b"}{Default.NextCounter()}"));
			}
		}

		private static void Register(ISection section, CommandBusySectionHandler state)
		{
			if (section.TryUnwrap<ISection, IBusyManagerAwareSection>(out IBusyManagerAwareSection value))
			{
				value.Attach(state.Service, null);
			}
			if (section.TryUnwrap<ISection, IRefreshableSection>(out IRefreshableSection value2))
			{
				state.Service.AddCommandBusySectionHandler(value2.RefreshCommand, CommandBusyHandlerType.Refresh, section, state.GetKey(CommandBusyHandlerType.Refresh));
			}
			if (section.TryUnwrap<ISection, IReloadableSection>(out IReloadableSection value3))
			{
				state.Service.AddCommandBusySectionHandler(value3.ReloadCommand, CommandBusyHandlerType.Reload, section, state.GetKey(CommandBusyHandlerType.Reload));
			}
			if (section.TryUnwrap<ISection, ILoadMoreSupportSection>(out ILoadMoreSupportSection value4))
			{
				state.Service.AddCommandBusySectionHandler(value4.LoadMoreCommand, CommandBusyHandlerType.LoadMore, section, state.GetKey(CommandBusyHandlerType.LoadMore));
			}
			if (section.TryUnwrap<ISection, IRemovableSection>(out IRemovableSection value5))
			{
				state.Service.AddCommandBusySectionHandler(value5.RemoveCommand, CommandBusyHandlerType.Remove, section, state.GetKey(CommandBusyHandlerType.Remove));
			}
			if (section.TryUnwrap<ISection, IWorkflowSection>(out IWorkflowSection value6))
			{
				state.Service.AddCommandBusySectionHandler(value6.GoBackCommand, CommandBusyHandlerType.GoBack, section, state.GetKey(CommandBusyHandlerType.GoBack));
				state.Service.AddCommandBusySectionHandler(value6.GoNextCommand, CommandBusyHandlerType.GoNext, section, state.GetKey(CommandBusyHandlerType.GoNext));
				state.Service.AddCommandBusySectionHandler(value6.CompleteCommand, CommandBusyHandlerType.Complete, section, state.GetKey(CommandBusyHandlerType.Complete));
			}
		}

		private static void Unregister(ISection section, CommandBusySectionHandler state)
		{
			if (section.TryUnwrap<ISection, IBusyManagerAwareSection>(out IBusyManagerAwareSection value))
			{
				value.Detach(state.Service, null);
			}
			if (section.TryUnwrap<ISection, IRefreshableSection>(out IRefreshableSection value2))
			{
				state.Service.RemoveCommandBusySectionHandler(value2.RefreshCommand, CommandBusyHandlerType.Refresh, state.GetKey(CommandBusyHandlerType.Refresh));
			}
			if (section.TryUnwrap<ISection, IReloadableSection>(out IReloadableSection value3))
			{
				state.Service.RemoveCommandBusySectionHandler(value3.ReloadCommand, CommandBusyHandlerType.Reload, state.GetKey(CommandBusyHandlerType.Reload));
			}
			if (section.TryUnwrap<ISection, ILoadMoreSupportSection>(out ILoadMoreSupportSection value4))
			{
				state.Service.RemoveCommandBusySectionHandler(value4.LoadMoreCommand, CommandBusyHandlerType.LoadMore, state.GetKey(CommandBusyHandlerType.LoadMore));
			}
			if (section.TryUnwrap<ISection, IRemovableSection>(out IRemovableSection value5))
			{
				state.Service.RemoveCommandBusySectionHandler(value5.RemoveCommand, CommandBusyHandlerType.Remove, state.GetKey(CommandBusyHandlerType.Remove));
			}
			if (section.TryUnwrap<ISection, IWorkflowSection>(out IWorkflowSection value6))
			{
				state.Service.RemoveCommandBusySectionHandler(value6.GoBackCommand, CommandBusyHandlerType.GoBack, state.GetKey(CommandBusyHandlerType.GoBack));
				state.Service.RemoveCommandBusySectionHandler(value6.GoNextCommand, CommandBusyHandlerType.GoNext, state.GetKey(CommandBusyHandlerType.GoNext));
				state.Service.RemoveCommandBusySectionHandler(value6.CompleteCommand, CommandBusyHandlerType.Complete, state.GetKey(CommandBusyHandlerType.Complete));
			}
		}
	}
	public sealed class CommandSynchronizerSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, ISuppressAppErrorsListenerSection
	{
		private IReadOnlyObservableCollection<object>? _bind;

		private ICompositeCommand? _reloadCommand;

		private ICompositeCommand? _refreshCommand;

		private ICompositeCommand? _loadMoreCommand;

		private ICompositeCommand? _goNextCommand;

		private ICompositeCommand? _goBackCommand;

		private ICompositeCommand? _completedCommand;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CommandSynchronizerSection))]
		public CommandSynchronizerSection()
		{
		}

		public void OnAttached(IShell shell)
		{
			if (_bind != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_bind = shell.Sections.Configure().WithState(this).For(ObservableCollectionSectionPredicate.Root<IReloadableSection>())
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IReloadableSection> v, CommandSynchronizerSection s)
				{
					if (v.OldItem?.ReloadCommand != null)
					{
						s._refreshCommand?.RemoveSynchronizationWith(v.OldItem.ReloadCommand, bidirectional: false);
						s._loadMoreCommand?.RemoveSynchronizationWith(v.OldItem.ReloadCommand, bidirectional: false);
						s._goNextCommand?.RemoveSynchronizationWith(v.OldItem.ReloadCommand);
						s._goBackCommand?.RemoveSynchronizationWith(v.OldItem.ReloadCommand);
						s._completedCommand?.RemoveSynchronizationWith(v.OldItem.ReloadCommand);
					}
					s._reloadCommand = v.Item?.ReloadCommand;
					if (s._reloadCommand != null)
					{
						s._refreshCommand?.SynchronizeWith(s._reloadCommand, bidirectional: false);
						s._loadMoreCommand?.SynchronizeWith(s._reloadCommand, bidirectional: false);
						s._goNextCommand?.SynchronizeWith(s._reloadCommand);
						s._goBackCommand?.SynchronizeWith(s._reloadCommand);
						s._completedCommand?.SynchronizeWith(s._reloadCommand);
					}
				})
				.For(ObservableCollectionSectionPredicate.Root<IRefreshableSection>())
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IRefreshableSection> v, CommandSynchronizerSection s)
				{
					if (v.OldItem?.RefreshCommand != null)
					{
						v.OldItem.RefreshCommand.RemoveSynchronizationWith(s._reloadCommand, bidirectional: false);
						v.OldItem.RefreshCommand.RemoveSynchronizationWith(s._goNextCommand, bidirectional: false);
						v.OldItem.RefreshCommand.RemoveSynchronizationWith(s._goBackCommand, bidirectional: false);
						v.OldItem.RefreshCommand.RemoveSynchronizationWith(s._completedCommand, bidirectional: false);
						v.OldItem.RefreshCommand.RemoveSynchronizationWith(s._loadMoreCommand);
					}
					s._refreshCommand = v.Item?.RefreshCommand;
					if (s._refreshCommand != null)
					{
						s._refreshCommand.SynchronizeWith(s._reloadCommand, bidirectional: false);
						s._refreshCommand.SynchronizeWith(s._goNextCommand, bidirectional: false);
						s._refreshCommand.SynchronizeWith(s._goBackCommand, bidirectional: false);
						s._refreshCommand.SynchronizeWith(s._completedCommand, bidirectional: false);
						s._refreshCommand.SynchronizeWith(s._loadMoreCommand);
					}
				})
				.For(ObservableCollectionSectionPredicate.Root<ILoadMoreSupportSection>())
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<ILoadMoreSupportSection> v, CommandSynchronizerSection s)
				{
					if (v.OldItem?.LoadMoreCommand != null)
					{
						v.OldItem.LoadMoreCommand.RemoveSynchronizationWith(s._reloadCommand, bidirectional: false);
						v.OldItem.LoadMoreCommand.RemoveSynchronizationWith(s._goNextCommand, bidirectional: false);
						v.OldItem.LoadMoreCommand.RemoveSynchronizationWith(s._goBackCommand, bidirectional: false);
						v.OldItem.LoadMoreCommand.RemoveSynchronizationWith(s._completedCommand, bidirectional: false);
						v.OldItem.LoadMoreCommand.RemoveSynchronizationWith(s._refreshCommand);
					}
					s._loadMoreCommand = v.Item?.LoadMoreCommand;
					if (s._loadMoreCommand != null)
					{
						s._loadMoreCommand.SynchronizeWith(s._reloadCommand, bidirectional: false);
						s._loadMoreCommand.SynchronizeWith(s._goNextCommand, bidirectional: false);
						s._loadMoreCommand.SynchronizeWith(s._goBackCommand, bidirectional: false);
						s._loadMoreCommand.SynchronizeWith(s._completedCommand, bidirectional: false);
						s._loadMoreCommand.SynchronizeWith(s._refreshCommand);
					}
				})
				.For(ObservableCollectionSectionPredicate.Root<IWorkflowSection>())
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IWorkflowSection> v, CommandSynchronizerSection s)
				{
					if (v.OldItem?.GoBackCommand != null)
					{
						s._refreshCommand?.RemoveSynchronizationWith(v.OldItem.GoBackCommand, bidirectional: false);
						s._loadMoreCommand?.RemoveSynchronizationWith(v.OldItem.GoBackCommand, bidirectional: false);
						v.OldItem.GoBackCommand.RemoveSynchronizationWith(s._reloadCommand);
						v.OldItem.GoBackCommand.RemoveSynchronizationWith(s._goNextCommand);
						v.OldItem.GoBackCommand.RemoveSynchronizationWith(s._completedCommand);
					}
					if (v.OldItem?.GoNextCommand != null)
					{
						s._refreshCommand?.RemoveSynchronizationWith(v.OldItem.GoNextCommand, bidirectional: false);
						s._loadMoreCommand?.RemoveSynchronizationWith(v.OldItem.GoNextCommand, bidirectional: false);
						v.OldItem.GoNextCommand.RemoveSynchronizationWith(s._reloadCommand);
						v.OldItem.GoNextCommand.RemoveSynchronizationWith(s._goBackCommand);
						v.OldItem.GoNextCommand.RemoveSynchronizationWith(s._completedCommand);
					}
					if (v.OldItem?.CompleteCommand != null)
					{
						s._refreshCommand?.RemoveSynchronizationWith(v.OldItem.CompleteCommand, bidirectional: false);
						s._loadMoreCommand?.RemoveSynchronizationWith(v.OldItem.CompleteCommand, bidirectional: false);
						v.OldItem.CompleteCommand.RemoveSynchronizationWith(s._reloadCommand);
						v.OldItem.CompleteCommand.RemoveSynchronizationWith(s._goBackCommand);
						v.OldItem.CompleteCommand.RemoveSynchronizationWith(s._goNextCommand);
					}
					s._goBackCommand = v.Item?.GoBackCommand;
					s._goNextCommand = v.Item?.GoNextCommand;
					s._completedCommand = v.Item?.CompleteCommand;
					if (s._goBackCommand != null)
					{
						s._refreshCommand?.SynchronizeWith(s._goBackCommand, bidirectional: false);
						s._loadMoreCommand?.SynchronizeWith(s._goBackCommand, bidirectional: false);
						s._goBackCommand.SynchronizeWith(s._reloadCommand);
						s._goBackCommand.SynchronizeWith(s._goNextCommand);
						s._goBackCommand.SynchronizeWith(s._completedCommand);
					}
					if (s._goNextCommand != null)
					{
						s._refreshCommand?.SynchronizeWith(s._goNextCommand, bidirectional: false);
						s._loadMoreCommand?.SynchronizeWith(s._goNextCommand, bidirectional: false);
						s._goNextCommand.SynchronizeWith(s._reloadCommand);
						s._goNextCommand.SynchronizeWith(s._goBackCommand);
						s._goNextCommand.SynchronizeWith(s._completedCommand);
					}
					if (s._completedCommand != null)
					{
						s._refreshCommand?.SynchronizeWith(s._completedCommand, bidirectional: false);
						s._loadMoreCommand?.SynchronizeWith(s._completedCommand, bidirectional: false);
						s._completedCommand.SynchronizeWith(s._reloadCommand);
						s._completedCommand.SynchronizeWith(s._goBackCommand);
						s._completedCommand.SynchronizeWith(s._goNextCommand);
					}
				})
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
		}
	}
	public class CompositeSection : CompositeSectionBase, IShellSection, IShellAware, IHasDisposeCallback, IHasDisposedState, IDisposable, ISupportDisposeCallback, IShellAwareSection, ISection, IInner<ISection>, ICompositeSection
	{
		private Func<ObservableCollectionConfiguration<ISection, UnitRef>, ObservableCollectionConfiguration<ISection, UnitRef>>? _configure;

		public virtual SectionVisibility CompositeSectionVisibility => SectionVisibility.Hidden;

		public IShell? Shell { get; set; }

		IReadOnlyCollection<ISection> ICompositeSection.Sections => base.Sections;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CompositeSection))]
		public CompositeSection(Func<ObservableCollectionConfiguration<ISection, UnitRef>, ObservableCollectionConfiguration<ISection, UnitRef>>? configure = null)
		{
			_configure = configure;
		}

		protected override ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			Func<ObservableCollectionConfiguration<ISection, UnitRef>, ObservableCollectionConfiguration<ISection, UnitRef>> configure = _configure;
			_configure = null;
			return configure?.Invoke(configuration) ?? configuration.AutoRefreshOnPropertyChangedSection(ShellViewModel.ObservableProperties, CompositeUIExtensions.GetReloadArgs).AutoRefreshOnVisualSectionVisibilityChanged().WithSectionVisibilityFilter(includeInvisible: true)
				.WithSectionPriority()
				.FlattenCompositeSection(checkVisibility: true);
		}
	}
	public class CompositeSectionBase : DisposableBindableModelBase
	{
		private readonly ObservableList<ISection> _sections;

		private IReadOnlyObservableCollection<ISection?>? _sectionsBind;

		private bool _updateSectionsInBatch;

		private Func<object, IReadOnlyMetadataContext?, bool>? _canClear;

		private bool _switchToBackgroundOnAsyncLoad;

		private int _switchToBackgroundItemsThreshold;

		public bool UpdateSectionsInBatch
		{
			get
			{
				return _updateSectionsInBatch;
			}
			set
			{
				if (value != _updateSectionsInBatch)
				{
					_updateSectionsInBatch = value;
					OnPropertyChanged(CompositeUIExtensions.UpdateSectionsInBatchArgs);
				}
			}
		}

		public bool SwitchToBackgroundOnAsyncLoad
		{
			get
			{
				return _switchToBackgroundOnAsyncLoad;
			}
			set
			{
				if (value != _switchToBackgroundOnAsyncLoad)
				{
					_switchToBackgroundOnAsyncLoad = value;
					OnPropertyChanged(CompositeUIExtensions.SwitchToBackgroundOnAsyncLoadArgs);
				}
			}
		}

		public int SwitchToBackgroundItemsThreshold
		{
			get
			{
				return _switchToBackgroundItemsThreshold;
			}
			set
			{
				if (value != _switchToBackgroundItemsThreshold)
				{
					_switchToBackgroundItemsThreshold = value;
					OnPropertyChanged(CompositeUIExtensions.SwitchToBackgroundItemsThresholdArgs);
				}
			}
		}

		public Func<object, IReadOnlyMetadataContext?, bool>? CanClearOnFirstItem
		{
			get
			{
				return _canClear;
			}
			set
			{
				if (!object.Equals(value, _canClear))
				{
					_canClear = value;
					OnPropertyChanged(CompositeUIExtensions.CanClearOnFirstItemArgs);
				}
			}
		}

		public IReadOnlyObservableCollection<ISection> Sections
		{
			get
			{
				if (_sectionsBind == null)
				{
					Initialize();
				}
				return _sectionsBind;
			}
		}

		protected ObservableList<ISection> SectionsRaw => _sections;

		protected virtual bool RaisePendingNotifications => false;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CompositeSectionBase))]
		protected CompositeSectionBase()
		{
			_sections = new ObservableList<ISection>(8);
			_switchToBackgroundOnAsyncLoad = true;
			_switchToBackgroundItemsThreshold = 50;
		}

		public bool RemoveSection(ISection section)
		{
			Should.NotBeNull(section, "section");
			bool num = _sections.Remove(section);
			if (num)
			{
				section.Dispose();
			}
			return num;
		}

		public void ClearSections()
		{
			ClearSections(dispose: false);
		}

		public async ValueTask<bool?> UpdateSectionsAsync(IAsyncEnumerator<ISection> enumerator, IReadOnlyMetadataContext? metadata = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ActionToken globalToken = default(ActionToken);
			ActionToken updateToken = default(ActionToken);
			PooledDictionarySlim<ISection, int> oldSections = new PooledDictionarySlim<ISection, int>(_sections.Count, ReferenceEqualityComparer.Instance);
			PooledItemOrList<ISection> pendingSections = default(PooledItemOrList<ISection>);
			bool cleared = false;
			bool? result;
			try
			{
				if (cancellationToken.IsCancellationRequested)
				{
					result = false;
				}
				else
				{
					_ = Sections;
					Func<object, IReadOnlyMetadataContext?, bool> canClearOnFirstItem = CanClearOnFirstItem;
					if (UpdateSectionsInBatch)
					{
						globalToken = _sections.BatchUpdate(metadata);
					}
					else
					{
						updateToken = _sections.BatchUpdate(metadata);
					}
					foreach (ISection section in _sections)
					{
						oldSections.GetOrAddValueRef(section)++;
					}
					cleared = _sections.Count == 0;
					if (!cleared && canClearOnFirstItem == null)
					{
						cleared = true;
						_sections.Clear();
					}
					int addedCount = 0;
					while (true)
					{
						if (cancellationToken.IsCancellationRequested)
						{
							result = false;
							break;
						}
						ValueTask<bool> task = enumerator.MoveNextAsync();
						if (!task.IsCompleted)
						{
							updateToken.Dispose();
							if (SwitchToBackgroundOnAsyncLoad)
							{
								await IMugenService<IMugenApplication>.Instance.SwitchToBackgroundAsync();
								addedCount = int.MinValue;
							}
						}
						if (await task.ConfigureAwait(continueOnCapturedContext: false))
						{
							int num = addedCount + 1;
							addedCount = num;
							if (addedCount > SwitchToBackgroundItemsThreshold)
							{
								updateToken.Dispose();
								await IMugenService<IMugenApplication>.Instance.SwitchToBackgroundAsync();
								addedCount = int.MinValue;
							}
							ISection current = enumerator.Current;
							using (_sections.Lock())
							{
								if (!cleared && canClearOnFirstItem(current, metadata) && !cancellationToken.IsCancellationRequested)
								{
									_sections.Clear();
									ArraySegmentEnumerator<ISection> enumerator2 = pendingSections.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										ISection current2 = enumerator2.Current;
										TryRemove(ref oldSections, current2);
										_sections.Add(current2);
									}
									pendingSections.Clear();
									pendingSections.Dispose();
									cleared = true;
								}
								if (cleared)
								{
									TryRemove(ref oldSections, current);
									if (!cancellationToken.IsCancellationRequested)
									{
										_sections.Add(current);
									}
								}
								else
								{
									pendingSections.Add(current);
								}
								if (cancellationToken.IsCancellationRequested)
								{
									result = false;
									break;
								}
							}
							continue;
						}
						result = !cancellationToken.IsCancellationRequested && cleared;
						break;
					}
				}
			}
			finally
			{
				if (cleared)
				{
					foreach (KeyValuePair<ISection, int> item in oldSections)
					{
						item.Key.Dispose();
					}
				}
				else
				{
					ArraySegmentEnumerator<ISection> enumerator2 = pendingSections.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ISection current3 = enumerator2.Current;
						if (!oldSections.ContainsKey(current3))
						{
							current3.Dispose();
						}
					}
				}
				oldSections.Dispose();
				pendingSections.Dispose();
				globalToken.Dispose();
				updateToken.Dispose();
				await enumerator.DisposeAsync().ConfigureAwait(continueOnCapturedContext: false);
				if (RaisePendingNotifications)
				{
					Sections.RaisePendingNotifications(metadata);
				}
			}
			return result;
		}

		protected virtual ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration;
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				base.OnDispose(disposing: true);
				_sections.TryInvoke<IReadOnlyObservableCollection, ReleaseBindingCollectionRequest, Unit>(ReleaseBindingCollectionRequest.Instance);
				ClearSections(dispose: true);
				_sections.Dispose();
			}
			else
			{
				base.OnDispose(disposing);
			}
		}

		protected virtual void OnSectionInitialized()
		{
		}

		private static void TryRemove(ref PooledDictionarySlim<ISection, int> dict, ISection section)
		{
			ref int valueRefOrNullRef = ref dict.GetValueRefOrNullRef(section);
			if (!Unsafe.IsNullRef(in valueRefOrNullRef) && --valueRefOrNullRef == 0)
			{
				dict.Remove(section);
			}
		}

		private void ClearSections(bool dispose)
		{
			if (_sections.IsDisposed)
			{
				return;
			}
			using PooledItemOrList<ISection> pooledItemOrList = new PooledItemOrList<ISection>(_sections.Count);
			using (_sections.Lock())
			{
				pooledItemOrList.AddRange(_sections);
				if (!dispose)
				{
					_sections.Clear();
				}
			}
			ArraySegmentEnumerator<ISection> enumerator = pooledItemOrList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.Dispose();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNull("_sectionsBind")]
		private void Initialize()
		{
			using (_sections.Lock())
			{
				if (_sectionsBind != null)
				{
					return;
				}
				_sectionsBind = ConfigureSections(_sections.Configure().WithCallback(delegate(IReadOnlyObservableCollection c, object? o)
				{
					((CompositeSectionBase)o)._sectionsBind = (IReadOnlyObservableCollection<ISection>)c;
				}, this)).BindTyped<ISection>();
			}
			OnSectionInitialized();
		}
	}
	public sealed class CompositeSectionRaw : ICompositeSection, ISection, IInner<ISection>, IDisposable
	{
		public bool DisposeSections { get; }

		public IReadOnlyCollection<ISection> Sections { get; }

		public SectionVisibility CompositeSectionVisibility => SectionVisibility.Hidden;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CompositeSectionRaw))]
		public CompositeSectionRaw(IReadOnlyCollection<ISection> sections, bool disposeSections)
		{
			Should.NotBeNull(sections, "sections");
			Sections = sections;
			DisposeSections = disposeSections;
		}

		public void Dispose()
		{
			if (DisposeSections)
			{
				foreach (ISection section in Sections)
				{
					section.Dispose();
				}
			}
			(Sections as IDisposable)?.Dispose();
		}
	}
	[DebuggerDisplay("View={View}, {Section}")]
	public class DataContextTargetAwareSection : SectionWrapperBase, IDataContextTargetAware, IDataContextWrapper
	{
		private IWeakReference? _view;

		public object? View => _view?.Target;

		public DataContextTargetAwareSection(ISection section)
			: base(section)
		{
		}

		public void OnAttached(object? target, IReadOnlyMetadataContext? metadata)
		{
			_view = target.ToWeakReferenceRaw();
		}

		public void OnDetached(object? target, IReadOnlyMetadataContext? metadata)
		{
			_view = null;
		}
	}
	public sealed class DisposableScopeSection : IHasDisposeCallback, IHasDisposedState, IDisposable, ISupportDisposeCallback, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>
	{
		internal static readonly DisposableScopeSection Disposed = new DisposableScopeSection(_: true);

		private DisposeTokenHandler _disposeTokenHandler;

		public bool IsDisposed => _disposeTokenHandler.IsDisposed;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(DisposableScopeSection))]
		public DisposableScopeSection()
		{
			_disposeTokenHandler = new DisposeTokenHandler(this);
		}

		private DisposableScopeSection(bool _)
			: this()
		{
			Dispose();
		}

		public PooledReadOnlyList<KeyValuePair<string?, ActionToken>> GetDisposeTokens(string? id)
		{
			return _disposeTokenHandler.GetTokens(id);
		}

		public void RegisterDisposeToken(ActionToken token, string? id)
		{
			_disposeTokenHandler.Register(token, id);
		}

		public bool UnregisterDisposeToken(ActionToken token, string? id)
		{
			return _disposeTokenHandler.Unregister(token, id);
		}

		public void Dispose()
		{
			_disposeTokenHandler.Dispose();
		}
	}
	[DebuggerDisplay("Hidden: {Target}")]
	public sealed class HiddenDisposableSection : IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		public IDisposable Target { get; }

		public SectionVisibility Visibility => SectionVisibility.Hidden;

		public HiddenDisposableSection(IDisposable target)
		{
			Should.NotBeNull(target, "target");
			Target = target;
		}

		public void Dispose()
		{
			Target.Dispose();
		}
	}
	[DebuggerDisplay("Value={Value}")]
	public sealed class ImmutableValueSection<T> : IDataContextWrapper, IValueSection<T>, ISection, IInner<ISection>, IDisposable, IHasReadOnlyValue<T>, IHasReadOnlyValue, IEquatable<ImmutableValueSection<T>>
	{
		public T Value { get; }

		object? IDataContextWrapper.DataContext => Value;

		public ImmutableValueSection(T value)
		{
			Value = value;
		}

		public override bool Equals(object? obj)
		{
			if (this != obj)
			{
				if (obj is ImmutableValueSection<T> other)
				{
					return Equals(other);
				}
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return EqualityComparer<T>.Default.GetHashCode(Value);
		}

		public bool Equals(ImmutableValueSection<T>? other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			return EqualityComparer<T>.Default.Equals(Value, other.Value);
		}
	}
	[DebuggerDisplay("Invisible: {Section}")]
	public sealed class InvisibleSection : SectionWrapperBase, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		public InvisibleSection(ISection section)
			: base(section)
		{
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class LoadMoreSectionRaw : ILoadMoreSupportSection, ISection, IInner<ISection>, IDisposable, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly Disposable<ICompositeCommand?> _command;

		[HandlesResourceDisposal]
		public required Disposable<ICompositeCommand?> LoadMoreCommand
		{
			get
			{
				return _command;
			}
			init
			{
				_command = value.WithActionInvokerSource(this);
			}
		}

		public bool IsVertical { get; }

		ICompositeCommand? ILoadMoreSupportSection.LoadMoreCommand => LoadMoreCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(LoadMoreSectionRaw))]
		public LoadMoreSectionRaw(bool isVertical)
		{
			IsVertical = isVertical;
		}

		public LoadMoreSectionRaw Execute(object? parameter = null, bool isForce = false, IReadOnlyMetadataContext? metadata = null)
		{
			_command.Target?.Execute(parameter, isForce, metadata);
			return this;
		}

		public void Dispose()
		{
			LoadMoreCommand.Dispose();
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class RefreshableSectionRaw : IRefreshableSection, ISection, IInner<ISection>, IDisposable, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly Disposable<ICompositeCommand?> _command;

		[HandlesResourceDisposal]
		public required Disposable<ICompositeCommand?> RefreshCommand
		{
			get
			{
				return _command;
			}
			init
			{
				_command = value.WithActionInvokerSource(this);
			}
		}

		ICompositeCommand? IRefreshableSection.RefreshCommand => RefreshCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(RefreshableSectionRaw))]
		public RefreshableSectionRaw()
		{
		}

		public RefreshableSectionRaw Execute(object? parameter = null, bool isForce = false, IReadOnlyMetadataContext? metadata = null)
		{
			_command.Target?.Execute(parameter, isForce, metadata);
			return this;
		}

		public void Dispose()
		{
			RefreshCommand.Dispose();
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class ReloadableSectionRaw : IReloadableSection, ISection, IInner<ISection>, IDisposable, IBusyManagerAwareSection, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly bool _refreshBusy;

		private readonly Disposable<ICompositeCommand> _command;

		[HandlesResourceDisposal]
		public required Disposable<ICompositeCommand> ReloadCommand
		{
			get
			{
				return _command;
			}
			init
			{
				_command = value.WithActionInvokerSource(this);
			}
		}

		ICompositeCommand IReloadableSection.ReloadCommand => ReloadCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ReloadableSectionRaw))]
		public ReloadableSectionRaw(bool refreshBusy)
		{
			_refreshBusy = refreshBusy;
		}

		public ReloadableSectionRaw Execute(object? parameter = null, bool isForce = false, IReadOnlyMetadataContext? metadata = null)
		{
			_command.Target?.Execute(parameter, isForce, metadata);
			return this;
		}

		public void Attach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			if (_refreshBusy)
			{
				busyManager.AddCommandBusySectionHandler(ReloadCommand.Target, CommandBusyHandlerType.Refresh, this, null, metadata);
			}
		}

		public void Detach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			if (_refreshBusy)
			{
				busyManager.RemoveCommandBusySectionHandler(ReloadCommand.Target, CommandBusyHandlerType.Refresh);
			}
		}

		public void Dispose()
		{
			ReloadCommand.Dispose();
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class RemovableSectionRaw : IRemovableSection, ISection, IInner<ISection>, IDisposable, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly Disposable<ICompositeCommand?> _command;

		[HandlesResourceDisposal]
		public required Disposable<ICompositeCommand?> RemoveCommand
		{
			get
			{
				return _command;
			}
			init
			{
				_command = value.WithActionInvokerSource(this);
			}
		}

		ICompositeCommand? IRemovableSection.RemoveCommand => RemoveCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(RemovableSectionRaw))]
		public RemovableSectionRaw()
		{
		}

		public RemovableSectionRaw Execute(object? parameter = null, bool isForce = false, IReadOnlyMetadataContext? metadata = null)
		{
			_command.Target?.Execute(parameter, isForce, metadata);
			return this;
		}

		public void Dispose()
		{
			RemoveCommand.Dispose();
		}
	}
	public sealed class ResultSection<T> : IHasResult<Optional<T>>, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, ISuppressAppErrorsListenerSection
	{
		public Optional<T> Result { get; set; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ResultSection<>))]
		public ResultSection()
		{
		}
	}
	public abstract class RootSectionBase : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IExternalValueHolder<IWeakReference>, IExternalValueHolder<AttachedValueContainer>
	{
		AttachedValueContainer? IExternalValueHolder<AttachedValueContainer>._Value { get; set; }

		IWeakReference? IExternalValueHolder<IWeakReference>._Value { get; set; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(RootSectionBase))]
		protected RootSectionBase()
		{
		}
	}
	public static class SectionListenerSection
	{
		public static ISection GetValidationErrors<TState>(TState state, Func<IValidationErrorsAwareSection?, TState, IDisposable?> bindFunc, Func<IValidationErrorsAwareSection, TState, bool>? condition = null)
		{
			return Get(state, bindFunc, condition);
		}

		public static ISection GetAppErrors<TState>(TState state, Func<IAppErrorsAwareSection?, TState, IDisposable?> bindFunc, Func<IAppErrorsAwareSection, TState, bool>? condition = null)
		{
			return Get(state, bindFunc, condition);
		}

		public static ISection GetBusyTokens<TState>(TState state, Func<IBusyTokensAwareSection?, TState, IDisposable?> bindFunc, Func<IBusyTokensAwareSection, TState, bool>? condition = null)
		{
			return Get(state, bindFunc, condition);
		}

		public static ISection Get<TTarget, TState>(TState state, Func<TTarget?, TState, IDisposable?> bindFunc, Func<TTarget, TState, bool>? condition = null) where TTarget : class
		{
			return new SectionListenerSection<TTarget, TState>(state, bindFunc, condition);
		}
	}
	internal sealed class SectionListenerSection<TTarget, TState> : IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, ISuppressAppErrorsListenerSection where TTarget : class
	{
		private readonly TState _state;

		private readonly Func<TTarget?, TState, IDisposable?> _bindFunc;

		private readonly Func<TTarget, TState, bool>? _condition;

		private IReadOnlyObservableCollection<object>? _root;

		private IDisposable? _token;

		public SectionListenerSection(TState state, Func<TTarget?, TState, IDisposable?> bindFunc, Func<TTarget, TState, bool>? condition)
		{
			_state = state;
			_bindFunc = bindFunc;
			_condition = condition;
		}

		public void OnAttached(IShell shell)
		{
			_root = shell.Sections.Configure().WithState(this).ForWrapper<ISection, TTarget>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<TTarget> v, SectionListenerSection<TTarget, TState> d)
				{
					d._token?.Dispose();
					d._token = d._bindFunc(v.Item, d._state);
				}, (_condition == null) ? null : ((Func<TTarget, SectionListenerSection<TTarget, TState>, bool>)((TTarget t, SectionListenerSection<TTarget, TState> s) => s._condition(t, s._state))))
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_root?.Dispose();
			_root = null;
		}
	}
	[DebuggerDisplay("Priority = {Priority}: {Section}")]
	public sealed class SectionPriorityWrapper : SectionWrapperBase, IHasPrioritySection, ISection, IInner<ISection>, IDisposable, IHasPriority
	{
		public int Priority { get; }

		public SectionPriorityWrapper(ISection section, int priority)
			: base(section)
		{
			Priority = priority;
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public abstract class SectionWrapperBase : IDataContextWrapperSection, IDataContextWrapper, ISection, IInner<ISection>, IDisposable, IDecorator<ISection>
	{
		public ISection Section { get; }

		IInner<ISection> IDecorator<ISection>.Next => Section;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(SectionWrapperBase))]
		protected SectionWrapperBase(ISection section)
		{
			Should.NotBeNull(section, "section");
			Section = section;
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class SelectableSectionRaw : ISelectableSection, ISection, IInner<ISection>, IDisposable, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly Disposable<ICompositeCommand?> _command;

		[HandlesResourceDisposal]
		public required Disposable<ICompositeCommand?> SelectCommand
		{
			get
			{
				return _command;
			}
			init
			{
				_command = value.WithActionInvokerSource(this);
			}
		}

		ICompositeCommand? ISelectableSection.SelectCommand => SelectCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(SelectableSectionRaw))]
		public SelectableSectionRaw()
		{
		}

		public SelectableSectionRaw Execute(object? parameter = null, bool isForce = false, IReadOnlyMetadataContext? metadata = null)
		{
			_command.Target?.Execute(parameter, isForce, metadata);
			return this;
		}

		public void Dispose()
		{
			SelectCommand.Dispose();
		}
	}
	public class ShellLayoutSection : DisposableBindableModelBase, IShellLayoutSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasPrioritySection, IHasPriority
	{
		private IReadOnlyObservableCollection<ISection>? _sections;

		private IShell? _shell;

		public IReadOnlyObservableCollection<ISection>? Sections
		{
			get
			{
				return _sections;
			}
			protected set
			{
				if (!object.Equals(value, _sections))
				{
					_sections = value;
					OnPropertyChanged(CompositeUIExtensions.SectionsArgs);
				}
			}
		}

		public int Priority { get; init; } = 1073741823;

		public IShell? Shell
		{
			get
			{
				return _shell;
			}
			private set
			{
				if (!object.Equals(value, _shell))
				{
					_shell = value;
					OnPropertyChanged(CompositeUIExtensions.ShellArgs);
				}
			}
		}

		public virtual object Content => this;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ShellLayoutSection))]
		public ShellLayoutSection()
		{
		}

		public virtual void OnAttached(IShell shell)
		{
			if (shell != _shell)
			{
				if (Shell != null)
				{
					ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
				}
				Shell = shell;
				Sections = Configure(shell.Sections.Configure()).BindTyped<ISection>();
			}
		}

		public virtual void OnDetached(IShell shell)
		{
			_sections?.Dispose();
			_sections = null;
			Shell = null;
		}

		protected virtual ObservableCollectionConfiguration<ISection, UnitRef> Configure(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration.WithSectionVisibilityFilter(includeInvisible: false).WithBatchUpdateDelay();
		}
	}
	public sealed class ShellSectionHandler : RootSectionBase, IRefreshableSection, ISection, IInner<ISection>, IDisposable, ICloseableSection, ILoadMoreSupportSection, ISelectorSection, ISelectableSection, IRemovableSection, IReloadableSection, IHasPrioritySection, IHasPriority
	{
		private ImmutableList<ISelectorSection> _selectors;

		private IReadOnlyObservableCollection<object>? _bind;

		private IShell? _shell;

		private EventHandler? _raiseSelectedHandler;

		public ICompositeCommand CloseCommand { get; }

		public int Priority { get; init; } = -1073741824;

		public ICompositeCommand LoadMoreCommand { get; }

		public ICompositeCommand RefreshCommand { get; }

		public ICompositeCommand ReloadCommand { get; }

		public ICompositeCommand RemoveCommand { get; }

		public ICompositeCommand SelectCommand { get; }

		public event EventHandler? IsSelectedChanged;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ShellSectionHandler))]
		[DynamicDependency("IsSelected", typeof(ISelectorSection))]
		[DynamicDependency("IsSelectedChanged", typeof(ISelectorSection))]
		public ShellSectionHandler()
		{
			_selectors = ImmutableList<ISelectorSection>.Empty;
			RefreshCommand = CompositeCommand.CreateChildAdapter(this, null, ChildCommandAdapter.AnyNoExecutingCanExecuteHandler).ToCommand();
			LoadMoreCommand = CompositeCommand.CreateChildAdapter(this, null, ChildCommandAdapter.AnyNoExecutingCanExecuteHandler).ToCommand();
			SelectCommand = CompositeCommand.CreateChildAdapter(this, ChildCommandAdapter.ExecuteSequentiallyHandler, ChildCommandAdapter.AnyNoExecutingCanExecuteHandler, canExecuteEmptyResult: false, -10000, suppressCanExecuteCheck: true).ToCommand();
			RemoveCommand = CompositeCommand.CreateChildAdapter(this, ChildCommandAdapter.ExecuteSequentiallyHandler, ChildCommandAdapter.AnyNoExecutingCanExecuteHandler, canExecuteEmptyResult: false, -10000, suppressCanExecuteCheck: true).ToCommand();
			CloseCommand = CompositeCommand.Create((object?)this, (Func<IReadOnlyMetadataContext?, CancellationToken, Task>)CloseAsync, allowMultipleExecution: false, (Func<IReadOnlyMetadataContext?, bool>?)null, (IReadOnlyMetadataContext?)null).ToCommand();
			ReloadCommand = CompositeCommand.Create(this, Reload).ToCommand();
			if (!RuntimeFeature.IsDynamicCodeSupported)
			{
				ReflectionMugenExtensions.LinkerIncludeGenericType(typeof(MethodMemberInfo<object, object, bool>));
			}
		}

		public void Dispose()
		{
			this.IsSelectedChanged = null;
			CloseCommand.Dispose();
			LoadMoreCommand.Dispose();
			RefreshCommand.Dispose();
			ReloadCommand.Dispose();
			RemoveCommand.Dispose();
			SelectCommand.Dispose();
		}

		public void OnAttached(IShell shell)
		{
			if (shell != _shell)
			{
				if (_shell != null)
				{
					ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
				}
				_shell = shell;
				_bind = shell.Sections.Configure().For(delegate(object? o)
				{
					ISection section = (ISection)o;
					return (section.IsWrappedAs<ISection, IRootSection>() || (!section.IsWrappedAs<ISection, IRefreshableSection>() && !section.IsWrappedAs<ISection, ILoadMoreSupportSection>() && !section.IsWrappedAs<ISection, IRemovableSection>() && !section.IsWrappedAs<ISection, ISelectableSection>())) ? default(Optional<ISection>) : Optional.Get(section, hasValue: true);
				}).WithState(this)
					.TrackItems(Register, Unregister)
					.Bind();
			}
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
			_shell = null;
		}

		public bool IsSelected(object? item)
		{
			foreach (ISelectorSection selector in _selectors)
			{
				if (selector.IsSelected(item))
				{
					return true;
				}
			}
			return false;
		}

		private static void Register(ISection section, ShellSectionHandler state)
		{
			if (section.TryUnwrap<ISection, IRefreshableSection>(out IRefreshableSection value) && state.RefreshCommand.AddChildCommand(value.RefreshCommand) && value.AutoRefreshOnAttach)
			{
				value.RefreshCommand.Execute(null);
			}
			if (section.TryUnwrap<ISection, ILoadMoreSupportSection>(out ILoadMoreSupportSection value2) && value2 != null && value2.IsVertical)
			{
				state.LoadMoreCommand.AddChildCommand(value2.LoadMoreCommand);
			}
			if (section.TryUnwrap<ISection, IRemovableSection>(out IRemovableSection value3))
			{
				state.RemoveCommand.AddChildCommand(value3.RemoveCommand);
			}
			if (section.TryUnwrap<ISection, ISelectableSection>(out ISelectableSection value4))
			{
				state.SelectCommand.AddChildCommand(value4.SelectCommand);
				if (value4 is ISelectorSection selectorSection && ImmutableInterlocked.Update<ImmutableList<ISelectorSection>, ISelectorSection>(ref state._selectors, (ImmutableList<ISelectorSection> set, ISelectorSection v) => set.Add(v), selectorSection))
				{
					selectorSection.IsSelectedChanged += state.RaiseSelectedHandler;
				}
			}
		}

		private static void Unregister(ISection section, ShellSectionHandler state)
		{
			if (section.TryUnwrap<ISection, IRefreshableSection>(out IRefreshableSection value))
			{
				state.RefreshCommand.RemoveChildCommand(value.RefreshCommand);
			}
			if (section.TryUnwrap<ISection, ILoadMoreSupportSection>(out ILoadMoreSupportSection value2) && value2 != null && value2.IsVertical)
			{
				state.LoadMoreCommand.RemoveChildCommand(value2.LoadMoreCommand);
			}
			if (section.TryUnwrap<ISection, IRemovableSection>(out IRemovableSection value3))
			{
				state.RemoveCommand.RemoveChildCommand(value3.RemoveCommand);
			}
			if (section.TryUnwrap<ISection, ISelectableSection>(out ISelectableSection value4))
			{
				state.SelectCommand.RemoveChildCommand(value4.SelectCommand);
				if (value4 is ISelectorSection selectorSection)
				{
					state._selectors = state._selectors.Remove(selectorSection);
					selectorSection.IsSelectedChanged -= state._raiseSelectedHandler;
				}
			}
		}

		private ValueTask<bool?> Reload(ICompositeCommand cmd, ExecuteCommandRequest request, UnitRef _, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell == null || request.Parameter == null)
			{
				return default(ValueTask<bool?>);
			}
			IAsyncEnumerator<ISection> asyncEnumerator = IMugenService<IMugenApplication>.Instance.TryGetSections(shell, request.Parameter, metadata, cancellationToken);
			if (asyncEnumerator == null)
			{
				return default(ValueTask<bool?>);
			}
			return shell.UpdateSectionsAsync(asyncEnumerator, metadata, cancellationToken);
		}

		private Task CloseAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell == null)
			{
				return Task.CompletedTask;
			}
			using PooledReadOnlyList<NavigationResult> values = IMugenService<INavigationDispatcher>.Instance.TryCloseViewModel(shell, null, metadata, cancellationToken);
			return values.WaitClosingAsync(metadata, CancellationToken.None);
		}

		private void RaiseSelectedHandler(object? sender, EventArgs e)
		{
			this.IsSelectedChanged?.Invoke(((object)_shell) ?? ((object)this), e);
		}
	}
	[DebuggerDisplay("SuppressDispose: {Section}")]
	public class SuppressDisposeSectionWrapper : SectionWrapperBase, ISection, IInner<ISection>, IDisposable
	{
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(SuppressDisposeSectionWrapper))]
		public SuppressDisposeSectionWrapper(ISection target)
			: base(target)
		{
		}

		public void Dispose()
		{
		}
	}
	public sealed class TemporarySectionWrapper : SectionWrapperBase, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware
	{
		private byte _state;

		public IShell? Shell { get; set; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(TemporarySectionWrapper))]
		public TemporarySectionWrapper(ISection section)
			: base(section)
		{
		}

		public void OnAttached(IShell shell)
		{
			if (Volatile.Read(in _state) != 0)
			{
				DetachImpl(shell);
			}
		}

		public void Dispose()
		{
			if (Interlocked.Exchange(ref _state, 1) == 0)
			{
				DetachImpl(Shell);
			}
		}

		private void DetachImpl(IShell? shell)
		{
			if (shell != null)
			{
				shell.RemoveSection(this);
				base.Section.Dispose();
			}
		}
	}
	public sealed class ValidatableSectionRaw : IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IHasService<IValidator>, IHasOptionalService<IValidator>, ISuppressAppErrorsListenerSection
	{
		public IValidator Validator { get; }

		IValidator IHasService<IValidator>.Service => Validator;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValidatableSectionRaw))]
		public ValidatableSectionRaw()
		{
			Validator = IMugenService<IMugenApplication>.Instance.GetValidator(this);
		}

		public void Dispose()
		{
			Validator.Dispose();
		}
	}
	public sealed class ValidationErrorsAwareSection : IValidationErrorsAwareSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IHasService<IValidator>, IHasOptionalService<IValidator>, IApiHandlerComponent<IValidator, OnErrorsChangedValidatorRequest, Unit>, IApiHandlerComponent<IValidator>, IApiProviderComponent<IValidator>, IApiProviderComponent, IComponent, ISupportRequestComponent<IValidator>, IComponent<IValidator>, ISupportApiHandlerComponent<IValidator, OnErrorsChangedValidatorRequest>, ISuppressAppErrorsListenerSection
	{
		private readonly Lock _locker;

		private readonly ObservableSet<ValidationErrorInfo, ValidationErrorInfoRef> _errors;

		private IReadOnlyObservableCollection<object>? _bind;

		public IValidator Service { get; }

		public IReadOnlyObservableCollection<ValidationErrorInfoRef> Errors => _errors;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValidationErrorsAwareSection))]
		public ValidationErrorsAwareSection()
		{
			_locker = new Lock();
			_errors = new ObservableSet<ValidationErrorInfo, ValidationErrorInfoRef>((ValidationErrorInfoRef e) => e.ErrorInfo);
			Service = CompositeValidator.Create();
			Service.AddComponent(this);
		}

		public Unit TryInvoke(OnErrorsChangedValidatorRequest request, IValidator apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			UpdateErrors(apiProvider, metadata);
			return default(Unit);
		}

		public void OnAttached(IShell shell)
		{
			if (_bind != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_bind = shell.Sections.Configure().WithState(this).For((object? o) => Optional.Get(MugenExtensions.TryUnwrap<ISection, IHasService<IValidator>>(o)?.Service))
				.TrackItems(Register, Unregister)
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
		}

		public void Dispose()
		{
			_errors.Dispose();
		}

		private static void Register(IValidator validator, ValidationErrorsAwareSection state)
		{
			state.Service.AddChildValidator(validator);
		}

		private static void Unregister(IValidator validator, ValidationErrorsAwareSection state)
		{
			state.Service.RemoveChildValidator(validator);
		}

		private void UpdateErrors(IValidator validator, IReadOnlyMetadataContext? metadata = null)
		{
			ActionToken actionToken = _errors.BatchUpdate(metadata);
			PooledListSlim<ValidationErrorInfoRef> pooledListSlim = new PooledListSlim<ValidationErrorInfoRef>(0);
			try
			{
				using (_locker.EnterScope())
				{
					foreach (ValidationErrorInfo item in validator.GetErrors().GetDisposableEnumerator())
					{
						pooledListSlim.Add(_errors.TryGetValue(item, out ValidationErrorInfoRef value) ? value : new ValidationErrorInfoRef(item));
					}
				}
				_errors.Reset(pooledListSlim);
			}
			finally
			{
				pooledListSlim.Dispose();
				actionToken.Dispose();
			}
		}
	}
	public sealed class ViewsAwareSection : RootSectionBase, IViewsAwareSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IApiHandlerComponent<IViewManager, OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo>, Unit>, IApiHandlerComponent<IViewManager>, IApiProviderComponent<IViewManager>, IApiProviderComponent, IComponent, ISupportRequestComponent<IViewManager>, IComponent<IViewManager>, ISupportApiHandlerComponent<IViewManager, OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo>>, ISuppressAppErrorsListenerSection
	{
		private readonly ObservableSet<IView> _views = new ObservableSet<IView>(ReferenceEqualityComparer.Instance);

		private IShell? _shell;

		public IReadOnlyObservableCollection<IView> Views => _views;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ViewsAwareSection))]
		public ViewsAwareSection()
		{
		}

		public Unit TryInvoke(OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo> request, IViewManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell != null && request.Target.TryGet<IView>(out IView view) && view.ViewModel == shell)
			{
				if (request.LifecycleState == ViewLifecycleState.Initializing)
				{
					_views.Add(view);
				}
				else if (request.LifecycleState == ViewLifecycleState.Clearing)
				{
					_views.Remove(view);
				}
			}
			return default(Unit);
		}

		public void OnAttached(IShell shell)
		{
			if (shell == _shell)
			{
				return;
			}
			if (_shell != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			_shell = shell;
			IMugenService<IViewManager>.Instance.AddComponent(this);
			foreach (IView item in IMugenService<IViewManager>.Instance.GetViewsByViewModel(_shell).GetDisposableEnumerator())
			{
				_views.Add(item);
			}
		}

		public void OnDetached(IShell shell)
		{
			IMugenService<IViewManager>.Instance.RemoveComponent(this);
			_shell = null;
			_views.Clear();
		}

		public void Dispose()
		{
			_views.Dispose();
		}
	}
	[DebuggerDisplay("Visibility={Visibility}, {Next}")]
	public sealed class VisibilitySectionWrapper : NotifyPropertyChangedBase, IHasVisibilitySection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IDataContextWrapperSection, IDataContextWrapper, IDecorator<ISection>
	{
		private SectionVisibility? _visibility;

		public IInner<ISection> Next { get; }

		public SectionVisibility Visibility
		{
			get
			{
				return _visibility ?? SectionVisibility.Visible;
			}
			[param: AllowNull]
			set
			{
				if (!EqualityComparer<SectionVisibility>.Default.Equals(value, Visibility))
				{
					_visibility = value;
					OnPropertyChanged(CompositeUIExtensions.VisibilityArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(VisibilitySectionWrapper))]
		public VisibilitySectionWrapper(ISection target)
		{
			Should.NotBeNull(target, "target");
			Next = target;
		}
	}
	public sealed class WorkflowSectionHandler : RootSectionBase, IWorkflowHandlerSection, IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IWorkflowSection, IReloadableSection, IHasCloseConditionSection, IHasPrioritySection, IHasPriority
	{
		private sealed class StepsSection : CompositeSectionBase, IHasPriority, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IShellSection, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICompositeSection, IApiHandlerComponent<ICompositeCommand, ExecuteCommandRequest, ValueTask<bool?>>, IApiHandlerComponent<ICompositeCommand>, IApiProviderComponent<ICompositeCommand>, IApiProviderComponent, IComponent, ISupportRequestComponent<ICompositeCommand>, IComponent<ICompositeCommand>, ISupportApiHandlerComponent<ICompositeCommand, ExecuteCommandRequest>, IApiHandlerComponent<ICompositeCommand, CanExecuteCommandRequest, bool?>, ISupportApiHandlerComponent<ICompositeCommand, CanExecuteCommandRequest>
		{
			private readonly WorkflowSectionHandler _handler;

			private IReadOnlyObservableCollection<ISection>? _invisibleSections;

			private ISelectedItemTracker<IValueSection<IWorkflowStepInfo>>? _selectedItemTracker;

			private IShell? _shell;

			public ISelectedItemTracker<IValueSection<IWorkflowStepInfo>> Tracker => _selectedItemTracker;

			public SectionVisibility CompositeSectionVisibility => SectionVisibility.Invisible;

			public int Priority => int.MaxValue;

			public IShell? Shell
			{
				get
				{
					return _shell;
				}
				set
				{
					if (!object.Equals(value, _shell))
					{
						_shell = value;
						OnPropertyChanged(CompositeUIExtensions.ShellArgs);
					}
				}
			}

			IReadOnlyCollection<ISection> ICompositeSection.Sections
			{
				get
				{
					_ = base.Sections;
					return _invisibleSections;
				}
			}

			[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(StepsSection))]
			public StepsSection(WorkflowSectionHandler handler)
			{
				_handler = handler;
				base.UpdateSectionsInBatch = true;
			}

			public int IndexOf(IWorkflowStepInfo? step)
			{
				if (step == null)
				{
					return -1;
				}
				int num = 0;
				foreach (IValueSection<IWorkflowStepInfo> section in base.Sections)
				{
					if (section.Value.Equals(step))
					{
						return num;
					}
					num++;
				}
				return -1;
			}

			public bool? TryInvoke(CanExecuteCommandRequest request, ICompositeCommand apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				return !_handler._suspended;
			}

			public ValueTask<bool?> TryInvoke(ExecuteCommandRequest request, ICompositeCommand apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				if (!_handler._suspended)
				{
					return default(ValueTask<bool?>);
				}
				return new ValueTask<bool?>(false);
			}

			protected override ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
			{
				_invisibleSections = configuration.Source.Configure().For<ISection>().Select((CollectionPredicateItem<ISection> s, IInvisibleSection? v, UnitRef _) => v ?? s.Item.AsInvisibleSection())
					.BindTyped<ISection>();
				return configuration.AutoRefreshOnPropertyChangedSection("Visibility").AutoRefreshOnVisualSectionVisibilityChanged().WithSectionVisibilityFilter(includeInvisible: false)
					.Where((ISection s, UnitRef _) => s.IsWrappedAs<ISection, IValueSection<IWorkflowStepInfo>>())
					.ForWrapper<ISection, IValueSection<IWorkflowStepInfo>>()
					.OrderBy((IValueSection<IWorkflowStepInfo> i, UnitRef _) => i.Value.Priority, SortingComparerBuilder.DescendingComparer<int>.Instance)
					.WithState(this)
					.TrackSelectedItem<IValueSection<IWorkflowStepInfo>, IValueSection<IWorkflowStepInfo>, StepsSection>(Default.Selector<IValueSection<IWorkflowStepInfo>>(), out _selectedItemTracker, delegate(IReadOnlyObservableCollection _, IValueSection<IWorkflowStepInfo>? t, StepsSection s, IReadOnlyMetadataContext? m)
					{
						s._handler.SetCurrentStepAsync(t?.Value, m, default(CancellationToken));
					}, delegate(IReadOnlyCollection<IValueSection<IWorkflowStepInfo>> infos, IValueSection<IWorkflowStepInfo>? _, StepsSection s)
					{
						IWorkflowStepInfo defaultStep = s._handler.State.DefaultStep;
						if (defaultStep != null)
						{
							foreach (IValueSection<IWorkflowStepInfo> info in infos)
							{
								if (object.Equals(info.Value, defaultStep))
								{
									return info;
								}
							}
						}
						return infos.FirstOrDefault();
					})
					.For<ISection>()
					.NoState();
			}
		}

		private static Expression<Func<IValidationErrorsAwareSection, bool>>? _bindCache2;

		private static readonly IMetadataContextKey<bool> Executed = MetadataContextKey.FromKey<bool>("!#rr");

		private readonly StepsSection _stepsSection;

		private IShell? _shell;

		private IReadOnlyObservableCollection<object>? _bind;

		private ImmutableHashSet<ICompositeCommand> _actionCommands;

		private bool _isNextMove;

		private bool _suspended;

		private bool _hasAppErrors;

		private bool _hasValidationErrors;

		private bool _isValidating;

		private bool _isBusy;

		private IWorkflowStepInfo? _currentStep;

		private IWorkflowStepInfo? _currentVisibleStep;

		private IDisposable? _validationErrorsDisposable;

		private ActionToken _validationErrorsValidatingDisposable;

		private IDisposable? _appErrorsDisposable;

		private IDisposable? _busyDisposable;

		public IWorkflowSectionApiRequest State { get; }

		public int Priority { get; init; } = -1073740824;

		public ICompositeCommand ReloadCommand { get; }

		public ICompositeCommand CompleteCommand { get; }

		public ICompositeCommand GoBackCommand { get; }

		public ICompositeCommand GoNextCommand { get; }

		private IViewsAwareSection? ViewsAware { get; set; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(WorkflowSectionHandler))]
		public WorkflowSectionHandler(IWorkflowSectionApiRequest state, out ISection stepsSection)
		{
			Should.NotBeNull(state, "state");
			State = state;
			_isNextMove = true;
			_actionCommands = ImmutableHashSet<ICompositeCommand>.Empty;
			_stepsSection = new StepsSection(this);
			Func<ICompositeCommand, ImmutableHashSet<ICompositeCommand>, ExecuteCommandRequest, IReadOnlyMetadataContext, CancellationToken, ValueTask<bool?>> executeHandler = ExecuteGo;
			GoBackCommand = CompositeCommand.CreateChildAdapter(this, executeHandler, null, canExecuteEmptyResult: true).ToCommand();
			GoNextCommand = CompositeCommand.CreateChildAdapter(this, executeHandler, CanExecuteGoNext, canExecuteEmptyResult: true).ToCommand();
			CompleteCommand = CompositeCommand.CreateChildAdapter(this, ChildCommandAdapter.ExecuteSequentiallyHandler).ToCommand();
			ReloadCommand = CompositeCommand.Create(this, this, ReloadAsync).ToCommand();
			stepsSection = _stepsSection;
		}

		public async ValueTask<bool> OnBackNavigationAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (_stepsSection.IndexOf(_currentStep) > 0)
			{
				await GoBackCommand.ExecuteAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return false;
			}
			return true;
		}

		public void OnAttached(IShell shell)
		{
			if (shell == _shell)
			{
				return;
			}
			if (_shell != null)
			{
				ExceptionManager.ThrowObjectInitialized(this, "OnAttached");
			}
			if (shell is CompositeSectionBase compositeSectionBase)
			{
				compositeSectionBase.UpdateSectionsInBatch = true;
				compositeSectionBase.CanClearOnFirstItem = IsVisibleSection;
			}
			_shell = shell;
			_bind = shell.Sections.Configure().WithState(this).ForWrapper<ISection, IValidationErrorsAwareSection>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IValidationErrorsAwareSection> v, WorkflowSectionHandler d)
				{
					d._validationErrorsDisposable?.Dispose();
					d._validationErrorsValidatingDisposable.Dispose();
					if (v.HasItem)
					{
						d._validationErrorsValidatingDisposable = d.Bind().Combine(v.Item.B(_bindCache2 ?? (_bindCache2 = (IValidationErrorsAwareSection e) => e.IsValidating())), delegate(WorkflowSectionHandler s, bool b)
						{
							s._isValidating = b;
							s.GoNextCommand.RaiseCanExecuteChanged();
							return Unit.Value;
						}).Subscribe();
						d._validationErrorsDisposable = v.Item.Errors.Configure().WithState(d).FirstOrDefault(delegate(IReadOnlyObservableCollection readOnlyObservableCollection, CollectionItemInfo<ValidationErrorInfoRef> collectionItemInfo, WorkflowSectionHandler workflowSectionHandler)
						{
							workflowSectionHandler._hasValidationErrors = collectionItemInfo.HasItem;
							workflowSectionHandler.GoNextCommand.RaiseCanExecuteChanged();
						})
							.Bind();
					}
					else
					{
						d._isValidating = false;
						d._hasValidationErrors = false;
						d.GoNextCommand.RaiseCanExecuteChanged();
					}
				})
				.ForWrapper<ISection, IAppErrorsAwareSection>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IAppErrorsAwareSection> v, WorkflowSectionHandler d)
				{
					d._appErrorsDisposable?.Dispose();
					if (v.HasItem)
					{
						d._appErrorsDisposable = v.Item.Errors.Configure().WithState(d).FirstOrDefault(delegate(IReadOnlyObservableCollection readOnlyObservableCollection, CollectionItemInfo<IAppErrorInfo> collectionItemInfo, WorkflowSectionHandler workflowSectionHandler)
						{
							workflowSectionHandler._hasAppErrors = collectionItemInfo.HasItem;
							workflowSectionHandler.GoNextCommand.RaiseCanExecuteChanged();
						}, (IAppErrorInfo info, WorkflowSectionHandler workflowSectionHandler) => info.IsFatal)
							.Bind();
					}
					else
					{
						d._hasAppErrors = false;
						d.GoNextCommand.RaiseCanExecuteChanged();
					}
				})
				.ForWrapper<ISection, IBusyTokensAwareSection>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IBusyTokensAwareSection> v, WorkflowSectionHandler d)
				{
					d._busyDisposable?.Dispose();
					if (v.HasItem)
					{
						d._busyDisposable = v.Item.BusyTokens.Configure().WithState(d).FirstOrDefault(delegate(IReadOnlyObservableCollection readOnlyObservableCollection, CollectionItemInfo<IBusyToken> collectionItemInfo, WorkflowSectionHandler workflowSectionHandler)
						{
							workflowSectionHandler._isBusy = collectionItemInfo.HasItem;
							workflowSectionHandler.GoNextCommand.RaiseCanExecuteChanged();
						})
							.Bind();
					}
					else
					{
						d._isBusy = false;
						d.GoNextCommand.RaiseCanExecuteChanged();
					}
				})
				.ForWrapper<ISection, IViewsAwareSection>()
				.FirstOrDefault(delegate(IReadOnlyObservableCollection _, CollectionItemInfo<IViewsAwareSection> v, WorkflowSectionHandler d)
				{
					d.ViewsAware = v.Item;
				})
				.For((object? o) => (!(o is ISection section) || section.Inner == this || (!section.IsWrappedAs<ISection, IWorkflowSection>() && !section.IsWrappedAs<ISection, IWorkflowSuspendableSection>())) ? default(Optional<ISection>) : Optional.Get(section, hasValue: true))
				.TrackItems(Register, Unregister)
				.Bind();
		}

		public void OnDetached(IShell shell)
		{
			_bind?.Dispose();
			_bind = null;
			_shell = null;
		}

		public void Dispose()
		{
			_stepsSection.Dispose();
			GoBackCommand.Dispose();
			GoNextCommand.Dispose();
			ReloadCommand.Dispose();
			CompleteCommand.Dispose();
		}

		private static void Register(ISection section, WorkflowSectionHandler state)
		{
			if (section.TryUnwrap<ISection, IWorkflowSection>(out IWorkflowSection value))
			{
				state.CompleteCommand.AddChildCommand(value.CompleteCommand);
				state.GoBackCommand.AddChildCommand(value.GoBackCommand);
				state.GoNextCommand.AddChildCommand(value.GoNextCommand);
			}
			if (section.TryUnwrap<ISection, IWorkflowSuspendableSection>(out IWorkflowSuspendableSection value2))
			{
				value2.Register(state);
			}
		}

		private static void Unregister(ISection section, WorkflowSectionHandler state)
		{
			if (section.TryUnwrap<ISection, IWorkflowSection>(out IWorkflowSection value))
			{
				state.CompleteCommand.RemoveChildCommand(value.CompleteCommand);
				state.GoBackCommand.RemoveChildCommand(value.GoBackCommand);
				state.GoNextCommand.RemoveChildCommand(value.GoNextCommand);
				value.GoBackCommand?.MetadataOptional?.Remove(Executed);
				value.GoNextCommand?.MetadataOptional?.Remove(Executed);
			}
			if (section.TryUnwrap<ISection, IWorkflowSuspendableSection>(out IWorkflowSuspendableSection value2))
			{
				value2.Unregister(state);
			}
		}

		private static bool HasSections(IShell shell)
		{
			foreach (ISection section in shell.Sections)
			{
				if (IsVisibleSection(section))
				{
					return true;
				}
			}
			return false;
		}

		private static bool IsVisibleSection(object? section, IReadOnlyMetadataContext? _ = null)
		{
			return MugenExtensions.TryUnwrap<ISection, IHasReadOnlyVisibilitySection>(section)?.Visibility.IsVisible() ?? true;
		}

		private static ValueTask<bool?> ReloadAsync(ICompositeCommand target, ExecuteCommandRequest request, WorkflowSectionHandler state, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IWorkflowStepInfo workflowStepInfo = null;
			if (request.Parameter is IWorkflowStepInfo workflowStepInfo2)
			{
				workflowStepInfo = workflowStepInfo2;
			}
			else if (request.Parameter == null)
			{
				workflowStepInfo = state._currentStep;
				if (workflowStepInfo == null)
				{
					return default(ValueTask<bool?>);
				}
			}
			if (workflowStepInfo == null)
			{
				IAsyncEnumerator<ISection> asyncEnumerator = IMugenService<IMugenApplication>.Instance.TryGetSections(state._stepsSection, request.Parameter, metadata, cancellationToken);
				if (asyncEnumerator != null)
				{
					return state._stepsSection.UpdateSectionsAsync(asyncEnumerator, metadata, cancellationToken);
				}
				return default(ValueTask<bool?>);
			}
			return state.ReloadAsync(workflowStepInfo, metadata, cancellationToken);
		}

		private Task SetCurrentStepAsync(IWorkflowStepInfo? step, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			lock (this)
			{
				IWorkflowStepInfo currentStep = _currentStep;
				if (currentStep == step || cancellationToken.IsCancellationRequested)
				{
					return Task.CompletedTask;
				}
				_currentStep = step;
				if (!object.Equals(_stepsSection.Tracker.Value?.Value, step) && !_stepsSection.Tracker.SetSelectedItem(_stepsSection.Tracker.Find(step, (IValueSection<IWorkflowStepInfo> v, IWorkflowStepInfo s) => object.Equals(v.Value, s))))
				{
					_currentStep = currentStep;
					return Task.CompletedTask;
				}
			}
			return _shell?.TryGetRootReloadCommand()?.ExecuteAsync(step, isForce: true, metadata, cancellationToken).AsVoidTask() ?? Task.CompletedTask;
		}

		private async ValueTask<bool?> ReloadAsync(IWorkflowStepInfo? step, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell == null)
			{
				return false;
			}
			if (step == null)
			{
				step = _currentStep;
				if (step == null)
				{
					return false;
				}
			}
			else if (_currentStep != step)
			{
				await SetCurrentStepAsync(step, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return false;
			}
			await ResetLayoutAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (await shell.UpdateSectionsAsync(State.GetSectionsRequest(shell, step, metadata).GetSections(IMugenService<IMugenApplication>.Instance, metadata, cancellationToken), metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false) == true)
			{
				await shell.Sections.WaitBatchUpdateAsync(raisePendingNotifications: true, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (HasSections(shell))
				{
					_currentVisibleStep = step;
					return true;
				}
			}
			await _stepsSection.Sections.WaitBatchUpdateAsync(raisePendingNotifications: true, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return await (_isNextMove ? GoNextCommand : GoBackCommand).ExecuteAsync(metadata, cancellationToken).GetValueOrDefaultAsync(defaultResult: false).ConfigureAwait(continueOnCapturedContext: false);
		}

		private async Task MoveAsync(bool isNext, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (_shell == null)
			{
				return;
			}
			int num = _stepsSection.IndexOf(_currentStep) + (isNext ? 1 : (-1));
			if (num < 0)
			{
				await CloseAsync(metadata, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (num >= _stepsSection.Sections.Count)
			{
				await HideKeyboardAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				_currentStep = _currentVisibleStep;
				if (await CompleteCommand.ExecuteAsync(metadata, cancellationToken).GetValueOrDefaultAsync(defaultResult: false).ConfigureAwait(continueOnCapturedContext: false))
				{
					await CloseAsync(metadata, CancellationToken.None).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			else
			{
				_isNextMove = isNext;
				await SetCurrentStepAsync(((IValueSection<IWorkflowStepInfo>)_stepsSection.Sections.ElementAt(num)).Value, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}

		private bool CanGoNext()
		{
			if (!_hasAppErrors && !_hasValidationErrors)
			{
				return !_isValidating;
			}
			return false;
		}

		private Task CloseAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return _shell?.TryGetRootCloseCommand()?.ExecuteAsync(metadata, cancellationToken).AsVoidTask() ?? Task.CompletedTask;
		}

		private async Task HideKeyboardAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IViewsAwareSection viewsAware = ViewsAware;
			if (viewsAware == null)
			{
				return;
			}
			foreach (IView view in viewsAware.Views)
			{
				await view.HideKeyboardAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}

		private async Task ResetLayoutAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IViewsAwareSection viewsAware = ViewsAware;
			if (viewsAware == null)
			{
				return;
			}
			foreach (IView view in viewsAware.Views)
			{
				await view.ResetLayoutAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}

		private void SetSuspended(IShell shell, bool value, IReadOnlyMetadataContext? metadata)
		{
			using (shell.Sections.Lock(metadata))
			{
				_suspended = value;
				if (value)
				{
					return;
				}
				foreach (ICompositeCommand actionCommand in _actionCommands)
				{
					if (actionCommand.Components.TryAdd(_stepsSection))
					{
						actionCommand.RaiseCanExecuteChanged();
					}
				}
			}
		}

		private async Task WaitCommandsAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			bool completed;
			do
			{
				completed = true;
				foreach (ICompositeCommand actionCommand in _actionCommands)
				{
					Task task = actionCommand.WaitAsync(metadata, cancellationToken);
					if (!task.IsCompleted)
					{
						completed = false;
						await task.ConfigureAwait(continueOnCapturedContext: false);
					}
				}
			}
			while (!completed);
		}

		private bool? CanExecuteGoNext(ICompositeCommand target, ImmutableHashSet<ICompositeCommand> commands, CanExecuteCommandRequest request, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (_shell == null)
			{
				return false;
			}
			foreach (ICompositeCommand command in commands)
			{
				if (!(command.TryInvoke<ICompositeCommand, CanExecuteCommandRequest, bool?>(request, metadata, cancellationToken) ?? true))
				{
					return false;
				}
			}
			return CanGoNext() && !_isBusy;
		}

		private async ValueTask<bool?> ExecuteGo(ICompositeCommand target, ImmutableHashSet<ICompositeCommand> commands, ExecuteCommandRequest request, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IShell shell = _shell;
			if (shell == null)
			{
				return null;
			}
			bool isNext = target == GoNextCommand;
			bool owner = false;
			try
			{
				if (!_suspended)
				{
					owner = true;
					SetSuspended(shell, value: true, metadata);
				}
				await shell.Sections.WaitBatchUpdateAsync(raisePendingNotifications: true, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (isNext)
				{
					await WaitCommandsAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (!CanGoNext())
					{
						return false;
					}
				}
				foreach (ICompositeCommand cmd in commands)
				{
					if (!cmd.MetadataOptional.Get(Executed, defaultValue: false))
					{
						if (!((await cmd.TryInvoke<ICompositeCommand, ExecuteCommandRequest, ValueTask<bool?>>(request, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) ?? true))
						{
							return false;
						}
						cmd.Metadata.SetRaw(Executed, BoxingExtensions.TrueObject);
					}
				}
				if (isNext && !CanGoNext())
				{
					return false;
				}
				await MoveAsync(isNext, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return true;
			}
			finally
			{
				if (owner)
				{
					foreach (ICompositeCommand command in commands)
					{
						command.MetadataOptional?.Remove(Executed);
					}
					SetSuspended(shell, value: false, metadata);
				}
			}
		}

		IWorkflowHandlerSection IWorkflowHandlerSection.Register(ICompositeCommand? command)
		{
			if (command != null)
			{
				_actionCommands = _actionCommands.Add(command);
				if (!_suspended)
				{
					command.TryAddComponent(_stepsSection);
					command.RaiseCanExecuteChanged();
				}
			}
			return this;
		}

		IWorkflowHandlerSection IWorkflowHandlerSection.Unregister(ICompositeCommand? command)
		{
			if (command != null)
			{
				_actionCommands = _actionCommands.Remove(command);
				command.RemoveComponent(_stepsSection);
				command.RaiseCanExecuteChanged();
			}
			return this;
		}
	}
	[DebuggerTypeProxy(typeof(BindableModelDebugView))]
	public sealed class WorkflowSectionRaw : IWorkflowSection, ISection, IInner<ISection>, IDisposable, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly Disposable<ICompositeCommand?> _goBackCommand;

		private readonly Disposable<ICompositeCommand?> _completeCommand;

		private readonly Disposable<ICompositeCommand?> _goNextCommand;

		[HandlesResourceDisposal]
		public Disposable<ICompositeCommand?> GoBackCommand
		{
			get
			{
				return _goBackCommand;
			}
			init
			{
				_goBackCommand = value.WithActionInvokerSource(this);
			}
		}

		[HandlesResourceDisposal]
		public Disposable<ICompositeCommand?> GoNextCommand
		{
			get
			{
				return _goNextCommand;
			}
			init
			{
				_goNextCommand = value.WithActionInvokerSource(this);
			}
		}

		[HandlesResourceDisposal]
		public Disposable<ICompositeCommand?> CompleteCommand
		{
			get
			{
				return _completeCommand;
			}
			init
			{
				_completeCommand = value.WithActionInvokerSource(this);
			}
		}

		ICompositeCommand? IWorkflowSection.GoNextCommand => GoNextCommand.Target;

		ICompositeCommand? IWorkflowSection.CompleteCommand => CompleteCommand.Target;

		ICompositeCommand? IWorkflowSection.GoBackCommand => GoBackCommand.Target;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(WorkflowSectionRaw))]
		public WorkflowSectionRaw()
		{
		}

		public void Dispose()
		{
			GoBackCommand.Dispose();
			GoNextCommand.Dispose();
			CompleteCommand.Dispose();
		}
	}
	public sealed class WorkflowSectionResult<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult, TState> : IWorkflowSection, ISection, IInner<ISection>, IDisposable, IHasResult<Optional<TResult>>, IInvisibleSection, IHasReadOnlyVisibilitySection where TRequest : class, IWorkflowSectionApiRequest<TRequest, TResult>
	{
		private readonly TRequest _request;

		private readonly TState _state;

		private readonly Func<TRequest, TState, IReadOnlyMetadataContext?, CancellationToken, ValueTask<Optional<TResult>>> _getResult;

		public Optional<TResult> Result { get; set; }

		public ICompositeCommand CompleteCommand { get; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(WorkflowSectionResult<, , >))]
		public WorkflowSectionResult(TRequest request, TState state, [RequireStaticDelegate] Func<TRequest, TState, IReadOnlyMetadataContext?, CancellationToken, ValueTask<Optional<TResult>>> getResult, [RequireStaticDelegate] Func<CompositeCommandConfiguration<object?>, TState, CompositeCommandConfiguration<object?>>? configure)
		{
			_request = request;
			_state = state;
			_getResult = getResult;
			CompositeCommandConfiguration<object> arg = CompositeCommand.Create(this, CompleteAsync);
			if (configure != null)
			{
				arg = configure(arg, state);
			}
			CompleteCommand = arg.ToCommand();
		}

		public void Dispose()
		{
			CompleteCommand.Dispose();
		}

		private async Task<bool> CompleteAsync(IReadOnlyMetadataContext? m, CancellationToken c)
		{
			Result = await _getResult(_request, _state, m, c).ConfigureAwait(continueOnCapturedContext: false);
			return Result.HasValue;
		}
	}
	public sealed class WorkflowSuspendableSectionRaw : IWorkflowSuspendableSection, ISection, IInner<ISection>, IDisposable, IBusyManagerAwareSection, IInvisibleSection, IHasReadOnlyVisibilitySection
	{
		private readonly bool _refreshBusy;

		public ItemOrIEnumerable<ICompositeCommand> Commands { get; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(WorkflowSuspendableSectionRaw))]
		public WorkflowSuspendableSectionRaw(ItemOrIEnumerable<ICompositeCommand> commands, bool refreshBusy)
		{
			_refreshBusy = refreshBusy;
			Commands = commands;
			foreach (ICompositeCommand item in commands)
			{
				item.WithActionInvokerSource(this);
			}
		}

		public void Attach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			if (!_refreshBusy)
			{
				return;
			}
			foreach (ICompositeCommand command in Commands)
			{
				busyManager.AddCommandBusySectionHandler(command, CommandBusyHandlerType.Refresh, this, null, metadata);
			}
		}

		public void Detach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata)
		{
			if (!_refreshBusy)
			{
				return;
			}
			foreach (ICompositeCommand command in Commands)
			{
				busyManager.RemoveCommandBusySectionHandler(command, CommandBusyHandlerType.Refresh);
			}
		}

		public void Dispose()
		{
			foreach (ICompositeCommand command in Commands)
			{
				if (command.Metadata.Get(CompositeUIMetadata.ActionInvokerSourceCommand) == this)
				{
					command.Dispose();
				}
			}
		}

		public void Register(IWorkflowHandlerSection handler)
		{
			foreach (ICompositeCommand command in Commands)
			{
				handler.Register(command);
			}
		}

		public void Unregister(IWorkflowHandlerSection handler)
		{
			foreach (ICompositeCommand command in Commands)
			{
				handler.Unregister(command);
			}
		}
	}
}
namespace MugenMvvm.CompositeUI.Sections.Visuals
{
	public class ButtonSection : VisualSectionBase, IButtonSection, ISupportFormattedTextSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportTextColorSection, ISupportFontStyleSection, ISupportIconSection
	{
		private FormattedText _text;

		private ImageSource _icon;

		public FormattedText Text
		{
			get
			{
				return _text;
			}
			set
			{
				if (!value.Equals(_text))
				{
					_text = value;
					OnPropertyChanged(CompositeUIExtensions.TextArgs);
				}
			}
		}

		public ImageSource Icon
		{
			get
			{
				return _icon;
			}
			set
			{
				if (!value.Equals(_icon))
				{
					_icon = value;
					OnPropertyChanged(CompositeUIExtensions.IconArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ButtonSection))]
		public ButtonSection(FormattedText text = default(FormattedText), ImageSource icon = default(ImageSource), ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Text = text;
			Icon = icon;
		}
	}
	public class CollectionHostLayoutSection : HostLayoutSectionBase, ICollectionLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICollectionLayoutSectionBase, ISupportOrientationSection, ISupportScrollSection
	{
		public CollectionHostLayoutSection(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, ModifierSet modifiers = default(ModifierSet))
			: base(children, disposeSource, modifiers)
		{
		}
	}
	public class CollectionLayoutSection : EditableLayoutSectionBase, ICollectionLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICollectionLayoutSectionBase, ISupportOrientationSection, ISupportScrollSection
	{
		public CollectionLayoutSection([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
			: base(children)
		{
		}
	}
	public abstract class CompositeLayoutSectionBase : CompositeSectionBase, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IParentMarkerSectionModifier, IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		private ModifierSet _modifiers;

		private IShell? _shell;

		private bool _hasItems;

		public bool HasItems
		{
			get
			{
				return _hasItems;
			}
			protected set
			{
				if (value != _hasItems)
				{
					_hasItems = value;
					OnPropertyChanged(CompositeUIExtensions.HasItemsArgs);
				}
			}
		}

		public IReadOnlyCollection<ISection> Children => base.Sections;

		public IShell? Shell
		{
			get
			{
				return _shell;
			}
			set
			{
				IShell shell = _shell;
				if (object.Equals(value, shell))
				{
					return;
				}
				if (value == null)
				{
					foreach (ISection item in base.SectionsRaw)
					{
						item.Detach(shell);
					}
				}
				else
				{
					foreach (ISection item2 in base.SectionsRaw)
					{
						item2.Attach(value);
					}
				}
				_shell = value;
				OnPropertyChanged(CompositeUIExtensions.ShellArgs);
			}
		}

		public ModifierSet Modifiers => _modifiers;

		ILayoutSection IParentMarkerSectionModifier.Parent => this;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CompositeLayoutSectionBase))]
		protected CompositeLayoutSectionBase(ModifierSet modifiers)
		{
			_modifiers = modifiers;
			base.SectionsRaw.Configure().WithState(this).TrackItems(OnAdded, OnRemoved)
				.Bind();
		}

		public bool UpdateModifiers<TState>(ref TState state, ModifierMutator<TState> mutator, ModifierCleanup<TState>? cleanup = null)
		{
			if (_modifiers.Update(this, mutator, cleanup, ref state))
			{
				OnPropertyChanged(CompositeUIExtensions.ModifiersArgs);
				return true;
			}
			return false;
		}

		public void Invalidate()
		{
			OnPropertyChanged(CompositeUIExtensions.ReloadSectionArgs);
		}

		protected override ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration.LayoutConfig(includePriority: true).WithState(this).Any(delegate(IReadOnlyObservableCollection _, bool b, CompositeLayoutSectionBase s)
			{
				s.HasItems = b;
			})
				.NoState();
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				_modifiers.OnDispose(this);
			}
			base.OnDispose(disposing);
		}

		private static void OnAdded(ISection section, CompositeLayoutSectionBase state)
		{
			section.TryUnwrap<ISection, IVisualSection>()?.WithModifier(state);
			IShell shell = state.Shell;
			if (shell != null)
			{
				section.Attach(shell);
			}
		}

		private static void OnRemoved(ISection section, CompositeLayoutSectionBase state)
		{
			section.TryUnwrap<ISection, IVisualSection>()?.RemoveModifier(state);
			IShell shell = state.Shell;
			if (shell != null)
			{
				section.Detach(shell);
			}
		}
	}
	public class ContentLayoutSection : VisualSectionBase, IContentLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IParentMarkerSectionModifier, IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IFastBindableListener<IVisualSection?>, IBindableListener<IVisualSection?>, IBindableListener, IObserver<IVisualSection?>, IEventListener, IWeakItem, IMemberPathObserverListener
	{
		private IVisualSection? _content;

		public IVisualSection? Content
		{
			get
			{
				return _content;
			}
			set
			{
				if (!object.Equals(value, _content))
				{
					IVisualSection content = _content;
					_content = value;
					OnContentChanged(content, value);
					OnPropertyChanged(CompositeUIExtensions.ContentArgs);
				}
			}
		}

		ILayoutSection IParentMarkerSectionModifier.Parent => this;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ContentLayoutSection))]
		public ContentLayoutSection(ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
		}

		protected virtual void OnContentChanged(IVisualSection? oldContent, IVisualSection? newContent)
		{
			IShell shell = base.Shell;
			if (oldContent != null)
			{
				if (shell != null)
				{
					oldContent.Detach(shell);
				}
				oldContent.RemoveModifier(this);
			}
			if (newContent != null)
			{
				if (shell != null)
				{
					newContent.Attach(shell);
				}
				newContent.WithModifier(this);
			}
		}

		protected override void OnShellChanging(IShell? oldValue, IShell? newValue)
		{
			IVisualSection content = _content;
			if (content != null)
			{
				if (newValue == null)
				{
					content.Detach(oldValue);
				}
				else
				{
					content.Attach(newValue);
				}
			}
		}

		void IBindableListener.OnError(Exception error, BindableErrorType errorType)
		{
		}

		void IBindableListener.OnBeginExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener.OnEndExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener<IVisualSection>.OnValue(IVisualSection? value)
		{
			Content = value;
		}
	}
	public abstract class EditableLayoutSectionBase : VisualSectionBase, IEditableCompositeLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IParentMarkerSectionModifier, IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		internal static readonly string[] ObservablePropertiesComposite = new string[6] { "Visibility", "Children", "Priority", "TemplateKey", "Modifiers", "$Reload" };

		private bool _hasItems;

		private IReadOnlyObservableCollection<IVisualSection>? _children;

		public IReadOnlyObservableCollection<IVisualSection> Children
		{
			get
			{
				if (_children == null)
				{
					Initialize();
				}
				return _children;
			}
		}

		public bool HasItems
		{
			get
			{
				return _hasItems;
			}
			protected set
			{
				if (value != _hasItems)
				{
					_hasItems = value;
					OnPropertyChanged(CompositeUIExtensions.HasItemsArgs);
				}
			}
		}

		protected ObservableList<IVisualSection> ChildrenRaw { get; }

		IReadOnlyCollection<ISection> ICompositeLayoutSection.Children => Children;

		ILayoutSection IParentMarkerSectionModifier.Parent => this;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(EditableLayoutSectionBase))]
		protected EditableLayoutSectionBase(ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			ChildrenRaw = new ObservableList<IVisualSection>();
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(EditableLayoutSectionBase))]
		protected EditableLayoutSectionBase([ParamCollection] scoped ReadOnlySpan<IVisualSection?> sections)
			: base(default(ModifierSet))
		{
			ChildrenRaw = new ObservableList<IVisualSection>(sections.Length);
			ReadOnlySpan<IVisualSection> readOnlySpan = sections;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				IVisualSection visualSection = readOnlySpan[i];
				if (visualSection != null)
				{
					Add(visualSection);
				}
			}
		}

		public void Add(IVisualSection section)
		{
			Should.NotBeNull(section, "section");
			OnAdding(section);
			AddCore(section);
			OnAdded(section);
		}

		public bool Remove(IVisualSection? section)
		{
			if (section == null)
			{
				return false;
			}
			OnRemoving(section);
			if (RemoveCore(section))
			{
				OnRemoved(section);
				return true;
			}
			return false;
		}

		protected virtual void AddCore(IVisualSection section)
		{
			ChildrenRaw.Add(section);
		}

		protected virtual bool RemoveCore(IVisualSection section)
		{
			return ChildrenRaw.Remove(section);
		}

		protected virtual void OnAdding(IVisualSection section)
		{
			IShell shell = base.Shell;
			if (shell != null)
			{
				section.Attach(shell);
			}
			section.WithModifier(this);
		}

		protected virtual void OnAdded(IVisualSection section)
		{
		}

		protected virtual void OnRemoving(IVisualSection section)
		{
		}

		protected virtual void OnRemoved(IVisualSection section)
		{
			section.RemoveModifier(this);
			IShell shell = base.Shell;
			if (shell != null)
			{
				section.Detach(shell);
			}
		}

		protected virtual ObservableCollectionConfiguration<IVisualSection, UnitRef> ConfigureChildren(ObservableCollectionConfiguration<IVisualSection, UnitRef> configuration)
		{
			return configuration.LayoutConfig(includePriority: false).WithState(this).Any(delegate(IReadOnlyObservableCollection _, bool b, EditableLayoutSectionBase s)
			{
				s.HasItems = b;
			})
				.NoState();
		}

		protected override void OnShellChanging(IShell? oldValue, IShell? newValue)
		{
			if (newValue == null)
			{
				foreach (IVisualSection item in ChildrenRaw)
				{
					item.Detach(oldValue);
				}
				return;
			}
			foreach (IVisualSection item2 in ChildrenRaw)
			{
				item2.Attach(newValue);
			}
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				foreach (IVisualSection item in ChildrenRaw)
				{
					item.Dispose();
				}
				ChildrenRaw.Dispose();
			}
			base.OnDispose(disposing);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[MemberNotNull("_children")]
		private void Initialize()
		{
			using (ChildrenRaw.Lock())
			{
				if (_children == null)
				{
					_children = ConfigureChildren(ChildrenRaw.Configure().WithCallback(delegate(IReadOnlyObservableCollection c, object? o)
					{
						((EditableLayoutSectionBase)o)._children = (IReadOnlyObservableCollection<IVisualSection>)c;
					}, this)).BindTyped<IVisualSection>();
				}
			}
		}
	}
	public class FrameHostSection : HostLayoutSectionBase, IFrameLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IFrameLayoutSectionBase, ISupportGravitySection, ISupportZOrderSection
	{
		public FrameHostSection(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, ModifierSet modifiers = default(ModifierSet))
			: base(children, disposeSource, modifiers)
		{
		}

		protected override void OnAdded(IVisualSection section)
		{
			base.OnAdded(section);
			section.WithDefaultGravity();
		}
	}
	public class FrameImmutableSection : ImmutableLayoutSectionBase, IImmutableFrameLayoutSection, IImmutableLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection, IFrameLayoutSectionBase, ISupportGravitySection, ISupportZOrderSection
	{
		public FrameImmutableSection(ImmutableArray<IVisualSection> children, ModifierSet modifiers = default(ModifierSet))
			: base(children, modifiers)
		{
		}

		protected override void InitializeSection(IVisualSection section)
		{
			base.InitializeSection(section);
			section.WithDefaultGravity();
		}
	}
	public class FrameSection : EditableLayoutSectionBase, IFrameLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IFrameLayoutSectionBase, ISupportGravitySection, ISupportZOrderSection
	{
		public FrameSection([ParamCollection] scoped ReadOnlySpan<IVisualSection?> sections)
			: base(sections)
		{
		}

		protected override void OnAdding(IVisualSection section)
		{
			base.OnAdding(section);
			section.WithDefaultGravity();
		}
	}
	public abstract class HostLayoutSectionBase : VisualSectionBase, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IParentMarkerSectionModifier, IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		private readonly IDisposable _token;

		private bool _hasItems;

		public IReadOnlyObservableCollection<IVisualSection> Children { get; }

		public bool HasItems
		{
			get
			{
				return _hasItems;
			}
			private set
			{
				if (value != _hasItems)
				{
					_hasItems = value;
					OnPropertyChanged(CompositeUIExtensions.HasItemsArgs);
				}
			}
		}

		public ILayoutSection Parent => this;

		IReadOnlyCollection<ISection> ICompositeLayoutSection.Children => Children;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(HostLayoutSectionBase))]
		protected HostLayoutSectionBase(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Should.NotBeNull(children, "children");
			Children = children;
			_token = children.Configure().WithState(this).TrackItems(OnAdded, OnRemoved)
				.Any(delegate(IReadOnlyObservableCollection _, bool v, HostLayoutSectionBase s)
				{
					s.HasItems = v;
				})
				.DisposeSource(disposeSource)
				.Bind();
		}

		protected virtual void OnAdded(IVisualSection section)
		{
			section.WithModifier(this);
			IShell shell = base.Shell;
			if (shell != null)
			{
				section.Attach(shell);
			}
		}

		protected virtual void OnRemoved(IVisualSection section)
		{
			section.RemoveModifier(this);
			IShell shell = base.Shell;
			if (shell != null)
			{
				section.Detach(shell);
			}
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				_token.Dispose();
			}
			base.OnDispose(disposing);
		}

		protected override void OnShellChanging(IShell? oldValue, IShell? newValue)
		{
			if (newValue == null)
			{
				foreach (IVisualSection child in Children)
				{
					child.Detach(oldValue);
				}
				return;
			}
			foreach (IVisualSection child2 in Children)
			{
				child2.Attach(newValue);
			}
		}

		private static void OnAdded(IVisualSection section, HostLayoutSectionBase state)
		{
			state.OnAdded(section);
		}

		private static void OnRemoved(IVisualSection section, HostLayoutSectionBase state)
		{
			state.OnRemoved(section);
		}
	}
	public class ImageSection : VisualSectionBase, IImageSection, ISupportTintColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportImageStretchModeSection
	{
		private ImageSource _source;

		public ImageSource Source
		{
			get
			{
				return _source;
			}
			set
			{
				if (!value.Equals(_source))
				{
					_source = value;
					OnPropertyChanged(CompositeUIExtensions.SourceArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ImageSection))]
		public ImageSection(ImageSource source = default(ImageSource), ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Source = source;
		}
	}
	public abstract class ImmutableLayoutSectionBase : VisualSectionBase, IImmutableLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection, IHasTemplateSelectorKey, IParentMarkerSectionModifier, IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		private object? _key;

		public ImmutableArray<IVisualSection> Children { get; }

		object? IHasTemplateSelectorKey.TemplateKey => _key;

		ILayoutSection IParentMarkerSectionModifier.Parent => this;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ImmutableLayoutSectionBase))]
		protected ImmutableLayoutSectionBase(ImmutableArray<IVisualSection> children, ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Should.BeValid(children.Length > 0, "children");
			Children = children;
			ImmutableArray<IVisualSection>.Enumerator enumerator = children.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IVisualSection current = enumerator.Current;
				current.WithModifier(this);
				InitializeSection(current);
				INotifyPropertyChanged notifyPropertyChanged = current;
				if (notifyPropertyChanged != null)
				{
					notifyPropertyChanged.PropertyChanged += OnChildPropertyChanged;
				}
			}
			InvalidateKey();
		}

		protected virtual void InitializeSection(IVisualSection section)
		{
		}

		protected override void OnShellChanged(IShell? oldValue, IShell? newValue)
		{
			if (newValue == null)
			{
				ImmutableArray<IVisualSection>.Enumerator enumerator = Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					enumerator.Current.Detach(oldValue);
				}
			}
			else
			{
				ImmutableArray<IVisualSection>.Enumerator enumerator = Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					enumerator.Current.Attach(newValue);
				}
			}
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				ImmutableArray<IVisualSection>.Enumerator enumerator = Children.GetEnumerator();
				while (enumerator.MoveNext())
				{
					INotifyPropertyChanged current;
					INotifyPropertyChanged notifyPropertyChanged = (current = enumerator.Current);
					if (current != null)
					{
						current.PropertyChanged -= OnChildPropertyChanged;
					}
					((IDisposable)notifyPropertyChanged).Dispose();
				}
			}
			base.OnDispose(disposing);
		}

		private void OnChildPropertyChanged(object? sender, PropertyChangedEventArgs args)
		{
			bool flag;
			switch (args.PropertyName)
			{
			case "Modifiers":
			case "TemplateKey":
			case "$Reload":
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			if (flag && !InvalidateKey() && args.PropertyName == "$Reload")
			{
				Invalidate();
			}
		}

		private bool InvalidateKey()
		{
			string templateId = CompositeUIExtensions.GetTemplateId(this);
			if (object.Equals(templateId, _key))
			{
				return false;
			}
			_key = templateId;
			OnPropertyChanged(CompositeUIExtensions.TemplateKeyArgs);
			return true;
		}
	}
	public class NestedCompositeLayoutsSection : VisualSectionBase, INestedCompositeLayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICompositeSection
	{
		public bool DisposeSections { get; }

		public IReadOnlyCollection<IVisualSection> Children { get; }

		IReadOnlyCollection<ISection> ICompositeSection.Sections => Children;

		SectionVisibility ICompositeSection.CompositeSectionVisibility => SectionVisibility.Invisible;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(NestedCompositeLayoutsSection))]
		public NestedCompositeLayoutsSection(IReadOnlyCollection<IVisualSection> children, bool disposeSections)
			: base(default(ModifierSet))
		{
			Should.NotBeNull(children, "children");
			Children = children;
			DisposeSections = disposeSections;
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				if (DisposeSections)
				{
					foreach (IVisualSection child in Children)
					{
						child.Dispose();
					}
				}
				(Children as IDisposable)?.Dispose();
			}
			base.OnDispose(disposing);
		}
	}
	public class NumberInputSection<T> : TextInputSectionBase<T?>, ISupportMinValueSection<T>, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportMaxValueSection<T>, ISupportFormatSection where T : struct, INumber<T>, IMinMaxValue<T>
	{
		private T _max = T.MaxValue;

		private T _min = T.MinValue;

		private CultureInfo? _cultureInfo;

		private string? _format;

		public string? Format
		{
			get
			{
				return _format;
			}
			set
			{
				if (!(value == _format))
				{
					_format = value;
					SetText(ToString(base.Value), base.IsUserInput);
					OnPropertyChanged(CompositeUIExtensions.FormatArgs);
				}
			}
		}

		public CultureInfo CultureInfo
		{
			get
			{
				return _cultureInfo ?? System.Globalization.CultureInfo.CurrentCulture;
			}
			[param: AllowNull]
			set
			{
				if (!object.Equals(value, _cultureInfo))
				{
					_cultureInfo = value;
					SetText(ToString(base.Value), base.IsUserInput);
					OnPropertyChanged(CompositeUIExtensions.CultureInfoArgs);
				}
			}
		}

		public T Max
		{
			get
			{
				return _max;
			}
			set
			{
				if (!(_max == value))
				{
					_max = value;
					T? value2 = base.Value;
					if (value < value2)
					{
						SetText(ToString(value), base.IsUserInput);
					}
					OnPropertyChanged(CompositeUIExtensions.MaxArgs);
				}
			}
		}

		public T Min
		{
			get
			{
				return _min;
			}
			set
			{
				if (!(_min == value))
				{
					_min = value;
					T? value2 = base.Value;
					if (value > value2)
					{
						SetText(ToString(value), base.IsUserInput);
					}
					OnPropertyChanged(CompositeUIExtensions.MinArgs);
				}
			}
		}

		public NumberInputSection(T? value = null, string? format = null, CultureInfo? cultureInfo = null, ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			base.Value = value;
			_format = format;
			_cultureInfo = cultureInfo;
		}

		protected override T? GetValue(ref string? value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			CultureInfo cultureInfo = CultureInfo;
			if (!T.TryParse(value, NumberStyles.Number, cultureInfo, out var result))
			{
				return null;
			}
			if (result < Min)
			{
				result = Min;
			}
			else if (result > Max)
			{
				result = Max;
			}
			value = result.ToString(Format, cultureInfo);
			return T.Parse(value, NumberStyles.Number, cultureInfo);
		}

		protected override string? ToString(T? value)
		{
			return value?.ToString(Format, CultureInfo);
		}
	}
	public sealed class SpaceSection : VisualSectionBase, IImmutableVisualSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		public SpaceSection(ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
		}
	}
	public class StackImmutableSection : ImmutableLayoutSectionBase, IImmutableStackLayoutSection, IImmutableLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection, IStackLayoutSectionBase, ISupportOrientationSection, ISupportAlignmentSection
	{
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(StackImmutableSection))]
		public StackImmutableSection(ImmutableArray<IVisualSection> children, ModifierSet modifiers = default(ModifierSet))
			: base(children, modifiers)
		{
		}
	}
	public class StackSection : EditableLayoutSectionBase, IStackLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IStackLayoutSectionBase, ISupportOrientationSection, ISupportAlignmentSection
	{
		public StackSection([ParamCollection] scoped ReadOnlySpan<IVisualSection?> children)
			: base(children)
		{
		}
	}
	public class StakeHostSection : HostLayoutSectionBase, IStackLayoutSection, ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IStackLayoutSectionBase, ISupportOrientationSection, ISupportAlignmentSection
	{
		public StakeHostSection(IReadOnlyObservableCollection<IVisualSection> children, bool disposeSource, ModifierSet modifiers = default(ModifierSet))
			: base(children, disposeSource, modifiers)
		{
		}
	}
	public class SwitchSection : VisualSectionBase, ISwitchSection, ISupportTrackTintColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportThumbTintColorSection, IValueInputSection<bool>, IValueInputSection, IHasReadOnlyValue, IHasValue<bool>, IHasReadOnlyValue<bool>
	{
		private bool _value;

		public bool Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (value != _value)
				{
					_value = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(SwitchSection))]
		public SwitchSection(ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
		}
	}
	public class TabLayoutSection : CompositeLayoutSectionBase, IReloadableSection, ISection, IInner<ISection>, IDisposable, IHasTemplateSelectorKey, IShellSection, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		private static Expression<Func<TabLayoutSection, IViewsAwareSection?>>? _bindCache1;

		private ISelectedItemTracker<IValueSection<ITabSectionApiRequest>>? _selectedItemTracker;

		private TabSectionType? _tabType;

		private bool _resetLayout;

		private IViewsAwareSection? _viewsAwareSection;

		public IViewsAwareSection? ViewsAwareSection
		{
			get
			{
				return _viewsAwareSection;
			}
			private set
			{
				if (!object.Equals(value, _viewsAwareSection))
				{
					_viewsAwareSection = value;
					OnPropertyChanged(CompositeUIExtensions.ViewsAwareSectionArgs);
				}
			}
		}

		public IShellSection ContentSection { get; }

		public TabSectionType TabType
		{
			get
			{
				return _tabType ?? TabSectionType.Main;
			}
			set
			{
				if (!object.Equals(value, _tabType))
				{
					_tabType = value;
					OnPropertyChanged(CompositeUIExtensions.TabTypeArgs);
					OnPropertyChanged(CompositeUIExtensions.TemplateKeyArgs);
				}
			}
		}

		public bool ResetLayout
		{
			get
			{
				return _resetLayout;
			}
			set
			{
				if (value != _resetLayout)
				{
					_resetLayout = value;
					OnPropertyChanged(CompositeUIExtensions.ResetLayoutArgs);
				}
			}
		}

		public IValueSection<ITabSectionApiRequest>? SelectedTab
		{
			get
			{
				return _selectedItemTracker?.Value;
			}
			set
			{
				_selectedItemTracker?.SetSelectedItem(value);
			}
		}

		public ICompositeCommand ReloadCommand { get; }

		object IHasTemplateSelectorKey.TemplateKey => TabType;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(TabLayoutSection))]
		public TabLayoutSection(IShellSection contentSection, TabSectionType? tabType = null, ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Should.NotBeNull(contentSection, "contentSection");
			ContentSection = contentSection;
			_tabType = tabType;
			_resetLayout = true;
			ReloadCommand = CompositeCommand.Create((object?)this, (Func<object?, IReadOnlyMetadataContext?, CancellationToken, Task>)ReloadAsync, (Func<object?, IReadOnlyMetadataContext?, bool>?)null, allowMultipleExecution: false, allowNullParameter: false, (IReadOnlyMetadataContext?)null).ToCommand();
			base.UpdateSectionsInBatch = true;
			this.B(_bindCache1 ?? (_bindCache1 = (TabLayoutSection vm) => vm.RootSection<IViewsAwareSection>().Section)).Bind<IViewsAwareSection, TabLayoutSection>(this, delegate(IViewsAwareSection? v, TabLayoutSection s)
			{
				s.ViewsAwareSection = v;
			}).DisposeWith(this);
		}

		public IValueSection<ITabSectionApiRequest>? TryGetByRequest(ITabSectionApiRequest? request)
		{
			return _selectedItemTracker?.Find(request, (IValueSection<ITabSectionApiRequest> v, ITabSectionApiRequest r) => v.Value.Equals(r));
		}

		public TabLayoutSection UpdateTabs(IEnumerable<ISection> tabs, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(tabs, "tabs");
			UpdateSectionsAsync(SynchronousAsyncEnumerable<ISection>.GetEnumerator(ItemOrIEnumerable.FromList(tabs)), metadata).LogException(UnhandledExceptionType.System);
			return this;
		}

		public TabLayoutSection UpdateTabs<T>(T request, IReadOnlyMetadataContext? metadata = null) where T : class, ISectionApiRequest
		{
			ReloadCommand.ForceExecute(new GetTabSectionsRequest<T>(this, request), metadata);
			return this;
		}

		public TabLayoutSection SetSelectedTabByRequest(ITabSectionApiRequest? value)
		{
			SelectedTab = ((value == null) ? null : TryGetByRequest(value));
			return this;
		}

		public TabLayoutSection SetSelectedTab(IValueSection<ITabSectionApiRequest>? value)
		{
			if (value != null)
			{
				SelectedTab = value;
			}
			return this;
		}

		protected override ObservableCollectionConfiguration<ISection, UnitRef> ConfigureSections(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration.AutoRefreshOnPropertyChangedSection(EditableLayoutSectionBase.ObservablePropertiesComposite, CompositeUIExtensions.GetReloadArgs).AutoRefreshOnVisualSectionVisibilityChanged().WithSectionVisibilityFilter(includeInvisible: false)
				.WithSectionPriority()
				.For<INestedCompositeLayoutSection>()
				.SelectMany((INestedCompositeLayoutSection t, ICollectionDecorator<UnitRef> _) => t.Children)
				.For<ISection>()
				.Where((ISection s, UnitRef _) => s.IsWrappedAs<ISection, IValueSection<ITabSectionApiRequest>>())
				.ForWrapper<ISection, IValueSection<ITabSectionApiRequest>>()
				.SelectImmutable()
				.WithState(this)
				.TrackSelectedItem<IValueSection<ITabSectionApiRequest>, string, TabLayoutSection>((IValueSection<ITabSectionApiRequest> s) => s.Value.Id, out _selectedItemTracker, delegate(IReadOnlyObservableCollection _, IValueSection<ITabSectionApiRequest>? v, TabLayoutSection vm, IReadOnlyMetadataContext? m)
				{
					vm.OnPropertyChanged(CompositeUIExtensions.SelectedTabArgs);
					vm.ReloadCommand.ForceExecute(v, m);
				}, null, null, EqualityComparer<IValueSection<ITabSectionApiRequest>>.Default)
				.Any(delegate(IReadOnlyObservableCollection _, bool b, TabLayoutSection vm)
				{
					vm.HasItems = b;
				})
				.For<ISection>()
				.NoState();
		}

		private Task ReloadAsync(object section, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (!(section is IValueSection<ITabSectionApiRequest>) && section is GetSectionsRequestBase getSectionsRequestBase)
			{
				return UpdateSectionsAsync(getSectionsRequestBase.GetSections(IMugenService<IMugenApplication>.Instance, metadata, cancellationToken), metadata, cancellationToken).AsVoidTask();
			}
			if (!(section is IValueSection<ITabSectionApiRequest> valueSection) || (!object.Equals(SelectedTab, valueSection) && SelectedTab?.Value.Id != valueSection.Value.Id))
			{
				return Task.CompletedTask;
			}
			if (ResetLayout)
			{
				ViewsAwareSection.ResetLayout(metadata);
			}
			return ContentSection.UpdateSectionsAsync(valueSection.Value.GetSectionsRequest(this, ContentSection, metadata).GetSections(IMugenService<IMugenApplication>.Instance, metadata, cancellationToken), metadata, cancellationToken).AsVoidTask();
		}
	}
	public class TextInputSection : TextInputSectionBase<string>
	{
		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(TextInputSection))]
		public TextInputSection(string? text = null, ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			base.Text = text;
		}

		protected override string? GetValue(ref string? value)
		{
			return value;
		}

		protected override string? ToString(string? value)
		{
			return value;
		}
	}
	public abstract class TextInputSectionBase<T> : VisualSectionBase, ITextInputSection, ITextSectionBase, ISupportTextColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportFontStyleSection, ISupportTextSection, IValueInputSection, IHasReadOnlyValue, IValueInputSection<T?>, IHasValue<T?>, IHasReadOnlyValue<T?>
	{
		private string? _text;

		private T? _value;

		private bool _isUserInput;

		public bool IsUserInput
		{
			get
			{
				return _isUserInput;
			}
			protected set
			{
				if (value != _isUserInput)
				{
					_isUserInput = value;
					OnPropertyChanged(CompositeUIExtensions.IsUserInputArgs);
				}
			}
		}

		public T? Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (!EqualityComparer<T>.Default.Equals(_value, value))
				{
					_value = value;
					SetText(ToString(value), isExternal: false);
				}
			}
		}

		public string? Text
		{
			get
			{
				return _text;
			}
			set
			{
				SetText(value, value != null);
			}
		}

		protected TextInputSectionBase(ModifierSet modifiers)
			: base(modifiers)
		{
		}

		public void SetValue(T? valueRaw, bool isUserInput = true)
		{
			Value = valueRaw;
			IsUserInput = isUserInput;
		}

		protected abstract T? GetValue(ref string? value);

		protected abstract string? ToString(T? value);

		protected virtual void SetText(string? value, bool isExternal)
		{
			if (!(_text == value))
			{
				_value = GetValue(ref value);
				_text = value;
				IsUserInput = isExternal;
				OnPropertyChanged(Default.ValueChangedArgs);
				OnPropertyChanged(CompositeUIExtensions.TextArgs);
			}
		}
	}
	public class TextSection : VisualSectionBase, ITextSection, ITextSectionBase, ISupportTextColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportFontStyleSection, ISupportFormattedTextSection
	{
		private FormattedText _text;

		public FormattedText Text
		{
			get
			{
				return _text;
			}
			set
			{
				if (!value.Equals(_text))
				{
					_text = value;
					OnPropertyChanged(CompositeUIExtensions.TextArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(TextSection))]
		public TextSection(FormattedText text = default(FormattedText), ModifierSet modifiers = default(ModifierSet))
			: base(modifiers)
		{
			Text = text;
		}
	}
	public abstract class VisualSectionBase : DisposableBindableModelBase, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		private IShell? _shell;

		private ModifierSet _modifiers;

		public IShell? Shell
		{
			get
			{
				return _shell;
			}
			set
			{
				IShell shell = _shell;
				if (!object.Equals(value, shell))
				{
					OnShellChanging(shell, value);
					_shell = value;
					OnShellChanged(shell, value);
					OnPropertyChanged(CompositeUIExtensions.ShellArgs);
				}
			}
		}

		public ModifierSet Modifiers => _modifiers;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(VisualSectionBase))]
		protected VisualSectionBase(ModifierSet modifiers)
		{
			_modifiers = modifiers;
		}

		public static explicit operator Bindable<IVisualSection>(VisualSectionBase section)
		{
			return Bindable.Constant((IVisualSection)section);
		}

		public bool UpdateModifiers<TState>(ref TState state, ModifierMutator<TState> mutator, ModifierCleanup<TState>? cleanup = null)
		{
			if (_modifiers.Update(this, mutator, cleanup, ref state))
			{
				OnPropertyChanged(CompositeUIExtensions.ModifiersArgs);
				return true;
			}
			return false;
		}

		public void Invalidate()
		{
			OnPropertyChanged(CompositeUIExtensions.ReloadSectionArgs);
		}

		protected virtual void OnShellChanging(IShell? oldValue, IShell? newValue)
		{
		}

		protected virtual void OnShellChanged(IShell? oldValue, IShell? newValue)
		{
		}

		protected override void OnDispose(bool disposing)
		{
			if (disposing)
			{
				_modifiers.OnDispose(this);
			}
			base.OnDispose(disposing);
		}
	}
}
namespace MugenMvvm.CompositeUI.Sections.Visuals.Interfaces
{
	public interface IButtonSection : ISupportFormattedTextSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportTextColorSection, ISupportFontStyleSection, ISupportIconSection
	{
	}
	public interface ICollectionLayoutSection : ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ICollectionLayoutSectionBase, ISupportOrientationSection, ISupportScrollSection
	{
	}
	public interface ICollectionLayoutSectionBase : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportOrientationSection, ISupportScrollSection
	{
	}
	public interface ICompositeLayoutSection : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		bool HasItems { get; }

		IReadOnlyCollection<ISection> Children { get; }
	}
	public interface IContentLayoutSection : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		IVisualSection? Content { get; }
	}
	public interface IEditableCompositeLayoutSection : ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		void Add(IVisualSection section);

		bool Remove(IVisualSection? section);
	}
	public interface IFrameLayoutSection : ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IFrameLayoutSectionBase, ISupportGravitySection, ISupportZOrderSection
	{
	}
	public interface IFrameLayoutSectionBase : ISupportGravitySection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportZOrderSection
	{
	}
	public interface IImageSection : ISupportTintColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportImageStretchModeSection
	{
		ImageSource Source { get; set; }
	}
	public interface IImmutableFrameLayoutSection : IImmutableLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection, IFrameLayoutSectionBase, ISupportGravitySection, ISupportZOrderSection
	{
	}
	public interface IImmutableLayoutSection : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection
	{
		ImmutableArray<IVisualSection> Children { get; }
	}
	public interface IImmutableStackLayoutSection : IImmutableLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IImmutableVisualSection, IStackLayoutSectionBase, ISupportOrientationSection, ISupportAlignmentSection
	{
	}
	public interface IImmutableVisualSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ILayoutSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface INestedCompositeLayoutSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		IReadOnlyCollection<IVisualSection> Children { get; }
	}
	public interface IStackLayoutSection : ICompositeLayoutSection, ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IStackLayoutSectionBase, ISupportOrientationSection, ISupportAlignmentSection
	{
	}
	public interface IStackLayoutSectionBase : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportOrientationSection, ISupportAlignmentSection
	{
	}
	public interface ISupportAlignmentSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportFontStyleSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportFormatSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		string? Format { get; set; }

		CultureInfo? CultureInfo { get; set; }
	}
	public interface ISupportFormattedTextSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		FormattedText Text { get; set; }
	}
	public interface ISupportGravitySection : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportIconSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		ImageSource Icon { get; set; }
	}
	public interface ISupportImageStretchModeSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportMaxValueSection<T> : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback where T : INumber<T>
	{
		T? Max { get; set; }
	}
	public interface ISupportMinValueSection<T> : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback where T : INumber<T>
	{
		T? Min { get; set; }
	}
	public interface ISupportOrientationSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportScrollSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportTextColorSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportTextSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		string? Text { get; set; }
	}
	public interface ISupportThumbTintColorSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportTintColorSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportTrackTintColorSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISupportZOrderSection : ILayoutSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
	}
	public interface ISwitchSection : ISupportTrackTintColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportThumbTintColorSection, IValueInputSection<bool>, IValueInputSection, IHasReadOnlyValue, IHasValue<bool>, IHasReadOnlyValue<bool>
	{
	}
	public interface ITextInputSection : ITextSectionBase, ISupportTextColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportFontStyleSection, ISupportTextSection, IValueInputSection, IHasReadOnlyValue
	{
	}
	public interface ITextSection : ITextSectionBase, ISupportTextColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportFontStyleSection, ISupportFormattedTextSection
	{
	}
	public interface ITextSectionBase : ISupportTextColorSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, ISupportFontStyleSection
	{
	}
	public interface IValueInputSection : IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IHasReadOnlyValue
	{
	}
	public interface IValueInputSection<T> : IValueInputSection, IVisualSection, INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback, IHasReadOnlyValue, IHasValue<T>, IHasReadOnlyValue<T>
	{
	}
	public interface IVisualSection : INotifyPropertyChanged, IShellAwareSection, ISection, IInner<ISection>, IDisposable, IShellAware, IHasDisposeCallback, IHasDisposedState, ISupportDisposeCallback
	{
		ModifierSet Modifiers { get; }

		bool UpdateModifiers<TState>(ref TState state, ModifierMutator<TState> mutator, ModifierCleanup<TState>? cleanup = null);

		void Invalidate();
	}
}
namespace MugenMvvm.CompositeUI.Sections.Renderers
{
	public abstract class SectionModifierRendererBase<TView> : ISectionModifierRenderer<TView>, ISectionModifierRenderer where TView : class
	{
		public virtual void GetLayoutRendererId(object? container, object item, ref ValueSpanBuilder<char> builder, IReadOnlyMetadataContext? metadata)
		{
			builder.AppendCompact(Default.GetIdByType(GetType()));
		}

		public virtual ISectionModifierRenderer<TView>? TryGet(object item, ISectionModifier modifier, IReadOnlyMetadataContext? metadata)
		{
			return this;
		}

		public void Apply(object container, TView view, ref TView hostView, ref TView anchorView, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata)
		{
			if (IsViewSupported(container, view, hostView, anchorView, metadata))
			{
				ApplyCore(container, view, ref hostView, ref anchorView, renderers, metadata);
			}
		}

		protected abstract void ApplyCore(object container, TView view, ref TView hostView, ref TView anchorView, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata);

		protected virtual bool IsViewSupported(object container, TView view, TView hostView, TView anchorView, IReadOnlyMetadataContext? metadata)
		{
			return true;
		}
	}
	public class AlignmentSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Alignment>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindAlignmentTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((object)c).DataContext<IVisualSection>().TryGetModifier<IAlignmentSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class AnimateLayoutChangesSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, bool>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindIsAnimateLayoutChangesTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IAnimateLayoutChangesSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class AttachStateSectionModifierRenderer : SectionModifierRendererBase
	{
		private sealed class AttachStateListener : Object, IBoolValueChangedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			private bool _isAttached;

			private WeakRef<IAttachStateSectionModifier> _modifier;

			public IAttachStateSectionModifier? Modifier
			{
				get
				{
					return _modifier.Target;
				}
				set
				{
					IAttachStateSectionModifier modifier = Modifier;
					if (value != modifier)
					{
						modifier?.OnChanged(value: false);
						_modifier = value.ToWeakReference();
						value?.OnChanged(_isAttached);
					}
				}
			}

			public void OnChanged(bool isAttached)
			{
				if (isAttached != _isAttached)
				{
					_isAttached = isAttached;
					Modifier?.OnChanged(isAttached);
				}
			}
		}

		private static Expression<Func<View, IAttachStateSectionModifier?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			AttachStateListener attachStateListener = new AttachStateListener();
			NativeBindableMemberMugenExtensions.AddAttachStateListener(hostView, attachStateListener);
			attachStateListener.BindTarget().ToAction<AttachStateListener, AttachStateListener, IAttachStateSectionModifier>(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IAttachStateSectionModifier>())), delegate(AttachStateListener v, IAttachStateSectionModifier m)
			{
				v.Modifier = m;
			});
		}
	}
	public class BackgroundColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindBackgroundColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IBackgroundColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class BorderColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindStrokeColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IBorderColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class BorderWidthSectionModifierRenderer : SectionModifierRendererBase, IMaterialImageRequiredRenderer, ISectionModifierRenderer
	{
		private static Expression<Func<View, float>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindStrokeWidthTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IBorderWidthSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class ClipToPaddingSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, bool>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindClipToPaddingTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IClipToPaddingSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class CornerRadiusSectionModifierRenderer : SectionModifierRendererBase, IMaterialImageRequiredRenderer, ISectionModifierRenderer
	{
		private static Expression<Func<View, CornerRadius>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindCornerRadiiTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ICornerRadiusSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class CursorColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindCursorColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((object)c).DataContext<IVisualSection>().TryGetModifier<ICursorColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class ElevationSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, float>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindElevationTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IElevationSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class EnableSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, bool>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			ObjectInternalBindableMembers.BindEnabledTarget<View>(anchorView).To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((object)c).DataContext<IVisualSection>().TryGetModifier<IEnabledSectionModifier>().Value)), (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
			{
				c.TwoWayToSource();
			}, (IReadOnlyMetadataContext?)null);
		}
	}
	public class FocusSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, bool>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindIsFocusedTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IFocusSectionModifier>().Value)), (Action<IBindingBuilderContext>?)delegate(IBindingBuilderContext c)
			{
				c.TwoWayToSource();
			}, (IReadOnlyMetadataContext?)null);
		}
	}
	public class FontSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, FontSpec>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindFontSpecTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IFontSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class GravitySectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, EnumFlags<GravityFlags>>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			View target = (View)container;
			view.BindTarget<View>().ToAction<View, View, View, EnumFlags<GravityFlags>>(target.Bind<View>(), hostView.B(_bindCache1 ?? (_bindCache1 = (View v) => ((Object)v).DataContext<IVisualSection>().TryGetModifier<IGravitySectionModifier>().Value)), delegate(View c, View p, EnumFlags<GravityFlags> g)
			{
				//IL_0003: Unknown result type (might be due to invalid IL or missing references)
				//IL_0023: Expected I4, but got Unknown
				NativeBindableMemberMugenExtensions.SetLayoutGravity(p, c, (int)g.ToNative(), g.HasFlag(GravityFlags.FillHorizontal), g.HasFlag(GravityFlags.FillVertical));
			}, null, distinct: true);
		}

		protected override bool IsViewSupported(object container, View view, View hostView, View anchorView, IReadOnlyMetadataContext? metadata)
		{
			View val = (View)((container is View) ? container : null);
			if (val != null)
			{
				return NativeBindableMemberMugenExtensions.IsChildLayoutGravitySupported(val);
			}
			return false;
		}
	}
	public class ImageStretchModeSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, ImageStretchMode>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindStretchModeTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IImageStretchModeSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class KeyboardTypeSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, KeyboardType>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindKeyboardTypeTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IKeyboardTypeSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class LoadMoreSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, object?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindLoadMore<View>().ToCommand(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ILoadMoreSectionModifier>().Command)), (IBinding _, View v, IReadOnlyMetadataContext? _) => (((Object)(object)v).DataContext() as IVisualSection)?.TryGetModifier<ILoadMoreSectionModifier>()?.Parameter);
		}
	}
	public class MarginSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Thickness>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView.BindMarginTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View v) => ((Object)v).DataContext<IVisualSection>().TryGetModifier<IMarginSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class MaxLinesSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, int>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindMaxLinesTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IMaxLinesSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class NativeViewSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, NativeViewSectionModifier?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView.BindTarget<View>().ToAction<View, View, NativeViewSectionModifier>(hostView.B(_bindCache1 ?? (_bindCache1 = (View v) => ((Object)v).DataContext<IVisualSection>().TryGetModifier<NativeViewSectionModifier>())), delegate(View v, NativeViewSectionModifier s)
			{
				if (s != null)
				{
					s.Value = v;
				}
			});
		}
	}
	public class OrientationSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, OrientationType>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindOrientationTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IOrientationSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class PaddingSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Thickness>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView.BindPaddingTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View v) => ((Object)v).DataContext<IVisualSection>().TryGetModifier<IPaddingSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class PlaceholderColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindPlaceholderTextColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IPlaceholderColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class PlaceholderSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, FormattedText>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindPlaceholderTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IPlaceholderSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class PressedSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, IPressedSectionModifier?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindPressedTarget<View>().ToAction<View, bool, IPressedSectionModifier>(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IPressedSectionModifier>())), delegate(bool v, IPressedSectionModifier m)
			{
				m?.OnChanged(v);
			});
		}
	}
	public class RefreshSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, object?>>? _bindCache1;

		private static Expression<Func<View, bool>>? _bindCache2;

		private static Expression<Func<View, Optional<bool>>>? _bindCache3;

		private static Expression<Func<View, bool>>? _bindCache4;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView = NativeBindableMemberMugenExtensions.WrapToRefreshView(view);
			View target = hostView;
			ViewBaseBindableMembers.BindEnabledTarget<View>(hostView.BindRefreshed<View>().ToCommand(target.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IRefreshSectionModifier>().Command)), (IBinding _, View v, IReadOnlyMetadataContext? _) => (((Object)(object)v).DataContext() as IVisualSection)?.TryGetModifier<IRefreshSectionModifier>()?.Parameter)).To(target.B(_bindCache2 ?? (_bindCache2 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IRefreshSectionModifier>().Command.CanExecute())), target.B(_bindCache3 ?? (_bindCache3 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IRefreshSectionModifier>().Command.As<ICompositeCommand>().IsExecuting().AsOptional())), (bool canExecute, Optional<bool> isExecuting) => canExecute || isExecuting.GetValueOrDefault(defaultValue: true), null, distinct: false, null).BindRefreshingTarget<View>()
				.To(target.B(_bindCache4 ?? (_bindCache4 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IRefreshSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class ResetScrollSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, int>>? _bindCache1;

		private static Expression<Func<View, bool>>? _bindCache2;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindTarget<View>().ToAction(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ResetScrollSectionModifier>().Value)), hostView.B(_bindCache2 ?? (_bindCache2 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ResetScrollSectionModifier>().Animate)), delegate(View v, int _, bool a)
			{
				NativeBindableMemberMugenExtensions.ResetScroll(v, a);
			});
		}
	}
	public abstract class SectionModifierRendererBase : SectionModifierRendererBase<View>
	{
	}
	public class SizeLimitsSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, SizeLimits>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView = NativeBindableMemberMugenExtensions.WrapToMaxSizeLayout(hostView);
			hostView.BindTarget<View>().ToAction(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((object)c).DataContext<IVisualSection>().TryGetModifier<ISizeLimitsSectionModifier>().Value)), delegate(View v, SizeLimits s)
			{
				NativeBindableMemberMugenExtensions.SetMaxSize(v, s.MaxWidth ?? 2.1474836E+09f, s.MaxHeight ?? 2.1474836E+09f);
			}, null, distinct: true);
			hostView.BindTarget<View>().ToAction(hostView.B(_bindCache1), delegate(View v, SizeLimits s)
			{
				NativeBindableMemberMugenExtensions.SetMinSize(v, s.MinWidth ?? (-2.1474836E+09f), s.MinHeight ?? (-2.1474836E+09f));
			}, null, distinct: true);
		}
	}
	public class SizeSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, SizeF>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindTarget<View>().ToAction(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ISizeSectionModifier>().Value)), delegate(View v, SizeF f)
			{
				NativeBindableMemberMugenExtensions.SetSize(v, f.Width, f.Height);
			}, null, distinct: true);
		}
	}
	public class StretchSectionModifierRenderer : SectionModifierRendererBase
	{
		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			NativeBindableMemberMugenExtensions.SetWeight(hostView, 1f);
		}
	}
	public class TapSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, object?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			BindClick(anchorView);
		}

		private static void BindClick(View view)
		{
			ViewBaseBindableMembers.BindClick<View>(view).ToCommand(view.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITapSectionModifier>().Command)), (IBinding _, View v, IReadOnlyMetadataContext? _) => (((Object)(object)v).DataContext() as IVisualSection)?.TryGetModifier<ITapSectionModifier>()?.Parameter, null, delegate(IBindingBuilderContext c)
			{
				c.ToggleEnabled();
			});
		}
	}
	public class TapThroughSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, object?>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			BindClick(anchorView);
		}

		private static void BindClick(View view)
		{
			view.BindClickThrough<View>().ToCommand(view.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITapThroughSectionModifier>().Command)), (IBinding _, View v, IReadOnlyMetadataContext? _) => (((Object)(object)v).DataContext() as IVisualSection)?.TryGetModifier<ITapThroughSectionModifier>()?.Parameter);
		}
	}
	public class TextAlignmentSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, TextAlignment>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindTextAlignmentTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITextAlignmentSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class TextColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			anchorView.BindTextColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITextColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class ThumbTintColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindThumbTintColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IThumbTintColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class TintColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindTintColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITintColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class TrackTintColorSectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, Color>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			view.BindTrackTintColorTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<ITrackTintColorSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class VisibilitySectionModifierRenderer : SectionModifierRendererBase
	{
		private static Expression<Func<View, SectionVisibility>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			CompositeUIViewBaseBindableMembers.BindVisibilityTarget<View>(hostView).To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IVisibilitySectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
	public class ZIndexSectionModifierRenderer : SectionModifierRendererBase, IMaterialImageRequiredRenderer, ISectionModifierRenderer
	{
		private static Expression<Func<View, float>>? _bindCache1;

		protected override void ApplyCore(object container, View view, ref View hostView, ref View anchorView, ImmutableArray<ISectionModifierRenderer<View>> renderers, IReadOnlyMetadataContext? metadata)
		{
			hostView.BindZIndexTarget<View>().To(hostView.B(_bindCache1 ?? (_bindCache1 = (View c) => ((Object)c).DataContext<IVisualSection>().TryGetModifier<IZIndexSectionModifier>().Value)), (Action<IBindingBuilderContext>?)null, (IReadOnlyMetadataContext?)null);
		}
	}
}
namespace MugenMvvm.CompositeUI.Sections.Renderers.Interfaces
{
	public interface IAttachableSectionModifierRenderer<TView> : ISectionModifierRenderer<TView>, ISectionModifierRenderer where TView : class
	{
		void OnAttached(object container, TView view, IReadOnlyMetadataContext? metadata);

		void OnDetached(object container, TView view, IReadOnlyMetadataContext? metadata);
	}
	public interface IDataContextAwareSectionModifierRenderer<TView> : ISectionModifierRenderer<TView>, ISectionModifierRenderer where TView : class
	{
		void OnDataContextChanged(object container, TView view, object? oldDataContext, object? newDataContext, IReadOnlyMetadataContext? metadata);
	}
	public interface IHasPrioritySectionModifierRenderer : ISectionModifierRenderer, IHasPriority
	{
	}
	public interface ISectionModifierRenderer
	{
		void GetLayoutRendererId(object? container, object item, ref ValueSpanBuilder<char> builder, IReadOnlyMetadataContext? metadata);
	}
	public interface ISectionModifierRenderer<TView> : ISectionModifierRenderer where TView : class
	{
		ISectionModifierRenderer<TView>? TryGet(object item, ISectionModifier modifier, IReadOnlyMetadataContext? metadata);

		void Apply(object container, TView view, ref TView hostView, ref TView anchorView, ImmutableArray<ISectionModifierRenderer<TView>> renderers, IReadOnlyMetadataContext? metadata);
	}
	public interface ITemplateProviderSectionModifierRenderer : ISectionModifierRenderer
	{
	}
	public interface ITemplateProviderSectionModifierRenderer<TTemplate> : ITemplateProviderSectionModifierRenderer, ISectionModifierRenderer
	{
		bool TrySelectTemplate(object container, object? item, IReadOnlyMetadataContext? metadata, [NotNullWhen(true)] out TTemplate? template);
	}
	public interface IMaterialImageRequiredRenderer : ISectionModifierRenderer
	{
	}
}
namespace MugenMvvm.CompositeUI.Sections.Modifiers
{
	public sealed class AlignmentImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<AlignmentImmutableSectionModifier, IAlignmentSectionModifier, byte, Alignment>, IAlignmentSectionModifier, IReadOnlyValueSectionModifier<Alignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Alignment>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Alignment, byte>, IImmutableValueSectionModifier<Alignment>
	{
		public override int Priority => 4600;

		public static byte GetKey(Alignment? value)
		{
			Should.NotBeNull(value, "value");
			return value.Value;
		}
	}
	public sealed class AlignmentSectionModifier : EnumValueSectionModifierBase<IAlignmentSectionModifier, Alignment, byte>, IAlignmentSectionModifier, IReadOnlyValueSectionModifier<Alignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Alignment>, IHasReadOnlyValue
	{
		public override int Priority => 4600;

		protected override Alignment DefaultValue => Alignment.Start;
	}
	public class AnimateLayoutChangesImmutableSectionModifier : CacheableBoolImmutableSectionModifierBase<AnimateLayoutChangesImmutableSectionModifier, IAnimateLayoutChangesSectionModifier>, IAnimateLayoutChangesSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		public override int Priority => 700;
	}
	public class AnimateLayoutChangesSectionModifier : ValueSectionModifierBase<IAnimateLayoutChangesSectionModifier, bool>, IAnimateLayoutChangesSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		public override int Priority => 700;
	}
	public sealed class AttachStateSectionModifier : SectionModifierBase<IAttachStateSectionModifier>, IAttachStateSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		private bool _value;

		public override int Priority => 800;

		public bool Value
		{
			get
			{
				return _value;
			}
			private set
			{
				if (value != _value)
				{
					_value = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(AttachStateSectionModifier))]
		public AttachStateSectionModifier()
		{
		}

		void IAttachStateSectionModifier.OnChanged(bool value)
		{
			Value = value;
		}
	}
	public sealed class BackgroundColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<BackgroundColorImmutableSectionModifier, IBackgroundColorSectionModifier, int, Color>, IBackgroundColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 980;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class BackgroundColorSectionModifier : ValueSectionModifierBase<IBackgroundColorSectionModifier, Color>, IBackgroundColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 980;
	}
	public sealed class BorderColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<BorderColorImmutableSectionModifier, IBorderColorSectionModifier, int, Color>, IBorderColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 1000;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class BorderColorSectionModifier : ValueSectionModifierBase<IBorderColorSectionModifier, Color>, IBorderColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 1000;
	}
	public sealed class BorderWidthImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<BorderWidthImmutableSectionModifier, IBorderWidthSectionModifier, float, float>, IBorderWidthSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<float, float>, IImmutableValueSectionModifier<float>
	{
		public override int Priority => 1000;

		public static float GetKey(float value)
		{
			return value;
		}
	}
	public sealed class BorderWidthSectionModifier : ValueSectionModifierBase<IBorderWidthSectionModifier, float>, IBorderWidthSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
		public override int Priority => 1000;
	}
	public abstract class CacheableBoolImmutableSectionModifierBase<TSelf, TModifierBase> : ValueImmutableSectionModifierBase<IClipToPaddingSectionModifier, bool>, IImmutableValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue where TSelf : CacheableBoolImmutableSectionModifierBase<TSelf, TModifierBase>, TModifierBase, IImmutableValueSectionModifier<bool>, new() where TModifierBase : class, ISectionModifier
	{
		public static readonly TSelf True = new TSelf
		{
			Value = true
		};

		public static readonly TSelf False = new TSelf
		{
			Value = false
		};

		public static IImmutableValueSectionModifier<bool> Get(bool value)
		{
			return value ? True : False;
		}
	}
	public abstract class CacheableValueImmutableSectionModifierBase<TSelf, TModifierBase, TKey, TValue> : ValueImmutableSectionModifierBase<TModifierBase, TValue>, IImmutableValueSectionModifier<TValue>, IReadOnlyValueSectionModifier<TValue>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TValue>, IHasReadOnlyValue where TSelf : CacheableValueImmutableSectionModifierBase<TSelf, TModifierBase, TKey, TValue>, TModifierBase, ICacheableImmutableValueSectionModifier<TValue, TKey>, new() where TModifierBase : class, ISectionModifier where TKey : IEquatable<TKey>
	{
		private static readonly Lock Locker = new Lock();

		private static DictionarySlim<TKey, object> _cache = new DictionarySlim<TKey, object>(11);

		public static IImmutableValueSectionModifier<TValue> Get(TValue? value)
		{
			using (Locker.EnterScope())
			{
				ref object orAddValueRef = ref _cache.GetOrAddValueRef(TSelf.GetKey(value));
				return (IImmutableValueSectionModifier<TValue>)(orAddValueRef ?? (orAddValueRef = new TSelf
				{
					Value = value
				}));
			}
		}
	}
	public class ClipToPaddingImmutableSectionModifier : CacheableBoolImmutableSectionModifierBase<ClipToPaddingImmutableSectionModifier, IClipToPaddingSectionModifier>, IClipToPaddingSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		public override int Priority => 920;
	}
	public class ClipToPaddingSectionModifier : ValueSectionModifierBase<IClipToPaddingSectionModifier, bool>, IClipToPaddingSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		public override int Priority => 920;
	}
	public abstract class CommandImmutableSectionModifier<TSelf> : ImmutableSectionModifierBase<TSelf>, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName where TSelf : class, ICommandSectionModifier
	{
		public override int Priority => 500;

		public ICommand Command { get; }

		public object? Parameter { get; }

		public CommandImmutableSectionModifier(ICommand command, object? parameter)
		{
			Should.NotBeNull(command, "command");
			Command = command;
			Parameter = parameter;
		}
	}
	public abstract class CommandSectionModifierBase<TModifierBase> : SectionModifierBase<TModifierBase>, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IFastBindableListener<ICommand?>, IBindableListener<ICommand?>, IBindableListener, IObserver<ICommand?>, IEventListener, IWeakItem, IMemberPathObserverListener where TModifierBase : class, ICommandSectionModifier
	{
		private ICommand? _command;

		private object? _parameter;

		public ICommand? Command
		{
			get
			{
				return _command;
			}
			set
			{
				if (!object.Equals(value, _command))
				{
					_command = value;
					OnPropertyChanged(CompositeUIExtensions.CommandArgs);
				}
			}
		}

		public object? Parameter
		{
			get
			{
				return _parameter;
			}
			set
			{
				if (!object.Equals(value, _parameter))
				{
					_parameter = value;
					OnPropertyChanged(CompositeUIExtensions.ParameterArgs);
				}
			}
		}

		public override int Priority => 500;

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(CommandSectionModifierBase<>))]
		public CommandSectionModifierBase()
		{
		}

		void IBindableListener.OnError(Exception error, BindableErrorType errorType)
		{
			IMugenService<IMugenApplication>.Instance.OnUnhandledException(error, errorType.UnhandledExceptionType, this);
		}

		void IBindableListener.OnBeginExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener.OnEndExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener<ICommand>.OnValue(ICommand? value)
		{
			Command = value;
		}
	}
	public sealed class CornerRadiusImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<CornerRadiusImmutableSectionModifier, ICornerRadiusSectionModifier, CornerRadius, CornerRadius>, ICornerRadiusSectionModifier, IReadOnlyValueSectionModifier<CornerRadius>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<CornerRadius>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<CornerRadius, CornerRadius>, IImmutableValueSectionModifier<CornerRadius>
	{
		public override int Priority => 990;

		public static CornerRadius GetKey(CornerRadius value)
		{
			return value;
		}
	}
	public sealed class CornerRadiusSectionModifier : ValueSectionModifierBase<ICornerRadiusSectionModifier, CornerRadius>, ICornerRadiusSectionModifier, IReadOnlyValueSectionModifier<CornerRadius>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<CornerRadius>, IHasReadOnlyValue
	{
		public override int Priority => 990;
	}
	public sealed class CursorColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<CursorColorImmutableSectionModifier, ICursorColorSectionModifier, int, Color>, ICursorColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 930;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class CursorColorSectionModifier : ValueSectionModifierBase<ICursorColorSectionModifier, Color>, ICursorColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 930;
	}
	public sealed class ElevationImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<ElevationImmutableSectionModifier, IElevationSectionModifier, float, float>, IElevationSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<float, float>, IImmutableValueSectionModifier<float>
	{
		public override int Priority => 950;

		public static float GetKey(float value)
		{
			return value;
		}
	}
	public sealed class ElevationSectionModifier : ValueSectionModifierBase<IElevationSectionModifier, float>, IElevationSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
		public override int Priority => 950;
	}
	public sealed class EnableSectionModifier : ValueSectionModifierBase<IEnabledSectionModifier, bool>, IEnabledSectionModifier, IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
		public override int Priority => 800;
	}
	[UnconditionalSuppressMessage("Trimming", "IL2091")]
	public abstract class EnumValueSectionModifierBase<TModifierBase, TEnum, TValue> : SectionModifierBase<TModifierBase>, IValueSectionModifier<TEnum>, IReadOnlyValueSectionModifier<TEnum>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TEnum>, IHasReadOnlyValue, IHasValue<TEnum>, IFastBindableListener<TEnum>, IBindableListener<TEnum>, IBindableListener, IObserver<TEnum>, IEventListener, IWeakItem, IMemberPathObserverListener where TModifierBase : class, ISectionModifier where TEnum : EnumBase<TEnum, TValue> where TValue : struct, IComparable<TValue>, IEquatable<TValue>
	{
		private TEnum? _value;

		public TEnum Value
		{
			get
			{
				return _value ?? DefaultValue;
			}
			[param: AllowNull]
			set
			{
				if (!EqualityComparer<TEnum>.Default.Equals(_value, value))
				{
					_value = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		protected abstract TEnum DefaultValue { get; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(EnumValueSectionModifierBase<, , >))]
		protected EnumValueSectionModifierBase()
		{
		}

		void IBindableListener<TEnum>.OnValue(TEnum value)
		{
			Value = value;
		}

		void IBindableListener.OnError(Exception error, BindableErrorType errorType)
		{
			IMugenService<IMugenApplication>.Instance.OnUnhandledException(error, errorType.UnhandledExceptionType, this);
		}

		void IBindableListener.OnBeginExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener.OnEndExecuting(object source, BindableExecutionKind kind)
		{
		}
	}
	public sealed class FocusSectionModifier : ValueSectionModifierBase<IFocusSectionModifier, bool>, IFocusSectionModifier, IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
		public override int Priority => 800;
	}
	public sealed class FontImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<FontImmutableSectionModifier, IFontSectionModifier, FontSpec, FontSpec>, IFontSectionModifier, IReadOnlyValueSectionModifier<FontSpec>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FontSpec>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<FontSpec, FontSpec>, IImmutableValueSectionModifier<FontSpec>
	{
		public override int Priority => 4700;

		public static FontSpec GetKey(FontSpec value)
		{
			return value;
		}
	}
	public sealed class FontSectionModifier : ValueSectionModifierBase<IFontSectionModifier, FontSpec>, IFontSectionModifier, IReadOnlyValueSectionModifier<FontSpec>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FontSpec>, IHasReadOnlyValue
	{
		public override int Priority => 4700;
	}
	public sealed class GravityImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<GravityImmutableSectionModifier, IGravitySectionModifier, EnumFlags<GravityFlags>, EnumFlags<GravityFlags>>, IGravitySectionModifier, IReadOnlyValueSectionModifier<EnumFlags<GravityFlags>>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<EnumFlags<GravityFlags>>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<EnumFlags<GravityFlags>, EnumFlags<GravityFlags>>, IImmutableValueSectionModifier<EnumFlags<GravityFlags>>
	{
		public override int Priority => 8000;

		public static EnumFlags<GravityFlags> GetKey(EnumFlags<GravityFlags> value)
		{
			return value;
		}
	}
	public sealed class GravitySectionModifier : ValueSectionModifierBase<IGravitySectionModifier, EnumFlags<GravityFlags>>, IGravitySectionModifier, IReadOnlyValueSectionModifier<EnumFlags<GravityFlags>>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<EnumFlags<GravityFlags>>, IHasReadOnlyValue
	{
		public override int Priority => 8000;
	}
	public sealed class ImageStretchModeImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<ImageStretchModeImmutableSectionModifier, IImageStretchModeSectionModifier, byte, ImageStretchMode>, IImageStretchModeSectionModifier, IReadOnlyValueSectionModifier<ImageStretchMode>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<ImageStretchMode>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<ImageStretchMode, byte>, IImmutableValueSectionModifier<ImageStretchMode>
	{
		public override int Priority => 7700;

		public static byte GetKey(ImageStretchMode? value)
		{
			Should.NotBeNull(value, "value");
			return value.Value;
		}
	}
	public sealed class ImageStretchModeSectionModifier : EnumValueSectionModifierBase<IImageStretchModeSectionModifier, ImageStretchMode, byte>, IImageStretchModeSectionModifier, IReadOnlyValueSectionModifier<ImageStretchMode>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<ImageStretchMode>, IHasReadOnlyValue
	{
		public override int Priority => 7700;

		protected override ImageStretchMode DefaultValue => ImageStretchMode.AspectFit;
	}
	public abstract class ImmutableSectionModifierBase<TSelf> : ISectionModifier, IHasPriority, IHasId<int>, IHasName where TSelf : class, ISectionModifier
	{
		public abstract int Priority { get; }

		public virtual int Id => Default.GetIdByType(typeof(TSelf));

		public virtual string Name => typeof(TSelf).Name;

		public virtual EnumFlags<SectionModifierFlags> Flags => (FlagsEnumBase<SectionModifierFlags, int>?)SectionModifierFlags.Immutable;

		public virtual ISectionModifierRenderer<TView>? TryGetRenderer<TView>(object item, IReadOnlyMetadataContext? metadata) where TView : class
		{
			return ((ISectionModifierRenderer<TView>)IMugenService<IMugenApplication>.Instance.TryInvoke<IMugenApplication, GetSectionModifierRendererRequest, ISectionModifierRenderer>(new GetSectionModifierRendererRequest(item, this, typeof(TSelf), typeof(TView)), metadata))?.TryGet(item, this, metadata);
		}
	}
	public sealed class KeyboardTypeImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<KeyboardTypeImmutableSectionModifier, IKeyboardTypeSectionModifier, byte, KeyboardType>, IKeyboardTypeSectionModifier, IReadOnlyValueSectionModifier<KeyboardType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<KeyboardType>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<KeyboardType, byte>, IImmutableValueSectionModifier<KeyboardType>
	{
		public override int Priority => 950;

		public static byte GetKey(KeyboardType? value)
		{
			Should.NotBeNull(value, "value");
			return value.Value;
		}
	}
	public sealed class KeyboardTypeSectionModifier : EnumValueSectionModifierBase<IKeyboardTypeSectionModifier, KeyboardType, byte>, IKeyboardTypeSectionModifier, IReadOnlyValueSectionModifier<KeyboardType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<KeyboardType>, IHasReadOnlyValue
	{
		public override int Priority => 950;

		protected override KeyboardType DefaultValue => KeyboardType.Default;
	}
	public sealed class LoadMoreImmutableSectionModifier : CommandImmutableSectionModifier<ILoadMoreSectionModifier>, ILoadMoreSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IImmutableCommandSectionModifier
	{
		public LoadMoreImmutableSectionModifier(ICommand command, object? parameter)
			: base(command, parameter)
		{
		}

		public static IImmutableCommandSectionModifier Get(ICompositeCommand command, object? parameter)
		{
			return new LoadMoreImmutableSectionModifier(command, parameter);
		}
	}
	public sealed class LoadMoreSectionModifier : CommandSectionModifierBase<ILoadMoreSectionModifier>, ILoadMoreSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public sealed class MarginImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<MarginImmutableSectionModifier, IMarginSectionModifier, Thickness, Thickness>, IMarginSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Thickness, Thickness>, IImmutableValueSectionModifier<Thickness>
	{
		public override int Priority => 9000;

		public static Thickness GetKey(Thickness value)
		{
			return value;
		}
	}
	public sealed class MarginSectionModifier : ValueSectionModifierBase<IMarginSectionModifier, Thickness>, IMarginSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
		public override int Priority => 9000;
	}
	public abstract class MarginWrapperSectionModifierBase : ValueWrapperSectionModifierBase<IMarginSectionModifier, Thickness>, IMarginSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
		public override int Priority => 9001;
	}
	public sealed class MaxLinesImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<MaxLinesImmutableSectionModifier, IMaxLinesSectionModifier, int, int>, IMaxLinesSectionModifier, IReadOnlyValueSectionModifier<int>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<int>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<int, int>, IImmutableValueSectionModifier<int>
	{
		public override int Priority => 7800;

		public static int GetKey(int value)
		{
			return value;
		}
	}
	public sealed class MaxLinesSectionModifier : ValueSectionModifierBase<IMaxLinesSectionModifier, int>, IMaxLinesSectionModifier, IReadOnlyValueSectionModifier<int>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<int>, IHasReadOnlyValue
	{
		public override int Priority => 7800;
	}
	public sealed class NativeViewSectionModifier : SectionModifierBase<NativeViewSectionModifier>, IHasValue<object?>, IHasReadOnlyValue<object?>, IHasReadOnlyValue
	{
		private IWeakReference? _view;

		public override int Priority { get; }

		public object? Value
		{
			get
			{
				return _view?.Target;
			}
			set
			{
				if (!object.Equals(value, _view?.Target))
				{
					_view = value.ToWeakReferenceRaw();
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		public NativeViewSectionModifier()
			: this(-100000)
		{
		}

		public NativeViewSectionModifier(int priority)
		{
			Priority = priority;
		}
	}
	public sealed class OrientationImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<OrientationImmutableSectionModifier, IOrientationSectionModifier, byte, OrientationType>, IOrientationSectionModifier, IReadOnlyValueSectionModifier<OrientationType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<OrientationType>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<OrientationType, byte>, IImmutableValueSectionModifier<OrientationType>
	{
		public override int Priority => 4800;

		public static byte GetKey(OrientationType? value)
		{
			Should.NotBeNull(value, "value");
			return value.Value;
		}
	}
	public sealed class OrientationSectionModifier : EnumValueSectionModifierBase<IOrientationSectionModifier, OrientationType, byte>, IOrientationSectionModifier, IReadOnlyValueSectionModifier<OrientationType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<OrientationType>, IHasReadOnlyValue
	{
		public override int Priority => 4800;

		protected override OrientationType DefaultValue => OrientationType.Horizontal;
	}
	public sealed class PaddingImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<PaddingImmutableSectionModifier, IPaddingSectionModifier, Thickness, Thickness>, IPaddingSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Thickness, Thickness>, IImmutableValueSectionModifier<Thickness>
	{
		public override int Priority => 10000;

		public static Thickness GetKey(Thickness value)
		{
			return value;
		}
	}
	public sealed class PaddingSectionModifier : ValueSectionModifierBase<IPaddingSectionModifier, Thickness>, IPaddingSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
		public override int Priority => 10000;
	}
	public abstract class PaddingWrapperSectionModifierBase : ValueWrapperSectionModifierBase<IPaddingSectionModifier, Thickness>, IPaddingSectionModifier, IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
		public override int Priority => 10001;
	}
	public sealed class PlaceholderColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<PlaceholderColorImmutableSectionModifier, IPlaceholderColorSectionModifier, int, Color>, IPlaceholderColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 940;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class PlaceholderColorSectionModifier : ValueSectionModifierBase<IPlaceholderColorSectionModifier, Color>, IPlaceholderColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 940;
	}
	public sealed class PlaceholderImmutableSectionModifier : ValueImmutableSectionModifierBase<IPlaceholderSectionModifier, FormattedText>, IPlaceholderSectionModifier, IReadOnlyValueSectionModifier<FormattedText>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FormattedText>, IHasReadOnlyValue, IImmutableValueSectionModifier<FormattedText>
	{
		public override int Priority => 8900;

		public PlaceholderImmutableSectionModifier(FormattedText placeholder)
		{
			base.Value = placeholder;
		}

		public static IImmutableValueSectionModifier<FormattedText> Get(FormattedText value)
		{
			return new PlaceholderImmutableSectionModifier(value);
		}
	}
	public sealed class PlaceholderSectionModifier : ValueSectionModifierBase<IPlaceholderSectionModifier, FormattedText>, IPlaceholderSectionModifier, IReadOnlyValueSectionModifier<FormattedText>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FormattedText>, IHasReadOnlyValue
	{
		public override int Priority => 8900;
	}
	public sealed class PressedSectionModifier : SectionModifierBase<IPressedSectionModifier>, IPressedSectionModifier, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		private bool _isPressed;

		public override int Priority => 810;

		public bool Value
		{
			get
			{
				return _isPressed;
			}
			private set
			{
				if (value != _isPressed)
				{
					_isPressed = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(PressedSectionModifier))]
		public PressedSectionModifier()
		{
		}

		void IPressedSectionModifier.OnChanged(bool value)
		{
			Value = value;
		}
	}
	public sealed class PriorityImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<PriorityImmutableSectionModifier, IPrioritySectionModifier, int, int>, IPrioritySectionModifier, IMarkerSectionModifier<IPrioritySectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IReadOnlyValueSectionModifier<int>, IHasReadOnlyValue<int>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<int, int>, IImmutableValueSectionModifier<int>
	{
		public override int Priority => 0;

		public override EnumFlags<SectionModifierFlags> Flags => SectionModifierFlags.Immutable | SectionModifierFlags.Marker;

		public static int GetKey(int value)
		{
			return value;
		}
	}
	public sealed class RefreshSectionModifier : CommandSectionModifierBase<IRefreshSectionModifier>, IRefreshSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
		private bool _value;

		public override int Priority => 9900;

		public bool Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (value != _value)
				{
					_value = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(RefreshSectionModifier))]
		public RefreshSectionModifier()
		{
		}
	}
	public sealed class ResetScrollSectionModifier : ValueSectionModifierBase<ResetScrollSectionModifier, int>
	{
		private bool _animate;

		public override int Priority => 100;

		public bool Animate
		{
			get
			{
				return _animate;
			}
			set
			{
				if (value != _animate)
				{
					_animate = value;
					OnPropertyChanged(CompositeUIExtensions.AnimateArgs);
				}
			}
		}
	}
	public abstract class SectionModifierBase<TModifierBase> : DisposableBindableModelBase, IAttachableSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName where TModifierBase : class, ISectionModifier
	{
		public abstract int Priority { get; }

		public virtual int Id => Default.GetIdByType(typeof(TModifierBase));

		public virtual string Name => typeof(TModifierBase).Name;

		public virtual EnumFlags<SectionModifierFlags> Flags => default(EnumFlags<SectionModifierFlags>);

		public virtual void OnAttached(IVisualSection section)
		{
			if (base.IsDisposed)
			{
				ExceptionManager.ThrowObjectDisposed(this);
			}
		}

		public virtual void OnDetached(IVisualSection section)
		{
			Dispose();
		}

		public virtual ISectionModifierRenderer<TView>? TryGetRenderer<TView>(object item, IReadOnlyMetadataContext? metadata) where TView : class
		{
			return ((ISectionModifierRenderer<TView>)IMugenService<IMugenApplication>.Instance.TryInvoke<IMugenApplication, GetSectionModifierRendererRequest, ISectionModifierRenderer>(new GetSectionModifierRendererRequest(item, this, typeof(TModifierBase), typeof(TView)), metadata))?.TryGet(item, this, metadata);
		}
	}
	public static class SectionModifierPriority
	{
		public const int Step = 10;

		public const int SmallStep = 1;

		public const int PreInitializer = 100000;

		public const int Padding = 10000;

		public const int RefreshWrapper = 9900;

		public const int SizeLimits = 9800;

		public const int SizeBox = 9700;

		public const int Margin = 9000;

		public const int Placeholder = 8900;

		public const int Gravity = 8000;

		public const int Stretch = 7900;

		public const int MaxLines = 7800;

		public const int StretchMode = 7700;

		public const int Visibility = 5000;

		public const int TextAlignment = 4900;

		public const int Orientation = 4800;

		public const int Font = 4700;

		public const int Alignment = 4600;

		public const int Border = 1000;

		public const int CornerRadius = 990;

		public const int Background = 980;

		public const int TextColor = 970;

		public const int TintColor = 960;

		public const int Elevation = 950;

		public const int KeyboardType = 950;

		public const int PlaceholderColor = 940;

		public const int CursorColor = 930;

		public const int ClipToPadding = 920;

		public const int ZIndex = 900;

		public const int PressedTracking = 810;

		public const int StateTracking = 800;

		public const int Animations = 700;

		public const int Command = 500;

		public const int Action = 100;

		public const int PostInitializer = -100000;
	}
	public sealed class SizeImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<SizeImmutableSectionModifier, ISizeSectionModifier, long, SizeF>, ISizeSectionModifier, IReadOnlyValueSectionModifier<SizeF>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeF>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<SizeF, long>, IImmutableValueSectionModifier<SizeF>
	{
		public override int Priority => 9700;

		public static long GetKey(SizeF value)
		{
			global::DecompiledInlineArray2<float> buffer = default(global::DecompiledInlineArray2<float>);
			global::DecompiledPrivateImplementationDetails.InlineArrayElementRef<global::DecompiledInlineArray2<float>, float>(ref buffer, 0) = value.Width;
			global::DecompiledPrivateImplementationDetails.InlineArrayElementRef<global::DecompiledInlineArray2<float>, float>(ref buffer, 1) = value.Height;
			return MemoryMarshal.Cast<float, long>(global::DecompiledPrivateImplementationDetails.InlineArrayAsReadOnlySpan<global::DecompiledInlineArray2<float>, float>(in buffer, 2))[0];
		}
	}
	public sealed class SizeLimitsImmutableSectionModifier : ValueImmutableSectionModifierBase<ISizeLimitsSectionModifier, SizeLimits>, ISizeLimitsSectionModifier, IReadOnlyValueSectionModifier<SizeLimits>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeLimits>, IHasReadOnlyValue, IImmutableValueSectionModifier<SizeLimits>
	{
		public override int Priority => 9800;

		public static IImmutableValueSectionModifier<SizeLimits> Get(SizeLimits value)
		{
			return new SizeLimitsImmutableSectionModifier
			{
				Value = value
			};
		}
	}
	public sealed class SizeLimitsSectionModifier : ValueSectionModifierBase<ISizeLimitsSectionModifier, SizeLimits>, ISizeLimitsSectionModifier, IReadOnlyValueSectionModifier<SizeLimits>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeLimits>, IHasReadOnlyValue
	{
		public override int Priority => 9800;
	}
	public sealed class SizeSectionModifier : ValueSectionModifierBase<ISizeSectionModifier, SizeF>, ISizeSectionModifier, IReadOnlyValueSectionModifier<SizeF>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeF>, IHasReadOnlyValue
	{
		public override int Priority => 9700;
	}
	public sealed class StretchSectionModifier : ImmutableSectionModifierBase<StretchSectionModifier>
	{
		public static readonly StretchSectionModifier Instance = new StretchSectionModifier();

		public override int Priority => 7900;

		private StretchSectionModifier()
		{
		}
	}
	public sealed class TapImmutableSectionModifier : CommandImmutableSectionModifier<ITapSectionModifier>, ITapSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IImmutableCommandSectionModifier
	{
		public TapImmutableSectionModifier(ICommand command, object? parameter)
			: base(command, parameter)
		{
		}

		public static IImmutableCommandSectionModifier Get(ICompositeCommand command, object? parameter)
		{
			return new TapImmutableSectionModifier(command, parameter);
		}
	}
	public sealed class TapSectionModifier : CommandSectionModifierBase<ITapSectionModifier>, ITapSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public sealed class TapThroughImmutableSectionModifier : CommandImmutableSectionModifier<ITapThroughSectionModifier>, ITapThroughSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IImmutableCommandSectionModifier
	{
		public TapThroughImmutableSectionModifier(ICommand command, object? parameter)
			: base(command, parameter)
		{
		}

		public static IImmutableCommandSectionModifier Get(ICompositeCommand command, object? parameter)
		{
			return new TapThroughImmutableSectionModifier(command, parameter);
		}
	}
	public sealed class TapThroughSectionModifier : CommandSectionModifierBase<ITapThroughSectionModifier>, ITapThroughSectionModifier, ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public sealed class TextAlignmentImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<TextAlignmentImmutableSectionModifier, ITextAlignmentSectionModifier, byte, TextAlignment>, ITextAlignmentSectionModifier, IReadOnlyValueSectionModifier<TextAlignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TextAlignment>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<TextAlignment, byte>, IImmutableValueSectionModifier<TextAlignment>
	{
		public override int Priority => 4900;

		public static byte GetKey(TextAlignment? value)
		{
			Should.NotBeNull(value, "value");
			return value.Value;
		}
	}
	public sealed class TextAlignmentSectionModifier : EnumValueSectionModifierBase<ITextAlignmentSectionModifier, TextAlignment, byte>, ITextAlignmentSectionModifier, IReadOnlyValueSectionModifier<TextAlignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TextAlignment>, IHasReadOnlyValue
	{
		public override int Priority => 4900;

		protected override TextAlignment DefaultValue => TextAlignment.Start;
	}
	public sealed class TextColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<TextColorImmutableSectionModifier, ITextColorSectionModifier, int, Color>, ITextColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 970;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class TextColorSectionModifier : ValueSectionModifierBase<ITextColorSectionModifier, Color>, ITextColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 970;
	}
	public sealed class ThumbTintColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<ThumbTintColorImmutableSectionModifier, IThumbTintColorSectionModifier, int, Color>, IThumbTintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 960;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class ThumbTintColorSectionModifier : ValueSectionModifierBase<IThumbTintColorSectionModifier, Color>, IThumbTintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 960;
	}
	public sealed class TintColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<TintColorImmutableSectionModifier, ITintColorSectionModifier, int, Color>, ITintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 960;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class TintColorSectionModifier : ValueSectionModifierBase<ITintColorSectionModifier, Color>, ITintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 960;
	}
	public class ToolbarItemSectionModifier : IToolbarItemSectionModifier, IMarkerSectionModifier<IToolbarItemSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		private static readonly Lock Locker = new Lock();

		private static DictionarySlim<long, ToolbarItemSectionModifier> _cache = new DictionarySlim<long, ToolbarItemSectionModifier>(17);

		public ToolbarType ToolbarType { get; }

		public EnumFlags<ToolbarSectionFlags> ToolbarFlags { get; }

		public ToolbarItemSectionModifier(ToolbarType toolbarType, EnumFlags<ToolbarSectionFlags> toolbarFlags)
		{
			Should.NotBeNull(toolbarType, "toolbarType");
			ToolbarType = toolbarType;
			ToolbarFlags = toolbarFlags;
		}

		public static ToolbarItemSectionModifier Get(ToolbarType toolbarType, EnumFlags<ToolbarSectionFlags> toolbarFlags)
		{
			Should.NotBeNull(toolbarType, "toolbarType");
			global::DecompiledInlineArray2<int> buffer = default(global::DecompiledInlineArray2<int>);
			global::DecompiledPrivateImplementationDetails.InlineArrayElementRef<global::DecompiledInlineArray2<int>, int>(ref buffer, 0) = toolbarType.Value;
			global::DecompiledPrivateImplementationDetails.InlineArrayElementRef<global::DecompiledInlineArray2<int>, int>(ref buffer, 1) = toolbarFlags.Value();
			long key = MemoryMarshal.Cast<int, long>(global::DecompiledPrivateImplementationDetails.InlineArrayAsReadOnlySpan<global::DecompiledInlineArray2<int>, int>(in buffer, 2))[0];
			using (Locker.EnterScope())
			{
				ref ToolbarItemSectionModifier orAddValueRef = ref _cache.GetOrAddValueRef(key);
				return orAddValueRef ?? (orAddValueRef = new ToolbarItemSectionModifier(toolbarType, toolbarFlags));
			}
		}
	}
	public sealed class ToolbarMenuSectionModifier : ToolbarItemSectionModifier, IToolbarMenuSectionModifier, IToolbarItemSectionModifier, IMarkerSectionModifier<IToolbarItemSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		public Bindable<FormattedText> Title { get; }

		public ToolbarMenuSectionModifier(Bindable<FormattedText> title, ToolbarType toolbarType, EnumFlags<ToolbarSectionFlags> toolbarFlags)
			: base(toolbarType, (FlagsEnumBase<ToolbarSectionFlags, int>?)ToolbarSectionFlags.MenuItem | toolbarFlags)
		{
			Title = title;
		}
	}
	public sealed class TrackTintColorImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<TrackTintColorImmutableSectionModifier, ITrackTintColorSectionModifier, int, Color>, ITrackTintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<Color, int>, IImmutableValueSectionModifier<Color>
	{
		public override int Priority => 960;

		public static int GetKey(Color value)
		{
			return value;
		}
	}
	public sealed class TrackTintColorSectionModifier : ValueSectionModifierBase<ITrackTintColorSectionModifier, Color>, ITrackTintColorSectionModifier, IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
		public override int Priority => 960;
	}
	public sealed class ValidatorSectionModifier : IValidatorSectionModifier, IMarkerSectionModifier<IValidatorSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasService<IValidator>, IHasOptionalService<IValidator>
	{
		public IValidator Service { get; }

		public ValidatorSectionModifier(IVisualSection section)
		{
			Should.NotBeNull(section, "section");
			Service = CompositeValidator.Create(PooledReadOnlyList.Get((object)section));
		}

		public void Dispose()
		{
			Service.Dispose();
		}
	}
	public abstract class ValueImmutableSectionModifierBase<TModifierBase, TValue> : ImmutableSectionModifierBase<TModifierBase>, IReadOnlyValueSectionModifier<TValue>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TValue>, IHasReadOnlyValue where TModifierBase : class, ISectionModifier
	{
		public TValue Value { get; init; }

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValueImmutableSectionModifierBase<, >))]
		protected ValueImmutableSectionModifierBase()
		{
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValueImmutableSectionModifierBase<, >))]
		protected ValueImmutableSectionModifierBase(TValue value)
		{
			Value = value;
		}
	}
	public abstract class ValueSectionModifierBase<TModifierBase, TValue> : SectionModifierBase<TModifierBase>, IValueSectionModifier<TValue>, IReadOnlyValueSectionModifier<TValue>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TValue>, IHasReadOnlyValue, IHasValue<TValue>, IFastBindableListener<TValue>, IBindableListener<TValue>, IBindableListener, IObserver<TValue>, IEventListener, IWeakItem, IMemberPathObserverListener where TModifierBase : class, ISectionModifier
	{
		private TValue _value;

		public TValue Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (!EqualityComparer<TValue>.Default.Equals(value, _value))
				{
					_value = value;
					OnPropertyChanged(Default.ValueChangedArgs);
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValueSectionModifierBase<, >))]
		protected ValueSectionModifierBase()
		{
		}

		void IBindableListener<TValue>.OnValue(TValue value)
		{
			Value = value;
		}

		void IBindableListener.OnError(Exception error, BindableErrorType errorType)
		{
			IMugenService<IMugenApplication>.Instance.OnUnhandledException(error, errorType.UnhandledExceptionType, this);
		}

		void IBindableListener.OnBeginExecuting(object source, BindableExecutionKind kind)
		{
		}

		void IBindableListener.OnEndExecuting(object source, BindableExecutionKind kind)
		{
		}
	}
	public abstract class ValueWrapperSectionModifierBase<TModifierBase, TValue> : SectionModifierBase<TModifierBase>, IValueSectionModifier<TValue>, IReadOnlyValueSectionModifier<TValue>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TValue>, IHasReadOnlyValue, IHasValue<TValue> where TModifierBase : class, IReadOnlyValueSectionModifier<TValue>
	{
		private TValue _externalValue;

		private TValue _wrapperValue;

		private TValue _value;

		public TValue WrapperValue
		{
			get
			{
				return _wrapperValue;
			}
			set
			{
				if (!EqualityComparer<TValue>.Default.Equals(value, _wrapperValue))
				{
					_wrapperValue = value;
					UpdateValue();
				}
			}
		}

		public TValue Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (!EqualityComparer<TValue>.Default.Equals(value, _externalValue))
				{
					_externalValue = value;
					UpdateValue();
				}
			}
		}

		[DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces, typeof(ValueWrapperSectionModifierBase<, >))]
		protected ValueWrapperSectionModifierBase()
		{
		}

		public override void OnAttached(IVisualSection section)
		{
			base.OnAttached(section);
			TModifierBase val = section.Modifiers.TryGet<TModifierBase>();
			if (val != null)
			{
				section.BindModifier(val.BindValue(), this, delegate(TValue? v, ValueWrapperSectionModifierBase<TModifierBase, TValue> s)
				{
					s.Value = v;
				});
			}
		}

		protected abstract TValue OnValueChanged(TValue externalValue, TValue wrapperValue);

		private void UpdateValue()
		{
			TValue val = OnValueChanged(_externalValue, _wrapperValue);
			if (!EqualityComparer<TValue>.Default.Equals(val, _value))
			{
				_value = val;
				OnPropertyChanged(Default.ValueChangedArgs);
			}
		}
	}
	public sealed class VisibilitySectionModifier : EnumValueSectionModifierBase<IVisibilitySectionModifier, SectionVisibility, byte>, IVisibilitySectionModifier, IReadOnlyValueSectionModifier<SectionVisibility>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SectionVisibility>, IHasReadOnlyValue
	{
		public override int Priority => 5000;

		protected override SectionVisibility DefaultValue => SectionVisibility.Visible;
	}
	public sealed class ZIndexImmutableSectionModifier : CacheableValueImmutableSectionModifierBase<ZIndexImmutableSectionModifier, IZIndexSectionModifier, float, float>, IZIndexSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue, ICacheableImmutableValueSectionModifier<float, float>, IImmutableValueSectionModifier<float>
	{
		public override int Priority => 900;

		public static float GetKey(float value)
		{
			return value;
		}
	}
	public sealed class ZIndexSectionModifier : ValueSectionModifierBase<IZIndexSectionModifier, float>, IZIndexSectionModifier, IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
		public override int Priority => 900;
	}
}
namespace MugenMvvm.CompositeUI.Sections.Modifiers.Interfaces
{
	public interface IAlignmentSectionModifier : IReadOnlyValueSectionModifier<Alignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Alignment>, IHasReadOnlyValue
	{
	}
	public interface IAnimateLayoutChangesSectionModifier : IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
	}
	public interface IAttachableSectionModifier : ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		void OnAttached(IVisualSection section);

		void OnDetached(IVisualSection section);
	}
	public interface IAttachStateSectionModifier : IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		void OnChanged(bool value);
	}
	public interface IBackgroundColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IBorderColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IBorderWidthSectionModifier : IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
	}
	public interface ICacheableImmutableValueSectionModifier<T, out TKey> : IImmutableValueSectionModifier<T>, IReadOnlyValueSectionModifier<T>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<T>, IHasReadOnlyValue
	{
		static abstract TKey GetKey(T? value);
	}
	public interface IClipToPaddingSectionModifier : IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
	}
	public interface ICommandSectionModifier : ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		ICommand? Command { get; }

		object? Parameter { get; }
	}
	public interface ICornerRadiusSectionModifier : IReadOnlyValueSectionModifier<CornerRadius>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<CornerRadius>, IHasReadOnlyValue
	{
	}
	public interface ICursorColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IElevationSectionModifier : IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
	}
	public interface IEnabledSectionModifier : IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
	}
	public interface IFocusSectionModifier : IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
	}
	public interface IFontSectionModifier : IReadOnlyValueSectionModifier<FontSpec>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FontSpec>, IHasReadOnlyValue
	{
	}
	public interface IGravitySectionModifier : IReadOnlyValueSectionModifier<EnumFlags<GravityFlags>>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<EnumFlags<GravityFlags>>, IHasReadOnlyValue
	{
	}
	public interface IImageStretchModeSectionModifier : IReadOnlyValueSectionModifier<ImageStretchMode>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<ImageStretchMode>, IHasReadOnlyValue
	{
	}
	public interface IImmutableCommandSectionModifier : ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		static abstract IImmutableCommandSectionModifier Get(ICompositeCommand command, object? parameter);
	}
	public interface IImmutableValueSectionModifier<T> : IReadOnlyValueSectionModifier<T>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<T>, IHasReadOnlyValue
	{
		static abstract IImmutableValueSectionModifier<T> Get(T? value);
	}
	public interface IKeyboardTypeSectionModifier : IReadOnlyValueSectionModifier<KeyboardType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<KeyboardType>, IHasReadOnlyValue
	{
	}
	public interface ILoadMoreSectionModifier : ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public interface IMarginSectionModifier : IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
	}
	public interface IMarkerSectionModifier<TMarker> : ISectionModifier, IHasPriority, IHasId<int>, IHasName where TMarker : IMarkerSectionModifier<TMarker>
	{
		EnumFlags<SectionModifierFlags> ISectionModifier.Flags => SectionModifierFlags.Immutable | SectionModifierFlags.Marker;

		int IHasPriority.Priority => 0;

		int IHasId<int>.Id => Default.GetIdByType(typeof(TMarker));

		string IHasName.Name => typeof(TMarker).Name;

		ISectionModifierRenderer<TView>? ISectionModifier.TryGetRenderer<TView>(object item, IReadOnlyMetadataContext? metadata)
		{
			return null;
		}
	}
	public interface IMaxLinesSectionModifier : IReadOnlyValueSectionModifier<int>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<int>, IHasReadOnlyValue
	{
	}
	public interface IOrientationSectionModifier : IReadOnlyValueSectionModifier<OrientationType>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<OrientationType>, IHasReadOnlyValue
	{
	}
	public interface IPaddingSectionModifier : IReadOnlyValueSectionModifier<Thickness>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Thickness>, IHasReadOnlyValue
	{
	}
	public interface IParentMarkerSectionModifier : IMarkerSectionModifier<IParentMarkerSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		ILayoutSection Parent { get; }
	}
	public interface IPlaceholderColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IPlaceholderSectionModifier : IReadOnlyValueSectionModifier<FormattedText>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<FormattedText>, IHasReadOnlyValue
	{
	}
	public interface IPressedSectionModifier : IReadOnlyValueSectionModifier<bool>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<bool>, IHasReadOnlyValue
	{
		void OnChanged(bool value);
	}
	public interface IPrioritySectionModifier : IMarkerSectionModifier<IPrioritySectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IReadOnlyValueSectionModifier<int>, IHasReadOnlyValue<int>, IHasReadOnlyValue
	{
	}
	public interface IReadOnlyValueSectionModifier<out T> : ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<T>, IHasReadOnlyValue
	{
	}
	public interface IRefreshSectionModifier : ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IValueSectionModifier<bool>, IReadOnlyValueSectionModifier<bool>, IHasReadOnlyValue<bool>, IHasReadOnlyValue, IHasValue<bool>
	{
	}
	public interface ISectionModifier : IHasPriority, IHasId<int>, IHasName
	{
		EnumFlags<SectionModifierFlags> Flags { get; }

		ISectionModifierRenderer<TView>? TryGetRenderer<TView>(object item, IReadOnlyMetadataContext? metadata) where TView : class;
	}
	public interface ISizeLimitsSectionModifier : IReadOnlyValueSectionModifier<SizeLimits>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeLimits>, IHasReadOnlyValue
	{
	}
	public interface ISizeSectionModifier : IReadOnlyValueSectionModifier<SizeF>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SizeF>, IHasReadOnlyValue
	{
	}
	public interface ITapSectionModifier : ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public interface ITapThroughSectionModifier : ICommandSectionModifier, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
	}
	public interface ITextAlignmentSectionModifier : IReadOnlyValueSectionModifier<TextAlignment>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<TextAlignment>, IHasReadOnlyValue
	{
	}
	public interface ITextColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IThumbTintColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface ITintColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IToolbarItemSectionModifier : IMarkerSectionModifier<IToolbarItemSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		ToolbarType ToolbarType { get; }

		EnumFlags<ToolbarSectionFlags> ToolbarFlags { get; }

		int IHasPriority.Priority => int.MaxValue;
	}
	public interface IToolbarMenuSectionModifier : IToolbarItemSectionModifier, IMarkerSectionModifier<IToolbarItemSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName
	{
		Bindable<FormattedText> Title { get; }
	}
	public interface ITrackTintColorSectionModifier : IReadOnlyValueSectionModifier<Color>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<Color>, IHasReadOnlyValue
	{
	}
	public interface IValidatorSectionModifier : IMarkerSectionModifier<IValidatorSectionModifier>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasService<IValidator>, IHasOptionalService<IValidator>
	{
	}
	public interface IValueSectionModifier<T> : IReadOnlyValueSectionModifier<T>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<T>, IHasReadOnlyValue, IHasValue<T>
	{
	}
	public interface IVisibilitySectionModifier : IReadOnlyValueSectionModifier<SectionVisibility>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<SectionVisibility>, IHasReadOnlyValue
	{
	}
	public interface IZIndexSectionModifier : IReadOnlyValueSectionModifier<float>, ISectionModifier, IHasPriority, IHasId<int>, IHasName, IHasReadOnlyValue<float>, IHasReadOnlyValue
	{
	}
}
namespace MugenMvvm.CompositeUI.Sections.Interfaces
{
	public interface IAppErrorsAwareSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		IReadOnlyObservableCollection<IAppErrorInfo> Errors { get; }

		bool Register(object section, IReadOnlyMetadataContext? metadata);

		bool Unregister(object section, IReadOnlyMetadataContext? metadata);
	}
	public interface IBusyManagerAwareSection : ISection, IInner<ISection>, IDisposable
	{
		void Attach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata);

		void Detach(IBusyManager busyManager, IReadOnlyMetadataContext? metadata);
	}
	public interface IBusyTokensAwareSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		IReadOnlyObservableCollection<IBusyToken> BusyTokens { get; }

		bool Register(IBusyManager busyManager, IReadOnlyMetadataContext? metadata);

		bool Unregister(IBusyManager busyManager, IReadOnlyMetadataContext? metadata);
	}
	public interface ICloseableSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? CloseCommand { get; }
	}
	public interface ICompositeSection : ISection, IInner<ISection>, IDisposable
	{
		IReadOnlyCollection<ISection> Sections { get; }

		SectionVisibility CompositeSectionVisibility { get; }

		bool Flatten => true;
	}
	public interface IDataContextWrapperSection : IDataContextWrapper, ISection, IInner<ISection>, IDisposable, IDecorator<ISection>
	{
		object? IDataContextWrapper.DataContext => Next;
	}
	public interface IHasCloseConditionSection : ISection, IInner<ISection>, IDisposable
	{
		ValueTask<bool> OnBackNavigationAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return new ValueTask<bool>(result: true);
		}

		ValueTask<bool> OnClosingAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return new ValueTask<bool>(result: true);
		}
	}
	public interface IHasPrioritySection : ISection, IInner<ISection>, IDisposable, IHasPriority
	{
	}
	public interface IHasReadOnlyVisibilitySection : ISection, IInner<ISection>, IDisposable
	{
		SectionVisibility Visibility { get; }
	}
	public interface IHasVisibilitySection : IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		new SectionVisibility Visibility { get; set; }

		SectionVisibility IHasReadOnlyVisibilitySection.Visibility => Visibility;
	}
	public interface IInvisibleSection : IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		SectionVisibility IHasReadOnlyVisibilitySection.Visibility => SectionVisibility.Invisible;
	}
	public interface ILoadMoreSupportSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? LoadMoreCommand { get; }

		bool IsVertical => true;
	}
	public interface IRefreshableSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? RefreshCommand { get; }

		bool AutoRefreshOnAttach => false;
	}
	public interface IReloadableSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand ReloadCommand { get; }
	}
	public interface IRemovableSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? RemoveCommand { get; }
	}
	public interface IRootSection : IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
	}
	public interface ISection : IInner<ISection>, IDisposable
	{
		void Attach(IShell shell)
		{
			ISection section = this.NextDecoratorOrSource();
			if (this != section)
			{
				section.Attach(shell);
			}
			OnAttaching(shell);
			if (this is IShellAwareSection shellAwareSection)
			{
				if (shellAwareSection.Shell != null)
				{
					if (shellAwareSection.Shell == shell)
					{
						return;
					}
					ExceptionManager.ThrowObjectInitialized(this, "Attach");
				}
				shellAwareSection.Shell = shell;
			}
			OnAttached(shell);
		}

		void Detach(IShell shell)
		{
			ISection section = this.NextDecoratorOrSource();
			if (this != section)
			{
				section.Detach(shell);
			}
			OnDetaching(shell);
			if (this is IShellAwareSection shellAwareSection)
			{
				if (shellAwareSection.Shell == null)
				{
					return;
				}
				if (shellAwareSection.Shell == shell)
				{
					shellAwareSection.Shell = null;
				}
			}
			OnDetached(shell);
		}

		void OnAttaching(IShell shell)
		{
		}

		void OnAttached(IShell shell)
		{
		}

		void OnDetaching(IShell shell)
		{
		}

		void OnDetached(IShell shell)
		{
		}

		void IDisposable.Dispose()
		{
			ISection section = this.NextDecoratorOrSource();
			if (section != this)
			{
				section.Dispose();
			}
		}
	}
	public interface ISelectableSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? SelectCommand { get; }
	}
	public interface ISelectorSection : ISelectableSection, ISection, IInner<ISection>, IDisposable
	{
		event EventHandler? IsSelectedChanged;

		bool IsSelected(object? item);
	}
	public interface IShell : INotifyPropertyChanged, IShellSection, IShellAware, IHasDisposeCallback, IHasDisposedState, IDisposable, ISupportDisposeCallback
	{
		IShellLayoutSection? Layout { get; }

		IShell IShellAware.Shell => this;
	}
	public interface IShellAware
	{
		IShell? Shell { get; }
	}
	public interface IShellAwareSection : ISection, IInner<ISection>, IDisposable, IShellAware
	{
		new IShell? Shell { get; set; }

		IShell? IShellAware.Shell => Shell;
	}
	public interface IShellConfigurationHandlerSection : ISection, IInner<ISection>, IDisposable
	{
		ObservableCollectionConfiguration<ISection, UnitRef> OnConfiguring(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration;
		}

		ObservableCollectionConfiguration<ISection, UnitRef> OnConfigured(ObservableCollectionConfiguration<ISection, UnitRef> configuration)
		{
			return configuration;
		}

		void OnInitialized(IShell shell, ref PooledItemOrList<ISection> additionalSections);
	}
	public interface IShellLayoutSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IShellAware
	{
		object? Content { get; }
	}
	public interface IShellSection : IShellAware, IHasDisposeCallback, IHasDisposedState, IDisposable, ISupportDisposeCallback
	{
		IReadOnlyObservableCollection<ISection> Sections { get; }

		ValueTask<bool?> UpdateSectionsAsync(IAsyncEnumerator<ISection> sections, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);

		bool RemoveSection(ISection section);
	}
	public interface ISuppressAppErrorsListenerSection : ISection, IInner<ISection>, IDisposable
	{
	}
	public interface IValidationErrorsAwareSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IHasService<IValidator>, IHasOptionalService<IValidator>
	{
		IReadOnlyObservableCollection<ValidationErrorInfoRef> Errors { get; }
	}
	public interface IValueSection<out T> : ISection, IInner<ISection>, IDisposable, IHasReadOnlyValue<T>, IHasReadOnlyValue
	{
	}
	public interface IViewsAwareSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable
	{
		IReadOnlyObservableCollection<IView> Views { get; }
	}
	public interface IWorkflowHandlerSection : IRootSection, IInvisibleSection, IHasReadOnlyVisibilitySection, ISection, IInner<ISection>, IDisposable, IWorkflowSection
	{
		IWorkflowHandlerSection Register(ICompositeCommand? command);

		IWorkflowHandlerSection Unregister(ICompositeCommand? command);
	}
	public interface IWorkflowSection : ISection, IInner<ISection>, IDisposable
	{
		ICompositeCommand? GoBackCommand => null;

		ICompositeCommand? GoNextCommand => null;

		ICompositeCommand? CompleteCommand => null;
	}
	public interface IWorkflowStepInfo : IEquatable<IWorkflowStepInfo>, IHasPriority, IHasId<string>
	{
	}
	public interface IWorkflowSuspendableSection : ISection, IInner<ISection>, IDisposable
	{
		void Register(IWorkflowHandlerSection handler);

		void Unregister(IWorkflowHandlerSection handler);
	}
}
namespace MugenMvvm.CompositeUI.Enums
{
	public class Alignment : EnumBase<Alignment, byte>
	{
		public static readonly Alignment Start = new Alignment(1, "Start");

		public static readonly Alignment Center = new Alignment(2, "Center");

		public static readonly Alignment End = new Alignment(3, "End");

		public static readonly Alignment Fill = new Alignment(4, "Fill");

		public Alignment(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class BreakpointType : EnumBase<BreakpointType, byte>
	{
		public static readonly BreakpointType Xs = new BreakpointType(1, "Xs");

		public static readonly BreakpointType Sm = new BreakpointType(2, "Sm");

		public static readonly BreakpointType SmWide = new BreakpointType(3, "SmWide");

		public static readonly BreakpointType Md = new BreakpointType(4, "Md");

		public static readonly BreakpointType Lg = new BreakpointType(5, "Lg");

		public BreakpointType(byte value, string? name = null)
			: base(value, name, register: true)
		{
		}
	}
	public class FontStyle : EnumBase<FontStyle, byte>
	{
		public static readonly FontStyle Normal = new FontStyle(0, "Normal");

		public static readonly FontStyle Italic = new FontStyle(1, "Italic");

		public FontStyle(byte v, string? n = null)
			: base(v, n, register: true)
		{
		}
	}
	public class FontWeight : EnumBase<FontWeight, byte>
	{
		public static readonly FontWeight Thin = new FontWeight(1, 100, "Thin");

		public static readonly FontWeight Light = new FontWeight(2, 300, "Light");

		public static readonly FontWeight Regular = new FontWeight(3, 400, "Regular");

		public static readonly FontWeight Medium = new FontWeight(4, 500, "Medium");

		public static readonly FontWeight SemiBold = new FontWeight(5, 600, "SemiBold");

		public static readonly FontWeight Bold = new FontWeight(6, 700, "Bold");

		public static readonly FontWeight ExtraBold = new FontWeight(7, 800, "ExtraBold");

		public static readonly FontWeight Black = new FontWeight(8, 900, "Black");

		public int Weight { get; }

		public FontWeight(byte v, int weight, string? n = null)
			: base(v, n, register: true)
		{
			Weight = weight;
		}
	}
	public class GravityFlags : FlagsEnumBase<GravityFlags, ushort>
	{
		public static readonly GravityFlags Start = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "Start");

		public static readonly GravityFlags CenterHorizontal = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "CenterHorizontal");

		public static readonly GravityFlags End = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "End");

		public static readonly GravityFlags FillHorizontal = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "FillHorizontal");

		public static readonly GravityFlags Top = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "Top");

		public static readonly GravityFlags CenterVertical = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "CenterVertical");

		public static readonly GravityFlags Bottom = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "Bottom");

		public static readonly GravityFlags FillVertical = new GravityFlags((ushort)FlagsEnumBase<GravityFlags, ushort>.NextFlagInt(), "FillVertical");

		public static EnumFlags<GravityFlags> Default => TopStart;

		public static EnumFlags<GravityFlags> Center => CenterHorizontal | CenterVertical;

		public static EnumFlags<GravityFlags> Fill => FillHorizontal | FillVertical;

		public static EnumFlags<GravityFlags> TopStart => Top | Start;

		public static EnumFlags<GravityFlags> TopEnd => Top | End;

		public static EnumFlags<GravityFlags> BottomStart => Bottom | Start;

		public static EnumFlags<GravityFlags> BottomEnd => Bottom | End;

		public GravityFlags(ushort value, string? name = null, bool register = true)
			: base(value, (long)value, name, register)
		{
		}
	}
	public class ImageSourceType : EnumBase<ImageSourceType, byte>
	{
		public static readonly ImageSourceType None = new ImageSourceType(MugenMvvm.CompositeUI.Enums.MediaSourceType.None);

		public static readonly ImageSourceType Url = new ImageSourceType(MugenMvvm.CompositeUI.Enums.MediaSourceType.ImageUrl);

		public static readonly ImageSourceType Resource = new ImageSourceType(MugenMvvm.CompositeUI.Enums.MediaSourceType.ImageResource);

		public static readonly ImageSourceType Raw = new ImageSourceType(MugenMvvm.CompositeUI.Enums.MediaSourceType.ImageRaw);

		public static readonly ImageSourceType Qr = new ImageSourceType(MugenMvvm.CompositeUI.Enums.MediaSourceType.ImageQr);

		public EnumFlags<MediaSourceFlags> Flags => MediaSourceType.Flags;

		public bool IsResource => Flags.HasFlag(MediaSourceFlags.Resource);

		public MediaSourceType MediaSourceType => EnumBase<MugenMvvm.CompositeUI.Enums.MediaSourceType, byte>.Get(base.Value);

		public ImageSourceType(MediaSourceType mediaSourceType, bool register = true)
			: base(mediaSourceType.Value, mediaSourceType.Name, register)
		{
		}
	}
	public class ImageStretchMode : EnumBase<ImageStretchMode, byte>
	{
		public static readonly ImageStretchMode None = new ImageStretchMode(0, "None");

		public static readonly ImageStretchMode Fill = new ImageStretchMode(1, "Fill");

		public static readonly ImageStretchMode AspectFit = new ImageStretchMode(2, "AspectFit");

		public static readonly ImageStretchMode AspectFill = new ImageStretchMode(3, "AspectFill");

		public static readonly ImageStretchMode Center = new ImageStretchMode(4, "Center");

		private ImageStretchMode(byte value, string name, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class ImageTintBehavior : EnumBase<ImageTintBehavior, byte>
	{
		public static readonly ImageTintBehavior Auto = new ImageTintBehavior(0, "Auto");

		public static readonly ImageTintBehavior ForceTint = new ImageTintBehavior(1, "ForceTint");

		public static readonly ImageTintBehavior IgnoreTint = new ImageTintBehavior(2, "IgnoreTint");

		public ImageTintBehavior(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class ImageTransitionFlags : FlagsEnumBase<ImageTransitionFlags, byte>
	{
		public static readonly ImageTransitionFlags None = new ImageTransitionFlags(0, "None");

		public static readonly ImageTransitionFlags Crossfade = new ImageTransitionFlags((byte)FlagsEnumBase<ImageTransitionFlags, byte>.NextFlagInt(), "Crossfade");

		public ImageTransitionFlags(byte value, string? name = null, bool register = true)
			: base(value, (long)value, name, register)
		{
		}
	}
	public class KeyboardType : EnumBase<KeyboardType, byte>
	{
		public static readonly KeyboardType Default = new KeyboardType(0, "Default");

		public static readonly KeyboardType Text = new KeyboardType(1, "Text");

		public static readonly KeyboardType TextMultiline = new KeyboardType(2, "TextMultiline");

		public static readonly KeyboardType Email = new KeyboardType(3, "Email");

		public static readonly KeyboardType Integer = new KeyboardType(4, "Integer");

		public static readonly KeyboardType Decimal = new KeyboardType(5, "Decimal");

		public static readonly KeyboardType Phone = new KeyboardType(6, "Phone");

		public static readonly KeyboardType Url = new KeyboardType(7, "Url");

		public static readonly KeyboardType Password = new KeyboardType(8, "Password")
		{
			IsSecure = true
		};

		public bool IsSecure { get; init; }

		public KeyboardType(byte value, string name, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public sealed class LayoutDirType : EnumBase<LayoutDirType, byte>
	{
		public static readonly LayoutDirType Ltr = new LayoutDirType(1, "Ltr");

		public static readonly LayoutDirType Rtl = new LayoutDirType(2, "Rtl");

		private LayoutDirType(byte v, string? n = null, bool register = true)
			: base(v, n, register)
		{
		}
	}
	public sealed class MediaSourceFlags : FlagsEnumBase<MediaSourceFlags, int>
	{
		public static readonly MediaSourceFlags Resource = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Resource");

		public static readonly MediaSourceFlags Remote = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Remote");

		public static readonly MediaSourceFlags Raw = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Raw");

		public static readonly MediaSourceFlags Image = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Image");

		public static readonly MediaSourceFlags Video = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Video");

		public static readonly MediaSourceFlags Model = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Model");

		public static readonly MediaSourceFlags Audio = new MediaSourceFlags(FlagsEnumBase<MediaSourceFlags, int>.NextFlagInt(), "Audio");

		public MediaSourceFlags(int value, string? name = null, bool register = true)
			: base(value, (long)value, name, register)
		{
		}
	}
	public sealed class MediaSourceType : EnumBase<MediaSourceType, byte>
	{
		public static readonly MediaSourceType None = new MediaSourceType(0, "None");

		public static readonly MediaSourceType ImageUrl = new MediaSourceType(1, "ImageUrl")
		{
			Flags = (MediaSourceFlags.Image | MediaSourceFlags.Remote)
		};

		public static readonly MediaSourceType ImageResource = new MediaSourceType(2, "ImageResource")
		{
			Flags = (MediaSourceFlags.Image | MediaSourceFlags.Resource)
		};

		public static readonly MediaSourceType ImageRaw = new MediaSourceType(3, "ImageRaw")
		{
			Flags = (MediaSourceFlags.Image | MediaSourceFlags.Raw)
		};

		public static readonly MediaSourceType ImageQr = new MediaSourceType(4, "ImageQr")
		{
			Flags = (FlagsEnumBase<MediaSourceFlags, int>?)MediaSourceFlags.Image
		};

		public static readonly MediaSourceType VideoUrl = new MediaSourceType(50, "VideoUrl")
		{
			Flags = (MediaSourceFlags.Video | MediaSourceFlags.Remote)
		};

		public static readonly MediaSourceType VideoResource = new MediaSourceType(51, "VideoResource")
		{
			Flags = (MediaSourceFlags.Video | MediaSourceFlags.Resource)
		};

		public static readonly MediaSourceType VideoRaw = new MediaSourceType(52, "VideoRaw")
		{
			Flags = (MediaSourceFlags.Video | MediaSourceFlags.Raw)
		};

		public static readonly MediaSourceType ModelUrl = new MediaSourceType(100, "ModelUrl")
		{
			Flags = (MediaSourceFlags.Model | MediaSourceFlags.Remote)
		};

		public static readonly MediaSourceType ModelResource = new MediaSourceType(101, "ModelResource")
		{
			Flags = (MediaSourceFlags.Model | MediaSourceFlags.Resource)
		};

		public static readonly MediaSourceType ModelRaw = new MediaSourceType(102, "ModelRaw")
		{
			Flags = (MediaSourceFlags.Model | MediaSourceFlags.Raw)
		};

		public static readonly MediaSourceType AudioUrl = new MediaSourceType(150, "AudioUrl")
		{
			Flags = (MediaSourceFlags.Audio | MediaSourceFlags.Remote)
		};

		public static readonly MediaSourceType AudioResource = new MediaSourceType(151, "AudioResource")
		{
			Flags = (MediaSourceFlags.Audio | MediaSourceFlags.Resource)
		};

		public static readonly MediaSourceType AudioRaw = new MediaSourceType(152, "AudioRaw")
		{
			Flags = (MediaSourceFlags.Audio | MediaSourceFlags.Raw)
		};

		public EnumFlags<MediaSourceFlags> Flags { get; init; }

		public ImageSourceType? ImageSourceType => EnumBase<MugenMvvm.CompositeUI.Enums.ImageSourceType, byte>.TryGet(base.Value);

		public MediaSourceType(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class OrientationType : EnumBase<OrientationType, byte>
	{
		public static readonly OrientationType Vertical = new OrientationType(1, "Vertical");

		public static readonly OrientationType Horizontal = new OrientationType(2, "Horizontal");

		public OrientationType(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class SectionModifierFlags : FlagsEnumBase<SectionModifierFlags, int>
	{
		public static readonly SectionModifierFlags Marker = new SectionModifierFlags(FlagsEnumBase<SectionModifierFlags, int>.NextFlagInt());

		public static readonly SectionModifierFlags Immutable = new SectionModifierFlags(FlagsEnumBase<SectionModifierFlags, int>.NextFlagInt());

		public SectionModifierFlags(int value, string? name = null, bool register = true)
			: base(value, (long)value, name, register)
		{
		}
	}
	public class SectionVisibility : EnumBase<SectionVisibility, byte>
	{
		public static readonly SectionVisibility Visible = new SectionVisibility(1, "Visible")
		{
			IsVisible = true
		};

		public static readonly SectionVisibility Invisible = new SectionVisibility(2, "Invisible");

		public static readonly SectionVisibility Hidden = new SectionVisibility(3, "Hidden")
		{
			IsHidden = true
		};

		public bool IsHidden { get; init; }

		public bool IsVisible { get; init; }

		public SectionVisibility(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}

		public static implicit operator bool(SectionVisibility? visibility)
		{
			if (visibility != null)
			{
				return visibility.IsVisible;
			}
			return false;
		}

		public static implicit operator SectionVisibility(bool visible)
		{
			if (!visible)
			{
				return Hidden;
			}
			return Visible;
		}
	}
	public class SystemInsetType : EnumBase<SystemInsetType, byte>
	{
		public static readonly SystemInsetType SafeArea = new SystemInsetType(1, "SafeArea");

		public static readonly SystemInsetType SystemBars = new SystemInsetType(2, "SystemBars");

		public static readonly SystemInsetType Ime = new SystemInsetType(3, "Ime");

		public static readonly SystemInsetType Cutout = new SystemInsetType(4, "Cutout");

		public SystemInsetType(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class TabSectionType : EnumBase<TabSectionType, string>
	{
		public static readonly TabSectionType Main = new TabSectionType("Main");

		public TabSectionType(string value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class TextAlignment : EnumBase<TextAlignment, byte>
	{
		public static readonly TextAlignment Start = new TextAlignment(1, "Start");

		public static readonly TextAlignment Center = new TextAlignment(2, "Center");

		public static readonly TextAlignment End = new TextAlignment(3, "End");

		public static readonly TextAlignment Justify = new TextAlignment(4, "Justify");

		private TextAlignment(byte value, string name, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class TextFormat : EnumBase<TextFormat, byte>
	{
		public static readonly TextFormat Raw = new TextFormat(1, "Raw");

		public static readonly TextFormat Html = new TextFormat(2, "Html");

		public static readonly TextFormat Markdown = new TextFormat(3, "Markdown");

		public TextFormat(byte value, string? name = null)
			: base(value, name, register: true)
		{
		}
	}
	public class ToolbarSectionFlags : FlagsEnumBase<ToolbarSectionFlags, int>
	{
		public static readonly ToolbarSectionFlags Toolbar = new ToolbarSectionFlags(FlagsEnumBase<ToolbarSectionFlags, int>.NextFlagInt(), "Toolbar");

		public static readonly ToolbarSectionFlags MenuItem = new ToolbarSectionFlags(FlagsEnumBase<ToolbarSectionFlags, int>.NextFlagInt(), "MenuItem");

		public static readonly ToolbarSectionFlags Primary = new ToolbarSectionFlags(FlagsEnumBase<ToolbarSectionFlags, int>.NextFlagInt(), "Primary");

		public static readonly ToolbarSectionFlags Hidden = new ToolbarSectionFlags(FlagsEnumBase<ToolbarSectionFlags, int>.NextFlagInt(), "Hidden");

		public static readonly ToolbarSectionFlags AlwaysVisible = new ToolbarSectionFlags(FlagsEnumBase<ToolbarSectionFlags, int>.NextFlagInt(), "AlwaysVisible");

		public ToolbarSectionFlags(int value, string? name = null, bool register = true)
			: base(value, (long)value, name, register)
		{
		}
	}
	public class ToolbarType : EnumBase<ToolbarType, byte>
	{
		public static readonly ToolbarType Top = new ToolbarType(1, "Top");

		public static readonly ToolbarType Left = new ToolbarType(2, "Left");

		public static readonly ToolbarType Right = new ToolbarType(3, "Right");

		public static readonly ToolbarType Bottom = new ToolbarType(4, "Bottom");

		public ToolbarType(byte value, string? name = null, bool register = true)
			: base(value, name, register)
		{
		}
	}
	public class ViewportOrientationType : EnumBase<ViewportOrientationType, byte>
	{
		public static readonly ViewportOrientationType Portrait = new ViewportOrientationType(1, "Portrait");

		public static readonly ViewportOrientationType Landscape = new ViewportOrientationType(2, "Landscape");

		private ViewportOrientationType(byte v, string? n = null, bool register = true)
			: base(v, n, register)
		{
		}
	}
	public sealed class WindowSizeClassType : EnumBase<WindowSizeClassType, byte>
	{
		public const float WidthCompactMax = 599f;

		public const float WidthMediumMax = 839f;

		public const float HeightCompactMax = 479f;

		public const float HeightMediumMax = 899f;

		public static readonly WindowSizeClassType Compact = new WindowSizeClassType(1, "Compact");

		public static readonly WindowSizeClassType Medium = new WindowSizeClassType(2, "Medium");

		public static readonly WindowSizeClassType Expanded = new WindowSizeClassType(3, "Expanded");

		private WindowSizeClassType(byte v, string? n = null, bool register = true)
			: base(v, n, register)
		{
		}

		public static WindowSizeClassType FromWidthDp(float dp)
		{
			if (!(dp <= 599f))
			{
				if (!(dp <= 839f))
				{
					return Expanded;
				}
				return Medium;
			}
			return Compact;
		}

		public static WindowSizeClassType FromHeightDp(float dp)
		{
			if (!(dp <= 479f))
			{
				if (!(dp <= 899f))
				{
					return Expanded;
				}
				return Medium;
			}
			return Compact;
		}
	}
	public class WorkflowStep : EnumBase<WorkflowStep, string>, IWorkflowStepInfo, IEquatable<IWorkflowStepInfo>, IHasPriority, IHasId<string>
	{
		public int Priority { get; }

		public WorkflowStep(string value, int priority, string? name = null, bool register = true)
			: base(value, name, register)
		{
			Priority = priority;
		}

		bool IEquatable<IWorkflowStepInfo>.Equals(IWorkflowStepInfo? other)
		{
			if (other is WorkflowStep other2)
			{
				return Equals(other2);
			}
			return false;
		}
	}
}
namespace MugenMvvm.CompositeUI.Delegates
{
	public delegate void ModifierCleanup<TState>(ModifierSet modifiers, ref TState state);
	public delegate ModifierSet ModifierMutator<TState>(ModifierSet modifiers, ref TState state);
}
namespace MugenMvvm.CompositeUI.Debugging
{
	public class ShellDebugView : ViewModelDebugView
	{
		public ISectionApiRequest? Request => (Model as IMetadataOwner<IReadOnlyMetadataContext>)?.Metadata.Get(CompositeUIMetadata.SectionRequest);

		[DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(ShellDebugView))]
		public ShellDebugView(object model)
			: base(model)
		{
		}
	}
}
namespace MugenMvvm.CompositeUI.Common
{
	public readonly record struct Color(byte A, byte R, byte G, byte B)
	{
		public static Color Transparent => new Color(0, 0, 0, 0);

		public static Color Black => new Color(byte.MaxValue, 0, 0, 0);

		public static Color White => new Color(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		public static Color Red => new Color(byte.MaxValue, byte.MaxValue, 0, 0);

		public static Color Green => new Color(byte.MaxValue, 0, 128, 0);

		public static Color Blue => new Color(byte.MaxValue, 0, 122, byte.MaxValue);

		public static Color Yellow => new Color(byte.MaxValue, byte.MaxValue, 235, 59);

		public static Color Cyan => new Color(byte.MaxValue, 0, 188, 212);

		public static Color Magenta => new Color(byte.MaxValue, byte.MaxValue, 0, 221);

		public static Color Gray => new Color(byte.MaxValue, 142, 142, 147);

		public static Color LightGray => new Color(byte.MaxValue, 199, 199, 204);

		public static Color DarkGray => new Color(byte.MaxValue, 99, 99, 102);

		public static implicit operator int(Color c)
		{
			return c.ToInt32();
		}

		public static implicit operator Color(int argb)
		{
			return FromInt32(argb);
		}

		public static Color FromRgb(byte r, byte g, byte b)
		{
			return new Color(byte.MaxValue, r, g, b);
		}

		public static Color FromArgb(byte a, byte r, byte g, byte b)
		{
			return new Color(a, r, g, b);
		}

		public static Color FromInt32(int argb)
		{
			return new Color((byte)(argb >> 24), (byte)(argb >> 16), (byte)(argb >> 8), (byte)argb);
		}

		public static Color FromHtml(ReadOnlySpan<char> hexValue)
		{
			hexValue = hexValue.TrimStart('#');
			int length = hexValue.Length;
			int num = int.Parse(hexValue, NumberStyles.HexNumber);
			switch (length)
			{
			case 3:
				return FromInt32(-16777216 | (num & 0xF) | ((num & 0xF) << 4) | ((num & 0xF0) << 4) | ((num & 0xF0) << 8) | ((num & 0xF00) << 8) | ((num & 0xF00) << 12));
			case 4:
				return FromInt32(((num & 0xF) << 24) | ((num & 0xF) << 28) | ((num & 0xF0) >> 4) | (num & 0xF0) | (num & 0xF00) | ((num & 0xF00) << 4) | ((num & 0xF000) << 4) | ((num & 0xF000) << 8));
			case 6:
				return FromInt32(-16777216 | num);
			case 8:
				return FromInt32(((num & 0xFF) << 24) | (num >> 8));
			default:
				Should.BeValid(validation: false, "hexValue");
				return default(Color);
			}
		}

		public override string ToString()
		{
			return $"#{A:X2}{R:X2}{G:X2}{B:X2}";
		}

		public Color WithAlpha(float factor)
		{
			Should.BeValid(factor <= 1f && factor >= 0f, "factor");
			return this with
			{
				A = (byte)((float)(int)A * factor)
			};
		}

		public int ToInt32()
		{
			return (A << 24) | (R << 16) | (G << 8) | B;
		}
	}
	public readonly record struct CornerRadius(float TopLeft, float TopRight, float BottomRight, float BottomLeft)
	{
		public bool IsUniform
		{
			get
			{
				if (TopLeft == TopRight && TopRight == BottomRight)
				{
					return BottomRight == BottomLeft;
				}
				return false;
			}
		}

		public static CornerRadius Zero => default(CornerRadius);

		public static CornerRadius Uniform(float radius)
		{
			return new CornerRadius(radius, radius, radius, radius);
		}

		public static CornerRadius Get(float topLeft = 0f, float topRight = 0f, float bottomRight = 0f, float bottomLeft = 0f)
		{
			return new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
		}

		public bool ApproximatelyEquals(CornerRadius other, float eps = 0.5f)
		{
			if (Math.Abs(TopLeft - other.TopLeft) <= eps && Math.Abs(TopRight - other.TopRight) <= eps && Math.Abs(BottomRight - other.BottomRight) <= eps)
			{
				return Math.Abs(BottomLeft - other.BottomLeft) <= eps;
			}
			return false;
		}
	}
	public readonly record struct FontSpec
	{
		public string Family { get; init; }

		public float Size { get; init; }

		public FontWeight Weight => EnumBase<FontWeight, byte>.TryGet(_weight, FontWeight.Regular);

		public FontStyle Style => EnumBase<FontStyle, byte>.TryGet(_style, FontStyle.Normal);

		public bool IsSystem => string.IsNullOrEmpty(Family);

		private readonly byte _weight;

		private readonly byte _style;

		public FontSpec(string? family, float size, FontWeight? weight = null, FontStyle? style = null)
		{
			Family = family ?? "";
			Size = size;
			_weight = (weight ?? FontWeight.Regular).Value;
			_style = (style ?? FontStyle.Normal).Value;
		}

		public static FontSpec System(float size = 0f, FontWeight? weight = null, FontStyle? style = null)
		{
			return new FontSpec("", size, weight, style);
		}

		public override string ToString()
		{
			return $"{(IsSystem ? "System" : Family)} {Weight.Name} {Style.Name} {Size:0.#}";
		}

		public FontSpec WithFamily(string? family)
		{
			return new FontSpec(family, Size, Weight, Style);
		}

		public FontSpec WithSize(float size)
		{
			return new FontSpec(Family, size, Weight, Style);
		}

		public FontSpec WithWeight(FontWeight? weight)
		{
			return new FontSpec(Family, Size, weight, Style);
		}

		public FontSpec WithStyle(FontStyle? style)
		{
			return new FontSpec(Family, Size, Weight, style);
		}

		public void Deconstruct(out string family, out float size, out FontWeight weight, out FontStyle style)
		{
			family = Family;
			size = Size;
			weight = Weight;
			style = Style;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Family = ");
			builder.Append((object?)Family);
			builder.Append(", Size = ");
			builder.Append(Size.ToString());
			builder.Append(", Weight = ");
			builder.Append(Weight);
			builder.Append(", Style = ");
			builder.Append(Style);
			builder.Append(", IsSystem = ");
			builder.Append(IsSystem.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<byte>.Default.GetHashCode(_weight) * -1521134295 + EqualityComparer<byte>.Default.GetHashCode(_style)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Family)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Size);
		}

		[CompilerGenerated]
		public bool Equals(FontSpec other)
		{
			if (EqualityComparer<byte>.Default.Equals(_weight, other._weight) && EqualityComparer<byte>.Default.Equals(_style, other._style) && EqualityComparer<string>.Default.Equals(Family, other.Family))
			{
				return EqualityComparer<float>.Default.Equals(Size, other.Size);
			}
			return false;
		}
	}
	public readonly record struct FormattedText : IConvertible<FormattedText>, IHasInitializedState
	{
		public bool IsInitialized => _format > 0;

		public TextFormat? Format => EnumBase<TextFormat, byte>.TryGet(_format);

		public object? Value
		{
			get
			{
				if (_getValue != null)
				{
					return _getValue(_value);
				}
				return _value;
			}
		}

		public string? ValueString => Value as string;

		private readonly byte _format;

		private readonly object? _value;

		private readonly Func<object?, object?>? _getValue;

		public FormattedText(TextFormat format, object? value, Func<object?, object?>? getValue = null)
		{
			Should.NotBeNull(format, "format");
			_format = format.Value;
			_value = value;
			_getValue = getValue;
		}

		public static implicit operator FormattedText(string? value)
		{
			if (value != null)
			{
				return new FormattedText(TextFormat.Raw, value);
			}
			return default(FormattedText);
		}

		public static FormattedText Html(string? value)
		{
			return new FormattedText(TextFormat.Html, value);
		}

		public static FormattedText Markdown(string? value)
		{
			return new FormattedText(TextFormat.Markdown, value);
		}

		public override string ToString()
		{
			return Value?.ToString() ?? "";
		}

		bool IConvertible<FormattedText>.TryConvertFrom<TFrom>(TFrom from, out FormattedText to)
		{
			to = from?.ToString();
			return true;
		}

		bool IConvertible<FormattedText>.TryConvertTo<TTo>(FormattedText from, out TTo to)
		{
			if (Value is TTo val)
			{
				to = val;
				return true;
			}
			to = default(TTo);
			return false;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("IsInitialized = ");
			builder.Append(IsInitialized.ToString());
			builder.Append(", Format = ");
			builder.Append(Format);
			builder.Append(", Value = ");
			builder.Append(Value);
			builder.Append(", ValueString = ");
			builder.Append((object?)ValueString);
			return true;
		}
	}
	public readonly record struct ImageRenderOptions
	{
		public ImageTintBehavior Tint => EnumBase<ImageTintBehavior, byte>.Get(_tint);

		public readonly TransitionOptions Transition;

		private readonly byte _tint;

		public ImageRenderOptions(ImageTintBehavior? tint = null, TransitionOptions transition = default(TransitionOptions))
		{
			Transition = transition;
			_tint = tint?.Value ?? 0;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Transition = ");
			builder.Append(Transition.ToString());
			builder.Append(", Tint = ");
			builder.Append(Tint);
			return true;
		}
	}
	public readonly record struct ImageSource : IHasInitializedState
	{
		public ImageSourceType ImageSourceType => EnumBase<MugenMvvm.CompositeUI.Enums.ImageSourceType, byte>.TryGet(_type, MugenMvvm.CompositeUI.Enums.ImageSourceType.None);

		public bool IsInitialized => _type > 0;

		public readonly int ResourceId;

		public readonly object? Data;

		public readonly ImageRenderOptions Options;

		private readonly byte _type;

		public ImageSource(ImageSourceType imageSourceType, object? data, int resourceId, ImageRenderOptions options = default(ImageRenderOptions))
		{
			Should.NotBeNull(imageSourceType, "imageSourceType");
			Should.BeValid(data != null || resourceId != 0, "data");
			Options = options;
			_type = imageSourceType.Value;
			Data = data;
			ResourceId = resourceId;
		}

		public static implicit operator ImageSource(string? value)
		{
			if (value != null)
			{
				return new ImageSource(MugenMvvm.CompositeUI.Enums.ImageSourceType.Url, value, 0);
			}
			return default(ImageSource);
		}

		public static implicit operator MediaSource(ImageSource s)
		{
			return new MediaSource(s.ImageSourceType.MediaSourceType, s.Data, s.ResourceId, s.Options);
		}

		public static ImageSource Resource(int resourceId, bool isImage)
		{
			return new ImageSource(MugenMvvm.CompositeUI.Enums.ImageSourceType.Resource, "", resourceId, new ImageRenderOptions(isImage ? ImageTintBehavior.IgnoreTint : ImageTintBehavior.ForceTint));
		}

		public static ImageSource Resource(string resourceId, bool isImage)
		{
			return new ImageSource(MugenMvvm.CompositeUI.Enums.ImageSourceType.Resource, resourceId, 0, new ImageRenderOptions(isImage ? ImageTintBehavior.IgnoreTint : ImageTintBehavior.ForceTint));
		}

		public static ImageSource Qr(string value)
		{
			return new ImageSource(MugenMvvm.CompositeUI.Enums.ImageSourceType.Qr, value, 0);
		}

		public static ImageSource Url(string? value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				return new ImageSource(MugenMvvm.CompositeUI.Enums.ImageSourceType.Url, value, 0);
			}
			return default(ImageSource);
		}

		public override string ToString()
		{
			return $"{ImageSourceType}:{Data ?? "empty"}";
		}

		public ImageSource WithOptions(ImageRenderOptions options)
		{
			return new ImageSource(ImageSourceType, Data, ResourceId, options);
		}

		public ImageSource GetValueOrDefault(ImageSource defaultValue)
		{
			if (_type != 0)
			{
				return this;
			}
			return defaultValue;
		}

		public bool TryGet<TIcon>([NotNullWhen(true)] out TIcon? icon) where TIcon : class
		{
			icon = MugenExtensions.TryUnwrap<object, TIcon>(Data);
			return icon != null;
		}

		public MediaSource ToMedia()
		{
			return this;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("ResourceId = ");
			builder.Append(ResourceId.ToString());
			builder.Append(", Data = ");
			builder.Append(Data);
			builder.Append(", Options = ");
			builder.Append(Options.ToString());
			builder.Append(", ImageSourceType = ");
			builder.Append(ImageSourceType);
			builder.Append(", IsInitialized = ");
			builder.Append(IsInitialized.ToString());
			return true;
		}
	}
	public readonly record struct MediaSource : IHasInitializedState
	{
		public MediaSourceType MediaType => EnumBase<MediaSourceType, byte>.TryGet(_type, MediaSourceType.None);

		public bool IsInitialized => _type > 0;

		public readonly int ResourceId;

		public readonly object? Data;

		public readonly ImageRenderOptions Options;

		public readonly object? ExtraOptions;

		private readonly byte _type;

		public MediaSource(MediaSourceType mediaType, object? data, int resourceId, ImageRenderOptions options = default(ImageRenderOptions), object? extraOptions = null)
		{
			Should.NotBeNull(mediaType, "mediaType");
			Should.BeValid(data != null || resourceId != 0, "data");
			_type = mediaType.Value;
			Data = data;
			ResourceId = resourceId;
			Options = options;
			ExtraOptions = extraOptions;
		}

		public static MediaSource VideoUrl(string url, object? extra = null, ImageRenderOptions options = default(ImageRenderOptions))
		{
			return new MediaSource(MediaSourceType.VideoUrl, url, 0, options, extra);
		}

		public static MediaSource VideoResource(int resourceId, object? extra = null, ImageRenderOptions options = default(ImageRenderOptions))
		{
			return new MediaSource(MediaSourceType.VideoResource, "", resourceId, options, extra);
		}

		public static MediaSource ModelUrl(string url, object? extra = null, ImageRenderOptions options = default(ImageRenderOptions))
		{
			return new MediaSource(MediaSourceType.ModelUrl, url, 0, options, extra);
		}

		public static MediaSource ModelResource(string name, object? extra = null, ImageRenderOptions options = default(ImageRenderOptions))
		{
			return new MediaSource(MediaSourceType.ModelResource, name, 0, options, extra);
		}

		public override string ToString()
		{
			return $"{MediaType}:{Data ?? ((ResourceId != 0) ? ResourceId.ToString() : "empty")}";
		}

		public MediaSource WithOptions(ImageRenderOptions options)
		{
			return new MediaSource(MediaType, Data, ResourceId, options, ExtraOptions);
		}

		public MediaSource WithExtraOptions(object? extra)
		{
			return new MediaSource(MediaType, Data, ResourceId, Options, extra);
		}

		public MediaSource GetValueOrDefault(MediaSource defaultValue)
		{
			if (_type != 0)
			{
				return this;
			}
			return defaultValue;
		}

		public bool TryGet<TData>([NotNullWhen(true)] out TData? value) where TData : class
		{
			value = MugenExtensions.TryUnwrap<object, TData>(Data);
			return value != null;
		}

		public bool TryGetOptions<TExtra>([NotNullWhen(true)] out TExtra? extra) where TExtra : class
		{
			extra = MugenExtensions.TryUnwrap<object, TExtra>(ExtraOptions);
			return extra != null;
		}

		public bool TryToImage(out ImageSource image)
		{
			MediaSourceType mediaType = MediaType;
			if (!mediaType.Flags.HasFlag(MediaSourceFlags.Image))
			{
				image = default(ImageSource);
				return false;
			}
			ImageSourceType imageSourceType = EnumBase<ImageSourceType, byte>.TryGet(mediaType.Value, ImageSourceType.None);
			if (imageSourceType == ImageSourceType.None)
			{
				image = default(ImageSource);
				return false;
			}
			image = new ImageSource(imageSourceType, Data, ResourceId, Options);
			return true;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("ResourceId = ");
			builder.Append(ResourceId.ToString());
			builder.Append(", Data = ");
			builder.Append(Data);
			builder.Append(", Options = ");
			builder.Append(Options.ToString());
			builder.Append(", ExtraOptions = ");
			builder.Append(ExtraOptions);
			builder.Append(", MediaType = ");
			builder.Append(MediaType);
			builder.Append(", IsInitialized = ");
			builder.Append(IsInitialized.ToString());
			return true;
		}
	}
	public struct ModifierSet : IEquatable<ModifierSet>, IHasReadOnlySpan<ISectionModifier>
	{
		private object? _data;

		public readonly ReadOnlySpan<ISectionModifier> ReadOnlySpan
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (_data is ISectionModifier)
				{
					return MemoryMarshal.CreateReadOnlySpan(in Unsafe.As<object, ISectionModifier>(ref Unsafe.AsRef(in _data)), 1);
				}
				return new ReadOnlySpan<ISectionModifier>((ISectionModifier[])_data);
			}
		}

		public ModifierSet(ISectionModifier? modifier)
		{
			_data = modifier;
		}

		public ModifierSet(ISectionModifier[]? modifiers)
		{
			if (modifiers != null && modifiers.Length == 1)
			{
				_data = modifiers[0];
			}
			else
			{
				_data = modifiers;
			}
		}

		private ModifierSet(object? data)
		{
			_data = data;
		}

		public static bool operator ==(ModifierSet left, ModifierSet right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(ModifierSet left, ModifierSet right)
		{
			return !left.Equals(right);
		}

		public static implicit operator ModifierSet(ISectionModifier[]? items)
		{
			return new ModifierSet(items);
		}

		public override readonly bool Equals(object? obj)
		{
			if (obj is ModifierSet other)
			{
				return Equals(other);
			}
			return false;
		}

		public override readonly int GetHashCode()
		{
			if (_data == null)
			{
				return 0;
			}
			return _data.GetHashCode();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly ReadOnlySpan<ISectionModifier>.Enumerator GetEnumerator()
		{
			return ReadOnlySpan.GetEnumerator();
		}

		public bool Update<TState>(IVisualSection owner, ModifierMutator<TState> mutator, ModifierCleanup<TState>? cleanup, ref TState state)
		{
			object data;
			object data2;
			while (true)
			{
				data = _data;
				data2 = mutator(new ModifierSet(data), ref state)._data;
				if (data2 == data)
				{
					return false;
				}
				if (Interlocked.CompareExchange(ref _data, data2, data) == data)
				{
					break;
				}
				cleanup?.Invoke(new ModifierSet(data2), ref state);
			}
			DiffNotify(owner, new ModifierSet(data), new ModifierSet(data2));
			return true;
		}

		public readonly bool Equals(ModifierSet other)
		{
			return object.Equals(_data, other._data);
		}

		internal readonly void OnDispose(IVisualSection section)
		{
			ReadOnlySpan<ISectionModifier> readOnlySpan = ReadOnlySpan;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				(readOnlySpan[i] as IAttachableSectionModifier)?.OnDetached(section);
			}
		}

		private static void DiffNotify(IVisualSection owner, ModifierSet oldSet, ModifierSet newSet)
		{
			using PooledDictionarySlim<object, object> pooledDictionarySlim = new PooledDictionarySlim<object, object>(ReferenceEqualityComparer.Instance);
			ReadOnlySpan<ISectionModifier> readOnlySpan = oldSet.ReadOnlySpan;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ISectionModifier sectionModifier = readOnlySpan[i];
				if (sectionModifier is IAttachableSectionModifier)
				{
					pooledDictionarySlim.GetOrAddValueRef(sectionModifier);
				}
			}
			readOnlySpan = newSet.ReadOnlySpan;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ISectionModifier sectionModifier2 = readOnlySpan[i];
				if (sectionModifier2 is IAttachableSectionModifier attachableSectionModifier && !pooledDictionarySlim.Remove(sectionModifier2))
				{
					attachableSectionModifier.OnAttached(owner);
				}
			}
			foreach (KeyValuePair<object, object> item in pooledDictionarySlim)
			{
				((IAttachableSectionModifier)item.Key).OnDetached(owner);
			}
		}
	}
	public readonly record struct ScreenMetrics(float DpWidth, float DpHeight, float Scale)
	{
		public readonly record struct LayoutMetrics(BreakpointType Breakpoint, float ScreenWidth, float GridMargin, float BodyWidth, int GridColumns, float GridGutter, float ColumnWidth, float? ContainerMaxWidth, Thickness Margins)
		{
			public Thickness HorizontalMargins
			{
				get
				{
					Thickness margins = Margins;
					return Thickness.Get(margins.Left, 0f, margins.Right);
				}
			}

			public float WidthForColumns(int span)
			{
				return WidthForColumns(span, in this);
			}

			private static float WidthForColumns(int span, in LayoutMetrics l)
			{
				if (span > 0)
				{
					return (float)span * l.ColumnWidth + (float)(span - 1) * l.GridGutter;
				}
				return 0f;
			}
		}

		public readonly record struct ToolbarMetrics(int MaxActionsPrimary, float IconSize, float IconPadding, float SlotWidth, float Height, float EdgeMargin, float TitleMargin)
		{
			public float SlotEdgeMargin => MathF.Max(0f, EdgeMargin - (SlotWidth - IconSize) * 0.5f);

			public float TitleStartMargin => TitleMargin - (EdgeMargin + SlotWidth);

			public float TitleEndMargin => 16f;
		}

		public int PxWidth => (int)MathF.Round(DpWidth * Scale);

		public int PxHeight => (int)MathF.Round(DpHeight * Scale);

		public float OnePxDp => 1f / Scale;

		public WindowSizeClassType WidthClass => WindowSizeClassType.FromWidthDp(DpWidth);

		public WindowSizeClassType HeightClass => WindowSizeClassType.FromHeightDp(DpHeight);

		public ViewportOrientationType Orientation
		{
			get
			{
				if (!(DpWidth >= DpHeight))
				{
					return ViewportOrientationType.Portrait;
				}
				return ViewportOrientationType.Landscape;
			}
		}

		public BreakpointType Breakpoint => ResolveBreakpoint(DpWidth, WidthClass);

		public LayoutMetrics Layout => ComputeLayout(DpWidth, Breakpoint);

		public ToolbarMetrics Toolbar
		{
			get
			{
				LayoutMetrics layout = Layout;
				float num = Clamp(layout.BodyWidth * 0.25f, 88f, 240f);
				float num2 = MathF.Max(0f, layout.BodyWidth - num - 48f);
				int maxActionsPrimary = ClampInt(max: (layout.Breakpoint == BreakpointType.Xs) ? 3 : ((layout.Breakpoint == BreakpointType.Sm) ? 4 : ((layout.Breakpoint == BreakpointType.Lg) ? 6 : 5)), v: (int)MathF.Floor(num2 / 48f), min: 0);
				bool flag = layout.Breakpoint == BreakpointType.Xs || layout.Breakpoint == BreakpointType.Sm;
				return new ToolbarMetrics(maxActionsPrimary, 24f, 12f, 48f, flag ? 56f : 64f, flag ? 16f : 24f, flag ? 72f : 80f);
			}
		}

		private const float MarginXs = 16f;

		private const float MarginSm = 32f;

		private const float MaxMargin = 200f;

		private const float BodySmWide = 840f;

		private const float BodyLg = 1040f;

		private const float GutterCompact = 16f;

		private const float GutterExpanded = 24f;

		private const float Hit = 48f;

		private const float TopBarCompactHeight = 56f;

		private const float TopBarHeight = 64f;

		private const float TopBarIconSize = 24f;

		private const float TopBarSlotSize = 48f;

		private const float TopBarIconPadding = 12f;

		private const float TopBarEdgeMarginS = 16f;

		private const float TopBarEdgeMargin = 24f;

		private const float TopBarTitleMarginS = 72f;

		private const float TopBarTitleMargin = 80f;

		private static BreakpointType ResolveBreakpoint(float widthDp, WindowSizeClassType widthClass)
		{
			if (widthClass == WindowSizeClassType.Expanded)
			{
				if (widthDp >= 1440f)
				{
					return BreakpointType.Lg;
				}
				if (widthDp >= 1240f)
				{
					return BreakpointType.Md;
				}
				return BreakpointType.SmWide;
			}
			if (!(widthClass == WindowSizeClassType.Medium))
			{
				return BreakpointType.Xs;
			}
			return BreakpointType.Sm;
		}

		private static LayoutMetrics ComputeLayout(float w, BreakpointType bp)
		{
			switch (bp.Name)
			{
			case "Xs":
			{
				float num5 = MathF.Max(0f, w - 32f);
				float columnWidth5 = ColumnWidth(num5, 4, 16f);
				return new LayoutMetrics(bp, w, 16f, num5, 4, 16f, columnWidth5, null, Thickness.Get(16f, 0f, 16f));
			}
			case "Sm":
			{
				float num4 = MathF.Max(0f, w - 64f);
				float columnWidth4 = ColumnWidth(num4, 8, 16f);
				return new LayoutMetrics(bp, w, 32f, num4, 8, 16f, columnWidth4, null, Thickness.Get(32f, 0f, 32f));
			}
			case "SmWide":
			{
				float num3 = Clamp((w - 840f) * 0.5f, 32f, 200f);
				float columnWidth3 = ColumnWidth(840f, 12, 24f);
				return new LayoutMetrics(bp, w, num3, 840f, 12, 24f, columnWidth3, 840f, Thickness.Get(num3, 0f, num3));
			}
			case "Md":
			{
				float num2 = MathF.Max(0f, w - 400f);
				float columnWidth2 = ColumnWidth(num2, 12, 24f);
				return new LayoutMetrics(bp, w, 200f, num2, 12, 24f, columnWidth2, null, Thickness.Get(200f, 0f, 200f));
			}
			default:
			{
				float num = MathF.Max(0f, (w - 1040f) * 0.5f);
				float columnWidth = ColumnWidth(1040f, 12, 24f);
				return new LayoutMetrics(bp, w, num, 1040f, 12, 24f, columnWidth, 1040f, Thickness.Get(num, 0f, num));
			}
			}
		}

		private static float ColumnWidth(float body, int cols, float gutter)
		{
			if (cols > 0)
			{
				return MathF.Max(0f, (body - (float)(cols - 1) * gutter) / (float)cols);
			}
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float Clamp(float v, float min, float max)
		{
			if (!(v < min))
			{
				if (!(v > max))
				{
					return v;
				}
				return max;
			}
			return min;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ClampInt(int v, int min, int max)
		{
			if (v >= min)
			{
				if (v <= max)
				{
					return v;
				}
				return max;
			}
			return min;
		}
	}
	public readonly record struct SizeF(float Width, float Height)
	{
		public static SizeF MatchParentMatchParent => new SizeF(-1f, -1f);

		public static SizeF MatchParentWrapContent => new SizeF(-1f, -2f);

		public static SizeF WrapContentMatchParent => new SizeF(-2f, -1f);

		public static SizeF WrapContentWrapContent => new SizeF(-2f, -2f);

		public bool IsUniform => Width == Height;

		public static SizeF Zero => new SizeF(0f, 0f);

		public const float MatchParent = -1f;

		public const float WrapContent = -2f;

		public static SizeF Get(float width, float height)
		{
			return new SizeF(width, height);
		}

		public static SizeF Square(float side)
		{
			return new SizeF(side, side);
		}

		public SizeF With(float? width = null, float? height = null)
		{
			return new SizeF(width ?? Width, height ?? Height);
		}

		public SizeF Scale(float k)
		{
			return new SizeF(Width * k, Height * k);
		}

		public bool ApproximatelyEquals(SizeF other, float eps = 0.5f)
		{
			if (Math.Abs(Width - other.Width) <= eps)
			{
				return Math.Abs(Height - other.Height) <= eps;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Width, Height);
		}

		public static SizeF operator +(SizeF a, SizeF b)
		{
			return new SizeF(a.Width + b.Width, a.Height + b.Height);
		}

		public static SizeF operator -(SizeF a, SizeF b)
		{
			return new SizeF(a.Width - b.Width, a.Height - b.Height);
		}

		public static SizeF operator *(SizeF a, float k)
		{
			return a.Scale(k);
		}

		public static SizeF operator /(SizeF a, float k)
		{
			return new SizeF(a.Width / k, a.Height / k);
		}

		public override string ToString()
		{
			return $"{Width}×{Height}";
		}
	}
	public readonly record struct SizeLimits
	{
		public static SizeLimits Unbounded => new SizeLimits(null, null, null, null);

		public readonly float? MinWidth;

		public readonly float? MinHeight;

		public readonly float? MaxWidth;

		public readonly float? MaxHeight;

		public SizeLimits(float? MinWidth, float? MinHeight, float? MaxWidth, float? MaxHeight)
		{
			this.MinWidth = MinWidth;
			this.MinHeight = MinHeight;
			this.MaxWidth = MaxWidth;
			this.MaxHeight = MaxHeight;
		}

		public static SizeLimits AtLeast(float minWidth, float minHeight)
		{
			return new SizeLimits(minWidth, minHeight, null, null);
		}

		public static SizeLimits AtMost(float maxWidth, float maxHeight)
		{
			return new SizeLimits(null, null, maxWidth, maxHeight);
		}

		public static SizeLimits Get(float? minWidth = null, float? minHeight = null, float? maxWidth = null, float? maxHeight = null)
		{
			return new SizeLimits(minWidth, minHeight, maxWidth, maxHeight);
		}

		public SizeLimits With(float? minWidth = null, float? minHeight = null, float? maxWidth = null, float? maxHeight = null)
		{
			return new SizeLimits(minWidth ?? MinWidth, minHeight ?? MinHeight, maxWidth ?? MaxWidth, maxHeight ?? MaxHeight);
		}

		[CompilerGenerated]
		public void Deconstruct(out float? MinWidth, out float? MinHeight, out float? MaxWidth, out float? MaxHeight)
		{
			MinWidth = this.MinWidth;
			MinHeight = this.MinHeight;
			MaxWidth = this.MaxWidth;
			MaxHeight = this.MaxHeight;
		}
	}
	public readonly record struct Thickness(float Left, float Top, float Right, float Bottom)
	{
		public float Horizontal => Left + Right;

		public float Vertical => Top + Bottom;

		public bool IsZero
		{
			get
			{
				if (Left.Equals(0f) && Top.Equals(0f) && Right.Equals(0f))
				{
					return Bottom.Equals(0f);
				}
				return false;
			}
		}

		public static readonly Thickness Zero;

		public static implicit operator Thickness(float all)
		{
			return Uniform(all);
		}

		public static Thickness operator +(Thickness a, Thickness b)
		{
			return new Thickness(a.Left + b.Left, a.Top + b.Top, a.Right + b.Right, a.Bottom + b.Bottom);
		}

		public static Thickness operator -(Thickness a, Thickness b)
		{
			return new Thickness(a.Left - b.Left, a.Top - b.Top, a.Right - b.Right, a.Bottom - b.Bottom);
		}

		public static Thickness Get(float left = 0f, float top = 0f, float right = 0f, float bottom = 0f)
		{
			return new Thickness(left, top, right, bottom);
		}

		public static Thickness Uniform(float all)
		{
			return new Thickness(all, all, all, all);
		}

		public static Thickness Symmetric(float horizontal, float vertical)
		{
			return new Thickness(horizontal, vertical, horizontal, vertical);
		}

		public void Deconstruct(out float left, out float top, out float right, out float bottom)
		{
			float left2 = Left;
			float top2 = Top;
			float right2 = Right;
			float bottom2 = Bottom;
			left = left2;
			top = top2;
			right = right2;
			bottom = bottom2;
		}
	}
	internal sealed class ToolbarMenuItemsClosure : IDisposable
	{
		private readonly HashSet<object> _visibleItems = new HashSet<object>(ReferenceEqualityComparer.Instance);

		private Disposable<IVisualSection> _moreSection;

		private LimitCollectionDecoratorBase _limitDecorator;

		private HeaderFooterCollectionDecorator _headerFooterDecorator;

		private IReadOnlyObservableCollection<IVisualSection> _hiddenItems;

		private ActionToken _token;

		private bool _hasHidden;

		private int _count;

		private int _countVisible;

		private int _limitRaw;

		private int _state;

		public int CountVisible
		{
			get
			{
				return _countVisible;
			}
			set
			{
				if (value != _countVisible)
				{
					_countVisible = value;
					Invalidate();
				}
			}
		}

		public int Count
		{
			get
			{
				return _count;
			}
			set
			{
				if (value != _count)
				{
					_count = value;
					Invalidate();
				}
			}
		}

		public bool HasHidden
		{
			get
			{
				return _hasHidden;
			}
			set
			{
				if (value != _hasHidden)
				{
					_hasHidden = value;
					Invalidate();
				}
			}
		}

		private int LimitRaw
		{
			get
			{
				return _limitRaw;
			}
			set
			{
				if (value != _limitRaw)
				{
					_limitRaw = value;
					Invalidate();
				}
			}
		}

		private bool HasLimit => Count + CountVisible > LimitRaw;

		public static void OnAdded(TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure> state, IVisualSection item)
		{
			state.State._visibleItems.Add(item);
			state.State._hiddenItems.RaiseItemChanged(item);
		}

		public static void OnRemoved(TrackerCollectionDecorator<IVisualSection, IVisualSection, IVisualSection, ToolbarMenuItemsClosure> state, IVisualSection item)
		{
			state.State._visibleItems.Remove(item);
			state.State._hiddenItems.RaiseItemChanged(item);
		}

		public bool IsHidden(object section)
		{
			return !_visibleItems.Contains(section);
		}

		public IReadOnlyObservableCollection<IVisualSection> Initialize(Bindable<int> limit, Disposable<IVisualSection> source, LimitCollectionDecoratorBase limitDecorator, HeaderFooterCollectionDecorator headerFooterDecorator, IReadOnlyObservableCollection<IVisualSection> hiddenItems)
		{
			_moreSection = source;
			_limitDecorator = limitDecorator;
			_headerFooterDecorator = headerFooterDecorator;
			_hiddenItems = hiddenItems;
			_token = limit.BindSafe(source.Target, this, delegate(int i, ToolbarMenuItemsClosure c)
			{
				c.LimitRaw = i;
			});
			return _hiddenItems;
		}

		public void Dispose()
		{
			_moreSection.Dispose();
			_hiddenItems.Dispose();
			_token.Dispose();
		}

		private void Invalidate()
		{
			int num;
			do
			{
				num = Interlocked.Increment(ref _state);
				bool flag = HasHidden || HasLimit;
				int num2 = Math.Max(LimitRaw - CountVisible, 0);
				if (flag && num2 != 0)
				{
					num2--;
				}
				_limitDecorator.Limit = num2;
				_headerFooterDecorator.SetFooter(flag ? ((ItemOrIReadOnlyList<object>)(object?)_moreSection.Target) : default(ItemOrIReadOnlyList<object>));
			}
			while (num != _state);
		}
	}
	public readonly record struct TransitionOptions
	{
		public EnumFlags<ImageTransitionFlags> Kind => new EnumFlags<ImageTransitionFlags>(_kind);

		private readonly byte _kind;

		public readonly ushort Duration;

		public TransitionOptions(EnumFlags<ImageTransitionFlags> kind = default(EnumFlags<ImageTransitionFlags>), ushort duration = 0)
		{
			_kind = kind.Value((byte)0);
			Duration = duration;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Duration = ");
			builder.Append(Duration.ToString());
			builder.Append(", Kind = ");
			builder.Append(Kind.ToString());
			return true;
		}
	}
}
namespace MugenMvvm.CompositeUI.Common.Interfaces
{
	public interface ILoadMoreBusyMessage
	{
	}
	public interface IRefreshBusyMessage
	{
	}
}
namespace MugenMvvm.CompositeUI.Commands
{
	public sealed class AppActionInvokerCommandDecorator : IApiHandlerDecorator<ICompositeCommand, ExecuteCommandRequest, ValueTask<bool?>>, ISingleAttachableDecorator<ICompositeCommand, IApiProviderComponent<ICompositeCommand>, ExecuteCommandRequest>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<ICompositeCommand>, IAttachableComponent<ICompositeCommand>, IComponent<ICompositeCommand>, IComponent, IApiHandlerComponent<ICompositeCommand, ExecuteCommandRequest, ValueTask<bool?>>, IApiHandlerComponent<ICompositeCommand>, IApiProviderComponent<ICompositeCommand>, IApiProviderComponent, ISupportRequestComponent<ICompositeCommand>, ISupportApiHandlerComponent<ICompositeCommand, ExecuteCommandRequest>
	{
		private sealed class RetryImpl : IAppErrorRetryHandler
		{
			private readonly ExecuteCommandRequest _request;

			private readonly AppActionInvokerCommandDecorator _decorator;

			public object? ErrorSource => _decorator.Owner;

			public RetryImpl(ExecuteCommandRequest request, AppActionInvokerCommandDecorator decorator)
			{
				_request = request;
				_decorator = decorator;
			}

			public ValueTask<bool?> RetryAsync(IAppErrorInfo error, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				ICompositeCommand owner = _decorator.Owner;
				if (owner == null || !IMugenService<IMugenApplication>.Instance.OnCancelAppError(error, metadata))
				{
					return default(ValueTask<bool?>);
				}
				return _decorator.ExecuteAsync(_request, owner, this, metadata, cancellationToken);
			}
		}

		public readonly string ActionId = "a" + Default.NextCounter();

		public ApiProviderDecoratedComponents<ICompositeCommand, ExecuteCommandRequest, ValueTask<bool?>> Components { get; set; }

		public int Priority { get; init; } = 1073741723;

		public ICompositeCommand? Owner { get; set; }

		public ValueTask<bool?> TryInvoke(ExecuteCommandRequest request, ICompositeCommand apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return ExecuteAsync(request, apiProvider, null, metadata, cancellationToken);
		}

		private async ValueTask<bool?> ExecuteAsync(ExecuteCommandRequest request, ICompositeCommand command, RetryImpl? retryHandler, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			string actionId = ((command.GetComponents<ISingleExecutionCommandHandler>().Count == 0) ? null : ActionId);
			ICompositeMetadataContext metadataOptional = command.MetadataOptional;
			object source = metadataOptional.Get(CompositeUIMetadata.ActionInvokerSourceProviderCommand)?.Invoke(command, metadata) ?? metadataOptional.Get(CompositeUIMetadata.ActionInvokerSourceCommand) ?? this;
			try
			{
				if (actionId != null)
				{
					IMugenService<IMugenApplication>.Instance.OnCancelAppErrorById(source, actionId);
				}
				bool? flag = await Components.TryInvoke(request, command, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return (retryHandler == null) ? flag : new bool?(true);
			}
			catch (Exception exception)
			{
				await IMugenService<IMugenApplication>.Instance.OnAppErrorAsync(source, exception, actionId, retryHandler ?? new RetryImpl(request, this), metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				return false;
			}
		}
	}
	public sealed class AppActionInvokerCommandProvider : IApiHandlerDecorator<IMugenApplication, CommandRequest, ICompositeCommand>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, CommandRequest>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, CommandRequest, ICompositeCommand>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, CommandRequest>
	{
		public ApiProviderDecoratedComponents<IMugenApplication, CommandRequest, ICompositeCommand> Components { get; set; }

		public int Priority { get; init; } = 100;

		public IMugenApplication? Owner { get; set; }

		public ICompositeCommand? TryInvoke(CommandRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			ICompositeCommand compositeCommand = Components.TryInvoke(request, apiProvider, metadata, cancellationToken);
			if (compositeCommand != null)
			{
				if (request.Owner != null)
				{
					compositeCommand.Metadata.Set(CompositeUIMetadata.ActionInvokerSourceCommand, request.Owner);
				}
				compositeCommand.AddComponent(new AppActionInvokerCommandDecorator());
			}
			return compositeCommand;
		}
	}
	public sealed class DefaultCommandBusySectionHandler : IApiHandlerComponent<IMugenApplication, GetCommandBusySectionHandlerRequest, IComponent<ICompositeCommand>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetCommandBusySectionHandlerRequest>, IHasPriority
	{
		private sealed class RefreshMessage : IRefreshBusyMessage
		{
		}

		private sealed class LoadMoreMessage : ILoadMoreBusyMessage
		{
		}

		public int Priority => -2147483638;

		public IComponent<ICompositeCommand>? TryInvoke(GetCommandBusySectionHandlerRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.Type == CommandBusyHandlerType.Refresh)
			{
				return GetHandler(request.BusyManager, new RefreshMessage());
			}
			if (request.Type == CommandBusyHandlerType.LoadMore)
			{
				return GetHandler(request.BusyManager, new LoadMoreMessage());
			}
			return null;
		}

		private BusyCommandHandler GetHandler(IBusyManager busyManager, object message)
		{
			return BusyCommandHandler.Get(busyManager, message, (ICompositeCommand _, object m, IReadOnlyMetadataContext? _) => (0, 0, m));
		}
	}
}
namespace MugenMvvm.CompositeUI.Bindings
{
	internal abstract class ErrorHandlerBindableListener : IDisposable, IAppErrorRetryHandler
	{
		private readonly object _source;

		private readonly string _actionId;

		private IDisposable? _currentListener;

		public abstract object? ErrorSource { get; }

		protected bool IsDisposed => _currentListener == this;

		protected ErrorHandlerBindableListener(object source)
		{
			_source = source;
			_actionId = "a" + Default.NextCounter();
		}

		public bool? Subscribe(IAppErrorInfo? error, IReadOnlyMetadataContext? metadata)
		{
			if (error != null && !IMugenService<IMugenApplication>.Instance.OnCancelAppError(error, metadata))
			{
				return null;
			}
			if (IsDisposed)
			{
				return null;
			}
			IDisposable disposable = null;
			try
			{
				disposable = Subscribe();
				IDisposable disposable2;
				do
				{
					disposable2 = Volatile.Read(in _currentListener);
					if (disposable2 == this)
					{
						disposable.Dispose();
						return null;
					}
				}
				while (Interlocked.CompareExchange(ref _currentListener, disposable, disposable2) != disposable2);
				disposable2?.Dispose();
				return true;
			}
			catch (Exception e)
			{
				disposable?.Dispose();
				HandleException(e, BindableErrorType.Unhandled, metadata);
				return false;
			}
		}

		public ValueTask<bool?> RetryAsync(IAppErrorInfo error, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return new ValueTask<bool?>(Subscribe(error, metadata));
		}

		public void Dispose()
		{
			IDisposable disposable = Interlocked.Exchange(ref _currentListener, this);
			if (disposable != this)
			{
				disposable?.Dispose();
				IMugenService<IMugenApplication>.Instance.OnCancelAppErrorById(_source, _actionId);
			}
		}

		[MustDisposeResource]
		protected abstract IDisposable Subscribe();

		protected async void HandleException(Exception e, BindableErrorType errorType, IReadOnlyMetadataContext? metadata)
		{
			try
			{
				if (!errorType.IsBindingError && _source is IVisualSection section)
				{
					section.WithAppErrorListener();
				}
				await IMugenService<IMugenApplication>.Instance.OnAppErrorAsync(_source, e, _actionId, this).ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (Exception exception)
			{
				IMugenService<IMugenApplication>.Instance.OnUnhandledException(exception, UnhandledExceptionType.System, _source, metadata);
			}
		}
	}
	internal sealed class ErrorHandlerBindableListener<T> : ErrorHandlerBindableListener, ISingleFastBindableListener<T>, IFastBindableListener<T>, IBindableListener<T>, IBindableListener, IObserver<T>, IEventListener, IWeakItem, IMemberPathObserverListener
	{
		private readonly Bindable<T> _bindable;

		private readonly IBindableListener<T> _listener;

		private readonly bool _initialSync;

		public override object ErrorSource => ((object)_bindable.Observable) ?? ((object)this);

		public IAccessorMemberInfo? Accessor { get; set; }

		public ErrorHandlerBindableListener(object source, Bindable<T> bindable, IBindableListener<T> listener, bool initialSync)
			: base(source)
		{
			_bindable = bindable;
			_listener = listener;
			_initialSync = initialSync;
		}

		public void OnValue(T value)
		{
			if (!base.IsDisposed)
			{
				_listener.OnValue(value);
			}
		}

		public void OnError(Exception error, BindableErrorType errorType)
		{
			if (!base.IsDisposed)
			{
				HandleException(error, errorType, null);
			}
		}

		public void OnBeginExecuting(object source, BindableExecutionKind kind)
		{
			_listener.OnBeginExecuting(source, kind);
		}

		public void OnEndExecuting(object source, BindableExecutionKind kind)
		{
			_listener.OnEndExecuting(source, kind);
		}

		public void OnCompleted()
		{
			Dispose();
		}

		public void OnDisposed(IMemberPathObserver observer, IReadOnlyMetadataContext? metadata)
		{
			Dispose();
		}

		protected override IDisposable Subscribe()
		{
			return _bindable.Bind(this, _initialSync).ToDisposable();
		}
	}
	internal sealed class SafeBindableWrapper<T> : IBindableProvider<T>, IBindingSourceExpression
	{
		private readonly object _errorSource;

		private readonly object? _expression;

		private readonly T _constant;

		public SafeBindableWrapper(object errorSource, object? expression, T constant)
		{
			Should.NotBeNull(errorSource, "errorSource");
			_errorSource = errorSource;
			_expression = expression;
			_constant = constant;
		}

		public Bindable<T> GetBindable(object source)
		{
			return new Bindable<T>(source, _expression, _constant);
		}

		public ActionToken Bind(object? target, IBindableListener<T> listener, bool initialSync)
		{
			ErrorHandlerBindableListener<T> errorHandlerBindableListener = new ErrorHandlerBindableListener<T>(_errorSource, GetBindable(target), listener, initialSync);
			errorHandlerBindableListener.Subscribe(null, null);
			return ActionToken.FromDisposable(errorHandlerBindableListener);
		}

		public bool TryGet(object? target, ref object source, ref object expression, ref string? rootPath, IReadOnlyMetadataContext? metadata)
		{
			BindingSyntax<object, T> bindingSyntax = GetBindable(source).BindTarget();
			source = bindingSyntax.Target;
			expression = bindingSyntax.Expression;
			return false;
		}
	}
}
namespace MugenMvvm.CompositeUI.Views
{
	internal sealed class ViewBindableMembersDescriptor
	{
		public Color BackgroundColor { get; set; }

		public Color StrokeColor { get; set; }

		public Color TintColor { get; set; }

		public CornerRadius CornerRadii { get; set; }

		internal ImageSource Icon { get; set; }

		internal ImageSource Image { get; set; }

		internal Color TrackTintColor { get; set; }

		internal Color ThumbTintColor { get; set; }

		internal FormattedText FormattedText { get; set; }

		internal OrientationType? Orientation { get; set; }

		internal Alignment? Alignment { get; set; }

		internal Color CursorColor { get; set; }

		internal Color PlaceholderTextColor { get; set; }

		internal FormattedText Placeholder { get; set; }

		internal FontSpec FontSpec { get; set; }

		internal KeyboardType? KeyboardType { get; set; }

		internal ImageStretchMode? StretchMode { get; set; }

		internal Color TextColor { get; set; }

		internal TextAlignment? TextAlignment { get; set; }

		internal Thickness Margin { get; set; }

		internal Thickness Padding { get; set; }

		internal SectionVisibility? Visibility { get; set; }

		private ViewBindableMembersDescriptor()
		{
		}
	}
	public sealed class CompositeUIViewBehavior : IApiHandlerComponent<IViewManager, OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo>, Unit>, IApiHandlerComponent<IViewManager>, IApiProviderComponent<IViewManager>, IApiProviderComponent, IComponent, ISupportRequestComponent<IViewManager>, IComponent<IViewManager>, ISupportApiHandlerComponent<IViewManager, OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo>>, IComponent<IView>, IApiHandlerComponent<IView, HideKeyboardViewRequest, Task>, IApiHandlerComponent<IView>, IApiProviderComponent<IView>, ISupportRequestComponent<IView>, ISupportApiHandlerComponent<IView, HideKeyboardViewRequest>
	{
		public Unit TryInvoke(OnLifecycleChangedRequest<IViewManager, ViewLifecycleState, RawViewInfo> request, IViewManager apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.LifecycleState.IsInState(ViewLifecycleState.Initializing) && request.Target.TryGet<IView>(out IView view))
			{
				view.AddComponent(this);
			}
			return default(Unit);
		}

		public async Task TryInvoke(HideKeyboardViewRequest request, IView apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			await IMugenService<IMugenApplication>.Instance.SwitchToMainAsync();
			if (apiProvider.TryGet<Object>(out Object rawView))
			{
				NativeBindableMemberMugenExtensions.HideKeyboard(rawView);
			}
		}
	}
	[UnconditionalSuppressMessage("Trimming", "IL2072")]
	[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
	public static class CompositeUIViewBaseBindableMembers
	{
		public const string BackgroundColorPropertyName = "BackgroundColor";

		public const string StrokeColorPropertyName = "StrokeColor";

		public const string TintColorPropertyName = "TintColor";

		public const string CornerRadiiPropertyName = "CornerRadii";

		internal const string IconPropertyName = "Icon";

		internal const string ImagePropertyName = "Image";

		internal const string TrackTintColorPropertyName = "TrackTintColor";

		internal const string ThumbTintColorPropertyName = "ThumbTintColor";

		internal const string FormattedTextPropertyName = "FormattedText";

		internal const string OrientationPropertyName = "Orientation";

		internal const string AlignmentPropertyName = "Alignment";

		internal const string CursorColorPropertyName = "CursorColor";

		internal const string PlaceholderTextColorPropertyName = "PlaceholderTextColor";

		internal const string PlaceholderPropertyName = "Placeholder";

		internal const string FontSpecPropertyName = "FontSpec";

		internal const string KeyboardTypePropertyName = "KeyboardType";

		internal const string StretchModePropertyName = "StretchMode";

		internal const string TextColorPropertyName = "TextColor";

		internal const string TextAlignmentPropertyName = "TextAlignment";

		internal const string MarginPropertyName = "Margin";

		internal const string PaddingPropertyName = "Padding";

		internal const string VisibilityPropertyName = "Visibility";

		public static Type TargetType => typeof(View);

		public static Type BackgroundColorPropertyType => typeof(Color);

		public static Type StrokeColorPropertyType => typeof(Color);

		public static Type TintColorPropertyType => typeof(Color);

		public static Type CornerRadiiPropertyType => typeof(CornerRadius);

		internal static Type IconPropertyType => typeof(ImageSource);

		internal static Type ImagePropertyType => typeof(ImageSource);

		internal static Type TrackTintColorPropertyType => typeof(Color);

		internal static Type ThumbTintColorPropertyType => typeof(Color);

		internal static Type FormattedTextPropertyType => typeof(FormattedText);

		internal static Type OrientationPropertyType => typeof(OrientationType);

		internal static Type AlignmentPropertyType => typeof(Alignment);

		internal static Type CursorColorPropertyType => typeof(Color);

		internal static Type PlaceholderTextColorPropertyType => typeof(Color);

		internal static Type PlaceholderPropertyType => typeof(FormattedText);

		internal static Type FontSpecPropertyType => typeof(FontSpec);

		internal static Type KeyboardTypePropertyType => typeof(KeyboardType);

		internal static Type StretchModePropertyType => typeof(ImageStretchMode);

		internal static Type TextColorPropertyType => typeof(Color);

		internal static Type TextAlignmentPropertyType => typeof(TextAlignment);

		internal static Type MarginPropertyType => typeof(Thickness);

		internal static Type PaddingPropertyType => typeof(Thickness);

		internal static Type VisibilityPropertyType => typeof(SectionVisibility);

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetBackgroundColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "BackgroundColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetBackgroundColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "BackgroundColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetBackgroundColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "BackgroundColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetBackgroundColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "BackgroundColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<View, Color> BackgroundColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("BackgroundColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, Color> BackgroundColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("BackgroundColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<Color> BindBackgroundColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("BackgroundColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindBackgroundColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("BackgroundColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindBackgroundColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("BackgroundColor");
		}

		[BindingMember("BackgroundColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color BackgroundColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("BackgroundColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color BackgroundColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetBackgroundColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("BackgroundColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color BackgroundColor(this View item)
		{
			return item.BackgroundColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static View SetBackgroundColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetBackgroundColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetStrokeColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StrokeColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetStrokeColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StrokeColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetStrokeColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StrokeColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetStrokeColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StrokeColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<View, Color> StrokeColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("StrokeColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, Color> StrokeColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("StrokeColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<Color> BindStrokeColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("StrokeColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindStrokeColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("StrokeColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindStrokeColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("StrokeColor");
		}

		[BindingMember("StrokeColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color StrokeColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("StrokeColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color StrokeColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetStrokeColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("StrokeColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color StrokeColor(this View item)
		{
			return item.StrokeColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static View SetStrokeColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetStrokeColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<View, Color> TintColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("TintColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, Color> TintColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("TintColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<Color> BindTintColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("TintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindTintColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("TintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, Color> BindTintColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("TintColor");
		}

		[BindingMember("TintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color TintColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("TintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color TintColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetTintColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("TintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Color TintColor(this View item)
		{
			return item.TintColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static View SetTintColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTintColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetCornerRadiiAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CornerRadii", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetCornerRadiiAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CornerRadii", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo? TryGetCornerRadiiAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CornerRadii", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static IAccessorMemberInfo GetCornerRadiiAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CornerRadii", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<View, CornerRadius> CornerRadiiPropertyBuilder()
		{
			return new PropertyBuilder<View, CornerRadius>("CornerRadii", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static PropertyBuilder<T, CornerRadius> CornerRadiiPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, CornerRadius>("CornerRadii", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static Bindable<CornerRadius> BindCornerRadii<T>(this T target) where T : View
		{
			return target.Bind<T, CornerRadius>("CornerRadii");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, CornerRadius> BindCornerRadiiTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, CornerRadius>("CornerRadii");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static BindingSyntax<T, CornerRadius> BindCornerRadiiTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, CornerRadius>("CornerRadii");
		}

		[BindingMember("CornerRadii")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static CornerRadius CornerRadii(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("CornerRadii")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static CornerRadius CornerRadii(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetCornerRadiiAccessorMember(item, metadata).GetValue<CornerRadius>(item, metadata);
		}

		[BindingMember("CornerRadii")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static CornerRadius CornerRadii(this View item)
		{
			return item.CornerRadii(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		public static View SetCornerRadii(this View item, CornerRadius value, IReadOnlyMetadataContext? metadata = null)
		{
			GetCornerRadiiAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetIconAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetIconAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetIconAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetIconAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Icon", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, ImageSource> IconPropertyBuilder()
		{
			return new PropertyBuilder<View, ImageSource>("Icon", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, ImageSource> IconPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, ImageSource>("Icon", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<ImageSource> BindIcon<T>(this T target) where T : View
		{
			return target.Bind<T, ImageSource>("Icon");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageSource> BindIconTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, ImageSource>("Icon");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageSource> BindIconTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, ImageSource>("Icon");
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Icon(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Icon(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetIconAccessorMember(item, metadata).GetValue<ImageSource>(item, metadata);
		}

		[BindingMember("Icon")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Icon(this View item)
		{
			return item.Icon(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetIcon(this View item, ImageSource value, IReadOnlyMetadataContext? metadata = null)
		{
			GetIconAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetImageAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Image", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetImageAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Image", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetImageAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Image", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetImageAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Image", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, ImageSource> ImagePropertyBuilder()
		{
			return new PropertyBuilder<View, ImageSource>("Image", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, ImageSource> ImagePropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, ImageSource>("Image", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<ImageSource> BindImage<T>(this T target) where T : View
		{
			return target.Bind<T, ImageSource>("Image");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageSource> BindImageTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, ImageSource>("Image");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageSource> BindImageTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, ImageSource>("Image");
		}

		[BindingMember("Image")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Image(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Image")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Image(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetImageAccessorMember(item, metadata).GetValue<ImageSource>(item, metadata);
		}

		[BindingMember("Image")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageSource Image(this View item)
		{
			return item.Image(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetImage(this View item, ImageSource value, IReadOnlyMetadataContext? metadata = null)
		{
			GetImageAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTrackTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TrackTintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTrackTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TrackTintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTrackTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TrackTintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTrackTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TrackTintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Color> TrackTintColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("TrackTintColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Color> TrackTintColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("TrackTintColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Color> BindTrackTintColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("TrackTintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindTrackTintColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("TrackTintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindTrackTintColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("TrackTintColor");
		}

		[BindingMember("TrackTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TrackTintColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("TrackTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TrackTintColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetTrackTintColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("TrackTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TrackTintColor(this View item)
		{
			return item.TrackTintColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetTrackTintColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTrackTintColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetThumbTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "ThumbTintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetThumbTintColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "ThumbTintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetThumbTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "ThumbTintColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetThumbTintColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "ThumbTintColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Color> ThumbTintColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("ThumbTintColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Color> ThumbTintColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("ThumbTintColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Color> BindThumbTintColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("ThumbTintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindThumbTintColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("ThumbTintColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindThumbTintColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("ThumbTintColor");
		}

		[BindingMember("ThumbTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color ThumbTintColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("ThumbTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color ThumbTintColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetThumbTintColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("ThumbTintColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color ThumbTintColor(this View item)
		{
			return item.ThumbTintColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetThumbTintColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetThumbTintColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetFormattedTextAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FormattedText", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetFormattedTextAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FormattedText", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetFormattedTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FormattedText", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetFormattedTextAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FormattedText", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, FormattedText> FormattedTextPropertyBuilder()
		{
			return new PropertyBuilder<View, FormattedText>("FormattedText", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, FormattedText> FormattedTextPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, FormattedText>("FormattedText", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<FormattedText> BindFormattedText<T>(this T target) where T : View
		{
			return target.Bind<T, FormattedText>("FormattedText");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FormattedText> BindFormattedTextTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, FormattedText>("FormattedText");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FormattedText> BindFormattedTextTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, FormattedText>("FormattedText");
		}

		[BindingMember("FormattedText")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText FormattedText(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("FormattedText")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText FormattedText(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetFormattedTextAccessorMember(item, metadata).GetValue<FormattedText>(item, metadata);
		}

		[BindingMember("FormattedText")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText FormattedText(this View item)
		{
			return item.FormattedText(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetFormattedText(this View item, FormattedText value, IReadOnlyMetadataContext? metadata = null)
		{
			GetFormattedTextAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetOrientationAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Orientation", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetOrientationAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Orientation", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetOrientationAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Orientation", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetOrientationAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Orientation", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, OrientationType?> OrientationPropertyBuilder()
		{
			return new PropertyBuilder<View, OrientationType>("Orientation", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, OrientationType?> OrientationPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, OrientationType>("Orientation", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<OrientationType?> BindOrientation<T>(this T target) where T : View
		{
			return target.Bind<T, OrientationType>("Orientation");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, OrientationType?> BindOrientationTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, OrientationType>("Orientation");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, OrientationType?> BindOrientationTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, OrientationType>("Orientation");
		}

		[BindingMember("Orientation")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static OrientationType? Orientation(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Orientation")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static OrientationType? Orientation(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetOrientationAccessorMember(item, metadata).GetValue<OrientationType>(item, metadata);
		}

		[BindingMember("Orientation")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static OrientationType? Orientation(this View item)
		{
			return item.Orientation(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetOrientation(this View item, OrientationType? value, IReadOnlyMetadataContext? metadata = null)
		{
			GetOrientationAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetAlignmentAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Alignment", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetAlignmentAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Alignment", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetAlignmentAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Alignment", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetAlignmentAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Alignment", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Alignment?> AlignmentPropertyBuilder()
		{
			return new PropertyBuilder<View, Alignment>("Alignment", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Alignment?> AlignmentPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Alignment>("Alignment", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Alignment?> BindAlignment<T>(this T target) where T : View
		{
			return target.Bind<T, Alignment>("Alignment");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Alignment?> BindAlignmentTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Alignment>("Alignment");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Alignment?> BindAlignmentTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Alignment>("Alignment");
		}

		[BindingMember("Alignment")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Alignment? Alignment(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Alignment")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Alignment? Alignment(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetAlignmentAccessorMember(item, metadata).GetValue<Alignment>(item, metadata);
		}

		[BindingMember("Alignment")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Alignment? Alignment(this View item)
		{
			return item.Alignment(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetAlignment(this View item, Alignment? value, IReadOnlyMetadataContext? metadata = null)
		{
			GetAlignmentAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetCursorColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CursorColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetCursorColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CursorColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetCursorColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CursorColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetCursorColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "CursorColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Color> CursorColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("CursorColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Color> CursorColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("CursorColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Color> BindCursorColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("CursorColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindCursorColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("CursorColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindCursorColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("CursorColor");
		}

		[BindingMember("CursorColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color CursorColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("CursorColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color CursorColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetCursorColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("CursorColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color CursorColor(this View item)
		{
			return item.CursorColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetCursorColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetCursorColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPlaceholderTextColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "PlaceholderTextColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPlaceholderTextColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "PlaceholderTextColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPlaceholderTextColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "PlaceholderTextColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPlaceholderTextColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "PlaceholderTextColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Color> PlaceholderTextColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("PlaceholderTextColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Color> PlaceholderTextColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("PlaceholderTextColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Color> BindPlaceholderTextColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("PlaceholderTextColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindPlaceholderTextColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("PlaceholderTextColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindPlaceholderTextColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("PlaceholderTextColor");
		}

		[BindingMember("PlaceholderTextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color PlaceholderTextColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("PlaceholderTextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color PlaceholderTextColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetPlaceholderTextColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("PlaceholderTextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color PlaceholderTextColor(this View item)
		{
			return item.PlaceholderTextColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetPlaceholderTextColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetPlaceholderTextColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPlaceholderAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Placeholder", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPlaceholderAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Placeholder", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPlaceholderAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Placeholder", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPlaceholderAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Placeholder", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, FormattedText> PlaceholderPropertyBuilder()
		{
			return new PropertyBuilder<View, FormattedText>("Placeholder", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, FormattedText> PlaceholderPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, FormattedText>("Placeholder", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<FormattedText> BindPlaceholder<T>(this T target) where T : View
		{
			return target.Bind<T, FormattedText>("Placeholder");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FormattedText> BindPlaceholderTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, FormattedText>("Placeholder");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FormattedText> BindPlaceholderTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, FormattedText>("Placeholder");
		}

		[BindingMember("Placeholder")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText Placeholder(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Placeholder")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText Placeholder(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetPlaceholderAccessorMember(item, metadata).GetValue<FormattedText>(item, metadata);
		}

		[BindingMember("Placeholder")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FormattedText Placeholder(this View item)
		{
			return item.Placeholder(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetPlaceholder(this View item, FormattedText value, IReadOnlyMetadataContext? metadata = null)
		{
			GetPlaceholderAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetFontSpecAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FontSpec", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetFontSpecAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FontSpec", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetFontSpecAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FontSpec", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetFontSpecAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "FontSpec", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, FontSpec> FontSpecPropertyBuilder()
		{
			return new PropertyBuilder<View, FontSpec>("FontSpec", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, FontSpec> FontSpecPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, FontSpec>("FontSpec", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<FontSpec> BindFontSpec<T>(this T target) where T : View
		{
			return target.Bind<T, FontSpec>("FontSpec");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FontSpec> BindFontSpecTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, FontSpec>("FontSpec");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, FontSpec> BindFontSpecTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, FontSpec>("FontSpec");
		}

		[BindingMember("FontSpec")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FontSpec FontSpec(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("FontSpec")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FontSpec FontSpec(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetFontSpecAccessorMember(item, metadata).GetValue<FontSpec>(item, metadata);
		}

		[BindingMember("FontSpec")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static FontSpec FontSpec(this View item)
		{
			return item.FontSpec(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetFontSpec(this View item, FontSpec value, IReadOnlyMetadataContext? metadata = null)
		{
			GetFontSpecAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetKeyboardTypeAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "KeyboardType", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetKeyboardTypeAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "KeyboardType", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetKeyboardTypeAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "KeyboardType", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetKeyboardTypeAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "KeyboardType", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, KeyboardType?> KeyboardTypePropertyBuilder()
		{
			return new PropertyBuilder<View, KeyboardType>("KeyboardType", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, KeyboardType?> KeyboardTypePropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, KeyboardType>("KeyboardType", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<KeyboardType?> BindKeyboardType<T>(this T target) where T : View
		{
			return target.Bind<T, KeyboardType>("KeyboardType");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, KeyboardType?> BindKeyboardTypeTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, KeyboardType>("KeyboardType");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, KeyboardType?> BindKeyboardTypeTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, KeyboardType>("KeyboardType");
		}

		[BindingMember("KeyboardType")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static KeyboardType? KeyboardType(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("KeyboardType")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static KeyboardType? KeyboardType(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetKeyboardTypeAccessorMember(item, metadata).GetValue<KeyboardType>(item, metadata);
		}

		[BindingMember("KeyboardType")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static KeyboardType? KeyboardType(this View item)
		{
			return item.KeyboardType(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetKeyboardType(this View item, KeyboardType? value, IReadOnlyMetadataContext? metadata = null)
		{
			GetKeyboardTypeAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetStretchModeAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StretchMode", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetStretchModeAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StretchMode", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetStretchModeAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StretchMode", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetStretchModeAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "StretchMode", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, ImageStretchMode?> StretchModePropertyBuilder()
		{
			return new PropertyBuilder<View, ImageStretchMode>("StretchMode", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, ImageStretchMode?> StretchModePropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, ImageStretchMode>("StretchMode", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<ImageStretchMode?> BindStretchMode<T>(this T target) where T : View
		{
			return target.Bind<T, ImageStretchMode>("StretchMode");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageStretchMode?> BindStretchModeTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, ImageStretchMode>("StretchMode");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, ImageStretchMode?> BindStretchModeTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, ImageStretchMode>("StretchMode");
		}

		[BindingMember("StretchMode")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageStretchMode? StretchMode(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("StretchMode")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageStretchMode? StretchMode(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetStretchModeAccessorMember(item, metadata).GetValue<ImageStretchMode>(item, metadata);
		}

		[BindingMember("StretchMode")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static ImageStretchMode? StretchMode(this View item)
		{
			return item.StretchMode(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetStretchMode(this View item, ImageStretchMode? value, IReadOnlyMetadataContext? metadata = null)
		{
			GetStretchModeAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTextColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTextColorAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTextColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextColor", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTextColorAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextColor", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Color> TextColorPropertyBuilder()
		{
			return new PropertyBuilder<View, Color>("TextColor", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Color> TextColorPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Color>("TextColor", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Color> BindTextColor<T>(this T target) where T : View
		{
			return target.Bind<T, Color>("TextColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindTextColorTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Color>("TextColor");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Color> BindTextColorTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Color>("TextColor");
		}

		[BindingMember("TextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TextColor(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("TextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TextColor(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetTextColorAccessorMember(item, metadata).GetValue<Color>(item, metadata);
		}

		[BindingMember("TextColor")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Color TextColor(this View item)
		{
			return item.TextColor(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetTextColor(this View item, Color value, IReadOnlyMetadataContext? metadata = null)
		{
			GetTextColorAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTextAlignmentAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextAlignment", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTextAlignmentAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextAlignment", metadata);
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetTextAlignmentAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextAlignment", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetTextAlignmentAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "TextAlignment", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, TextAlignment?> TextAlignmentPropertyBuilder()
		{
			return new PropertyBuilder<View, TextAlignment>("TextAlignment", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, TextAlignment?> TextAlignmentPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, TextAlignment>("TextAlignment", typeof(T));
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<TextAlignment?> BindTextAlignment<T>(this T target) where T : View
		{
			return target.Bind<T, TextAlignment>("TextAlignment");
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, TextAlignment?> BindTextAlignmentTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, TextAlignment>("TextAlignment");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		[DynamicDependency("TextAlignment", typeof(View))]
		internal static BindingSyntax<T, TextAlignment?> BindTextAlignmentTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, TextAlignment>("TextAlignment");
		}

		[DynamicDependency("TextAlignment", typeof(View))]
		[BindingMember("TextAlignment")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static TextAlignment? TextAlignment(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetMarginAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Margin", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetMarginAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Margin", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetMarginAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Margin", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetMarginAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Margin", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Thickness> MarginPropertyBuilder()
		{
			return new PropertyBuilder<View, Thickness>("Margin", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Thickness> MarginPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Thickness>("Margin", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Thickness> BindMargin<T>(this T target) where T : View
		{
			return target.Bind<T, Thickness>("Margin");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Thickness> BindMarginTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Thickness>("Margin");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Thickness> BindMarginTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Thickness>("Margin");
		}

		[BindingMember("Margin")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Margin(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Margin")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Margin(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetMarginAccessorMember(item, metadata).GetValue<Thickness>(item, metadata);
		}

		[BindingMember("Margin")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Margin(this View item)
		{
			return item.Margin(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetMargin(this View item, Thickness value, IReadOnlyMetadataContext? metadata = null)
		{
			GetMarginAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPaddingAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Padding", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPaddingAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Padding", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetPaddingAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Padding", metadata) as IAccessorMemberInfo;
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetPaddingAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Padding", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, Thickness> PaddingPropertyBuilder()
		{
			return new PropertyBuilder<View, Thickness>("Padding", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, Thickness> PaddingPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, Thickness>("Padding", typeof(T));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<Thickness> BindPadding<T>(this T target) where T : View
		{
			return target.Bind<T, Thickness>("Padding");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Thickness> BindPaddingTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, Thickness>("Padding");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, Thickness> BindPaddingTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, Thickness>("Padding");
		}

		[BindingMember("Padding")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Padding(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}

		[BindingMember("Padding")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Padding(this View item, IReadOnlyMetadataContext? metadata)
		{
			return GetPaddingAccessorMember(item, metadata).GetValue<Thickness>(item, metadata);
		}

		[BindingMember("Padding")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Thickness Padding(this View item)
		{
			return item.Padding(null);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static View SetPadding(this View item, Thickness value, IReadOnlyMetadataContext? metadata = null)
		{
			GetPaddingAccessorMember(item, metadata).SetValue(item, value, metadata);
			return item;
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetVisibilityAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetVisibilityAccessorMember(View item, IReadOnlyMetadataContext? metadata = null)
		{
			Should.NotBeNull(item, "item");
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(((object)item).GetType()), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata);
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo? TryGetVisibilityAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return IMugenService<IReflectionManager>.Instance.TryGetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata) as IAccessorMemberInfo;
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static IAccessorMemberInfo GetVisibilityAccessorMember(IReadOnlyMetadataContext? metadata = null)
		{
			return (IAccessorMemberInfo)IMugenService<IReflectionManager>.Instance.GetMember(ReflectionMugenExtensions.IgnoreDynamicDependency(TargetType), (FlagsEnumBase<MemberType, ushort>?)MemberType.Accessor, MemberFlags.InstanceAll, "Visibility", metadata);
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<View, SectionVisibility?> VisibilityPropertyBuilder()
		{
			return new PropertyBuilder<View, SectionVisibility>("Visibility", typeof(View));
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static PropertyBuilder<T, SectionVisibility?> VisibilityPropertyBuilder<T>() where T : View
		{
			return new PropertyBuilder<T, SectionVisibility>("Visibility", typeof(T));
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static Bindable<SectionVisibility?> BindVisibility<T>(this T target) where T : View
		{
			return target.Bind<T, SectionVisibility>("Visibility");
		}

		[DynamicDependency("Visibility", typeof(View))]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static BindingSyntax<T, SectionVisibility?> BindVisibilityTarget<T>(this T target) where T : View
		{
			return target.BindTarget<T, SectionVisibility>("Visibility");
		}

		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		[DynamicDependency("Visibility", typeof(View))]
		internal static BindingSyntax<T, SectionVisibility?> BindVisibilityTarget<T>(this BindingResult<T> target) where T : View
		{
			return target.Target.BindTarget<T, SectionVisibility>("Visibility");
		}

		[DynamicDependency("Visibility", typeof(View))]
		[BindingMember("Visibility")]
		[GeneratedCode("MugenMvvm.SourceGenerator", "1.0.0")]
		internal static SectionVisibility? Visibility(this IBindingSyntaxExtension<View> target)
		{
			throw new NotSupportedException();
		}
	}
}
namespace MugenMvvm.CompositeUI.App
{
	public class AppErrorInfo : MetadataContext, IAppErrorInfo, IMetadataOwner<IMetadataContext>, IInner<IAppErrorInfo>
	{
		private IAppErrorRetryHandler? _retryHandler;

		public bool IsFatal { get; }

		public object Source { get; }

		public object? HandlerSource => _retryHandler?.ErrorSource;

		public string? ActionId { get; }

		public Exception Exception { get; }

		public IMetadataContext Metadata => this;

		public AppErrorInfo(object source, Exception exception, string? actionId, IAppErrorRetryHandler? retryHandler, bool isFatal)
		{
			Should.NotBeNull(source, "source");
			Should.NotBeNull(exception, "exception");
			_retryHandler = retryHandler;
			IsFatal = isFatal;
			Source = source;
			ActionId = actionId;
			Exception = exception;
		}

		public override string ToString()
		{
			return Exception.ToString();
		}

		public async ValueTask<bool?> RetryAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			try
			{
				IAppErrorRetryHandler appErrorRetryHandler = Interlocked.Exchange(ref _retryHandler, null);
				return (appErrorRetryHandler != null) ? (await appErrorRetryHandler.RetryAsync(this, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) : ((bool?)null);
			}
			catch (Exception exception)
			{
				IMugenService<IMugenApplication>.Instance.OnUnhandledException(exception, UnhandledExceptionType.System, metadata);
				return false;
			}
		}

		public void OnCanceled(IReadOnlyMetadataContext? metadata)
		{
			Interlocked.Exchange(ref _retryHandler, null);
		}
	}
	public sealed class AppErrorTracker : IApiHandlerDecorator<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, OnAppErrorRequest>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, OnAppErrorRequest>, IApiHandlerComponent<IMugenApplication, OnCancelAppErrorRequest, bool?>, ISupportApiHandlerComponent<IMugenApplication, OnCancelAppErrorRequest>, IApiHandlerComponent<IMugenApplication, OnCancelAppErrorByIdRequest, bool?>, ISupportApiHandlerComponent<IMugenApplication, OnCancelAppErrorByIdRequest>, IApiHandlerComponent<IMugenApplication, GetAppErrorsRequest, PooledReadOnlyList<IAppErrorInfo>>, ISupportApiHandlerComponent<IMugenApplication, GetAppErrorsRequest>, IApiHandlerComponent<IMugenApplication, RegisterAppErrorListenerRequest, bool?>, ISupportApiHandlerComponent<IMugenApplication, RegisterAppErrorListenerRequest>, IApiHandlerComponent<IMugenApplication, UnregisterAppErrorListenerRequest, bool?>, ISupportApiHandlerComponent<IMugenApplication, UnregisterAppErrorListenerRequest>
	{
		private ApiProviderDecoratedComponents<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>> _onErrorComponents;

		public ApiProviderDecoratedComponents<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>> Components
		{
			get
			{
				return _onErrorComponents;
			}
			set
			{
				_onErrorComponents = value;
			}
		}

		public int Priority { get; init; } = 1073741823;

		public IMugenApplication? Owner { get; set; }

		[MustDisposeResource]
		public PooledReadOnlyList<IAppErrorInfo> TryInvoke(GetAppErrorsRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			AttachedValueStorage attachedValueStorage = request.Source.AttachedValues().BatchUpdate();
			try
			{
				if (attachedValueStorage.TryGet("aek", out object value))
				{
					return ItemOrList<IAppErrorInfo>.FromRawValue(value).ToPooledReadOnlyList();
				}
				if (request.Source is IHasDisposedState hasDisposedState)
				{
					_ = hasDisposedState.IsDisposed;
					return default(PooledReadOnlyList<IAppErrorInfo>);
				}
				return default(PooledReadOnlyList<IAppErrorInfo>);
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		public async ValueTask<IAppErrorInfo?> TryInvoke(OnAppErrorRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			IAppErrorInfo appErrorInfo = await _onErrorComponents.TryInvoke(request, apiProvider, metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (appErrorInfo != null)
			{
				UpdateErrors(appErrorInfo, add: true, metadata);
			}
			return appErrorInfo;
		}

		public bool? TryInvoke(OnCancelAppErrorByIdRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return RemoveError(request.Source, request.ActionId, metadata);
		}

		public bool? TryInvoke(OnCancelAppErrorRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return UpdateErrors(request.Error, add: false, metadata);
		}

		public bool? TryInvoke(RegisterAppErrorListenerRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return UpdateListeners(request.Source, request.Listener, add: true);
		}

		public bool? TryInvoke(UnregisterAppErrorListenerRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return UpdateListeners(request.Source, request.Listener, add: false);
		}

		private static bool UpdateListeners(object source, IAppErrorListener listener, bool add)
		{
			AttachedValueStorage attachedValueStorage = source.AttachedValues().BatchUpdate();
			try
			{
				object value;
				bool num = attachedValueStorage.TryGet("ael", out value);
				ItemOrList<IAppErrorListener> editor = ItemOrList<IAppErrorListener>.FromRawValue(value);
				if (add)
				{
					if (!editor.Contains(listener))
					{
						editor.Add(listener);
					}
				}
				else
				{
					editor.Remove(listener);
				}
				attachedValueStorage.Set("ael", editor.GetRawValue());
				if (!num && editor.Count != 0 && source is ISupportDisposeCallback owner)
				{
					owner.TryRegisterDisposeToken(ActionToken.FromDelegate(delegate(object? o, object? _)
					{
						ClearErrors(o);
					}, source));
				}
				return true;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		private static void ClearErrors(object source)
		{
			AttachedValueStorage attachedValueStorage = source.AttachedValues().BatchUpdate();
			ItemOrList<IAppErrorListener> itemOrList;
			ItemOrList<IAppErrorInfo> itemOrList2;
			try
			{
				attachedValueStorage.Remove("ael", out object oldValue);
				itemOrList = ItemOrList<IAppErrorListener>.FromRawValue(oldValue);
				attachedValueStorage.Remove("aek", out oldValue);
				itemOrList2 = ItemOrList<IAppErrorInfo>.FromRawValue(oldValue);
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
			foreach (IAppErrorInfo item in itemOrList2)
			{
				item.OnCanceled(null);
				(source as IAppErrorListener)?.OnRemoved(item, null);
				foreach (IAppErrorListener item2 in itemOrList)
				{
					item2.OnRemoved(item, null);
				}
			}
		}

		private static bool UpdateErrors(IAppErrorInfo error, bool add, IReadOnlyMetadataContext? metadata)
		{
			PooledReadOnlyList<IAppErrorListener> items = default(PooledReadOnlyList<IAppErrorListener>);
			IAppErrorInfo appErrorInfo = null;
			bool flag = false;
			AttachedValueStorage attachedValueStorage = error.Source.AttachedValues().BatchUpdate();
			try
			{
				attachedValueStorage.TryGet("aek", out object value);
				ItemOrList<IAppErrorInfo> errors = ItemOrList<IAppErrorInfo>.FromRawValue(value);
				if (add)
				{
					if (error.ActionId != null)
					{
						appErrorInfo = RemoveError(error.Source, error.ActionId, ref errors);
					}
					errors.Add(error);
				}
				else
				{
					flag = errors.Remove(error);
				}
				if (!(flag || add))
				{
					return false;
				}
				attachedValueStorage.Set("aek", errors.GetRawValue());
				attachedValueStorage.TryGet("ael", out object value2);
				items = ItemOrList<IAppErrorListener>.FromRawValue(value2).ToPooledReadOnlyList();
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
			if (appErrorInfo != null)
			{
				appErrorInfo.OnCanceled(metadata);
				(appErrorInfo.Source as IAppErrorListener)?.OnRemoved(appErrorInfo, metadata);
			}
			if (add)
			{
				(error.Source as IAppErrorListener)?.OnAdded(error, metadata);
			}
			else
			{
				error.OnCanceled(metadata);
				(error.Source as IAppErrorListener)?.OnRemoved(error, metadata);
			}
			foreach (IAppErrorListener item in items.GetDisposableEnumerator())
			{
				if (appErrorInfo != null)
				{
					item.OnRemoved(appErrorInfo, metadata);
				}
				if (add)
				{
					item.OnAdded(error, metadata);
				}
				else
				{
					item.OnRemoved(error, metadata);
				}
			}
			return flag || add;
		}

		private static bool RemoveError(object source, string id, IReadOnlyMetadataContext? metadata)
		{
			AttachedValueStorage attachedValueStorage = source.AttachedValues().BatchUpdate();
			IAppErrorInfo appErrorInfo;
			PooledReadOnlyList<IAppErrorListener> items;
			try
			{
				attachedValueStorage.TryGet("aek", out object value);
				ItemOrList<IAppErrorInfo> errors = ItemOrList<IAppErrorInfo>.FromRawValue(value);
				appErrorInfo = RemoveError(source, id, ref errors);
				if (appErrorInfo == null)
				{
					return false;
				}
				attachedValueStorage.Set("aek", errors.GetRawValue());
				attachedValueStorage.TryGet("ael", out object value2);
				items = ItemOrList<IAppErrorListener>.FromRawValue(value2).ToPooledReadOnlyList();
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
			appErrorInfo.OnCanceled(metadata);
			(source as IAppErrorListener)?.OnRemoved(appErrorInfo, metadata);
			foreach (IAppErrorListener item in items.GetDisposableEnumerator())
			{
				item.OnRemoved(appErrorInfo, metadata);
			}
			return true;
		}

		private static IAppErrorInfo? RemoveError(object source, string id, ref ItemOrList<IAppErrorInfo> errors)
		{
			Span<IAppErrorInfo> span = errors.Span;
			for (int i = 0; i < span.Length; i++)
			{
				IAppErrorInfo appErrorInfo = span[i];
				if (appErrorInfo.Source == source && appErrorInfo.ActionId == id)
				{
					errors.RemoveAt(i);
					return appErrorInfo;
				}
			}
			return null;
		}
	}
	public sealed class CompositeApplicationInitializer : ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IAttachableComponentBase, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISectionApiRequestHandler, IHasPriority
	{
		private readonly Lock _lock = new Lock();

		private Task? _initializationTask;

		private ListSlim<TaskCompletionSource> _tasks = new ListSlim<TaskCompletionSource>(4);

		public int Priority { get; init; } = 1073741833;

		public IMugenApplication? Owner { get; set; }

		public TResponse? TryInvoke<TRequest, TResponse>(TRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken) where TRequest : IApiRequestBase<IMugenApplication, TRequest, TResponse>
		{
			if (typeof(TResponse) == typeof(IAsyncEnumerator<ISection>) && request is GetSectionsRequestBase getSectionsRequestBase)
			{
				return (TResponse)GetSections(apiProvider, getSectionsRequestBase.Shell, metadata, cancellationToken);
			}
			if (typeof(TResponse).IsValueType && typeof(ISectionApiRequest).IsAssignableFrom(typeof(TRequest)))
			{
				return ((ISectionApiRequest)(object)request).TryInvoke<TResponse>(this, apiProvider, metadata, cancellationToken);
			}
			return default(TResponse);
		}

		public ValueTask<Optional<TResult>> HandleGeneric<TResult>(ISectionApiRequest request, IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			Task task = WaitInitializationAsync(application, cancellationToken);
			if (!task.IsCompletedSuccessfully)
			{
				return task.ContinueWith((Task _) => default(Optional<TResult>), cancellationToken, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default).AsValueTask();
			}
			return default(ValueTask<Optional<TResult>>);
		}

		public bool IsRequestSupported(IMugenApplication owner, ComponentDescriptor descriptor)
		{
			if (!typeof(ISectionApiRequest).IsAssignableFrom(descriptor.RequestType))
			{
				return typeof(GetSectionsRequestBase).IsAssignableFrom(descriptor.RequestType);
			}
			return true;
		}

		private Task WaitInitializationAsync(IMugenApplication application, CancellationToken cancellationToken)
		{
			if (_initializationTask == null)
			{
				_initializationTask = WaitInitializationAsync(application);
			}
			using (_lock.EnterScope())
			{
				if (_tasks.IsInitialized)
				{
					TaskCompletionSource taskCompletionSource = new TaskCompletionSource();
					cancellationToken.Register(delegate(object? o)
					{
						((TaskCompletionSource)o).TrySetCanceled();
					}, taskCompletionSource);
					_tasks.Add(taskCompletionSource);
					return taskCompletionSource.Task;
				}
				return _initializationTask.IsCompleted ? _initializationTask : _initializationTask.WaitAsync(cancellationToken);
			}
		}

		private async Task WaitInitializationAsync(IMugenApplication application)
		{
			_ = 1;
			try
			{
				await application.EnsureAppInitializedAsync().ConfigureAwait(continueOnCapturedContext: false);
				await IMugenService<IMugenApplication>.Instance.WaitStateAsync((FlagsEnumBase<ApplicationLifecycleState, long>?)ApplicationLifecycleState.NavigationInitialized).ConfigureAwait(continueOnCapturedContext: false);
				OnInitialized(application, null);
			}
			catch (Exception exception)
			{
				OnInitialized(application, exception);
			}
		}

		private void OnInitialized(IMugenApplication application, Exception? exception)
		{
			PooledItemOrList<TaskCompletionSource> pooledItemOrList = default(PooledItemOrList<TaskCompletionSource>);
			try
			{
				using (_lock.EnterScope())
				{
					if (!_tasks.IsInitialized)
					{
						return;
					}
					pooledItemOrList = new PooledItemOrList<TaskCompletionSource>(_tasks.ReadOnlySpan);
					_tasks = default(ListSlim<TaskCompletionSource>);
				}
				ReadOnlySpan<TaskCompletionSource> readOnlySpan = pooledItemOrList.ReadOnlySpan;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					TaskCompletionSource taskCompletionSource = readOnlySpan[i];
					if (exception == null)
					{
						taskCompletionSource.TrySetResult();
					}
					else
					{
						taskCompletionSource.TrySetException(exception);
					}
				}
			}
			finally
			{
				pooledItemOrList.Dispose();
				application.RemoveComponent(this);
			}
		}

		private async IAsyncEnumerator<ISection> GetSections(IMugenApplication application, IShellSection shell, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			await application.EnsureAppInitializedAsync(metadata, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			application.RemoveComponent(this);
			yield break;
		}
	}
	public sealed class DefaultAppErrorHandler : IApiHandlerComponent<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, OnAppErrorRequest>, IHasPriority
	{
		public int Priority => -2147483638;

		public ValueTask<IAppErrorInfo?> TryInvoke(OnAppErrorRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return new ValueTask<IAppErrorInfo>(new AppErrorInfo(request.Source, request.Exception, request.ActionId, request.RetryHandler, isFatal: true));
		}
	}
	public abstract class EnvironmentMetricsProviderBase : IApiHandlerComponent<IMugenApplication, GetLayoutDirectionRequest, Bindable<LayoutDirType>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetLayoutDirectionRequest>, IApiHandlerComponent<IMugenApplication, GetScreenMetricsRequest, Bindable<ScreenMetrics>>, ISupportApiHandlerComponent<IMugenApplication, GetScreenMetricsRequest>
	{
		private const string LayoutDirKey = "$#ld$";

		private const string ScreenMetricsKey = "$#sm$";

		private static Expression<Func<IShellAware, IView?>>? _bindCache1;

		public virtual Bindable<LayoutDirType> TryInvoke(GetLayoutDirectionRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.Relative)
			{
				IVisualSection visualSection = MugenExtensions.TryUnwrap<ISection, IVisualSection>(request.Section);
				if (visualSection != null)
				{
					visualSection.TapNativeView(out Bindable<object> nativeView);
					return request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, EnvironmentMetricsProviderBase, object, BindableValue<LayoutDirType>>(this.Bind(), nativeView, (IView v, EnvironmentMetricsProviderBase p, object nv) => (!IsViewValid(v) || nv == null) ? null : p.GetLayoutDirection(v, nv)).Unwrap()
						.Share();
				}
			}
			AttachedValueStorage attachedValueStorage = request.Section.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet("$#ld$", out object value))
				{
					value = request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, EnvironmentMetricsProviderBase, BindableValue<LayoutDirType>>(this.Bind(), (IView v, EnvironmentMetricsProviderBase p) => (!IsViewValid(v)) ? null : p.GetLayoutDirection(v, p.GetGlobalView(v))).Unwrap()
						.Share();
					attachedValueStorage.Set("$#ld$", value);
				}
				return (Bindable<LayoutDirType>)value;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		public virtual Bindable<ScreenMetrics> TryInvoke(GetScreenMetricsRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.Relative)
			{
				IVisualSection visualSection = MugenExtensions.TryUnwrap<ISection, IVisualSection>(request.Section);
				if (visualSection != null)
				{
					visualSection.TapNativeView(out Bindable<object> nativeView);
					return request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, EnvironmentMetricsProviderBase, object, BindableValue<ScreenMetrics>>(this.Bind(), nativeView, (IView v, EnvironmentMetricsProviderBase p, object nv) => (!IsViewValid(v) || nv == null) ? null : p.GetScreenMetrics(v, nv)).Unwrap()
						.Share();
				}
			}
			AttachedValueStorage attachedValueStorage = request.Section.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet("$#sm$", out object value))
				{
					value = request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, EnvironmentMetricsProviderBase, BindableValue<ScreenMetrics>>(this.Bind(), (IView v, EnvironmentMetricsProviderBase p) => (!IsViewValid(v)) ? null : p.GetScreenMetrics(v, p.GetGlobalView(v))).Unwrap()
						.Share();
					attachedValueStorage.Set("$#sm$", value);
				}
				return (Bindable<ScreenMetrics>)value;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		protected abstract BindableValue<LayoutDirType>? GetLayoutDirection(IView view, object? nativeView);

		protected abstract BindableValue<ScreenMetrics>? GetScreenMetrics(IView view, object? nativeView);

		protected abstract object? GetGlobalView(IView view);

		private static bool IsViewValid([NotNullWhen(true)] IView? view)
		{
			if (view != null && !view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Clearing))
			{
				return !view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Cleared);
			}
			return false;
		}
	}
	public sealed class SectionModifierRendererRegistry : IApiHandlerComponent<IMugenApplication, GetSectionModifierRendererRequest, ISectionModifierRenderer>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetSectionModifierRendererRequest>
	{
		private DictionarySlim<Type2Key, ISectionModifierRenderer> _renderers = new DictionarySlim<Type2Key, ISectionModifierRenderer>(17);

		public SectionModifierRendererRegistry Register<TModifier, TView>(ISectionModifierRenderer<TView> renderer) where TModifier : class, ISectionModifier where TView : class
		{
			Should.NotBeNull(renderer, "renderer");
			_renderers.GetOrAddValueRef(new Type2Key(typeof(TModifier), typeof(TView))) = renderer;
			return this;
		}

		public bool Unregister<TModifier, TView>() where TModifier : class, ISectionModifier where TView : class
		{
			return _renderers.Remove(new Type2Key(typeof(TModifier), typeof(TView)));
		}

		public ISectionModifierRenderer? TryInvoke(GetSectionModifierRendererRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return _renderers.GetValueOrDefault(new Type2Key(request.ModifierType, request.ViewType));
		}
	}
	public abstract class SystemInsetsProviderBase : IApiHandlerComponent<IMugenApplication, GetSystemInsetsRequest, Bindable<Thickness>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetSystemInsetsRequest>
	{
		private const string InsetsPrefix = "#$si_";

		private static Expression<Func<IShellAware, IView?>>? _bindCache1;

		private static Expression<Func<SystemInsetType, SystemInsetType>>? _bindCache2;

		public Bindable<Thickness> TryInvoke(GetSystemInsetsRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (!IsSupported(request, metadata))
			{
				return Thickness.Zero;
			}
			if (request.Relative)
			{
				IVisualSection visualSection = MugenExtensions.TryUnwrap<ISection, IVisualSection>(request.Section);
				if (visualSection != null)
				{
					visualSection.TapNativeView(out Bindable<object> nativeView);
					return request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, SystemInsetType, SystemInsetsProviderBase, object, BindableValue<Thickness>>(request.Type.B(_bindCache2 ?? (_bindCache2 = (SystemInsetType t) => t.AsBindEx().Weak(value: false))), this.Bind(), nativeView, (IView v, SystemInsetType t, SystemInsetsProviderBase p, object nv) => (!IsViewValid(v) || nv == null) ? null : p.GetInsets(v, t, nv)).Unwrap()
						.Share();
				}
			}
			Span<char> span = stackalloc char["#$si_".Length + request.Type.Name.Length];
			"#$si_".CopyTo(span);
			request.Type.Name.CopyTo(span.Slice("#$si_".Length));
			AttachedValueStorage attachedValueStorage = request.Section.AttachedValues().BatchUpdate();
			try
			{
				if (!attachedValueStorage.TryGet(span, out object value))
				{
					value = request.Section.B(_bindCache1 ?? (_bindCache1 = (IShellAware s) => s.RootSection<IViewsAwareSection>().Section.Views.LastOrDefaultBindable().Value)).Combine<IView, SystemInsetType, SystemInsetsProviderBase, BindableValue<Thickness>>(request.Type.B(_bindCache2 ?? (_bindCache2 = (SystemInsetType t) => t.AsBindEx().Weak(value: false))), this.Bind(), (IView v, SystemInsetType t, SystemInsetsProviderBase p) => (!IsViewValid(v)) ? null : p.GetInsets(v, t, p.GetGlobalView(v))).Unwrap()
						.Share();
					attachedValueStorage.Set(span, value);
				}
				return (Bindable<Thickness>)value;
			}
			finally
			{
				((IDisposable)attachedValueStorage/*cast due to .constrained prefix*/).Dispose();
			}
		}

		protected abstract bool IsSupported(GetSystemInsetsRequest request, IReadOnlyMetadataContext? metadata);

		protected abstract object? GetGlobalView(IView view);

		protected abstract BindableValue<Thickness>? GetInsets(IView view, SystemInsetType type, object? nativeView);

		private static bool IsViewValid([NotNullWhen(true)] IView? view)
		{
			if (view != null && !view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Clearing))
			{
				return !view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Cleared);
			}
			return false;
		}
	}
	public class EnvironmentMetricsProvider : EnvironmentMetricsProviderBase
	{
		private sealed class EnvironmentNativeListener : Object, IApiHandlerComponent<IView, OnLifecycleChangedRequest<IView, ViewLifecycleState, IView>, Unit>, IApiHandlerComponent<IView>, IApiProviderComponent<IView>, IApiProviderComponent, IComponent, ISupportRequestComponent<IView>, IComponent<IView>, ISupportApiHandlerComponent<IView, OnLifecycleChangedRequest<IView, ViewLifecycleState, IView>>, ILayoutEnvironmentListener, IJavaObject, IDisposable, IJavaPeerable
		{
			private readonly WeakRef<Object> _viewRef;

			public Object? View => _viewRef.Target;

			public BindableValue<LayoutDirType> Direction { get; }

			public BindableValue<ScreenMetrics> Screen { get; }

			public EnvironmentNativeListener(Object view)
			{
				_viewRef = view.ToWeakReference<Object>();
				Direction = new BindableValue<LayoutDirType>();
				Screen = new BindableValue<ScreenMetrics>();
				NativeBindableMemberMugenExtensions.ObserveLayoutEnvironment(view, this);
			}

			public void Cleanup(IView? view)
			{
				view?.RemoveComponent(this);
				Object view2 = View;
				if (view2 != null)
				{
					NativeBindableMemberMugenExtensions.ObserveLayoutEnvironment(view2, null);
				}
			}

			public Unit TryInvoke(OnLifecycleChangedRequest<IView, ViewLifecycleState, IView> request, IView apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				if (View == null || request.LifecycleState.IsInState(ViewLifecycleState.Clearing))
				{
					Cleanup(apiProvider);
				}
				return default(Unit);
			}

			public void OnChanged(sbyte direction, float dpWidth, float dpHeight, float scale)
			{
				Direction.Value = EnumBase<LayoutDirType, byte>.Get((byte)direction);
				Screen.Value = new ScreenMetrics(dpWidth, dpHeight, scale);
			}
		}

		protected override BindableValue<LayoutDirType>? GetLayoutDirection(IView view, object? nativeView)
		{
			return TryGetListener(view, nativeView)?.Direction;
		}

		protected override BindableValue<ScreenMetrics>? GetScreenMetrics(IView view, object? nativeView)
		{
			return TryGetListener(view, nativeView)?.Screen;
		}

		protected override object? GetGlobalView(IView view)
		{
			view.TryGet<Object>(out Object rawView);
			return rawView;
		}

		private static EnvironmentNativeListener? TryGetListener(IView view, object? nativeView)
		{
			Object val = (Object)((nativeView is Object) ? nativeView : null);
			if (val == null || val.Handle == (IntPtr)0)
			{
				return null;
			}
			if (!view.TryGet<Object>(out Object rawView))
			{
				return null;
			}
			if (!ViewMugenExtensions.IsViewFromContext(rawView, val))
			{
				return null;
			}
			ArraySegmentEnumerator<EnvironmentNativeListener> enumerator = view.GetComponents<EnvironmentNativeListener>().GetEnumerator();
			while (enumerator.MoveNext())
			{
				EnvironmentNativeListener current = enumerator.Current;
				if (object.Equals(nativeView, current.View))
				{
					return current;
				}
			}
			EnvironmentNativeListener environmentNativeListener = new EnvironmentNativeListener(val);
			if (!view.Components.TryAdd(environmentNativeListener) || view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Clearing) || view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Cleared))
			{
				environmentNativeListener.Cleanup(view);
				return null;
			}
			return environmentNativeListener;
		}
	}
	public class SystemInsetsProvider : SystemInsetsProviderBase
	{
		private sealed class InsetsNativeListener : Object, IInsetsListener, IJavaObject, IDisposable, IJavaPeerable, IApiHandlerComponent<IView, OnLifecycleChangedRequest<IView, ViewLifecycleState, IView>, Unit>, IApiHandlerComponent<IView>, IApiProviderComponent<IView>, IApiProviderComponent, IComponent, ISupportRequestComponent<IView>, IComponent<IView>, ISupportApiHandlerComponent<IView, OnLifecycleChangedRequest<IView, ViewLifecycleState, IView>>
		{
			private readonly WeakRef<Object> _viewRef;

			public Object? View => _viewRef.Target;

			public BindableValue<Thickness> SystemBars { get; }

			public BindableValue<Thickness> Ime { get; }

			public BindableValue<Thickness> Cutout { get; }

			public InsetsNativeListener(Object view)
			{
				_viewRef = view.ToWeakReference<Object>();
				SystemBars = new BindableValue<Thickness>();
				Ime = new BindableValue<Thickness>();
				Cutout = new BindableValue<Thickness>();
				NativeBindableMemberMugenExtensions.ObserveInsets(view, this);
			}

			public void Cleanup(IView? view)
			{
				view?.RemoveComponent(this);
				Object view2 = View;
				if (view2 != null)
				{
					NativeBindableMemberMugenExtensions.ObserveInsets(view2, null);
				}
			}

			public Unit TryInvoke(OnLifecycleChangedRequest<IView, ViewLifecycleState, IView> request, IView apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
			{
				if (View == null || request.LifecycleState.IsInState(ViewLifecycleState.Clearing))
				{
					Cleanup(apiProvider);
				}
				return default(Unit);
			}

			public void OnCutoutChanged(int left, int top, int right, int bottom)
			{
				Cutout.Value = new Thickness(left, top, right, bottom);
			}

			public void OnImeChanged(int left, int top, int right, int bottom)
			{
				Ime.Value = new Thickness(left, top, right, bottom);
			}

			public void OnSystemBarChanged(int left, int top, int right, int bottom)
			{
				SystemBars.Value = new Thickness(left, top, right, bottom);
			}
		}

		protected override bool IsSupported(GetSystemInsetsRequest request, IReadOnlyMetadataContext? metadata)
		{
			SystemInsetType type = request.Type;
			if (!(type == SystemInsetType.SafeArea) && !(type == SystemInsetType.Cutout) && !(type == SystemInsetType.Ime))
			{
				return type == SystemInsetType.SystemBars;
			}
			return true;
		}

		protected override object? GetGlobalView(IView view)
		{
			view.TryGet<Object>(out Object rawView);
			return rawView;
		}

		protected override BindableValue<Thickness>? GetInsets(IView view, SystemInsetType type, object? nativeView)
		{
			Object val = (Object)((nativeView is Object) ? nativeView : null);
			if (val == null || val.Handle == (IntPtr)0)
			{
				return null;
			}
			if (!view.TryGet<Object>(out Object rawView))
			{
				return null;
			}
			if (!ViewMugenExtensions.IsViewFromContext(rawView, val))
			{
				return null;
			}
			ItemOrArray<InsetsNativeListener> components = view.GetComponents<InsetsNativeListener>();
			InsetsNativeListener insetsNativeListener = null;
			ArraySegmentEnumerator<InsetsNativeListener> enumerator = components.GetEnumerator();
			while (enumerator.MoveNext())
			{
				InsetsNativeListener current = enumerator.Current;
				if (object.Equals(nativeView, current.View))
				{
					insetsNativeListener = current;
					break;
				}
			}
			if (insetsNativeListener == null)
			{
				insetsNativeListener = new InsetsNativeListener(val);
				if (!view.Components.TryAdd(insetsNativeListener) || view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Clearing) || view.IsInState((FlagsEnumBase<ViewLifecycleState, long>?)ViewLifecycleState.Cleared))
				{
					insetsNativeListener.Cleanup(view);
					return null;
				}
			}
			if (type == SystemInsetType.Cutout)
			{
				return insetsNativeListener.Cutout;
			}
			if (type == SystemInsetType.Ime)
			{
				return insetsNativeListener.Ime;
			}
			if (type == SystemInsetType.SafeArea || type == SystemInsetType.SystemBars)
			{
				return insetsNativeListener.SystemBars;
			}
			return null;
		}
	}
}
namespace MugenMvvm.CompositeUI.App.Interfaces
{
	public interface IAppErrorInfo : IMetadataOwner<IMetadataContext>, IInner<IAppErrorInfo>
	{
		bool IsFatal { get; }

		object Source { get; }

		object? HandlerSource { get; }

		string? ActionId { get; }

		Exception Exception { get; }

		ValueTask<bool?> RetryAsync(IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);

		void OnCanceled(IReadOnlyMetadataContext? metadata);
	}
	public interface IAppErrorListener
	{
		void OnAdded(IAppErrorInfo error, IReadOnlyMetadataContext? metadata);

		void OnRemoved(IAppErrorInfo error, IReadOnlyMetadataContext? metadata);
	}
	public interface IAppErrorRetryHandler
	{
		object? ErrorSource { get; }

		ValueTask<bool?> RetryAsync(IAppErrorInfo error, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
}
namespace MugenMvvm.CompositeUI.Api
{
	public readonly struct GetAppErrorsRequest : IPooledListApiRequest<IMugenApplication, GetAppErrorsRequest, IAppErrorInfo>, IApiRequestBase<IMugenApplication, GetAppErrorsRequest, PooledReadOnlyList<IAppErrorInfo>>, IApiRequestBase, ICleanableResponseApiRequest<GetAppErrorsRequest, IAppErrorInfo>, ICleanableResponseApiRequestBase<GetAppErrorsRequest, IAppErrorInfo>
	{
		public readonly object Source;

		public GetAppErrorsRequest(object source)
		{
			Should.NotBeNull(source, "source");
			Source = source;
		}
	}
	public readonly struct GetLayoutDirectionRequest : IBindableValueApiRequest<GetLayoutDirectionRequest, LayoutDirType>, IApiRequest<IMugenApplication, GetLayoutDirectionRequest, Bindable<LayoutDirType>>, IApiRequestBase<IMugenApplication, GetLayoutDirectionRequest, Bindable<LayoutDirType>>, IApiRequestBase, ISupportInvokeAllApiRequest<GetLayoutDirectionRequest>, ISupportReverseInvokeApiRequest<GetLayoutDirectionRequest>, IValidatableResponseApiRequest<GetLayoutDirectionRequest, Bindable<LayoutDirType>>, ICleanableResponseApiRequest<GetLayoutDirectionRequest, Bindable<LayoutDirType>>, ICleanableResponseApiRequestBase<GetLayoutDirectionRequest, Bindable<LayoutDirType>>, IBindableValueApiRequest
	{
		public readonly IShellAware Section;

		public readonly bool Relative;

		public GetLayoutDirectionRequest(IShellAware section, bool relative)
		{
			Should.NotBeNull(section, "section");
			Section = section;
			Relative = relative;
		}
	}
	public readonly struct GetScreenMetricsRequest : IBindableValueApiRequest<GetScreenMetricsRequest, ScreenMetrics>, IApiRequest<IMugenApplication, GetScreenMetricsRequest, Bindable<ScreenMetrics>>, IApiRequestBase<IMugenApplication, GetScreenMetricsRequest, Bindable<ScreenMetrics>>, IApiRequestBase, ISupportInvokeAllApiRequest<GetScreenMetricsRequest>, ISupportReverseInvokeApiRequest<GetScreenMetricsRequest>, IValidatableResponseApiRequest<GetScreenMetricsRequest, Bindable<ScreenMetrics>>, ICleanableResponseApiRequest<GetScreenMetricsRequest, Bindable<ScreenMetrics>>, ICleanableResponseApiRequestBase<GetScreenMetricsRequest, Bindable<ScreenMetrics>>, IBindableValueApiRequest
	{
		public readonly IShellAware Section;

		public readonly bool Relative;

		public GetScreenMetricsRequest(IShellAware section, bool relative)
		{
			Should.NotBeNull(section, "section");
			Section = section;
			Relative = relative;
		}
	}
	public class GetSectionModifierRendererRequest : IApiRequest<IMugenApplication, GetSectionModifierRendererRequest, ISectionModifierRenderer>, IApiRequestBase<IMugenApplication, GetSectionModifierRendererRequest, ISectionModifierRenderer>, IApiRequestBase, ISupportInvokeAllApiRequest<GetSectionModifierRendererRequest>, ISupportReverseInvokeApiRequest<GetSectionModifierRendererRequest>, IValidatableResponseApiRequest<GetSectionModifierRendererRequest, ISectionModifierRenderer>, ICleanableResponseApiRequest<GetSectionModifierRendererRequest, ISectionModifierRenderer>, ICleanableResponseApiRequestBase<GetSectionModifierRendererRequest, ISectionModifierRenderer>
	{
		public readonly ISectionModifier Modifier;

		public readonly Type ModifierType;

		public readonly Type ViewType;

		public readonly object Item;

		public GetSectionModifierRendererRequest(object item, ISectionModifier modifier, Type modifierType, Type viewType)
		{
			Should.NotBeNull(item, "item");
			Should.NotBeNull(modifier, "modifier");
			Should.NotBeNull(modifierType, "modifierType");
			Should.NotBeNull(viewType, "viewType");
			Item = item;
			Modifier = modifier;
			ModifierType = modifierType;
			ViewType = viewType;
		}
	}
	public class GetSectionsRequest<TRequest> : GetSectionsRequestBase<GetSectionsRequest<TRequest>, TRequest> where TRequest : class, ISectionApiRequest
	{
		public GetSectionsRequest(IShellSection shell, TRequest request)
			: base(shell, request)
		{
		}
	}
	public abstract class GetSectionsRequestBase
	{
		protected sealed class ScopeAsyncEnumerator : IAsyncEnumerator<ISection>, IAsyncDisposable
		{
			private readonly IAsyncEnumerator<ISection> _enumerator;

			private readonly GetSectionsRequestBase _request;

			private DisposableScopeSection? _scope;

			public ISection Current
			{
				get
				{
					if (_scope != null && _scope != DisposableScopeSection.Disposed)
					{
						return _scope;
					}
					return _enumerator.Current;
				}
			}

			public ScopeAsyncEnumerator(IAsyncEnumerator<ISection> enumerator, GetSectionsRequestBase request)
			{
				_enumerator = enumerator;
				_request = request;
			}

			public ValueTask DisposeAsync()
			{
				return _enumerator.DisposeAsync();
			}

			public async ValueTask<bool> MoveNextAsync()
			{
				if (_scope != null)
				{
					return false;
				}
				try
				{
					if (await _enumerator.MoveNextAsync().ConfigureAwait(continueOnCapturedContext: false))
					{
						return true;
					}
				}
				catch
				{
					Interlocked.Exchange(ref _request._scope, DisposableScopeSection.Disposed)?.Dispose();
					throw;
				}
				_scope = Interlocked.Exchange(ref _request._scope, DisposableScopeSection.Disposed) ?? DisposableScopeSection.Disposed;
				return _scope != DisposableScopeSection.Disposed;
			}
		}

		protected sealed class SuppressDisposeSectionInternal : SuppressDisposeSectionWrapper
		{
			public SuppressDisposeSectionInternal(ISection target)
				: base(target)
			{
			}
		}

		protected sealed class CacheAsyncEnumerator : IAsyncEnumerator<ISection>, IAsyncDisposable
		{
			private readonly IAsyncEnumerator<ISection> _enumerator;

			private readonly GetSectionsRequestBase _request;

			private readonly string _key;

			private PooledItemOrList<ISection> _cache;

			private ISection? _current;

			private bool _isDisposed;

			public ISection Current => _current;

			public CacheAsyncEnumerator(IAsyncEnumerator<ISection> enumerator, GetSectionsRequestBase request, string key)
			{
				_cache = default(PooledItemOrList<ISection>);
				_enumerator = enumerator;
				_request = request;
				_key = key;
				request.BeginCacheScope();
			}

			public ValueTask DisposeAsync()
			{
				if (!_isDisposed)
				{
					_isDisposed = true;
					_cache.Dispose();
					_request.EndCacheScope();
				}
				return _enumerator.DisposeAsync();
			}

			public async ValueTask<bool> MoveNextAsync()
			{
				try
				{
					if (await _enumerator.MoveNextAsync().ConfigureAwait(continueOnCapturedContext: false))
					{
						_current = _enumerator.Current;
						CacheAsyncEnumerator cacheAsyncEnumerator = this;
						ISection current;
						if (_current is SuppressDisposeSectionWrapper)
						{
							current = _current;
						}
						else
						{
							ISection section = new SuppressDisposeSectionInternal(_current);
							current = section;
						}
						cacheAsyncEnumerator._current = current;
						_cache.Add(_current);
						return true;
					}
					object rawValue = _cache.ToItemOrArray().GetRawValue();
					_request.Shell.AttachedValues().Set(_key, rawValue);
					_request.Shell.RegisterDisposeToken(ActionToken.FromDelegate(delegate(object? v, object? _)
					{
						Cleanup(ItemOrArray.FromRawValue<ISection>(v).ReadOnlySpan);
					}, rawValue));
					return false;
				}
				catch
				{
					Cleanup(_cache.ReadOnlySpan);
					throw;
				}
			}

			private static void Cleanup(ReadOnlySpan<ISection> items)
			{
				ReadOnlySpan<ISection> readOnlySpan = items;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if (readOnlySpan[i] is SuppressDisposeSectionInternal suppressDisposeSectionInternal)
					{
						suppressDisposeSectionInternal.Section.Dispose();
					}
				}
			}
		}

		private DisposableScopeSection? _scope;

		private int _cacheScope;

		public IShellSection Shell { get; }

		public object RequestRaw { get; }

		public ISupportDisposeCallback Scope
		{
			get
			{
				if (_cacheScope != 0)
				{
					return Shell;
				}
				if (_scope != null)
				{
					return _scope;
				}
				DisposableScopeSection disposableScopeSection = new DisposableScopeSection();
				return Interlocked.CompareExchange(ref _scope, disposableScopeSection, null) ?? disposableScopeSection;
			}
		}

		protected GetSectionsRequestBase(IShellSection shell, object requestRaw)
		{
			Should.NotBeNull(shell, "shell");
			Should.NotBeNull(requestRaw, "requestRaw");
			Shell = shell;
			RequestRaw = requestRaw;
		}

		public virtual IAsyncEnumerator<ISection> GetSections(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return new ScopeAsyncEnumerator(GetSectionsCore(apiProvider, metadata, cancellationToken), this);
		}

		public void BeginCacheScope()
		{
			Interlocked.Increment(ref _cacheScope);
		}

		public void EndCacheScope()
		{
			Should.BeValid(Interlocked.Decrement(ref _cacheScope) > -1, "Begin < 0");
		}

		protected abstract IAsyncEnumerator<ISection> GetSectionsCore(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public abstract class GetSectionsRequestBase<TRequest> : GetSectionsRequestBase where TRequest : class
	{
		public TRequest Request => Unsafe.As<TRequest>(base.RequestRaw);

		protected GetSectionsRequestBase(IShellSection shell, TRequest request)
			: base(shell, request)
		{
		}
	}
	public abstract class GetSectionsRequestBase<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TSelf, TRequest> : GetSectionsRequestBase<TRequest>, IAsyncEnumeratorApiRequest<IMugenApplication, TSelf, ISection>, IAsyncApiRequestBase<IMugenApplication, TSelf, IAsyncEnumerator<ISection>>, IApiRequestBase<IMugenApplication, TSelf, IAsyncEnumerator<ISection>>, IApiRequestBase, IAsyncApiRequestBase where TSelf : GetSectionsRequestBase<TSelf, TRequest> where TRequest : class
	{
		protected virtual string? CacheId => typeof(TRequest).FullName;

		protected GetSectionsRequestBase(IShellSection shell, TRequest request)
			: base(shell, request)
		{
		}

		public IAsyncEnumerator<ISection> CacheSections(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken, [RequireStaticDelegate] Func<TSelf, IMugenApplication, UnitRef, IReadOnlyMetadataContext?, CancellationToken, IAsyncEnumerator<ISection>> getSections, [CallerLineNumber] int sourceLineNumber = 0)
		{
			return CacheSections(apiProvider, metadata, cancellationToken, UnitRef.Value, getSections, sourceLineNumber);
		}

		public IAsyncEnumerator<ISection> CacheSections<TState>(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken, TState state, [RequireStaticDelegate] Func<TSelf, IMugenApplication, TState, IReadOnlyMetadataContext?, CancellationToken, IAsyncEnumerator<ISection>> getSections, [CallerLineNumber] int sourceLineNumber = 0)
		{
			string value = null;
			if (base.RequestRaw is IHasId<string> hasId)
			{
				value = hasId.Id;
			}
			return CacheSections($"{CacheId}{sourceLineNumber}{value}", apiProvider, metadata, cancellationToken, state, getSections);
		}

		public IAsyncEnumerator<ISection> CacheSections(string key, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken, [RequireStaticDelegate] Func<TSelf, IMugenApplication, UnitRef, IReadOnlyMetadataContext?, CancellationToken, IAsyncEnumerator<ISection>> getSections)
		{
			return CacheSections(key, apiProvider, metadata, cancellationToken, UnitRef.Value, getSections);
		}

		public IAsyncEnumerator<ISection> CacheSections<TState>(string key, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken, TState state, [RequireStaticDelegate] Func<TSelf, IMugenApplication, TState, IReadOnlyMetadataContext?, CancellationToken, IAsyncEnumerator<ISection>> getSections)
		{
			Should.NotBeNull(key, "key");
			Should.NotBeNull(getSections, "getSections");
			if (base.Shell.AttachedValues().TryGet(key, out object value))
			{
				return SynchronousAsyncEnumerable<ISection>.GetEnumerator(ItemOrIEnumerable.FromRawValue<ISection>(value));
			}
			return new CacheAsyncEnumerator(getSections((TSelf)this, apiProvider, state, metadata, cancellationToken), this, key);
		}

		protected override IAsyncEnumerator<ISection> GetSectionsCore(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return ((IApiProvider<IMugenApplication>)apiProvider).TryInvoke((IApiRequestBase<IMugenApplication, TSelf, IAsyncEnumerator<ISection>>)this, metadata, cancellationToken) ?? SynchronousAsyncEnumerable<ISection>.EmptyEnumerator;
		}
	}
	public class GetShellHandlersRequest : IPooledListApiRequest<IMugenApplication, GetShellHandlersRequest, ISection>, IApiRequestBase<IMugenApplication, GetShellHandlersRequest, PooledReadOnlyList<ISection>>, IApiRequestBase, ICleanableResponseApiRequest<GetShellHandlersRequest, ISection>, ICleanableResponseApiRequestBase<GetShellHandlersRequest, ISection>
	{
		public ISectionApiRequest Request { get; }

		public GetShellHandlersRequest(ISectionApiRequest request)
		{
			Should.NotBeNull(request, "request");
			Request = request;
		}
	}
	public class GetShellViewModelRequest : IGetViewModelApiRequest<GetShellViewModelRequest, IShell>, IGetViewModelApiRequest, IApiRequestBase, IApiRequest<IViewModelManager, GetShellViewModelRequest, IShell>, IApiRequestBase<IViewModelManager, GetShellViewModelRequest, IShell>, ISupportInvokeAllApiRequest<GetShellViewModelRequest>, ISupportReverseInvokeApiRequest<GetShellViewModelRequest>, IValidatableResponseApiRequest<GetShellViewModelRequest, IShell>, ICleanableResponseApiRequest<GetShellViewModelRequest, IShell>, ICleanableResponseApiRequestBase<GetShellViewModelRequest, IShell>
	{
		public ISectionApiRequest Request { get; }

		public GetShellViewModelRequest(ISectionApiRequest request)
		{
			Should.NotBeNull(request, "request");
			Request = request;
		}
	}
	public readonly struct GetSystemInsetsRequest : IBindableValueApiRequest<GetSystemInsetsRequest, Thickness>, IApiRequest<IMugenApplication, GetSystemInsetsRequest, Bindable<Thickness>>, IApiRequestBase<IMugenApplication, GetSystemInsetsRequest, Bindable<Thickness>>, IApiRequestBase, ISupportInvokeAllApiRequest<GetSystemInsetsRequest>, ISupportReverseInvokeApiRequest<GetSystemInsetsRequest>, IValidatableResponseApiRequest<GetSystemInsetsRequest, Bindable<Thickness>>, ICleanableResponseApiRequest<GetSystemInsetsRequest, Bindable<Thickness>>, ICleanableResponseApiRequestBase<GetSystemInsetsRequest, Bindable<Thickness>>, IBindableValueApiRequest
	{
		public readonly IShellAware Section;

		public readonly SystemInsetType Type;

		public readonly bool Relative;

		public GetSystemInsetsRequest(IShellAware section, SystemInsetType type, bool relative)
		{
			Should.NotBeNull(section, "section");
			Should.NotBeNull(type, "type");
			Type = type;
			Section = section;
			Relative = relative;
		}
	}
	public class GetTabContentSectionsRequest<TRequest> : GetSectionsRequestBase<GetTabContentSectionsRequest<TRequest>, TRequest> where TRequest : class, ITabSectionApiRequest
	{
		public IShellSection TabSection { get; }

		public GetTabContentSectionsRequest(IShellSection tabSection, IShellSection shell, TRequest request)
			: base(shell, request)
		{
			TabSection = tabSection;
		}
	}
	public class GetTabSectionsRequest<TRequest> : GetSectionsRequestBase<GetTabSectionsRequest<TRequest>, TRequest> where TRequest : class, ISectionApiRequest
	{
		public GetTabSectionsRequest(IShellSection shell, TRequest request)
			: base(shell, request)
		{
		}
	}
	public class GetWorkflowStepSectionsRequest<TRequest> : GetSectionsRequestBase<GetWorkflowStepSectionsRequest<TRequest>, TRequest> where TRequest : class, IWorkflowSectionApiRequest
	{
		public IWorkflowStepInfo Step { get; }

		protected override string CacheId => Step.Id;

		public GetWorkflowStepSectionsRequest(IShellSection shell, TRequest request, IWorkflowStepInfo step)
			: base(shell, request)
		{
			Step = step;
		}
	}
	public class HideKeyboardViewRequest : IVoidAsyncApiRequest<IView, HideKeyboardViewRequest>, IAsyncApiRequestBase<IView, HideKeyboardViewRequest, Task>, IApiRequestBase<IView, HideKeyboardViewRequest, Task>, IApiRequestBase, IAsyncApiRequestBase, ISupportReverseInvokeApiRequest<HideKeyboardViewRequest>
	{
		public static readonly HideKeyboardViewRequest Instance = new HideKeyboardViewRequest();

		protected HideKeyboardViewRequest()
		{
		}
	}
	public class MainSectionRequest : IVoidSectionApiRequest<MainSectionRequest>, ISectionApiRequest<MainSectionRequest, Unit>, ISectionApiRequest<Unit>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, MainSectionRequest, Optional<Unit>>, IValueTaskAsyncApiRequestBase<IMugenApplication, MainSectionRequest, Optional<Unit>>, IAsyncApiRequestBase<IMugenApplication, MainSectionRequest, ValueTask<Optional<Unit>>>, IApiRequestBase<IMugenApplication, MainSectionRequest, ValueTask<Optional<Unit>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<MainSectionRequest>, ISupportReverseInvokeApiRequest<MainSectionRequest>, IValidatableResponseApiRequest<MainSectionRequest, Optional<Unit>>, IAsyncCleanableResponseApiRequest<MainSectionRequest, Optional<Unit>>, ICleanableResponseApiRequestBase<MainSectionRequest, Optional<Unit>>
	{
		public static readonly MainSectionRequest Instance = new MainSectionRequest(clearBackStack: true);

		protected bool ClearBackStack { get; }

		protected MainSectionRequest(bool clearBackStack)
		{
			ClearBackStack = clearBackStack;
		}

		public static ValueTask<Optional<Unit>> TryInvoke(ItemOrArray<IApiProviderComponent<IMugenApplication>> components, MainSectionRequest request, IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			if (request.ClearBackStack)
			{
				metadata = metadata.WithValue(NavigationMetadata.ClearBackStack, value: true);
			}
			return ApiRequestExtensions.ApiRequestAsyncImpl<IMugenApplication, MainSectionRequest, Optional<Unit>>(components, request, apiProvider, metadata, cancellationToken);
		}
	}
	public class OnAppErrorRequest : IAsyncApiRequest<IMugenApplication, OnAppErrorRequest, IAppErrorInfo>, IValueTaskAsyncApiRequestBase<IMugenApplication, OnAppErrorRequest, IAppErrorInfo>, IAsyncApiRequestBase<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, IApiRequestBase<IMugenApplication, OnAppErrorRequest, ValueTask<IAppErrorInfo?>>, IApiRequestBase, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<OnAppErrorRequest>, ISupportReverseInvokeApiRequest<OnAppErrorRequest>, IValidatableResponseApiRequest<OnAppErrorRequest, IAppErrorInfo>, IAsyncCleanableResponseApiRequest<OnAppErrorRequest, IAppErrorInfo>, ICleanableResponseApiRequestBase<OnAppErrorRequest, IAppErrorInfo>
	{
		public readonly object Source;

		public readonly string? ActionId;

		public readonly Exception Exception;

		public readonly IAppErrorRetryHandler? RetryHandler;

		public OnAppErrorRequest(object source, Exception exception, string? actionId, IAppErrorRetryHandler? retryHandler)
		{
			Should.NotBeNull(source, "source");
			Should.NotBeNull(exception, "exception");
			Source = source;
			Exception = exception;
			ActionId = actionId;
			RetryHandler = retryHandler;
		}
	}
	public readonly struct OnCancelAppErrorByIdRequest : IBoolApiRequest<IMugenApplication, OnCancelAppErrorByIdRequest>, IApiRequest<IMugenApplication, OnCancelAppErrorByIdRequest, bool?>, IApiRequestBase<IMugenApplication, OnCancelAppErrorByIdRequest, bool?>, IApiRequestBase, ISupportInvokeAllApiRequest<OnCancelAppErrorByIdRequest>, ISupportReverseInvokeApiRequest<OnCancelAppErrorByIdRequest>, IValidatableResponseApiRequest<OnCancelAppErrorByIdRequest, bool?>, ICleanableResponseApiRequest<OnCancelAppErrorByIdRequest, bool?>, ICleanableResponseApiRequestBase<OnCancelAppErrorByIdRequest, bool?>, IValidResponseAwareApiRequest<OnCancelAppErrorByIdRequest, bool?>
	{
		public readonly object Source;

		public readonly string ActionId;

		public OnCancelAppErrorByIdRequest(object source, string actionId)
		{
			Should.NotBeNull(source, "source");
			Should.NotBeNull(actionId, "actionId");
			Source = source;
			ActionId = actionId;
		}
	}
	public readonly struct OnCancelAppErrorRequest : IBoolApiRequest<IMugenApplication, OnCancelAppErrorRequest>, IApiRequest<IMugenApplication, OnCancelAppErrorRequest, bool?>, IApiRequestBase<IMugenApplication, OnCancelAppErrorRequest, bool?>, IApiRequestBase, ISupportInvokeAllApiRequest<OnCancelAppErrorRequest>, ISupportReverseInvokeApiRequest<OnCancelAppErrorRequest>, IValidatableResponseApiRequest<OnCancelAppErrorRequest, bool?>, ICleanableResponseApiRequest<OnCancelAppErrorRequest, bool?>, ICleanableResponseApiRequestBase<OnCancelAppErrorRequest, bool?>, IValidResponseAwareApiRequest<OnCancelAppErrorRequest, bool?>
	{
		public readonly IAppErrorInfo Error;

		public OnCancelAppErrorRequest(IAppErrorInfo error)
		{
			Should.NotBeNull(error, "error");
			Error = error;
		}
	}
	public readonly struct RegisterAppErrorListenerRequest : IBoolApiRequest<IMugenApplication, RegisterAppErrorListenerRequest>, IApiRequest<IMugenApplication, RegisterAppErrorListenerRequest, bool?>, IApiRequestBase<IMugenApplication, RegisterAppErrorListenerRequest, bool?>, IApiRequestBase, ISupportInvokeAllApiRequest<RegisterAppErrorListenerRequest>, ISupportReverseInvokeApiRequest<RegisterAppErrorListenerRequest>, IValidatableResponseApiRequest<RegisterAppErrorListenerRequest, bool?>, ICleanableResponseApiRequest<RegisterAppErrorListenerRequest, bool?>, ICleanableResponseApiRequestBase<RegisterAppErrorListenerRequest, bool?>, IValidResponseAwareApiRequest<RegisterAppErrorListenerRequest, bool?>
	{
		public readonly object Source;

		public readonly IAppErrorListener Listener;

		public RegisterAppErrorListenerRequest(object source, IAppErrorListener listener)
		{
			Should.NotBeNull(source, "source");
			Should.NotBeNull(listener, "listener");
			Source = source;
			Listener = listener;
		}
	}
	public class ResetLayoutViewRequest : IVoidAsyncApiRequest<IView, ResetLayoutViewRequest>, IAsyncApiRequestBase<IView, ResetLayoutViewRequest, Task>, IApiRequestBase<IView, ResetLayoutViewRequest, Task>, IApiRequestBase, IAsyncApiRequestBase, ISupportReverseInvokeApiRequest<ResetLayoutViewRequest>
	{
		public static readonly ResetLayoutViewRequest Instance = new ResetLayoutViewRequest();

		protected ResetLayoutViewRequest()
		{
		}
	}
	public readonly struct ShowShellRequest : IShowNavigationApiRequest<ShowShellRequest>, IShowNavigationApiRequest, IApiRequestBase, IHasNavigationTarget, IPooledListApiRequest<INavigationDispatcher, ShowShellRequest, NavigationResult>, IApiRequestBase<INavigationDispatcher, ShowShellRequest, PooledReadOnlyList<NavigationResult>>, ICleanableResponseApiRequest<ShowShellRequest, NavigationResult>, ICleanableResponseApiRequestBase<ShowShellRequest, NavigationResult>, IHasViewModel
	{
		public IShell Shell { get; }

		public ISectionApiRequest Request { get; }

		object IHasNavigationTarget.Target => Shell;

		object IHasViewModel.ViewModel => Shell;

		public ShowShellRequest(IShell shell, ISectionApiRequest request)
		{
			Should.NotBeNull(shell, "shell");
			Should.NotBeNull(request, "request");
			Shell = shell;
			Request = request;
		}
	}
	public readonly struct UnregisterAppErrorListenerRequest : IBoolApiRequest<IMugenApplication, UnregisterAppErrorListenerRequest>, IApiRequest<IMugenApplication, UnregisterAppErrorListenerRequest, bool?>, IApiRequestBase<IMugenApplication, UnregisterAppErrorListenerRequest, bool?>, IApiRequestBase, ISupportInvokeAllApiRequest<UnregisterAppErrorListenerRequest>, ISupportReverseInvokeApiRequest<UnregisterAppErrorListenerRequest>, IValidatableResponseApiRequest<UnregisterAppErrorListenerRequest, bool?>, ICleanableResponseApiRequest<UnregisterAppErrorListenerRequest, bool?>, ICleanableResponseApiRequestBase<UnregisterAppErrorListenerRequest, bool?>, IValidResponseAwareApiRequest<UnregisterAppErrorListenerRequest, bool?>
	{
		public readonly object Source;

		public readonly IAppErrorListener Listener;

		public UnregisterAppErrorListenerRequest(object source, IAppErrorListener listener)
		{
			Should.NotBeNull(source, "source");
			Should.NotBeNull(listener, "listener");
			Source = source;
			Listener = listener;
		}
	}
}
namespace MugenMvvm.CompositeUI.Api.Interfaces
{
	public interface IGetSectionsApiDecorator<TRequest> : IApiHandlerDecorator<IMugenApplication, GetSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, GetSectionsRequest<TRequest>>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>> where TRequest : class, ISectionApiRequest
	{
	}
	public interface IGetSectionsApiHandler<TRequest> : IApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>> where TRequest : class, ISectionApiRequest
	{
	}
	public interface IGetTabContentSectionsApiDecorator<TRequest> : IApiHandlerDecorator<IMugenApplication, GetTabContentSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, GetTabContentSectionsRequest<TRequest>>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, GetTabContentSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetTabContentSectionsRequest<TRequest>> where TRequest : class, ITabSectionApiRequest
	{
	}
	public interface IGetTabContentSectionsApiHandler<TRequest> : IApiHandlerComponent<IMugenApplication, GetTabContentSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetTabContentSectionsRequest<TRequest>> where TRequest : class, ITabSectionApiRequest
	{
	}
	public interface IGetTabSectionsApiHandler<TRequest> : IApiHandlerComponent<IMugenApplication, GetTabSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetTabSectionsRequest<TRequest>> where TRequest : class, ISectionApiRequest
	{
	}
	public interface IGetWorkflowSectionsApiHandler<TRequest> : IApiHandlerComponent<IMugenApplication, GetWorkflowStepSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, IComponent, ISupportRequestComponent<IMugenApplication>, IComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetWorkflowStepSectionsRequest<TRequest>>, IApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, ISupportApiHandlerComponent<IMugenApplication, GetSectionsRequest<TRequest>> where TRequest : class, IWorkflowSectionApiRequest
	{
	}
	public interface IGetWorkflowStepSectionsApiDecorator<TRequest> : IApiHandlerDecorator<IMugenApplication, GetWorkflowStepSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, ISingleAttachableDecorator<IMugenApplication, IApiProviderComponent<IMugenApplication>, GetWorkflowStepSectionsRequest<TRequest>>, IDecoratorComponentBase, IHasComponentCollectionHandlerComponent, IAttachableComponentBase, IHasPriority, ISingleAttachableComponent<IMugenApplication>, IAttachableComponent<IMugenApplication>, IComponent<IMugenApplication>, IComponent, IApiHandlerComponent<IMugenApplication, GetWorkflowStepSectionsRequest<TRequest>, IAsyncEnumerator<ISection>>, IApiHandlerComponent<IMugenApplication>, IApiProviderComponent<IMugenApplication>, IApiProviderComponent, ISupportRequestComponent<IMugenApplication>, ISupportApiHandlerComponent<IMugenApplication, GetWorkflowStepSectionsRequest<TRequest>> where TRequest : class, IWorkflowSectionApiRequest
	{
	}
	public interface IHasCloseHandlerSectionApiRequest<T> : ISectionApiRequest, IApiRequestBase
	{
		ValueTask<Optional<T>> HandleAsync(IMugenApplication application, IShell? shell, Optional<T> result, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface IHasNestedSectionApiRequest<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult> : ISectionApiRequest<TRequest, TResult>, ISectionApiRequest<TResult>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, TRequest, Optional<TResult>>, IValueTaskAsyncApiRequestBase<IMugenApplication, TRequest, Optional<TResult>>, IAsyncApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<TRequest>, ISupportReverseInvokeApiRequest<TRequest>, IValidatableResponseApiRequest<TRequest, Optional<TResult>>, IAsyncCleanableResponseApiRequest<TRequest, Optional<TResult>>, ICleanableResponseApiRequestBase<TRequest, Optional<TResult>>, IHasOpenHandlerSectionApiRequest<TResult> where TRequest : class, IHasNestedSectionApiRequest<TRequest, TResult>
	{
		ISectionApiRequest<TResult>? TryGetWorkflowSectionRequest(IReadOnlyMetadataContext? metadata);

		ValueTask<Optional<Optional<TResult>>> IHasOpenHandlerSectionApiRequest<TResult>.HandleAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			ISectionApiRequest<TResult> sectionApiRequest = TryGetWorkflowSectionRequest(metadata);
			if (sectionApiRequest == null)
			{
				return default(ValueTask<Optional<Optional<TResult>>>);
			}
			ValueTask<Optional<TResult>> valueTask = sectionApiRequest.OpenAsync(application, metadata, cancellationToken);
			if (valueTask.IsCompletedSuccessfully)
			{
				return new ValueTask<Optional<Optional<TResult>>>(valueTask.Result);
			}
			return valueTask.AsTask().ContinueWith(delegate(Task<Optional<TResult>> t, object? s)
			{
				(s as IDisposable)?.Dispose();
				return Optional.Get(t.Result);
			}, sectionApiRequest, cancellationToken, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Current).AsValueTask();
		}
	}
	public interface IHasOpenConditionSectionApiRequest : ISectionApiRequest, IApiRequestBase
	{
		ValueTask<bool> CanOpenAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface IHasOpenHandlerSectionApiRequest<T> : ISectionApiRequest, IApiRequestBase
	{
		ValueTask<Optional<Optional<T>>> HandleAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface IHasShellSectionsSectionApiRequest : ISectionApiRequest, IApiRequestBase
	{
		void AddShellSections(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections);
	}
	public interface IModalSectionRequest : ISectionApiRequest, IApiRequestBase
	{
		bool IsModal { get; }
	}
	public interface ISectionApiRequest : IApiRequestBase
	{
		bool IsReloadOnReopen => true;

		GetSectionsRequestBase GetSectionsRequest(IShellSection shell, IReadOnlyMetadataContext? metadata);

		Task OpenAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);

		TResponse TryInvoke<TResponse>(ISectionApiRequestHandler handler, IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface ISectionApiRequest<TResult> : ISectionApiRequest, IApiRequestBase
	{
		new ValueTask<Optional<TResult>> OpenAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface ISectionApiRequest<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult> : ISectionApiRequest<TResult>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, TRequest, Optional<TResult>>, IValueTaskAsyncApiRequestBase<IMugenApplication, TRequest, Optional<TResult>>, IAsyncApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<TRequest>, ISupportReverseInvokeApiRequest<TRequest>, IValidatableResponseApiRequest<TRequest, Optional<TResult>>, IAsyncCleanableResponseApiRequest<TRequest, Optional<TResult>>, ICleanableResponseApiRequestBase<TRequest, Optional<TResult>> where TRequest : class, ISectionApiRequest<TRequest, TResult>
	{
		GetSectionsRequestBase ISectionApiRequest.GetSectionsRequest(IShellSection shell, IReadOnlyMetadataContext? metadata)
		{
			return new GetSectionsRequest<TRequest>(shell, (TRequest)this);
		}

		Task ISectionApiRequest.OpenAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return application.TryInvoke<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>((TRequest)this, metadata, cancellationToken).AsVoidTask();
		}

		TResponse ISectionApiRequest.TryInvoke<TResponse>(ISectionApiRequestHandler handler, IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return (TResponse)(object)handler.HandleGeneric<TResult>(this, application, metadata, cancellationToken);
		}

		ValueTask<Optional<TResult>> ISectionApiRequest<TResult>.OpenAsync(IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken)
		{
			return application.TryInvoke<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>((TRequest)this, metadata, cancellationToken);
		}
	}
	public interface ISectionApiRequestHandler
	{
		ValueTask<Optional<TResult>> HandleGeneric<TResult>(ISectionApiRequest request, IMugenApplication application, IReadOnlyMetadataContext? metadata, CancellationToken cancellationToken);
	}
	public interface IShellLayoutSectionApiRequest<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult> : ISectionApiRequest<TRequest, TResult>, ISectionApiRequest<TResult>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, TRequest, Optional<TResult>>, IValueTaskAsyncApiRequestBase<IMugenApplication, TRequest, Optional<TResult>>, IAsyncApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<TRequest>, ISupportReverseInvokeApiRequest<TRequest>, IValidatableResponseApiRequest<TRequest, Optional<TResult>>, IAsyncCleanableResponseApiRequest<TRequest, Optional<TResult>>, ICleanableResponseApiRequestBase<TRequest, Optional<TResult>>, IHasShellSectionsSectionApiRequest where TRequest : class, IShellLayoutSectionApiRequest<TRequest, TResult>
	{
		protected IShellLayoutSection GetLayout(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections);

		void IHasShellSectionsSectionApiRequest.AddShellSections(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections)
		{
			IShellLayoutSection layout = GetLayout(apiProvider, metadata, ref sections);
			sections.Add(layout);
		}
	}
	public interface ITabSectionApiRequest : IHasId<string>
	{
		GetSectionsRequestBase GetSectionsRequest(IShellSection tabSection, IShellSection contentSection, IReadOnlyMetadataContext? metadata);
	}
	public interface ITabSectionApiRequest<TRequest> : ITabSectionApiRequest, IHasId<string> where TRequest : class, ITabSectionApiRequest<TRequest>
	{
		GetSectionsRequestBase ITabSectionApiRequest.GetSectionsRequest(IShellSection tabSection, IShellSection contentSection, IReadOnlyMetadataContext? metadata)
		{
			return new GetTabContentSectionsRequest<TRequest>(tabSection, contentSection, (TRequest)this);
		}
	}
	public interface IVoidSectionApiRequest<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] TRequest> : ISectionApiRequest<TRequest, Unit>, ISectionApiRequest<Unit>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, TRequest, Optional<Unit>>, IValueTaskAsyncApiRequestBase<IMugenApplication, TRequest, Optional<Unit>>, IAsyncApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<Unit>>>, IApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<Unit>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<TRequest>, ISupportReverseInvokeApiRequest<TRequest>, IValidatableResponseApiRequest<TRequest, Optional<Unit>>, IAsyncCleanableResponseApiRequest<TRequest, Optional<Unit>>, ICleanableResponseApiRequestBase<TRequest, Optional<Unit>> where TRequest : class, IVoidSectionApiRequest<TRequest>
	{
	}
	public interface IWorkflowSectionApiRequest : ISectionApiRequest, IApiRequestBase
	{
		IWorkflowStepInfo? DefaultStep => null;

		GetSectionsRequestBase GetSectionsRequest(IShellSection shell, IWorkflowStepInfo step, IReadOnlyMetadataContext? metadata);
	}
	public interface IWorkflowSectionApiRequest<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.PublicEvents | DynamicallyAccessedMemberTypes.Interfaces)] TRequest, TResult> : ISectionApiRequest<TRequest, TResult>, ISectionApiRequest<TResult>, ISectionApiRequest, IApiRequestBase, IAsyncApiRequest<IMugenApplication, TRequest, Optional<TResult>>, IValueTaskAsyncApiRequestBase<IMugenApplication, TRequest, Optional<TResult>>, IAsyncApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IApiRequestBase<IMugenApplication, TRequest, ValueTask<Optional<TResult>>>, IAsyncApiRequestBase, ISupportInvokeAllApiRequest<TRequest>, ISupportReverseInvokeApiRequest<TRequest>, IValidatableResponseApiRequest<TRequest, Optional<TResult>>, IAsyncCleanableResponseApiRequest<TRequest, Optional<TResult>>, ICleanableResponseApiRequestBase<TRequest, Optional<TResult>>, IWorkflowSectionApiRequest where TRequest : class, IWorkflowSectionApiRequest<TRequest, TResult>
	{
		GetSectionsRequestBase IWorkflowSectionApiRequest.GetSectionsRequest(IShellSection shell, IWorkflowStepInfo step, IReadOnlyMetadataContext? metadata)
		{
			return new GetWorkflowStepSectionsRequest<TRequest>(shell, (TRequest)this, step);
		}
	}
}
[StructLayout(LayoutKind.Auto)]
[InlineArray(2)]
internal struct DecompiledInlineArray2<T>
{
}
[CompilerGenerated]
internal sealed class DecompiledReadOnlySingleElementList<T> : IEnumerable, ICollection, IList, IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{
	private sealed class Enumerator : IDisposable, IEnumerator, IEnumerator<T>
	{
		object IEnumerator.Current => _item;

		T IEnumerator<T>.Current => _item;

		public Enumerator(T item)
		{
			_item = item;
		}

		bool IEnumerator.MoveNext()
		{
			if (!_moveNextCalled)
			{
				return _moveNextCalled = true;
			}
			return false;
		}

		void IEnumerator.Reset()
		{
			_moveNextCalled = false;
		}

		void IDisposable.Dispose()
		{
		}
	}

	int ICollection.Count => 1;

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot => this;

	object? IList.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	bool IList.IsFixedSize => true;

	bool IList.IsReadOnly => true;

	int IReadOnlyCollection<T>.Count => 1;

	T IReadOnlyList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
	}

	int ICollection<T>.Count => 1;

	bool ICollection<T>.IsReadOnly => true;

	T IList<T>.this[int index]
	{
		get
		{
			if (index != 0)
			{
				throw new IndexOutOfRangeException();
			}
			return _item;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public DecompiledReadOnlySingleElementList(T item)
	{
		_item = item;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(_item);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		array.SetValue(_item, index);
	}

	int IList.Add(object? value)
	{
		throw new NotSupportedException();
	}

	void IList.Clear()
	{
		throw new NotSupportedException();
	}

	bool IList.Contains(object? value)
	{
		return EqualityComparer<T>.Default.Equals(_item, (T)value);
	}

	int IList.IndexOf(object? value)
	{
		if (!EqualityComparer<T>.Default.Equals(_item, (T)value))
		{
			return -1;
		}
		return 0;
	}

	void IList.Insert(int index, object? value)
	{
		throw new NotSupportedException();
	}

	void IList.Remove(object? value)
	{
		throw new NotSupportedException();
	}

	void IList.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(_item);
	}

	void ICollection<T>.Add(T item)
	{
		throw new NotSupportedException();
	}

	void ICollection<T>.Clear()
	{
		throw new NotSupportedException();
	}

	bool ICollection<T>.Contains(T item)
	{
		return EqualityComparer<T>.Default.Equals(_item, item);
	}

	void ICollection<T>.CopyTo(T[] array, int arrayIndex)
	{
		array[arrayIndex] = _item;
	}

	bool ICollection<T>.Remove(T item)
	{
		throw new NotSupportedException();
	}

	int IList<T>.IndexOf(T item)
	{
		if (!EqualityComparer<T>.Default.Equals(_item, item))
		{
			return -1;
		}
		return 0;
	}

	void IList<T>.Insert(int index, T item)
	{
		throw new NotSupportedException();
	}

	void IList<T>.RemoveAt(int index)
	{
		throw new NotSupportedException();
	}
}
