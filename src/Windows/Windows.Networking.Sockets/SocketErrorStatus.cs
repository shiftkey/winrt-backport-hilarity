using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[Version(100794368u)]
	public enum SocketErrorStatus
	{
		Unknown,
		OperationAborted,
		HttpInvalidServerResponse,
		ConnectionTimedOut,
		AddressFamilyNotSupported,
		SocketTypeNotSupported,
		HostNotFound,
		NoDataRecordOfRequestedType,
		NonAuthoritativeHostNotFound,
		ClassTypeNotFound,
		AddressAlreadyInUse,
		CannotAssignRequestedAddress,
		ConnectionRefused,
		NetworkIsUnreachable,
		UnreachableHost,
		NetworkIsDown,
		NetworkDroppedConnectionOnReset,
		SoftwareCausedConnectionAbort,
		ConnectionResetByPeer,
		HostIsDown,
		NoAddressesFound,
		TooManyOpenFiles,
		MessageTooLong,
		CertificateExpired,
		CertificateUntrustedRoot,
		CertificateCommonNameIsIncorrect,
		CertificateWrongUsage,
		CertificateRevoked,
		CertificateNoRevocationCheck,
		CertificateRevocationServerOffline,
		CertificateIsInvalid
	}
}
