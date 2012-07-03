using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PrintTaskCompletedEventArgs : IPrintTaskCompletedEventArgs
	{
		public extern PrintTaskCompletion Completion
		{
			get;
		}
	}
}
