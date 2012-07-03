using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ResourceMapIterator : IIterator<IKeyValuePair<string, NamedResource>>
	{
		public extern IKeyValuePair<string, NamedResource> Current
		{
			get;
		}
		public extern bool HasCurrent
		{
			get;
		}
		public extern bool MoveNext();
		public extern uint GetMany([Out] IKeyValuePair<string, NamedResource>[] items);
	}
}
