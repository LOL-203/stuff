using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FCB RID: 4043
	public class GunGameProgressionType : ScriptableObject
	{
		// Token: 0x0601369E RID: 79518 RVA: 0x004E25F0 File Offset: 0x004E07F0
		[CallerCount(0)]
		public unsafe float GetNormalizedPower(int currentWave, int totalWaves, Il2CppSystem.Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentWave;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalWaves;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameProgressionType.NativeMethodInfoPtr_GetNormalizedPower_Public_Single_Int32_Int32_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601369F RID: 79519 RVA: 0x004E2680 File Offset: 0x004E0880
		[CallerCount(0)]
		public unsafe GunGameProgressionType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameProgressionType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136A0 RID: 79520 RVA: 0x004E26CC File Offset: 0x004E08CC
		// Note: this type is marked as 'beforefieldinit'.
		static GunGameProgressionType()
		{
			Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "GunGameProgressionType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr);
			GunGameProgressionType.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "Description");
			GunGameProgressionType.NativeFieldInfoPtr_PowerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "PowerCurve");
			GunGameProgressionType.NativeFieldInfoPtr_Chaos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "Chaos");
			GunGameProgressionType.NativeFieldInfoPtr_Static = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "Static");
			GunGameProgressionType.NativeFieldInfoPtr_StaticProgression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "StaticProgression");
			GunGameProgressionType.NativeFieldInfoPtr_StaticEquipmentOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, "StaticEquipmentOption");
			GunGameProgressionType.NativeMethodInfoPtr_GetNormalizedPower_Public_Single_Int32_Int32_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, 100688070);
			GunGameProgressionType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr, 100688071);
		}

		// Token: 0x060136A1 RID: 79521 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		public GunGameProgressionType(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E1F RID: 28191
		// (get) Token: 0x060136A2 RID: 79522 RVA: 0x004E279C File Offset: 0x004E099C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameProgressionType>.NativeClassPtr));
			}
		}

		// Token: 0x17006E20 RID: 28192
		// (get) Token: 0x060136A3 RID: 79523 RVA: 0x004E27B0 File Offset: 0x004E09B0
		// (set) Token: 0x060136A4 RID: 79524 RVA: 0x004E27D9 File Offset: 0x004E09D9
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17006E21 RID: 28193
		// (get) Token: 0x060136A5 RID: 79525 RVA: 0x004E2800 File Offset: 0x004E0A00
		// (set) Token: 0x060136A6 RID: 79526 RVA: 0x004E2834 File Offset: 0x004E0A34
		public unsafe AnimationCurve PowerCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_PowerCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_PowerCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x060136A7 RID: 79527 RVA: 0x004E285C File Offset: 0x004E0A5C
		// (set) Token: 0x060136A8 RID: 79528 RVA: 0x004E2884 File Offset: 0x004E0A84
		public unsafe bool Chaos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Chaos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Chaos)) = value;
			}
		}

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x060136A9 RID: 79529 RVA: 0x004E28A8 File Offset: 0x004E0AA8
		// (set) Token: 0x060136AA RID: 79530 RVA: 0x004E28D0 File Offset: 0x004E0AD0
		public unsafe bool Static
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Static);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_Static)) = value;
			}
		}

		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x060136AB RID: 79531 RVA: 0x004E28F4 File Offset: 0x004E0AF4
		// (set) Token: 0x060136AC RID: 79532 RVA: 0x004E2928 File Offset: 0x004E0B28
		public unsafe Il2CppReferenceArray<SerializedLoadout> StaticProgression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_StaticProgression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<SerializedLoadout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_StaticProgression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x060136AD RID: 79533 RVA: 0x004E2950 File Offset: 0x004E0B50
		// (set) Token: 0x060136AE RID: 79534 RVA: 0x004E2984 File Offset: 0x004E0B84
		public unsafe GunGameEquipmentOption StaticEquipmentOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_StaticEquipmentOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GunGameEquipmentOption(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameProgressionType.NativeFieldInfoPtr_StaticEquipmentOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C693 RID: 50835
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400C694 RID: 50836
		private static readonly IntPtr NativeFieldInfoPtr_PowerCurve;

		// Token: 0x0400C695 RID: 50837
		private static readonly IntPtr NativeFieldInfoPtr_Chaos;

		// Token: 0x0400C696 RID: 50838
		private static readonly IntPtr NativeFieldInfoPtr_Static;

		// Token: 0x0400C697 RID: 50839
		private static readonly IntPtr NativeFieldInfoPtr_StaticProgression;

		// Token: 0x0400C698 RID: 50840
		private static readonly IntPtr NativeFieldInfoPtr_StaticEquipmentOption;

		// Token: 0x0400C699 RID: 50841
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedPower_Public_Single_Int32_Int32_Random_0;

		// Token: 0x0400C69A RID: 50842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
