// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMessageEntityMentionName : TLMessageEntityBase 
	{
		public TLInputUserBase UserId { get; set; }

		public TLInputMessageEntityMentionName() { }
		public TLInputMessageEntityMentionName(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMessageEntityMentionName; } }

		public override void Read(TLBinaryReader from)
		{
			Offset = from.ReadInt32();
			Length = from.ReadInt32();
			UserId = TLFactory.Read<TLInputUserBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x208E68C9);
			to.Write(Offset);
			to.Write(Length);
			to.WriteObject(UserId);
		}
	}
}