using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlDocumentType)), Guid(4147389477u, 38785, 18788, 142, 148, 155, 28, 109, 252, 155, 199), Version(100794368u)]
	internal interface IXmlDocumentType : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		XmlNamedNodeMap Entities
		{
			get;
		}
		string Name
		{
			get;
		}
		XmlNamedNodeMap Notations
		{
			get;
		}
	}
}
