using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(RepeatBehaviorHelper)), Guid(2054770739u, 31219, 19929, 178, 103, 156, 245, 15, 181, 31, 132), Version(100794368u), WebHostHidden]
	internal interface IRepeatBehaviorHelperStatics
	{
		RepeatBehavior Forever
		{
			get;
		}
		RepeatBehavior FromCount([In] double count);
		RepeatBehavior FromDuration([In] TimeSpan duration);
		bool GetHasCount([In] RepeatBehavior target);
		bool GetHasDuration([In] RepeatBehavior target);
		bool Equals([In] RepeatBehavior target, [In] RepeatBehavior value);
	}
}
