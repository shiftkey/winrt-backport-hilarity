using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskRequestedDeferral : IPrintTaskRequestedDeferral
	{
		public extern void Complete();
	}
}
