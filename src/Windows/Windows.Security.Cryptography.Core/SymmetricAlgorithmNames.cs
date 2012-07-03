using System;
using Windows.Foundation.Metadata;
namespace Windows.Security.Cryptography.Core
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISymmetricAlgorithmNamesStatics), 100794368u), Version(100794368u)]
	public static class SymmetricAlgorithmNames
	{
		public static extern string AesCbc
		{
			get;
		}
		public static extern string AesCbcPkcs7
		{
			get;
		}
		public static extern string AesCcm
		{
			get;
		}
		public static extern string AesEcb
		{
			get;
		}
		public static extern string AesEcbPkcs7
		{
			get;
		}
		public static extern string AesGcm
		{
			get;
		}
		public static extern string DesCbc
		{
			get;
		}
		public static extern string DesCbcPkcs7
		{
			get;
		}
		public static extern string DesEcb
		{
			get;
		}
		public static extern string DesEcbPkcs7
		{
			get;
		}
		public static extern string Rc2Cbc
		{
			get;
		}
		public static extern string Rc2CbcPkcs7
		{
			get;
		}
		public static extern string Rc2Ecb
		{
			get;
		}
		public static extern string Rc2EcbPkcs7
		{
			get;
		}
		public static extern string Rc4
		{
			get;
		}
		public static extern string TripleDesCbc
		{
			get;
		}
		public static extern string TripleDesCbcPkcs7
		{
			get;
		}
		public static extern string TripleDesEcb
		{
			get;
		}
		public static extern string TripleDesEcbPkcs7
		{
			get;
		}
	}
}
