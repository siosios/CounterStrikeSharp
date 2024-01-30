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

public partial class CPhysMotor : CLogicalEntity
{
    public CPhysMotor (IntPtr pointer) : base(pointer) {}

	// m_nameAttach
	[SchemaMember("CPhysMotor", "m_nameAttach")]
	public string NameAttach
	{
		get { return Schema.GetUtf8String(this.Handle, "CPhysMotor", "m_nameAttach"); }
		set { Schema.SetString(this.Handle, "CPhysMotor", "m_nameAttach", value); }
	}

	// m_hAttachedObject
	[SchemaMember("CPhysMotor", "m_hAttachedObject")]
	public CHandle<CBaseEntity> AttachedObject => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPhysMotor", "m_hAttachedObject");

	// m_spinUp
	[SchemaMember("CPhysMotor", "m_spinUp")]
	public ref float SpinUp => ref Schema.GetRef<float>(this.Handle, "CPhysMotor", "m_spinUp");

	// m_additionalAcceleration
	[SchemaMember("CPhysMotor", "m_additionalAcceleration")]
	public ref float AdditionalAcceleration => ref Schema.GetRef<float>(this.Handle, "CPhysMotor", "m_additionalAcceleration");

	// m_angularAcceleration
	[SchemaMember("CPhysMotor", "m_angularAcceleration")]
	public ref float AngularAcceleration => ref Schema.GetRef<float>(this.Handle, "CPhysMotor", "m_angularAcceleration");

	// m_lastTime
	[SchemaMember("CPhysMotor", "m_lastTime")]
	public ref float LastTime => ref Schema.GetRef<float>(this.Handle, "CPhysMotor", "m_lastTime");

	// m_motor
	[SchemaMember("CPhysMotor", "m_motor")]
	public CMotorController Motor => Schema.GetDeclaredClass<CMotorController>(this.Handle, "CPhysMotor", "m_motor");

}
