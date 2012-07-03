using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintBindingOptionDetails : IPrintOptionDetails, IPrintItemListOptionDetails
	{
		public extern string ErrorText
		{
			get;
			set;
		}
		public extern string OptionId
		{
			get;
		}
		public extern PrintOptionType OptionType
		{
			get;
		}
		public extern PrintOptionStates State
		{
			get;
			set;
		}
		public extern object Value
		{
			[return: Variant]
			get;
		}
		public extern IVectorView<object> Items
		{
			[return: HasVariant]
			get;
		}
		public extern bool TrySetValue([Variant] [In] object value);
	}
}
