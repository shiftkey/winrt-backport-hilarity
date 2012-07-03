using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToggleButton)), Guid(3524152360u, 61835, 18714, 154, 69, 241, 160, 74, 147, 105, 164), Version(100794368u), WebHostHidden]
	internal interface IToggleButtonOverrides
	{
		void OnToggle();
	}
}
