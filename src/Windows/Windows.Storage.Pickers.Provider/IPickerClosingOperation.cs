using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(PickerClosingOperation)), Guid(1290402692u, 48878, 20025, 167, 115, 252, 95, 14, 174, 50, 141), Version(100794368u)]
	internal interface IPickerClosingOperation
	{
		DateTime Deadline
		{
			get;
		}
		PickerClosingDeferral GetDeferral();
	}
}
