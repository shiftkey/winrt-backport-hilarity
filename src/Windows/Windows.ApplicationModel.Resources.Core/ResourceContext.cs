using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IResourceContextStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class ResourceContext : IResourceContext
	{
		public extern IVectorView<string> Languages
		{
			get;
			set;
		}
		public extern IObservableMap<string, string> QualifierValues
		{
			get;
		}
		public extern ResourceContext();
		[Overload("Reset")]
		public extern void Reset();
		[Overload("ResetQualifierValues")]
		public extern void Reset([In] IIterable<string> qualifierNames);
		public extern void OverrideToMatch([In] IIterable<ResourceQualifier> result);
		public extern ResourceContext Clone();
		public static extern ResourceContext CreateMatchingContext([In] IIterable<ResourceQualifier> result);
	}
}
