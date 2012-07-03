using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAutomationPropertiesStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class AutomationProperties : IAutomationProperties
	{
		public static extern DependencyProperty AcceleratorKeyProperty
		{
			get;
		}
		public static extern DependencyProperty AccessKeyProperty
		{
			get;
		}
		public static extern DependencyProperty AutomationIdProperty
		{
			get;
		}
		public static extern DependencyProperty HelpTextProperty
		{
			get;
		}
		public static extern DependencyProperty IsRequiredForFormProperty
		{
			get;
		}
		public static extern DependencyProperty ItemStatusProperty
		{
			get;
		}
		public static extern DependencyProperty ItemTypeProperty
		{
			get;
		}
		public static extern DependencyProperty LabeledByProperty
		{
			get;
		}
		public static extern DependencyProperty NameProperty
		{
			get;
		}
		public static extern string GetAcceleratorKey([In] DependencyObject element);
		public static extern void SetAcceleratorKey([In] DependencyObject element, [In] string value);
		public static extern string GetAccessKey([In] DependencyObject element);
		public static extern void SetAccessKey([In] DependencyObject element, [In] string value);
		public static extern string GetAutomationId([In] DependencyObject element);
		public static extern void SetAutomationId([In] DependencyObject element, [In] string value);
		public static extern string GetHelpText([In] DependencyObject element);
		public static extern void SetHelpText([In] DependencyObject element, [In] string value);
		public static extern bool GetIsRequiredForForm([In] DependencyObject element);
		public static extern void SetIsRequiredForForm([In] DependencyObject element, [In] bool value);
		public static extern string GetItemStatus([In] DependencyObject element);
		public static extern void SetItemStatus([In] DependencyObject element, [In] string value);
		public static extern string GetItemType([In] DependencyObject element);
		public static extern void SetItemType([In] DependencyObject element, [In] string value);
		public static extern UIElement GetLabeledBy([In] DependencyObject element);
		public static extern void SetLabeledBy([In] DependencyObject element, [In] UIElement value);
		public static extern string GetName([In] DependencyObject element);
		public static extern void SetName([In] DependencyObject element, [In] string value);
	}
}
