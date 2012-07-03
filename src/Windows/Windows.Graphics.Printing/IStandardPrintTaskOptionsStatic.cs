using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[ExclusiveTo(typeof(StandardPrintTaskOptions)), Guid(3024633126u, 3536, 19668, 186, 255, 147, 15, 199, 214, 165, 116), Version(100794368u)]
	internal interface IStandardPrintTaskOptionsStatic
	{
		string Binding
		{
			get;
		}
		string Collation
		{
			get;
		}
		string ColorMode
		{
			get;
		}
		string Copies
		{
			get;
		}
		string Duplex
		{
			get;
		}
		string HolePunch
		{
			get;
		}
		string InputBin
		{
			get;
		}
		string MediaSize
		{
			get;
		}
		string MediaType
		{
			get;
		}
		string NUp
		{
			get;
		}
		string Orientation
		{
			get;
		}
		string PrintQuality
		{
			get;
		}
		string Staple
		{
			get;
		}
	}
}
