using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(typeof(ISyndicationLinkFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationLink : ISyndicationLink, ISyndicationNode
	{
		public extern uint Length
		{
			get;
			set;
		}
		public extern string MediaType
		{
			get;
			set;
		}
		public extern string Relationship
		{
			get;
			set;
		}
		public extern string ResourceLanguage
		{
			get;
			set;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern Uri Uri
		{
			get;
			set;
		}
		public extern IVector<SyndicationAttribute> AttributeExtensions
		{
			get;
		}
		public extern Uri BaseUri
		{
			get;
			set;
		}
		public extern IVector<ISyndicationNode> ElementExtensions
		{
			get;
		}
		public extern string Language
		{
			get;
			set;
		}
		public extern string NodeName
		{
			get;
			set;
		}
		public extern string NodeNamespace
		{
			get;
			set;
		}
		public extern string NodeValue
		{
			get;
			set;
		}
		public extern SyndicationLink([In] Uri uri);
		public extern SyndicationLink([In] Uri uri, [In] string relationship, [In] string title, [In] string mediaType, [In] uint length);
		public extern SyndicationLink();
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
