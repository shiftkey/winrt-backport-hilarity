using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Diagnostics
{
	[Flags, Version(100794368u)]
	public enum ErrorOptions : uint
	{
		None = 0u,
		SuppressExceptions = 1u,
		ForceExceptions = 2u,
		UseSetErrorInfo = 4u,
		SuppressSetErrorInfo = 8u
	}
}
