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

public partial class CFuncMoveLinear : CBaseToggle
{
    public CFuncMoveLinear (IntPtr pointer) : base(pointer) {}

	// m_authoredPosition
	[SchemaMember("CFuncMoveLinear", "m_authoredPosition")]
	public ref MoveLinearAuthoredPos_t AuthoredPosition => ref Schema.GetRef<MoveLinearAuthoredPos_t>(this.Handle, "CFuncMoveLinear", "m_authoredPosition");

	// m_angMoveEntitySpace
	[SchemaMember("CFuncMoveLinear", "m_angMoveEntitySpace")]
	public QAngle MoveEntitySpace => Schema.GetDeclaredClass<QAngle>(this.Handle, "CFuncMoveLinear", "m_angMoveEntitySpace");

	// m_vecMoveDirParentSpace
	[SchemaMember("CFuncMoveLinear", "m_vecMoveDirParentSpace")]
	public Vector MoveDirParentSpace => Schema.GetDeclaredClass<Vector>(this.Handle, "CFuncMoveLinear", "m_vecMoveDirParentSpace");

	// m_soundStart
	[SchemaMember("CFuncMoveLinear", "m_soundStart")]
	public string SoundStart
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMoveLinear", "m_soundStart"); }
		set { Schema.SetString(this.Handle, "CFuncMoveLinear", "m_soundStart", value); }
	}

	// m_soundStop
	[SchemaMember("CFuncMoveLinear", "m_soundStop")]
	public string SoundStop
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMoveLinear", "m_soundStop"); }
		set { Schema.SetString(this.Handle, "CFuncMoveLinear", "m_soundStop", value); }
	}

	// m_currentSound
	[SchemaMember("CFuncMoveLinear", "m_currentSound")]
	public string CurrentSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncMoveLinear", "m_currentSound"); }
		set { Schema.SetString(this.Handle, "CFuncMoveLinear", "m_currentSound", value); }
	}

	// m_flBlockDamage
	[SchemaMember("CFuncMoveLinear", "m_flBlockDamage")]
	public ref float BlockDamage => ref Schema.GetRef<float>(this.Handle, "CFuncMoveLinear", "m_flBlockDamage");

	// m_flStartPosition
	[SchemaMember("CFuncMoveLinear", "m_flStartPosition")]
	public ref float StartPosition => ref Schema.GetRef<float>(this.Handle, "CFuncMoveLinear", "m_flStartPosition");

	// m_flMoveDistance
	[SchemaMember("CFuncMoveLinear", "m_flMoveDistance")]
	public ref float MoveDistance => ref Schema.GetRef<float>(this.Handle, "CFuncMoveLinear", "m_flMoveDistance");

	// m_OnFullyOpen
	[SchemaMember("CFuncMoveLinear", "m_OnFullyOpen")]
	public CEntityIOOutput OnFullyOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncMoveLinear", "m_OnFullyOpen");

	// m_OnFullyClosed
	[SchemaMember("CFuncMoveLinear", "m_OnFullyClosed")]
	public CEntityIOOutput OnFullyClosed => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CFuncMoveLinear", "m_OnFullyClosed");

	// m_bCreateMovableNavMesh
	[SchemaMember("CFuncMoveLinear", "m_bCreateMovableNavMesh")]
	public ref bool CreateMovableNavMesh => ref Schema.GetRef<bool>(this.Handle, "CFuncMoveLinear", "m_bCreateMovableNavMesh");

	// m_bCreateNavObstacle
	[SchemaMember("CFuncMoveLinear", "m_bCreateNavObstacle")]
	public ref bool CreateNavObstacle => ref Schema.GetRef<bool>(this.Handle, "CFuncMoveLinear", "m_bCreateNavObstacle");

}
