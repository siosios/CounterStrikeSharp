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

public partial class CBaseAnimGraphController : CSkeletonAnimationController
{
    public CBaseAnimGraphController (IntPtr pointer) : base(pointer) {}

	// m_baseLayer
	[SchemaMember("CBaseAnimGraphController", "m_baseLayer")]
	public CNetworkedSequenceOperation BaseLayer => Schema.GetDeclaredClass<CNetworkedSequenceOperation>(this.Handle, "CBaseAnimGraphController", "m_baseLayer");

	// m_animGraphNetworkedVars
	[SchemaMember("CBaseAnimGraphController", "m_animGraphNetworkedVars")]
	public CAnimGraphNetworkedVariables AnimGraphNetworkedVars => Schema.GetDeclaredClass<CAnimGraphNetworkedVariables>(this.Handle, "CBaseAnimGraphController", "m_animGraphNetworkedVars");

	// m_bSequenceFinished
	[SchemaMember("CBaseAnimGraphController", "m_bSequenceFinished")]
	public ref bool SequenceFinished => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bSequenceFinished");

	// m_flLastEventCycle
	[SchemaMember("CBaseAnimGraphController", "m_flLastEventCycle")]
	public ref float LastEventCycle => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flLastEventCycle");

	// m_flLastEventAnimTime
	[SchemaMember("CBaseAnimGraphController", "m_flLastEventAnimTime")]
	public ref float LastEventAnimTime => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flLastEventAnimTime");

	// m_flPlaybackRate
	[SchemaMember("CBaseAnimGraphController", "m_flPlaybackRate")]
	public float PlaybackRate => Schema.GetDeclaredClass<float>(this.Handle, "CBaseAnimGraphController", "m_flPlaybackRate");

	// m_flPrevAnimTime
	[SchemaMember("CBaseAnimGraphController", "m_flPrevAnimTime")]
	public ref float PrevAnimTime => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flPrevAnimTime");

	// m_bClientSideAnimation
	[SchemaMember("CBaseAnimGraphController", "m_bClientSideAnimation")]
	public ref bool ClientSideAnimation => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bClientSideAnimation");

	// m_bNetworkedAnimationInputsChanged
	[SchemaMember("CBaseAnimGraphController", "m_bNetworkedAnimationInputsChanged")]
	public ref bool NetworkedAnimationInputsChanged => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bNetworkedAnimationInputsChanged");

	// m_nNewSequenceParity
	[SchemaMember("CBaseAnimGraphController", "m_nNewSequenceParity")]
	public ref Int32 NewSequenceParity => ref Schema.GetRef<Int32>(this.Handle, "CBaseAnimGraphController", "m_nNewSequenceParity");

	// m_nResetEventsParity
	[SchemaMember("CBaseAnimGraphController", "m_nResetEventsParity")]
	public ref Int32 ResetEventsParity => ref Schema.GetRef<Int32>(this.Handle, "CBaseAnimGraphController", "m_nResetEventsParity");

	// m_nAnimLoopMode
	[SchemaMember("CBaseAnimGraphController", "m_nAnimLoopMode")]
	public ref AnimLoopMode_t AnimLoopMode => ref Schema.GetRef<AnimLoopMode_t>(this.Handle, "CBaseAnimGraphController", "m_nAnimLoopMode");

	// m_hAnimationUpdate
	[SchemaMember("CBaseAnimGraphController", "m_hAnimationUpdate")]
	public AnimationUpdateListHandle_t AnimationUpdate => Schema.GetDeclaredClass<AnimationUpdateListHandle_t>(this.Handle, "CBaseAnimGraphController", "m_hAnimationUpdate");

}
