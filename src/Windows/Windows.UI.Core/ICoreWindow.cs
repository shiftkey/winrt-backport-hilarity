using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[Guid(2042222066u, 34718, 19337, 183, 152, 121, 228, 117, 152, 3, 12), Version(100794368u), WebHostHidden]
	public interface ICoreWindow
	{
		event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated;
		event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested;
		event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived;
		event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed;
		event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled;
		event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown;
		event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased;
		event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged;
		event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged;
		event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting;
		event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged;
		object AutomationHostProvider
		{
			get;
		}
		Rect Bounds
		{
			get;
		}
		IPropertySet CustomProperties
		{
			get;
		}
		CoreDispatcher Dispatcher
		{
			get;
		}
		CoreWindowFlowDirection FlowDirection
		{
			get;
			set;
		}
		bool IsInputEnabled
		{
			get;
			set;
		}
		CoreCursor PointerCursor
		{
			get;
			set;
		}
		Point PointerPosition
		{
			get;
		}
		bool Visible
		{
			get;
		}
		void Activate();
		void Close();
		CoreVirtualKeyStates GetAsyncKeyState([In] VirtualKey virtualKey);
		CoreVirtualKeyStates GetKeyState([In] VirtualKey virtualKey);
		void ReleasePointerCapture();
		void SetPointerCapture();
	}
}
