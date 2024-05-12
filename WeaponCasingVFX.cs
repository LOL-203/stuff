using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000523 RID: 1315
public class WeaponCasingVFX : MonoBehaviour
{
	// Token: 0x06006B9A RID: 27546 RVA: 0x001B0774 File Offset: 0x001AE974
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B9B RID: 27547 RVA: 0x001B07B8 File Offset: 0x001AE9B8
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B9C RID: 27548 RVA: 0x001B07FC File Offset: 0x001AE9FC
	[CallerCount(0)]
	public unsafe void LaunchCasing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponCasingVFX.NativeMethodInfoPtr_LaunchCasing_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B9D RID: 27549 RVA: 0x001B084C File Offset: 0x001AEA4C
	[CallerCount(0)]
	public unsafe void EmmitCasingParticle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_EmmitCasingParticle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x1700264A RID: 9802
	// (get) Token: 0x06006B9E RID: 27550 RVA: 0x001B0890 File Offset: 0x001AEA90
	// (set) Token: 0x06006B9F RID: 27551 RVA: 0x001B08E0 File Offset: 0x001AEAE0
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06006BA0 RID: 27552 RVA: 0x001B0934 File Offset: 0x001AEB34
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BA1 RID: 27553 RVA: 0x001B0978 File Offset: 0x001AEB78
	[CallerCount(0)]
	public unsafe WeaponCasingVFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponCasingVFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BA2 RID: 27554 RVA: 0x001B09C4 File Offset: 0x001AEBC4
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponCasingVFX()
	{
		Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponCasingVFX");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr);
		WeaponCasingVFX.NativeFieldInfoPtr__casingParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_casingParticle");
		WeaponCasingVFX.NativeFieldInfoPtr__casingOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_casingOrigin");
		WeaponCasingVFX.NativeFieldInfoPtr_SFXCollisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "SFXCollisionType");
		WeaponCasingVFX.NativeFieldInfoPtr__casingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_casingSpeed");
		WeaponCasingVFX.NativeFieldInfoPtr__pickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_pickup");
		WeaponCasingVFX.NativeFieldInfoPtr__setLifeTimeToDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_setLifeTimeToDistance");
		WeaponCasingVFX.NativeFieldInfoPtr__alignParticleRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_alignParticleRotation");
		WeaponCasingVFX.NativeFieldInfoPtr__minParticleVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_minParticleVelocity");
		WeaponCasingVFX.NativeFieldInfoPtr__maxParticleVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_maxParticleVelocity");
		WeaponCasingVFX.NativeFieldInfoPtr__verticalAngleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_verticalAngleRange");
		WeaponCasingVFX.NativeFieldInfoPtr__horizontalAngleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_horizontalAngleRange");
		WeaponCasingVFX.NativeFieldInfoPtr__distanceMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_distanceMask");
		WeaponCasingVFX.NativeFieldInfoPtr__casingImpacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "_casingImpacts");
		WeaponCasingVFX.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		WeaponCasingVFX.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671857);
		WeaponCasingVFX.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671858);
		WeaponCasingVFX.NativeMethodInfoPtr_LaunchCasing_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671859);
		WeaponCasingVFX.NativeMethodInfoPtr_EmmitCasingParticle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671860);
		WeaponCasingVFX.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671861);
		WeaponCasingVFX.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671862);
		WeaponCasingVFX.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671863);
		WeaponCasingVFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, 100671864);
	}

	// Token: 0x06006BA3 RID: 27555 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponCasingVFX(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700263B RID: 9787
	// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x001B0BAC File Offset: 0x001AEDAC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr));
		}
	}

	// Token: 0x1700263C RID: 9788
	// (get) Token: 0x06006BA5 RID: 27557 RVA: 0x001B0BC0 File Offset: 0x001AEDC0
	// (set) Token: 0x06006BA6 RID: 27558 RVA: 0x001B0BF4 File Offset: 0x001AEDF4
	public unsafe ParticleSystem _casingParticle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingParticle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ParticleSystem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingParticle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700263D RID: 9789
	// (get) Token: 0x06006BA7 RID: 27559 RVA: 0x001B0C1C File Offset: 0x001AEE1C
	// (set) Token: 0x06006BA8 RID: 27560 RVA: 0x001B0C50 File Offset: 0x001AEE50
	public unsafe Transform _casingOrigin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingOrigin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700263E RID: 9790
	// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001B0C78 File Offset: 0x001AEE78
	// (set) Token: 0x06006BAA RID: 27562 RVA: 0x001B0CA0 File Offset: 0x001AEEA0
	public unsafe SFXCollisionTypes SFXCollisionType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr_SFXCollisionType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr_SFXCollisionType)) = value;
		}
	}

	// Token: 0x1700263F RID: 9791
	// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001B0CC4 File Offset: 0x001AEEC4
	// (set) Token: 0x06006BAC RID: 27564 RVA: 0x001B0CEC File Offset: 0x001AEEEC
	public unsafe float _casingSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingSpeed)) = value;
		}
	}

	// Token: 0x17002640 RID: 9792
	// (get) Token: 0x06006BAD RID: 27565 RVA: 0x001B0D10 File Offset: 0x001AEF10
	// (set) Token: 0x06006BAE RID: 27566 RVA: 0x001B0D44 File Offset: 0x001AEF44
	public unsafe Pickup _pickup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__pickup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__pickup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002641 RID: 9793
	// (get) Token: 0x06006BAF RID: 27567 RVA: 0x001B0D6C File Offset: 0x001AEF6C
	// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x001B0D94 File Offset: 0x001AEF94
	public unsafe bool _setLifeTimeToDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__setLifeTimeToDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__setLifeTimeToDistance)) = value;
		}
	}

	// Token: 0x17002642 RID: 9794
	// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001B0DB8 File Offset: 0x001AEFB8
	// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x001B0DE0 File Offset: 0x001AEFE0
	public unsafe bool _alignParticleRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__alignParticleRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__alignParticleRotation)) = value;
		}
	}

	// Token: 0x17002643 RID: 9795
	// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x001B0E04 File Offset: 0x001AF004
	// (set) Token: 0x06006BB4 RID: 27572 RVA: 0x001B0E2C File Offset: 0x001AF02C
	public unsafe float _minParticleVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__minParticleVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__minParticleVelocity)) = value;
		}
	}

	// Token: 0x17002644 RID: 9796
	// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x001B0E50 File Offset: 0x001AF050
	// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x001B0E78 File Offset: 0x001AF078
	public unsafe float _maxParticleVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__maxParticleVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__maxParticleVelocity)) = value;
		}
	}

	// Token: 0x17002645 RID: 9797
	// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x001B0E9C File Offset: 0x001AF09C
	// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x001B0EC4 File Offset: 0x001AF0C4
	public unsafe float _verticalAngleRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__verticalAngleRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__verticalAngleRange)) = value;
		}
	}

	// Token: 0x17002646 RID: 9798
	// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x001B0EE8 File Offset: 0x001AF0E8
	// (set) Token: 0x06006BBA RID: 27578 RVA: 0x001B0F10 File Offset: 0x001AF110
	public unsafe float _horizontalAngleRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__horizontalAngleRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__horizontalAngleRange)) = value;
		}
	}

	// Token: 0x17002647 RID: 9799
	// (get) Token: 0x06006BBB RID: 27579 RVA: 0x001B0F34 File Offset: 0x001AF134
	// (set) Token: 0x06006BBC RID: 27580 RVA: 0x001B0F5C File Offset: 0x001AF15C
	public unsafe LayerMask _distanceMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__distanceMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__distanceMask)) = value;
		}
	}

	// Token: 0x17002648 RID: 9800
	// (get) Token: 0x06006BBD RID: 27581 RVA: 0x001B0F80 File Offset: 0x001AF180
	// (set) Token: 0x06006BBE RID: 27582 RVA: 0x001B0FB4 File Offset: 0x001AF1B4
	public unsafe List<WeaponCasingVFX.CasingImpactInfo> _casingImpacts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingImpacts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<WeaponCasingVFX.CasingImpactInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__casingImpacts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002649 RID: 9801
	// (get) Token: 0x06006BBF RID: 27583 RVA: 0x001B0FDC File Offset: 0x001AF1DC
	// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x001B1004 File Offset: 0x001AF204
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponCasingVFX.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x04004493 RID: 17555
	private static readonly IntPtr NativeFieldInfoPtr__casingParticle;

	// Token: 0x04004494 RID: 17556
	private static readonly IntPtr NativeFieldInfoPtr__casingOrigin;

	// Token: 0x04004495 RID: 17557
	private static readonly IntPtr NativeFieldInfoPtr_SFXCollisionType;

	// Token: 0x04004496 RID: 17558
	private static readonly IntPtr NativeFieldInfoPtr__casingSpeed;

	// Token: 0x04004497 RID: 17559
	private static readonly IntPtr NativeFieldInfoPtr__pickup;

	// Token: 0x04004498 RID: 17560
	private static readonly IntPtr NativeFieldInfoPtr__setLifeTimeToDistance;

	// Token: 0x04004499 RID: 17561
	private static readonly IntPtr NativeFieldInfoPtr__alignParticleRotation;

	// Token: 0x0400449A RID: 17562
	private static readonly IntPtr NativeFieldInfoPtr__minParticleVelocity;

	// Token: 0x0400449B RID: 17563
	private static readonly IntPtr NativeFieldInfoPtr__maxParticleVelocity;

	// Token: 0x0400449C RID: 17564
	private static readonly IntPtr NativeFieldInfoPtr__verticalAngleRange;

	// Token: 0x0400449D RID: 17565
	private static readonly IntPtr NativeFieldInfoPtr__horizontalAngleRange;

	// Token: 0x0400449E RID: 17566
	private static readonly IntPtr NativeFieldInfoPtr__distanceMask;

	// Token: 0x0400449F RID: 17567
	private static readonly IntPtr NativeFieldInfoPtr__casingImpacts;

	// Token: 0x040044A0 RID: 17568
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x040044A1 RID: 17569
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040044A2 RID: 17570
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040044A3 RID: 17571
	private static readonly IntPtr NativeMethodInfoPtr_LaunchCasing_Public_Virtual_New_Void_0;

	// Token: 0x040044A4 RID: 17572
	private static readonly IntPtr NativeMethodInfoPtr_EmmitCasingParticle_Private_Void_0;

	// Token: 0x040044A5 RID: 17573
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x040044A6 RID: 17574
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x040044A7 RID: 17575
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x040044A8 RID: 17576
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000524 RID: 1316
	[StructLayout(2)]
	public struct CasingImpactInfo
	{
		// Token: 0x06006BC1 RID: 27585 RVA: 0x001B1028 File Offset: 0x001AF228
		// Note: this type is marked as 'beforefieldinit'.
		static CasingImpactInfo()
		{
			Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponCasingVFX>.NativeClassPtr, "CasingImpactInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr);
			WeaponCasingVFX.CasingImpactInfo.NativeFieldInfoPtr_ImpactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr, "ImpactTime");
			WeaponCasingVFX.CasingImpactInfo.NativeFieldInfoPtr_ImpactPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr, "ImpactPosition");
			WeaponCasingVFX.CasingImpactInfo.NativeFieldInfoPtr_ImpactMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr, "ImpactMaterial");
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x001B108F File Offset: 0x001AF28F
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x001B10A1 File Offset: 0x001AF2A1
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponCasingVFX.CasingImpactInfo>.NativeClassPtr));
			}
		}

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeFieldInfoPtr_ImpactTime;

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeFieldInfoPtr_ImpactPosition;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeFieldInfoPtr_ImpactMaterial;

		// Token: 0x040044AC RID: 17580
		[FieldOffset(0)]
		public float ImpactTime;

		// Token: 0x040044AD RID: 17581
		[FieldOffset(4)]
		public Vector3 ImpactPosition;

		// Token: 0x040044AE RID: 17582
		[FieldOffset(16)]
		public DamageLibrary.MaterialType ImpactMaterial;
	}
}
