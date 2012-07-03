using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(3743238332u, 1159, 20095, 157, 94, 240, 158, 119, 228, 18, 70), Version(100794368u), WebHostHidden]
	public interface ITextProvider2 : ITextProvider
	{
		ITextRangeProvider RangeFromAnnotation([In] IRawElementProviderSimple annotationElement);
		ITextRangeProvider GetCaretRange(out bool isActive);
	}
}
