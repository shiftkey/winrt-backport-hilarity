using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Guid(2585941951u, 65121, 17368, 162, 79, 163, 246, 171, 115, 32, 231), Version(100794368u)]
	public interface IPrintItemListOptionDetails : IPrintOptionDetails
	{
		IVectorView<object> Items
		{
			[return: HasVariant]
			get;
		}
	}
}
