namespace Windows.Foundation.Diagnostics
{
	public interface IErrorReportingSettings
	{
		void SetErrorOptions(ErrorOptions value);
		ErrorOptions GetErrorOptions();
	}
}
