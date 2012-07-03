using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IRangeBaseFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRangeBaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RangeBase : Control, IRangeBase, IRangeBaseOverrides
	{
		public extern event RangeBaseValueChangedEventHandler ValueChanged
		{
			add;
			remove;
		}
		public extern double LargeChange
		{
			get;
			set;
		}
		public extern double Maximum
		{
			get;
			set;
		}
		public extern double Minimum
		{
			get;
			set;
		}
		public extern double SmallChange
		{
			get;
			set;
		}
		public extern double Value
		{
			get;
			set;
		}
		public static extern DependencyProperty LargeChangeProperty
		{
			get;
		}
		public static extern DependencyProperty MaximumProperty
		{
			get;
		}
		public static extern DependencyProperty MinimumProperty
		{
			get;
		}
		public static extern DependencyProperty SmallChangeProperty
		{
			get;
		}
		public static extern DependencyProperty ValueProperty
		{
			get;
		}
		protected extern RangeBase();
		protected virtual extern void OnMinimumChanged([In] double oldMinimum, [In] double newMinimum);
		protected virtual extern void OnMaximumChanged([In] double oldMaximum, [In] double newMaximum);
		protected virtual extern void OnValueChanged([In] double oldValue, [In] double newValue);
	}
}
