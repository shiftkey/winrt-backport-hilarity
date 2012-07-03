using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[ExclusiveTo(typeof(IndexedResourceQualifier)), Guid(3672357787u, 54020, 18815, 161, 104, 163, 64, 4, 44, 138, 219), Version(100794368u), WebHostHidden]
	internal interface IIndexedResourceQualifier
	{
		string QualifierName
		{
			get;
		}
		string QualifierValue
		{
			get;
		}
	}
}
