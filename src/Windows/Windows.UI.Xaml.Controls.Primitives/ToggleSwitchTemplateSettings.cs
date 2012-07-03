using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ToggleSwitchTemplateSettings : DependencyObject, IToggleSwitchTemplateSettings
	{
		public extern double CurtainCurrentToOffOffset
		{
			get;
		}
		public extern double CurtainCurrentToOnOffset
		{
			get;
		}
		public extern double CurtainOffToOnOffset
		{
			get;
		}
		public extern double CurtainOnToOffOffset
		{
			get;
		}
		public extern double KnobCurrentToOffOffset
		{
			get;
		}
		public extern double KnobCurrentToOnOffset
		{
			get;
		}
		public extern double KnobOffToOnOffset
		{
			get;
		}
		public extern double KnobOnToOffOffset
		{
			get;
		}
	}
}
