using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceQualifier)), Guid(2019403186u, 19197, 17270, 168, 136, 197, 249, 166, 183, 160, 92), Version(100794368u)]
	internal interface IResourceQualifier
	{
		bool IsDefault
		{
			get;
		}
		bool IsMatch
		{
			get;
		}
		string QualifierName
		{
			get;
		}
		string QualifierValue
		{
			get;
		}
		double Score
		{
			get;
		}
	}
}
