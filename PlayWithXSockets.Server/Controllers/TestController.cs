using System.Diagnostics;
using System.Runtime.InteropServices;
using XSockets.Core.Common.Socket.Event.Attributes;
using XSockets.Core.XSocket;
using XSockets.Core.XSocket.Helpers;
using XSockets.Plugin.Framework.Attributes;

namespace PlayWithXSockets.Server.Controllers
{
    [XSocketMetadata(PluginAlias = "Test")]
    public class TestController : XSocketController
    {
        [NoEvent]
        public object State { get; set; }

        public TestController()
        {
            this.OnOpen += TimeController_OnOpen;
        }

        void TimeController_OnOpen(object sender, XSockets.Core.Common.Socket.Event.Arguments.OnClientConnectArgs e)
        {
            Debug.WriteLine(this.GetHashCode());
            State = new object();
        }

        public void Test()
        {
            Debug.WriteLine(this.GetHashCode());
            Debug.Assert(State != null, "State != null");
        }
    }
}
