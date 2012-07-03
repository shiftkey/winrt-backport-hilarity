using System;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading
{
	[Flags, Version(100794368u), WebHostHidden]
	public enum WorkItemOptions : uint
	{
		None = 0u,
		TimeSliced = 1u
	}
}
