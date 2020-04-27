using RoR2;
using RoR2.Orbs;
using UnityEngine;

namespace WispDeathBonus
{
	public class WispBoostOrb : Orb
	{
		private Inventory targetInventory;
		public int bonusType;

		public override void Begin()
		{
			duration = distanceToTarget / 30f;
			EffectData effectData = new EffectData
			{
				origin = origin,
				genericFloat = duration,
				color = Color.white
			};
			effectData.SetHurtBoxReference(target);
			EffectManager.SpawnEffect(Resources.Load<GameObject>("Prefabs/Effects/OrbEffects/InfusionOrbEffect"), effectData, true);
			CharacterBody targetBody = target.healthComponent.body;
			if (targetBody)
			{
				targetInventory = targetBody.inventory;
			}
		}

		public override void OnArrival()
		{
			if (targetInventory)
			{
				//Add the bonus of type whatever
			}
		}
	}
}
