using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(PasswordBox)), Guid(45722129u, 2887, 20093, 173, 145, 58, 65, 104, 237, 35, 13), Version(100794368u), WebHostHidden]
	internal interface IPasswordBox
	{
		event ContextMenuOpeningEventHandler ContextMenuOpening;
		event RoutedEventHandler PasswordChanged;
		bool IsPasswordRevealButtonEnabled
		{
			get;
			set;
		}
		int MaxLength
		{
			get;
			set;
		}
		string Password
		{
			get;
			set;
		}
		string PasswordChar
		{
			get;
			set;
		}
		void SelectAll();
	}
}
