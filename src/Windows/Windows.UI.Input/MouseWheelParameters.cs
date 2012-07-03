using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class MouseWheelParameters : IMouseWheelParameters
	{
		public extern Point CharTranslation
		{
			get;
			set;
		}
		public extern float DeltaRotationAngle
		{
			get;
			set;
		}
		public extern float DeltaScale
		{
			get;
			set;
		}
		public extern Point PageTranslation
		{
			get;
			set;
		}
	}
}
