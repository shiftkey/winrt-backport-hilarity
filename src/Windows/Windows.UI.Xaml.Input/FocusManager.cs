using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFocusManagerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class FocusManager : IFocusManager
	{
		public static extern object GetFocusedElement();
	}
}
