using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Guid(459084598u, 58907, 19793, 190, 65, 253, 141, 220, 85, 197, 140), Version(100794368u), WebHostHidden]
	public interface IScrollSnapPointsInfo
	{
		event EventHandler<object> HorizontalSnapPointsChanged;
		event EventHandler<object> VerticalSnapPointsChanged;
		bool AreHorizontalSnapPointsRegular
		{
			get;
		}
		bool AreVerticalSnapPointsRegular
		{
			get;
		}
		IVectorView<float> GetIrregularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment);
		float GetRegularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);
	}
}
