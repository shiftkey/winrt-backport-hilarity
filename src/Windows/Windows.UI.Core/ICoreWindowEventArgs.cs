using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Guid(657137395u, 50739, 19877, 162, 108, 198, 208, 245, 107, 41, 218), Version(100794368u), WebHostHidden]
	public interface ICoreWindowEventArgs
	{
		bool Handled
		{
			get;
			set;
		}
	}
}
