using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input.Inking
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class InkRecognizer : IInkRecognizer
	{
		public extern string Name
		{
			get;
		}
	}
}
