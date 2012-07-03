using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Version(100794368u)]
	public enum TextRangeUnit
	{
		Character,
		Word,
		Sentence,
		Paragraph,
		Line,
		Story,
		Screen,
		Section,
		Window,
		CharacterFormat,
		ParagraphFormat,
		Object,
		HardParagraph,
		Cluster,
		Bold,
		Italic,
		Underline,
		Strikethrough,
		ProtectedText,
		Link,
		SmallCaps,
		AllCaps,
		Hidden,
		Outline,
		Shadow,
		Imprint,
		Disabled,
		Revised,
		Subscript,
		Superscript,
		FontBound,
		LinkProtected
	}
}
