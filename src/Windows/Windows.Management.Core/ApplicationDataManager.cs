using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Management.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IApplicationDataManagerStatics), 100794368u), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class ApplicationDataManager : IApplicationDataManager
	{
		public static extern ApplicationData CreateForPackageFamily([In] string packageFamilyName);
	}
}
