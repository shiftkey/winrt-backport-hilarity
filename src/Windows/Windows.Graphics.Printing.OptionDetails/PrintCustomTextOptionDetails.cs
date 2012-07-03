using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintCustomTextOptionDetails : IPrintOptionDetails, IPrintCustomOptionDetails, IPrintCustomTextOptionDetails
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
		public extern string DisplayName
		{
			get;
			set;
		}
		public extern uint MaxCharacters
		{
			get;
			set;
		}
		public extern bool TrySetValue([Variant] [In] object value);
	}
}
