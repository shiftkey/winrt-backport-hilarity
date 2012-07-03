using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(PointerEventArgs)), Guid(2450365617u, 42492, 18977, 140, 9, 73, 223, 230, 255, 226, 95), Version(100794368u), WebHostHidden]
	internal interface IPointerEventArgs : ICoreWindowEventArgs
	{
		PointerPoint CurrentPoint
		{
			get;
		}
		VirtualKeyModifiers KeyModifiers
		{
			get;
		}
		IVector<PointerPoint> GetIntermediatePoints();
	}
}
