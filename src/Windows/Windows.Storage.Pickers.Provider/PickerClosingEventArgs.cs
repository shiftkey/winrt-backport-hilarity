using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class PickerClosingEventArgs : IPickerClosingEventArgs
	{
		public extern PickerClosingOperation ClosingOperation
		{
			get;
		}
		public extern bool IsCanceled
		{
			get;
		}
	}
}
