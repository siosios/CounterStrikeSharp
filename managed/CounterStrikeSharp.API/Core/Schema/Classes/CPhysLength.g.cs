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

public partial class CPhysLength : CPhysConstraint
{
    public CPhysLength (IntPtr pointer) : base(pointer) {}

	// m_offset
	[SchemaMember("CPhysLength", "m_offset")]
	public Span<Vector> Offset => Schema.GetFixedArray<Vector>(this.Handle, "CPhysLength", "m_offset", 2);

	// m_vecAttach
	[SchemaMember("CPhysLength", "m_vecAttach")]
	public Vector Attach => Schema.GetDeclaredClass<Vector>(this.Handle, "CPhysLength", "m_vecAttach");

	// m_addLength
	[SchemaMember("CPhysLength", "m_addLength")]
	public ref float AddLength => ref Schema.GetRef<float>(this.Handle, "CPhysLength", "m_addLength");

	// m_minLength
	[SchemaMember("CPhysLength", "m_minLength")]
	public ref float MinLength => ref Schema.GetRef<float>(this.Handle, "CPhysLength", "m_minLength");

	// m_totalLength
	[SchemaMember("CPhysLength", "m_totalLength")]
	public ref float TotalLength => ref Schema.GetRef<float>(this.Handle, "CPhysLength", "m_totalLength");

	// m_bEnableCollision
	[SchemaMember("CPhysLength", "m_bEnableCollision")]
	public ref bool EnableCollision => ref Schema.GetRef<bool>(this.Handle, "CPhysLength", "m_bEnableCollision");

}
