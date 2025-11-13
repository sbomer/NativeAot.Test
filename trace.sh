#!/usr/bin/env bash

# Grep command:
# grep -e 'ComponentDescriptor+Impl`3&lt;MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1&lt;MugenMvvm.Views.Interfaces.IViewManager&gt;,MugenMvvm.' ./NativeAOT.Android/obj/Release/net10.0-android/android-x64/native/NativeAOT.Android.codegen.dgml.xml


# This is the EETypeNode!!!
# _ZTV323MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>

# This type misses a vtable
# Impl`3<MugenMvvm.Views.Interfaces.IViewManager, MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>, MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>
# node='Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>'
node='IApiProviderComponent`1<System.__Canon>.TryInvoke<BindingBuilderRequest`1<InlineObjectTuple>,__Canon>(BindingBuilderRequest`1<InlineObjectTuple>,__Canon,IReadOnlyMetadataContext,CancellationToken)'
# node="MugenMvvm_Android_MugenMvvm_Android_Views_ResourceViewMappingDecorator___ctor"
dotnet run --project ~/src/runtime2/src/coreclr/tools/aot/DependencyGraphCli/ -- \
    --ui \
    ./NativeAOT.Android/obj/Release/net10.0-android/android-x64/native/NativeAOT.Android.scan.dgml.xml \
    --node 677431
    # --path-to-root --node 677431
    # --list --filter 'NativeLayoutTemplateTypeLayoutVertexNode_MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<TOwner_System___Canon__T_System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>'
    # --list --filter '(__NONGCSTATICSMugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>, NativeLayoutTemplateTypeLayoutVertexNode_MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<TOwner_System___Canon__T_System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>)'
    # --list --filter 'MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>'
    # --path-to-root --node 678031
    # --list --filter '.*ComponentDescriptor\+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,.*'
    # --list --filter '.*ResourceViewMappingDecorator.*construct'
    # --path-to-root --node 474503
    # --list --filter 'ResourceViewMappingDecorator.TryInvoke<BindingBuilderRequest`1<InlineObjectTuple'
    # --list --filter 'ApiProviderDecoratorBase`1<MugenMvvm.Views.Interfaces.IViewManager>.TryInvoke<'
    # --path-t# o-root --node 755216
    # --list --filter '
    # --list --filter 'IApiProviderComponent`1<System.__Canon>.TryInvoke<BindingBuilderRequest`1<InlineObjectTuple>,__Canon>'
    
    # --path-to-root --node "$node"
    # --path-to-root \
    # --node '[MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>..cctor() backed by MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>___cctor'
    # --path-to-root \
    # --node MugenMvvm_Android_MugenMvvm_Android_Views_ResourceViewMappingDecorator___ctor --path-to-root
    # --list --filter "$node"
    # ./NativeAOT.Android/obj/Release/net10.0-android/android-x64/native/NativeAOT.Android.codegen.dgml.xml \
    # --node 562546 --path-to-root # for codegen graph
    # --node 260800 --path-to-root

# CodeGen:
# Index: 407991, Name: Reflectable field: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.TrackerId
# Index: 407992, Name: Reflectable field: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.EmptyInstance
# Index: 407993, Name: Reflectable field: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.SingleItemInstance
# Index: 407994, Name: Reflectable field: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.ArrayInstance
# Index: 562543, Name: Static base info: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>
# Index: 562546, Name: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>..cctor() backed by MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>___cctor
# Index: 631010, Name: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.GetDescriptor(int32) backed by MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>__GetDescriptor
# Index: 631392, Name: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>..ctor(int32) backed by MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>___ctor
# [sven@diane NativeAot.Test]$ ./trace.sh
# Path to Root:
#   Start -> Index: 562546, Name: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>..cctor() backed by MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>___cctor
#   Step -> Index: 833638, Name: (__GenericDict_MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>, MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<System___Canon__System___Canon__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>___cctor)
#   Step -> Index: 282264, Name: __GenericDict_MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>>
#   Step -> Index: 187967, Name: _ZTV323MugenMvvm_MugenMvvm_Components_ComponentDescriptor_Impl_3<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager__MugenMvvm_MugenMvvm_Api_Interfaces_IApiProviderComponent_1<MugenMvvm_MugenMvvm_Views_Interfaces_IViewManager>__MugenMvvm_MugenMvvm_Bindings_Api_BindingBuilderRequest_1<MugenMvvm_MugenMvvm_Common_InlineObjectTuple>> constructed
#   Step -> Index: 407994, Name: Reflectable field: [MugenMvvm]MugenMvvm.Components.ComponentDescriptor+Impl`3<MugenMvvm.Views.Interfaces.IViewManager,MugenMvvm.Api.Interfaces.IApiProviderComponent`1<MugenMvvm.Views.Interfaces.IViewManager>,MugenMvvm.Bindings.Api.BindingBuilderRequest`1<MugenMvvm.Common.InlineObjectTuple>>.ArrayInstance
#   Root -> Index: 750876, Name: Reflection
