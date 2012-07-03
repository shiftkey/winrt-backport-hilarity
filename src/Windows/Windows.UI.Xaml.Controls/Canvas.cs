using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(ICanvasFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICanvasStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Canvas : Panel, ICanvas
	{
		public static extern DependencyProperty LeftProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty TopProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty ZIndexProperty
		{
			get;
		}
		public extern Canvas();
		public static extern double GetLeft([In] UIElement element);
		public static extern void SetLeft([In] UIElement element, [In] double length);
		public static extern double GetTop([In] UIElement element);
		public static extern void SetTop([In] UIElement element, [In] double length);
		public static extern int GetZIndex([In] UIElement element);
		public static extern void SetZIndex([In] UIElement element, [In] int value);
	}
}
