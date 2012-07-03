using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Version(100794368u), WebHostHidden]
	public struct CoreProximityEvaluation
	{
		public int Score;
		public Point AdjustedPoint;
	}
}
