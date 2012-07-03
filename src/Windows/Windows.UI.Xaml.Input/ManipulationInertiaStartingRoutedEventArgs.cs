using System;
using Windows.Devices.Input;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ManipulationInertiaStartingRoutedEventArgs : RoutedEventArgs, IManipulationInertiaStartingRoutedEventArgs
	{
		public extern UIElement Container
		{
			get;
		}
		public extern ManipulationDelta Cumulative
		{
			get;
		}
		public extern ManipulationDelta Delta
		{
			get;
		}
		public extern InertiaExpansionBehavior ExpansionBehavior
		{
			get;
			set;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern PointerDeviceType PointerDeviceType
		{
			get;
		}
		public extern InertiaRotationBehavior RotationBehavior
		{
			get;
			set;
		}
		public extern InertiaTranslationBehavior TranslationBehavior
		{
			get;
			set;
		}
		public extern ManipulationVelocities Velocities
		{
			get;
		}
		public extern ManipulationInertiaStartingRoutedEventArgs();
	}
}
