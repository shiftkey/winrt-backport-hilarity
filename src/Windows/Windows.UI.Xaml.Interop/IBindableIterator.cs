using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(1780313095u, 1901, 18930, 131, 20, 245, 44, 156, 154, 131, 49), Version(100794368u), WebHostHidden]
	public interface IBindableIterator
	{
		object Current
		{
			get;
		}
		bool HasCurrent
		{
			get;
		}
		bool MoveNext();
	}
}
