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

public partial class CNavLinkAreaEntity : CPointEntity
{
    public CNavLinkAreaEntity (IntPtr pointer) : base(pointer) {}

	// m_flWidth
	[SchemaMember("CNavLinkAreaEntity", "m_flWidth")]
	public ref float Width => ref Schema.GetRef<float>(this.Handle, "CNavLinkAreaEntity", "m_flWidth");

	// m_vLocatorOffset
	[SchemaMember("CNavLinkAreaEntity", "m_vLocatorOffset")]
	public Vector LocatorOffset => Schema.GetDeclaredClass<Vector>(this.Handle, "CNavLinkAreaEntity", "m_vLocatorOffset");

	// m_qLocatorAnglesOffset
	[SchemaMember("CNavLinkAreaEntity", "m_qLocatorAnglesOffset")]
	public QAngle LocatorAnglesOffset => Schema.GetDeclaredClass<QAngle>(this.Handle, "CNavLinkAreaEntity", "m_qLocatorAnglesOffset");

	// m_strMovementForward
	[SchemaMember("CNavLinkAreaEntity", "m_strMovementForward")]
	public string StrMovementForward
	{
		get { return Schema.GetUtf8String(this.Handle, "CNavLinkAreaEntity", "m_strMovementForward"); }
		set { Schema.SetString(this.Handle, "CNavLinkAreaEntity", "m_strMovementForward", value); }
	}

	// m_strMovementReverse
	[SchemaMember("CNavLinkAreaEntity", "m_strMovementReverse")]
	public string StrMovementReverse
	{
		get { return Schema.GetUtf8String(this.Handle, "CNavLinkAreaEntity", "m_strMovementReverse"); }
		set { Schema.SetString(this.Handle, "CNavLinkAreaEntity", "m_strMovementReverse", value); }
	}

	// m_nNavLinkIdForward
	[SchemaMember("CNavLinkAreaEntity", "m_nNavLinkIdForward")]
	public ref Int32 NavLinkIdForward => ref Schema.GetRef<Int32>(this.Handle, "CNavLinkAreaEntity", "m_nNavLinkIdForward");

	// m_nNavLinkIdReverse
	[SchemaMember("CNavLinkAreaEntity", "m_nNavLinkIdReverse")]
	public ref Int32 NavLinkIdReverse => ref Schema.GetRef<Int32>(this.Handle, "CNavLinkAreaEntity", "m_nNavLinkIdReverse");

	// m_bEnabled
	[SchemaMember("CNavLinkAreaEntity", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CNavLinkAreaEntity", "m_bEnabled");

	// m_strFilterName
	[SchemaMember("CNavLinkAreaEntity", "m_strFilterName")]
	public string StrFilterName
	{
		get { return Schema.GetUtf8String(this.Handle, "CNavLinkAreaEntity", "m_strFilterName"); }
		set { Schema.SetString(this.Handle, "CNavLinkAreaEntity", "m_strFilterName", value); }
	}

	// m_hFilter
	[SchemaMember("CNavLinkAreaEntity", "m_hFilter")]
	public CHandle<CBaseFilter> Filter => Schema.GetDeclaredClass<CHandle<CBaseFilter>>(this.Handle, "CNavLinkAreaEntity", "m_hFilter");

	// m_OnNavLinkStart
	[SchemaMember("CNavLinkAreaEntity", "m_OnNavLinkStart")]
	public CEntityIOOutput OnNavLinkStart => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CNavLinkAreaEntity", "m_OnNavLinkStart");

	// m_OnNavLinkFinish
	[SchemaMember("CNavLinkAreaEntity", "m_OnNavLinkFinish")]
	public CEntityIOOutput OnNavLinkFinish => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CNavLinkAreaEntity", "m_OnNavLinkFinish");

	// m_bIsTerminus
	[SchemaMember("CNavLinkAreaEntity", "m_bIsTerminus")]
	public ref bool IsTerminus => ref Schema.GetRef<bool>(this.Handle, "CNavLinkAreaEntity", "m_bIsTerminus");

}
