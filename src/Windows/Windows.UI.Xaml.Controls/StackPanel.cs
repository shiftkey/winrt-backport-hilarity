using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IStackPanelFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IStackPanelStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class StackPanel : Panel, IStackPanel, IScrollSnapPointsInfo
	{
		public extern event EventHandler<object> HorizontalSnapPointsChanged
		{
			add;
			remove;
		}
		public extern event EventHandler<object> VerticalSnapPointsChanged
		{
			add;
			remove;
		}
		public extern bool AreScrollSnapPointsRegular
		{
			get;
			set;
		}
		public extern Orientation Orientation
		{
			get;
			set;
		}
		public extern bool AreHorizontalSnapPointsRegular
		{
			get;
		}
		public extern bool AreVerticalSnapPointsRegular
		{
			get;
		}
		public static extern DependencyProperty AreScrollSnapPointsRegularProperty
		{
			get;
		}
		public static extern DependencyProperty OrientationProperty
		{
			get;
		}
		public extern StackPanel();
		public extern IVectorView<float> GetIrregularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment);
		public extern float GetRegularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);
	}
}
