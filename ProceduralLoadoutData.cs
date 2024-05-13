using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FCE RID: 4046
	public class ProceduralLoadoutData : ScriptableObject
	{
		// Token: 0x060136D7 RID: 79575 RVA: 0x004E3274 File Offset: 0x004E1474
		[CallerCount(0)]
		public unsafe ProceduralLoadoutData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadoutData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136D8 RID: 79576 RVA: 0x004E32C0 File Offset: 0x004E14C0
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralLoadoutData()
		{
			Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "ProceduralLoadoutData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr);
			ProceduralLoadoutData.NativeFieldInfoPtr_AllLoadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr, "AllLoadouts");
			ProceduralLoadoutData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr, 100688079);
		}

		// Token: 0x060136D9 RID: 79577 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		public ProceduralLoadoutData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E36 RID: 28214
		// (get) Token: 0x060136DA RID: 79578 RVA: 0x004E3318 File Offset: 0x004E1518
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProceduralLoadoutData>.NativeClassPtr));
			}
		}

		// Token: 0x17006E37 RID: 28215
		// (get) Token: 0x060136DB RID: 79579 RVA: 0x004E332C File Offset: 0x004E152C
		// (set) Token: 0x060136DC RID: 79580 RVA: 0x004E3360 File Offset: 0x004E1560
		public unsafe Il2CppReferenceArray<ProceduralLoadoutHashedCollection> AllLoadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutData.NativeFieldInfoPtr_AllLoadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ProceduralLoadoutHashedCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutData.NativeFieldInfoPtr_AllLoadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6AF RID: 50863
		private static readonly IntPtr NativeFieldInfoPtr_AllLoadouts;

		// Token: 0x0400C6B0 RID: 50864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
