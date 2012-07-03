using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPrintTaskOptionDetailsStatic), 100794368u), Version(100794368u)]
	public sealed class PrintTaskOptionDetails : IPrintTaskOptionDetails, IPrintTaskOptionsCore, IPrintTaskOptionsCoreUIConfiguration
	{
		public extern event TypedEventHandler<PrintTaskOptionDetails, object> BeginValidation
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<PrintTaskOptionDetails, PrintTaskOptionChangedEventArgs> OptionChanged
		{
			add;
			remove;
		}
		public extern IMapView<string, IPrintOptionDetails> Options
		{
			get;
		}
		public extern IVector<string> DisplayedOptions
		{
			get;
		}
		public extern PrintCustomItemListOptionDetails CreateItemListOption([In] string optionId, [In] string displayName);
		public extern PrintCustomTextOptionDetails CreateTextOption([In] string optionId, [In] string displayName);
		public extern PrintPageDescription GetPageDescription([In] uint jobPageNumber);
		public static extern PrintTaskOptionDetails GetFromPrintTaskOptions([In] PrintTaskOptions printTaskOptions);
	}
}
