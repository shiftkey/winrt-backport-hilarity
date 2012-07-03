using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskOptions : IPrintTaskOptionsCore, IPrintTaskOptionsCoreProperties, IPrintTaskOptionsCoreUIConfiguration
	{
		public extern PrintBinding Binding
		{
			get;
			set;
		}
		public extern PrintCollation Collation
		{
			get;
			set;
		}
		public extern PrintColorMode ColorMode
		{
			get;
			set;
		}
		public extern PrintDuplex Duplex
		{
			get;
			set;
		}
		public extern PrintHolePunch HolePunch
		{
			get;
			set;
		}
		public extern uint MaxCopies
		{
			get;
		}
		public extern PrintMediaSize MediaSize
		{
			get;
			set;
		}
		public extern PrintMediaType MediaType
		{
			get;
			set;
		}
		public extern uint MinCopies
		{
			get;
		}
		public extern uint NumberOfCopies
		{
			get;
			set;
		}
		public extern PrintOrientation Orientation
		{
			get;
			set;
		}
		public extern PrintQuality PrintQuality
		{
			get;
			set;
		}
		public extern PrintStaple Staple
		{
			get;
			set;
		}
		public extern IVector<string> DisplayedOptions
		{
			get;
		}
		public extern PrintPageDescription GetPageDescription([In] uint jobPageNumber);
	}
}
