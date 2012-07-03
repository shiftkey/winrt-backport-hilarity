using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPasswordBoxStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PasswordBox : Control, IPasswordBox
	{
		public extern event ContextMenuOpeningEventHandler ContextMenuOpening
		{
			add;
			remove;
		}
		public extern event RoutedEventHandler PasswordChanged
		{
			add;
			remove;
		}
		public extern bool IsPasswordRevealButtonEnabled
		{
			get;
			set;
		}
		public extern int MaxLength
		{
			get;
			set;
		}
		public extern string Password
		{
			get;
			set;
		}
		public extern string PasswordChar
		{
			get;
			set;
		}
		public static extern DependencyProperty IsPasswordRevealButtonEnabledProperty
		{
			get;
		}
		public static extern DependencyProperty MaxLengthProperty
		{
			get;
		}
		public static extern DependencyProperty PasswordCharProperty
		{
			get;
		}
		public static extern DependencyProperty PasswordProperty
		{
			get;
		}
		public extern PasswordBox();
		public extern void SelectAll();
	}
}
