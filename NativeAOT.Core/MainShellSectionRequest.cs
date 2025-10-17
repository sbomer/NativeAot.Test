using System.Diagnostics.CodeAnalysis;
using MugenMvvm.App.Enums;
using MugenMvvm.App.Interfaces;
using MugenMvvm.Bindings;
using MugenMvvm.Collections;
using MugenMvvm.Common;
using MugenMvvm.CompositeUI;
using MugenMvvm.CompositeUI.Api.Interfaces;
using MugenMvvm.CompositeUI.Common;
using MugenMvvm.CompositeUI.Enums;
using MugenMvvm.CompositeUI.Sections.Interfaces;
using MugenMvvm.CompositeUI.Sections.Visuals.Interfaces;
using MugenMvvm.CompositeUI.States;
using MugenMvvm.Extensions;
using MugenMvvm.Metadata.Interfaces;
using static MugenMvvm.CompositeUI.SectionKit;

namespace NativeAOT.Core;

public class MainShellSectionRequest : IShellLayoutSectionApiRequest<MainShellSectionRequest, Unit>
{
    public static readonly MainShellSectionRequest Instance = new();

    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(LinkerInclude))]
    public IShellLayoutSection GetLayout(IMugenApplication apiProvider, IReadOnlyMetadataContext? metadata, ref PooledListSlim<ISection> sections)
    {
        var state = new ScreenState();
        sections.Add(state);

        return ShellLayout(state.Shell
                                .Combine(state.AppLifecycleState, (shell, f) => (initialized: shell != null && f.HasFlag(ApplicationLifecycleState.Initialized), shell))
                                .UseLatestDisposable((v, _) => v.initialized ? GetMainLayout(v.shell!) : GetSplashScreen()));
    }

    private IVisualSection GetSplashScreen() =>
        Frame(
                Text("Hello Splash").WithGravity(GravityFlags.Center)
            )
            .WithBackgroundColor(Color.Cyan)
            .WithSize(SizeF.MatchParentMatchParent);

    private IVisualSection GetMainLayout(IShell shell)
    {
        return Frame(
                   Text("Hello NativeAOT").WithGravity(GravityFlags.Center)
               )
               .WithBackgroundColor(Color.Gray)
               .WithSize(SizeF.MatchParentMatchParent);
    }
}