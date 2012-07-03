using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Activatable(typeof(ICoreCursorFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u), WebHostHidden]
	public sealed class CoreCursor : ICoreCursor
	{
		public extern uint Id
		{
			get;
		}
		public extern CoreCursorType Type
		{
			get;
		}
		public extern CoreCursor([In] CoreCursorType type, [In] uint id);
	}
}
