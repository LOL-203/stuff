using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Tayx.Graphy.Utils.NumString
{
	// Token: 0x020008E1 RID: 2273
	public static class G_IntString : Object
	{
		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x0600B94C RID: 47436 RVA: 0x002F6D74 File Offset: 0x002F4F74
		public unsafe static bool Inited
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x0600B94D RID: 47437 RVA: 0x002F6DB8 File Offset: 0x002F4FB8
		public unsafe static int MinValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x002F6DFC File Offset: 0x002F4FFC
		public unsafe static int MaxValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x002F6E40 File Offset: 0x002F5040
		[CallerCount(0)]
		public unsafe static void Init(int minNegativeValue, int maxPositiveValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minNegativeValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPositiveValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x002F6E98 File Offset: 0x002F5098
		[CallerCount(0)]
		public unsafe static string ToStringNonAlloc(this int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x002F6EE8 File Offset: 0x002F50E8
		// Note: this type is marked as 'beforefieldinit'.
		static G_IntString()
		{
			Il2CppClassPointerStore<G_IntString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Utils.NumString", "G_IntString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_IntString>.NativeClassPtr);
			G_IntString.NativeFieldInfoPtr_negativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, "negativeBuffer");
			G_IntString.NativeFieldInfoPtr_positiveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, "positiveBuffer");
			G_IntString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100678399);
			G_IntString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100678400);
			G_IntString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100678401);
			G_IntString.NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100678402);
			G_IntString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100678403);
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x00002988 File Offset: 0x00000B88
		public G_IntString(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700421C RID: 16924
		// (get) Token: 0x0600B953 RID: 47443 RVA: 0x002F6FA4 File Offset: 0x002F51A4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_IntString>.NativeClassPtr));
			}
		}

		// Token: 0x1700421D RID: 16925
		// (get) Token: 0x0600B954 RID: 47444 RVA: 0x002F6FB8 File Offset: 0x002F51B8
		// (set) Token: 0x0600B955 RID: 47445 RVA: 0x002F6FE3 File Offset: 0x002F51E3
		public unsafe static Il2CppStringArray negativeBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(G_IntString.NativeFieldInfoPtr_negativeBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_IntString.NativeFieldInfoPtr_negativeBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0600B956 RID: 47446 RVA: 0x002F6FF8 File Offset: 0x002F51F8
		// (set) Token: 0x0600B957 RID: 47447 RVA: 0x002F7023 File Offset: 0x002F5223
		public unsafe static Il2CppStringArray positiveBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(G_IntString.NativeFieldInfoPtr_positiveBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_IntString.NativeFieldInfoPtr_positiveBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040076FA RID: 30458
		private static readonly IntPtr NativeFieldInfoPtr_negativeBuffer;

		// Token: 0x040076FB RID: 30459
		private static readonly IntPtr NativeFieldInfoPtr_positiveBuffer;

		// Token: 0x040076FC RID: 30460
		private static readonly IntPtr NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0;

		// Token: 0x040076FD RID: 30461
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0;

		// Token: 0x040076FE RID: 30462
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0;

		// Token: 0x040076FF RID: 30463
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04007700 RID: 30464
		private static readonly IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0;
	}
}
