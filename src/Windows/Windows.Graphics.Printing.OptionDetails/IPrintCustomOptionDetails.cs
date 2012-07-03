using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Guid(3811302940u, 10415, 19344, 149, 218, 163, 172, 243, 32, 185, 41), Version(100794368u)]
	public interface IPrintCustomOptionDetails : IPrintOptionDetails
	{
		string DisplayName
		{
			get;
			set;
		}
	}
}
