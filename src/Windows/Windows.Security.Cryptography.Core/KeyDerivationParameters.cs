using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IKeyDerivationParametersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class KeyDerivationParameters : IKeyDerivationParameters
	{
		public extern uint IterationCount
		{
			get;
		}
		public extern IBuffer KdfGenericBinary
		{
			get;
			set;
		}
		public static extern KeyDerivationParameters BuildForPbkdf2([In] IBuffer pbkdf2Salt, [In] uint iterationCount);
		public static extern KeyDerivationParameters BuildForSP800108([In] IBuffer label, [In] IBuffer context);
		public static extern KeyDerivationParameters BuildForSP80056a([In] IBuffer algorithmId, [In] IBuffer partyUInfo, [In] IBuffer partyVInfo, [In] IBuffer suppPubInfo, [In] IBuffer suppPrivInfo);
	}
}
