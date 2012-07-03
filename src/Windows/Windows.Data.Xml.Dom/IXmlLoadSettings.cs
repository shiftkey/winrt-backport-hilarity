using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[ExclusiveTo(typeof(XmlLoadSettings)), Guid(1487538088u, 65238, 18167, 180, 197, 251, 27, 167, 33, 8, 214), Version(100794368u)]
	internal interface IXmlLoadSettings
	{
		bool ElementContentWhiteSpace
		{
			get;
			set;
		}
		uint MaxElementDepth
		{
			get;
			set;
		}
		bool ProhibitDtd
		{
			get;
			set;
		}
		bool ResolveExternals
		{
			get;
			set;
		}
		bool ValidateOnParse
		{
			get;
			set;
		}
	}
}
