using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Version(100794368u)]
	public struct CrossSlideThresholds
	{
		public float SelectionStart;
		public float SpeedBumpStart;
		public float SpeedBumpEnd;
		public float RearrangeStart;
	}
}
