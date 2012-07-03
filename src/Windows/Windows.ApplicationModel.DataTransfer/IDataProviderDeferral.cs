using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataProviderDeferral)), Guid(3268354931u, 11558, 17369, 182, 157, 220, 184, 109, 3, 246, 218), Version(100794368u)]
	internal interface IDataProviderDeferral
	{
		void Complete();
	}
}
