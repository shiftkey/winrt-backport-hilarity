using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Version(100794368u)]
	public enum PointerUpdateKind
	{
		Other,
		LeftButtonPressed,
		LeftButtonReleased,
		RightButtonPressed,
		RightButtonReleased,
		MiddleButtonPressed,
		MiddleButtonReleased,
		XButton1Pressed,
		XButton1Released,
		XButton2Pressed,
		XButton2Released
	}
}
