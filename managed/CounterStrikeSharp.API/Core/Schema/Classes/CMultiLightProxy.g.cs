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

public partial class CMultiLightProxy : CLogicalEntity
{
    public CMultiLightProxy (IntPtr pointer) : base(pointer) {}

	// m_iszLightNameFilter
	[SchemaMember("CMultiLightProxy", "m_iszLightNameFilter")]
	public string LightNameFilter
	{
		get { return Schema.GetUtf8String(this.Handle, "CMultiLightProxy", "m_iszLightNameFilter"); }
		set { Schema.SetString(this.Handle, "CMultiLightProxy", "m_iszLightNameFilter", value); }
	}

	// m_iszLightClassFilter
	[SchemaMember("CMultiLightProxy", "m_iszLightClassFilter")]
	public string LightClassFilter
	{
		get { return Schema.GetUtf8String(this.Handle, "CMultiLightProxy", "m_iszLightClassFilter"); }
		set { Schema.SetString(this.Handle, "CMultiLightProxy", "m_iszLightClassFilter", value); }
	}

	// m_flLightRadiusFilter
	[SchemaMember("CMultiLightProxy", "m_flLightRadiusFilter")]
	public ref float LightRadiusFilter => ref Schema.GetRef<float>(this.Handle, "CMultiLightProxy", "m_flLightRadiusFilter");

	// m_flBrightnessDelta
	[SchemaMember("CMultiLightProxy", "m_flBrightnessDelta")]
	public ref float BrightnessDelta => ref Schema.GetRef<float>(this.Handle, "CMultiLightProxy", "m_flBrightnessDelta");

	// m_bPerformScreenFade
	[SchemaMember("CMultiLightProxy", "m_bPerformScreenFade")]
	public ref bool PerformScreenFade => ref Schema.GetRef<bool>(this.Handle, "CMultiLightProxy", "m_bPerformScreenFade");

	// m_flTargetBrightnessMultiplier
	[SchemaMember("CMultiLightProxy", "m_flTargetBrightnessMultiplier")]
	public ref float TargetBrightnessMultiplier => ref Schema.GetRef<float>(this.Handle, "CMultiLightProxy", "m_flTargetBrightnessMultiplier");

	// m_flCurrentBrightnessMultiplier
	[SchemaMember("CMultiLightProxy", "m_flCurrentBrightnessMultiplier")]
	public ref float CurrentBrightnessMultiplier => ref Schema.GetRef<float>(this.Handle, "CMultiLightProxy", "m_flCurrentBrightnessMultiplier");

	// m_vecLights
	[SchemaMember("CMultiLightProxy", "m_vecLights")]
	public NetworkedVector<CHandle<CLightEntity>> Lights => Schema.GetDeclaredClass<NetworkedVector<CHandle<CLightEntity>>>(this.Handle, "CMultiLightProxy", "m_vecLights");

}
