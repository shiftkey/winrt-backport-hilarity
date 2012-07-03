using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class CharacterReceivedEventArgs : ICharacterReceivedEventArgs, ICoreWindowEventArgs
	{
		public extern uint KeyCode
		{
			get;
		}
		public extern CorePhysicalKeyStatus KeyStatus
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
