using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Guid(3250001970u, 40595, 20053, 129, 75, 51, 38, 165, 158, 252, 225), Version(100794368u)]
	public interface IPrintTaskOptionsCoreProperties
	{
		PrintBinding Binding
		{
			get;
			set;
		}
		PrintCollation Collation
		{
			get;
			set;
		}
		PrintColorMode ColorMode
		{
			get;
			set;
		}
		PrintDuplex Duplex
		{
			get;
			set;
		}
		PrintHolePunch HolePunch
		{
			get;
			set;
		}
		uint MaxCopies
		{
			get;
		}
		PrintMediaSize MediaSize
		{
			get;
			set;
		}
		PrintMediaType MediaType
		{
			get;
			set;
		}
		uint MinCopies
		{
			get;
		}
		uint NumberOfCopies
		{
			get;
			set;
		}
		PrintOrientation Orientation
		{
			get;
			set;
		}
		PrintQuality PrintQuality
		{
			get;
			set;
		}
		PrintStaple Staple
		{
			get;
			set;
		}
	}
}
