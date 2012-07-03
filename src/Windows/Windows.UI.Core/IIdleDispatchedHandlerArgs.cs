using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(IdleDispatchedHandlerArgs)), Guid(2562419236u, 56348, 17355, 180, 237, 209, 192, 235, 35, 145, 243), Version(100794368u), WebHostHidden]
	internal interface IIdleDispatchedHandlerArgs
	{
		bool IsDispatcherIdle
		{
			get;
		}
	}
}
