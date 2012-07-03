using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(OperationCompletedEventArgs)), Guid(3887018653u, 1309, 20395, 177, 169, 71, 253, 119, 247, 10, 65), Version(100794368u)]
	internal interface IOperationCompletedEventArgs
	{
		DataPackageOperation Operation
		{
			get;
		}
	}
}
