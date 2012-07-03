using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class KeySpline : DependencyObject, IKeySpline
	{
		public extern Point ControlPoint1
		{
			get;
			set;
		}
		public extern Point ControlPoint2
		{
			get;
			set;
		}
		public extern KeySpline();
	}
}
