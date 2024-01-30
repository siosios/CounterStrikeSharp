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

public partial class CFuncLadder : CBaseModelEntity
{
    public CFuncLadder (IntPtr pointer) : base(pointer) {}

	// m_vecLadderDir
	[SchemaMember("CFuncLadder", "m_vecLadderDir")]
	public Vector LadderDir => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncLadder", "m_vecLadderDir");

	// m_Dismounts
	[SchemaMember("CFuncLadder", "m_Dismounts")]
	public NetworkedVector<CHandle<CInfoLadderDismount>> Dismounts => Schema.GetDeclaredClass<NetworkedVector<CHandle<CInfoLadderDismount>>>(this.Handle, "CFuncLadder", "m_Dismounts");

	// m_vecLocalTop
	[SchemaMember("CFuncLadder", "m_vecLocalTop")]
	public Vector LocalTop => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncLadder", "m_vecLocalTop");

	// m_vecPlayerMountPositionTop
	[SchemaMember("CFuncLadder", "m_vecPlayerMountPositionTop")]
	public Vector PlayerMountPositionTop => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncLadder", "m_vecPlayerMountPositionTop");

	// m_vecPlayerMountPositionBottom
	[SchemaMember("CFuncLadder", "m_vecPlayerMountPositionBottom")]
	public Vector PlayerMountPositionBottom => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncLadder", "m_vecPlayerMountPositionBottom");

	// m_flAutoRideSpeed
	[SchemaMember("CFuncLadder", "m_flAutoRideSpeed")]
	public ref float AutoRideSpeed => ref Schema.GetRef<float>(this.Handle, "CFuncLadder", "m_flAutoRideSpeed");

	// m_bDisabled
	[SchemaMember("CFuncLadder", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CFuncLadder", "m_bDisabled");

	// m_bFakeLadder
	[SchemaMember("CFuncLadder", "m_bFakeLadder")]
	public ref bool FakeLadder => ref Schema.GetRef<bool>(this.Handle, "CFuncLadder", "m_bFakeLadder");

	// m_bHasSlack
	[SchemaMember("CFuncLadder", "m_bHasSlack")]
	public ref bool HasSlack => ref Schema.GetRef<bool>(this.Handle, "CFuncLadder", "m_bHasSlack");

	// m_surfacePropName
	[SchemaMember("CFuncLadder", "m_surfacePropName")]
	public string SurfacePropName
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncLadder", "m_surfacePropName"); }
		set { Schema.SetString(this.Handle, "CFuncLadder", "m_surfacePropName", value); }
	}

	// m_OnPlayerGotOnLadder
	[SchemaMember("CFuncLadder", "m_OnPlayerGotOnLadder")]
	public CEntityIOOutput OnPlayerGotOnLadder => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncLadder", "m_OnPlayerGotOnLadder");

	// m_OnPlayerGotOffLadder
	[SchemaMember("CFuncLadder", "m_OnPlayerGotOffLadder")]
	public CEntityIOOutput OnPlayerGotOffLadder => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncLadder", "m_OnPlayerGotOffLadder");

}
