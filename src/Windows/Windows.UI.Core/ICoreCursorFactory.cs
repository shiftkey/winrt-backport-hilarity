using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreCursor)), Guid(4130706977u, 42909, 20179, 140, 50, 169, 239, 157, 107, 118, 164), Version(100794368u), WebHostHidden]
	internal interface ICoreCursorFactory
	{
		CoreCursor CreateCursor([In] CoreCursorType type, [In] uint id);
	}
}
