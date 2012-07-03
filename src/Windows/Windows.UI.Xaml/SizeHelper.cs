using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISizeHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SizeHelper : ISizeHelper
	{
		public static extern Size Empty
		{
			get;
		}
		public static extern Size FromDimensions([In] float width, [In] float height);
		public static extern bool GetIsEmpty([In] Size target);
		public static extern bool Equals([In] Size target, [In] Size value);
	}
}
