using System;
using Windows.Foundation.Metadata;
namespace Windows.System
{
	[Version(100794368u)]
	public enum ProcessorArchitecture
	{
		X86,
		Arm = 5,
		X64 = 9,
		Neutral = 11,
		Unknown = 65535
	}
}
