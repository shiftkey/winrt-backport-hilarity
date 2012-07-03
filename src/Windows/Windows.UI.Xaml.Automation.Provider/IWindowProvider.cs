using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Provider
{
	[Guid(464161597u, 14543, 16730, 133, 211, 32, 228, 58, 14, 193, 177), Version(100794368u), WebHostHidden]
	public interface IWindowProvider
	{
		WindowInteractionState InteractionState
		{
			get;
		}
		bool IsModal
		{
			get;
		}
		bool IsTopmost
		{
			get;
		}
		bool Maximizable
		{
			get;
		}
		bool Minimizable
		{
			get;
		}
		WindowVisualState VisualState
		{
			get;
		}
		void Close();
		void SetVisualState([In] WindowVisualState state);
		bool WaitForInputIdle([In] int milliseconds);
	}
}
