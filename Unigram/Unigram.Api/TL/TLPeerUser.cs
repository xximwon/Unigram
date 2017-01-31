// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPeerUser : TLPeerBase 
	{
		public Int32 UserId { get; set; }

		public TLPeerUser() { }
		public TLPeerUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PeerUser; } }

		public override void Read(TLBinaryReader from)
		{
			UserId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9DB1BC6D);
			to.Write(UserId);
		}
	}
}