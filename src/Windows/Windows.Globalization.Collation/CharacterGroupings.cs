using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Collation
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class CharacterGroupings : ICharacterGroupings, IVectorView<CharacterGrouping>, IIterable<CharacterGrouping>
	{
		public extern uint Size
		{
			get;
		}
		public extern CharacterGroupings();
		public extern string Lookup([In] string text);
		public extern CharacterGrouping GetAt([In] uint index);
		public extern bool IndexOf([In] CharacterGrouping value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] CharacterGrouping[] items);
		public extern IIterator<CharacterGrouping> First();
	}
}
