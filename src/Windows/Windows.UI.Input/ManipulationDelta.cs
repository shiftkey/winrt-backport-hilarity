using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Version(100794368u)]
	public struct ManipulationDelta
	{
		public Point Translation;
		public float Scale;
		public float Rotation;
		public float Expansion;
	}
}
