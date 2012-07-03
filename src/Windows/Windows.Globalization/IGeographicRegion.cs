using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(GeographicRegion)), Guid(32089633u, 19044, 20185, 149, 79, 158, 222, 176, 123, 217, 3), Version(100794368u)]
	internal interface IGeographicRegion
	{
		string Code
		{
			get;
		}
		string CodeThreeDigit
		{
			get;
		}
		string CodeThreeLetter
		{
			get;
		}
		string CodeTwoLetter
		{
			get;
		}
		IVectorView<string> CurrenciesInUse
		{
			get;
		}
		string DisplayName
		{
			get;
		}
		string NativeName
		{
			get;
		}
	}
}
