using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class NotifyEventArgs : INotifyEventArgs
	{
		public extern string Value
		{
			get;
		}
	}
}
