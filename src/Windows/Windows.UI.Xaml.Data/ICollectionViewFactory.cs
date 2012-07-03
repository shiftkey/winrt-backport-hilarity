using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Guid(886352628u, 36466, 18768, 145, 146, 236, 208, 125, 57, 157, 10), Version(100794368u), WebHostHidden]
	public interface ICollectionViewFactory
	{
		ICollectionView CreateView();
	}
}
