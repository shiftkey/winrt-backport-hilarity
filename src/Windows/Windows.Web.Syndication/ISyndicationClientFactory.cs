using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationClient)), Guid(784642860u, 42907, 16660, 178, 154, 5, 223, 251, 175, 185, 164), Version(100794368u)]
	internal interface ISyndicationClientFactory
	{
		SyndicationClient CreateSyndicationClient([In] PasswordCredential serverCredential);
	}
}
