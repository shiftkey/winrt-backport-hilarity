using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(DtdNotation)), Guid(2360664141u, 27974, 20187, 171, 115, 223, 131, 197, 26, 211, 151), Version(100794368u)]
	internal interface IDtdNotation : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		object PublicId
		{
			[return: Variant]
			get;
		}
		object SystemId
		{
			[return: Variant]
			get;
		}
	}
}
