using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Guid(2114042328u, 55221, 18614, 179, 28, 91, 181, 189, 245, 240, 155), Version(100794368u), WebHostHidden]
	public interface ICollectionViewGroup
	{
		object Group
		{
			get;
		}
		IObservableVector<object> GroupItems
		{
			get;
		}
	}
}
