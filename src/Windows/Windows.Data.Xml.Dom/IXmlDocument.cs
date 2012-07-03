using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlDocument)), Guid(4159939846u, 7815, 17110, 188, 251, 184, 200, 9, 250, 84, 148), Version(100794368u)]
	internal interface IXmlDocument : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		XmlDocumentType Doctype
		{
			get;
		}
		XmlElement DocumentElement
		{
			get;
		}
		string DocumentUri
		{
			get;
		}
		XmlDomImplementation Implementation
		{
			get;
		}
		XmlElement CreateElement([In] string tagName);
		XmlDocumentFragment CreateDocumentFragment();
		XmlText CreateTextNode([In] string data);
		XmlComment CreateComment([In] string data);
		XmlProcessingInstruction CreateProcessingInstruction([In] string target, [In] string data);
		XmlAttribute CreateAttribute([In] string name);
		XmlEntityReference CreateEntityReference([In] string name);
		XmlNodeList GetElementsByTagName([In] string tagName);
		XmlCDataSection CreateCDataSection([In] string data);
		XmlAttribute CreateAttributeNS([Variant] [In] object namespaceUri, [In] string qualifiedName);
		XmlElement CreateElementNS([Variant] [In] object namespaceUri, [In] string qualifiedName);
		XmlElement GetElementById([In] string elementId);
		IXmlNode ImportNode([In] IXmlNode node, [In] bool deep);
	}
}
