using System;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[ExclusiveTo(typeof(SignalNotifier)), Guid(338189830u, 25511, 18195, 182, 217, 98, 246, 75, 86, 251, 139), Version(100794368u), WebHostHidden]
	internal interface ISignalNotifier
	{
		void Enable();
		void Terminate();
	}
}
