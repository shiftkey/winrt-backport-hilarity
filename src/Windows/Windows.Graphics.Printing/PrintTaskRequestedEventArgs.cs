using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskRequestedEventArgs : IPrintTaskRequestedEventArgs
	{
		public extern PrintTaskRequest Request
		{
			get;
		}
	}
}
