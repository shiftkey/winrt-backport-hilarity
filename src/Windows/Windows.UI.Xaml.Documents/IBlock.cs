using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Block)), Guid(1271791638u, 56647, 17232, 140, 176, 225, 113, 96, 10, 200, 150), Version(100794368u), WebHostHidden]
	internal interface IBlock
	{
		double LineHeight
		{
			get;
			set;
		}
		LineStackingStrategy LineStackingStrategy
		{
			get;
			set;
		}
		TextAlignment TextAlignment
		{
			get;
			set;
		}
	}
}
