using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Version(100794368u), WebHostHidden]
	public enum CoreAcceleratorKeyEventType
	{
		Character = 2,
		DeadCharacter,
		KeyDown = 0,
		KeyUp,
		SystemCharacter = 6,
		SystemDeadCharacter,
		SystemKeyDown = 4,
		SystemKeyUp,
		UnicodeCharacter = 8
	}
}
