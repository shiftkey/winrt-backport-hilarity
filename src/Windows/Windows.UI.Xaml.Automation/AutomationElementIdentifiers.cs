using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAutomationElementIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class AutomationElementIdentifiers : IAutomationElementIdentifiers
	{
		public static extern AutomationProperty AcceleratorKeyProperty
		{
			get;
		}
		public static extern AutomationProperty AccessKeyProperty
		{
			get;
		}
		public static extern AutomationProperty AutomationIdProperty
		{
			get;
		}
		public static extern AutomationProperty BoundingRectangleProperty
		{
			get;
		}
		public static extern AutomationProperty ClassNameProperty
		{
			get;
		}
		public static extern AutomationProperty ClickablePointProperty
		{
			get;
		}
		public static extern AutomationProperty ControlTypeProperty
		{
			get;
		}
		public static extern AutomationProperty HasKeyboardFocusProperty
		{
			get;
		}
		public static extern AutomationProperty HelpTextProperty
		{
			get;
		}
		public static extern AutomationProperty IsContentElementProperty
		{
			get;
		}
		public static extern AutomationProperty IsControlElementProperty
		{
			get;
		}
		public static extern AutomationProperty IsEnabledProperty
		{
			get;
		}
		public static extern AutomationProperty IsKeyboardFocusableProperty
		{
			get;
		}
		public static extern AutomationProperty IsOffscreenProperty
		{
			get;
		}
		public static extern AutomationProperty IsPasswordProperty
		{
			get;
		}
		public static extern AutomationProperty IsRequiredForFormProperty
		{
			get;
		}
		public static extern AutomationProperty ItemStatusProperty
		{
			get;
		}
		public static extern AutomationProperty ItemTypeProperty
		{
			get;
		}
		public static extern AutomationProperty LabeledByProperty
		{
			get;
		}
		public static extern AutomationProperty LocalizedControlTypeProperty
		{
			get;
		}
		public static extern AutomationProperty NameProperty
		{
			get;
		}
		public static extern AutomationProperty OrientationProperty
		{
			get;
		}
	}
}
