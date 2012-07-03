using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Canvas)), Guid(1087265862u, 10594, 17519, 170, 251, 76, 220, 72, 105, 57, 201), Version(100794368u), WebHostHidden]
	internal interface ICanvasStatics
	{
		DependencyProperty LeftProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty TopProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		DependencyProperty ZIndexProperty
		{
			get;
		}
		double GetLeft([In] UIElement element);
		void SetLeft([In] UIElement element, [In] double length);
		double GetTop([In] UIElement element);
		void SetTop([In] UIElement element, [In] double length);
		int GetZIndex([In] UIElement element);
		void SetZIndex([In] UIElement element, [In] int value);
	}
}
