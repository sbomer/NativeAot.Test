using Android.Content;
using MugenMvvm.Android.Native;
using MugenMvvm.Android.Native.Constants;
using MugenMvvm.App;
using MugenMvvm.CompositeUI;
using NativeAOT.Core;

namespace NativeAOT.Android;

[ContentProvider(["com.nativeaot.android"], Exported = false, InitOrder = 1)]
public class AppBootstrapper : MugenBootstrapperBase
{
    protected override void Initialize()
    {
        MugenApplicationConfiguration.Configure()
                                     .UseCompositeUIShell(mainSectionRequest: MainShellSectionRequest.Instance)
                                     .Initialize();
    }

    protected override int Flags =>
#if DEBUG
        AndroidInitializationFlags.Debug |
#endif
        AndroidInitializationFlags.NativeMode | AndroidInitializationFlags.NoAppState | AndroidInitializationFlags.MaterialLib | AndroidInitializationFlags.SwipeRefreshLib;
}