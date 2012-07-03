using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class InputEnabledEventArgs : IInputEnabledEventArgs, ICoreWindowEventArgs
	{
		public extern bool InputEnabled
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
