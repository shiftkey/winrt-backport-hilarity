using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintCustomItemDetails)), Guid(1459926583u, 23610, 17562, 170, 54, 179, 41, 27, 17, 146, 253), Version(100794368u)]
	internal interface IPrintCustomItemDetails
	{
		string ItemDisplayName
		{
			get;
			set;
		}
		string ItemId
		{
			get;
		}
	}
}
