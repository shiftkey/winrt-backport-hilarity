using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class IndexedResourceCandidate : IIndexedResourceCandidate
	{
		public extern IMapView<string, string> Metadata
		{
			get;
		}
		public extern IVectorView<IndexedResourceQualifier> Qualifiers
		{
			get;
		}
		public extern IndexedResourceType Type
		{
			get;
		}
		public extern Uri Uri
		{
			get;
		}
		public extern string ValueAsString
		{
			get;
		}
		public extern string GetQualifierValue([In] string qualifierName);
	}
}
