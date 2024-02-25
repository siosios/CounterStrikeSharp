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

public partial class CPointCommentaryNode : CBaseAnimGraph
{
    public CPointCommentaryNode (IntPtr pointer) : base(pointer) {}

	// m_iszPreCommands
	[SchemaMember("CPointCommentaryNode", "m_iszPreCommands")]
	public string PreCommands
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszPreCommands"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszPreCommands", value); }
	}

	// m_iszPostCommands
	[SchemaMember("CPointCommentaryNode", "m_iszPostCommands")]
	public string PostCommands
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszPostCommands"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszPostCommands", value); }
	}

	// m_iszCommentaryFile
	[SchemaMember("CPointCommentaryNode", "m_iszCommentaryFile")]
	public string CommentaryFile
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszCommentaryFile"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszCommentaryFile", value); }
	}

	// m_iszViewTarget
	[SchemaMember("CPointCommentaryNode", "m_iszViewTarget")]
	public string IszViewTarget
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszViewTarget"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszViewTarget", value); }
	}

	// m_hViewTarget
	[SchemaMember("CPointCommentaryNode", "m_hViewTarget")]
	public CHandle<CBaseEntity> HViewTarget => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointCommentaryNode", "m_hViewTarget");

	// m_hViewTargetAngles
	[SchemaMember("CPointCommentaryNode", "m_hViewTargetAngles")]
	public CHandle<CBaseEntity> ViewTargetAngles => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointCommentaryNode", "m_hViewTargetAngles");

	// m_iszViewPosition
	[SchemaMember("CPointCommentaryNode", "m_iszViewPosition")]
	public string IszViewPosition
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszViewPosition"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszViewPosition", value); }
	}

	// m_hViewPosition
	[SchemaMember("CPointCommentaryNode", "m_hViewPosition")]
	public CHandle<CBaseEntity> HViewPosition => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointCommentaryNode", "m_hViewPosition");

	// m_hViewPositionMover
	[SchemaMember("CPointCommentaryNode", "m_hViewPositionMover")]
	public CHandle<CBaseEntity> ViewPositionMover => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointCommentaryNode", "m_hViewPositionMover");

	// m_bPreventMovement
	[SchemaMember("CPointCommentaryNode", "m_bPreventMovement")]
	public ref bool PreventMovement => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bPreventMovement");

	// m_bUnderCrosshair
	[SchemaMember("CPointCommentaryNode", "m_bUnderCrosshair")]
	public ref bool UnderCrosshair => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bUnderCrosshair");

	// m_bUnstoppable
	[SchemaMember("CPointCommentaryNode", "m_bUnstoppable")]
	public ref bool Unstoppable => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bUnstoppable");

	// m_flFinishedTime
	[SchemaMember("CPointCommentaryNode", "m_flFinishedTime")]
	public ref float FinishedTime => ref Schema.GetRef<float>(this.Handle, "CPointCommentaryNode", "m_flFinishedTime");

	// m_vecFinishOrigin
	[SchemaMember("CPointCommentaryNode", "m_vecFinishOrigin")]
	public Vector FinishOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CPointCommentaryNode", "m_vecFinishOrigin");

	// m_vecOriginalAngles
	[SchemaMember("CPointCommentaryNode", "m_vecOriginalAngles")]
	public QAngle OriginalAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPointCommentaryNode", "m_vecOriginalAngles");

	// m_vecFinishAngles
	[SchemaMember("CPointCommentaryNode", "m_vecFinishAngles")]
	public QAngle FinishAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPointCommentaryNode", "m_vecFinishAngles");

	// m_bPreventChangesWhileMoving
	[SchemaMember("CPointCommentaryNode", "m_bPreventChangesWhileMoving")]
	public ref bool PreventChangesWhileMoving => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bPreventChangesWhileMoving");

	// m_bDisabled
	[SchemaMember("CPointCommentaryNode", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bDisabled");

	// m_vecTeleportOrigin
	[SchemaMember("CPointCommentaryNode", "m_vecTeleportOrigin")]
	public Vector TeleportOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CPointCommentaryNode", "m_vecTeleportOrigin");

	// m_flAbortedPlaybackAt
	[SchemaMember("CPointCommentaryNode", "m_flAbortedPlaybackAt")]
	public ref float AbortedPlaybackAt => ref Schema.GetRef<float>(this.Handle, "CPointCommentaryNode", "m_flAbortedPlaybackAt");

	// m_pOnCommentaryStarted
	[SchemaMember("CPointCommentaryNode", "m_pOnCommentaryStarted")]
	public CEntityIOOutput OnCommentaryStarted => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointCommentaryNode", "m_pOnCommentaryStarted");

	// m_pOnCommentaryStopped
	[SchemaMember("CPointCommentaryNode", "m_pOnCommentaryStopped")]
	public CEntityIOOutput OnCommentaryStopped => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointCommentaryNode", "m_pOnCommentaryStopped");

	// m_bActive
	[SchemaMember("CPointCommentaryNode", "m_bActive")]
	public ref bool Active => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bActive");

	// m_flStartTime
	[SchemaMember("CPointCommentaryNode", "m_flStartTime")]
	public ref float StartTime => ref Schema.GetRef<float>(this.Handle, "CPointCommentaryNode", "m_flStartTime");

	// m_flStartTimeInCommentary
	[SchemaMember("CPointCommentaryNode", "m_flStartTimeInCommentary")]
	public ref float StartTimeInCommentary => ref Schema.GetRef<float>(this.Handle, "CPointCommentaryNode", "m_flStartTimeInCommentary");

	// m_iszTitle
	[SchemaMember("CPointCommentaryNode", "m_iszTitle")]
	public string Title
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszTitle"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszTitle", value); }
	}

	// m_iszSpeakers
	[SchemaMember("CPointCommentaryNode", "m_iszSpeakers")]
	public string Speakers
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointCommentaryNode", "m_iszSpeakers"); }
		set { Schema.SetString(this.Handle, "CPointCommentaryNode", "m_iszSpeakers", value); }
	}

	// m_iNodeNumber
	[SchemaMember("CPointCommentaryNode", "m_iNodeNumber")]
	public ref Int32 NodeNumber => ref Schema.GetRef<Int32>(this.Handle, "CPointCommentaryNode", "m_iNodeNumber");

	// m_iNodeNumberMax
	[SchemaMember("CPointCommentaryNode", "m_iNodeNumberMax")]
	public ref Int32 NodeNumberMax => ref Schema.GetRef<Int32>(this.Handle, "CPointCommentaryNode", "m_iNodeNumberMax");

	// m_bListenedTo
	[SchemaMember("CPointCommentaryNode", "m_bListenedTo")]
	public ref bool ListenedTo => ref Schema.GetRef<bool>(this.Handle, "CPointCommentaryNode", "m_bListenedTo");

}
