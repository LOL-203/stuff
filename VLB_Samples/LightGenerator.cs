using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005FB RID: 1531
	public class LightGenerator : MonoBehaviour
	{
		// Token: 0x06007BFE RID: 31742 RVA: 0x001F2A2C File Offset: 0x001F0C2C
		[CallerCount(0)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BFF RID: 31743 RVA: 0x001F2A70 File Offset: 0x001F0C70
		[CallerCount(0)]
		public unsafe LightGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C00 RID: 31744 RVA: 0x001F2ABC File Offset: 0x001F0CBC
		// Note: this type is marked as 'beforefieldinit'.
		static LightGenerator()
		{
			Il2CppClassPointerStore<LightGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "LightGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr);
			LightGenerator.NativeFieldInfoPtr_CountX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountX");
			LightGenerator.NativeFieldInfoPtr_CountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "CountY");
			LightGenerator.NativeFieldInfoPtr_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "OffsetUnits");
			LightGenerator.NativeFieldInfoPtr_PositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "PositionY");
			LightGenerator.NativeFieldInfoPtr_NoiseEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "NoiseEnabled");
			LightGenerator.NativeFieldInfoPtr_AddLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, "AddLight");
			LightGenerator.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100673207);
			LightGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr, 100673208);
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x0000210C File Offset: 0x0000030C
		public LightGenerator(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06007C02 RID: 31746 RVA: 0x001F2B8C File Offset: 0x001F0D8C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LightGenerator>.NativeClassPtr));
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x001F2BA0 File Offset: 0x001F0DA0
		// (set) Token: 0x06007C04 RID: 31748 RVA: 0x001F2BC8 File Offset: 0x001F0DC8
		public unsafe int CountX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountX)) = value;
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x001F2BEC File Offset: 0x001F0DEC
		// (set) Token: 0x06007C06 RID: 31750 RVA: 0x001F2C14 File Offset: 0x001F0E14
		public unsafe int CountY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_CountY)) = value;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x001F2C38 File Offset: 0x001F0E38
		// (set) Token: 0x06007C08 RID: 31752 RVA: 0x001F2C60 File Offset: 0x001F0E60
		public unsafe float OffsetUnits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_OffsetUnits)) = value;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06007C09 RID: 31753 RVA: 0x001F2C84 File Offset: 0x001F0E84
		// (set) Token: 0x06007C0A RID: 31754 RVA: 0x001F2CAC File Offset: 0x001F0EAC
		public unsafe float PositionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_PositionY)) = value;
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06007C0B RID: 31755 RVA: 0x001F2CD0 File Offset: 0x001F0ED0
		// (set) Token: 0x06007C0C RID: 31756 RVA: 0x001F2CF8 File Offset: 0x001F0EF8
		public unsafe bool NoiseEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_NoiseEnabled)) = value;
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06007C0D RID: 31757 RVA: 0x001F2D1C File Offset: 0x001F0F1C
		// (set) Token: 0x06007C0E RID: 31758 RVA: 0x001F2D44 File Offset: 0x001F0F44
		public unsafe bool AddLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightGenerator.NativeFieldInfoPtr_AddLight)) = value;
			}
		}

		// Token: 0x04004F6B RID: 20331
		private static readonly IntPtr NativeFieldInfoPtr_CountX;

		// Token: 0x04004F6C RID: 20332
		private static readonly IntPtr NativeFieldInfoPtr_CountY;

		// Token: 0x04004F6D RID: 20333
		private static readonly IntPtr NativeFieldInfoPtr_OffsetUnits;

		// Token: 0x04004F6E RID: 20334
		private static readonly IntPtr NativeFieldInfoPtr_PositionY;

		// Token: 0x04004F6F RID: 20335
		private static readonly IntPtr NativeFieldInfoPtr_NoiseEnabled;

		// Token: 0x04004F70 RID: 20336
		private static readonly IntPtr NativeFieldInfoPtr_AddLight;

		// Token: 0x04004F71 RID: 20337
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x04004F72 RID: 20338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
