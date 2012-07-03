using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IAppBarFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IAppBarStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class AppBar : ContentControl, IAppBar, IAppBarOverrides
	{
		public extern event EventHandler<object> Closed
		{
			add;
			remove;
		}
		public extern event EventHandler<object> Opened
		{
			add;
			remove;
		}
		public extern bool IsOpen
		{
			get;
			set;
		}
		public extern bool IsSticky
		{
			get;
			set;
		}
		public static extern DependencyProperty IsOpenProperty
		{
			get;
		}
		public static extern DependencyProperty IsStickyProperty
		{
			get;
		}
		public extern AppBar();
		protected virtual extern void OnClosed([In] object e);
		protected virtual extern void OnOpened([In] object e);
	}
}
