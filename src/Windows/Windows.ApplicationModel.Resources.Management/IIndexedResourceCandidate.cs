using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[ExclusiveTo(typeof(IndexedResourceCandidate)), Guid(241278707u, 64236, 17428, 169, 215, 84, 172, 213, 149, 63, 41), Version(100794368u), WebHostHidden]
	internal interface IIndexedResourceCandidate
	{
		IMapView<string, string> Metadata
		{
			get;
		}
		IVectorView<IndexedResourceQualifier> Qualifiers
		{
			get;
		}
		IndexedResourceType Type
		{
			get;
		}
		Uri Uri
		{
			get;
		}
		string ValueAsString
		{
			get;
		}
		string GetQualifierValue([In] string qualifierName);
	}
}
