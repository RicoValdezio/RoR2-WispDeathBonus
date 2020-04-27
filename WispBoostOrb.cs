using RoR2;
using RoR2.Orbs;
using System.Reflection;
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
			try
			{
				switch (bonusType)
				{
					case 1:
						targetInventory.GiveItem(Items.DamageBoostIndex);
						targetBody.baseDamage *= (ConfigHandler.DamageValue * 0.01f) + 1f;
						break;
					case 2:
						targetInventory.GiveItem(Items.HealthBoostIndex);
						targetBody.baseMaxHealth *= (ConfigHandler.HealthValue * 0.01f) + 1f;
						break;
					case 3:
						targetHealth.HealFraction(ConfigHandler.HealingValue * 0.01f, new ProcChainMask());
						break;
					case 4:
						ulong exp = (targetTeamManager.GetTeamNextLevelExperience(targetTeam) - targetTeamManager.GetTeamCurrentLevelExperience(targetTeam)) * (ulong)(ConfigHandler.ExpValue * 0.01f);
						targetTeamManager.GiveTeamExperience(targetTeam, exp);
						break;
					case 5:
						switch (affixType)
						{
							case 0: //Nothing
								break;
							case 1: //Blue
								if (targetTeam == TeamIndex.Player && ConfigHandler.AffixOverride)
								{
									targetInventory.SetEquipmentIndex(EquipmentIndex.AffixBlue);
								}
								else
								{
									targetBody.AddBuff(BuffIndex.AffixBlue);
								}
								break;
							case 2: //Red
								if (targetTeam == TeamIndex.Player && ConfigHandler.AffixOverride)
								{
									targetInventory.SetEquipmentIndex(EquipmentIndex.AffixRed);
								}
								else
								{
									targetBody.AddBuff(BuffIndex.AffixRed);
								}
								break;
							case 3: //White
								if (targetTeam == TeamIndex.Player && ConfigHandler.AffixOverride)
								{
									targetInventory.SetEquipmentIndex(EquipmentIndex.AffixWhite);
								}
								else
								{
									targetBody.AddBuff(BuffIndex.AffixWhite);
								}
								break;
							case 4: //Ghost
								if (targetTeam == TeamIndex.Player && ConfigHandler.AffixOverride)
								{
									targetInventory.SetEquipmentIndex(EquipmentIndex.AffixHaunted);
								}
								else
								{
									targetBody.AddBuff(BuffIndex.AffixHaunted);
								}
								break;
							case 5: //Poison
								if (targetTeam == TeamIndex.Player && ConfigHandler.AffixOverride)
								{
									targetInventory.SetEquipmentIndex(EquipmentIndex.AffixPoison);
								}
								else
								{
									targetBody.AddBuff(BuffIndex.AffixPoison);
								}
								break;
						}
						break;
					case 6:
						targetInventory.GiveItem(Items.SpeedBoostIndex);
						targetBody.baseMoveSpeed *= (ConfigHandler.SpeedValue * 0.01f) + 1f;
						break;
					case 7:
						targetInventory.GiveItem(Items.DexBoostIndex);
						targetBody.baseAttackSpeed *= (ConfigHandler.DexValue * 0.01f) + 1f;
						break;
					case 8:
						targetInventory.GiveItem(Items.ArmorBoostIndex);
						targetBody.baseArmor *= (ConfigHandler.ArmorValue * 0.01f) + 1f;
						break;
				}
				targetBody.RecalculateStats();
			}
			catch { }
		}
	}
}
