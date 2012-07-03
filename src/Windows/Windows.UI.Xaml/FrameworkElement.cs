using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IFrameworkElementFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFrameworkElementStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class FrameworkElement : UIElement, IFrameworkElement, IFrameworkElementOverrides
	{
		public extern event EventHandler<object> LayoutUpdated
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler Loaded
		{
			add;
			remove;
		}
		public extern event SizeChangedEventHandler SizeChanged
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler Unloaded
		{
			add;
			remove;
		}
		public extern double ActualHeight
		{
			get;
		}
		public extern double ActualWidth
		{
			get;
		}
		public extern Uri BaseUri
		{
			get;
		}
		public extern object DataContext
		{
			get;
			set;
		}
		public extern FlowDirection FlowDirection
		{
			get;
			set;
		}
		public extern double Height
		{
			get;
			set;
		}
		public extern HorizontalAlignment HorizontalAlignment
		{
			get;
			set;
		}
		public extern string Language
		{
			get;
			set;
		}
		public extern Thickness Margin
		{
			get;
			set;
		}
		public extern double MaxHeight
		{
			get;
			set;
		}
		public extern double MaxWidth
		{
			get;
			set;
		}
		public extern double MinHeight
		{
			get;
			set;
		}
		public extern double MinWidth
		{
			get;
			set;
		}
		public extern string Name
		{
			get;
			set;
		}
		public extern DependencyObject Parent
		{
			get;
		}
		public extern ResourceDictionary Resources
		{
			get;
			set;
		}
		public extern Style Style
		{
			get;
			set;
		}
		public extern object Tag
		{
			get;
			set;
		}
		public extern TriggerCollection Triggers
		{
			get;
		}
		public extern VerticalAlignment VerticalAlignment
		{
			get;
			set;
		}
		public extern double Width
		{
			get;
			set;
		}
		public static extern DependencyProperty ActualHeightProperty
		{
			get;
		}
		public static extern DependencyProperty ActualWidthProperty
		{
			get;
		}
		public static extern DependencyProperty DataContextProperty
		{
			get;
		}
		public static extern DependencyProperty FlowDirectionProperty
		{
			get;
		}
		public static extern DependencyProperty HeightProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty LanguageProperty
		{
			get;
		}
		public static extern DependencyProperty MarginProperty
		{
			get;
		}
		public static extern DependencyProperty MaxHeightProperty
		{
			get;
		}
		public static extern DependencyProperty MaxWidthProperty
		{
			get;
		}
		public static extern DependencyProperty MinHeightProperty
		{
			get;
		}
		public static extern DependencyProperty MinWidthProperty
		{
			get;
		}
		public static extern DependencyProperty NameProperty
		{
			get;
		}
		public static extern DependencyProperty StyleProperty
		{
			get;
		}
		public static extern DependencyProperty TagProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty WidthProperty
		{
			get;
		}
		protected extern FrameworkElement();
		public extern object FindName([In] string name);
		public extern void SetBinding([In] DependencyProperty dp, [In] BindingBase binding);
		protected virtual extern Size MeasureOverride([In] Size availableSize);
		protected virtual extern Size ArrangeOverride([In] Size finalSize);
		protected virtual extern void OnApplyTemplate();
	}
}
