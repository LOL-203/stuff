using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FC2 RID: 4034
	[Serializable]
	public class GunGameEquipmentOption : Object
	{
		// Token: 0x060135CF RID: 79311 RVA: 0x004DF238 File Offset: 0x004DD438
		[CallerCount(0)]
		public unsafe GunGameEquipmentOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameEquipmentOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060135D0 RID: 79312 RVA: 0x004DF284 File Offset: 0x004DD484
		// Note: this type is marked as 'beforefieldinit'.
		static GunGameEquipmentOption()
		{
			Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "GunGameEquipmentOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr);
			GunGameEquipmentOption.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr, "Description");
			GunGameEquipmentOption.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr, "Chance");
			GunGameEquipmentOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr, 100688020);
		}

		// Token: 0x060135D1 RID: 79313 RVA: 0x00002988 File Offset: 0x00000B88
		public GunGameEquipmentOption(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x060135D2 RID: 79314 RVA: 0x004DF2F0 File Offset: 0x004DD4F0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameEquipmentOption>.NativeClassPtr));
			}
		}

		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x060135D3 RID: 79315 RVA: 0x004DF304 File Offset: 0x004DD504
		// (set) Token: 0x060135D4 RID: 79316 RVA: 0x004DF32D File Offset: 0x004DD52D
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameEquipmentOption.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameEquipmentOption.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17006DCB RID: 28107
		// (get) Token: 0x060135D5 RID: 79317 RVA: 0x004DF354 File Offset: 0x004DD554
		// (set) Token: 0x060135D6 RID: 79318 RVA: 0x004DF37C File Offset: 0x004DD57C
		public unsafe float Chance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameEquipmentOption.NativeFieldInfoPtr_Chance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GunGameEquipmentOption.NativeFieldInfoPtr_Chance)) = value;
			}
		}

		// Token: 0x0400C61C RID: 50716
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400C61D RID: 50717
		private static readonly IntPtr NativeFieldInfoPtr_Chance;

		// Token: 0x0400C61E RID: 50718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
