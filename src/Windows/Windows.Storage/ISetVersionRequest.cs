using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(SetVersionRequest)), Guid(3116854171u, 4182, 20073, 131, 48, 22, 38, 25, 149, 111, 155), Version(100794368u)]
	internal interface ISetVersionRequest
	{
		uint CurrentVersion
		{
			get;
		}
		uint DesiredVersion
		{
			get;
		}
		SetVersionDeferral GetDeferral();
	}
}
