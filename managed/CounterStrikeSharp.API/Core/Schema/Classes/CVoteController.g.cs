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

public partial class CVoteController : CBaseEntity
{
    public CVoteController (IntPtr pointer) : base(pointer) {}

	// m_iActiveIssueIndex
	[SchemaMember("CVoteController", "m_iActiveIssueIndex")]
	public ref Int32 ActiveIssueIndex => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_iActiveIssueIndex");

	// m_iOnlyTeamToVote
	[SchemaMember("CVoteController", "m_iOnlyTeamToVote")]
	public ref Int32 OnlyTeamToVote => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_iOnlyTeamToVote");

	// m_nVoteOptionCount
	[SchemaMember("CVoteController", "m_nVoteOptionCount")]
	public Span<Int32> VoteOptionCount => Schema.GetFixedArray<Int32>(this.Handle, "CVoteController", "m_nVoteOptionCount", 5);

	// m_nPotentialVotes
	[SchemaMember("CVoteController", "m_nPotentialVotes")]
	public ref Int32 PotentialVotes => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_nPotentialVotes");

	// m_bIsYesNoVote
	[SchemaMember("CVoteController", "m_bIsYesNoVote")]
	public ref bool IsYesNoVote => ref Schema.GetRef<bool>(this.Handle, "CVoteController", "m_bIsYesNoVote");

	// m_acceptingVotesTimer
	[SchemaMember("CVoteController", "m_acceptingVotesTimer")]
	public CountdownTimer AcceptingVotesTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CVoteController", "m_acceptingVotesTimer");

	// m_executeCommandTimer
	[SchemaMember("CVoteController", "m_executeCommandTimer")]
	public CountdownTimer ExecuteCommandTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CVoteController", "m_executeCommandTimer");

	// m_resetVoteTimer
	[SchemaMember("CVoteController", "m_resetVoteTimer")]
	public CountdownTimer ResetVoteTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CVoteController", "m_resetVoteTimer");

	// m_nVotesCast
	[SchemaMember("CVoteController", "m_nVotesCast")]
	public Span<Int32> VotesCast => Schema.GetFixedArray<Int32>(this.Handle, "CVoteController", "m_nVotesCast", 64);

	// m_playerHoldingVote
	[SchemaMember("CVoteController", "m_playerHoldingVote")]
	public ref Int32 PlayerHoldingVote => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_playerHoldingVote");

	// m_playerOverrideForVote
	[SchemaMember("CVoteController", "m_playerOverrideForVote")]
	public ref Int32 PlayerOverrideForVote => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_playerOverrideForVote");

	// m_nHighestCountIndex
	[SchemaMember("CVoteController", "m_nHighestCountIndex")]
	public ref Int32 HighestCountIndex => ref Schema.GetRef<Int32>(this.Handle, "CVoteController", "m_nHighestCountIndex");

	// m_potentialIssues
	[SchemaMember("CVoteController", "m_potentialIssues")]
	public NetworkedVector<CBaseIssue?> PotentialIssues => Schema.GetDeclaredClass<NetworkedVector<CBaseIssue?>>(this.Handle, "CVoteController", "m_potentialIssues");

}
