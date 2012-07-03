using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ItemClickEventArgs)), Guid(2620473922u, 62106, 18765, 163, 165, 212, 199, 178, 164, 104, 82), Version(100794368u), WebHostHidden]
	internal interface IItemClickEventArgs
	{
		object ClickedItem
		{
			get;
		}
	}
}
