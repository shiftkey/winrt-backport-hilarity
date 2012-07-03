using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TimelineMarkerCollection : IVector<TimelineMarker>, IIterable<TimelineMarker>
	{
		public extern uint Size
		{
			get;
		}
		public extern TimelineMarkerCollection();
		public extern TimelineMarker GetAt([In] uint index);
		public extern IVectorView<TimelineMarker> GetView();
		public extern bool IndexOf([In] TimelineMarker value, out uint index);
		public extern void SetAt([In] uint index, [In] TimelineMarker value);
		public extern void InsertAt([In] uint index, [In] TimelineMarker value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] TimelineMarker value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] TimelineMarker[] items);
		public extern void ReplaceAll([In] TimelineMarker[] items);
		public extern IIterator<TimelineMarker> First();
	}
}
