using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Guid(754503590u, 18038, 18826, 147, 245, 187, 219, 252, 11, 216, 131), Version(100794368u), WebHostHidden]
	public interface ITextParagraphFormat
	{
		ParagraphAlignment Alignment
		{
			get;
			set;
		}
		float FirstLineIndent
		{
			get;
		}
		FormatEffect KeepTogether
		{
			get;
			set;
		}
		FormatEffect KeepWithNext
		{
			get;
			set;
		}
		float LeftIndent
		{
			get;
		}
		float LineSpacing
		{
			get;
		}
		LineSpacingRule LineSpacingRule
		{
			get;
		}
		MarkerAlignment ListAlignment
		{
			get;
			set;
		}
		int ListLevelIndex
		{
			get;
			set;
		}
		int ListStart
		{
			get;
			set;
		}
		MarkerStyle ListStyle
		{
			get;
			set;
		}
		float ListTab
		{
			get;
			set;
		}
		MarkerType ListType
		{
			get;
			set;
		}
		FormatEffect NoLineNumber
		{
			get;
			set;
		}
		FormatEffect PageBreakBefore
		{
			get;
			set;
		}
		float RightIndent
		{
			get;
			set;
		}
		FormatEffect RightToLeft
		{
			get;
			set;
		}
		float SpaceAfter
		{
			get;
			set;
		}
		float SpaceBefore
		{
			get;
			set;
		}
		ParagraphStyle Style
		{
			get;
			set;
		}
		int TabCount
		{
			get;
		}
		FormatEffect WidowControl
		{
			get;
			set;
		}
		void AddTab([In] float position, [In] TabAlignment align, [In] TabLeader leader);
		void ClearAllTabs();
		void DeleteTab([In] float position);
		ITextParagraphFormat GetClone();
		void GetTab([In] int index, out float position, out TabAlignment align, out TabLeader leader);
		bool IsEqual([In] ITextParagraphFormat format);
		void SetClone([In] ITextParagraphFormat format);
		void SetIndents([In] float start, [In] float left, [In] float right);
		void SetLineSpacing([In] LineSpacingRule rule, [In] float spacing);
	}
}
