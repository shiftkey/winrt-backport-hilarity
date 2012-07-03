using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Xsl
{
	[ExclusiveTo(typeof(XsltProcessor)), Guid(658589376u, 39505, 18019, 191, 48, 14, 247, 66, 20, 111, 32), Version(100794368u)]
	internal interface IXsltProcessorFactory
	{
		XsltProcessor CreateInstance([In] XmlDocument document);
	}
}
