using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlProcessingInstruction)), Guid(654834974u, 7826, 20174, 182, 244, 38, 240, 105, 7, 141, 220), Version(100794368u)]
	internal interface IXmlProcessingInstruction : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		string Data
		{
			get;
			set;
		}
		string Target
		{
			get;
		}
	}
}
