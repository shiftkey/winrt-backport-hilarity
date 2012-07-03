using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IItemsPresenterStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ItemsPresenter : FrameworkElement, IItemsPresenter, IScrollSnapPointsInfo
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
		public extern object Header
		{
			get;
			set;
		}
		public extern DataTemplate HeaderTemplate
		{
			get;
			set;
		}
		public extern TransitionCollection HeaderTransitions
		{
			get;
			set;
		}
		public extern Thickness Padding
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
		public static extern DependencyProperty HeaderProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderTemplateProperty
		{
			get;
		}
		public static extern DependencyProperty HeaderTransitionsProperty
		{
			get;
		}
		public static extern DependencyProperty PaddingProperty
		{
			get;
		}
		public extern ItemsPresenter();
		public extern IVectorView<float> GetIrregularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment);
		public extern float GetRegularSnapPoints([In] Orientation orientation, [In] SnapPointsAlignment alignment, out float offset);
	}
}
