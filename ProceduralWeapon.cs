using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FD0 RID: 4048
	public class ProceduralWeapon : Object
	{
		// Token: 0x060136E5 RID: 79589 RVA: 0x004E34FC File Offset: 0x004E16FC
		[CallerCount(0)]
		public unsafe bool GetIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralWeapon.NativeMethodInfoPtr_GetIsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060136E6 RID: 79590 RVA: 0x004E354C File Offset: 0x004E174C
		[CallerCount(0)]
		public unsafe ProceduralWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136E7 RID: 79591 RVA: 0x004E3598 File Offset: 0x004E1798
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralWeapon()
		{
			Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "ProceduralWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr);
			ProceduralWeapon.NativeFieldInfoPtr_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr, "Weapon");
			ProceduralWeapon.NativeFieldInfoPtr_Attachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr, "Attachments");
			ProceduralWeapon.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr, "Cost");
			ProceduralWeapon.NativeMethodInfoPtr_GetIsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr, 100688081);
			ProceduralWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr, 100688082);
		}

		// Token: 0x060136E8 RID: 79592 RVA: 0x00002988 File Offset: 0x00000B88
		public ProceduralWeapon(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E3B RID: 28219
		// (get) Token: 0x060136E9 RID: 79593 RVA: 0x004E362C File Offset: 0x004E182C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProceduralWeapon>.NativeClassPtr));
			}
		}

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x060136EA RID: 79594 RVA: 0x004E3640 File Offset: 0x004E1840
		// (set) Token: 0x060136EB RID: 79595 RVA: 0x004E3668 File Offset: 0x004E1868
		public unsafe WeaponName Weapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Weapon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Weapon)) = value;
			}
		}

		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x060136EC RID: 79596 RVA: 0x004E368C File Offset: 0x004E188C
		// (set) Token: 0x060136ED RID: 79597 RVA: 0x004E36C0 File Offset: 0x004E18C0
		public unsafe List<WeaponAttachment.AttachmentType> Attachments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Attachments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<WeaponAttachment.AttachmentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Attachments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E3E RID: 28222
		// (get) Token: 0x060136EE RID: 79598 RVA: 0x004E36E8 File Offset: 0x004E18E8
		// (set) Token: 0x060136EF RID: 79599 RVA: 0x004E3710 File Offset: 0x004E1910
		public unsafe int Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralWeapon.NativeFieldInfoPtr_Cost)) = value;
			}
		}

		// Token: 0x0400C6B4 RID: 50868
		private static readonly IntPtr NativeFieldInfoPtr_Weapon;

		// Token: 0x0400C6B5 RID: 50869
		private static readonly IntPtr NativeFieldInfoPtr_Attachments;

		// Token: 0x0400C6B6 RID: 50870
		private static readonly IntPtr NativeFieldInfoPtr_Cost;

		// Token: 0x0400C6B7 RID: 50871
		private static readonly IntPtr NativeMethodInfoPtr_GetIsValid_Public_Boolean_0;

		// Token: 0x0400C6B8 RID: 50872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
