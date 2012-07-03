using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(InputEnabledEventArgs)), Guid(2151095631u, 12248, 19492, 170, 134, 49, 99, 168, 123, 78, 90), Version(100794368u), WebHostHidden]
	internal interface IInputEnabledEventArgs : ICoreWindowEventArgs
	{
		bool InputEnabled
		{
			get;
		}
	}
}
