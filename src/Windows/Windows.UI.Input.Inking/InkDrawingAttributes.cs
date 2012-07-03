using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Threading(ThreadingModel.STA), Version(100794368u)]
	public sealed class InkDrawingAttributes : IInkDrawingAttributes
	{
		public extern Color Color
		{
			get;
			set;
		}
		public extern bool FitToCurve
		{
			get;
			set;
		}
		public extern bool IgnorePressure
		{
			get;
			set;
		}
		public extern PenTipShape PenTip
		{
			get;
			set;
		}
		public extern Size Size
		{
			get;
			set;
		}
		public extern InkDrawingAttributes();
	}
}
