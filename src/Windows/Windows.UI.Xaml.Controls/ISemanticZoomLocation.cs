using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SemanticZoomLocation)), Guid(1107367734u, 58306, 18795, 188, 78, 215, 80, 212, 55, 91, 154), Version(100794368u), WebHostHidden]
	internal interface ISemanticZoomLocation
	{
		Rect Bounds
		{
			get;
			set;
		}
		object Item
		{
			get;
			set;
		}
	}
}
