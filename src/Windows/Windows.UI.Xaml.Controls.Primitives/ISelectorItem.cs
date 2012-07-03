using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(SelectorItem)), Guid(1411157356u, 643, 17793, 185, 69, 42, 100, 194, 138, 6, 70), Version(100794368u), WebHostHidden]
	internal interface ISelectorItem
	{
		bool IsSelected
		{
			get;
			set;
		}
	}
}
