using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FCC RID: 4044
	public class ProceduralEquipment : Object
	{
		// Token: 0x060136AF RID: 79535 RVA: 0x004E29AC File Offset: 0x004E0BAC
		[CallerCount(0)]
		public unsafe bool GetIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralEquipment.NativeMethodInfoPtr_GetIsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060136B0 RID: 79536 RVA: 0x004E29FC File Offset: 0x004E0BFC
		[CallerCount(0)]
		public unsafe ProceduralEquipment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralEquipment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136B1 RID: 79537 RVA: 0x004E2A48 File Offset: 0x004E0C48
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralEquipment()
		{
			Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "ProceduralEquipment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr);
			ProceduralEquipment.NativeFieldInfoPtr_Equipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr, "Equipment");
			ProceduralEquipment.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr, "Cost");
			ProceduralEquipment.NativeMethodInfoPtr_GetIsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr, 100688072);
			ProceduralEquipment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr, 100688073);
		}

		// Token: 0x060136B2 RID: 79538 RVA: 0x00002988 File Offset: 0x00000B88
		public ProceduralEquipment(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x060136B3 RID: 79539 RVA: 0x004E2AC8 File Offset: 0x004E0CC8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProceduralEquipment>.NativeClassPtr));
			}
		}

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x060136B4 RID: 79540 RVA: 0x004E2ADC File Offset: 0x004E0CDC
		// (set) Token: 0x060136B5 RID: 79541 RVA: 0x004E2B10 File Offset: 0x004E0D10
		public unsafe List<ClassLoadout.EquipmentType> Equipment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralEquipment.NativeFieldInfoPtr_Equipment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<ClassLoadout.EquipmentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralEquipment.NativeFieldInfoPtr_Equipment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E28 RID: 28200
		// (get) Token: 0x060136B6 RID: 79542 RVA: 0x004E2B38 File Offset: 0x004E0D38
		// (set) Token: 0x060136B7 RID: 79543 RVA: 0x004E2B60 File Offset: 0x004E0D60
		public unsafe int Cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralEquipment.NativeFieldInfoPtr_Cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralEquipment.NativeFieldInfoPtr_Cost)) = value;
			}
		}

		// Token: 0x0400C69B RID: 50843
		private static readonly IntPtr NativeFieldInfoPtr_Equipment;

		// Token: 0x0400C69C RID: 50844
		private static readonly IntPtr NativeFieldInfoPtr_Cost;

		// Token: 0x0400C69D RID: 50845
		private static readonly IntPtr NativeMethodInfoPtr_GetIsValid_Public_Boolean_0;

		// Token: 0x0400C69E RID: 50846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
