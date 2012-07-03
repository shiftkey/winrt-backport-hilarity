using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Security.Credentials
{
	[ExclusiveTo(typeof(PasswordCredential)), Guid(1790019977u, 50976, 16807, 166, 193, 254, 173, 179, 99, 41, 160), Version(100794368u)]
	internal interface IPasswordCredential
	{
		string Password
		{
			get;
			set;
		}
		IPropertySet Properties
		{
			get;
		}
		string Resource
		{
			get;
			set;
		}
		string UserName
		{
			get;
			set;
		}
		void RetrievePassword();
	}
}
