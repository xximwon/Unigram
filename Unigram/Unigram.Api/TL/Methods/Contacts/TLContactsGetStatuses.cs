// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.getStatuses
	/// </summary>
	public partial class TLContactsGetStatuses : TLObject
	{
		public TLContactsGetStatuses() { }
		public TLContactsGetStatuses(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsGetStatuses; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC4A353EE);
		}
	}
}