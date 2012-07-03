using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Markup
{
	[Guid(4135127431u, 59109, 18418, 146, 198, 236, 204, 228, 186, 21, 154), Version(100794368u), WebHostHidden]
	public interface IComponentConnector
	{
		void Connect([In] int connectionId, [In] object target);
	}
}
