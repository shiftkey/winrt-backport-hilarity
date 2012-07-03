using System;
using Windows.Foundation.Metadata;
using Windows.System;
namespace Windows.ApplicationModel
{
	[ExclusiveTo(typeof(PackageId)), Guid(450586206u, 14279, 18320, 153, 128, 221, 122, 231, 78, 139, 178), Version(100794368u)]
	internal interface IPackageId
	{
		ProcessorArchitecture Architecture
		{
			get;
		}
		string FamilyName
		{
			get;
		}
		string FullName
		{
			get;
		}
		string Name
		{
			get;
		}
		string Publisher
		{
			get;
		}
		string PublisherId
		{
			get;
		}
		string ResourceId
		{
			get;
		}
		PackageVersion Version
		{
			get;
		}
	}
}
