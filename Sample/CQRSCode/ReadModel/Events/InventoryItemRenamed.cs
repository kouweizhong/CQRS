﻿using System;
using Cqrs.Events;
using Cqrs.Authentication;

namespace CQRSCode.ReadModel.Events
{
	public class InventoryItemRenamed : IEvent<ISingleSignOnToken>
	{
		public readonly string NewName;
 
		public InventoryItemRenamed(Guid id, string newName)
		{
			Id = id;
			NewName = newName;
		}

		public Guid Id { get; set; }

		public int Version { get; set; }

		public DateTimeOffset TimeStamp { get; set; }

		#region Implementation of IMessageWithAuthenticationToken<ISingleSignOnToken>

		public ISingleSignOnToken AuthenticationToken { get; set; }

		#endregion

		#region Implementation of IMessage

		public Guid CorrelationId { get; set; }

		[Obsolete("Use CorrelationId")]
		public Guid CorrolationId
		{
			get { return CorrelationId; }
			set { CorrelationId = value; }
		}

		#endregion
	}
}