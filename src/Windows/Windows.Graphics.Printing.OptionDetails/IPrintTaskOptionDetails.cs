using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[ExclusiveTo(typeof(PrintTaskOptionDetails)), Guid(4117891825u, 43166, 17062, 129, 175, 248, 224, 16, 179, 138, 104), Version(100794368u)]
	internal interface IPrintTaskOptionDetails
	{
		event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation;
		event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged;
		IMapView<string, IPrintOptionDetails> Options
		{
			get;
		}
		PrintCustomItemListOptionDetails CreateItemListOption([In] string optionId, [In] string displayName);
		PrintCustomTextOptionDetails CreateTextOption([In] string optionId, [In] string displayName);
	}
}
