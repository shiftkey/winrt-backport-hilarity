using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IAutomationPeerFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAutomationPeerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class AutomationPeer : DependencyObject, IAutomationPeer, IAutomationPeerOverrides, IAutomationPeerProtected
	{
		public extern AutomationPeer EventsSource
		{
			get;
			set;
		}
		protected extern AutomationPeer();
		public extern object GetPattern([In] PatternInterface patternInterface);
		public extern void RaiseAutomationEvent([In] AutomationEvents eventId);
		public extern void RaisePropertyChangedEvent([In] AutomationProperty automationProperty, [In] object oldValue, [In] object newValue);
		public extern string GetAcceleratorKey();
		public extern string GetAccessKey();
		public extern AutomationControlType GetAutomationControlType();
		public extern string GetAutomationId();
		public extern Rect GetBoundingRectangle();
		public extern IVector<AutomationPeer> GetChildren();
		public extern string GetClassName();
		public extern Point GetClickablePoint();
		public extern string GetHelpText();
		public extern string GetItemStatus();
		public extern string GetItemType();
		public extern AutomationPeer GetLabeledBy();
		public extern string GetLocalizedControlType();
		public extern string GetName();
		public extern AutomationOrientation GetOrientation();
		public extern bool HasKeyboardFocus();
		public extern bool IsContentElement();
		public extern bool IsControlElement();
		public extern bool IsEnabled();
		public extern bool IsKeyboardFocusable();
		public extern bool IsOffscreen();
		public extern bool IsPassword();
		public extern bool IsRequiredForForm();
		public extern void SetFocus();
		public extern AutomationPeer GetParent();
		public extern void InvalidatePeer();
		public extern AutomationPeer GetPeerFromPoint([In] Point point);
		protected virtual extern object GetPatternCore([In] PatternInterface patternInterface);
		protected virtual extern string GetAcceleratorKeyCore();
		protected virtual extern string GetAccessKeyCore();
		protected virtual extern AutomationControlType GetAutomationControlTypeCore();
		protected virtual extern string GetAutomationIdCore();
		protected virtual extern Rect GetBoundingRectangleCore();
		protected virtual extern IVector<AutomationPeer> GetChildrenCore();
		protected virtual extern string GetClassNameCore();
		protected virtual extern Point GetClickablePointCore();
		protected virtual extern string GetHelpTextCore();
		protected virtual extern string GetItemStatusCore();
		protected virtual extern string GetItemTypeCore();
		protected virtual extern AutomationPeer GetLabeledByCore();
		protected virtual extern string GetLocalizedControlTypeCore();
		protected virtual extern string GetNameCore();
		protected virtual extern AutomationOrientation GetOrientationCore();
		protected virtual extern bool HasKeyboardFocusCore();
		protected virtual extern bool IsContentElementCore();
		protected virtual extern bool IsControlElementCore();
		protected virtual extern bool IsEnabledCore();
		protected virtual extern bool IsKeyboardFocusableCore();
		protected virtual extern bool IsOffscreenCore();
		protected virtual extern bool IsPasswordCore();
		protected virtual extern bool IsRequiredForFormCore();
		protected virtual extern void SetFocusCore();
		protected virtual extern AutomationPeer GetPeerFromPointCore([In] Point point);
		protected extern AutomationPeer PeerFromProvider([In] IRawElementProviderSimple provider);
		protected extern IRawElementProviderSimple ProviderFromPeer([In] AutomationPeer peer);
		public static extern bool ListenerExists([In] AutomationEvents eventId);
	}
}
