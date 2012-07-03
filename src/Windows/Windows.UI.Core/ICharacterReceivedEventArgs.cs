using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CharacterReceivedEventArgs)), Guid(3313788319u, 39346, 19404, 189, 51, 4, 230, 63, 66, 144, 46), Version(100794368u), WebHostHidden]
	internal interface ICharacterReceivedEventArgs : ICoreWindowEventArgs
	{
		uint KeyCode
		{
			get;
		}
		CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
	}
}
