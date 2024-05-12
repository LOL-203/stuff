using System;
using DPI.Data;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000251 RID: 593
public class WeightMovementData : BaseData
{
	// Token: 0x06002BDF RID: 11231 RVA: 0x000AD368 File Offset: 0x000AB568
	[CallerCount(0)]
	public unsafe void SetupSpeedComparisonValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightMovementData.NativeMethodInfoPtr_SetupSpeedComparisonValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x000AD3AC File Offset: 0x000AB5AC
	[CallerCount(0)]
	public unsafe static void SetupUIValues()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightMovementData.NativeMethodInfoPtr_SetupUIValues_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002BE1 RID: 11233 RVA: 0x000AD3E0 File Offset: 0x000AB5E0
	[CallerCount(0)]
	public unsafe WeightMovementData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeightMovementData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002BE2 RID: 11234 RVA: 0x000AD42C File Offset: 0x000AB62C
	// Note: this type is marked as 'beforefieldinit'.
	static WeightMovementData()
	{
		Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeightMovementData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr);
		WeightMovementData.NativeFieldInfoPtr_WeightClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "WeightClass");
		WeightMovementData.NativeFieldInfoPtr_BaseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "BaseSpeed");
		WeightMovementData.NativeFieldInfoPtr_SprintModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "SprintModifier");
		WeightMovementData.NativeFieldInfoPtr_FastWalkingMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "FastWalkingMultiplier");
		WeightMovementData.NativeFieldInfoPtr_WalkingMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "WalkingMultiplier");
		WeightMovementData.NativeFieldInfoPtr_ProneMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "ProneMultiplier");
		WeightMovementData.NativeFieldInfoPtr_CrouchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "CrouchMultiplier");
		WeightMovementData.NativeFieldInfoPtr_GunHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "GunHeightMultiplier");
		WeightMovementData.NativeFieldInfoPtr_PistolHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "PistolHeightMultiplier");
		WeightMovementData.NativeFieldInfoPtr_ForwardMovementLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "ForwardMovementLimit");
		WeightMovementData.NativeFieldInfoPtr_StrafeMovementLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "StrafeMovementLimit");
		WeightMovementData.NativeFieldInfoPtr_WeaponAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "WeaponAngle");
		WeightMovementData.NativeFieldInfoPtr_WeaponAngleUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "WeaponAngleUp");
		WeightMovementData.NativeFieldInfoPtr_StrafeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "StrafeSpeedMultiplier");
		WeightMovementData.NativeFieldInfoPtr_BackwardSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "BackwardSpeedMultiplier");
		WeightMovementData.NativeFieldInfoPtr_MidStrafeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "MidStrafeSpeedMultiplier");
		WeightMovementData.NativeFieldInfoPtr_IsUsingInertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "IsUsingInertia");
		WeightMovementData.NativeFieldInfoPtr_InertiaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "InertiaMultiplier");
		WeightMovementData.NativeFieldInfoPtr_WeightMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "WeightMovement");
		WeightMovementData.NativeFieldInfoPtr_NormalizedWeightMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, "NormalizedWeightMovement");
		WeightMovementData.NativeMethodInfoPtr_SetupSpeedComparisonValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, 100666625);
		WeightMovementData.NativeMethodInfoPtr_SetupUIValues_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, 100666626);
		WeightMovementData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr, 100666627);
	}

	// Token: 0x06002BE3 RID: 11235 RVA: 0x000AD628 File Offset: 0x000AB828
	public WeightMovementData(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000FA9 RID: 4009
	// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000AD631 File Offset: 0x000AB831
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeightMovementData>.NativeClassPtr));
		}
	}

	// Token: 0x17000FAA RID: 4010
	// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x000AD644 File Offset: 0x000AB844
	// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x000AD66C File Offset: 0x000AB86C
	public unsafe WeightClass WeightClass
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeightClass);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeightClass)) = value;
		}
	}

	// Token: 0x17000FAB RID: 4011
	// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000AD690 File Offset: 0x000AB890
	// (set) Token: 0x06002BE8 RID: 11240 RVA: 0x000AD6B8 File Offset: 0x000AB8B8
	public unsafe float BaseSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_BaseSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_BaseSpeed)) = value;
		}
	}

	// Token: 0x17000FAC RID: 4012
	// (get) Token: 0x06002BE9 RID: 11241 RVA: 0x000AD6DC File Offset: 0x000AB8DC
	// (set) Token: 0x06002BEA RID: 11242 RVA: 0x000AD704 File Offset: 0x000AB904
	public unsafe float SprintModifier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_SprintModifier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_SprintModifier)) = value;
		}
	}

	// Token: 0x17000FAD RID: 4013
	// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000AD728 File Offset: 0x000AB928
	// (set) Token: 0x06002BEC RID: 11244 RVA: 0x000AD750 File Offset: 0x000AB950
	public unsafe float FastWalkingMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_FastWalkingMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_FastWalkingMultiplier)) = value;
		}
	}

	// Token: 0x17000FAE RID: 4014
	// (get) Token: 0x06002BED RID: 11245 RVA: 0x000AD774 File Offset: 0x000AB974
	// (set) Token: 0x06002BEE RID: 11246 RVA: 0x000AD79C File Offset: 0x000AB99C
	public unsafe float WalkingMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WalkingMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WalkingMultiplier)) = value;
		}
	}

	// Token: 0x17000FAF RID: 4015
	// (get) Token: 0x06002BEF RID: 11247 RVA: 0x000AD7C0 File Offset: 0x000AB9C0
	// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x000AD7E8 File Offset: 0x000AB9E8
	public unsafe float ProneMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_ProneMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_ProneMultiplier)) = value;
		}
	}

	// Token: 0x17000FB0 RID: 4016
	// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000AD80C File Offset: 0x000ABA0C
	// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x000AD834 File Offset: 0x000ABA34
	public unsafe float CrouchMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_CrouchMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_CrouchMultiplier)) = value;
		}
	}

	// Token: 0x17000FB1 RID: 4017
	// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000AD858 File Offset: 0x000ABA58
	// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x000AD880 File Offset: 0x000ABA80
	public unsafe float GunHeightMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_GunHeightMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_GunHeightMultiplier)) = value;
		}
	}

	// Token: 0x17000FB2 RID: 4018
	// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
	// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x000AD8CC File Offset: 0x000ABACC
	public unsafe float PistolHeightMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_PistolHeightMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_PistolHeightMultiplier)) = value;
		}
	}

	// Token: 0x17000FB3 RID: 4019
	// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000AD8F0 File Offset: 0x000ABAF0
	// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x000AD918 File Offset: 0x000ABB18
	public unsafe float ForwardMovementLimit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_ForwardMovementLimit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_ForwardMovementLimit)) = value;
		}
	}

	// Token: 0x17000FB4 RID: 4020
	// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000AD93C File Offset: 0x000ABB3C
	// (set) Token: 0x06002BFA RID: 11258 RVA: 0x000AD964 File Offset: 0x000ABB64
	public unsafe float StrafeMovementLimit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_StrafeMovementLimit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_StrafeMovementLimit)) = value;
		}
	}

	// Token: 0x17000FB5 RID: 4021
	// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000AD988 File Offset: 0x000ABB88
	// (set) Token: 0x06002BFC RID: 11260 RVA: 0x000AD9B0 File Offset: 0x000ABBB0
	public unsafe float WeaponAngle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeaponAngle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeaponAngle)) = value;
		}
	}

	// Token: 0x17000FB6 RID: 4022
	// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000AD9D4 File Offset: 0x000ABBD4
	// (set) Token: 0x06002BFE RID: 11262 RVA: 0x000AD9FC File Offset: 0x000ABBFC
	public unsafe float WeaponAngleUp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeaponAngleUp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeaponAngleUp)) = value;
		}
	}

	// Token: 0x17000FB7 RID: 4023
	// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000ADA20 File Offset: 0x000ABC20
	// (set) Token: 0x06002C00 RID: 11264 RVA: 0x000ADA48 File Offset: 0x000ABC48
	public unsafe float StrafeSpeedMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_StrafeSpeedMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_StrafeSpeedMultiplier)) = value;
		}
	}

	// Token: 0x17000FB8 RID: 4024
	// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000ADA6C File Offset: 0x000ABC6C
	// (set) Token: 0x06002C02 RID: 11266 RVA: 0x000ADA94 File Offset: 0x000ABC94
	public unsafe float BackwardSpeedMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_BackwardSpeedMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_BackwardSpeedMultiplier)) = value;
		}
	}

	// Token: 0x17000FB9 RID: 4025
	// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000ADAB8 File Offset: 0x000ABCB8
	// (set) Token: 0x06002C04 RID: 11268 RVA: 0x000ADAE0 File Offset: 0x000ABCE0
	public unsafe float MidStrafeSpeedMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_MidStrafeSpeedMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_MidStrafeSpeedMultiplier)) = value;
		}
	}

	// Token: 0x17000FBA RID: 4026
	// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000ADB04 File Offset: 0x000ABD04
	// (set) Token: 0x06002C06 RID: 11270 RVA: 0x000ADB2C File Offset: 0x000ABD2C
	public unsafe bool IsUsingInertia
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_IsUsingInertia);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_IsUsingInertia)) = value;
		}
	}

	// Token: 0x17000FBB RID: 4027
	// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000ADB50 File Offset: 0x000ABD50
	// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000ADB78 File Offset: 0x000ABD78
	public unsafe float InertiaMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_InertiaMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_InertiaMultiplier)) = value;
		}
	}

	// Token: 0x17000FBC RID: 4028
	// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000ADB9C File Offset: 0x000ABD9C
	// (set) Token: 0x06002C0A RID: 11274 RVA: 0x000ADBC4 File Offset: 0x000ABDC4
	public unsafe float WeightMovement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeightMovement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_WeightMovement)) = value;
		}
	}

	// Token: 0x17000FBD RID: 4029
	// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000ADBE8 File Offset: 0x000ABDE8
	// (set) Token: 0x06002C0C RID: 11276 RVA: 0x000ADC10 File Offset: 0x000ABE10
	public unsafe float NormalizedWeightMovement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_NormalizedWeightMovement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeightMovementData.NativeFieldInfoPtr_NormalizedWeightMovement)) = value;
		}
	}

	// Token: 0x04001BF3 RID: 7155
	private static readonly IntPtr NativeFieldInfoPtr_WeightClass;

	// Token: 0x04001BF4 RID: 7156
	private static readonly IntPtr NativeFieldInfoPtr_BaseSpeed;

	// Token: 0x04001BF5 RID: 7157
	private static readonly IntPtr NativeFieldInfoPtr_SprintModifier;

	// Token: 0x04001BF6 RID: 7158
	private static readonly IntPtr NativeFieldInfoPtr_FastWalkingMultiplier;

	// Token: 0x04001BF7 RID: 7159
	private static readonly IntPtr NativeFieldInfoPtr_WalkingMultiplier;

	// Token: 0x04001BF8 RID: 7160
	private static readonly IntPtr NativeFieldInfoPtr_ProneMultiplier;

	// Token: 0x04001BF9 RID: 7161
	private static readonly IntPtr NativeFieldInfoPtr_CrouchMultiplier;

	// Token: 0x04001BFA RID: 7162
	private static readonly IntPtr NativeFieldInfoPtr_GunHeightMultiplier;

	// Token: 0x04001BFB RID: 7163
	private static readonly IntPtr NativeFieldInfoPtr_PistolHeightMultiplier;

	// Token: 0x04001BFC RID: 7164
	private static readonly IntPtr NativeFieldInfoPtr_ForwardMovementLimit;

	// Token: 0x04001BFD RID: 7165
	private static readonly IntPtr NativeFieldInfoPtr_StrafeMovementLimit;

	// Token: 0x04001BFE RID: 7166
	private static readonly IntPtr NativeFieldInfoPtr_WeaponAngle;

	// Token: 0x04001BFF RID: 7167
	private static readonly IntPtr NativeFieldInfoPtr_WeaponAngleUp;

	// Token: 0x04001C00 RID: 7168
	private static readonly IntPtr NativeFieldInfoPtr_StrafeSpeedMultiplier;

	// Token: 0x04001C01 RID: 7169
	private static readonly IntPtr NativeFieldInfoPtr_BackwardSpeedMultiplier;

	// Token: 0x04001C02 RID: 7170
	private static readonly IntPtr NativeFieldInfoPtr_MidStrafeSpeedMultiplier;

	// Token: 0x04001C03 RID: 7171
	private static readonly IntPtr NativeFieldInfoPtr_IsUsingInertia;

	// Token: 0x04001C04 RID: 7172
	private static readonly IntPtr NativeFieldInfoPtr_InertiaMultiplier;

	// Token: 0x04001C05 RID: 7173
	private static readonly IntPtr NativeFieldInfoPtr_WeightMovement;

	// Token: 0x04001C06 RID: 7174
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedWeightMovement;

	// Token: 0x04001C07 RID: 7175
	private static readonly IntPtr NativeMethodInfoPtr_SetupSpeedComparisonValue_Public_Void_0;

	// Token: 0x04001C08 RID: 7176
	private static readonly IntPtr NativeMethodInfoPtr_SetupUIValues_Public_Static_Void_0;

	// Token: 0x04001C09 RID: 7177
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
