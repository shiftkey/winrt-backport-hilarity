using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Guid(1291959215u, 25692, 19945, 150, 95, 111, 198, 187, 196, 124, 171), Version(100794368u)]
	public interface IPrintNumberOptionDetails : IPrintOptionDetails
	{
		uint MaxValue
		{
			get;
		}
		uint MinValue
		{
			get;
		}
	}
}
