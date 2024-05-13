using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Settings
{
	// Token: 0x02000FD8 RID: 4056
	[Serializable]
	public class LoadoutSettingsSlotHeader : Object
	{
		// Token: 0x0601374F RID: 79695 RVA: 0x004E5134 File Offset: 0x004E3334
		[CallerCount(0)]
		public unsafe static bool IsSameSlot(LoadoutSettingsSlotHeader a, LoadoutSettingsSlotHeader b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlotHeader.NativeMethodInfoPtr_IsSameSlot_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013750 RID: 79696 RVA: 0x004E51A4 File Offset: 0x004E33A4
		[CallerCount(0)]
		public unsafe static bool IsSameCategory(LoadoutSettingsSlotHeader a, LoadoutSettingsSlotHeader b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlotHeader.NativeMethodInfoPtr_IsSameCategory_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013751 RID: 79697 RVA: 0x004E5214 File Offset: 0x004E3414
		[CallerCount(0)]
		public unsafe LoadoutSettingsSlotHeader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlotHeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013752 RID: 79698 RVA: 0x004E5260 File Offset: 0x004E3460
		// Note: this type is marked as 'beforefieldinit'.
		static LoadoutSettingsSlotHeader()
		{
			Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Settings", "LoadoutSettingsSlotHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr);
			LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, "Slot");
			LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, "Faction");
			LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, "Role");
			LoadoutSettingsSlotHeader.NativeFieldInfoPtr_GameVariantCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, "GameVariantCategory");
			LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, "Night");
			LoadoutSettingsSlotHeader.NativeMethodInfoPtr_IsSameSlot_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, 100688116);
			LoadoutSettingsSlotHeader.NativeMethodInfoPtr_IsSameCategory_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, 100688117);
			LoadoutSettingsSlotHeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr, 100688118);
		}

		// Token: 0x06013753 RID: 79699 RVA: 0x00002988 File Offset: 0x00000B88
		public LoadoutSettingsSlotHeader(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x06013754 RID: 79700 RVA: 0x004E5330 File Offset: 0x004E3530
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LoadoutSettingsSlotHeader>.NativeClassPtr));
			}
		}

		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x06013755 RID: 79701 RVA: 0x004E5344 File Offset: 0x004E3544
		// (set) Token: 0x06013756 RID: 79702 RVA: 0x004E536C File Offset: 0x004E356C
		public unsafe int Slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Slot)) = value;
			}
		}

		// Token: 0x17006E5E RID: 28254
		// (get) Token: 0x06013757 RID: 79703 RVA: 0x004E5390 File Offset: 0x004E3590
		// (set) Token: 0x06013758 RID: 79704 RVA: 0x004E53B8 File Offset: 0x004E35B8
		public unsafe int Faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Faction)) = value;
			}
		}

		// Token: 0x17006E5F RID: 28255
		// (get) Token: 0x06013759 RID: 79705 RVA: 0x004E53DC File Offset: 0x004E35DC
		// (set) Token: 0x0601375A RID: 79706 RVA: 0x004E5404 File Offset: 0x004E3604
		public unsafe int Role
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Role);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Role)) = value;
			}
		}

		// Token: 0x17006E60 RID: 28256
		// (get) Token: 0x0601375B RID: 79707 RVA: 0x004E5428 File Offset: 0x004E3628
		// (set) Token: 0x0601375C RID: 79708 RVA: 0x004E5450 File Offset: 0x004E3650
		public unsafe int GameVariantCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_GameVariantCategory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_GameVariantCategory)) = value;
			}
		}

		// Token: 0x17006E61 RID: 28257
		// (get) Token: 0x0601375D RID: 79709 RVA: 0x004E5474 File Offset: 0x004E3674
		// (set) Token: 0x0601375E RID: 79710 RVA: 0x004E549C File Offset: 0x004E369C
		public unsafe int Night
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Night);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlotHeader.NativeFieldInfoPtr_Night)) = value;
			}
		}

		// Token: 0x0400C6F4 RID: 50932
		private static readonly IntPtr NativeFieldInfoPtr_Slot;

		// Token: 0x0400C6F5 RID: 50933
		private static readonly IntPtr NativeFieldInfoPtr_Faction;

		// Token: 0x0400C6F6 RID: 50934
		private static readonly IntPtr NativeFieldInfoPtr_Role;

		// Token: 0x0400C6F7 RID: 50935
		private static readonly IntPtr NativeFieldInfoPtr_GameVariantCategory;

		// Token: 0x0400C6F8 RID: 50936
		private static readonly IntPtr NativeFieldInfoPtr_Night;

		// Token: 0x0400C6F9 RID: 50937
		private static readonly IntPtr NativeMethodInfoPtr_IsSameSlot_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0;

		// Token: 0x0400C6FA RID: 50938
		private static readonly IntPtr NativeMethodInfoPtr_IsSameCategory_Public_Static_Boolean_LoadoutSettingsSlotHeader_LoadoutSettingsSlotHeader_0;

		// Token: 0x0400C6FB RID: 50939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
