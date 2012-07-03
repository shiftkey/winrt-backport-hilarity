using System;
using System.Runtime.InteropServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationFeed)), Guid(2147368146u, 23398, 19810, 132, 3, 27, 193, 13, 145, 13, 107), Version(100794368u)]
	internal interface ISyndicationFeed : ISyndicationNode
	{
		IVector<SyndicationPerson> Authors
		{
			get;
		}
		IVector<SyndicationCategory> Categories
		{
			get;
		}
		IVector<SyndicationPerson> Contributors
		{
			get;
		}
		Uri FirstUri
		{
			get;
		}
		SyndicationGenerator Generator
		{
			get;
			set;
		}
		Uri IconUri
		{
			get;
			set;
		}
		string Id
		{
			get;
			set;
		}
		Uri ImageUri
		{
			get;
			set;
		}
		IVector<SyndicationItem> Items
		{
			get;
		}
		DateTime LastUpdatedTime
		{
			get;
			set;
		}
		Uri LastUri
		{
			get;
		}
		IVector<SyndicationLink> Links
		{
			get;
		}
		Uri NextUri
		{
			get;
		}
		Uri PreviousUri
		{
			get;
		}
		ISyndicationText Rights
		{
			get;
			set;
		}
		SyndicationFormat SourceFormat
		{
			get;
		}
		ISyndicationText Subtitle
		{
			get;
			set;
		}
		ISyndicationText Title
		{
			get;
			set;
		}
		void Load([In] string feed);
		void LoadFromXml([In] XmlDocument feedDocument);
	}
}
