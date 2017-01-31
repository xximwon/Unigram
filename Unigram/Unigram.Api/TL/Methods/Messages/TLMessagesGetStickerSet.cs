// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getStickerSet
	/// </summary>
	public partial class TLMessagesGetStickerSet : TLObject
	{
		public TLInputStickerSetBase Stickerset { get; set; }

		public TLMessagesGetStickerSet() { }
		public TLMessagesGetStickerSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetStickerSet; } }

		public override void Read(TLBinaryReader from)
		{
			Stickerset = TLFactory.Read<TLInputStickerSetBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2619A90E);
			to.WriteObject(Stickerset);
		}
	}
}