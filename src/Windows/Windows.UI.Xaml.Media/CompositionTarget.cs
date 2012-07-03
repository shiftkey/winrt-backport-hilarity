using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICompositionTargetStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CompositionTarget : ICompositionTarget
	{
		public static extern event EventHandler<object> Rendering
		{
			add;
			remove;
		}
		public static extern event EventHandler<object> SurfaceContentsLost
		{
			add;
			remove;
		}
	}
}
