using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LineSegment)), Guid(4016713253u, 16368, 17440, 164, 17, 113, 130, 164, 206, 203, 21), Version(100794368u), WebHostHidden]
	internal interface ILineSegment
	{
		Point Point
		{
			get;
			set;
		}
	}
}
