using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintCustomTextOptionDetails)), Guid(718369272u, 51389, 18693, 145, 146, 13, 117, 19, 110, 139, 49), Version(100794368u)]
	internal interface IPrintCustomTextOptionDetails : IPrintCustomOptionDetails, IPrintOptionDetails
	{
		uint MaxCharacters
		{
			get;
			set;
		}
	}
}
