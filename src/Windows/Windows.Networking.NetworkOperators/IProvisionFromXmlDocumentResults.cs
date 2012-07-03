using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(ProvisionFromXmlDocumentResults)), Guid(561447136u, 33283, 4575, 173, 185, 244, 206, 70, 45, 145, 55), Version(100794368u)]
	internal interface IProvisionFromXmlDocumentResults
	{
		bool AllElementsProvisioned
		{
			get;
		}
		string ProvisionResultsXml
		{
			get;
		}
	}
}
