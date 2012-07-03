using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(PickerClosingDeferral)), Guid(2063071006u, 6759, 18993, 174, 128, 233, 7, 112, 138, 97, 155), Version(100794368u)]
	internal interface IPickerClosingDeferral
	{
		void Complete();
	}
}
