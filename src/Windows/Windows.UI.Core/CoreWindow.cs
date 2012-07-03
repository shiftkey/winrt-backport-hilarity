using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(ICoreWindowStatic), 100794368u), Version(100794368u), WebHostHidden]
	public sealed class CoreWindow : ICoreWindow
	{
		public extern event TypedEventHandler<CoreWindow, WindowActivatedEventArgs> Activated
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, AutomationProviderRequestedEventArgs> AutomationProviderRequested
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, CharacterReceivedEventArgs> CharacterReceived
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, CoreWindowEventArgs> Closed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, InputEnabledEventArgs> InputEnabled
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyDown
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, KeyEventArgs> KeyUp
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerCaptureLost
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerEntered
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerExited
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerMoved
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerPressed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerReleased
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, PointerEventArgs> PointerWheelChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, WindowSizeChangedEventArgs> SizeChanged
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, TouchHitTestingEventArgs> TouchHitTesting
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<CoreWindow, VisibilityChangedEventArgs> VisibilityChanged
		{
			add;
			remove;
		}
		public extern object AutomationHostProvider
		{
			get;
		}
		public extern Rect Bounds
		{
			get;
		}
		public extern IPropertySet CustomProperties
		{
			get;
		}
		public extern CoreDispatcher Dispatcher
		{
			get;
		}
		public extern CoreWindowFlowDirection FlowDirection
		{
			get;
			set;
		}
		public extern bool IsInputEnabled
		{
			get;
			set;
		}
		public extern CoreCursor PointerCursor
		{
			get;
			set;
		}
		public extern Point PointerPosition
		{
			get;
		}
		public extern bool Visible
		{
			get;
		}
		public extern void Activate();
		public extern void Close();
		public extern CoreVirtualKeyStates GetAsyncKeyState([In] VirtualKey virtualKey);
		public extern CoreVirtualKeyStates GetKeyState([In] VirtualKey virtualKey);
		public extern void ReleasePointerCapture();
		public extern void SetPointerCapture();
		public static extern CoreWindow GetForCurrentThread();
	}
}
