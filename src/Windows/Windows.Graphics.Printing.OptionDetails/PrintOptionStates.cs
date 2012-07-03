using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Flags, Version(100794368u)]
	public enum PrintOptionStates : uint
	{
		None = 0u,
		Enabled = 1u,
		Constrained = 2u
	}
}
