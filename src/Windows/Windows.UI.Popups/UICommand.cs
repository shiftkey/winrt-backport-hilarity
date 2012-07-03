using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Activatable(typeof(IUICommandFactory), 100794368u), Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class UICommand : IUICommand
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
		public extern UICommand([In] string label);
		public extern UICommand([In] string label, [In] UICommandInvokedHandler action);
		public extern UICommand([In] string label, [In] UICommandInvokedHandler action, [Variant] [In] object commandId);
		public extern UICommand();
	}
}
