using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Activatable(100794368u), Activatable(typeof(ISyndicationAttributeFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class SyndicationAttribute : ISyndicationAttribute
	{
		public extern string Name
		{
			get;
			set;
		}
		public extern string Namespace
		{
			get;
			set;
		}
		public extern string Value
		{
			get;
			set;
		}
		public extern SyndicationAttribute([In] string attributeName, [In] string attributeNamespace, [In] string attributeValue);
		public extern SyndicationAttribute();
	}
}
