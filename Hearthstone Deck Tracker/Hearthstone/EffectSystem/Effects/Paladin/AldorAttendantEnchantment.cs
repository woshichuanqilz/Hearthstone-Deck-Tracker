﻿using Hearthstone_Deck_Tracker.Hearthstone.EffectSystem.Enums;

namespace Hearthstone_Deck_Tracker.Hearthstone.EffectSystem.Effects.Paladin;

public class AldorAttendantEnchantment : EntityBasedEffect
{
	public override string CardId => HearthDb.CardIds.NonCollectible.Neutral.AldorAttendant_AldorAttendantEnchantment;
	protected override string CardIdToShowInUI => HearthDb.CardIds.Collectible.Paladin.AldorAttendant;

	public AldorAttendantEnchantment(int entityId, bool isControlledByPlayer) : base(entityId, isControlledByPlayer)
	{
	}

	public override EffectDuration EffectDuration => EffectDuration.Permanent;
	public override EffectTag EffectTag => EffectTag.CostModification;
}
