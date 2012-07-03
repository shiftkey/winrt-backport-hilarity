using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.UI.Text
{
	[Guid(3203288539u, 37042, 16524, 162, 246, 10, 10, 195, 30, 51, 228), Version(100794368u), WebHostHidden]
	public interface ITextDocument
	{
		CaretType CaretType
		{
			get;
			set;
		}
		float DefaultTabStop
		{
			get;
			set;
		}
		ITextSelection Selection
		{
			get;
		}
		uint UndoLimit
		{
			get;
			set;
		}
		bool CanCopy();
		bool CanPaste();
		bool CanRedo();
		bool CanUndo();
		int ApplyDisplayUpdates();
		int BatchDisplayUpdates();
		void BeginUndoGroup();
		void EndUndoGroup();
		ITextCharacterFormat GetDefaultCharacterFormat();
		ITextParagraphFormat GetDefaultParagraphFormat();
		ITextRange GetRange([In] int startPosition, [In] int endPosition);
		ITextRange GetRangeFromPoint([In] Point point, [In] PointOptions options);
		void GetText([In] TextGetOptions options, out string value);
		void LoadFromStream([In] TextSetOptions options, [In] IRandomAccessStream value);
		void Redo();
		void SaveToStream([In] TextGetOptions options, [In] IRandomAccessStream value);
		void SetDefaultCharacterFormat([In] ITextCharacterFormat value);
		void SetDefaultParagraphFormat([In] ITextParagraphFormat value);
		void SetText([In] TextSetOptions options, [In] string value);
		void Undo();
	}
}
