using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class UICommandSeparator : IUICommand
	{
		public extern object Id
		{
			[return: Variant]
			get;
			[param: Variant]
			set;
		}
		public extern UICommandInvokedHandler Invoked
		{
			get;
			set;
		}
		public extern string Label
		{
			get;
			set;
		}
		public extern UICommandSeparator();
	}
}
