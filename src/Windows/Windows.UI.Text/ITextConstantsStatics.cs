using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[ExclusiveTo(typeof(TextConstants)), Guid(2006875187u, 6301, 19450, 151, 200, 16, 219, 19, 93, 151, 110), Version(100794368u), WebHostHidden]
	internal interface ITextConstantsStatics
	{
		Color AutoColor
		{
			get;
		}
		int MaxUnitCount
		{
			get;
		}
		int MinUnitCount
		{
			get;
		}
		Color UndefinedColor
		{
			get;
		}
		float UndefinedFloatValue
		{
			get;
		}
		FontStretch UndefinedFontStretch
		{
			get;
		}
		FontStyle UndefinedFontStyle
		{
			get;
		}
		int UndefinedInt32Value
		{
			get;
		}
	}
}
