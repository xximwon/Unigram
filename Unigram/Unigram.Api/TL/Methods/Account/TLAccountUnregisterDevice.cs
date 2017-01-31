// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.unregisterDevice
	/// </summary>
	public partial class TLAccountUnregisterDevice : TLObject
	{
		public Int32 TokenType { get; set; }
		public String Token { get; set; }

		public TLAccountUnregisterDevice() { }
		public TLAccountUnregisterDevice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountUnregisterDevice; } }

		public override void Read(TLBinaryReader from)
		{
			TokenType = from.ReadInt32();
			Token = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x65C55B40);
			to.Write(TokenType);
			to.Write(Token);
		}
	}
}