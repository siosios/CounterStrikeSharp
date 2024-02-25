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

public partial class CEnvDecal : CBaseModelEntity
{
    public CEnvDecal (IntPtr pointer) : base(pointer) {}

	// m_hDecalMaterial
	[SchemaMember("CEnvDecal", "m_hDecalMaterial")]
	public CStrongHandle<InfoForResourceTypeIMaterial2> DecalMaterial => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeIMaterial2>>(this.Handle, "CEnvDecal", "m_hDecalMaterial");

	// m_flWidth
	[SchemaMember("CEnvDecal", "m_flWidth")]
	public ref float Width => ref Schema.GetRef<float>(this.Handle, "CEnvDecal", "m_flWidth");

	// m_flHeight
	[SchemaMember("CEnvDecal", "m_flHeight")]
	public ref float Height => ref Schema.GetRef<float>(this.Handle, "CEnvDecal", "m_flHeight");

	// m_flDepth
	[SchemaMember("CEnvDecal", "m_flDepth")]
	public ref float Depth => ref Schema.GetRef<float>(this.Handle, "CEnvDecal", "m_flDepth");

	// m_nRenderOrder
	[SchemaMember("CEnvDecal", "m_nRenderOrder")]
	public ref UInt32 RenderOrder => ref Schema.GetRef<UInt32>(this.Handle, "CEnvDecal", "m_nRenderOrder");

	// m_bProjectOnWorld
	[SchemaMember("CEnvDecal", "m_bProjectOnWorld")]
	public ref bool ProjectOnWorld => ref Schema.GetRef<bool>(this.Handle, "CEnvDecal", "m_bProjectOnWorld");

	// m_bProjectOnCharacters
	[SchemaMember("CEnvDecal", "m_bProjectOnCharacters")]
	public ref bool ProjectOnCharacters => ref Schema.GetRef<bool>(this.Handle, "CEnvDecal", "m_bProjectOnCharacters");

	// m_bProjectOnWater
	[SchemaMember("CEnvDecal", "m_bProjectOnWater")]
	public ref bool ProjectOnWater => ref Schema.GetRef<bool>(this.Handle, "CEnvDecal", "m_bProjectOnWater");

	// m_flDepthSortBias
	[SchemaMember("CEnvDecal", "m_flDepthSortBias")]
	public ref float DepthSortBias => ref Schema.GetRef<float>(this.Handle, "CEnvDecal", "m_flDepthSortBias");

}
