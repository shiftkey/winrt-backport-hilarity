using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDesignModeStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class DesignMode
	{
		public static extern bool DesignModeEnabled
		{
			get;
		}
	}
}
