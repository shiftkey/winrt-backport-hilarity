using System;

namespace Windows.Foundation.Diagnostics
{
	[Flags]
	public enum ErrorOptions : uint
	{
		None = 0u,
		SuppressExceptions = 1u,
		ForceExceptions = 2u,
		UseSetErrorInfo = 4u,
		SuppressSetErrorInfo = 8u
	}
}
