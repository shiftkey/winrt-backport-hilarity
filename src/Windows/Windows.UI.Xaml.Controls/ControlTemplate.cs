using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ControlTemplate : FrameworkTemplate, IControlTemplate
	{
		public extern TypeName TargetType
		{
			get;
			set;
		}
		public extern ControlTemplate();
	}
}
