using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Version(100794368u), WebHostHidden]
	public enum CoreProximityEvaluationScore
	{
		Closest,
		Farthest = 2147483647
	}
}
