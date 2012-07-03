using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class UnhandledExceptionEventArgs : IUnhandledExceptionEventArgs
	{
		public extern HResult Exception
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern string Message
		{
			get;
		}
	}
}
