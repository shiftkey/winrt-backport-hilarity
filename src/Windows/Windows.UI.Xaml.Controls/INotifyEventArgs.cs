using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(NotifyEventArgs)), Guid(2936931831u, 50359, 17605, 176, 157, 92, 183, 5, 43, 58, 151), Version(100794368u), WebHostHidden]
	internal interface INotifyEventArgs
	{
		string Value
		{
			get;
		}
	}
}
