// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.deleteContacts
	/// </summary>
	public partial class TLContactsDeleteContacts : TLObject
	{
		public TLVector<TLInputUserBase> Id { get; set; }

		public TLContactsDeleteContacts() { }
		public TLContactsDeleteContacts(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsDeleteContacts; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLVector<TLInputUserBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x59AB389E);
			to.WriteObject(Id);
		}
	}
}