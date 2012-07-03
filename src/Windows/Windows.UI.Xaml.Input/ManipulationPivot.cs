using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Activatable(typeof(IManipulationPivotFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ManipulationPivot : IManipulationPivot
	{
		public extern Point Center
		{
			get;
			set;
		}
		public extern double Radius
		{
			get;
			set;
		}
		public extern ManipulationPivot();
		public extern ManipulationPivot([In] Point center, [In] double radius);
	}
}
