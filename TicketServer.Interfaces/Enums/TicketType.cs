﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TicketServer.Interfaces.Enums
{
	/// <summary>
	/// Defines the type of the card.
	/// </summary>
	public enum TicketType
	{
		/// <summary>
		/// A free card (lucky drawings or sponsors)
		/// </summary>
		Free,
		/// <summary>
		/// A normal/paid card.
		/// </summary>
		Normal,
		/// <summary>
		/// A special card type.
		/// </summary>
		Special
	}
}