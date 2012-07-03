using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
namespace Windows.UI.WebUI
{
	[Guid(1358030640u, 50641, 19307, 154, 219, 138, 17, 117, 107, 226, 156), Version(100794368u)]
	public delegate void ActivatedEventHandler([In] object sender, [In] IActivatedEventArgs eventArgs);
}
