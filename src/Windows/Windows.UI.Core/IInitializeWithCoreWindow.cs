using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[Guid(412033238u, 39027, 17994, 172, 229, 87, 224, 16, 244, 101, 230), Version(100794368u), WebHostHidden]
	public interface IInitializeWithCoreWindow
	{
		void Initialize([In] CoreWindow window);
	}
}
