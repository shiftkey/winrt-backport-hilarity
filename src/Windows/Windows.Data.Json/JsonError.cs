using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Json
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IJsonErrorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public static class JsonError
	{
		public static extern JsonErrorStatus GetStatus([In] int hresult);
	}
}
