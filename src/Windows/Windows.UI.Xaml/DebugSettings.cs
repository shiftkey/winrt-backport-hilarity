using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DebugSettings : IDebugSettings
	{
		public extern event BindingFailedEventHandler BindingFailed
		{
			add;
			remove;
		}
		public extern bool EnableFrameRateCounter
		{
			get;
			set;
		}
		public extern bool IsBindingTracingEnabled
		{
			get;
			set;
		}
		public extern bool IsOverdrawHeatMapEnabled
		{
			get;
			set;
		}
	}
}
