using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Guid(1524560859u, 1531, 17453, 128, 101, 100, 42, 254, 160, 44, 237), Version(100794368u), WebHostHidden]
	public interface ITextCharacterFormat
	{
		FormatEffect AllCaps
		{
			get;
			set;
		}
		Color BackgroundColor
		{
			get;
			set;
		}
		FormatEffect Bold
		{
			get;
			set;
		}
		FontStretch FontStretch
		{
			get;
			set;
		}
		FontStyle FontStyle
		{
			get;
			set;
		}
		Color ForegroundColor
		{
			get;
			set;
		}
		FormatEffect Hidden
		{
			get;
			set;
		}
		FormatEffect Italic
		{
			get;
			set;
		}
		float Kerning
		{
			get;
			set;
		}
		string LanguageTag
		{
			get;
			set;
		}
		LinkType LinkType
		{
			get;
		}
		string Name
		{
			get;
			set;
		}
		FormatEffect Outline
		{
			get;
			set;
		}
		float Position
		{
			get;
			set;
		}
		FormatEffect ProtectedText
		{
			get;
			set;
		}
		float Size
		{
			get;
			set;
		}
		FormatEffect SmallCaps
		{
			get;
			set;
		}
		float Spacing
		{
			get;
			set;
		}
		FormatEffect Strikethrough
		{
			get;
			set;
		}
		FormatEffect Subscript
		{
			get;
			set;
		}
		FormatEffect Superscript
		{
			get;
			set;
		}
		TextScript TextScript
		{
			get;
			set;
		}
		UnderlineType Underline
		{
			get;
			set;
		}
		int Weight
		{
			get;
			set;
		}
		void SetClone([In] ITextCharacterFormat value);
		ITextCharacterFormat GetClone();
		bool IsEqual([In] ITextCharacterFormat format);
	}
}
