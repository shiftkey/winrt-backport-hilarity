using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDurationHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DurationHelper : IDurationHelper
	{
		public static extern Duration Automatic
		{
			get;
		}
		public static extern Duration Forever
		{
			get;
		}
		public static extern int Compare([In] Duration duration1, [In] Duration duration2);
		public static extern Duration FromTimeSpan([In] TimeSpan timeSpan);
		public static extern bool GetHasTimeSpan([In] Duration target);
		public static extern Duration Add([In] Duration target, [In] Duration duration);
		public static extern bool Equals([In] Duration target, [In] Duration value);
		public static extern Duration Subtract([In] Duration target, [In] Duration duration);
	}
}
