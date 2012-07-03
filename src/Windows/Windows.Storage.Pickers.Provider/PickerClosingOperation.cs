using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class PickerClosingOperation : IPickerClosingOperation
	{
		public extern DateTime Deadline
		{
			get;
		}
		public extern PickerClosingDeferral GetDeferral();
	}
}
