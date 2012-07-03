using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.ExchangeActiveSyncProvisioning
{
	[Activatable(100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class EasClientDeviceInformation : IEasClientDeviceInformation
	{
		public extern string FriendlyName
		{
			get;
		}
		public extern Guid Id
		{
			get;
		}
		public extern string OperatingSystem
		{
			get;
		}
		public extern string SystemManufacturer
		{
			get;
		}
		public extern string SystemProductName
		{
			get;
		}
		public extern string SystemSku
		{
			get;
		}
		public extern EasClientDeviceInformation();
	}
}
