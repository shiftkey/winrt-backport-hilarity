using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Guid(1659280931u, 39454, 17206, 183, 79, 60, 199, 244, 207, 247, 9), Version(100794368u)]
	public interface IPrintTaskOptionsCoreUIConfiguration
	{
		IVector<string> DisplayedOptions
		{
			get;
		}
	}
}
