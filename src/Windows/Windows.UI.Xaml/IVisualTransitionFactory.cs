using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualTransition)), Guid(3933570639u, 53728, 19886, 180, 41, 137, 252, 50, 39, 36, 244), Version(100794368u), WebHostHidden]
	internal interface IVisualTransitionFactory
	{
		VisualTransition CreateInstance([In] object outer, out object inner);
	}
}
