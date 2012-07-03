using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(4263425334u, 32383, 20368, 172, 154, 71, 73, 132, 170, 229, 18), Version(100794368u), WebHostHidden]
	public interface IBindableObservableVector : IBindableVector, IBindableIterable
	{
		event BindableVectorChangedEventHandler VectorChanged;
	}
}
