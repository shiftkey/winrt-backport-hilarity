using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AutomationPeer)), Guid(3198762599u, 56302, 20347, 175, 13, 167, 154, 174, 83, 51, 191), Version(100794368u), WebHostHidden]
	internal interface IAutomationPeerOverrides
	{
		object GetPatternCore([In] PatternInterface patternInterface);
		string GetAcceleratorKeyCore();
		string GetAccessKeyCore();
		AutomationControlType GetAutomationControlTypeCore();
		string GetAutomationIdCore();
		Rect GetBoundingRectangleCore();
		IVector<AutomationPeer> GetChildrenCore();
		string GetClassNameCore();
		Point GetClickablePointCore();
		string GetHelpTextCore();
		string GetItemStatusCore();
		string GetItemTypeCore();
		AutomationPeer GetLabeledByCore();
		string GetLocalizedControlTypeCore();
		string GetNameCore();
		AutomationOrientation GetOrientationCore();
		bool HasKeyboardFocusCore();
		bool IsContentElementCore();
		bool IsControlElementCore();
		bool IsEnabledCore();
		bool IsKeyboardFocusableCore();
		bool IsOffscreenCore();
		bool IsPasswordCore();
		bool IsRequiredForFormCore();
		void SetFocusCore();
		AutomationPeer GetPeerFromPointCore([In] Point point);
	}
}
