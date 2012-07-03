using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Text;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(41183373u, 1769, 20326, 148, 70, 40, 165, 190, 152, 251, 208), Version(100794368u), WebHostHidden]
	public interface ITextRangeProvider
	{
		ITextRangeProvider Clone();
		bool Compare([In] ITextRangeProvider textRangeProvider);
		int CompareEndpoints([In] TextPatternRangeEndpoint endpoint, [In] ITextRangeProvider textRangeProvider, [In] TextPatternRangeEndpoint targetEndpoint);
		void ExpandToEnclosingUnit([In] TextUnit unit);
		ITextRangeProvider FindAttribute([In] int attributeId, [In] object value, [In] bool backward);
		ITextRangeProvider FindText([In] string text, [In] bool backward, [In] bool ignoreCase);
		object GetAttributeValue([In] int attributeId);
		void GetBoundingRectangles(out double[] returnValue);
		IRawElementProviderSimple GetEnclosingElement();
		string GetText([In] int maxLength);
		int Move([In] TextUnit unit, [In] int count);
		int MoveEndpointByUnit([In] TextPatternRangeEndpoint endpoint, [In] TextUnit unit, [In] int count);
		void MoveEndpointByRange([In] TextPatternRangeEndpoint endpoint, [In] ITextRangeProvider textRangeProvider, [In] TextPatternRangeEndpoint targetEndpoint);
		void Select();
		void AddToSelection();
		void RemoveFromSelection();
		void ScrollIntoView([In] bool alignToTop);
		IRawElementProviderSimple[] GetChildren();
	}
}
