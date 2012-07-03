using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Web.Syndication
{
	[Guid(2652416439u, 29257, 19269, 178, 41, 125, 248, 149, 165, 161, 245), Version(100794368u)]
	public interface ISyndicationClient
	{
		bool BypassCacheOnRetrieve
		{
			get;
			set;
		}
		uint MaxResponseBufferSize
		{
			get;
			set;
		}
		PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		PasswordCredential ServerCredential
		{
			get;
			set;
		}
		uint Timeout
		{
			get;
			set;
		}
		void SetRequestHeader([In] string name, [In] string value);
		IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync([In] Uri uri);
	}
}
