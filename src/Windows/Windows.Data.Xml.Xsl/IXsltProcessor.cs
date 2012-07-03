using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Xsl
{
	[ExclusiveTo(typeof(XsltProcessor)), Guid(2070179903u, 21772, 18630, 169, 15, 147, 165, 185, 100, 81, 143), Version(100794368u)]
	internal interface IXsltProcessor
	{
		string TransformToString([In] IXmlNode inputNode);
	}
}
