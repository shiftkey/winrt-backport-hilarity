using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IStandardPrintTaskOptionsStatic), 100794368u), Version(100794368u)]
	public static class StandardPrintTaskOptions
	{
		public static extern string Binding
		{
			get;
		}
		public static extern string Collation
		{
			get;
		}
		public static extern string ColorMode
		{
			get;
		}
		public static extern string Copies
		{
			get;
		}
		public static extern string Duplex
		{
			get;
		}
		public static extern string HolePunch
		{
			get;
		}
		public static extern string InputBin
		{
			get;
		}
		public static extern string MediaSize
		{
			get;
		}
		public static extern string MediaType
		{
			get;
		}
		public static extern string NUp
		{
			get;
		}
		public static extern string Orientation
		{
			get;
		}
		public static extern string PrintQuality
		{
			get;
		}
		public static extern string Staple
		{
			get;
		}
	}
}
