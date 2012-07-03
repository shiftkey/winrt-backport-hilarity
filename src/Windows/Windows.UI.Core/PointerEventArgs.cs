using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class PointerEventArgs : IPointerEventArgs, ICoreWindowEventArgs
	{
		public extern PointerPoint CurrentPoint
		{
			get;
		}
		public extern VirtualKeyModifiers KeyModifiers
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern IVector<PointerPoint> GetIntermediatePoints();
	}
}
