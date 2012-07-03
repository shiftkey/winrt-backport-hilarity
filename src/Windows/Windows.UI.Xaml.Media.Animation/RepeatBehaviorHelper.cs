using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRepeatBehaviorHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RepeatBehaviorHelper : IRepeatBehaviorHelper
	{
		public static extern RepeatBehavior Forever
		{
			get;
		}
		public static extern RepeatBehavior FromCount([In] double count);
		public static extern RepeatBehavior FromDuration([In] TimeSpan duration);
		public static extern bool GetHasCount([In] RepeatBehavior target);
		public static extern bool GetHasDuration([In] RepeatBehavior target);
		public static extern bool Equals([In] RepeatBehavior target, [In] RepeatBehavior value);
	}
}
