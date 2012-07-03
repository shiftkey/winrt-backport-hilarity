using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(WindowActivatedEventArgs)), Guid(396191207u, 18008, 19638, 170, 19, 65, 208, 148, 234, 37, 94), Version(100794368u), WebHostHidden]
	internal interface IWindowActivatedEventArgs : ICoreWindowEventArgs
	{
		CoreWindowActivationState WindowActivationState
		{
			get;
		}
	}
}
