// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.uninstallStickerSet
	/// </summary>
	public partial class TLMessagesUninstallStickerSet : TLObject
	{
		public TLInputStickerSetBase Stickerset { get; set; }

		public TLMessagesUninstallStickerSet() { }
		public TLMessagesUninstallStickerSet(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesUninstallStickerSet; } }

		public override void Read(TLBinaryReader from)
		{
			Stickerset = TLFactory.Read<TLInputStickerSetBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF96E55DE);
			to.WriteObject(Stickerset);
		}
	}
}