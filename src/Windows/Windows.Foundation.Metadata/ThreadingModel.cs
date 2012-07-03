using System;
namespace Windows.Foundation.Metadata
{
	[Version(100794368u)]
	public enum ThreadingModel
	{
		STA = 1,
		MTA,
		Both,
		InvalidThreading = 0
	}
}
