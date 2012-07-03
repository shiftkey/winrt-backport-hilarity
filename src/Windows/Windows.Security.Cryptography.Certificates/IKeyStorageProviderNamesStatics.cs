using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Certificates
{
	[ExclusiveTo(typeof(KeyStorageProviderNames)), Guid(2937613024u, 21801, 17922, 189, 148, 10, 171, 145, 149, 123, 92), Version(134217728u)]
	internal interface IKeyStorageProviderNamesStatics
	{
		string PlatformKeyStorageProvider
		{
			get;
		}
		string SmartcardKeyStorageProvider
		{
			get;
		}
		string SoftwareKeyStorageProvider
		{
			get;
		}
	}
}
