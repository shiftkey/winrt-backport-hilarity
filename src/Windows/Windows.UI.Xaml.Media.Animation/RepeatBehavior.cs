using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Version(100794368u), WebHostHidden]
	public struct RepeatBehavior
	{
		public double Count;
		public TimeSpan Duration;
		public RepeatBehaviorType Type;
	}
}
