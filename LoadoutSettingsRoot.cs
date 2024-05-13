using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Settings
{
	// Token: 0x02000FD7 RID: 4055
	[Serializable]
	public class LoadoutSettingsRoot : Object
	{
		// Token: 0x06013747 RID: 79687 RVA: 0x004E4FC0 File Offset: 0x004E31C0
		[CallerCount(0)]
		public unsafe LoadoutSettingsRoot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadoutSettingsRoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013748 RID: 79688 RVA: 0x004E500C File Offset: 0x004E320C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadoutSettingsRoot()
		{
			Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Settings", "LoadoutSettingsRoot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr);
			LoadoutSettingsRoot.NativeFieldInfoPtr_LoadoutVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr, "LoadoutVersion");
			LoadoutSettingsRoot.NativeFieldInfoPtr_Loadouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr, "Loadouts");
			LoadoutSettingsRoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr, 100688115);
		}

		// Token: 0x06013749 RID: 79689 RVA: 0x00002988 File Offset: 0x00000B88
		public LoadoutSettingsRoot(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E59 RID: 28249
		// (get) Token: 0x0601374A RID: 79690 RVA: 0x004E5078 File Offset: 0x004E3278
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LoadoutSettingsRoot>.NativeClassPtr));
			}
		}

		// Token: 0x17006E5A RID: 28250
		// (get) Token: 0x0601374B RID: 79691 RVA: 0x004E508C File Offset: 0x004E328C
		// (set) Token: 0x0601374C RID: 79692 RVA: 0x004E50B4 File Offset: 0x004E32B4
		public unsafe int LoadoutVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsRoot.NativeFieldInfoPtr_LoadoutVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsRoot.NativeFieldInfoPtr_LoadoutVersion)) = value;
			}
		}

		// Token: 0x17006E5B RID: 28251
		// (get) Token: 0x0601374D RID: 79693 RVA: 0x004E50D8 File Offset: 0x004E32D8
		// (set) Token: 0x0601374E RID: 79694 RVA: 0x004E510C File Offset: 0x004E330C
		public unsafe List<LoadoutSettingsSlot> Loadouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsRoot.NativeFieldInfoPtr_Loadouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<LoadoutSettingsSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadoutSettingsRoot.NativeFieldInfoPtr_Loadouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6F1 RID: 50929
		private static readonly IntPtr NativeFieldInfoPtr_LoadoutVersion;

		// Token: 0x0400C6F2 RID: 50930
		private static readonly IntPtr NativeFieldInfoPtr_Loadouts;

		// Token: 0x0400C6F3 RID: 50931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
