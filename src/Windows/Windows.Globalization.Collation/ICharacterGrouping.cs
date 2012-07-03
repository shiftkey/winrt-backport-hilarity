using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Collation
{
	[ExclusiveTo(typeof(CharacterGrouping)), Guid(4209467835u, 32861, 19376, 149, 187, 193, 247, 195, 232, 235, 142), Version(100794368u)]
	internal interface ICharacterGrouping
	{
		string First
		{
			get;
		}
		string Label
		{
			get;
		}
	}
}
