using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintCustomItemDetails : IPrintCustomItemDetails
	{
		public extern string ItemDisplayName
		{
			get;
			set;
		}
		public extern string ItemId
		{
			get;
		}
	}
}
