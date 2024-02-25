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

public partial class CRopeKeyframe : CBaseModelEntity
{
    public CRopeKeyframe (IntPtr pointer) : base(pointer) {}

	// m_RopeFlags
	[SchemaMember("CRopeKeyframe", "m_RopeFlags")]
	public ref UInt16 RopeFlags => ref Schema.GetRef<UInt16>(this.Handle, "CRopeKeyframe", "m_RopeFlags");

	// m_iNextLinkName
	[SchemaMember("CRopeKeyframe", "m_iNextLinkName")]
	public string NextLinkName
	{
		get { return Schema.GetUtf8String(this.Handle, "CRopeKeyframe", "m_iNextLinkName"); }
		set { Schema.SetString(this.Handle, "CRopeKeyframe", "m_iNextLinkName", value); }
	}

	// m_Slack
	[SchemaMember("CRopeKeyframe", "m_Slack")]
	public ref Int16 Slack => ref Schema.GetRef<Int16>(this.Handle, "CRopeKeyframe", "m_Slack");

	// m_Width
	[SchemaMember("CRopeKeyframe", "m_Width")]
	public ref float Width => ref Schema.GetRef<float>(this.Handle, "CRopeKeyframe", "m_Width");

	// m_TextureScale
	[SchemaMember("CRopeKeyframe", "m_TextureScale")]
	public ref float TextureScale => ref Schema.GetRef<float>(this.Handle, "CRopeKeyframe", "m_TextureScale");

	// m_nSegments
	[SchemaMember("CRopeKeyframe", "m_nSegments")]
	public ref byte Segments => ref Schema.GetRef<byte>(this.Handle, "CRopeKeyframe", "m_nSegments");

	// m_bConstrainBetweenEndpoints
	[SchemaMember("CRopeKeyframe", "m_bConstrainBetweenEndpoints")]
	public ref bool ConstrainBetweenEndpoints => ref Schema.GetRef<bool>(this.Handle, "CRopeKeyframe", "m_bConstrainBetweenEndpoints");

	// m_strRopeMaterialModel
	[SchemaMember("CRopeKeyframe", "m_strRopeMaterialModel")]
	public string StrRopeMaterialModel
	{
		get { return Schema.GetUtf8String(this.Handle, "CRopeKeyframe", "m_strRopeMaterialModel"); }
		set { Schema.SetString(this.Handle, "CRopeKeyframe", "m_strRopeMaterialModel", value); }
	}

	// m_iRopeMaterialModelIndex
	[SchemaMember("CRopeKeyframe", "m_iRopeMaterialModelIndex")]
	public CStrongHandle<InfoForResourceTypeIMaterial2> RopeMaterialModelIndex => Schema.GetDeclaredClass<CStrongHandle<InfoForResourceTypeIMaterial2>>(this.Handle, "CRopeKeyframe", "m_iRopeMaterialModelIndex");

	// m_Subdiv
	[SchemaMember("CRopeKeyframe", "m_Subdiv")]
	public ref byte Subdiv => ref Schema.GetRef<byte>(this.Handle, "CRopeKeyframe", "m_Subdiv");

	// m_nChangeCount
	[SchemaMember("CRopeKeyframe", "m_nChangeCount")]
	public ref byte ChangeCount => ref Schema.GetRef<byte>(this.Handle, "CRopeKeyframe", "m_nChangeCount");

	// m_RopeLength
	[SchemaMember("CRopeKeyframe", "m_RopeLength")]
	public ref Int16 RopeLength => ref Schema.GetRef<Int16>(this.Handle, "CRopeKeyframe", "m_RopeLength");

	// m_fLockedPoints
	[SchemaMember("CRopeKeyframe", "m_fLockedPoints")]
	public ref byte LockedPoints => ref Schema.GetRef<byte>(this.Handle, "CRopeKeyframe", "m_fLockedPoints");

	// m_bCreatedFromMapFile
	[SchemaMember("CRopeKeyframe", "m_bCreatedFromMapFile")]
	public ref bool CreatedFromMapFile => ref Schema.GetRef<bool>(this.Handle, "CRopeKeyframe", "m_bCreatedFromMapFile");

	// m_flScrollSpeed
	[SchemaMember("CRopeKeyframe", "m_flScrollSpeed")]
	public ref float ScrollSpeed => ref Schema.GetRef<float>(this.Handle, "CRopeKeyframe", "m_flScrollSpeed");

	// m_bStartPointValid
	[SchemaMember("CRopeKeyframe", "m_bStartPointValid")]
	public ref bool StartPointValid => ref Schema.GetRef<bool>(this.Handle, "CRopeKeyframe", "m_bStartPointValid");

	// m_bEndPointValid
	[SchemaMember("CRopeKeyframe", "m_bEndPointValid")]
	public ref bool EndPointValid => ref Schema.GetRef<bool>(this.Handle, "CRopeKeyframe", "m_bEndPointValid");

	// m_hStartPoint
	[SchemaMember("CRopeKeyframe", "m_hStartPoint")]
	public CHandle<CBaseEntity> StartPoint => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CRopeKeyframe", "m_hStartPoint");

	// m_hEndPoint
	[SchemaMember("CRopeKeyframe", "m_hEndPoint")]
	public CHandle<CBaseEntity> EndPoint => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CRopeKeyframe", "m_hEndPoint");

}
