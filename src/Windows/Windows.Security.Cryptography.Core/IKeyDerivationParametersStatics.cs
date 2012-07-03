using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[ExclusiveTo(typeof(KeyDerivationParameters)), Guid(3935707070u, 62335, 16710, 157, 254, 164, 86, 241, 115, 95, 75), Version(100794368u)]
	internal interface IKeyDerivationParametersStatics
	{
		KeyDerivationParameters BuildForPbkdf2([In] IBuffer pbkdf2Salt, [In] uint iterationCount);
		KeyDerivationParameters BuildForSP800108([In] IBuffer label, [In] IBuffer context);
		KeyDerivationParameters BuildForSP80056a([In] IBuffer algorithmId, [In] IBuffer partyUInfo, [In] IBuffer partyVInfo, [In] IBuffer suppPubInfo, [In] IBuffer suppPrivInfo);
	}
}
