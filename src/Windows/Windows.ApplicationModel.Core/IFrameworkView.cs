using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.ApplicationModel.Core
{
	[Guid(4205534416u, 35108, 17836, 173, 15, 160, 143, 174, 93, 3, 36), Version(100794368u), WebHostHidden]
	public interface IFrameworkView
	{
		void Initialize([In] CoreApplicationView applicationView);
		void SetWindow([In] CoreWindow window);
		void Load([In] string entryPoint);
		void Run();
		void Uninitialize();
	}
}
