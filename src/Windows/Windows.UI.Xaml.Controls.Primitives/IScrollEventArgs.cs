using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ScrollEventArgs)), Guid(3313389928u, 15102, 17549, 183, 82, 47, 54, 76, 117, 215, 67), Version(100794368u), WebHostHidden]
	internal interface IScrollEventArgs
	{
		double NewValue
		{
			get;
		}
		ScrollEventType ScrollEventType
		{
			get;
		}
	}
}
