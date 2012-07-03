using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(UssdMessage)), Guid(798674818u, 4099, 19805, 191, 129, 42, 186, 27, 75, 228, 168), Version(100794368u)]
	internal interface IUssdMessageFactory
	{
		UssdMessage CreateMessage([In] string messageText);
	}
}
