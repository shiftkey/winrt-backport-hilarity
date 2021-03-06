using System;
using Windows.Foundation.Metadata;
namespace Windows.Web
{
	[Version(100794368u)]
	public enum WebErrorStatus
	{
		Unknown,
		CertificateCommonNameIsIncorrect,
		CertificateExpired,
		CertificateContainsErrors,
		CertificateRevoked,
		CertificateIsInvalid,
		ServerUnreachable,
		Timeout,
		ErrorHttpInvalidServerResponse,
		ConnectionAborted,
		ConnectionReset,
		Disconnected,
		HttpToHttpsOnRedirection,
		HttpsToHttpOnRedirection,
		CannotConnect,
		HostNameNotResolved,
		OperationCanceled,
		RedirectFailed,
		UnexpectedStatusCode,
		UnexpectedRedirection,
		UnexpectedClientError,
		UnexpectedServerError,
		MultipleChoices = 300,
		MovedPermanently,
		Found,
		SeeOther,
		NotModified,
		UseProxy,
		TemporaryRedirect = 307,
		BadRequest = 400,
		Unauthorized,
		PaymentRequired,
		Forbidden,
		NotFound,
		MethodNotAllowed,
		NotAcceptable,
		ProxyAuthenticationRequired,
		RequestTimeout,
		Conflict,
		Gone,
		LengthRequired,
		PreconditionFailed,
		RequestEntityTooLarge,
		RequestUriTooLong,
		UnsupportedMediaType,
		RequestedRangeNotSatisfiable,
		ExpectationFailed,
		InternalServerError = 500,
		NotImplemented,
		BadGateway,
		ServiceUnavailable,
		GatewayTimeout,
		HttpVersionNotSupported
	}
}
