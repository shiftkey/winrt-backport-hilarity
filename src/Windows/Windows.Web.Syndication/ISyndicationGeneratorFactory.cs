using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationGenerator)), Guid(2738914275u, 7718, 19900, 186, 157, 26, 184, 75, 239, 249, 123), Version(100794368u)]
	internal interface ISyndicationGeneratorFactory
	{
		SyndicationGenerator CreateSyndicationGenerator([In] string text);
	}
}
