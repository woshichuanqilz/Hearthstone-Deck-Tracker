﻿using System.Collections.Generic;
using System.Linq;

namespace Hearthstone_Deck_Tracker.Hearthstone.RelatedCardsSystem.Cards.Mage;

public class Rewind: ICardWithRelatedCards
{
	public string GetCardId() => HearthDb.CardIds.Collectible.Mage.Rewind;

	public bool ShouldShowForOpponent(Player opponent)
	{
		var card = Database.GetCardFromId(GetCardId());
		return CardUtils.MayCardBeRelevant(card, Core.Game.CurrentFormat, opponent.Class) && GetRelatedCards(opponent).Count > 1;
	}

	public List<Card?> GetRelatedCards(Player player) =>
		player.SpellsPlayedCards
			.Select(entity => Database.GetCardFromId(entity.CardId))
			.Distinct()
			.Where(card => card != null && card.Id != HearthDb.CardIds.Collectible.Mage.Rewind)
			.OrderByDescending(card => card!.Cost)
			.ToList();
}
