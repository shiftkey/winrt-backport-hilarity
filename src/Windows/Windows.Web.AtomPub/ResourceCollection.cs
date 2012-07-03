using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceCollection : IResourceCollection, ISyndicationNode
	{
		public extern IVectorView<string> Accepts
		{
			get;
		}
		public extern IVectorView<SyndicationCategory> Categories
		{
			get;
		}
		public extern ISyndicationText Title
		{
			get;
		}
		public extern Uri Uri
		{
			get;
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
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
