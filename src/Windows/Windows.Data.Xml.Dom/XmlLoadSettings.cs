using System;
using Windows.Foundation.Metadata;
namespace Windows.Data.Xml.Dom
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class XmlLoadSettings : IXmlLoadSettings
	{
		public extern bool ElementContentWhiteSpace
		{
			get;
			set;
		}
		public extern uint MaxElementDepth
		{
			get;
			set;
		}
		public extern bool ProhibitDtd
		{
			get;
			set;
		}
		public extern bool ResolveExternals
		{
			get;
			set;
		}
		public extern bool ValidateOnParse
		{
			get;
			set;
		}
		public extern XmlLoadSettings();
	}
}
