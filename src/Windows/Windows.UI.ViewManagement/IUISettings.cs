using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.ViewManagement
{
	[ExclusiveTo(typeof(UISettings)), Guid(2234914304u, 7267, 17959, 188, 177, 58, 137, 224, 188, 156, 85), Version(100794368u)]
	internal interface IUISettings
	{
		bool AnimationsEnabled
		{
			get;
		}
		uint CaretBlinkRate
		{
			get;
		}
		bool CaretBrowsingEnabled
		{
			get;
		}
		uint CaretWidth
		{
			get;
		}
		Size CursorSize
		{
			get;
		}
		uint DoubleClickTime
		{
			get;
		}
		HandPreference HandPreference
		{
			get;
		}
		uint MessageDuration
		{
			get;
		}
		uint MouseHoverTime
		{
			get;
		}
		Size ScrollBarArrowSize
		{
			get;
		}
		Size ScrollBarSize
		{
			get;
		}
		Size ScrollBarThumbBoxSize
		{
			get;
		}
		Color UIElementColor([In] UIElementType desiredElement);
	}
}
