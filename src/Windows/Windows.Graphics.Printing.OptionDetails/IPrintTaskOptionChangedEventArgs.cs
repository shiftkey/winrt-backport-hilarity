using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintTaskOptionChangedEventArgs)), Guid(1696169221u, 42478, 17159, 148, 7, 154, 202, 209, 71, 103, 156), Version(100794368u)]
	internal interface IPrintTaskOptionChangedEventArgs
	{
		object OptionId
		{
			[return: Variant]
			get;
		}
	}
}
