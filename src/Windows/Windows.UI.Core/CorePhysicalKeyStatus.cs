using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Version(100794368u), WebHostHidden]
	public struct CorePhysicalKeyStatus
	{
		public uint RepeatCount;
		public uint ScanCode;
		public bool IsExtendedKey;
		public bool IsMenuKeyDown;
		public bool WasKeyDown;
		public bool IsKeyReleased;
	}
}
