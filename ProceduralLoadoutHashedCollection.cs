using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FCF RID: 4047
	[Serializable]
	public class ProceduralLoadoutHashedCollection : Object
	{
		// Token: 0x060136DD RID: 79581 RVA: 0x004E3388 File Offset: 0x004E1588
		[CallerCount(0)]
		public unsafe ProceduralLoadoutHashedCollection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralLoadoutHashedCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136DE RID: 79582 RVA: 0x004E33D4 File Offset: 0x004E15D4
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralLoadoutHashedCollection()
		{
			Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "ProceduralLoadoutHashedCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr);
			ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr, "Hash");
			ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Loadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr, "Loadouts");
			ProceduralLoadoutHashedCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr, 100688080);
		}

		// Token: 0x060136DF RID: 79583 RVA: 0x00002988 File Offset: 0x00000B88
		public ProceduralLoadoutHashedCollection(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E38 RID: 28216
		// (get) Token: 0x060136E0 RID: 79584 RVA: 0x004E3440 File Offset: 0x004E1640
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ProceduralLoadoutHashedCollection>.NativeClassPtr));
			}
		}

		// Token: 0x17006E39 RID: 28217
		// (get) Token: 0x060136E1 RID: 79585 RVA: 0x004E3454 File Offset: 0x004E1654
		// (set) Token: 0x060136E2 RID: 79586 RVA: 0x004E347C File Offset: 0x004E167C
		public unsafe int Hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Hash)) = value;
			}
		}

		// Token: 0x17006E3A RID: 28218
		// (get) Token: 0x060136E3 RID: 79587 RVA: 0x004E34A0 File Offset: 0x004E16A0
		// (set) Token: 0x060136E4 RID: 79588 RVA: 0x004E34D4 File Offset: 0x004E16D4
		public unsafe Il2CppReferenceArray<ProceduralLoadout> Loadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Loadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ProceduralLoadout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralLoadoutHashedCollection.NativeFieldInfoPtr_Loadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6B1 RID: 50865
		private static readonly IntPtr NativeFieldInfoPtr_Hash;

		// Token: 0x0400C6B2 RID: 50866
		private static readonly IntPtr NativeFieldInfoPtr_Loadouts;

		// Token: 0x0400C6B3 RID: 50867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
