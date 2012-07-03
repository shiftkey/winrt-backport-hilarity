using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System
{
	[ExclusiveTo(typeof(LauncherOptions)), Guid(3136954840u, 45169, 19672, 133, 62, 52, 18, 3, 229, 87, 211), Version(100794368u)]
	internal interface ILauncherOptions
	{
		bool DisplayApplicationPicker
		{
			get;
			set;
		}
		Uri FallbackUri
		{
			get;
			set;
		}
		string PreferredApplicationDisplayName
		{
			get;
			set;
		}
		string PreferredApplicationPackageFamilyName
		{
			get;
			set;
		}
		bool TreatAsUntrusted
		{
			get;
			set;
		}
		LauncherUIOptions UI
		{
			get;
		}
	}
}
