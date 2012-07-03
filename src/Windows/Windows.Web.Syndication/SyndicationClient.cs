using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
namespace Windows.Web.Syndication
{
	[Activatable(typeof(ISyndicationClientFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationClient : ISyndicationClient
	{
		public extern bool BypassCacheOnRetrieve
		{
			get;
			set;
		}
		public extern uint MaxResponseBufferSize
		{
			get;
			set;
		}
		public extern PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		public extern PasswordCredential ServerCredential
		{
			get;
			set;
		}
		public extern uint Timeout
		{
			get;
			set;
		}
		public extern SyndicationClient([In] PasswordCredential serverCredential);
		public extern SyndicationClient();
		public extern void SetRequestHeader([In] string name, [In] string value);
		public extern IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync([In] Uri uri);
	}
}
