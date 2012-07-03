using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Guid(1966927736u, 20984, 17856, 169, 245, 241, 113, 157, 236, 63, 178), Version(100794368u)]
	public interface ISyndicationNode
	{
		IVector<SyndicationAttribute> AttributeExtensions
		{
			get;
		}
		Uri BaseUri
		{
			get;
			set;
		}
		IVector<ISyndicationNode> ElementExtensions
		{
			get;
		}
		string Language
		{
			get;
			set;
		}
		string NodeName
		{
			get;
			set;
		}
		string NodeNamespace
		{
			get;
			set;
		}
		string NodeValue
		{
			get;
			set;
		}
		XmlDocument GetXmlDocument([In] SyndicationFormat format);
	}
}
