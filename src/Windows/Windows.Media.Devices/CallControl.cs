using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ICallControlStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class CallControl : ICallControl
	{
		public extern event CallControlEventHandler AnswerRequested
		{
			add;
			remove;
		}
		public extern event CallControlEventHandler AudioTransferRequested
		{
			add;
			remove;
		}
		public extern event DialRequestedEventHandler DialRequested
		{
			add;
			remove;
		}
		public extern event CallControlEventHandler HangUpRequested
		{
			add;
			remove;
		}
		public extern event KeypadPressedEventHandler KeypadPressed
		{
			add;
			remove;
		}
		public extern event RedialRequestedEventHandler RedialRequested
		{
			add;
			remove;
		}
		public extern bool HasRinger
		{
			get;
		}
		public extern ulong IndicateNewIncomingCall([In] bool enableRinger, [In] string callerId);
		public extern ulong IndicateNewOutgoingCall();
		public extern void IndicateActiveCall([In] ulong callToken);
		public extern void EndCall([In] ulong callToken);
		public static extern CallControl GetDefault();
		public static extern CallControl FromId([In] string deviceInterfaceId);
	}
}
