using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(PickerClosingEventArgs)), Guid(2119823908u, 45874, 20242, 139, 159, 168, 194, 240, 107, 50, 205), Version(100794368u)]
	internal interface IPickerClosingEventArgs
	{
		PickerClosingOperation ClosingOperation
		{
			get;
		}
		bool IsCanceled
		{
			get;
		}
	}
}
