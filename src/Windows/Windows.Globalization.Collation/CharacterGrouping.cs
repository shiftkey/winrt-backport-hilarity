using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Collation
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class CharacterGrouping : ICharacterGrouping
	{
		public extern string First
		{
			get;
		}
		public extern string Label
		{
			get;
		}
	}
}
