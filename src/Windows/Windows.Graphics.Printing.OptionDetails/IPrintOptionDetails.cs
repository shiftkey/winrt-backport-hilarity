using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[Guid(956729039u, 54914, 18783, 173, 254, 215, 51, 63, 92, 24, 8), Version(100794368u)]
	public interface IPrintOptionDetails
	{
		string ErrorText
		{
			get;
			set;
		}
		string OptionId
		{
			get;
		}
		PrintOptionType OptionType
		{
			get;
		}
		PrintOptionStates State
		{
			get;
			set;
		}
		object Value
		{
			[return: Variant]
			get;
		}
		bool TrySetValue([Variant] [In] object value);
	}
}
