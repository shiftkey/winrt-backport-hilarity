using System;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class FrameworkViewSource : IFrameworkViewSource, Windows.ApplicationModel.Core.IFrameworkViewSource
	{
		public extern FrameworkViewSource();
		public extern Windows.ApplicationModel.Core.IFrameworkView CreateView();
	}
}
