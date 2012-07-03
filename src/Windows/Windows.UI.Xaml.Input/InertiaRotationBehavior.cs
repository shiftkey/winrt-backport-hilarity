using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class InertiaRotationBehavior : IInertiaRotationBehavior
	{
		public extern double DesiredDeceleration
		{
			get;
			set;
		}
		public extern double DesiredRotation
		{
			get;
			set;
		}
	}
}
