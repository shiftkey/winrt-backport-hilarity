using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ItemsChangedEventArgs : IItemsChangedEventArgs
	{
		public extern int Action
		{
			get;
		}
		public extern int ItemCount
		{
			get;
		}
		public extern int ItemUICount
		{
			get;
		}
		public extern GeneratorPosition OldPosition
		{
			get;
		}
		public extern GeneratorPosition Position
		{
			get;
		}
	}
}
