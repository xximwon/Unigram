// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesStickerSetInstallResultSuccess : TLMessagesStickerSetInstallResultBase 
	{
		public TLMessagesStickerSetInstallResultSuccess() { }
		public TLMessagesStickerSetInstallResultSuccess(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesStickerSetInstallResultSuccess; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x38641628);
		}
	}
}