using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPointHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PointHelper : IPointHelper
	{
		public static extern Point FromCoordinates([In] float x, [In] float y);
	}
}
