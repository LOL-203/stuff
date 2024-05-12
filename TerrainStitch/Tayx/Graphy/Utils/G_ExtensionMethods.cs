using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Utils
{
	// Token: 0x020008DE RID: 2270
	public static class G_ExtensionMethods : Il2CppSystem.Object
	{
		// Token: 0x0600B923 RID: 47395 RVA: 0x002F6274 File Offset: 0x002F4474
		[CallerCount(0)]
		public unsafe static List<GameObject> SetAllActive(this List<GameObject> gameObjects, bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
		}

		// Token: 0x0600B924 RID: 47396 RVA: 0x002F62E8 File Offset: 0x002F44E8
		[CallerCount(0)]
		public unsafe static List<Image> SetOneActive(this List<Image> images, int active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(images);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x002F635C File Offset: 0x002F455C
		[CallerCount(0)]
		public unsafe static List<Image> SetAllActive(this List<Image> images, bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(images);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<Image>(intPtr2) : null;
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x002F63D0 File Offset: 0x002F45D0
		// Note: this type is marked as 'beforefieldinit'.
		static G_ExtensionMethods()
		{
			Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Utils", "G_ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr);
			G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100678379);
			G_ExtensionMethods.NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100678380);
			G_ExtensionMethods.NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr, 100678381);
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x00002988 File Offset: 0x00000B88
		public G_ExtensionMethods(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0600B928 RID: 47400 RVA: 0x002F643C File Offset: 0x002F463C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_ExtensionMethods>.NativeClassPtr));
			}
		}

		// Token: 0x040076E1 RID: 30433
		private static readonly IntPtr NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_GameObject_List_1_GameObject_Boolean_0;

		// Token: 0x040076E2 RID: 30434
		private static readonly IntPtr NativeMethodInfoPtr_SetOneActive_Public_Static_List_1_Image_List_1_Image_Int32_0;

		// Token: 0x040076E3 RID: 30435
		private static readonly IntPtr NativeMethodInfoPtr_SetAllActive_Public_Static_List_1_Image_List_1_Image_Boolean_0;
	}
}
