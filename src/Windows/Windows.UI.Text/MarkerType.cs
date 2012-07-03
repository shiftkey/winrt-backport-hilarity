using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[Version(100794368u)]
	public enum MarkerType
	{
		Undefined,
		None,
		Bullet,
		Arabic,
		LowercaseEnglishLetter,
		UppercaseEnglishLetter,
		LowercaseRoman,
		UppercaseRoman,
		UnicodeSequence,
		CircledNumber,
		BlackCircleWingding,
		WhiteCircleWingding,
		ArabicWide,
		SimplifiedChinese,
		TraditionalChinese,
		JapanSimplifiedChinese,
		JapanKorea,
		ArabicDictionary,
		ArabicAbjad,
		Hebrew,
		ThaiAlphabetic,
		ThaiNumeric,
		DevanagariVowel,
		DevanagariConsonant,
		DevanagariNumeric
	}
}
