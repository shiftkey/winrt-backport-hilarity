using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Media.Devices
{
	[ExclusiveTo(typeof(CallControl)), Guid(2770391254u, 44685, 17883, 128, 17, 202, 73, 211, 179, 229, 120), Version(100794368u)]
	internal interface ICallControl
	{
		event CallControlEventHandler AnswerRequested;
		event CallControlEventHandler AudioTransferRequested;
		event DialRequestedEventHandler DialRequested;
		event CallControlEventHandler HangUpRequested;
		event KeypadPressedEventHandler KeypadPressed;
		event RedialRequestedEventHandler RedialRequested;
		bool HasRinger
		{
			get;
		}
		ulong IndicateNewIncomingCall([In] bool enableRinger, [In] string callerId);
		ulong IndicateNewOutgoingCall();
		void IndicateActiveCall([In] ulong callToken);
		void EndCall([In] ulong callToken);
	}
}
