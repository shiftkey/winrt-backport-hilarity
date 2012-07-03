using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataRequestDeferral)), Guid(1841608863u, 902, 16995, 135, 193, 237, 125, 206, 48, 137, 14), Version(100794368u)]
	internal interface IDataRequestDeferral
	{
		void Complete();
	}
}
