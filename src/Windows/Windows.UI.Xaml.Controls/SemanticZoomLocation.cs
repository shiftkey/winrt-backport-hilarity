using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SemanticZoomLocation : ISemanticZoomLocation
	{
		public extern Rect Bounds
		{
			get;
			set;
		}
		public extern object Item
		{
			get;
			set;
		}
		public extern SemanticZoomLocation();
	}
}
