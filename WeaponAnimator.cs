using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000519 RID: 1305
public class WeaponAnimator : MonoBehaviour
{
	// Token: 0x06006AF7 RID: 27383 RVA: 0x001ADD2C File Offset: 0x001ABF2C
	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AF8 RID: 27384 RVA: 0x001ADD70 File Offset: 0x001ABF70
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AF9 RID: 27385 RVA: 0x001ADDB4 File Offset: 0x001ABFB4
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFA RID: 27386 RVA: 0x001ADDF8 File Offset: 0x001ABFF8
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFB RID: 27387 RVA: 0x001ADE3C File Offset: 0x001AC03C
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAnimator.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFC RID: 27388 RVA: 0x001ADE8C File Offset: 0x001AC08C
	[CallerCount(0)]
	public unsafe void AddClip(Animation animation, AnimationClip clip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_AddClip_Public_Void_Animation_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFD RID: 27389 RVA: 0x001ADF00 File Offset: 0x001AC100
	[CallerCount(0)]
	public unsafe void PlayAnimationClip(Animation animation, AnimationClip clip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_PlayAnimationClip_Public_Void_Animation_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFE RID: 27390 RVA: 0x001ADF74 File Offset: 0x001AC174
	[CallerCount(0)]
	public unsafe void FireBoltSlide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_FireBoltSlide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006AFF RID: 27391 RVA: 0x001ADFB8 File Offset: 0x001AC1B8
	[CallerCount(0)]
	public unsafe void EmptyBoltSlide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_EmptyBoltSlide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B00 RID: 27392 RVA: 0x001ADFFC File Offset: 0x001AC1FC
	[CallerCount(0)]
	public unsafe void BoltRelease()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_BoltRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B01 RID: 27393 RVA: 0x001AE040 File Offset: 0x001AC240
	[CallerCount(0)]
	public unsafe void SemiAutoSwitch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_SemiAutoSwitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B02 RID: 27394 RVA: 0x001AE084 File Offset: 0x001AC284
	[CallerCount(0)]
	public unsafe void FullAutoSwitch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr_FullAutoSwitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B03 RID: 27395 RVA: 0x001AE0C8 File Offset: 0x001AC2C8
	[CallerCount(0)]
	public unsafe WeaponAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B04 RID: 27396 RVA: 0x001AE114 File Offset: 0x001AC314
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAnimator()
	{
		Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAnimator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr);
		WeaponAnimator.NativeFieldInfoPtr_WeaponSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "WeaponSO");
		WeaponAnimator.NativeFieldInfoPtr_boltAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "boltAnimation");
		WeaponAnimator.NativeFieldInfoPtr_fireSelectorAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "fireSelectorAnimation");
		WeaponAnimator.NativeFieldInfoPtr_pickupGun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "pickupGun");
		WeaponAnimator.NativeFieldInfoPtr_fireSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "fireSelector");
		WeaponAnimator.NativeFieldInfoPtr__hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "_hasInit");
		WeaponAnimator.NativeFieldInfoPtr__animationClipNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, "_animationClipNames");
		WeaponAnimator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671792);
		WeaponAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671793);
		WeaponAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671794);
		WeaponAnimator.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671795);
		WeaponAnimator.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671796);
		WeaponAnimator.NativeMethodInfoPtr_AddClip_Public_Void_Animation_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671797);
		WeaponAnimator.NativeMethodInfoPtr_PlayAnimationClip_Public_Void_Animation_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671798);
		WeaponAnimator.NativeMethodInfoPtr_FireBoltSlide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671799);
		WeaponAnimator.NativeMethodInfoPtr_EmptyBoltSlide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671800);
		WeaponAnimator.NativeMethodInfoPtr_BoltRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671801);
		WeaponAnimator.NativeMethodInfoPtr_SemiAutoSwitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671802);
		WeaponAnimator.NativeMethodInfoPtr_FullAutoSwitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671803);
		WeaponAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr, 100671804);
	}

	// Token: 0x06006B05 RID: 27397 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponAnimator(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002609 RID: 9737
	// (get) Token: 0x06006B06 RID: 27398 RVA: 0x001AE2D4 File Offset: 0x001AC4D4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAnimator>.NativeClassPtr));
		}
	}

	// Token: 0x1700260A RID: 9738
	// (get) Token: 0x06006B07 RID: 27399 RVA: 0x001AE2E8 File Offset: 0x001AC4E8
	// (set) Token: 0x06006B08 RID: 27400 RVA: 0x001AE31C File Offset: 0x001AC51C
	public unsafe WeaponSO WeaponSO
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_WeaponSO);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSO(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_WeaponSO), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700260B RID: 9739
	// (get) Token: 0x06006B09 RID: 27401 RVA: 0x001AE344 File Offset: 0x001AC544
	// (set) Token: 0x06006B0A RID: 27402 RVA: 0x001AE378 File Offset: 0x001AC578
	public unsafe Animation boltAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_boltAnimation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animation(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_boltAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700260C RID: 9740
	// (get) Token: 0x06006B0B RID: 27403 RVA: 0x001AE3A0 File Offset: 0x001AC5A0
	// (set) Token: 0x06006B0C RID: 27404 RVA: 0x001AE3D4 File Offset: 0x001AC5D4
	public unsafe Animation fireSelectorAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_fireSelectorAnimation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animation(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_fireSelectorAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700260D RID: 9741
	// (get) Token: 0x06006B0D RID: 27405 RVA: 0x001AE3FC File Offset: 0x001AC5FC
	// (set) Token: 0x06006B0E RID: 27406 RVA: 0x001AE430 File Offset: 0x001AC630
	public unsafe Pickup_Gun pickupGun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_pickupGun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Gun(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_pickupGun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700260E RID: 9742
	// (get) Token: 0x06006B0F RID: 27407 RVA: 0x001AE458 File Offset: 0x001AC658
	// (set) Token: 0x06006B10 RID: 27408 RVA: 0x001AE48C File Offset: 0x001AC68C
	public unsafe FireSelector fireSelector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_fireSelector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FireSelector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr_fireSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700260F RID: 9743
	// (get) Token: 0x06006B11 RID: 27409 RVA: 0x001AE4B4 File Offset: 0x001AC6B4
	// (set) Token: 0x06006B12 RID: 27410 RVA: 0x001AE4DC File Offset: 0x001AC6DC
	public unsafe bool _hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr__hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr__hasInit)) = value;
		}
	}

	// Token: 0x17002610 RID: 9744
	// (get) Token: 0x06006B13 RID: 27411 RVA: 0x001AE500 File Offset: 0x001AC700
	// (set) Token: 0x06006B14 RID: 27412 RVA: 0x001AE534 File Offset: 0x001AC734
	public unsafe Dictionary<AnimationClip, string> _animationClipNames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr__animationClipNames);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<AnimationClip, string>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAnimator.NativeFieldInfoPtr__animationClipNames), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040043B8 RID: 17336
	private static readonly IntPtr NativeFieldInfoPtr_WeaponSO;

	// Token: 0x040043B9 RID: 17337
	private static readonly IntPtr NativeFieldInfoPtr_boltAnimation;

	// Token: 0x040043BA RID: 17338
	private static readonly IntPtr NativeFieldInfoPtr_fireSelectorAnimation;

	// Token: 0x040043BB RID: 17339
	private static readonly IntPtr NativeFieldInfoPtr_pickupGun;

	// Token: 0x040043BC RID: 17340
	private static readonly IntPtr NativeFieldInfoPtr_fireSelector;

	// Token: 0x040043BD RID: 17341
	private static readonly IntPtr NativeFieldInfoPtr__hasInit;

	// Token: 0x040043BE RID: 17342
	private static readonly IntPtr NativeFieldInfoPtr__animationClipNames;

	// Token: 0x040043BF RID: 17343
	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	// Token: 0x040043C0 RID: 17344
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040043C1 RID: 17345
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040043C2 RID: 17346
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040043C3 RID: 17347
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

	// Token: 0x040043C4 RID: 17348
	private static readonly IntPtr NativeMethodInfoPtr_AddClip_Public_Void_Animation_AnimationClip_0;

	// Token: 0x040043C5 RID: 17349
	private static readonly IntPtr NativeMethodInfoPtr_PlayAnimationClip_Public_Void_Animation_AnimationClip_0;

	// Token: 0x040043C6 RID: 17350
	private static readonly IntPtr NativeMethodInfoPtr_FireBoltSlide_Public_Void_0;

	// Token: 0x040043C7 RID: 17351
	private static readonly IntPtr NativeMethodInfoPtr_EmptyBoltSlide_Public_Void_0;

	// Token: 0x040043C8 RID: 17352
	private static readonly IntPtr NativeMethodInfoPtr_BoltRelease_Public_Void_0;

	// Token: 0x040043C9 RID: 17353
	private static readonly IntPtr NativeMethodInfoPtr_SemiAutoSwitch_Public_Void_0;

	// Token: 0x040043CA RID: 17354
	private static readonly IntPtr NativeMethodInfoPtr_FullAutoSwitch_Public_Void_0;

	// Token: 0x040043CB RID: 17355
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
