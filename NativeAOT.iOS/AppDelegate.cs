using MugenMvvm.App;
using MugenMvvm.CompositeUI;
using MugenMvvm.iOS;
using NativeAOT.Core;

namespace NativeAOT.iOS;

[Register("AppDelegate")]
public class AppDelegate : MugenApplicationDelegate
{
    public override UISceneConfiguration GetConfiguration(UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options) =>
        new("Default Configuration", connectingSceneSession.Role);

    public override void DidDiscardSceneSessions(UIApplication application, NSSet<UISceneSession> sceneSessions)
    {
    }

    protected override void Initialize(UIApplication application, NSDictionary? launchOptions) =>
        MugenApplicationConfiguration.Configure()
                                     .UseCompositeUIShell(mainSectionRequest: MainShellSectionRequest.Instance)
                                     .Initialize();
}