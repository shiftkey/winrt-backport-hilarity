using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IProgressRingStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ProgressRing : Control, IProgressRing
	{
		public extern bool IsActive
		{
			get;
			set;
		}
		public extern ProgressRingTemplateSettings TemplateSettings
		{
			get;
		}
		public static extern DependencyProperty IsActiveProperty
		{
			get;
		}
		public extern ProgressRing();
	}
}
