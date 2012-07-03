using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlAttribute)), Guid(2887010980u, 46321, 19894, 178, 6, 138, 34, 195, 8, 219, 10), Version(100794368u)]
	internal interface IXmlAttribute : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		string Name
		{
			get;
		}
		bool Specified
		{
			get;
		}
		string Value
		{
			get;
			set;
		}
	}
}
