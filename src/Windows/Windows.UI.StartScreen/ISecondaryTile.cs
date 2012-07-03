using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.StartScreen
{
	[ExclusiveTo(typeof(SecondaryTile)), Guid(2661175776u, 11189, 19392, 187, 141, 66, 178, 58, 188, 200, 141), Version(100794368u)]
	internal interface ISecondaryTile
	{
		string Arguments
		{
			get;
			set;
		}
		Color BackgroundColor
		{
			get;
			set;
		}
		string DisplayName
		{
			get;
			set;
		}
		ForegroundText ForegroundText
		{
			get;
			set;
		}
		Uri LockScreenBadgeLogo
		{
			get;
			set;
		}
		bool LockScreenDisplayBadgeAndTileText
		{
			get;
			set;
		}
		Uri Logo
		{
			get;
			set;
		}
		string ShortName
		{
			get;
			set;
		}
		Uri SmallLogo
		{
			get;
			set;
		}
		string TileId
		{
			get;
			set;
		}
		TileOptions TileOptions
		{
			get;
			set;
		}
		Uri WideLogo
		{
			get;
			set;
		}
		[DefaultOverload, Overload("RequestCreateAsync")]
		IAsyncOperation<bool> RequestCreateAsync();
		[DefaultOverload, Overload("RequestCreateAsyncWithPoint")]
		IAsyncOperation<bool> RequestCreateAsync([In] Point invocationPoint);
		[DefaultOverload, Overload("RequestCreateAsyncWithRect")]
		IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection);
		[DefaultOverload, Overload("RequestCreateAsyncWithRectAndPlacement")]
		IAsyncOperation<bool> RequestCreateForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
		[DefaultOverload, Overload("RequestDeleteAsync")]
		IAsyncOperation<bool> RequestDeleteAsync();
		[DefaultOverload, Overload("RequestDeleteAsyncWithPoint")]
		IAsyncOperation<bool> RequestDeleteAsync([In] Point invocationPoint);
		[DefaultOverload, Overload("RequestDeleteAsyncWithRect")]
		IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection);
		[DefaultOverload, Overload("RequestDeleteAsyncWithRectAndPlacement")]
		IAsyncOperation<bool> RequestDeleteForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
		IAsyncOperation<bool> UpdateAsync();
	}
}
