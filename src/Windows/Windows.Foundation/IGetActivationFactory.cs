using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(1323011810u, 38621, 18855, 148, 247, 70, 7, 221, 171, 142, 60), Version(100794368u), WebHostHidden]
	public interface IGetActivationFactory
	{
		object GetActivationFactory([In] string activatableClassId);
	}
}
