using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(typeof(ISyndicationContentFactory), 100794368u), Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationContent : ISyndicationText, ISyndicationNode, ISyndicationContent
	{
		public extern string Text
		{
			get;
			set;
		}
		public extern string Type
		{
			get;
			set;
		}
		public extern XmlDocument Xml
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
		public extern Uri SourceUri
		{
			get;
			set;
		}
		public extern SyndicationContent([In] string text, [In] SyndicationTextType type);
		public extern SyndicationContent([In] Uri sourceUri);
		public extern SyndicationContent();
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
