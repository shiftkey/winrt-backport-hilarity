using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class IndexedResourceQualifier : IIndexedResourceQualifier
	{
		public extern string QualifierName
		{
			get;
		}
		public extern string QualifierValue
		{
			get;
		}
	}
}
