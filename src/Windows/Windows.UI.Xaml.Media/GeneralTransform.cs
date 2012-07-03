using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IGeneralTransformFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class GeneralTransform : DependencyObject, IGeneralTransform, IGeneralTransformOverrides
	{
		public extern GeneralTransform Inverse
		{
			get;
		}
		protected virtual extern GeneralTransform InverseCore
		{
			get;
		}
		protected extern GeneralTransform();
		public extern Point TransformPoint([In] Point point);
		public extern bool TryTransform([In] Point inPoint, out Point outPoint);
		public extern Rect TransformBounds([In] Rect rect);
		protected virtual extern bool TryTransformCore([In] Point inPoint, out Point outPoint);
		protected virtual extern Rect TransformBoundsCore([In] Rect rect);
	}
}
