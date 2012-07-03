using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGridLengthHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GridLengthHelper : IGridLengthHelper
	{
		public static extern GridLength Auto
		{
			get;
		}
		public static extern GridLength FromPixels([In] double pixels);
		public static extern GridLength FromValueAndType([In] double value, [In] GridUnitType type);
		public static extern bool GetIsAbsolute([In] GridLength target);
		public static extern bool GetIsAuto([In] GridLength target);
		public static extern bool GetIsStar([In] GridLength target);
		public static extern bool Equals([In] GridLength target, [In] GridLength value);
	}
}
