using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(DebugSettings)), Guid(1027940248u, 50855, 19735, 131, 152, 216, 58, 6, 113, 131, 216), Version(100794368u), WebHostHidden]
	internal interface IDebugSettings
	{
		event BindingFailedEventHandler BindingFailed;
		bool EnableFrameRateCounter
		{
			get;
			set;
		}
		bool IsBindingTracingEnabled
		{
			get;
			set;
		}
		bool IsOverdrawHeatMapEnabled
		{
			get;
			set;
		}
	}
}
