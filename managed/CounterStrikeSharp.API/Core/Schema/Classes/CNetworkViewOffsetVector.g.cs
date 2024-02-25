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

public partial class CNetworkViewOffsetVector : NativeObject
{
    public CNetworkViewOffsetVector (IntPtr pointer) : base(pointer) {}

	// m_vecX
	[SchemaMember("CNetworkViewOffsetVector", "m_vecX")]
	public float X => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkViewOffsetVector", "m_vecX");

	// m_vecY
	[SchemaMember("CNetworkViewOffsetVector", "m_vecY")]
	public float Y => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkViewOffsetVector", "m_vecY");

	// m_vecZ
	[SchemaMember("CNetworkViewOffsetVector", "m_vecZ")]
	public float Z => Schema.GetDeclaredClass<float>(this.Handle, "CNetworkViewOffsetVector", "m_vecZ");

}
