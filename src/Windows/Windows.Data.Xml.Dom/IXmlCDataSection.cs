using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlCDataSection)), Guid(1292153967u, 51389, 17844, 136, 153, 4, 0, 215, 194, 198, 15), Version(100794368u)]
	internal interface IXmlCDataSection : IXmlText, IXmlCharacterData, IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
	}
}
