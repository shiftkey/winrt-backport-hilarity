using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(VisualTreeHelper)), Guid(3881261252u, 53853, 19229, 151, 31, 89, 111, 23, 241, 43, 170), Version(100794368u), WebHostHidden]
	internal interface IVisualTreeHelperStatics
	{
		[DefaultOverload, Overload("FindElementsInHostCoordinatesPoint")]
		IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree);
		[Overload("FindElementsInHostCoordinatesRect")]
		IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree);
		[DefaultOverload, Overload("FindAllElementsInHostCoordinatesPoint")]
		IIterable<UIElement> FindElementsInHostCoordinates([In] Point intersectingPoint, [In] UIElement subtree, [In] bool includeAllElements);
		[Overload("FindAllElementsInHostCoordinatesRect")]
		IIterable<UIElement> FindElementsInHostCoordinates([In] Rect intersectingRect, [In] UIElement subtree, [In] bool includeAllElements);
		DependencyObject GetChild([In] DependencyObject reference, [In] int childIndex);
		int GetChildrenCount([In] DependencyObject reference);
		DependencyObject GetParent([In] DependencyObject reference);
		void DisconnectChildrenRecursive([In] UIElement element);
	}
}
