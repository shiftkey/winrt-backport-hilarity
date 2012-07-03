using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreCursor)), Guid(2525575887u, 4381, 17452, 138, 119, 184, 121, 146, 248, 226, 214), Version(100794368u), WebHostHidden]
	internal interface ICoreCursor
	{
		uint Id
		{
			get;
		}
		CoreCursorType Type
		{
			get;
		}
	}
}
