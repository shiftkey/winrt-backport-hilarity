using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.DataProtection
{
	[ExclusiveTo(typeof(DataProtectionProvider)), Guid(2918399404u, 18738, 19679, 172, 65, 114, 20, 51, 53, 20, 202), Version(100794368u)]
	internal interface IDataProtectionProviderFactory
	{
		DataProtectionProvider CreateOverloadExplicit([In] string protectionDescriptor);
	}
}
