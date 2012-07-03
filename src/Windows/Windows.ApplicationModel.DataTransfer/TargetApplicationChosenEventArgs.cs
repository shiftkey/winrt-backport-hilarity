using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class TargetApplicationChosenEventArgs : ITargetApplicationChosenEventArgs
	{
		public extern string ApplicationName
		{
			get;
		}
	}
}
