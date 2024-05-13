using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FC4 RID: 4036
	public class GunGameLoadoutOptions : ScriptableObject
	{
		// Token: 0x17006DE9 RID: 28137
		// (get) Token: 0x060135F2 RID: 79346 RVA: 0x004DFB20 File Offset: 0x004DDD20
		public unsafe GunGameProgressionType CurrentProgressionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentProgressionType_Public_get_GunGameProgressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new GunGameProgressionType(intPtr2) : null;
			}
		}

		// Token: 0x17006DEA RID: 28138
		// (get) Token: 0x060135F3 RID: 79347 RVA: 0x004DFB78 File Offset: 0x004DDD78
		public unsafe GunGameEquipmentOption CurrentEquipmentOption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentEquipmentOption_Public_get_GunGameEquipmentOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new GunGameEquipmentOption(intPtr2) : null;
			}
		}

		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x060135F4 RID: 79348 RVA: 0x004DFBD0 File Offset: 0x004DDDD0
		public unsafe int CurrentStageCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentStageCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x060135F5 RID: 79349 RVA: 0x004DFC20 File Offset: 0x004DDE20
		// (set) Token: 0x060135F6 RID: 79350 RVA: 0x004DFC70 File Offset: 0x004DDE70
		public unsafe int CurrentProgressionTypeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentProgressionTypeIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentProgressionTypeIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x060135F7 RID: 79351 RVA: 0x004DFCC4 File Offset: 0x004DDEC4
		// (set) Token: 0x060135F8 RID: 79352 RVA: 0x004DFD14 File Offset: 0x004DDF14
		public unsafe int CurrentEquipmentOptionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentEquipmentOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentEquipmentOptionIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x060135F9 RID: 79353 RVA: 0x004DFD68 File Offset: 0x004DDF68
		// (set) Token: 0x060135FA RID: 79354 RVA: 0x004DFDB8 File Offset: 0x004DDFB8
		public unsafe int CurrentStageCountIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentStageCountIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentStageCountIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060135FB RID: 79355 RVA: 0x004DFE0C File Offset: 0x004DE00C
		[CallerCount(0)]
		public unsafe IEnumerator GenerateAllDynamicStages(bool isNight, Il2CppSystem.Random random, Il2CppReferenceArray<Loadout> loadouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isNight;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadouts);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateAllDynamicStages_Private_IEnumerator_Boolean_Random_ArrayOf_Loadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x060135FC RID: 79356 RVA: 0x004DFEA4 File Offset: 0x004DE0A4
		[CallerCount(0)]
		public unsafe IEnumerator GenerateMiddleDynamicStages(int stagesToGenerate, bool isNight, bool equipmentAllowed, bool nonEquipmentAllowed, Il2CppSystem.Random random, Il2CppReferenceArray<Loadout> loadouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stagesToGenerate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref equipmentAllowed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonEquipmentAllowed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadouts);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateMiddleDynamicStages_Private_IEnumerator_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x060135FD RID: 79357 RVA: 0x004DFF78 File Offset: 0x004DE178
		[CallerCount(0)]
		public unsafe IEnumerator ChooseOneLoadout(bool synchronous, int arrayIndex, int stageNumber, int totalStageCount, bool isNight, bool equipmentAllowed, bool nonEquipmentAllowed, Il2CppSystem.Random random, Il2CppReferenceArray<Loadout> loadouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref synchronous;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stageNumber;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalStageCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref equipmentAllowed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonEquipmentAllowed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadouts);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_ChooseOneLoadout_Private_IEnumerator_Boolean_Int32_Int32_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x060135FE RID: 79358 RVA: 0x004E0084 File Offset: 0x004DE284
		[CallerCount(0)]
		public unsafe void AggregateLoadouts(WeaponName weapon, int cost, bool night, bool equipment, ref List<Il2CppReferenceArray<ProceduralLoadout>> working, ref int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weapon;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cost;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref night;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref equipment;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(working);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &total;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_AggregateLoadouts_Private_Void_WeaponName_Int32_Boolean_Boolean_byref_List_1_ArrayOf_ProceduralLoadout_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			working = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x060135FF RID: 79359 RVA: 0x004E0160 File Offset: 0x004DE360
		[CallerCount(0)]
		public unsafe void GenerateStageLoadouts(int seed, bool night, ref Il2CppReferenceArray<Loadout> loadouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref night;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(loadouts);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateStageLoadouts_Public_Void_Int32_Boolean_byref_ArrayOf_Loadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			loadouts = ((intPtr3 == 0) ? null : new Il2CppReferenceArray(intPtr3));
		}

		// Token: 0x06013600 RID: 79360 RVA: 0x004E0200 File Offset: 0x004DE400
		[CallerCount(0)]
		public unsafe int GetCostForStage(float power, float loadoutDeviance, Il2CppSystem.Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadoutDeviance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr_GetCostForStage_Private_Int32_Single_Single_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013601 RID: 79361 RVA: 0x004E0290 File Offset: 0x004DE490
		[CallerCount(0)]
		public unsafe GunGameLoadoutOptions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013602 RID: 79362 RVA: 0x004E02DC File Offset: 0x004DE4DC
		// Note: this type is marked as 'beforefieldinit'.
		static GunGameLoadoutOptions()
		{
			Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "GunGameLoadoutOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr);
			GunGameLoadoutOptions.NativeFieldInfoPtr_FAILURE_EXPANSION_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "FAILURE_EXPANSION_RATE");
			GunGameLoadoutOptions.NativeFieldInfoPtr_MAX_ITERATION_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "MAX_ITERATION_FAILURES");
			GunGameLoadoutOptions.NativeFieldInfoPtr_SourceLoadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "SourceLoadouts");
			GunGameLoadoutOptions.NativeFieldInfoPtr_AllProgressionTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "AllProgressionTypes");
			GunGameLoadoutOptions.NativeFieldInfoPtr_AllStageCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "AllStageCounts");
			GunGameLoadoutOptions.NativeFieldInfoPtr_AllEquipmentOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "AllEquipmentOptions");
			GunGameLoadoutOptions.NativeFieldInfoPtr_GimmickLoadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "GimmickLoadouts");
			GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultProgressionTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "DefaultProgressionTypeIndex");
			GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultStageCountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "DefaultStageCountIndex");
			GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultEquipmentOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "DefaultEquipmentOptionIndex");
			GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultLoadout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "DefaultLoadout");
			GunGameLoadoutOptions.NativeFieldInfoPtr_MinimumLoadoutPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "MinimumLoadoutPoints");
			GunGameLoadoutOptions.NativeFieldInfoPtr_MaximumLoadoutPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "MaximumLoadoutPoints");
			GunGameLoadoutOptions.NativeFieldInfoPtr_AllowanceLoadoutPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "AllowanceLoadoutPoints");
			GunGameLoadoutOptions.NativeFieldInfoPtr_MaxGeneratedCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "MaxGeneratedCost");
			GunGameLoadoutOptions.NativeFieldInfoPtr_WeaponChooser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "WeaponChooser");
			GunGameLoadoutOptions.NativeFieldInfoPtr_workingLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "workingLists");
			GunGameLoadoutOptions.NativeFieldInfoPtr__dynamicCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "_dynamicCoroutine");
			GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentProgressionTypeIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<CurrentProgressionTypeIndex>k__BackingField");
			GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentEquipmentOptionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<CurrentEquipmentOptionIndex>k__BackingField");
			GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentStageCountIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<CurrentStageCountIndex>k__BackingField");
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentProgressionType_Public_get_GunGameProgressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688033);
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentEquipmentOption_Public_get_GunGameEquipmentOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688034);
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentStageCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688035);
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentProgressionTypeIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688036);
			GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentProgressionTypeIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688037);
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentEquipmentOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688038);
			GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentEquipmentOptionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688039);
			GunGameLoadoutOptions.NativeMethodInfoPtr_get_CurrentStageCountIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688040);
			GunGameLoadoutOptions.NativeMethodInfoPtr_set_CurrentStageCountIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688041);
			GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateAllDynamicStages_Private_IEnumerator_Boolean_Random_ArrayOf_Loadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688042);
			GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateMiddleDynamicStages_Private_IEnumerator_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688043);
			GunGameLoadoutOptions.NativeMethodInfoPtr_ChooseOneLoadout_Private_IEnumerator_Boolean_Int32_Int32_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688044);
			GunGameLoadoutOptions.NativeMethodInfoPtr_AggregateLoadouts_Private_Void_WeaponName_Int32_Boolean_Boolean_byref_List_1_ArrayOf_ProceduralLoadout_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688045);
			GunGameLoadoutOptions.NativeMethodInfoPtr_GenerateStageLoadouts_Public_Void_Int32_Boolean_byref_ArrayOf_Loadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688046);
			GunGameLoadoutOptions.NativeMethodInfoPtr_GetCostForStage_Private_Int32_Single_Single_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688047);
			GunGameLoadoutOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, 100688048);
		}

		// Token: 0x06013603 RID: 79363 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		public GunGameLoadoutOptions(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006DD3 RID: 28115
		// (get) Token: 0x06013604 RID: 79364 RVA: 0x004E05F0 File Offset: 0x004DE7F0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr));
			}
		}

		// Token: 0x17006DD4 RID: 28116
		// (get) Token: 0x06013605 RID: 79365 RVA: 0x004E0604 File Offset: 0x004DE804
		// (set) Token: 0x06013606 RID: 79366 RVA: 0x004E0622 File Offset: 0x004DE822
		public unsafe static float FAILURE_EXPANSION_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GunGameLoadoutOptions.NativeFieldInfoPtr_FAILURE_EXPANSION_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunGameLoadoutOptions.NativeFieldInfoPtr_FAILURE_EXPANSION_RATE, (void*)(&value));
			}
		}

		// Token: 0x17006DD5 RID: 28117
		// (get) Token: 0x06013607 RID: 79367 RVA: 0x004E0634 File Offset: 0x004DE834
		// (set) Token: 0x06013608 RID: 79368 RVA: 0x004E0652 File Offset: 0x004DE852
		public unsafe static int MAX_ITERATION_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GunGameLoadoutOptions.NativeFieldInfoPtr_MAX_ITERATION_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GunGameLoadoutOptions.NativeFieldInfoPtr_MAX_ITERATION_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x17006DD6 RID: 28118
		// (get) Token: 0x06013609 RID: 79369 RVA: 0x004E0664 File Offset: 0x004DE864
		// (set) Token: 0x0601360A RID: 79370 RVA: 0x004E0698 File Offset: 0x004DE898
		public unsafe Il2CppReferenceArray<ClassLoadout> SourceLoadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_SourceLoadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ClassLoadout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_SourceLoadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DD7 RID: 28119
		// (get) Token: 0x0601360B RID: 79371 RVA: 0x004E06C0 File Offset: 0x004DE8C0
		// (set) Token: 0x0601360C RID: 79372 RVA: 0x004E06F4 File Offset: 0x004DE8F4
		public unsafe Il2CppReferenceArray<GunGameProgressionType> AllProgressionTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllProgressionTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<GunGameProgressionType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllProgressionTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DD8 RID: 28120
		// (get) Token: 0x0601360D RID: 79373 RVA: 0x004E071C File Offset: 0x004DE91C
		// (set) Token: 0x0601360E RID: 79374 RVA: 0x004E0750 File Offset: 0x004DE950
		public unsafe Il2CppStructArray<int> AllStageCounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllStageCounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllStageCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DD9 RID: 28121
		// (get) Token: 0x0601360F RID: 79375 RVA: 0x004E0778 File Offset: 0x004DE978
		// (set) Token: 0x06013610 RID: 79376 RVA: 0x004E07AC File Offset: 0x004DE9AC
		public unsafe Il2CppReferenceArray<GunGameEquipmentOption> AllEquipmentOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllEquipmentOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<GunGameEquipmentOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllEquipmentOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DDA RID: 28122
		// (get) Token: 0x06013611 RID: 79377 RVA: 0x004E07D4 File Offset: 0x004DE9D4
		// (set) Token: 0x06013612 RID: 79378 RVA: 0x004E0808 File Offset: 0x004DEA08
		public unsafe Il2CppReferenceArray<SerializedLoadout> GimmickLoadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_GimmickLoadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<SerializedLoadout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_GimmickLoadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DDB RID: 28123
		// (get) Token: 0x06013613 RID: 79379 RVA: 0x004E0830 File Offset: 0x004DEA30
		// (set) Token: 0x06013614 RID: 79380 RVA: 0x004E0858 File Offset: 0x004DEA58
		public unsafe int DefaultProgressionTypeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultProgressionTypeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultProgressionTypeIndex)) = value;
			}
		}

		// Token: 0x17006DDC RID: 28124
		// (get) Token: 0x06013615 RID: 79381 RVA: 0x004E087C File Offset: 0x004DEA7C
		// (set) Token: 0x06013616 RID: 79382 RVA: 0x004E08A4 File Offset: 0x004DEAA4
		public unsafe int DefaultStageCountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultStageCountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultStageCountIndex)) = value;
			}
		}

		// Token: 0x17006DDD RID: 28125
		// (get) Token: 0x06013617 RID: 79383 RVA: 0x004E08C8 File Offset: 0x004DEAC8
		// (set) Token: 0x06013618 RID: 79384 RVA: 0x004E08F0 File Offset: 0x004DEAF0
		public unsafe int DefaultEquipmentOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultEquipmentOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultEquipmentOptionIndex)) = value;
			}
		}

		// Token: 0x17006DDE RID: 28126
		// (get) Token: 0x06013619 RID: 79385 RVA: 0x004E0914 File Offset: 0x004DEB14
		// (set) Token: 0x0601361A RID: 79386 RVA: 0x004E0948 File Offset: 0x004DEB48
		public unsafe SerializedLoadout DefaultLoadout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultLoadout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new SerializedLoadout(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_DefaultLoadout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DDF RID: 28127
		// (get) Token: 0x0601361B RID: 79387 RVA: 0x004E0970 File Offset: 0x004DEB70
		// (set) Token: 0x0601361C RID: 79388 RVA: 0x004E0998 File Offset: 0x004DEB98
		public unsafe float MinimumLoadoutPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MinimumLoadoutPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MinimumLoadoutPoints)) = value;
			}
		}

		// Token: 0x17006DE0 RID: 28128
		// (get) Token: 0x0601361D RID: 79389 RVA: 0x004E09BC File Offset: 0x004DEBBC
		// (set) Token: 0x0601361E RID: 79390 RVA: 0x004E09E4 File Offset: 0x004DEBE4
		public unsafe float MaximumLoadoutPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MaximumLoadoutPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MaximumLoadoutPoints)) = value;
			}
		}

		// Token: 0x17006DE1 RID: 28129
		// (get) Token: 0x0601361F RID: 79391 RVA: 0x004E0A08 File Offset: 0x004DEC08
		// (set) Token: 0x06013620 RID: 79392 RVA: 0x004E0A30 File Offset: 0x004DEC30
		public unsafe float AllowanceLoadoutPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllowanceLoadoutPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_AllowanceLoadoutPoints)) = value;
			}
		}

		// Token: 0x17006DE2 RID: 28130
		// (get) Token: 0x06013621 RID: 79393 RVA: 0x004E0A54 File Offset: 0x004DEC54
		// (set) Token: 0x06013622 RID: 79394 RVA: 0x004E0A7C File Offset: 0x004DEC7C
		public unsafe int MaxGeneratedCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MaxGeneratedCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_MaxGeneratedCost)) = value;
			}
		}

		// Token: 0x17006DE3 RID: 28131
		// (get) Token: 0x06013623 RID: 79395 RVA: 0x004E0AA0 File Offset: 0x004DECA0
		// (set) Token: 0x06013624 RID: 79396 RVA: 0x004E0AD4 File Offset: 0x004DECD4
		public unsafe WeaponPowerChooser WeaponChooser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_WeaponChooser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WeaponPowerChooser(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_WeaponChooser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DE4 RID: 28132
		// (get) Token: 0x06013625 RID: 79397 RVA: 0x004E0AFC File Offset: 0x004DECFC
		// (set) Token: 0x06013626 RID: 79398 RVA: 0x004E0B30 File Offset: 0x004DED30
		public unsafe List<Il2CppReferenceArray<ProceduralLoadout>> workingLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_workingLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Il2CppReferenceArray<ProceduralLoadout>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr_workingLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DE5 RID: 28133
		// (get) Token: 0x06013627 RID: 79399 RVA: 0x004E0B58 File Offset: 0x004DED58
		// (set) Token: 0x06013628 RID: 79400 RVA: 0x004E0B8C File Offset: 0x004DED8C
		public unsafe Coroutine _dynamicCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__dynamicCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Coroutine(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__dynamicCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006DE6 RID: 28134
		// (get) Token: 0x06013629 RID: 79401 RVA: 0x004E0BB4 File Offset: 0x004DEDB4
		// (set) Token: 0x0601362A RID: 79402 RVA: 0x004E0BDC File Offset: 0x004DEDDC
		public unsafe int _CurrentProgressionTypeIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentProgressionTypeIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentProgressionTypeIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17006DE7 RID: 28135
		// (get) Token: 0x0601362B RID: 79403 RVA: 0x004E0C00 File Offset: 0x004DEE00
		// (set) Token: 0x0601362C RID: 79404 RVA: 0x004E0C28 File Offset: 0x004DEE28
		public unsafe int _CurrentEquipmentOptionIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentEquipmentOptionIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentEquipmentOptionIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17006DE8 RID: 28136
		// (get) Token: 0x0601362D RID: 79405 RVA: 0x004E0C4C File Offset: 0x004DEE4C
		// (set) Token: 0x0601362E RID: 79406 RVA: 0x004E0C74 File Offset: 0x004DEE74
		public unsafe int _CurrentStageCountIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentStageCountIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions.NativeFieldInfoPtr__CurrentStageCountIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x0400C631 RID: 50737
		private static readonly IntPtr NativeFieldInfoPtr_FAILURE_EXPANSION_RATE;

		// Token: 0x0400C632 RID: 50738
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ITERATION_FAILURES;

		// Token: 0x0400C633 RID: 50739
		private static readonly IntPtr NativeFieldInfoPtr_SourceLoadouts;

		// Token: 0x0400C634 RID: 50740
		private static readonly IntPtr NativeFieldInfoPtr_AllProgressionTypes;

		// Token: 0x0400C635 RID: 50741
		private static readonly IntPtr NativeFieldInfoPtr_AllStageCounts;

		// Token: 0x0400C636 RID: 50742
		private static readonly IntPtr NativeFieldInfoPtr_AllEquipmentOptions;

		// Token: 0x0400C637 RID: 50743
		private static readonly IntPtr NativeFieldInfoPtr_GimmickLoadouts;

		// Token: 0x0400C638 RID: 50744
		private static readonly IntPtr NativeFieldInfoPtr_DefaultProgressionTypeIndex;

		// Token: 0x0400C639 RID: 50745
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStageCountIndex;

		// Token: 0x0400C63A RID: 50746
		private static readonly IntPtr NativeFieldInfoPtr_DefaultEquipmentOptionIndex;

		// Token: 0x0400C63B RID: 50747
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLoadout;

		// Token: 0x0400C63C RID: 50748
		private static readonly IntPtr NativeFieldInfoPtr_MinimumLoadoutPoints;

		// Token: 0x0400C63D RID: 50749
		private static readonly IntPtr NativeFieldInfoPtr_MaximumLoadoutPoints;

		// Token: 0x0400C63E RID: 50750
		private static readonly IntPtr NativeFieldInfoPtr_AllowanceLoadoutPoints;

		// Token: 0x0400C63F RID: 50751
		private static readonly IntPtr NativeFieldInfoPtr_MaxGeneratedCost;

		// Token: 0x0400C640 RID: 50752
		private static readonly IntPtr NativeFieldInfoPtr_WeaponChooser;

		// Token: 0x0400C641 RID: 50753
		private static readonly IntPtr NativeFieldInfoPtr_workingLists;

		// Token: 0x0400C642 RID: 50754
		private static readonly IntPtr NativeFieldInfoPtr__dynamicCoroutine;

		// Token: 0x0400C643 RID: 50755
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProgressionTypeIndex_k__BackingField;

		// Token: 0x0400C644 RID: 50756
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEquipmentOptionIndex_k__BackingField;

		// Token: 0x0400C645 RID: 50757
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStageCountIndex_k__BackingField;

		// Token: 0x0400C646 RID: 50758
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProgressionType_Public_get_GunGameProgressionType_0;

		// Token: 0x0400C647 RID: 50759
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquipmentOption_Public_get_GunGameEquipmentOption_0;

		// Token: 0x0400C648 RID: 50760
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStageCount_Public_get_Int32_0;

		// Token: 0x0400C649 RID: 50761
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProgressionTypeIndex_Public_get_Int32_0;

		// Token: 0x0400C64A RID: 50762
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProgressionTypeIndex_Public_set_Void_Int32_0;

		// Token: 0x0400C64B RID: 50763
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquipmentOptionIndex_Public_get_Int32_0;

		// Token: 0x0400C64C RID: 50764
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEquipmentOptionIndex_Public_set_Void_Int32_0;

		// Token: 0x0400C64D RID: 50765
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStageCountIndex_Public_get_Int32_0;

		// Token: 0x0400C64E RID: 50766
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStageCountIndex_Public_set_Void_Int32_0;

		// Token: 0x0400C64F RID: 50767
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAllDynamicStages_Private_IEnumerator_Boolean_Random_ArrayOf_Loadout_0;

		// Token: 0x0400C650 RID: 50768
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMiddleDynamicStages_Private_IEnumerator_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0;

		// Token: 0x0400C651 RID: 50769
		private static readonly IntPtr NativeMethodInfoPtr_ChooseOneLoadout_Private_IEnumerator_Boolean_Int32_Int32_Int32_Boolean_Boolean_Boolean_Random_ArrayOf_Loadout_0;

		// Token: 0x0400C652 RID: 50770
		private static readonly IntPtr NativeMethodInfoPtr_AggregateLoadouts_Private_Void_WeaponName_Int32_Boolean_Boolean_byref_List_1_ArrayOf_ProceduralLoadout_byref_Int32_0;

		// Token: 0x0400C653 RID: 50771
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStageLoadouts_Public_Void_Int32_Boolean_byref_ArrayOf_Loadout_0;

		// Token: 0x0400C654 RID: 50772
		private static readonly IntPtr NativeMethodInfoPtr_GetCostForStage_Private_Int32_Single_Single_Random_0;

		// Token: 0x0400C655 RID: 50773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000FC5 RID: 4037
		[ObfuscatedName("DPI.GameVariants.GunGame.GunGameLoadoutOptions/<GenerateAllDynamicStages>d__36")]
		public sealed class _GenerateAllDynamicStages_d__36 : Il2CppSystem.Object
		{
			// Token: 0x0601362F RID: 79407 RVA: 0x004E0C98 File Offset: 0x004DEE98
			[CallerCount(0)]
			public unsafe _GenerateAllDynamicStages_d__36(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06013630 RID: 79408 RVA: 0x004E0CF8 File Offset: 0x004DEEF8
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06013631 RID: 79409 RVA: 0x004E0D3C File Offset: 0x004DEF3C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17006DF9 RID: 28153
			// (get) Token: 0x06013632 RID: 79410 RVA: 0x004E0D8C File Offset: 0x004DEF8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06013633 RID: 79411 RVA: 0x004E0DE4 File Offset: 0x004DEFE4
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17006DFA RID: 28154
			// (get) Token: 0x06013634 RID: 79412 RVA: 0x004E0E28 File Offset: 0x004DF028
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06013635 RID: 79413 RVA: 0x004E0E80 File Offset: 0x004DF080
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateAllDynamicStages_d__36()
			{
				Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<GenerateAllDynamicStages>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<>1__state");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<>2__current");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<>4__this");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_isNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "isNight");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "random");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_loadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "loadouts");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__totalStageCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<totalStageCount>5__2");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__equipmentAllowed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<equipmentAllowed>5__3");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__nonEquipmentAllowed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, "<nonEquipmentAllowed>5__4");
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688049);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688050);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688051);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688052);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688053);
				GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr, 100688054);
			}

			// Token: 0x06013636 RID: 79414 RVA: 0x00002988 File Offset: 0x00000B88
			public _GenerateAllDynamicStages_d__36(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17006DEF RID: 28143
			// (get) Token: 0x06013637 RID: 79415 RVA: 0x004E0FD7 File Offset: 0x004DF1D7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateAllDynamicStages_d__36>.NativeClassPtr));
				}
			}

			// Token: 0x17006DF0 RID: 28144
			// (get) Token: 0x06013638 RID: 79416 RVA: 0x004E0FE8 File Offset: 0x004DF1E8
			// (set) Token: 0x06013639 RID: 79417 RVA: 0x004E1010 File Offset: 0x004DF210
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17006DF1 RID: 28145
			// (get) Token: 0x0601363A RID: 79418 RVA: 0x004E1034 File Offset: 0x004DF234
			// (set) Token: 0x0601363B RID: 79419 RVA: 0x004E1068 File Offset: 0x004DF268
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006DF2 RID: 28146
			// (get) Token: 0x0601363C RID: 79420 RVA: 0x004E1090 File Offset: 0x004DF290
			// (set) Token: 0x0601363D RID: 79421 RVA: 0x004E10C4 File Offset: 0x004DF2C4
			public unsafe GunGameLoadoutOptions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GunGameLoadoutOptions(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006DF3 RID: 28147
			// (get) Token: 0x0601363E RID: 79422 RVA: 0x004E10EC File Offset: 0x004DF2EC
			// (set) Token: 0x0601363F RID: 79423 RVA: 0x004E1114 File Offset: 0x004DF314
			public unsafe bool isNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_isNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_isNight)) = value;
				}
			}

			// Token: 0x17006DF4 RID: 28148
			// (get) Token: 0x06013640 RID: 79424 RVA: 0x004E1138 File Offset: 0x004DF338
			// (set) Token: 0x06013641 RID: 79425 RVA: 0x004E116C File Offset: 0x004DF36C
			public unsafe Il2CppSystem.Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Random(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006DF5 RID: 28149
			// (get) Token: 0x06013642 RID: 79426 RVA: 0x004E1194 File Offset: 0x004DF394
			// (set) Token: 0x06013643 RID: 79427 RVA: 0x004E11C8 File Offset: 0x004DF3C8
			public unsafe Il2CppReferenceArray<Loadout> loadouts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_loadouts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Loadout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr_loadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006DF6 RID: 28150
			// (get) Token: 0x06013644 RID: 79428 RVA: 0x004E11F0 File Offset: 0x004DF3F0
			// (set) Token: 0x06013645 RID: 79429 RVA: 0x004E1218 File Offset: 0x004DF418
			public unsafe int _totalStageCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__totalStageCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__totalStageCount_5__2)) = value;
				}
			}

			// Token: 0x17006DF7 RID: 28151
			// (get) Token: 0x06013646 RID: 79430 RVA: 0x004E123C File Offset: 0x004DF43C
			// (set) Token: 0x06013647 RID: 79431 RVA: 0x004E1264 File Offset: 0x004DF464
			public unsafe bool _equipmentAllowed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__equipmentAllowed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__equipmentAllowed_5__3)) = value;
				}
			}

			// Token: 0x17006DF8 RID: 28152
			// (get) Token: 0x06013648 RID: 79432 RVA: 0x004E1288 File Offset: 0x004DF488
			// (set) Token: 0x06013649 RID: 79433 RVA: 0x004E12B0 File Offset: 0x004DF4B0
			public unsafe bool _nonEquipmentAllowed_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__nonEquipmentAllowed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateAllDynamicStages_d__36.NativeFieldInfoPtr__nonEquipmentAllowed_5__4)) = value;
				}
			}

			// Token: 0x0400C656 RID: 50774
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400C657 RID: 50775
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400C658 RID: 50776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400C659 RID: 50777
			private static readonly IntPtr NativeFieldInfoPtr_isNight;

			// Token: 0x0400C65A RID: 50778
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x0400C65B RID: 50779
			private static readonly IntPtr NativeFieldInfoPtr_loadouts;

			// Token: 0x0400C65C RID: 50780
			private static readonly IntPtr NativeFieldInfoPtr__totalStageCount_5__2;

			// Token: 0x0400C65D RID: 50781
			private static readonly IntPtr NativeFieldInfoPtr__equipmentAllowed_5__3;

			// Token: 0x0400C65E RID: 50782
			private static readonly IntPtr NativeFieldInfoPtr__nonEquipmentAllowed_5__4;

			// Token: 0x0400C65F RID: 50783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400C660 RID: 50784
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C661 RID: 50785
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400C662 RID: 50786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400C663 RID: 50787
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C664 RID: 50788
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000FC6 RID: 4038
		[ObfuscatedName("DPI.GameVariants.GunGame.GunGameLoadoutOptions/<GenerateMiddleDynamicStages>d__37")]
		public sealed class _GenerateMiddleDynamicStages_d__37 : Il2CppSystem.Object
		{
			// Token: 0x0601364A RID: 79434 RVA: 0x004E12D4 File Offset: 0x004DF4D4
			[CallerCount(0)]
			public unsafe _GenerateMiddleDynamicStages_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601364B RID: 79435 RVA: 0x004E1334 File Offset: 0x004DF534
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601364C RID: 79436 RVA: 0x004E1378 File Offset: 0x004DF578
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17006E07 RID: 28167
			// (get) Token: 0x0601364D RID: 79437 RVA: 0x004E13C8 File Offset: 0x004DF5C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x0601364E RID: 79438 RVA: 0x004E1420 File Offset: 0x004DF620
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17006E08 RID: 28168
			// (get) Token: 0x0601364F RID: 79439 RVA: 0x004E1464 File Offset: 0x004DF664
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06013650 RID: 79440 RVA: 0x004E14BC File Offset: 0x004DF6BC
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateMiddleDynamicStages_d__37()
			{
				Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<GenerateMiddleDynamicStages>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "<>1__state");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "<>2__current");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_stagesToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "stagesToGenerate");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "<>4__this");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_isNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "isNight");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_equipmentAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "equipmentAllowed");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_nonEquipmentAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "nonEquipmentAllowed");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "random");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_loadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "loadouts");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__totalStageCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "<totalStageCount>5__2");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__stage_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, "<stage>5__3");
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688055);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688056);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688057);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688058);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688059);
				GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr, 100688060);
			}

			// Token: 0x06013651 RID: 79441 RVA: 0x00002988 File Offset: 0x00000B88
			public _GenerateMiddleDynamicStages_d__37(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17006DFB RID: 28155
			// (get) Token: 0x06013652 RID: 79442 RVA: 0x004E163B File Offset: 0x004DF83B
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37>.NativeClassPtr));
				}
			}

			// Token: 0x17006DFC RID: 28156
			// (get) Token: 0x06013653 RID: 79443 RVA: 0x004E164C File Offset: 0x004DF84C
			// (set) Token: 0x06013654 RID: 79444 RVA: 0x004E1674 File Offset: 0x004DF874
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17006DFD RID: 28157
			// (get) Token: 0x06013655 RID: 79445 RVA: 0x004E1698 File Offset: 0x004DF898
			// (set) Token: 0x06013656 RID: 79446 RVA: 0x004E16CC File Offset: 0x004DF8CC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006DFE RID: 28158
			// (get) Token: 0x06013657 RID: 79447 RVA: 0x004E16F4 File Offset: 0x004DF8F4
			// (set) Token: 0x06013658 RID: 79448 RVA: 0x004E171C File Offset: 0x004DF91C
			public unsafe int stagesToGenerate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_stagesToGenerate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_stagesToGenerate)) = value;
				}
			}

			// Token: 0x17006DFF RID: 28159
			// (get) Token: 0x06013659 RID: 79449 RVA: 0x004E1740 File Offset: 0x004DF940
			// (set) Token: 0x0601365A RID: 79450 RVA: 0x004E1774 File Offset: 0x004DF974
			public unsafe GunGameLoadoutOptions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GunGameLoadoutOptions(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E00 RID: 28160
			// (get) Token: 0x0601365B RID: 79451 RVA: 0x004E179C File Offset: 0x004DF99C
			// (set) Token: 0x0601365C RID: 79452 RVA: 0x004E17C4 File Offset: 0x004DF9C4
			public unsafe bool isNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_isNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_isNight)) = value;
				}
			}

			// Token: 0x17006E01 RID: 28161
			// (get) Token: 0x0601365D RID: 79453 RVA: 0x004E17E8 File Offset: 0x004DF9E8
			// (set) Token: 0x0601365E RID: 79454 RVA: 0x004E1810 File Offset: 0x004DFA10
			public unsafe bool equipmentAllowed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_equipmentAllowed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_equipmentAllowed)) = value;
				}
			}

			// Token: 0x17006E02 RID: 28162
			// (get) Token: 0x0601365F RID: 79455 RVA: 0x004E1834 File Offset: 0x004DFA34
			// (set) Token: 0x06013660 RID: 79456 RVA: 0x004E185C File Offset: 0x004DFA5C
			public unsafe bool nonEquipmentAllowed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_nonEquipmentAllowed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_nonEquipmentAllowed)) = value;
				}
			}

			// Token: 0x17006E03 RID: 28163
			// (get) Token: 0x06013661 RID: 79457 RVA: 0x004E1880 File Offset: 0x004DFA80
			// (set) Token: 0x06013662 RID: 79458 RVA: 0x004E18B4 File Offset: 0x004DFAB4
			public unsafe Il2CppSystem.Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Random(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E04 RID: 28164
			// (get) Token: 0x06013663 RID: 79459 RVA: 0x004E18DC File Offset: 0x004DFADC
			// (set) Token: 0x06013664 RID: 79460 RVA: 0x004E1910 File Offset: 0x004DFB10
			public unsafe Il2CppReferenceArray<Loadout> loadouts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_loadouts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Loadout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr_loadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E05 RID: 28165
			// (get) Token: 0x06013665 RID: 79461 RVA: 0x004E1938 File Offset: 0x004DFB38
			// (set) Token: 0x06013666 RID: 79462 RVA: 0x004E1960 File Offset: 0x004DFB60
			public unsafe int _totalStageCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__totalStageCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__totalStageCount_5__2)) = value;
				}
			}

			// Token: 0x17006E06 RID: 28166
			// (get) Token: 0x06013667 RID: 79463 RVA: 0x004E1984 File Offset: 0x004DFB84
			// (set) Token: 0x06013668 RID: 79464 RVA: 0x004E19AC File Offset: 0x004DFBAC
			public unsafe int _stage_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__stage_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._GenerateMiddleDynamicStages_d__37.NativeFieldInfoPtr__stage_5__3)) = value;
				}
			}

			// Token: 0x0400C665 RID: 50789
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400C666 RID: 50790
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400C667 RID: 50791
			private static readonly IntPtr NativeFieldInfoPtr_stagesToGenerate;

			// Token: 0x0400C668 RID: 50792
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400C669 RID: 50793
			private static readonly IntPtr NativeFieldInfoPtr_isNight;

			// Token: 0x0400C66A RID: 50794
			private static readonly IntPtr NativeFieldInfoPtr_equipmentAllowed;

			// Token: 0x0400C66B RID: 50795
			private static readonly IntPtr NativeFieldInfoPtr_nonEquipmentAllowed;

			// Token: 0x0400C66C RID: 50796
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x0400C66D RID: 50797
			private static readonly IntPtr NativeFieldInfoPtr_loadouts;

			// Token: 0x0400C66E RID: 50798
			private static readonly IntPtr NativeFieldInfoPtr__totalStageCount_5__2;

			// Token: 0x0400C66F RID: 50799
			private static readonly IntPtr NativeFieldInfoPtr__stage_5__3;

			// Token: 0x0400C670 RID: 50800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400C671 RID: 50801
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C672 RID: 50802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400C673 RID: 50803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400C674 RID: 50804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C675 RID: 50805
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000FC7 RID: 4039
		[ObfuscatedName("DPI.GameVariants.GunGame.GunGameLoadoutOptions/<ChooseOneLoadout>d__38")]
		public sealed class _ChooseOneLoadout_d__38 : Il2CppSystem.Object
		{
			// Token: 0x06013669 RID: 79465 RVA: 0x004E19D0 File Offset: 0x004DFBD0
			[CallerCount(0)]
			public unsafe _ChooseOneLoadout_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601366A RID: 79466 RVA: 0x004E1A30 File Offset: 0x004DFC30
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0601366B RID: 79467 RVA: 0x004E1A74 File Offset: 0x004DFC74
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17006E1C RID: 28188
			// (get) Token: 0x0601366C RID: 79468 RVA: 0x004E1AC4 File Offset: 0x004DFCC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x0601366D RID: 79469 RVA: 0x004E1B1C File Offset: 0x004DFD1C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17006E1D RID: 28189
			// (get) Token: 0x0601366E RID: 79470 RVA: 0x004E1B60 File Offset: 0x004DFD60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x0601366F RID: 79471 RVA: 0x004E1BB8 File Offset: 0x004DFDB8
			// Note: this type is marked as 'beforefieldinit'.
			static _ChooseOneLoadout_d__38()
			{
				Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunGameLoadoutOptions>.NativeClassPtr, "<ChooseOneLoadout>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<>1__state");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<>2__current");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<>4__this");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_stageNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "stageNumber");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_totalStageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "totalStageCount");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "random");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_nonEquipmentAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "nonEquipmentAllowed");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_isNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "isNight");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_equipmentAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "equipmentAllowed");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_loadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "loadouts");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_arrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "arrayIndex");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_synchronous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "synchronous");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__loadoutPower_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<loadoutPower>5__2");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__weaponPower_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<weaponPower>5__3");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__currentLoadoutDeviance_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<currentLoadoutDeviance>5__4");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__fallbackLoadoutDeviance_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<fallbackLoadoutDeviance>5__5");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__chosen_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<chosen>5__6");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__iterationFailures_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, "<iterationFailures>5__7");
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688061);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688062);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688063);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688064);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688065);
				GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr, 100688066);
			}

			// Token: 0x06013670 RID: 79472 RVA: 0x00002988 File Offset: 0x00000B88
			public _ChooseOneLoadout_d__38(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17006E09 RID: 28169
			// (get) Token: 0x06013671 RID: 79473 RVA: 0x004E1DC3 File Offset: 0x004DFFC3
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutOptions._ChooseOneLoadout_d__38>.NativeClassPtr));
				}
			}

			// Token: 0x17006E0A RID: 28170
			// (get) Token: 0x06013672 RID: 79474 RVA: 0x004E1DD4 File Offset: 0x004DFFD4
			// (set) Token: 0x06013673 RID: 79475 RVA: 0x004E1DFC File Offset: 0x004DFFFC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17006E0B RID: 28171
			// (get) Token: 0x06013674 RID: 79476 RVA: 0x004E1E20 File Offset: 0x004E0020
			// (set) Token: 0x06013675 RID: 79477 RVA: 0x004E1E54 File Offset: 0x004E0054
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E0C RID: 28172
			// (get) Token: 0x06013676 RID: 79478 RVA: 0x004E1E7C File Offset: 0x004E007C
			// (set) Token: 0x06013677 RID: 79479 RVA: 0x004E1EB0 File Offset: 0x004E00B0
			public unsafe GunGameLoadoutOptions __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GunGameLoadoutOptions(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E0D RID: 28173
			// (get) Token: 0x06013678 RID: 79480 RVA: 0x004E1ED8 File Offset: 0x004E00D8
			// (set) Token: 0x06013679 RID: 79481 RVA: 0x004E1F00 File Offset: 0x004E0100
			public unsafe int stageNumber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_stageNumber);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_stageNumber)) = value;
				}
			}

			// Token: 0x17006E0E RID: 28174
			// (get) Token: 0x0601367A RID: 79482 RVA: 0x004E1F24 File Offset: 0x004E0124
			// (set) Token: 0x0601367B RID: 79483 RVA: 0x004E1F4C File Offset: 0x004E014C
			public unsafe int totalStageCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_totalStageCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_totalStageCount)) = value;
				}
			}

			// Token: 0x17006E0F RID: 28175
			// (get) Token: 0x0601367C RID: 79484 RVA: 0x004E1F70 File Offset: 0x004E0170
			// (set) Token: 0x0601367D RID: 79485 RVA: 0x004E1FA4 File Offset: 0x004E01A4
			public unsafe Il2CppSystem.Random random
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_random);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Random(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E10 RID: 28176
			// (get) Token: 0x0601367E RID: 79486 RVA: 0x004E1FCC File Offset: 0x004E01CC
			// (set) Token: 0x0601367F RID: 79487 RVA: 0x004E1FF4 File Offset: 0x004E01F4
			public unsafe bool nonEquipmentAllowed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_nonEquipmentAllowed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_nonEquipmentAllowed)) = value;
				}
			}

			// Token: 0x17006E11 RID: 28177
			// (get) Token: 0x06013680 RID: 79488 RVA: 0x004E2018 File Offset: 0x004E0218
			// (set) Token: 0x06013681 RID: 79489 RVA: 0x004E2040 File Offset: 0x004E0240
			public unsafe bool isNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_isNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_isNight)) = value;
				}
			}

			// Token: 0x17006E12 RID: 28178
			// (get) Token: 0x06013682 RID: 79490 RVA: 0x004E2064 File Offset: 0x004E0264
			// (set) Token: 0x06013683 RID: 79491 RVA: 0x004E208C File Offset: 0x004E028C
			public unsafe bool equipmentAllowed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_equipmentAllowed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_equipmentAllowed)) = value;
				}
			}

			// Token: 0x17006E13 RID: 28179
			// (get) Token: 0x06013684 RID: 79492 RVA: 0x004E20B0 File Offset: 0x004E02B0
			// (set) Token: 0x06013685 RID: 79493 RVA: 0x004E20E4 File Offset: 0x004E02E4
			public unsafe Il2CppReferenceArray<Loadout> loadouts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_loadouts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Loadout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_loadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E14 RID: 28180
			// (get) Token: 0x06013686 RID: 79494 RVA: 0x004E210C File Offset: 0x004E030C
			// (set) Token: 0x06013687 RID: 79495 RVA: 0x004E2134 File Offset: 0x004E0334
			public unsafe int arrayIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_arrayIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_arrayIndex)) = value;
				}
			}

			// Token: 0x17006E15 RID: 28181
			// (get) Token: 0x06013688 RID: 79496 RVA: 0x004E2158 File Offset: 0x004E0358
			// (set) Token: 0x06013689 RID: 79497 RVA: 0x004E2180 File Offset: 0x004E0380
			public unsafe bool synchronous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_synchronous);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr_synchronous)) = value;
				}
			}

			// Token: 0x17006E16 RID: 28182
			// (get) Token: 0x0601368A RID: 79498 RVA: 0x004E21A4 File Offset: 0x004E03A4
			// (set) Token: 0x0601368B RID: 79499 RVA: 0x004E21CC File Offset: 0x004E03CC
			public unsafe float _loadoutPower_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__loadoutPower_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__loadoutPower_5__2)) = value;
				}
			}

			// Token: 0x17006E17 RID: 28183
			// (get) Token: 0x0601368C RID: 79500 RVA: 0x004E21F0 File Offset: 0x004E03F0
			// (set) Token: 0x0601368D RID: 79501 RVA: 0x004E2218 File Offset: 0x004E0418
			public unsafe float _weaponPower_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__weaponPower_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__weaponPower_5__3)) = value;
				}
			}

			// Token: 0x17006E18 RID: 28184
			// (get) Token: 0x0601368E RID: 79502 RVA: 0x004E223C File Offset: 0x004E043C
			// (set) Token: 0x0601368F RID: 79503 RVA: 0x004E2264 File Offset: 0x004E0464
			public unsafe float _currentLoadoutDeviance_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__currentLoadoutDeviance_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__currentLoadoutDeviance_5__4)) = value;
				}
			}

			// Token: 0x17006E19 RID: 28185
			// (get) Token: 0x06013690 RID: 79504 RVA: 0x004E2288 File Offset: 0x004E0488
			// (set) Token: 0x06013691 RID: 79505 RVA: 0x004E22B0 File Offset: 0x004E04B0
			public unsafe float _fallbackLoadoutDeviance_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__fallbackLoadoutDeviance_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__fallbackLoadoutDeviance_5__5)) = value;
				}
			}

			// Token: 0x17006E1A RID: 28186
			// (get) Token: 0x06013692 RID: 79506 RVA: 0x004E22D4 File Offset: 0x004E04D4
			// (set) Token: 0x06013693 RID: 79507 RVA: 0x004E2308 File Offset: 0x004E0508
			public unsafe ProceduralLoadout _chosen_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__chosen_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new ProceduralLoadout(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__chosen_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17006E1B RID: 28187
			// (get) Token: 0x06013694 RID: 79508 RVA: 0x004E2330 File Offset: 0x004E0530
			// (set) Token: 0x06013695 RID: 79509 RVA: 0x004E2358 File Offset: 0x004E0558
			public unsafe int _iterationFailures_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__iterationFailures_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameLoadoutOptions._ChooseOneLoadout_d__38.NativeFieldInfoPtr__iterationFailures_5__7)) = value;
				}
			}

			// Token: 0x0400C676 RID: 50806
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400C677 RID: 50807
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400C678 RID: 50808
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400C679 RID: 50809
			private static readonly IntPtr NativeFieldInfoPtr_stageNumber;

			// Token: 0x0400C67A RID: 50810
			private static readonly IntPtr NativeFieldInfoPtr_totalStageCount;

			// Token: 0x0400C67B RID: 50811
			private static readonly IntPtr NativeFieldInfoPtr_random;

			// Token: 0x0400C67C RID: 50812
			private static readonly IntPtr NativeFieldInfoPtr_nonEquipmentAllowed;

			// Token: 0x0400C67D RID: 50813
			private static readonly IntPtr NativeFieldInfoPtr_isNight;

			// Token: 0x0400C67E RID: 50814
			private static readonly IntPtr NativeFieldInfoPtr_equipmentAllowed;

			// Token: 0x0400C67F RID: 50815
			private static readonly IntPtr NativeFieldInfoPtr_loadouts;

			// Token: 0x0400C680 RID: 50816
			private static readonly IntPtr NativeFieldInfoPtr_arrayIndex;

			// Token: 0x0400C681 RID: 50817
			private static readonly IntPtr NativeFieldInfoPtr_synchronous;

			// Token: 0x0400C682 RID: 50818
			private static readonly IntPtr NativeFieldInfoPtr__loadoutPower_5__2;

			// Token: 0x0400C683 RID: 50819
			private static readonly IntPtr NativeFieldInfoPtr__weaponPower_5__3;

			// Token: 0x0400C684 RID: 50820
			private static readonly IntPtr NativeFieldInfoPtr__currentLoadoutDeviance_5__4;

			// Token: 0x0400C685 RID: 50821
			private static readonly IntPtr NativeFieldInfoPtr__fallbackLoadoutDeviance_5__5;

			// Token: 0x0400C686 RID: 50822
			private static readonly IntPtr NativeFieldInfoPtr__chosen_5__6;

			// Token: 0x0400C687 RID: 50823
			private static readonly IntPtr NativeFieldInfoPtr__iterationFailures_5__7;

			// Token: 0x0400C688 RID: 50824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400C689 RID: 50825
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C68A RID: 50826
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400C68B RID: 50827
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400C68C RID: 50828
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400C68D RID: 50829
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
