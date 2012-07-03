using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(DtdEntity)), Guid(1779130364u, 25524, 18447, 158, 106, 138, 146, 129, 106, 173, 228), Version(100794368u)]
	internal interface IDtdEntity : IXmlNode, IXmlNodeSelector, IXmlNodeSerializer
	{
		object NotationName
		{
			[return: Variant]
			get;
		}
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
