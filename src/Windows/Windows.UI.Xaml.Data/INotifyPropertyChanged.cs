using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Guid(3480606364u, 62196, 18539, 179, 2, 187, 76, 9, 186, 235, 250), Version(100794368u), WebHostHidden]
	public interface INotifyPropertyChanged
	{
		event PropertyChangedEventHandler PropertyChanged;
	}
}
