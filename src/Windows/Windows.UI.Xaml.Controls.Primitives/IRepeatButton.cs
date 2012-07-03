using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RepeatButton)), Guid(35655161u, 538, 18506, 169, 59, 15, 49, 2, 3, 20, 229), Version(100794368u), WebHostHidden]
	internal interface IRepeatButton
	{
		int Delay
		{
			get;
			set;
		}
		int Interval
		{
			get;
			set;
		}
	}
}
