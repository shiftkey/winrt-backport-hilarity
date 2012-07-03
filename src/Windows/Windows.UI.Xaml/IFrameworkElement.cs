using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(FrameworkElement)), Guid(2744242331u, 19097, 19324, 157, 141, 111, 165, 208, 31, 111, 191), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElement
	{
		event EventHandler<object> LayoutUpdated;
		event RoutedEventHandler Loaded;
		event SizeChangedEventHandler SizeChanged;
		event RoutedEventHandler Unloaded;
		double ActualHeight
		{
			get;
		}
		double ActualWidth
		{
			get;
		}
		Uri BaseUri
		{
			get;
		}
		object DataContext
		{
			get;
			set;
		}
		FlowDirection FlowDirection
		{
			get;
			set;
		}
		double Height
		{
			get;
			set;
		}
		HorizontalAlignment HorizontalAlignment
		{
			get;
			set;
		}
		string Language
		{
			get;
			set;
		}
		Thickness Margin
		{
			get;
			set;
		}
		double MaxHeight
		{
			get;
			set;
		}
		double MaxWidth
		{
			get;
			set;
		}
		double MinHeight
		{
			get;
			set;
		}
		double MinWidth
		{
			get;
			set;
		}
		string Name
		{
			get;
			set;
		}
		DependencyObject Parent
		{
			get;
		}
		ResourceDictionary Resources
		{
			get;
			set;
		}
		Style Style
		{
			get;
			set;
		}
		object Tag
		{
			get;
			set;
		}
		TriggerCollection Triggers
		{
			get;
		}
		VerticalAlignment VerticalAlignment
		{
			get;
			set;
		}
		double Width
		{
			get;
			set;
		}
		object FindName([In] string name);
		void SetBinding([In] DependencyProperty dp, [In] BindingBase binding);
	}
}
