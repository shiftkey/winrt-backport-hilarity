using System;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Guid(3117178496u, 12602, 16529, 162, 166, 36, 62, 14, 233, 35, 249), Version(100794368u)]
	public interface ISyndicationText : ISyndicationNode
	{
		string Text
		{
			get;
			set;
		}
		string Type
		{
			get;
			set;
		}
		XmlDocument Xml
		{
			get;
			set;
		}
	}
}
