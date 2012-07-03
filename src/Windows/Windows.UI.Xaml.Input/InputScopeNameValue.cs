using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Version(100794368u), WebHostHidden]
	public enum InputScopeNameValue
	{
		Default,
		Url,
		EmailSmtpAddress = 5,
		Number = 29,
		TelephoneNumber = 32,
		Search = 51,
		NumberFullWidth = 39,
		AlphanumericHalfWidth,
		AlphanumericFullWidth,
		Hiragana = 44,
		KatakanaHalfWidth,
		KatakanaFullWidth,
		Hanja,
		HangulHalfWidth,
		HangulFullWidth,
		ChineseHalfWidth = 53,
		ChineseFullWidth,
		NativeScript
	}
}
