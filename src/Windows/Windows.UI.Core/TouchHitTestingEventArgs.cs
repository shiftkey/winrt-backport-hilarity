using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class TouchHitTestingEventArgs : ITouchHitTestingEventArgs, ICoreWindowEventArgs
	{
		public extern Rect BoundingBox
		{
			get;
		}
		public extern Point Point
		{
			get;
		}
		public extern CoreProximityEvaluation ProximityEvaluation
		{
			get;
			set;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		[DefaultOverload, Overload("EvaluateProximityToRect")]
		public extern CoreProximityEvaluation EvaluateProximity([In] Rect controlBoundingBox);
		[Overload("EvaluateProximityToPolygon")]
		public extern CoreProximityEvaluation EvaluateProximity([In] Point[] controlVertices);
	}
}
