using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(201660242u, 40895, 19568, 170, 12, 14, 76, 130, 217, 167, 97), Version(100794368u)]
	public delegate void VectorChangedEventHandler<T>([In] IObservableVector<T> sender, [In] IVectorChangedEventArgs @event);
}
