// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageGamePlayAction : TLSendMessageActionBase 
	{
		public TLSendMessageGamePlayAction() { }
		public TLSendMessageGamePlayAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageGamePlayAction; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDD6A8F48);
		}
	}
}