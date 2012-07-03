using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(IGroupStyleSelectorFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class GroupStyleSelector : IGroupStyleSelector, IGroupStyleSelectorOverrides
	{
		public extern GroupStyleSelector();
		public extern GroupStyle SelectGroupStyle([In] object group, [In] uint level);
		protected virtual extern GroupStyle SelectGroupStyleCore([In] object group, [In] uint level);
	}
}
