using MugenMvvm.Api.Interfaces;
using MugenMvvm.Bindings.Api;
using MugenMvvm.Common;
using MugenMvvm.Components;
using MugenMvvm.Views.Interfaces;

namespace NativeAOT.Core;

public static class LinkerInclude
{
    public static void Include()
    {
        //todo bug with aot linking
        // _ = ComponentDescriptor.Impl<IViewManager, IApiProviderComponent<IViewManager>, BindingBuilderRequest<InlineObjectTuple>>.EmptyInstance;
    }
}