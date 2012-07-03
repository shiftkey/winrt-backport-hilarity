using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DependencyPropertyChangedEventArgs : IDependencyPropertyChangedEventArgs
	{
		public extern object NewValue
		{
			get;
		}
		public extern object OldValue
		{
			get;
		}
		public extern DependencyProperty Property
		{
			get;
		}
	}
}
