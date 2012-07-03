using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(3680222367u, 18439, 20266, 134, 120, 27, 19, 243, 198, 14, 34), Version(100794368u), WebHostHidden]
	public interface ITextProvider
	{
		ITextRangeProvider DocumentRange
		{
			get;
		}
		SupportedTextSelection SupportedTextSelection
		{
			get;
		}
		ITextRangeProvider[] GetSelection();
		ITextRangeProvider[] GetVisibleRanges();
		ITextRangeProvider RangeFromChild([In] IRawElementProviderSimple childElement);
		ITextRangeProvider RangeFromPoint([In] Point screenLocation);
	}
}
