using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing.OptionDetails
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskOptionChangedEventArgs : IPrintTaskOptionChangedEventArgs
	{
		public extern object OptionId
		{
			[return: Variant]
			get;
		}
	}
}
