using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(TouchHitTestingEventArgs)), Guid(586397731u, 2940, 16974, 157, 247, 51, 212, 249, 98, 147, 27), Version(100794368u), WebHostHidden]
	internal interface ITouchHitTestingEventArgs : ICoreWindowEventArgs
	{
		Rect BoundingBox
		{
			get;
		}
		Point Point
		{
			get;
		}
		CoreProximityEvaluation ProximityEvaluation
		{
			get;
			set;
		}
		[DefaultOverload, Overload("EvaluateProximityToRect")]
		CoreProximityEvaluation EvaluateProximity([In] Rect controlBoundingBox);
		[Overload("EvaluateProximityToPolygon")]
		CoreProximityEvaluation EvaluateProximity([In] Point[] controlVertices);
	}
}
