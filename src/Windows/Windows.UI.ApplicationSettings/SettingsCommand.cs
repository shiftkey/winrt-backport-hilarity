using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.ApplicationSettings
{
	[Activatable(typeof(ISettingsCommandFactory), 100794368u), MarshalingBehavior(MarshalingType.None), Version(100794368u)]
	public sealed class SettingsCommand : IUICommand
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
		public extern SettingsCommand([Variant] [In] object settingsCommandId, [In] string label, [In] UICommandInvokedHandler handler);
	}
}
