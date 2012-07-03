using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceQualifier : IResourceQualifier
	{
		public extern bool IsDefault
		{
			get;
		}
		public extern bool IsMatch
		{
			get;
		}
		public extern string QualifierName
		{
			get;
		}
		public extern string QualifierValue
		{
			get;
		}
		public extern double Score
		{
			get;
		}
	}
}
