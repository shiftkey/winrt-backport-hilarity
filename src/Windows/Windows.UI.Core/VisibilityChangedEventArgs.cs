using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class VisibilityChangedEventArgs : IVisibilityChangedEventArgs, ICoreWindowEventArgs
	{
		public extern bool Visible
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
