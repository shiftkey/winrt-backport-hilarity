using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class UISettings : IUISettings
	{
		public extern bool AnimationsEnabled
		{
			get;
		}
		public extern uint CaretBlinkRate
		{
			get;
		}
		public extern bool CaretBrowsingEnabled
		{
			get;
		}
		public extern uint CaretWidth
		{
			get;
		}
		public extern Size CursorSize
		{
			get;
		}
		public extern uint DoubleClickTime
		{
			get;
		}
		public extern HandPreference HandPreference
		{
			get;
		}
		public extern uint MessageDuration
		{
			get;
		}
		public extern uint MouseHoverTime
		{
			get;
		}
		public extern Size ScrollBarArrowSize
		{
			get;
		}
		public extern Size ScrollBarSize
		{
			get;
		}
		public extern Size ScrollBarThumbBoxSize
		{
			get;
		}
		public extern UISettings();
		public extern Color UIElementColor([In] UIElementType desiredElement);
	}
}
