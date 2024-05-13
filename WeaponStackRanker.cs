using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FD2 RID: 4050
	public class WeaponStackRanker : Object
	{
		// Token: 0x06013703 RID: 79619 RVA: 0x004E3BB4 File Offset: 0x004E1DB4
		[CallerCount(0)]
		public unsafe WeaponStackRanker(Il2CppReferenceArray<WeaponSO> allWeapons, Il2CppReferenceArray<ClassLoadout> allClassLoadouts) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(allWeapons);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allClassLoadouts);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_WeaponSO_ArrayOf_ClassLoadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013704 RID: 79620 RVA: 0x004E3C30 File Offset: 0x004E1E30
		[CallerCount(0)]
		public unsafe void SortByRanking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_SortByRanking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013705 RID: 79621 RVA: 0x004E3C74 File Offset: 0x004E1E74
		[CallerCount(0)]
		public unsafe void CacheAllValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_CacheAllValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013706 RID: 79622 RVA: 0x004E3CB8 File Offset: 0x004E1EB8
		[CallerCount(0)]
		public unsafe void CacheValues<T>(Dictionary<WeaponSO, int> dictionary, Comparison<T> comparison)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparison);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.MethodInfoStoreGeneric_CacheValues_Private_Void_Dictionary_2_WeaponSO_Int32_Comparison_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013707 RID: 79623 RVA: 0x004E3D2C File Offset: 0x004E1F2C
		[CallerCount(0)]
		public unsafe int GetBaseScore(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetBaseScore_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013708 RID: 79624 RVA: 0x004E3D94 File Offset: 0x004E1F94
		[CallerCount(0)]
		public unsafe int GetSpammability(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetSpammability_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013709 RID: 79625 RVA: 0x004E3DFC File Offset: 0x004E1FFC
		[CallerCount(0)]
		public unsafe int GetHandling(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetHandling_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370A RID: 79626 RVA: 0x004E3E64 File Offset: 0x004E2064
		[CallerCount(0)]
		public unsafe int GetDamage(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetDamage_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370B RID: 79627 RVA: 0x004E3ECC File Offset: 0x004E20CC
		[CallerCount(0)]
		public unsafe bool GetSupportsForegrip(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetSupportsForegrip_Private_Boolean_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370C RID: 79628 RVA: 0x004E3F34 File Offset: 0x004E2134
		[CallerCount(0)]
		public unsafe int GetPointCost(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetPointCost_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370D RID: 79629 RVA: 0x004E3F9C File Offset: 0x004E219C
		[CallerCount(0)]
		public unsafe float AverageRecoil(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_AverageRecoil_Private_Single_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370E RID: 79630 RVA: 0x004E4004 File Offset: 0x004E2204
		[CallerCount(0)]
		public unsafe float GetSecondScore(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetSecondScore_Private_Single_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601370F RID: 79631 RVA: 0x004E406C File Offset: 0x004E226C
		[CallerCount(0)]
		public unsafe float GetFourthScore(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr_GetFourthScore_Private_Single_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013710 RID: 79632 RVA: 0x004E40D4 File Offset: 0x004E22D4
		[CallerCount(0)]
		public unsafe int _SortByRanking_b__9_0(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_0_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013711 RID: 79633 RVA: 0x004E413C File Offset: 0x004E233C
		[CallerCount(0)]
		public unsafe float _SortByRanking_b__9_1(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_1_Private_Single_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013712 RID: 79634 RVA: 0x004E41A4 File Offset: 0x004E23A4
		[CallerCount(0)]
		public unsafe int _SortByRanking_b__9_2(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_2_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013713 RID: 79635 RVA: 0x004E420C File Offset: 0x004E240C
		[CallerCount(0)]
		public unsafe float _SortByRanking_b__9_3(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_3_Private_Single_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013714 RID: 79636 RVA: 0x004E4274 File Offset: 0x004E2474
		[CallerCount(0)]
		public unsafe int _SortByRanking_b__9_4(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_4_Private_Int32_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013715 RID: 79637 RVA: 0x004E42DC File Offset: 0x004E24DC
		[CallerCount(0)]
		public unsafe int _CacheAllValues_b__10_4(WeaponSO a, WeaponSO b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.NativeMethodInfoPtr__CacheAllValues_b__10_4_Private_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013716 RID: 79638 RVA: 0x004E435C File Offset: 0x004E255C
		// Note: this type is marked as 'beforefieldinit'.
		static WeaponStackRanker()
		{
			Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "WeaponStackRanker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr);
			WeaponStackRanker.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "Output");
			WeaponStackRanker.NativeFieldInfoPtr__allWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_allWeapons");
			WeaponStackRanker.NativeFieldInfoPtr__allClassLoadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_allClassLoadouts");
			WeaponStackRanker.NativeFieldInfoPtr__scoreFireRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_scoreFireRate");
			WeaponStackRanker.NativeFieldInfoPtr__scoreMagazineCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_scoreMagazineCapacity");
			WeaponStackRanker.NativeFieldInfoPtr__scoreRecoil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_scoreRecoil");
			WeaponStackRanker.NativeFieldInfoPtr__scoreRecoilRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_scoreRecoilRecovery");
			WeaponStackRanker.NativeFieldInfoPtr__scoreDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "_scoreDamage");
			WeaponStackRanker.NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_WeaponSO_ArrayOf_ClassLoadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688087);
			WeaponStackRanker.NativeMethodInfoPtr_SortByRanking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688088);
			WeaponStackRanker.NativeMethodInfoPtr_CacheAllValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688089);
			WeaponStackRanker.NativeMethodInfoPtr_CacheValues_Private_Void_Dictionary_2_WeaponSO_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688090);
			WeaponStackRanker.NativeMethodInfoPtr_GetBaseScore_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688091);
			WeaponStackRanker.NativeMethodInfoPtr_GetSpammability_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688092);
			WeaponStackRanker.NativeMethodInfoPtr_GetHandling_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688093);
			WeaponStackRanker.NativeMethodInfoPtr_GetDamage_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688094);
			WeaponStackRanker.NativeMethodInfoPtr_GetSupportsForegrip_Private_Boolean_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688095);
			WeaponStackRanker.NativeMethodInfoPtr_GetPointCost_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688096);
			WeaponStackRanker.NativeMethodInfoPtr_AverageRecoil_Private_Single_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688097);
			WeaponStackRanker.NativeMethodInfoPtr_GetSecondScore_Private_Single_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688098);
			WeaponStackRanker.NativeMethodInfoPtr_GetFourthScore_Private_Single_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688099);
			WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_0_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688100);
			WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_1_Private_Single_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688101);
			WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_2_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688102);
			WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_3_Private_Single_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688103);
			WeaponStackRanker.NativeMethodInfoPtr__SortByRanking_b__9_4_Private_Int32_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688104);
			WeaponStackRanker.NativeMethodInfoPtr__CacheAllValues_b__10_4_Private_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, 100688105);
		}

		// Token: 0x06013717 RID: 79639 RVA: 0x00002988 File Offset: 0x00000B88
		public WeaponStackRanker(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E46 RID: 28230
		// (get) Token: 0x06013718 RID: 79640 RVA: 0x004E45A8 File Offset: 0x004E27A8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr));
			}
		}

		// Token: 0x17006E47 RID: 28231
		// (get) Token: 0x06013719 RID: 79641 RVA: 0x004E45BC File Offset: 0x004E27BC
		// (set) Token: 0x0601371A RID: 79642 RVA: 0x004E45F0 File Offset: 0x004E27F0
		public unsafe Il2CppReferenceArray<WeaponSO> Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<WeaponSO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E48 RID: 28232
		// (get) Token: 0x0601371B RID: 79643 RVA: 0x004E4618 File Offset: 0x004E2818
		// (set) Token: 0x0601371C RID: 79644 RVA: 0x004E464C File Offset: 0x004E284C
		public unsafe Il2CppReferenceArray<WeaponSO> _allWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__allWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<WeaponSO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__allWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E49 RID: 28233
		// (get) Token: 0x0601371D RID: 79645 RVA: 0x004E4674 File Offset: 0x004E2874
		// (set) Token: 0x0601371E RID: 79646 RVA: 0x004E46A8 File Offset: 0x004E28A8
		public unsafe Il2CppReferenceArray<ClassLoadout> _allClassLoadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__allClassLoadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ClassLoadout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__allClassLoadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E4A RID: 28234
		// (get) Token: 0x0601371F RID: 79647 RVA: 0x004E46D0 File Offset: 0x004E28D0
		// (set) Token: 0x06013720 RID: 79648 RVA: 0x004E4704 File Offset: 0x004E2904
		public unsafe Dictionary<WeaponSO, int> _scoreFireRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreFireRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreFireRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x06013721 RID: 79649 RVA: 0x004E472C File Offset: 0x004E292C
		// (set) Token: 0x06013722 RID: 79650 RVA: 0x004E4760 File Offset: 0x004E2960
		public unsafe Dictionary<WeaponSO, int> _scoreMagazineCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreMagazineCapacity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreMagazineCapacity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x06013723 RID: 79651 RVA: 0x004E4788 File Offset: 0x004E2988
		// (set) Token: 0x06013724 RID: 79652 RVA: 0x004E47BC File Offset: 0x004E29BC
		public unsafe Dictionary<WeaponSO, int> _scoreRecoil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreRecoil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreRecoil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x06013725 RID: 79653 RVA: 0x004E47E4 File Offset: 0x004E29E4
		// (set) Token: 0x06013726 RID: 79654 RVA: 0x004E4818 File Offset: 0x004E2A18
		public unsafe Dictionary<WeaponSO, int> _scoreRecoilRecovery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreRecoilRecovery);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreRecoilRecovery), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x06013727 RID: 79655 RVA: 0x004E4840 File Offset: 0x004E2A40
		// (set) Token: 0x06013728 RID: 79656 RVA: 0x004E4874 File Offset: 0x004E2A74
		public unsafe Dictionary<WeaponSO, int> _scoreDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreDamage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponStackRanker.NativeFieldInfoPtr__scoreDamage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6C3 RID: 50883
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x0400C6C4 RID: 50884
		private static readonly IntPtr NativeFieldInfoPtr__allWeapons;

		// Token: 0x0400C6C5 RID: 50885
		private static readonly IntPtr NativeFieldInfoPtr__allClassLoadouts;

		// Token: 0x0400C6C6 RID: 50886
		private static readonly IntPtr NativeFieldInfoPtr__scoreFireRate;

		// Token: 0x0400C6C7 RID: 50887
		private static readonly IntPtr NativeFieldInfoPtr__scoreMagazineCapacity;

		// Token: 0x0400C6C8 RID: 50888
		private static readonly IntPtr NativeFieldInfoPtr__scoreRecoil;

		// Token: 0x0400C6C9 RID: 50889
		private static readonly IntPtr NativeFieldInfoPtr__scoreRecoilRecovery;

		// Token: 0x0400C6CA RID: 50890
		private static readonly IntPtr NativeFieldInfoPtr__scoreDamage;

		// Token: 0x0400C6CB RID: 50891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayOf_WeaponSO_ArrayOf_ClassLoadout_0;

		// Token: 0x0400C6CC RID: 50892
		private static readonly IntPtr NativeMethodInfoPtr_SortByRanking_Private_Void_0;

		// Token: 0x0400C6CD RID: 50893
		private static readonly IntPtr NativeMethodInfoPtr_CacheAllValues_Private_Void_0;

		// Token: 0x0400C6CE RID: 50894
		private static readonly IntPtr NativeMethodInfoPtr_CacheValues_Private_Void_Dictionary_2_WeaponSO_Int32_Comparison_1_T_0;

		// Token: 0x0400C6CF RID: 50895
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseScore_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D0 RID: 50896
		private static readonly IntPtr NativeMethodInfoPtr_GetSpammability_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D1 RID: 50897
		private static readonly IntPtr NativeMethodInfoPtr_GetHandling_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D2 RID: 50898
		private static readonly IntPtr NativeMethodInfoPtr_GetDamage_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D3 RID: 50899
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportsForegrip_Private_Boolean_WeaponSO_0;

		// Token: 0x0400C6D4 RID: 50900
		private static readonly IntPtr NativeMethodInfoPtr_GetPointCost_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D5 RID: 50901
		private static readonly IntPtr NativeMethodInfoPtr_AverageRecoil_Private_Single_WeaponSO_0;

		// Token: 0x0400C6D6 RID: 50902
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondScore_Private_Single_WeaponSO_0;

		// Token: 0x0400C6D7 RID: 50903
		private static readonly IntPtr NativeMethodInfoPtr_GetFourthScore_Private_Single_WeaponSO_0;

		// Token: 0x0400C6D8 RID: 50904
		private static readonly IntPtr NativeMethodInfoPtr__SortByRanking_b__9_0_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6D9 RID: 50905
		private static readonly IntPtr NativeMethodInfoPtr__SortByRanking_b__9_1_Private_Single_WeaponSO_0;

		// Token: 0x0400C6DA RID: 50906
		private static readonly IntPtr NativeMethodInfoPtr__SortByRanking_b__9_2_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6DB RID: 50907
		private static readonly IntPtr NativeMethodInfoPtr__SortByRanking_b__9_3_Private_Single_WeaponSO_0;

		// Token: 0x0400C6DC RID: 50908
		private static readonly IntPtr NativeMethodInfoPtr__SortByRanking_b__9_4_Private_Int32_WeaponSO_0;

		// Token: 0x0400C6DD RID: 50909
		private static readonly IntPtr NativeMethodInfoPtr__CacheAllValues_b__10_4_Private_Int32_WeaponSO_WeaponSO_0;

		// Token: 0x02000FD3 RID: 4051
		[ObfuscatedName("DPI.GameVariants.GunGame.WeaponStackRanker/<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06013729 RID: 79657 RVA: 0x004E489C File Offset: 0x004E2A9C
			[CallerCount(0)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601372A RID: 79658 RVA: 0x004E48E8 File Offset: 0x004E2AE8
			[CallerCount(0)]
			public unsafe int _CacheAllValues_b__10_0(WeaponSO a, WeaponSO b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_0_Internal_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0601372B RID: 79659 RVA: 0x004E4968 File Offset: 0x004E2B68
			[CallerCount(0)]
			public unsafe int _CacheAllValues_b__10_1(WeaponSO a, WeaponSO b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_1_Internal_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0601372C RID: 79660 RVA: 0x004E49E8 File Offset: 0x004E2BE8
			[CallerCount(0)]
			public unsafe int _CacheAllValues_b__10_2(WeaponSO a, WeaponSO b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_2_Internal_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0601372D RID: 79661 RVA: 0x004E4A68 File Offset: 0x004E2C68
			[CallerCount(0)]
			public unsafe int _CacheAllValues_b__10_3(WeaponSO a, WeaponSO b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_3_Internal_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0601372E RID: 79662 RVA: 0x004E4AE8 File Offset: 0x004E2CE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr);
				WeaponStackRanker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, "<>9");
				WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, "<>9__10_0");
				WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, "<>9__10_1");
				WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, "<>9__10_2");
				WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, "<>9__10_3");
				WeaponStackRanker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, 100688107);
				WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_0_Internal_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, 100688108);
				WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_1_Internal_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, 100688109);
				WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_2_Internal_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, 100688110);
				WeaponStackRanker.__c.NativeMethodInfoPtr__CacheAllValues_b__10_3_Internal_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr, 100688111);
			}

			// Token: 0x0601372F RID: 79663 RVA: 0x00002988 File Offset: 0x00000B88
			public __c(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17006E4F RID: 28239
			// (get) Token: 0x06013730 RID: 79664 RVA: 0x004E4BDB File Offset: 0x004E2DDB
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponStackRanker.__c>.NativeClassPtr));
				}
			}

			// Token: 0x17006E50 RID: 28240
			// (get) Token: 0x06013731 RID: 79665 RVA: 0x004E4BEC File Offset: 0x004E2DEC
			// (set) Token: 0x06013732 RID: 79666 RVA: 0x004E4C17 File Offset: 0x004E2E17
			public unsafe static WeaponStackRanker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new WeaponStackRanker.__c(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E51 RID: 28241
			// (get) Token: 0x06013733 RID: 79667 RVA: 0x004E4C2C File Offset: 0x004E2E2C
			// (set) Token: 0x06013734 RID: 79668 RVA: 0x004E4C57 File Offset: 0x004E2E57
			public unsafe static Comparison<WeaponSO> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Comparison<WeaponSO>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E52 RID: 28242
			// (get) Token: 0x06013735 RID: 79669 RVA: 0x004E4C6C File Offset: 0x004E2E6C
			// (set) Token: 0x06013736 RID: 79670 RVA: 0x004E4C97 File Offset: 0x004E2E97
			public unsafe static Comparison<WeaponSO> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Comparison<WeaponSO>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E53 RID: 28243
			// (get) Token: 0x06013737 RID: 79671 RVA: 0x004E4CAC File Offset: 0x004E2EAC
			// (set) Token: 0x06013738 RID: 79672 RVA: 0x004E4CD7 File Offset: 0x004E2ED7
			public unsafe static Comparison<WeaponSO> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Comparison<WeaponSO>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E54 RID: 28244
			// (get) Token: 0x06013739 RID: 79673 RVA: 0x004E4CEC File Offset: 0x004E2EEC
			// (set) Token: 0x0601373A RID: 79674 RVA: 0x004E4D17 File Offset: 0x004E2F17
			public unsafe static Comparison<WeaponSO> __9__10_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Comparison<WeaponSO>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c.NativeFieldInfoPtr___9__10_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400C6DE RID: 50910
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400C6DF RID: 50911
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400C6E0 RID: 50912
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400C6E1 RID: 50913
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x0400C6E2 RID: 50914
			private static readonly IntPtr NativeFieldInfoPtr___9__10_3;

			// Token: 0x0400C6E3 RID: 50915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400C6E4 RID: 50916
			private static readonly IntPtr NativeMethodInfoPtr__CacheAllValues_b__10_0_Internal_Int32_WeaponSO_WeaponSO_0;

			// Token: 0x0400C6E5 RID: 50917
			private static readonly IntPtr NativeMethodInfoPtr__CacheAllValues_b__10_1_Internal_Int32_WeaponSO_WeaponSO_0;

			// Token: 0x0400C6E6 RID: 50918
			private static readonly IntPtr NativeMethodInfoPtr__CacheAllValues_b__10_2_Internal_Int32_WeaponSO_WeaponSO_0;

			// Token: 0x0400C6E7 RID: 50919
			private static readonly IntPtr NativeMethodInfoPtr__CacheAllValues_b__10_3_Internal_Int32_WeaponSO_WeaponSO_0;
		}

		// Token: 0x02000FD4 RID: 4052
		[ObfuscatedName("DPI.GameVariants.GunGame.WeaponStackRanker/<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Object
		{
			// Token: 0x0601373B RID: 79675 RVA: 0x004E4D2C File Offset: 0x004E2F2C
			[CallerCount(0)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601373C RID: 79676 RVA: 0x004E4D78 File Offset: 0x004E2F78
			[CallerCount(0)]
			public unsafe int _CacheValues_b__11_0(WeaponSO a, WeaponSO b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponStackRanker.__c__11<T>.NativeMethodInfoPtr__CacheValues_b__11_0_Internal_Int32_WeaponSO_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0601373D RID: 79677 RVA: 0x004E4DF8 File Offset: 0x004E2FF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr);
				WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr, "<>9");
				WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				WeaponStackRanker.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr, 100688113);
				WeaponStackRanker.__c__11<T>.NativeMethodInfoPtr__CacheValues_b__11_0_Internal_Int32_WeaponSO_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr, 100688114);
			}

			// Token: 0x0601373E RID: 79678 RVA: 0x00002988 File Offset: 0x00000B88
			public __c__11(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17006E55 RID: 28245
			// (get) Token: 0x0601373F RID: 79679 RVA: 0x004E4EAE File Offset: 0x004E30AE
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponStackRanker.__c__11<T>>.NativeClassPtr));
				}
			}

			// Token: 0x17006E56 RID: 28246
			// (get) Token: 0x06013740 RID: 79680 RVA: 0x004E4EC0 File Offset: 0x004E30C0
			// (set) Token: 0x06013741 RID: 79681 RVA: 0x004E4EEB File Offset: 0x004E30EB
			public unsafe static WeaponStackRanker.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new WeaponStackRanker.__c__11<T>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E57 RID: 28247
			// (get) Token: 0x06013742 RID: 79682 RVA: 0x004E4F00 File Offset: 0x004E3100
			// (set) Token: 0x06013743 RID: 79683 RVA: 0x004E4F2B File Offset: 0x004E312B
			public unsafe static Comparison<WeaponSO> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Comparison<WeaponSO>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeaponStackRanker.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400C6E8 RID: 50920
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400C6E9 RID: 50921
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400C6EA RID: 50922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400C6EB RID: 50923
			private static readonly IntPtr NativeMethodInfoPtr__CacheValues_b__11_0_Internal_Int32_WeaponSO_WeaponSO_0;
		}

		// Token: 0x02000FD5 RID: 4053
		private sealed class MethodInfoStoreGeneric_CacheValues_Private_Void_Dictionary_2_WeaponSO_Int32_Comparison_1_T_0<T>
		{
			// Token: 0x0400C6EC RID: 50924
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WeaponStackRanker.NativeMethodInfoPtr_CacheValues_Private_Void_Dictionary_2_WeaponSO_Int32_Comparison_1_T_0, Il2CppClassPointerStore<WeaponStackRanker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
