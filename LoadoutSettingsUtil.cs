using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Settings
{
	// Token: 0x02000FDA RID: 4058
	public class LoadoutSettingsUtil : Object
	{
		// Token: 0x06013777 RID: 79735 RVA: 0x004E59E4 File Offset: 0x004E3BE4
		[CallerCount(0)]
		public unsafe static void SaveLoadout(LoadoutSettingsRoot root, LoadoutSettingsSlotHeader header, int primaryWeapon, int primaryAmmo, int secondaryWeapon, List<int> primaryAttachments, List<int> secondaryAttachments, List<int> equipment, List<int> explosives)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(header);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref primaryWeapon;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref primaryAmmo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondaryWeapon;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryAttachments);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondaryAttachments);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equipment);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(explosives);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_SaveLoadout_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_Int32_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x004E5AE0 File Offset: 0x004E3CE0
		[CallerCount(0)]
		public unsafe static void SaveRoot(LoadoutSettingsRoot root)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_SaveRoot_Public_Static_Void_LoadoutSettingsRoot_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013779 RID: 79737 RVA: 0x004E5B2C File Offset: 0x004E3D2C
		[CallerCount(0)]
		public unsafe static LoadoutSettingsSlot FindSlot(LoadoutSettingsRoot root, LoadoutSettingsSlotHeader header)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(header);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_FindSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new LoadoutSettingsSlot(intPtr2) : null;
		}

		// Token: 0x0601377A RID: 79738 RVA: 0x004E5BA4 File Offset: 0x004E3DA4
		[CallerCount(0)]
		public unsafe static void RenameSlot(LoadoutSettingsRoot root, LoadoutSettingsSlotHeader header, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(header);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_RenameSlot_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601377B RID: 79739 RVA: 0x004E5C20 File Offset: 0x004E3E20
		[CallerCount(0)]
		public unsafe static bool DeleteSlot(LoadoutSettingsRoot root, LoadoutSettingsSlotHeader header)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(header);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_DeleteSlot_Public_Static_Boolean_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601377C RID: 79740 RVA: 0x004E5C90 File Offset: 0x004E3E90
		[CallerCount(0)]
		public unsafe static LoadoutSettingsSlot LoadOrCreateSlot(LoadoutSettingsRoot root, LoadoutSettingsSlotHeader header)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(header);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_LoadOrCreateSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new LoadoutSettingsSlot(intPtr2) : null;
		}

		// Token: 0x0601377D RID: 79741 RVA: 0x004E5D08 File Offset: 0x004E3F08
		[CallerCount(0)]
		public unsafe static LoadoutSettingsRoot LoadOrCreateRoot()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_LoadOrCreateRoot_Public_Static_LoadoutSettingsRoot_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new LoadoutSettingsRoot(intPtr2) : null;
		}

		// Token: 0x0601377E RID: 79742 RVA: 0x004E5D50 File Offset: 0x004E3F50
		[CallerCount(0)]
		public unsafe static void UpgradeRootVersion(LoadoutSettingsRoot root, int from, int to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_UpgradeRootVersion_Private_Static_Void_LoadoutSettingsRoot_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601377F RID: 79743 RVA: 0x004E5DC0 File Offset: 0x004E3FC0
		[CallerCount(0)]
		public unsafe static void ProcessOldDayLoadoutsToNightLoadouts(LoadoutSettingsRoot root)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr_ProcessOldDayLoadoutsToNightLoadouts_Private_Static_Void_LoadoutSettingsRoot_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013780 RID: 79744 RVA: 0x004E5E0C File Offset: 0x004E400C
		[CallerCount(0)]
		public unsafe LoadoutSettingsUtil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013781 RID: 79745 RVA: 0x004E5E58 File Offset: 0x004E4058
		// Note: this type is marked as 'beforefieldinit'.
		static LoadoutSettingsUtil()
		{
			Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Settings", "LoadoutSettingsUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr);
			LoadoutSettingsUtil.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, "_root");
			LoadoutSettingsUtil.NativeMethodInfoPtr_SaveLoadout_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_Int32_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688122);
			LoadoutSettingsUtil.NativeMethodInfoPtr_SaveRoot_Public_Static_Void_LoadoutSettingsRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688123);
			LoadoutSettingsUtil.NativeMethodInfoPtr_FindSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688124);
			LoadoutSettingsUtil.NativeMethodInfoPtr_RenameSlot_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688125);
			LoadoutSettingsUtil.NativeMethodInfoPtr_DeleteSlot_Public_Static_Boolean_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688126);
			LoadoutSettingsUtil.NativeMethodInfoPtr_LoadOrCreateSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688127);
			LoadoutSettingsUtil.NativeMethodInfoPtr_LoadOrCreateRoot_Public_Static_LoadoutSettingsRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688128);
			LoadoutSettingsUtil.NativeMethodInfoPtr_UpgradeRootVersion_Private_Static_Void_LoadoutSettingsRoot_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688129);
			LoadoutSettingsUtil.NativeMethodInfoPtr_ProcessOldDayLoadoutsToNightLoadouts_Private_Static_Void_LoadoutSettingsRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688130);
			LoadoutSettingsUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr, 100688131);
		}

		// Token: 0x06013782 RID: 79746 RVA: 0x00002988 File Offset: 0x00000B88
		public LoadoutSettingsUtil(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E6C RID: 28268
		// (get) Token: 0x06013783 RID: 79747 RVA: 0x004E5F64 File Offset: 0x004E4164
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LoadoutSettingsUtil>.NativeClassPtr));
			}
		}

		// Token: 0x17006E6D RID: 28269
		// (get) Token: 0x06013784 RID: 79748 RVA: 0x004E5F78 File Offset: 0x004E4178
		// (set) Token: 0x06013785 RID: 79749 RVA: 0x004E5FA3 File Offset: 0x004E41A3
		public unsafe static LoadoutSettingsRoot _root
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadoutSettingsUtil.NativeFieldInfoPtr__root, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new LoadoutSettingsRoot(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadoutSettingsUtil.NativeFieldInfoPtr__root, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C708 RID: 50952
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x0400C709 RID: 50953
		private static readonly IntPtr NativeMethodInfoPtr_SaveLoadout_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_Int32_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0;

		// Token: 0x0400C70A RID: 50954
		private static readonly IntPtr NativeMethodInfoPtr_SaveRoot_Public_Static_Void_LoadoutSettingsRoot_0;

		// Token: 0x0400C70B RID: 50955
		private static readonly IntPtr NativeMethodInfoPtr_FindSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0;

		// Token: 0x0400C70C RID: 50956
		private static readonly IntPtr NativeMethodInfoPtr_RenameSlot_Public_Static_Void_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_String_0;

		// Token: 0x0400C70D RID: 50957
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSlot_Public_Static_Boolean_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0;

		// Token: 0x0400C70E RID: 50958
		private static readonly IntPtr NativeMethodInfoPtr_LoadOrCreateSlot_Public_Static_LoadoutSettingsSlot_LoadoutSettingsRoot_LoadoutSettingsSlotHeader_0;

		// Token: 0x0400C70F RID: 50959
		private static readonly IntPtr NativeMethodInfoPtr_LoadOrCreateRoot_Public_Static_LoadoutSettingsRoot_0;

		// Token: 0x0400C710 RID: 50960
		private static readonly IntPtr NativeMethodInfoPtr_UpgradeRootVersion_Private_Static_Void_LoadoutSettingsRoot_Int32_Int32_0;

		// Token: 0x0400C711 RID: 50961
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOldDayLoadoutsToNightLoadouts_Private_Static_Void_LoadoutSettingsRoot_0;

		// Token: 0x0400C712 RID: 50962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
