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

public partial class CBaseIssue : NativeObject
{
    public CBaseIssue (IntPtr pointer) : base(pointer) {}

	// m_szTypeString
	[SchemaMember("CBaseIssue", "m_szTypeString")]
	public string TypeString
	{
		get { return Schema.GetString(this.Handle, "CBaseIssue", "m_szTypeString"); }
		set { Schema.SetString(this.Handle, "CBaseIssue", "m_szTypeString", value); }
	}

	// m_szDetailsString
	[SchemaMember("CBaseIssue", "m_szDetailsString")]
	public string DetailsString
	{
		get { return Schema.GetString(this.Handle, "CBaseIssue", "m_szDetailsString"); }
		set { Schema.SetString(this.Handle, "CBaseIssue", "m_szDetailsString", value); }
	}

	// m_iNumYesVotes
	[SchemaMember("CBaseIssue", "m_iNumYesVotes")]
	public ref Int32 NumYesVotes => ref Schema.GetRef<Int32>(this.Handle, "CBaseIssue", "m_iNumYesVotes");

	// m_iNumNoVotes
	[SchemaMember("CBaseIssue", "m_iNumNoVotes")]
	public ref Int32 NumNoVotes => ref Schema.GetRef<Int32>(this.Handle, "CBaseIssue", "m_iNumNoVotes");

	// m_iNumPotentialVotes
	[SchemaMember("CBaseIssue", "m_iNumPotentialVotes")]
	public ref Int32 NumPotentialVotes => ref Schema.GetRef<Int32>(this.Handle, "CBaseIssue", "m_iNumPotentialVotes");

	// m_pVoteController
	[SchemaMember("CBaseIssue", "m_pVoteController")]
	public CVoteController? VoteController => Schema.GetPointer<CVoteController>(this.Handle, "CBaseIssue", "m_pVoteController");

}
