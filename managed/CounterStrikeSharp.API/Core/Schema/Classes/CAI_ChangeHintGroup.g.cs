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

public partial class CAI_ChangeHintGroup : CBaseEntity
{
    public CAI_ChangeHintGroup (IntPtr pointer) : base(pointer) {}

	// m_iSearchType
	[SchemaMember("CAI_ChangeHintGroup", "m_iSearchType")]
	public ref Int32 SearchType => ref Schema.GetRef<Int32>(this.Handle, "CAI_ChangeHintGroup", "m_iSearchType");

	// m_strSearchName
	[SchemaMember("CAI_ChangeHintGroup", "m_strSearchName")]
	public string StrSearchName
	{
		get { return Schema.GetUtf8String(this.Handle, "CAI_ChangeHintGroup", "m_strSearchName"); }
		set { Schema.SetString(this.Handle, "CAI_ChangeHintGroup", "m_strSearchName", value); }
	}

	// m_strNewHintGroup
	[SchemaMember("CAI_ChangeHintGroup", "m_strNewHintGroup")]
	public string StrNewHintGroup
	{
		get { return Schema.GetUtf8String(this.Handle, "CAI_ChangeHintGroup", "m_strNewHintGroup"); }
		set { Schema.SetString(this.Handle, "CAI_ChangeHintGroup", "m_strNewHintGroup", value); }
	}

	// m_flRadius
	[SchemaMember("CAI_ChangeHintGroup", "m_flRadius")]
	public ref float Radius => ref Schema.GetRef<float>(this.Handle, "CAI_ChangeHintGroup", "m_flRadius");

}