using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(CompositionTarget)), Guid(723185725u, 7890, 19289, 189, 0, 117, 148, 238, 146, 131, 43), Version(100794368u), WebHostHidden]
	internal interface ICompositionTargetStatics
	{
		event EventHandler<object> Rendering;
		event EventHandler<object> SurfaceContentsLost;
	}
}
