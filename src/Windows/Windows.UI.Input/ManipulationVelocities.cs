using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Input
{
	[Version(100794368u)]
	public struct ManipulationVelocities
	{
		public Point Linear;
		public float Angular;
		public float Expansion;
	}
}
