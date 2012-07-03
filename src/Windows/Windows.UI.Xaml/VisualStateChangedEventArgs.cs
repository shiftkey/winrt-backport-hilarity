using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class VisualStateChangedEventArgs : IVisualStateChangedEventArgs
	{
		public extern Control Control
		{
			get;
			set;
		}
		public extern VisualState NewState
		{
			get;
			set;
		}
		public extern VisualState OldState
		{
			get;
			set;
		}
		public extern VisualStateChangedEventArgs();
	}
}
