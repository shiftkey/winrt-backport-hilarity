using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Activatable(typeof(IUriRuntimeClassFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Uri : IUriRuntimeClass, IUriRuntimeClassWithAbsoluteCanonicalUri
	{
		public extern string AbsoluteUri
		{
			get;
		}
		public extern string DisplayUri
		{
			get;
		}
		public extern string Domain
		{
			get;
		}
		public extern string Extension
		{
			get;
		}
		public extern string Fragment
		{
			get;
		}
		public extern string Host
		{
			get;
		}
		public extern string Password
		{
			get;
		}
		public extern string Path
		{
			get;
		}
		public extern int Port
		{
			get;
		}
		public extern string Query
		{
			get;
		}
		public extern WwwFormUrlDecoder QueryParsed
		{
			get;
		}
		public extern string RawUri
		{
			get;
		}
		public extern string SchemeName
		{
			get;
		}
		public extern bool Suspicious
		{
			get;
		}
		public extern string UserName
		{
			get;
		}
		public extern string AbsoluteCanonicalUri
		{
			get;
		}
		public extern string DisplayIri
		{
			get;
		}
		public extern Uri([In] string uri);
		public extern Uri([In] string baseUri, [In] string relativeUri);
		public extern bool Equals([In] Uri pUri);
		public extern Uri CombineUri([In] string relativeUri);
	}
}
