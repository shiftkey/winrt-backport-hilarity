using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[ExclusiveTo(typeof(InkDrawingAttributes)), Guid(2543982444u, 26484, 18605, 132, 240, 72, 245, 169, 190, 116, 249), Version(100794368u)]
	internal interface IInkDrawingAttributes
	{
		Color Color
		{
			get;
			set;
		}
		bool FitToCurve
		{
			get;
			set;
		}
		bool IgnorePressure
		{
			get;
			set;
		}
		PenTipShape PenTip
		{
			get;
			set;
		}
		Size Size
		{
			get;
			set;
		}
	}
}
