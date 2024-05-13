using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Navigation
{
	// Token: 0x020010CE RID: 4302
	public class CustomContentNavigationMap : Il2CppSystem.Object
	{
		// Token: 0x06014497 RID: 83095 RVA: 0x0051AFC4 File Offset: 0x005191C4
		[CallerCount(0)]
		public unsafe static CustomContentNavigationMap DeSerializeVersion(string data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomContentNavigationMap.NativeMethodInfoPtr_DeSerializeVersion_Public_Static_CustomContentNavigationMap_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new CustomContentNavigationMap(intPtr2) : null;
		}

		// Token: 0x06014498 RID: 83096 RVA: 0x0051B024 File Offset: 0x00519224
		[CallerCount(0)]
		public unsafe NavigationMap GetNavigationMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomContentNavigationMap.NativeMethodInfoPtr_GetNavigationMap_Public_NavigationMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new NavigationMap(intPtr2) : null;
		}

		// Token: 0x06014499 RID: 83097 RVA: 0x0051B07C File Offset: 0x0051927C
		[CallerCount(0)]
		public unsafe CustomContentNavigationMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomContentNavigationMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601449A RID: 83098 RVA: 0x0051B0C8 File Offset: 0x005192C8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomContentNavigationMap()
		{
			Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Navigation", "CustomContentNavigationMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr);
			CustomContentNavigationMap.NativeFieldInfoPtr_SDKVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "SDKVersion");
			CustomContentNavigationMap.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "Center");
			CustomContentNavigationMap.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "Size");
			CustomContentNavigationMap.NativeFieldInfoPtr_CoverAngleSliceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "CoverAngleSliceCount");
			CustomContentNavigationMap.NativeFieldInfoPtr_MaxCoverDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "MaxCoverDistance");
			CustomContentNavigationMap.NativeFieldInfoPtr_CoverStandingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "CoverStandingHeight");
			CustomContentNavigationMap.NativeFieldInfoPtr_CoverCrouchingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "CoverCrouchingHeight");
			CustomContentNavigationMap.NativeFieldInfoPtr_FiringStandingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "FiringStandingHeight");
			CustomContentNavigationMap.NativeFieldInfoPtr_FiringCrouchingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "FiringCrouchingHeight");
			CustomContentNavigationMap.NativeFieldInfoPtr_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, "Nodes");
			CustomContentNavigationMap.NativeMethodInfoPtr_DeSerializeVersion_Public_Static_CustomContentNavigationMap_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, 100689253);
			CustomContentNavigationMap.NativeMethodInfoPtr_GetNavigationMap_Public_NavigationMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, 100689254);
			CustomContentNavigationMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr, 100689255);
		}

		// Token: 0x0601449B RID: 83099 RVA: 0x00002988 File Offset: 0x00000B88
		public CustomContentNavigationMap(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072E7 RID: 29415
		// (get) Token: 0x0601449C RID: 83100 RVA: 0x0051B1FC File Offset: 0x005193FC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CustomContentNavigationMap>.NativeClassPtr));
			}
		}

		// Token: 0x170072E8 RID: 29416
		// (get) Token: 0x0601449D RID: 83101 RVA: 0x0051B210 File Offset: 0x00519410
		// (set) Token: 0x0601449E RID: 83102 RVA: 0x0051B238 File Offset: 0x00519438
		public unsafe int SDKVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_SDKVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_SDKVersion)) = value;
			}
		}

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x0601449F RID: 83103 RVA: 0x0051B25C File Offset: 0x0051945C
		// (set) Token: 0x060144A0 RID: 83104 RVA: 0x0051B284 File Offset: 0x00519484
		public unsafe Vector3 Center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Center);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Center)) = value;
			}
		}

		// Token: 0x170072EA RID: 29418
		// (get) Token: 0x060144A1 RID: 83105 RVA: 0x0051B2A8 File Offset: 0x005194A8
		// (set) Token: 0x060144A2 RID: 83106 RVA: 0x0051B2D0 File Offset: 0x005194D0
		public unsafe float Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x170072EB RID: 29419
		// (get) Token: 0x060144A3 RID: 83107 RVA: 0x0051B2F4 File Offset: 0x005194F4
		// (set) Token: 0x060144A4 RID: 83108 RVA: 0x0051B31C File Offset: 0x0051951C
		public unsafe int CoverAngleSliceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverAngleSliceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverAngleSliceCount)) = value;
			}
		}

		// Token: 0x170072EC RID: 29420
		// (get) Token: 0x060144A5 RID: 83109 RVA: 0x0051B340 File Offset: 0x00519540
		// (set) Token: 0x060144A6 RID: 83110 RVA: 0x0051B368 File Offset: 0x00519568
		public unsafe int MaxCoverDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_MaxCoverDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_MaxCoverDistance)) = value;
			}
		}

		// Token: 0x170072ED RID: 29421
		// (get) Token: 0x060144A7 RID: 83111 RVA: 0x0051B38C File Offset: 0x0051958C
		// (set) Token: 0x060144A8 RID: 83112 RVA: 0x0051B3B4 File Offset: 0x005195B4
		public unsafe float CoverStandingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverStandingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverStandingHeight)) = value;
			}
		}

		// Token: 0x170072EE RID: 29422
		// (get) Token: 0x060144A9 RID: 83113 RVA: 0x0051B3D8 File Offset: 0x005195D8
		// (set) Token: 0x060144AA RID: 83114 RVA: 0x0051B400 File Offset: 0x00519600
		public unsafe float CoverCrouchingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverCrouchingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_CoverCrouchingHeight)) = value;
			}
		}

		// Token: 0x170072EF RID: 29423
		// (get) Token: 0x060144AB RID: 83115 RVA: 0x0051B424 File Offset: 0x00519624
		// (set) Token: 0x060144AC RID: 83116 RVA: 0x0051B44C File Offset: 0x0051964C
		public unsafe float FiringStandingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_FiringStandingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_FiringStandingHeight)) = value;
			}
		}

		// Token: 0x170072F0 RID: 29424
		// (get) Token: 0x060144AD RID: 83117 RVA: 0x0051B470 File Offset: 0x00519670
		// (set) Token: 0x060144AE RID: 83118 RVA: 0x0051B498 File Offset: 0x00519698
		public unsafe float FiringCrouchingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_FiringCrouchingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_FiringCrouchingHeight)) = value;
			}
		}

		// Token: 0x170072F1 RID: 29425
		// (get) Token: 0x060144AF RID: 83119 RVA: 0x0051B4BC File Offset: 0x005196BC
		// (set) Token: 0x060144B0 RID: 83120 RVA: 0x0051B4F0 File Offset: 0x005196F0
		public unsafe List<NavigationNode> Nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<NavigationNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomContentNavigationMap.NativeFieldInfoPtr_Nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400CF59 RID: 53081
		private static readonly IntPtr NativeFieldInfoPtr_SDKVersion;

		// Token: 0x0400CF5A RID: 53082
		private static readonly IntPtr NativeFieldInfoPtr_Center;

		// Token: 0x0400CF5B RID: 53083
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x0400CF5C RID: 53084
		private static readonly IntPtr NativeFieldInfoPtr_CoverAngleSliceCount;

		// Token: 0x0400CF5D RID: 53085
		private static readonly IntPtr NativeFieldInfoPtr_MaxCoverDistance;

		// Token: 0x0400CF5E RID: 53086
		private static readonly IntPtr NativeFieldInfoPtr_CoverStandingHeight;

		// Token: 0x0400CF5F RID: 53087
		private static readonly IntPtr NativeFieldInfoPtr_CoverCrouchingHeight;

		// Token: 0x0400CF60 RID: 53088
		private static readonly IntPtr NativeFieldInfoPtr_FiringStandingHeight;

		// Token: 0x0400CF61 RID: 53089
		private static readonly IntPtr NativeFieldInfoPtr_FiringCrouchingHeight;

		// Token: 0x0400CF62 RID: 53090
		private static readonly IntPtr NativeFieldInfoPtr_Nodes;

		// Token: 0x0400CF63 RID: 53091
		private static readonly IntPtr NativeMethodInfoPtr_DeSerializeVersion_Public_Static_CustomContentNavigationMap_String_0;

		// Token: 0x0400CF64 RID: 53092
		private static readonly IntPtr NativeMethodInfoPtr_GetNavigationMap_Public_NavigationMap_0;

		// Token: 0x0400CF65 RID: 53093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
