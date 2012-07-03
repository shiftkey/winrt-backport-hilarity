using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(UnhandledExceptionEventArgs)), Guid(1915758236u, 1358, 19699, 134, 197, 190, 144, 235, 104, 99, 213), Version(100794368u), WebHostHidden]
	internal interface IUnhandledExceptionEventArgs
	{
		HResult Exception
		{
			get;
		}
		bool Handled
		{
			get;
			set;
		}
		string Message
		{
			get;
		}
	}
}
