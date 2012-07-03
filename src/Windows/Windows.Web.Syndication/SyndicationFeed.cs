using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(100794368u), Activatable(typeof(ISyndicationFeedFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationFeed : ISyndicationFeed, ISyndicationNode
	{
		public extern IVector<SyndicationPerson> Authors
		{
			get;
		}
		public extern IVector<SyndicationCategory> Categories
		{
			get;
		}
		public extern IVector<SyndicationPerson> Contributors
		{
			get;
		}
		public extern Uri FirstUri
		{
			get;
		}
		public extern SyndicationGenerator Generator
		{
			get;
			set;
		}
		public extern Uri IconUri
		{
			get;
			set;
		}
		public extern string Id
		{
			get;
			set;
		}
		public extern Uri ImageUri
		{
			get;
			set;
		}
		public extern IVector<SyndicationItem> Items
		{
			get;
		}
		public extern DateTime LastUpdatedTime
		{
			get;
			set;
		}
		public extern Uri LastUri
		{
			get;
		}
		public extern IVector<SyndicationLink> Links
		{
			get;
		}
		public extern Uri NextUri
		{
			get;
		}
		public extern Uri PreviousUri
		{
			get;
		}
		public extern ISyndicationText Rights
		{
			get;
			set;
		}
		public extern SyndicationFormat SourceFormat
		{
			get;
		}
		public extern ISyndicationText Subtitle
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
		public extern SyndicationFeed([In] string title, [In] string subtitle, [In] Uri uri);
		public extern SyndicationFeed();
		public extern void Load([In] string feed);
		public extern void LoadFromXml([In] XmlDocument feedDocument);
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
