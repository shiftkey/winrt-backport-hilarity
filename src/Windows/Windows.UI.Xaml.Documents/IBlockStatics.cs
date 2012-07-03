using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[ExclusiveTo(typeof(Block)), Guid(4167732276u, 36120, 19539, 174, 189, 145, 230, 16, 165, 224, 16), Version(100794368u), WebHostHidden]
	internal interface IBlockStatics
	{
		DependencyProperty LineHeightProperty
		{
			get;
		}
		DependencyProperty LineStackingStrategyProperty
		{
			get;
		}
		DependencyProperty TextAlignmentProperty
		{
			get;
		}
	}
}
