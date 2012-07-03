using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(AutomationProperties)), Guid(3055091067u, 13008, 18800, 156, 66, 124, 3, 154, 199, 190, 120), Version(100794368u), WebHostHidden]
	internal interface IAutomationPropertiesStatics
	{
		DependencyProperty AcceleratorKeyProperty
		{
			get;
		}
		DependencyProperty AccessKeyProperty
		{
			get;
		}
		DependencyProperty AutomationIdProperty
		{
			get;
		}
		DependencyProperty HelpTextProperty
		{
			get;
		}
		DependencyProperty IsRequiredForFormProperty
		{
			get;
		}
		DependencyProperty ItemStatusProperty
		{
			get;
		}
		DependencyProperty ItemTypeProperty
		{
			get;
		}
		DependencyProperty LabeledByProperty
		{
			get;
		}
		DependencyProperty NameProperty
		{
			get;
		}
		string GetAcceleratorKey([In] DependencyObject element);
		void SetAcceleratorKey([In] DependencyObject element, [In] string value);
		string GetAccessKey([In] DependencyObject element);
		void SetAccessKey([In] DependencyObject element, [In] string value);
		string GetAutomationId([In] DependencyObject element);
		void SetAutomationId([In] DependencyObject element, [In] string value);
		string GetHelpText([In] DependencyObject element);
		void SetHelpText([In] DependencyObject element, [In] string value);
		bool GetIsRequiredForForm([In] DependencyObject element);
		void SetIsRequiredForForm([In] DependencyObject element, [In] bool value);
		string GetItemStatus([In] DependencyObject element);
		void SetItemStatus([In] DependencyObject element, [In] string value);
		string GetItemType([In] DependencyObject element);
		void SetItemType([In] DependencyObject element, [In] string value);
		UIElement GetLabeledBy([In] DependencyObject element);
		void SetLabeledBy([In] DependencyObject element, [In] UIElement value);
		string GetName([In] DependencyObject element);
		void SetName([In] DependencyObject element, [In] string value);
	}
}
