using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Xsl
{
	[Activatable(typeof(IXsltProcessorFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class XsltProcessor : IXsltProcessor
	{
		public extern XsltProcessor([In] XmlDocument document);
		public extern string TransformToString([In] IXmlNode inputNode);
	}
}
