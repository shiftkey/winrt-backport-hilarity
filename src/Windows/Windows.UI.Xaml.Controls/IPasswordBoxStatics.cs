using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(PasswordBox)), Guid(1592161635u, 11636, 19150, 189, 121, 252, 171, 97, 167, 215, 123), Version(100794368u), WebHostHidden]
	internal interface IPasswordBoxStatics
	{
		DependencyProperty IsPasswordRevealButtonEnabledProperty
		{
			get;
		}
		DependencyProperty MaxLengthProperty
		{
			get;
		}
		DependencyProperty PasswordCharProperty
		{
			get;
		}
		DependencyProperty PasswordProperty
		{
			get;
		}
	}
}
