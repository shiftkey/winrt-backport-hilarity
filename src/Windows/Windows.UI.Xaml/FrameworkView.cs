using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class FrameworkView : IFrameworkView, Windows.ApplicationModel.Core.IFrameworkView
	{
		public extern FrameworkView();
		public extern void Initialize([In] CoreApplicationView applicationView);
		public extern void SetWindow([In] CoreWindow window);
		public extern void Load([In] string entryPoint);
		public extern void Run();
		public extern void Uninitialize();
	}
}
