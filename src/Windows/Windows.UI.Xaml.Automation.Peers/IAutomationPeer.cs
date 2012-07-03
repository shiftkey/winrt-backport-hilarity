using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AutomationPeer)), Guid(900384890u, 25326, 19774, 162, 76, 43, 200, 67, 45, 104, 183), Version(100794368u), WebHostHidden]
	internal interface IAutomationPeer
	{
		AutomationPeer EventsSource
		{
			get;
			set;
		}
		object GetPattern([In] PatternInterface patternInterface);
		void RaiseAutomationEvent([In] AutomationEvents eventId);
		void RaisePropertyChangedEvent([In] AutomationProperty automationProperty, [In] object oldValue, [In] object newValue);
		string GetAcceleratorKey();
		string GetAccessKey();
		AutomationControlType GetAutomationControlType();
		string GetAutomationId();
		Rect GetBoundingRectangle();
		IVector<AutomationPeer> GetChildren();
		string GetClassName();
		Point GetClickablePoint();
		string GetHelpText();
		string GetItemStatus();
		string GetItemType();
		AutomationPeer GetLabeledBy();
		string GetLocalizedControlType();
		string GetName();
		AutomationOrientation GetOrientation();
		bool HasKeyboardFocus();
		bool IsContentElement();
		bool IsControlElement();
		bool IsEnabled();
		bool IsKeyboardFocusable();
		bool IsOffscreen();
		bool IsPassword();
		bool IsRequiredForForm();
		void SetFocus();
		AutomationPeer GetParent();
		void InvalidatePeer();
		AutomationPeer GetPeerFromPoint([In] Point point);
	}
}
