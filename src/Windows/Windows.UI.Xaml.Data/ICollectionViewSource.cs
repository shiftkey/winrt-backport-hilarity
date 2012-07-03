using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(CollectionViewSource)), Guid(2791969094u, 54011, 20141, 190, 159, 53, 120, 164, 102, 220, 254), Version(100794368u), WebHostHidden]
	internal interface ICollectionViewSource
	{
		bool IsSourceGrouped
		{
			get;
			set;
		}
		PropertyPath ItemsPath
		{
			get;
			set;
		}
		object Source
		{
			get;
			set;
		}
		ICollectionView View
		{
			get;
		}
	}
}
