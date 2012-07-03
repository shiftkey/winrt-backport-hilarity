using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Text
{
	[Guid(1537101399u, 49266, 17056, 137, 69, 175, 80, 62, 229, 71, 104), Version(100794368u), WebHostHidden]
	public interface ITextRange
	{
		char Character
		{
			get;
			set;
		}
		ITextCharacterFormat CharacterFormat
		{
			get;
			set;
		}
		int EndPosition
		{
			get;
			set;
		}
		ITextRange FormattedText
		{
			get;
			set;
		}
		RangeGravity Gravity
		{
			get;
			set;
		}
		int Length
		{
			get;
		}
		string Link
		{
			get;
			set;
		}
		ITextParagraphFormat ParagraphFormat
		{
			get;
			set;
		}
		int StartPosition
		{
			get;
			set;
		}
		int StoryLength
		{
			get;
		}
		string Text
		{
			get;
			set;
		}
		bool CanPaste([In] int format);
		void ChangeCase([In] LetterCase value);
		void Collapse([In] bool value);
		void Copy();
		void Cut();
		int Delete([In] TextRangeUnit unit, [In] int count);
		int EndOf([In] TextRangeUnit unit, [In] bool extend);
		int Expand([In] TextRangeUnit unit);
		int FindText([In] string value, [In] int scanLength, [In] FindOptions options);
		void GetCharacterUtf32(out uint value, [In] int offset);
		ITextRange GetClone();
		int GetIndex([In] TextRangeUnit unit);
		void GetPoint([In] HorizontalCharacterAlignment horizontalAlign, [In] VerticalCharacterAlignment verticalAlign, [In] PointOptions options, out Point point);
		void GetRect([In] PointOptions options, out Rect rect, out int hit);
		void GetText([In] TextGetOptions options, out string value);
		void GetTextViaStream([In] TextGetOptions options, [In] IRandomAccessStream value);
		bool InRange([In] ITextRange range);
		void InsertImage([In] int width, [In] int height, [In] int ascent, [In] VerticalCharacterAlignment verticalAlign, [In] string alternateText, [In] IRandomAccessStream value);
		bool InStory([In] ITextRange range);
		bool IsEqual([In] ITextRange range);
		int Move([In] TextRangeUnit unit, [In] int count);
		int MoveEnd([In] TextRangeUnit unit, [In] int count);
		int MoveStart([In] TextRangeUnit unit, [In] int count);
		void Paste([In] int format);
		void ScrollIntoView([In] PointOptions value);
		void MatchSelection();
		void SetIndex([In] TextRangeUnit unit, [In] int index, [In] bool extend);
		void SetPoint([In] Point point, [In] PointOptions options, [In] bool extend);
		void SetRange([In] int startPosition, [In] int endPosition);
		void SetText([In] TextSetOptions options, [In] string value);
		void SetTextViaStream([In] TextSetOptions options, [In] IRandomAccessStream value);
		int StartOf([In] TextRangeUnit unit, [In] bool extend);
	}
}
