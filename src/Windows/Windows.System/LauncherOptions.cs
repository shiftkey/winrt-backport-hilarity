using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LauncherOptions : ILauncherOptions
	{
		public extern bool DisplayApplicationPicker
		{
			get;
			set;
		}
		public extern Uri FallbackUri
		{
			get;
			set;
		}
		public extern string PreferredApplicationDisplayName
		{
			get;
			set;
		}
		public extern string PreferredApplicationPackageFamilyName
		{
			get;
			set;
		}
		public extern bool TreatAsUntrusted
		{
			get;
			set;
		}
		public extern LauncherUIOptions UI
		{
			get;
		}
		public extern LauncherOptions();
	}
}
