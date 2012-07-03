using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(CollectionViewSource)), Guid(389678864u, 18095, 19468, 129, 139, 33, 182, 239, 129, 191, 101), Version(100794368u), WebHostHidden]
	internal interface ICollectionViewSourceStatics
	{
		DependencyProperty IsSourceGroupedProperty
		{
			get;
		}
		DependencyProperty ItemsPathProperty
		{
			get;
		}
		DependencyProperty SourceProperty
		{
			get;
		}
		DependencyProperty ViewProperty
		{
			get;
		}
	}
}
