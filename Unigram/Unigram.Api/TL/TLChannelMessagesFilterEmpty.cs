// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelMessagesFilterEmpty : TLChannelMessagesFilterBase 
	{
		public TLChannelMessagesFilterEmpty() { }
		public TLChannelMessagesFilterEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelMessagesFilterEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x94D42EE7);
		}
	}
}