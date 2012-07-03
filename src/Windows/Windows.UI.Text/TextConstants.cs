using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITextConstantsStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public static class TextConstants
	{
		public static extern Color AutoColor
		{
			get;
		}
		public static extern int MaxUnitCount
		{
			get;
		}
		public static extern int MinUnitCount
		{
			get;
		}
		public static extern Color UndefinedColor
		{
			get;
		}
		public static extern float UndefinedFloatValue
		{
			get;
		}
		public static extern FontStretch UndefinedFontStretch
		{
			get;
		}
		public static extern FontStyle UndefinedFontStyle
		{
			get;
		}
		public static extern int UndefinedInt32Value
		{
			get;
		}
	}
}
