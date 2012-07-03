using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(KeySpline)), Guid(2007065531u, 54730, 18994, 186, 11, 125, 255, 152, 142, 88, 160), Version(100794368u), WebHostHidden]
	internal interface IKeySpline
	{
		Point ControlPoint1
		{
			get;
			set;
		}
		Point ControlPoint2
		{
			get;
			set;
		}
	}
}
