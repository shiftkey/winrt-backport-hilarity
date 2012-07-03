using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICollectionViewSourceStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CollectionViewSource : DependencyObject, ICollectionViewSource
	{
		public extern bool IsSourceGrouped
		{
			get;
			set;
		}
		public extern PropertyPath ItemsPath
		{
			get;
			set;
		}
		public extern object Source
		{
			get;
			set;
		}
		public extern ICollectionView View
		{
			get;
		}
		public static extern DependencyProperty IsSourceGroupedProperty
		{
			get;
		}
		public static extern DependencyProperty ItemsPathProperty
		{
			get;
		}
		public static extern DependencyProperty SourceProperty
		{
			get;
		}
		public static extern DependencyProperty ViewProperty
		{
			get;
		}
		public extern CollectionViewSource();
	}
}
