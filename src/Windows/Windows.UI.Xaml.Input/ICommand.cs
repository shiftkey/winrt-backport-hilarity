using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[Guid(3853464898u, 51815, 16513, 153, 91, 112, 157, 209, 55, 146, 223), Version(100794368u), WebHostHidden]
	public interface ICommand
	{
		event EventHandler<object> CanExecuteChanged;
		bool CanExecute([In] object parameter);
		void Execute([In] object parameter);
	}
}
