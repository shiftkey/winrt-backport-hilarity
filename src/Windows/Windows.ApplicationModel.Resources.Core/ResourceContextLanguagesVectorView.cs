using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceContextLanguagesVectorView : IVectorView<string>, IIterable<string>
	{
		public extern uint Size
		{
			get;
		}
		public extern string GetAt([In] uint index);
		public extern bool IndexOf([In] string value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] string[] items);
		public extern IIterator<string> First();
	}
}
