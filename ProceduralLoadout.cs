using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FCD RID: 4045
	[Serializable]
	public class ProceduralLoadout : Object
	{
		// Token: 0x060136B8 RID: 79544 RVA: 0x004E2B84 File Offset: 0x004E0D84
		[CallerCount(0)]
		public unsafe static int CreateHash(WeaponName weapon, int cost, bool forNight, bool hasEquipment)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weapon;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cost;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forNight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasEquipment;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadout.NativeMethodInfoPtr_CreateHash_Public_Static_Int32_WeaponName_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060136B9 RID: 79545 RVA: 0x004E2C10 File Offset: 0x004E0E10
		[CallerCount(0)]
		public unsafe Loadout GetAsLoadout(bool isNight, Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isNight;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadout.NativeMethodInfoPtr_GetAsLoadout_Public_Loadout_Boolean_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Loadout(intPtr2) : null;
		}

		// Token: 0x060136BA RID: 79546 RVA: 0x004E2C90 File Offset: 0x004E0E90
		[CallerCount(0)]
		public unsafe void ReplaceInfraredAttachments(bool night, bool secondary, Random random, Loadout loadout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref night;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondary;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadout);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadout.NativeMethodInfoPtr_ReplaceInfraredAttachments_Private_Void_Boolean_Boolean_Random_Loadout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136BB RID: 79547 RVA: 0x004E2D28 File Offset: 0x004E0F28
		[CallerCount(0)]
		public unsafe ProceduralLoadout() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136BC RID: 79548 RVA: 0x004E2D74 File Offset: 0x004E0F74
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralLoadout()
		{
			Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "ProceduralLoadout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr);
			ProceduralLoadout.NativeFieldInfoPtr_INFRARED_ODDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "INFRARED_ODDS");
			ProceduralLoadout.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Hash");
			ProceduralLoadout.NativeFieldInfoPtr_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Weapon");
			ProceduralLoadout.NativeFieldInfoPtr_Role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Role");
			ProceduralLoadout.NativeFieldInfoPtr_Ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Ammo");
			ProceduralLoadout.NativeFieldInfoPtr_Attachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Attachments");
			ProceduralLoadout.NativeFieldInfoPtr_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "Equipment");
			ProceduralLoadout.NativeFieldInfoPtr__workingEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "_workingEquipment");
			ProceduralLoadout.NativeFieldInfoPtr__workingExplosives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "_workingExplosives");
			ProceduralLoadout.NativeFieldInfoPtr__cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "_cost");
			ProceduralLoadout.NativeFieldInfoPtr__nightLoadout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "_nightLoadout");
			ProceduralLoadout.NativeFieldInfoPtr__hasEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, "_hasEquipment");
			ProceduralLoadout.NativeMethodInfoPtr_CreateHash_Public_Static_Int32_WeaponName_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, 100688074);
			ProceduralLoadout.NativeMethodInfoPtr_GetAsLoadout_Public_Loadout_Boolean_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, 100688075);
			ProceduralLoadout.NativeMethodInfoPtr_ReplaceInfraredAttachments_Private_Void_Boolean_Boolean_Random_Loadout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, 100688076);
			ProceduralLoadout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr, 100688077);
		}

		// Token: 0x060136BD RID: 79549 RVA: 0x00002988 File Offset: 0x00000B88
		public ProceduralLoadout(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E29 RID: 28201
		// (get) Token: 0x060136BE RID: 79550 RVA: 0x004E2EE4 File Offset: 0x004E10E4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProceduralLoadout>.NativeClassPtr));
			}
		}

		// Token: 0x17006E2A RID: 28202
		// (get) Token: 0x060136BF RID: 79551 RVA: 0x004E2EF8 File Offset: 0x004E10F8
		// (set) Token: 0x060136C0 RID: 79552 RVA: 0x004E2F16 File Offset: 0x004E1116
		public unsafe static int INFRARED_ODDS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProceduralLoadout.NativeFieldInfoPtr_INFRARED_ODDS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProceduralLoadout.NativeFieldInfoPtr_INFRARED_ODDS, (void*)(&value));
			}
		}

		// Token: 0x17006E2B RID: 28203
		// (get) Token: 0x060136C1 RID: 79553 RVA: 0x004E2F28 File Offset: 0x004E1128
		// (set) Token: 0x060136C2 RID: 79554 RVA: 0x004E2F50 File Offset: 0x004E1150
		public unsafe int Hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Hash)) = value;
			}
		}

		// Token: 0x17006E2C RID: 28204
		// (get) Token: 0x060136C3 RID: 79555 RVA: 0x004E2F74 File Offset: 0x004E1174
		// (set) Token: 0x060136C4 RID: 79556 RVA: 0x004E2F9C File Offset: 0x004E119C
		public unsafe WeaponName Weapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Weapon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Weapon)) = value;
			}
		}

		// Token: 0x17006E2D RID: 28205
		// (get) Token: 0x060136C5 RID: 79557 RVA: 0x004E2FC0 File Offset: 0x004E11C0
		// (set) Token: 0x060136C6 RID: 79558 RVA: 0x004E2FE8 File Offset: 0x004E11E8
		public unsafe SoldierClass Role
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Role);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Role)) = value;
			}
		}

		// Token: 0x17006E2E RID: 28206
		// (get) Token: 0x060136C7 RID: 79559 RVA: 0x004E300C File Offset: 0x004E120C
		// (set) Token: 0x060136C8 RID: 79560 RVA: 0x004E3034 File Offset: 0x004E1234
		public unsafe ClassLoadout.AmmoType Ammo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Ammo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Ammo)) = value;
			}
		}

		// Token: 0x17006E2F RID: 28207
		// (get) Token: 0x060136C9 RID: 79561 RVA: 0x004E3058 File Offset: 0x004E1258
		// (set) Token: 0x060136CA RID: 79562 RVA: 0x004E308C File Offset: 0x004E128C
		public unsafe List<WeaponAttachment.AttachmentType> Attachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Attachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<WeaponAttachment.AttachmentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Attachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E30 RID: 28208
		// (get) Token: 0x060136CB RID: 79563 RVA: 0x004E30B4 File Offset: 0x004E12B4
		// (set) Token: 0x060136CC RID: 79564 RVA: 0x004E30E8 File Offset: 0x004E12E8
		public unsafe List<ClassLoadout.EquipmentType> Equipment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Equipment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<ClassLoadout.EquipmentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr_Equipment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E31 RID: 28209
		// (get) Token: 0x060136CD RID: 79565 RVA: 0x004E3110 File Offset: 0x004E1310
		// (set) Token: 0x060136CE RID: 79566 RVA: 0x004E313B File Offset: 0x004E133B
		public unsafe static List<ClassLoadout.EquipmentType> _workingEquipment
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProceduralLoadout.NativeFieldInfoPtr__workingEquipment, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<ClassLoadout.EquipmentType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProceduralLoadout.NativeFieldInfoPtr__workingEquipment, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E32 RID: 28210
		// (get) Token: 0x060136CF RID: 79567 RVA: 0x004E3150 File Offset: 0x004E1350
		// (set) Token: 0x060136D0 RID: 79568 RVA: 0x004E317B File Offset: 0x004E137B
		public unsafe static List<ClassLoadout.EquipmentType> _workingExplosives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProceduralLoadout.NativeFieldInfoPtr__workingExplosives, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<ClassLoadout.EquipmentType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProceduralLoadout.NativeFieldInfoPtr__workingExplosives, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E33 RID: 28211
		// (get) Token: 0x060136D1 RID: 79569 RVA: 0x004E3190 File Offset: 0x004E1390
		// (set) Token: 0x060136D2 RID: 79570 RVA: 0x004E31B8 File Offset: 0x004E13B8
		public unsafe int _cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__cost)) = value;
			}
		}

		// Token: 0x17006E34 RID: 28212
		// (get) Token: 0x060136D3 RID: 79571 RVA: 0x004E31DC File Offset: 0x004E13DC
		// (set) Token: 0x060136D4 RID: 79572 RVA: 0x004E3204 File Offset: 0x004E1404
		public unsafe bool _nightLoadout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__nightLoadout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__nightLoadout)) = value;
			}
		}

		// Token: 0x17006E35 RID: 28213
		// (get) Token: 0x060136D5 RID: 79573 RVA: 0x004E3228 File Offset: 0x004E1428
		// (set) Token: 0x060136D6 RID: 79574 RVA: 0x004E3250 File Offset: 0x004E1450
		public unsafe bool _hasEquipment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__hasEquipment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadout.NativeFieldInfoPtr__hasEquipment)) = value;
			}
		}

		// Token: 0x0400C69F RID: 50847
		private static readonly IntPtr NativeFieldInfoPtr_INFRARED_ODDS;

		// Token: 0x0400C6A0 RID: 50848
		private static readonly IntPtr NativeFieldInfoPtr_Hash;

		// Token: 0x0400C6A1 RID: 50849
		private static readonly IntPtr NativeFieldInfoPtr_Weapon;

		// Token: 0x0400C6A2 RID: 50850
		private static readonly IntPtr NativeFieldInfoPtr_Role;

		// Token: 0x0400C6A3 RID: 50851
		private static readonly IntPtr NativeFieldInfoPtr_Ammo;

		// Token: 0x0400C6A4 RID: 50852
		private static readonly IntPtr NativeFieldInfoPtr_Attachments;

		// Token: 0x0400C6A5 RID: 50853
		private static readonly IntPtr NativeFieldInfoPtr_Equipment;

		// Token: 0x0400C6A6 RID: 50854
		private static readonly IntPtr NativeFieldInfoPtr__workingEquipment;

		// Token: 0x0400C6A7 RID: 50855
		private static readonly IntPtr NativeFieldInfoPtr__workingExplosives;

		// Token: 0x0400C6A8 RID: 50856
		private static readonly IntPtr NativeFieldInfoPtr__cost;

		// Token: 0x0400C6A9 RID: 50857
		private static readonly IntPtr NativeFieldInfoPtr__nightLoadout;

		// Token: 0x0400C6AA RID: 50858
		private static readonly IntPtr NativeFieldInfoPtr__hasEquipment;

		// Token: 0x0400C6AB RID: 50859
		private static readonly IntPtr NativeMethodInfoPtr_CreateHash_Public_Static_Int32_WeaponName_Int32_Boolean_Boolean_0;

		// Token: 0x0400C6AC RID: 50860
		private static readonly IntPtr NativeMethodInfoPtr_GetAsLoadout_Public_Loadout_Boolean_Random_0;

		// Token: 0x0400C6AD RID: 50861
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInfraredAttachments_Private_Void_Boolean_Boolean_Random_Loadout_0;

		// Token: 0x0400C6AE RID: 50862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
