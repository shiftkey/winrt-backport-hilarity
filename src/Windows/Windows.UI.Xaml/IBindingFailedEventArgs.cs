using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(BindingFailedEventArgs)), Guid(851562515u, 19901, 17517, 187, 184, 13, 227, 80, 72, 164, 73), Version(100794368u), WebHostHidden]
	internal interface IBindingFailedEventArgs
	{
		string Message
		{
			get;
		}
	}
}
