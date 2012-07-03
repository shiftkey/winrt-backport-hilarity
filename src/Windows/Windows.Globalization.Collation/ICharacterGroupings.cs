using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Collation
{
	[ExclusiveTo(typeof(CharacterGroupings)), Guid(3100772981u, 54479, 16469, 128, 229, 206, 22, 156, 34, 100, 150), Version(100794368u)]
	internal interface ICharacterGroupings : IVectorView<CharacterGrouping>, IIterable<CharacterGrouping>
	{
		string Lookup([In] string text);
	}
}
