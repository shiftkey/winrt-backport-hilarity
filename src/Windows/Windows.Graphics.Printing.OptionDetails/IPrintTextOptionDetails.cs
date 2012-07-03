using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Guid(2910184803u, 23780, 18108, 153, 24, 171, 159, 173, 20, 76, 91), Version(100794368u)]
	public interface IPrintTextOptionDetails : IPrintOptionDetails
	{
		uint MaxCharacters
		{
			get;
		}
	}
}
