using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Core
{
	[Guid(3447129620u, 26052, 17004, 148, 148, 52, 252, 67, 85, 72, 98), Version(100794368u), WebHostHidden]
	public interface IFrameworkViewSource
	{
		IFrameworkView CreateView();
	}
}
