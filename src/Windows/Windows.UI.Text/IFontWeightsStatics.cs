using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Text
{
	[ExclusiveTo(typeof(FontWeights)), Guid(3015014869u, 7081, 18667, 157, 173, 192, 149, 232, 194, 59, 163), Version(100794368u), WebHostHidden]
	internal interface IFontWeightsStatics
	{
		FontWeight Black
		{
			get;
		}
		FontWeight Bold
		{
			get;
		}
		FontWeight ExtraBlack
		{
			get;
		}
		FontWeight ExtraBold
		{
			get;
		}
		FontWeight ExtraLight
		{
			get;
		}
		FontWeight Light
		{
			get;
		}
		FontWeight Medium
		{
			get;
		}
		FontWeight Normal
		{
			get;
		}
		FontWeight SemiBold
		{
			get;
		}
		FontWeight SemiLight
		{
			get;
		}
		FontWeight Thin
		{
			get;
		}
	}
}
