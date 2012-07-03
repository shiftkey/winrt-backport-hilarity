using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Guid(1556460418u, 59101, 18833, 171, 239, 6, 216, 210, 231, 189, 12), Version(100794368u)]
	public interface IXmlNodeSerializer
	{
		string InnerText
		{
			get;
			set;
		}
		string GetXml();
	}
}
