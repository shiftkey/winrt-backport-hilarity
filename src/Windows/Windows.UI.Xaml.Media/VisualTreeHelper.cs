using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IVisualTreeHelperStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class VisualTreeHelper : IVisualTreeHelper
	{
		[DefaultOverload, Overload("FindElementsInHostCoordinatesPoint")]
		public static extern IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree);
		[Overload("FindElementsInHostCoordinatesRect")]
		public static extern IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree);
		[DefaultOverload, Overload("FindAllElementsInHostCoordinatesPoint")]
		public static extern IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree, [In] bool includeAllElements);
		[Overload("FindAllElementsInHostCoordinatesRect")]
		public static extern IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree, [In] bool includeAllElements);
		public static extern DependencyObject GetChild([In] DependencyObject reference, [In] int childIndex);
		public static extern int GetChildrenCount([In] DependencyObject reference);
		public static extern DependencyObject GetParent([In] DependencyObject reference);
		public static extern void DisconnectChildrenRecursive([In] UIElement element);
	}
}
