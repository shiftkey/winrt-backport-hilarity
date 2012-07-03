using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IControlFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IControlStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Control : FrameworkElement, IControl, IControlOverrides, IControlProtected
	{
		public extern event DependencyPropertyChangedEventHandler IsEnabledChanged
		{
			add;
			remove;
		}
		public extern Brush Background
		{
			get;
			set;
		}
		public extern Brush BorderBrush
		{
			get;
			set;
		}
		public extern Thickness BorderThickness
		{
			get;
			set;
		}
		public extern int CharacterSpacing
		{
			get;
			set;
		}
		public extern FocusState FocusState
		{
			get;
		}
		public extern FontFamily FontFamily
		{
			get;
			set;
		}
		public extern double FontSize
		{
			get;
			set;
		}
		public extern FontStretch FontStretch
		{
			get;
			set;
		}
		public extern FontStyle FontStyle
		{
			get;
			set;
		}
		public extern FontWeight FontWeight
		{
			get;
			set;
		}
		public extern Brush Foreground
		{
			get;
			set;
		}
		public extern HorizontalAlignment HorizontalContentAlignment
		{
			get;
			set;
		}
		public extern bool IsEnabled
		{
			get;
			set;
		}
		public extern bool IsTabStop
		{
			get;
			set;
		}
		public extern Thickness Padding
		{
			get;
			set;
		}
		public extern int TabIndex
		{
			get;
			set;
		}
		public extern KeyboardNavigationMode TabNavigation
		{
			get;
			set;
		}
		public extern ControlTemplate Template
		{
			get;
			set;
		}
		public extern VerticalAlignment VerticalContentAlignment
		{
			get;
			set;
		}
		protected extern object DefaultStyleKey
		{
			get;
			set;
		}
		public static extern DependencyProperty BackgroundProperty
		{
			get;
		}
		public static extern DependencyProperty BorderBrushProperty
		{
			get;
		}
		public static extern DependencyProperty BorderThicknessProperty
		{
			get;
		}
		public static extern DependencyProperty CharacterSpacingProperty
		{
			get;
		}
		public static extern DependencyProperty DefaultStyleKeyProperty
		{
			get;
		}
		public static extern DependencyProperty FocusStateProperty
		{
			get;
		}
		public static extern DependencyProperty FontFamilyProperty
		{
			get;
		}
		public static extern DependencyProperty FontSizeProperty
		{
			get;
		}
		public static extern DependencyProperty FontStretchProperty
		{
			get;
		}
		public static extern DependencyProperty FontStyleProperty
		{
			get;
		}
		public static extern DependencyProperty FontWeightProperty
		{
			get;
		}
		public static extern DependencyProperty ForegroundProperty
		{
			get;
		}
		public static extern DependencyProperty HorizontalContentAlignmentProperty
		{
			get;
		}
		public static extern DependencyProperty IsEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty IsTabStopProperty
		{
			get;
		}
		public static extern DependencyProperty PaddingProperty
		{
			get;
		}
		public static extern DependencyProperty TabIndexProperty
		{
			get;
		}
		public static extern DependencyProperty TabNavigationProperty
		{
			get;
		}
		public static extern DependencyProperty TemplateProperty
		{
			get;
		}
		public static extern DependencyProperty VerticalContentAlignmentProperty
		{
			get;
		}
		protected extern Control();
		public extern bool ApplyTemplate();
		public extern bool Focus([In] FocusState value);
		protected virtual extern void OnPointerEntered([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerPressed([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerMoved([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerReleased([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerExited([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerCaptureLost([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerCanceled([In] PointerRoutedEventArgs e);
		protected virtual extern void OnPointerWheelChanged([In] PointerRoutedEventArgs e);
		protected virtual extern void OnTapped([In] TappedRoutedEventArgs e);
		protected virtual extern void OnDoubleTapped([In] DoubleTappedRoutedEventArgs e);
		protected virtual extern void OnHolding([In] HoldingRoutedEventArgs e);
		protected virtual extern void OnRightTapped([In] RightTappedRoutedEventArgs e);
		protected virtual extern void OnManipulationStarting([In] ManipulationStartingRoutedEventArgs e);
		protected virtual extern void OnManipulationInertiaStarting([In] ManipulationInertiaStartingRoutedEventArgs e);
		protected virtual extern void OnManipulationStarted([In] ManipulationStartedRoutedEventArgs e);
		protected virtual extern void OnManipulationDelta([In] ManipulationDeltaRoutedEventArgs e);
		protected virtual extern void OnManipulationCompleted([In] ManipulationCompletedRoutedEventArgs e);
		protected virtual extern void OnKeyUp([In] KeyRoutedEventArgs e);
		protected virtual extern void OnKeyDown([In] KeyRoutedEventArgs e);
		protected virtual extern void OnGotFocus([In] RoutedEventArgs e);
		protected virtual extern void OnLostFocus([In] RoutedEventArgs e);
		protected virtual extern void OnDragEnter([In] DragEventArgs e);
		protected virtual extern void OnDragLeave([In] DragEventArgs e);
		protected virtual extern void OnDragOver([In] DragEventArgs e);
		protected virtual extern void OnDrop([In] DragEventArgs e);
		protected extern DependencyObject GetTemplateChild([In] string childName);
	}
}
