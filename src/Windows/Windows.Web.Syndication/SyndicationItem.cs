using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(100794368u), Activatable(typeof(ISyndicationItemFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationItem : ISyndicationItem, ISyndicationNode
	{
		public extern IVector<SyndicationPerson> Authors
		{
			get;
		}
		public extern IVector<SyndicationCategory> Categories
		{
			get;
		}
		public extern Uri CommentsUri
		{
			get;
			set;
		}
		public extern SyndicationContent Content
		{
			get;
			set;
		}
		public extern IVector<SyndicationPerson> Contributors
		{
			get;
		}
		public extern string ETag
		{
			get;
		}
		public extern Uri EditMediaUri
		{
			get;
		}
		public extern Uri EditUri
		{
			get;
		}
		public extern string Id
		{
			get;
			set;
		}
		public extern Uri ItemUri
		{
			get;
		}
		public extern DateTime LastUpdatedTime
		{
			get;
			set;
		}
		public extern IVector<SyndicationLink> Links
		{
			get;
		}
		public extern DateTime PublishedDate
		{
			get;
			set;
		}
		public extern ISyndicationText Rights
		{
			get;
			set;
		}
		public extern SyndicationFeed Source
		{
			get;
			set;
		}
		public extern ISyndicationText Summary
		{
			get;
			set;
		}
		public extern ISyndicationText Title
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
		public extern SyndicationItem([In] string title, [In] SyndicationContent content, [In] Uri uri);
		public extern SyndicationItem();
		public extern void Load([In] string item);
		public extern void LoadFromXml([In] XmlDocument itemDocument);
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
