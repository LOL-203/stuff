using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward.GameVariants;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FC3 RID: 4035
	public class GunGameLoadoutDatabase : MonoBehaviour
	{
		// Token: 0x060135D7 RID: 79319 RVA: 0x004DF3A0 File Offset: 0x004DD5A0
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135D8 RID: 79320 RVA: 0x004DF3E4 File Offset: 0x004DD5E4
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135D9 RID: 79321 RVA: 0x004DF428 File Offset: 0x004DD628
		[CallerCount(0)]
		public unsafe void EnteringLoadingScreen(OnwardMap map)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref map;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_EnteringLoadingScreen_Private_Void_OnwardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135DA RID: 79322 RVA: 0x004DF47C File Offset: 0x004DD67C
		[CallerCount(0)]
		public unsafe bool TryGetHashedLoadouts(int hash, out Il2CppReferenceArray<ProceduralLoadout> loadouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hash;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(loadouts);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_TryGetHashedLoadouts_Public_Boolean_Int32_byref_ArrayOf_ProceduralLoadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			loadouts = ((intPtr2 == 0) ? null : new Il2CppReferenceArray(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060135DB RID: 79323 RVA: 0x004DF518 File Offset: 0x004DD718
		[CallerCount(0)]
		public unsafe void SetGameVariant(GameVariantTypes newVariant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVariant;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_SetGameVariant_Private_Void_GameVariantTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135DC RID: 79324 RVA: 0x004DF56C File Offset: 0x004DD76C
		[CallerCount(0)]
		public unsafe void OnGunGameStreakStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_OnGunGameStreakStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135DD RID: 79325 RVA: 0x004DF5B0 File Offset: 0x004DD7B0
		[CallerCount(0)]
		public unsafe void OnGunGameStreakEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_OnGunGameStreakEnded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135DE RID: 79326 RVA: 0x004DF5F4 File Offset: 0x004DD7F4
		[CallerCount(0)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_Load_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135DF RID: 79327 RVA: 0x004DF638 File Offset: 0x004DD838
		[CallerCount(0)]
		public unsafe void Unload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_Unload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135E0 RID: 79328 RVA: 0x004DF67C File Offset: 0x004DD87C
		[CallerCount(0)]
		public unsafe void OnDataLoaded(AsyncOperationHandle<ProceduralLoadoutData> handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_OnDataLoaded_Private_Void_AsyncOperationHandle_1_ProceduralLoadoutData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135E1 RID: 79329 RVA: 0x004DF6DC File Offset: 0x004DD8DC
		[CallerCount(0)]
		public unsafe void ClearData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr_ClearData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135E2 RID: 79330 RVA: 0x004DF720 File Offset: 0x004DD920
		[CallerCount(0)]
		public unsafe GunGameLoadoutDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135E3 RID: 79331 RVA: 0x004DF76C File Offset: 0x004DD96C
		// Note: this type is marked as 'beforefieldinit'.
		static GunGameLoadoutDatabase()
		{
			Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "GunGameLoadoutDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr);
			GunGameLoadoutDatabase.NativeFieldInfoPtr_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "Singleton");
			GunGameLoadoutDatabase.NativeFieldInfoPtr_DataReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "DataReference");
			GunGameLoadoutDatabase.NativeFieldInfoPtr__dataHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "_dataHandle");
			GunGameLoadoutDatabase.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "_data");
			GunGameLoadoutDatabase.NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "_cache");
			GunGameLoadoutDatabase.NativeFieldInfoPtr__currentVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, "_currentVariant");
			GunGameLoadoutDatabase.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688021);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688022);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_EnteringLoadingScreen_Private_Void_OnwardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688023);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_TryGetHashedLoadouts_Public_Boolean_Int32_byref_ArrayOf_ProceduralLoadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688024);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_SetGameVariant_Private_Void_GameVariantTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688025);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_OnGunGameStreakStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688026);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_OnGunGameStreakEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688027);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_Load_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688028);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_Unload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688029);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_OnDataLoaded_Private_Void_AsyncOperationHandle_1_ProceduralLoadoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688030);
			GunGameLoadoutDatabase.NativeMethodInfoPtr_ClearData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688031);
			GunGameLoadoutDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr, 100688032);
		}

		// Token: 0x060135E4 RID: 79332 RVA: 0x0000210C File Offset: 0x0000030C
		public GunGameLoadoutDatabase(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x060135E5 RID: 79333 RVA: 0x004DF904 File Offset: 0x004DDB04
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutDatabase>.NativeClassPtr));
			}
		}

		// Token: 0x17006DCD RID: 28109
		// (get) Token: 0x060135E6 RID: 79334 RVA: 0x004DF918 File Offset: 0x004DDB18
		// (set) Token: 0x060135E7 RID: 79335 RVA: 0x004DF943 File Offset: 0x004DDB43
		public unsafe static GunGameLoadoutDatabase Singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GunGameLoadoutDatabase.NativeFieldInfoPtr_Singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new GunGameLoadoutDatabase(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunGameLoadoutDatabase.NativeFieldInfoPtr_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DCE RID: 28110
		// (get) Token: 0x060135E8 RID: 79336 RVA: 0x004DF958 File Offset: 0x004DDB58
		// (set) Token: 0x060135E9 RID: 79337 RVA: 0x004DF98C File Offset: 0x004DDB8C
		public unsafe AssetReference DataReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr_DataReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AssetReference(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr_DataReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DCF RID: 28111
		// (get) Token: 0x060135EA RID: 79338 RVA: 0x004DF9B4 File Offset: 0x004DDBB4
		// (set) Token: 0x060135EB RID: 79339 RVA: 0x004DF9E6 File Offset: 0x004DDBE6
		public AsyncOperationHandle<ProceduralLoadoutData> _dataHandle
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__dataHandle);
				return new AsyncOperationHandle<ProceduralLoadoutData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<ProceduralLoadoutData>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__dataHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<ProceduralLoadoutData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17006DD0 RID: 28112
		// (get) Token: 0x060135EC RID: 79340 RVA: 0x004DFA1C File Offset: 0x004DDC1C
		// (set) Token: 0x060135ED RID: 79341 RVA: 0x004DFA50 File Offset: 0x004DDC50
		public unsafe ProceduralLoadoutData _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ProceduralLoadoutData(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DD1 RID: 28113
		// (get) Token: 0x060135EE RID: 79342 RVA: 0x004DFA78 File Offset: 0x004DDC78
		// (set) Token: 0x060135EF RID: 79343 RVA: 0x004DFAAC File Offset: 0x004DDCAC
		public unsafe Dictionary<int, Il2CppReferenceArray<ProceduralLoadout>> _cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<int, Il2CppReferenceArray<ProceduralLoadout>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DD2 RID: 28114
		// (get) Token: 0x060135F0 RID: 79344 RVA: 0x004DFAD4 File Offset: 0x004DDCD4
		// (set) Token: 0x060135F1 RID: 79345 RVA: 0x004DFAFC File Offset: 0x004DDCFC
		public unsafe GameVariantTypes _currentVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__currentVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutDatabase.NativeFieldInfoPtr__currentVariant)) = value;
			}
		}

		// Token: 0x0400C61F RID: 50719
		private static readonly IntPtr NativeFieldInfoPtr_Singleton;

		// Token: 0x0400C620 RID: 50720
		private static readonly IntPtr NativeFieldInfoPtr_DataReference;

		// Token: 0x0400C621 RID: 50721
		private static readonly IntPtr NativeFieldInfoPtr__dataHandle;

		// Token: 0x0400C622 RID: 50722
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x0400C623 RID: 50723
		private static readonly IntPtr NativeFieldInfoPtr__cache;

		// Token: 0x0400C624 RID: 50724
		private static readonly IntPtr NativeFieldInfoPtr__currentVariant;

		// Token: 0x0400C625 RID: 50725
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400C626 RID: 50726
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400C627 RID: 50727
		private static readonly IntPtr NativeMethodInfoPtr_EnteringLoadingScreen_Private_Void_OnwardMap_0;

		// Token: 0x0400C628 RID: 50728
		private static readonly IntPtr NativeMethodInfoPtr_TryGetHashedLoadouts_Public_Boolean_Int32_byref_ArrayOf_ProceduralLoadout_0;

		// Token: 0x0400C629 RID: 50729
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVariant_Private_Void_GameVariantTypes_0;

		// Token: 0x0400C62A RID: 50730
		private static readonly IntPtr NativeMethodInfoPtr_OnGunGameStreakStarted_Private_Void_0;

		// Token: 0x0400C62B RID: 50731
		private static readonly IntPtr NativeMethodInfoPtr_OnGunGameStreakEnded_Private_Void_0;

		// Token: 0x0400C62C RID: 50732
		private static readonly IntPtr NativeMethodInfoPtr_Load_Private_Void_0;

		// Token: 0x0400C62D RID: 50733
		private static readonly IntPtr NativeMethodInfoPtr_Unload_Private_Void_0;

		// Token: 0x0400C62E RID: 50734
		private static readonly IntPtr NativeMethodInfoPtr_OnDataLoaded_Private_Void_AsyncOperationHandle_1_ProceduralLoadoutData_0;

		// Token: 0x0400C62F RID: 50735
		private static readonly IntPtr NativeMethodInfoPtr_ClearData_Private_Void_0;

		// Token: 0x0400C630 RID: 50736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
