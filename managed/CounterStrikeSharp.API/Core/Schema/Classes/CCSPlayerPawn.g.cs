// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CCSPlayerPawn : CCSPlayerPawnBase
{
    public CCSPlayerPawn (IntPtr pointer) : base(pointer) {}

	// m_pBulletServices
	[SchemaMember("CCSPlayerPawn", "m_pBulletServices")]
	public CCSPlayer_BulletServices? BulletServices => Schema.GetPointer<CCSPlayer_BulletServices>(this.Handle, "CCSPlayerPawn", "m_pBulletServices");

	// m_pHostageServices
	[SchemaMember("CCSPlayerPawn", "m_pHostageServices")]
	public CCSPlayer_HostageServices? HostageServices => Schema.GetPointer<CCSPlayer_HostageServices>(this.Handle, "CCSPlayerPawn", "m_pHostageServices");

	// m_pBuyServices
	[SchemaMember("CCSPlayerPawn", "m_pBuyServices")]
	public CCSPlayer_BuyServices? BuyServices => Schema.GetPointer<CCSPlayer_BuyServices>(this.Handle, "CCSPlayerPawn", "m_pBuyServices");

	// m_pActionTrackingServices
	[SchemaMember("CCSPlayerPawn", "m_pActionTrackingServices")]
	public CCSPlayer_ActionTrackingServices? ActionTrackingServices => Schema.GetPointer<CCSPlayer_ActionTrackingServices>(this.Handle, "CCSPlayerPawn", "m_pActionTrackingServices");

	// m_pRadioServices
	[SchemaMember("CCSPlayerPawn", "m_pRadioServices")]
	public CCSPlayer_RadioServices? RadioServices => Schema.GetPointer<CCSPlayer_RadioServices>(this.Handle, "CCSPlayerPawn", "m_pRadioServices");

	// m_pDamageReactServices
	[SchemaMember("CCSPlayerPawn", "m_pDamageReactServices")]
	public CCSPlayer_DamageReactServices? DamageReactServices => Schema.GetPointer<CCSPlayer_DamageReactServices>(this.Handle, "CCSPlayerPawn", "m_pDamageReactServices");

	// m_nCharacterDefIndex
	[SchemaMember("CCSPlayerPawn", "m_nCharacterDefIndex")]
	public ref UInt16 CharacterDefIndex => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawn", "m_nCharacterDefIndex");

	// m_bHasFemaleVoice
	[SchemaMember("CCSPlayerPawn", "m_bHasFemaleVoice")]
	public ref bool HasFemaleVoice => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bHasFemaleVoice");

	// m_strVOPrefix
	[SchemaMember("CCSPlayerPawn", "m_strVOPrefix")]
	public string StrVOPrefix
	{
		get { return Schema.GetUtf8String(this.Handle, "CCSPlayerPawn", "m_strVOPrefix"); }
		set { Schema.SetString(this.Handle, "CCSPlayerPawn", "m_strVOPrefix", value); }
	}

	// m_szLastPlaceName
	[SchemaMember("CCSPlayerPawn", "m_szLastPlaceName")]
	public string LastPlaceName
	{
		get { return Schema.GetString(this.Handle, "CCSPlayerPawn", "m_szLastPlaceName"); }
		set { Schema.SetStringBytes(this.Handle, "CCSPlayerPawn", "m_szLastPlaceName", value, 18); }
	}

	// m_bInHostageResetZone
	[SchemaMember("CCSPlayerPawn", "m_bInHostageResetZone")]
	public ref bool InHostageResetZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInHostageResetZone");

	// m_bInBuyZone
	[SchemaMember("CCSPlayerPawn", "m_bInBuyZone")]
	public ref bool InBuyZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInBuyZone");

	// m_TouchingBuyZones
	[SchemaMember("CCSPlayerPawn", "m_TouchingBuyZones")]
	public NetworkedVector<CHandle<CBaseEntity>> TouchingBuyZones => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseEntity>>>(this.Handle, "CCSPlayerPawn", "m_TouchingBuyZones");

	// m_bWasInBuyZone
	[SchemaMember("CCSPlayerPawn", "m_bWasInBuyZone")]
	public ref bool WasInBuyZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bWasInBuyZone");

	// m_bInHostageRescueZone
	[SchemaMember("CCSPlayerPawn", "m_bInHostageRescueZone")]
	public ref bool InHostageRescueZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInHostageRescueZone");

	// m_bInBombZone
	[SchemaMember("CCSPlayerPawn", "m_bInBombZone")]
	public ref bool InBombZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInBombZone");

	// m_bWasInHostageRescueZone
	[SchemaMember("CCSPlayerPawn", "m_bWasInHostageRescueZone")]
	public ref bool WasInHostageRescueZone => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bWasInHostageRescueZone");

	// m_iRetakesOffering
	[SchemaMember("CCSPlayerPawn", "m_iRetakesOffering")]
	public ref Int32 RetakesOffering => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iRetakesOffering");

	// m_iRetakesOfferingCard
	[SchemaMember("CCSPlayerPawn", "m_iRetakesOfferingCard")]
	public ref Int32 RetakesOfferingCard => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iRetakesOfferingCard");

	// m_bRetakesHasDefuseKit
	[SchemaMember("CCSPlayerPawn", "m_bRetakesHasDefuseKit")]
	public ref bool RetakesHasDefuseKit => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bRetakesHasDefuseKit");

	// m_bRetakesMVPLastRound
	[SchemaMember("CCSPlayerPawn", "m_bRetakesMVPLastRound")]
	public ref bool RetakesMVPLastRound => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bRetakesMVPLastRound");

	// m_iRetakesMVPBoostItem
	[SchemaMember("CCSPlayerPawn", "m_iRetakesMVPBoostItem")]
	public ref Int32 RetakesMVPBoostItem => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iRetakesMVPBoostItem");

	// m_RetakesMVPBoostExtraUtility
	[SchemaMember("CCSPlayerPawn", "m_RetakesMVPBoostExtraUtility")]
	public ref loadout_slot_t RetakesMVPBoostExtraUtility => ref Schema.GetRef<loadout_slot_t>(this.Handle, "CCSPlayerPawn", "m_RetakesMVPBoostExtraUtility");

	// m_flHealthShotBoostExpirationTime
	[SchemaMember("CCSPlayerPawn", "m_flHealthShotBoostExpirationTime")]
	public ref float HealthShotBoostExpirationTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flHealthShotBoostExpirationTime");

	// m_flLandingTimeSeconds
	[SchemaMember("CCSPlayerPawn", "m_flLandingTimeSeconds")]
	public ref float LandingTimeSeconds => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flLandingTimeSeconds");

	// m_aimPunchAngle
	[SchemaMember("CCSPlayerPawn", "m_aimPunchAngle")]
	public QAngle AimPunchAngle => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawn", "m_aimPunchAngle");

	// m_aimPunchAngleVel
	[SchemaMember("CCSPlayerPawn", "m_aimPunchAngleVel")]
	public QAngle AimPunchAngleVel => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawn", "m_aimPunchAngleVel");

	// m_aimPunchTickBase
	[SchemaMember("CCSPlayerPawn", "m_aimPunchTickBase")]
	public ref Int32 AimPunchTickBase => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_aimPunchTickBase");

	// m_aimPunchTickFraction
	[SchemaMember("CCSPlayerPawn", "m_aimPunchTickFraction")]
	public ref float AimPunchTickFraction => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_aimPunchTickFraction");

	// m_aimPunchCache
	[SchemaMember("CCSPlayerPawn", "m_aimPunchCache")]
	public NetworkedVector<QAngle> AimPunchCache => Schema.GetDeclaredClass<NetworkedVector<QAngle>>(this.Handle, "CCSPlayerPawn", "m_aimPunchCache");

	// m_bIsBuyMenuOpen
	[SchemaMember("CCSPlayerPawn", "m_bIsBuyMenuOpen")]
	public ref bool IsBuyMenuOpen => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsBuyMenuOpen");

	// m_xLastHeadBoneTransform
	[SchemaMember("CCSPlayerPawn", "m_xLastHeadBoneTransform")]
	public CTransform XLastHeadBoneTransform => Schema.GetDeclaredClass<CTransform>(this.Handle, "CCSPlayerPawn", "m_xLastHeadBoneTransform");

	// m_bLastHeadBoneTransformIsValid
	[SchemaMember("CCSPlayerPawn", "m_bLastHeadBoneTransformIsValid")]
	public ref bool LastHeadBoneTransformIsValid => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bLastHeadBoneTransformIsValid");

	// m_lastLandTime
	[SchemaMember("CCSPlayerPawn", "m_lastLandTime")]
	public ref float LastLandTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_lastLandTime");

	// m_bOnGroundLastTick
	[SchemaMember("CCSPlayerPawn", "m_bOnGroundLastTick")]
	public ref bool OnGroundLastTick => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bOnGroundLastTick");

	// m_iPlayerLocked
	[SchemaMember("CCSPlayerPawn", "m_iPlayerLocked")]
	public ref Int32 PlayerLocked => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iPlayerLocked");

	// m_flTimeOfLastInjury
	[SchemaMember("CCSPlayerPawn", "m_flTimeOfLastInjury")]
	public ref float TimeOfLastInjury => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flTimeOfLastInjury");

	// m_flNextSprayDecalTime
	[SchemaMember("CCSPlayerPawn", "m_flNextSprayDecalTime")]
	public ref float NextSprayDecalTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flNextSprayDecalTime");

	// m_bNextSprayDecalTimeExpedited
	[SchemaMember("CCSPlayerPawn", "m_bNextSprayDecalTimeExpedited")]
	public ref bool NextSprayDecalTimeExpedited => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bNextSprayDecalTimeExpedited");

	// m_nRagdollDamageBone
	[SchemaMember("CCSPlayerPawn", "m_nRagdollDamageBone")]
	public ref Int32 RagdollDamageBone => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_nRagdollDamageBone");

	// m_vRagdollDamageForce
	[SchemaMember("CCSPlayerPawn", "m_vRagdollDamageForce")]
	public Vector RagdollDamageForce => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vRagdollDamageForce");

	// m_vRagdollDamagePosition
	[SchemaMember("CCSPlayerPawn", "m_vRagdollDamagePosition")]
	public Vector RagdollDamagePosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vRagdollDamagePosition");

	// m_szRagdollDamageWeaponName
	[SchemaMember("CCSPlayerPawn", "m_szRagdollDamageWeaponName")]
	public string RagdollDamageWeaponName
	{
		get { return Schema.GetString(this.Handle, "CCSPlayerPawn", "m_szRagdollDamageWeaponName"); }
		set { Schema.SetStringBytes(this.Handle, "CCSPlayerPawn", "m_szRagdollDamageWeaponName", value, 64); }
	}

	// m_bRagdollDamageHeadshot
	[SchemaMember("CCSPlayerPawn", "m_bRagdollDamageHeadshot")]
	public ref bool RagdollDamageHeadshot => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bRagdollDamageHeadshot");

	// m_vRagdollServerOrigin
	[SchemaMember("CCSPlayerPawn", "m_vRagdollServerOrigin")]
	public Vector RagdollServerOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vRagdollServerOrigin");

	// m_EconGloves
	[SchemaMember("CCSPlayerPawn", "m_EconGloves")]
	public CEconItemView EconGloves => Schema.GetDeclaredClass<CEconItemView>(this.Handle, "CCSPlayerPawn", "m_EconGloves");

	// m_nEconGlovesChanged
	[SchemaMember("CCSPlayerPawn", "m_nEconGlovesChanged")]
	public ref byte EconGlovesChanged => ref Schema.GetRef<byte>(this.Handle, "CCSPlayerPawn", "m_nEconGlovesChanged");

	// m_qDeathEyeAngles
	[SchemaMember("CCSPlayerPawn", "m_qDeathEyeAngles")]
	public QAngle DeathEyeAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawn", "m_qDeathEyeAngles");

	// m_bSkipOneHeadConstraintUpdate
	[SchemaMember("CCSPlayerPawn", "m_bSkipOneHeadConstraintUpdate")]
	public ref bool SkipOneHeadConstraintUpdate => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bSkipOneHeadConstraintUpdate");

	// m_bLeftHanded
	[SchemaMember("CCSPlayerPawn", "m_bLeftHanded")]
	public ref bool LeftHanded => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bLeftHanded");

	// m_fSwitchedHandednessTime
	[SchemaMember("CCSPlayerPawn", "m_fSwitchedHandednessTime")]
	public ref float SwitchedHandednessTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_fSwitchedHandednessTime");

	// m_flViewmodelOffsetX
	[SchemaMember("CCSPlayerPawn", "m_flViewmodelOffsetX")]
	public ref float ViewmodelOffsetX => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flViewmodelOffsetX");

	// m_flViewmodelOffsetY
	[SchemaMember("CCSPlayerPawn", "m_flViewmodelOffsetY")]
	public ref float ViewmodelOffsetY => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flViewmodelOffsetY");

	// m_flViewmodelOffsetZ
	[SchemaMember("CCSPlayerPawn", "m_flViewmodelOffsetZ")]
	public ref float ViewmodelOffsetZ => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flViewmodelOffsetZ");

	// m_flViewmodelFOV
	[SchemaMember("CCSPlayerPawn", "m_flViewmodelFOV")]
	public ref float ViewmodelFOV => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flViewmodelFOV");

	// m_bIsWalking
	[SchemaMember("CCSPlayerPawn", "m_bIsWalking")]
	public ref bool IsWalking => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsWalking");

	// m_fLastGivenDefuserTime
	[SchemaMember("CCSPlayerPawn", "m_fLastGivenDefuserTime")]
	public ref float LastGivenDefuserTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_fLastGivenDefuserTime");

	// m_fLastGivenBombTime
	[SchemaMember("CCSPlayerPawn", "m_fLastGivenBombTime")]
	public ref float LastGivenBombTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_fLastGivenBombTime");

	// m_flDealtDamageToEnemyMostRecentTimestamp
	[SchemaMember("CCSPlayerPawn", "m_flDealtDamageToEnemyMostRecentTimestamp")]
	public ref float DealtDamageToEnemyMostRecentTimestamp => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flDealtDamageToEnemyMostRecentTimestamp");

	// m_iDisplayHistoryBits
	[SchemaMember("CCSPlayerPawn", "m_iDisplayHistoryBits")]
	public ref UInt32 DisplayHistoryBits => ref Schema.GetRef<UInt32>(this.Handle, "CCSPlayerPawn", "m_iDisplayHistoryBits");

	// m_flLastAttackedTeammate
	[SchemaMember("CCSPlayerPawn", "m_flLastAttackedTeammate")]
	public ref float LastAttackedTeammate => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flLastAttackedTeammate");

	// m_allowAutoFollowTime
	[SchemaMember("CCSPlayerPawn", "m_allowAutoFollowTime")]
	public ref float AllowAutoFollowTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_allowAutoFollowTime");

	// m_bResetArmorNextSpawn
	[SchemaMember("CCSPlayerPawn", "m_bResetArmorNextSpawn")]
	public ref bool ResetArmorNextSpawn => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bResetArmorNextSpawn");

	// m_nLastKillerIndex
	[SchemaMember("CCSPlayerPawn", "m_nLastKillerIndex")]
	public CEntityIndex LastKillerIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CCSPlayerPawn", "m_nLastKillerIndex");

	// m_entitySpottedState
	[SchemaMember("CCSPlayerPawn", "m_entitySpottedState")]
	public EntitySpottedState_t EntitySpottedState => Schema.GetDeclaredClass<EntitySpottedState_t>(this.Handle, "CCSPlayerPawn", "m_entitySpottedState");

	// m_nSpotRules
	[SchemaMember("CCSPlayerPawn", "m_nSpotRules")]
	public ref Int32 SpotRules => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_nSpotRules");

	// m_bIsScoped
	[SchemaMember("CCSPlayerPawn", "m_bIsScoped")]
	public ref bool IsScoped => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsScoped");

	// m_bResumeZoom
	[SchemaMember("CCSPlayerPawn", "m_bResumeZoom")]
	public ref bool ResumeZoom => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bResumeZoom");

	// m_bIsDefusing
	[SchemaMember("CCSPlayerPawn", "m_bIsDefusing")]
	public ref bool IsDefusing => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsDefusing");

	// m_bIsGrabbingHostage
	[SchemaMember("CCSPlayerPawn", "m_bIsGrabbingHostage")]
	public ref bool IsGrabbingHostage => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsGrabbingHostage");

	// m_iBlockingUseActionInProgress
	[SchemaMember("CCSPlayerPawn", "m_iBlockingUseActionInProgress")]
	public ref CSPlayerBlockingUseAction_t BlockingUseActionInProgress => ref Schema.GetRef<CSPlayerBlockingUseAction_t>(this.Handle, "CCSPlayerPawn", "m_iBlockingUseActionInProgress");

	// m_flEmitSoundTime
	[SchemaMember("CCSPlayerPawn", "m_flEmitSoundTime")]
	public ref float EmitSoundTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flEmitSoundTime");

	// m_bInNoDefuseArea
	[SchemaMember("CCSPlayerPawn", "m_bInNoDefuseArea")]
	public ref bool InNoDefuseArea => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInNoDefuseArea");

	// m_iBombSiteIndex
	[SchemaMember("CCSPlayerPawn", "m_iBombSiteIndex")]
	public CEntityIndex BombSiteIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CCSPlayerPawn", "m_iBombSiteIndex");

	// m_nWhichBombZone
	[SchemaMember("CCSPlayerPawn", "m_nWhichBombZone")]
	public ref Int32 WhichBombZone => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_nWhichBombZone");

	// m_bInBombZoneTrigger
	[SchemaMember("CCSPlayerPawn", "m_bInBombZoneTrigger")]
	public ref bool InBombZoneTrigger => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bInBombZoneTrigger");

	// m_bWasInBombZoneTrigger
	[SchemaMember("CCSPlayerPawn", "m_bWasInBombZoneTrigger")]
	public ref bool WasInBombZoneTrigger => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bWasInBombZoneTrigger");

	// m_iShotsFired
	[SchemaMember("CCSPlayerPawn", "m_iShotsFired")]
	public ref Int32 ShotsFired => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iShotsFired");

	// m_flFlinchStack
	[SchemaMember("CCSPlayerPawn", "m_flFlinchStack")]
	public ref float FlinchStack => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flFlinchStack");

	// m_flVelocityModifier
	[SchemaMember("CCSPlayerPawn", "m_flVelocityModifier")]
	public ref float VelocityModifier => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flVelocityModifier");

	// m_flHitHeading
	[SchemaMember("CCSPlayerPawn", "m_flHitHeading")]
	public ref float HitHeading => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flHitHeading");

	// m_nHitBodyPart
	[SchemaMember("CCSPlayerPawn", "m_nHitBodyPart")]
	public ref Int32 HitBodyPart => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_nHitBodyPart");

	// m_vecTotalBulletForce
	[SchemaMember("CCSPlayerPawn", "m_vecTotalBulletForce")]
	public Vector TotalBulletForce => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vecTotalBulletForce");

	// m_bWaitForNoAttack
	[SchemaMember("CCSPlayerPawn", "m_bWaitForNoAttack")]
	public ref bool WaitForNoAttack => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bWaitForNoAttack");

	// m_ignoreLadderJumpTime
	[SchemaMember("CCSPlayerPawn", "m_ignoreLadderJumpTime")]
	public ref float IgnoreLadderJumpTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_ignoreLadderJumpTime");

	// m_bKilledByHeadshot
	[SchemaMember("CCSPlayerPawn", "m_bKilledByHeadshot")]
	public ref bool KilledByHeadshot => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bKilledByHeadshot");

	// m_LastHitBox
	[SchemaMember("CCSPlayerPawn", "m_LastHitBox")]
	public ref Int32 LastHitBox => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_LastHitBox");

	// m_LastHealth
	[SchemaMember("CCSPlayerPawn", "m_LastHealth")]
	public ref Int32 LastHealth => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_LastHealth");

	// m_pBot
	[SchemaMember("CCSPlayerPawn", "m_pBot")]
	public CCSBot? Bot => Schema.GetPointer<CCSBot>(this.Handle, "CCSPlayerPawn", "m_pBot");

	// m_bBotAllowActive
	[SchemaMember("CCSPlayerPawn", "m_bBotAllowActive")]
	public ref bool BotAllowActive => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bBotAllowActive");

	// m_thirdPersonHeading
	[SchemaMember("CCSPlayerPawn", "m_thirdPersonHeading")]
	public QAngle ThirdPersonHeading => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawn", "m_thirdPersonHeading");

	// m_flSlopeDropOffset
	[SchemaMember("CCSPlayerPawn", "m_flSlopeDropOffset")]
	public ref float SlopeDropOffset => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flSlopeDropOffset");

	// m_flSlopeDropHeight
	[SchemaMember("CCSPlayerPawn", "m_flSlopeDropHeight")]
	public ref float SlopeDropHeight => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flSlopeDropHeight");

	// m_vHeadConstraintOffset
	[SchemaMember("CCSPlayerPawn", "m_vHeadConstraintOffset")]
	public Vector HeadConstraintOffset => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vHeadConstraintOffset");

	// m_nLastPickupPriority
	[SchemaMember("CCSPlayerPawn", "m_nLastPickupPriority")]
	public ref Int32 LastPickupPriority => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_nLastPickupPriority");

	// m_flLastPickupPriorityTime
	[SchemaMember("CCSPlayerPawn", "m_flLastPickupPriorityTime")]
	public ref float LastPickupPriorityTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flLastPickupPriorityTime");

	// m_ArmorValue
	[SchemaMember("CCSPlayerPawn", "m_ArmorValue")]
	public ref Int32 ArmorValue => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_ArmorValue");

	// m_unCurrentEquipmentValue
	[SchemaMember("CCSPlayerPawn", "m_unCurrentEquipmentValue")]
	public ref UInt16 CurrentEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawn", "m_unCurrentEquipmentValue");

	// m_unRoundStartEquipmentValue
	[SchemaMember("CCSPlayerPawn", "m_unRoundStartEquipmentValue")]
	public ref UInt16 RoundStartEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawn", "m_unRoundStartEquipmentValue");

	// m_unFreezetimeEndEquipmentValue
	[SchemaMember("CCSPlayerPawn", "m_unFreezetimeEndEquipmentValue")]
	public ref UInt16 FreezetimeEndEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawn", "m_unFreezetimeEndEquipmentValue");

	// m_iLastWeaponFireUsercmd
	[SchemaMember("CCSPlayerPawn", "m_iLastWeaponFireUsercmd")]
	public ref Int32 LastWeaponFireUsercmd => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iLastWeaponFireUsercmd");

	// m_flLastFriendlyFireDamageReductionRatio
	[SchemaMember("CCSPlayerPawn", "m_flLastFriendlyFireDamageReductionRatio")]
	public ref float LastFriendlyFireDamageReductionRatio => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flLastFriendlyFireDamageReductionRatio");

	// m_bIsSpawning
	[SchemaMember("CCSPlayerPawn", "m_bIsSpawning")]
	public ref bool IsSpawning => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bIsSpawning");

	// m_iDeathFlags
	[SchemaMember("CCSPlayerPawn", "m_iDeathFlags")]
	public ref Int32 DeathFlags => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawn", "m_iDeathFlags");

	// m_bHasDeathInfo
	[SchemaMember("CCSPlayerPawn", "m_bHasDeathInfo")]
	public ref bool HasDeathInfo => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bHasDeathInfo");

	// m_flDeathInfoTime
	[SchemaMember("CCSPlayerPawn", "m_flDeathInfoTime")]
	public ref float DeathInfoTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_flDeathInfoTime");

	// m_vecDeathInfoOrigin
	[SchemaMember("CCSPlayerPawn", "m_vecDeathInfoOrigin")]
	public Vector DeathInfoOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vecDeathInfoOrigin");

	// m_vecPlayerPatchEconIndices
	[SchemaMember("CCSPlayerPawn", "m_vecPlayerPatchEconIndices")]
	public Span<UInt32> PlayerPatchEconIndices => Schema.GetFixedArray<UInt32>(this.Handle, "CCSPlayerPawn", "m_vecPlayerPatchEconIndices", 5);

	// m_GunGameImmunityColor
	[SchemaMember("CCSPlayerPawn", "m_GunGameImmunityColor")]
	public Color GunGameImmunityColor
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CCSPlayerPawn", "m_GunGameImmunityColor"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CCSPlayerPawn", "m_GunGameImmunityColor", value); }
	}

	// m_grenadeParameterStashTime
	[SchemaMember("CCSPlayerPawn", "m_grenadeParameterStashTime")]
	public ref float GrenadeParameterStashTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawn", "m_grenadeParameterStashTime");

	// m_bGrenadeParametersStashed
	[SchemaMember("CCSPlayerPawn", "m_bGrenadeParametersStashed")]
	public ref bool GrenadeParametersStashed => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawn", "m_bGrenadeParametersStashed");

	// m_angStashedShootAngles
	[SchemaMember("CCSPlayerPawn", "m_angStashedShootAngles")]
	public QAngle StashedShootAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawn", "m_angStashedShootAngles");

	// m_vecStashedGrenadeThrowPosition
	[SchemaMember("CCSPlayerPawn", "m_vecStashedGrenadeThrowPosition")]
	public Vector StashedGrenadeThrowPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vecStashedGrenadeThrowPosition");

	// m_vecStashedVelocity
	[SchemaMember("CCSPlayerPawn", "m_vecStashedVelocity")]
	public Vector StashedVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawn", "m_vecStashedVelocity");

	// m_angShootAngleHistory
	[SchemaMember("CCSPlayerPawn", "m_angShootAngleHistory")]
	public Span<QAngle> ShootAngleHistory => Schema.GetFixedArray<QAngle>(this.Handle, "CCSPlayerPawn", "m_angShootAngleHistory", 2);

	// m_vecThrowPositionHistory
	[SchemaMember("CCSPlayerPawn", "m_vecThrowPositionHistory")]
	public Span<Vector> ThrowPositionHistory => Schema.GetFixedArray<Vector>(this.Handle, "CCSPlayerPawn", "m_vecThrowPositionHistory", 2);

	// m_vecVelocityHistory
	[SchemaMember("CCSPlayerPawn", "m_vecVelocityHistory")]
	public Span<Vector> VelocityHistory => Schema.GetFixedArray<Vector>(this.Handle, "CCSPlayerPawn", "m_vecVelocityHistory", 2);

}
