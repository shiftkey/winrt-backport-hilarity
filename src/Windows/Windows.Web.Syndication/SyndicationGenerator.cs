using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(100794368u), Activatable(typeof(ISyndicationGeneratorFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationGenerator : ISyndicationGenerator, ISyndicationNode
	{
		public extern string Text
		{
			get;
			set;
		}
		public extern Uri Uri
		{
			get;
			set;
		}
		public extern string Version
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
		public extern SyndicationGenerator([In] string text);
		public extern SyndicationGenerator();
		public extern XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
