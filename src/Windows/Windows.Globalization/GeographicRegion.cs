using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[Activatable(100794368u), Activatable(typeof(IGeographicRegionFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGeographicRegionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class GeographicRegion : IGeographicRegion
	{
		public extern string Code
		{
			get;
		}
		public extern string CodeThreeDigit
		{
			get;
		}
		public extern string CodeThreeLetter
		{
			get;
		}
		public extern string CodeTwoLetter
		{
			get;
		}
		public extern IVectorView<string> CurrenciesInUse
		{
			get;
		}
		public extern string DisplayName
		{
			get;
		}
		public extern string NativeName
		{
			get;
		}
		public extern GeographicRegion([In] string geographicRegionCode);
		public extern GeographicRegion();
		public static extern bool IsSupported([In] string geographicRegionCode);
	}
}
