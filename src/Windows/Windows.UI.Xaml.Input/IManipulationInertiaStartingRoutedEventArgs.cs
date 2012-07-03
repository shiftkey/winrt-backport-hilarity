using System;
using Windows.Devices.Input;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationInertiaStartingRoutedEventArgs)), Guid(610963881u, 51779, 19467, 172, 239, 129, 232, 184, 20, 117, 32), Version(100794368u), WebHostHidden]
	internal interface IManipulationInertiaStartingRoutedEventArgs
	{
		UIElement Container
		{
			get;
		}
		ManipulationDelta Cumulative
		{
			get;
		}
		ManipulationDelta Delta
		{
			get;
		}
		InertiaExpansionBehavior ExpansionBehavior
		{
			get;
			set;
		}
		bool Handled
		{
			get;
			set;
		}
		PointerDeviceType PointerDeviceType
		{
			get;
		}
		InertiaRotationBehavior RotationBehavior
		{
			get;
			set;
		}
		InertiaTranslationBehavior TranslationBehavior
		{
			get;
			set;
		}
		ManipulationVelocities Velocities
		{
			get;
		}
	}
}
