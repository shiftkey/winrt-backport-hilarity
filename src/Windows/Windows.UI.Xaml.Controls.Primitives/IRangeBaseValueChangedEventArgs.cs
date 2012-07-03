using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(RangeBaseValueChangedEventArgs)), Guid(2710706039u, 54721, 20380, 167, 176, 4, 1, 183, 230, 220, 92), Version(100794368u), WebHostHidden]
	internal interface IRangeBaseValueChangedEventArgs
	{
		double NewValue
		{
			get;
		}
		double OldValue
		{
			get;
		}
	}
}
