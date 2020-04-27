using RoR2;
using RoR2.Orbs;
using UnityEngine;

namespace WispDeathBonus
{
	public class WispBoostOrb : Orb
	{
		private CharacterBody targetBody;
		private Inventory targetInventory;
		private HealthComponent targetHealth;
		private TeamIndex targetTeam;
		private TeamManager targetTeamManager;
		public int bonusType;
		public int affixType = 0;

		public override void Begin()
		{
			duration = distanceToTarget / 30f;
			EffectData effectData = new EffectData
			{
				origin = origin,
				genericFloat = duration
			};
			effectData.SetHurtBoxReference(target);
			EffectManager.SpawnEffect(Resources.Load<GameObject>("Prefabs/Effects/OrbEffects/DevilOrbEffect"), effectData, true);
			targetBody = target.healthComponent.body;
			targetTeam = target.teamIndex;
			targetTeamManager = new TeamManager();
			if (targetBody)
			{
				targetInventory = targetBody.inventory;
				targetHealth = targetBody.healthComponent;
			}
		}

		public override void OnArrival()
		{
			switch (bonusType)
			{
				case 1:
					targetInventory.GiveItem(Items.DamageBoostIndex);
					break;
				case 2:
					targetInventory.GiveItem(Items.HealthBoostIndex);
					break;
				case 3:
					targetHealth.HealFraction(ConfigHandler.HealingValue * 0.01f, new ProcChainMask());
					break;
				case 4:
					ulong exp = (targetTeamManager.GetTeamNextLevelExperience(targetTeam) - targetTeamManager.GetTeamCurrentLevelExperience(targetTeam)) * (ulong)(ConfigHandler.ExpValue * 0.01f);
					targetTeamManager.GiveTeamExperience(targetTeam, exp);
					break;
				case 5: //Affix

					break;
				case 6:
					targetInventory.GiveItem(Items.SpeedBoostIndex);
					break;
				case 7:
					targetInventory.GiveItem(Items.DexBoostIndex);
					break;
				case 8:
					targetInventory.GiveItem(Items.ArmorBoostIndex);
					break;
			}
			targetBody.RecalculateStats();
		}
	}
}
