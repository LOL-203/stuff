using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Settings
{
	// Token: 0x02000FD9 RID: 4057
	[Serializable]
	public class LoadoutSettingsSlot : Object
	{
		// Token: 0x0601375F RID: 79711 RVA: 0x004E54C0 File Offset: 0x004E36C0
		[CallerCount(0)]
		public unsafe string GetDisplayName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlot.NativeMethodInfoPtr_GetDisplayName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06013760 RID: 79712 RVA: 0x004E550C File Offset: 0x004E370C
		[CallerCount(0)]
		public unsafe LoadoutSettingsSlot GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlot.NativeMethodInfoPtr_GetCopy_Public_LoadoutSettingsSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new LoadoutSettingsSlot(intPtr2) : null;
		}

		// Token: 0x06013761 RID: 79713 RVA: 0x004E5564 File Offset: 0x004E3764
		[CallerCount(0)]
		public unsafe LoadoutSettingsSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013762 RID: 79714 RVA: 0x004E55B0 File Offset: 0x004E37B0
		// Note: this type is marked as 'beforefieldinit'.
		static LoadoutSettingsSlot()
		{
			Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Settings", "LoadoutSettingsSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr);
			LoadoutSettingsSlot.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "Header");
			LoadoutSettingsSlot.NativeFieldInfoPtr_CustomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "CustomName");
			LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "PrimaryWeapon");
			LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "PrimaryAmmo");
			LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "SecondaryWeapon");
			LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "PrimaryAttachments");
			LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "SecondaryAttachments");
			LoadoutSettingsSlot.NativeFieldInfoPtr_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "Equipment");
			LoadoutSettingsSlot.NativeFieldInfoPtr_Explosives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, "Explosives");
			LoadoutSettingsSlot.NativeMethodInfoPtr_GetDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, 100688119);
			LoadoutSettingsSlot.NativeMethodInfoPtr_GetCopy_Public_LoadoutSettingsSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, 100688120);
			LoadoutSettingsSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr, 100688121);
		}

		// Token: 0x06013763 RID: 79715 RVA: 0x00002988 File Offset: 0x00000B88
		public LoadoutSettingsSlot(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E62 RID: 28258
		// (get) Token: 0x06013764 RID: 79716 RVA: 0x004E56D0 File Offset: 0x004E38D0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LoadoutSettingsSlot>.NativeClassPtr));
			}
		}

		// Token: 0x17006E63 RID: 28259
		// (get) Token: 0x06013765 RID: 79717 RVA: 0x004E56E4 File Offset: 0x004E38E4
		// (set) Token: 0x06013766 RID: 79718 RVA: 0x004E5718 File Offset: 0x004E3918
		public unsafe LoadoutSettingsSlotHeader Header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new LoadoutSettingsSlotHeader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E64 RID: 28260
		// (get) Token: 0x06013767 RID: 79719 RVA: 0x004E5740 File Offset: 0x004E3940
		// (set) Token: 0x06013768 RID: 79720 RVA: 0x004E5769 File Offset: 0x004E3969
		public unsafe string CustomName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_CustomName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_CustomName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17006E65 RID: 28261
		// (get) Token: 0x06013769 RID: 79721 RVA: 0x004E5790 File Offset: 0x004E3990
		// (set) Token: 0x0601376A RID: 79722 RVA: 0x004E57B8 File Offset: 0x004E39B8
		public unsafe int PrimaryWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryWeapon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryWeapon)) = value;
			}
		}

		// Token: 0x17006E66 RID: 28262
		// (get) Token: 0x0601376B RID: 79723 RVA: 0x004E57DC File Offset: 0x004E39DC
		// (set) Token: 0x0601376C RID: 79724 RVA: 0x004E5804 File Offset: 0x004E3A04
		public unsafe int PrimaryAmmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAmmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAmmo)) = value;
			}
		}

		// Token: 0x17006E67 RID: 28263
		// (get) Token: 0x0601376D RID: 79725 RVA: 0x004E5828 File Offset: 0x004E3A28
		// (set) Token: 0x0601376E RID: 79726 RVA: 0x004E5850 File Offset: 0x004E3A50
		public unsafe int SecondaryWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryWeapon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryWeapon)) = value;
			}
		}

		// Token: 0x17006E68 RID: 28264
		// (get) Token: 0x0601376F RID: 79727 RVA: 0x004E5874 File Offset: 0x004E3A74
		// (set) Token: 0x06013770 RID: 79728 RVA: 0x004E58A8 File Offset: 0x004E3AA8
		public unsafe List<int> PrimaryAttachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAttachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_PrimaryAttachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x06013771 RID: 79729 RVA: 0x004E58D0 File Offset: 0x004E3AD0
		// (set) Token: 0x06013772 RID: 79730 RVA: 0x004E5904 File Offset: 0x004E3B04
		public unsafe List<int> SecondaryAttachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryAttachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_SecondaryAttachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E6A RID: 28266
		// (get) Token: 0x06013773 RID: 79731 RVA: 0x004E592C File Offset: 0x004E3B2C
		// (set) Token: 0x06013774 RID: 79732 RVA: 0x004E5960 File Offset: 0x004E3B60
		public unsafe List<int> Equipment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Equipment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Equipment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E6B RID: 28267
		// (get) Token: 0x06013775 RID: 79733 RVA: 0x004E5988 File Offset: 0x004E3B88
		// (set) Token: 0x06013776 RID: 79734 RVA: 0x004E59BC File Offset: 0x004E3BBC
		public unsafe List<int> Explosives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Explosives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsSlot.NativeFieldInfoPtr_Explosives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6FC RID: 50940
		private static readonly IntPtr NativeFieldInfoPtr_Header;

		// Token: 0x0400C6FD RID: 50941
		private static readonly IntPtr NativeFieldInfoPtr_CustomName;

		// Token: 0x0400C6FE RID: 50942
		private static readonly IntPtr NativeFieldInfoPtr_PrimaryWeapon;

		// Token: 0x0400C6FF RID: 50943
		private static readonly IntPtr NativeFieldInfoPtr_PrimaryAmmo;

		// Token: 0x0400C700 RID: 50944
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryWeapon;

		// Token: 0x0400C701 RID: 50945
		private static readonly IntPtr NativeFieldInfoPtr_PrimaryAttachments;

		// Token: 0x0400C702 RID: 50946
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryAttachments;

		// Token: 0x0400C703 RID: 50947
		private static readonly IntPtr NativeFieldInfoPtr_Equipment;

		// Token: 0x0400C704 RID: 50948
		private static readonly IntPtr NativeFieldInfoPtr_Explosives;

		// Token: 0x0400C705 RID: 50949
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayName_Public_String_0;

		// Token: 0x0400C706 RID: 50950
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_LoadoutSettingsSlot_0;

		// Token: 0x0400C707 RID: 50951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
