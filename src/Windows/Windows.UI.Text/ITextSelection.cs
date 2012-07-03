using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Guid(2798872356u, 62095, 17162, 178, 207, 195, 67, 103, 30, 192, 233), Version(100794368u), WebHostHidden]
	public interface ITextSelection : ITextRange
	{
		SelectionOptions Options
		{
			get;
			set;
		}
		SelectionType Type
		{
			get;
		}
		int EndKey([In] TextRangeUnit unit, [In] bool extend);
		int HomeKey([In] TextRangeUnit unit, [In] bool extend);
		int MoveDown([In] TextRangeUnit unit, [In] int count, [In] bool extend);
		int MoveLeft([In] TextRangeUnit unit, [In] int count, [In] bool extend);
		int MoveRight([In] TextRangeUnit unit, [In] int count, [In] bool extend);
		int MoveUp([In] TextRangeUnit unit, [In] int count, [In] bool extend);
		void TypeText([In] string value);
	}
}
