using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class InertiaTranslationBehavior : IInertiaTranslationBehavior
	{
		public extern double DesiredDeceleration
		{
			get;
			set;
		}
		public extern double DesiredDisplacement
		{
			get;
			set;
		}
	}
}
