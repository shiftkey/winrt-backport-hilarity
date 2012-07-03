using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IApplicationViewStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class ApplicationView
	{
		public static extern ApplicationViewState Value
		{
			get;
		}
		public static extern bool TryUnsnap();
	}
}
