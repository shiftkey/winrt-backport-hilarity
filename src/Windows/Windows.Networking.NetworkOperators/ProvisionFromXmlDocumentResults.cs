using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[DualApiPartition(version = 100794368u), Version(100794368u)]
	public sealed class ProvisionFromXmlDocumentResults : IProvisionFromXmlDocumentResults
	{
		public extern bool AllElementsProvisioned
		{
			get;
		}
		public extern string ProvisionResultsXml
		{
			get;
		}
	}
}
