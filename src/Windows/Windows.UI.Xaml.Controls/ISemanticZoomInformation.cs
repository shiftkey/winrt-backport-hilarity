using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Guid(2808757091u, 8859, 19909, 170, 17, 157, 146, 47, 191, 138, 152), Version(100794368u), WebHostHidden]
	public interface ISemanticZoomInformation
	{
		bool IsActiveView
		{
			get;
			set;
		}
		bool IsZoomedInView
		{
			get;
			set;
		}
		SemanticZoom SemanticZoomOwner
		{
			get;
			set;
		}
		void InitializeViewChange();
		void CompleteViewChange();
		void MakeVisible([In] SemanticZoomLocation item);
		void StartViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		void StartViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		void CompleteViewChangeFrom([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
		void CompleteViewChangeTo([In] SemanticZoomLocation source, [In] SemanticZoomLocation destination);
	}
}
