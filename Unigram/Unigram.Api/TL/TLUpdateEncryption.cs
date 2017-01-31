// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEncryption : TLUpdateBase 
	{
		public TLEncryptedChatBase Chat { get; set; }
		public Int32 Date { get; set; }

		public TLUpdateEncryption() { }
		public TLUpdateEncryption(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateEncryption; } }

		public override void Read(TLBinaryReader from)
		{
			Chat = TLFactory.Read<TLEncryptedChatBase>(from);
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB4A2E88D);
			to.WriteObject(Chat);
			to.Write(Date);
		}
	}
}