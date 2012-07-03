using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Core
{
	[ExclusiveTo(typeof(CoreApplication)), Guid(3481683485u, 9758, 19314, 154, 205, 68, 237, 42, 206, 106, 41), Version(100794368u), WebHostHidden]
	internal interface ICoreApplicationExit
	{
		event EventHandler<object> Exiting;
		void Exit();
	}
}
