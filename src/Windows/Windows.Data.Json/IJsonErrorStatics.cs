using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[ExclusiveTo(typeof(JsonError)), Guid(4267796326u, 48935, 16484, 135, 183, 101, 99, 187, 17, 206, 46), Version(100794368u), WebHostHidden]
	internal interface IJsonErrorStatics
	{
		JsonErrorStatus GetStatus([In] int hresult);
	}
}
