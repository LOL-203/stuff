using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x0200060E RID: 1550
	[Serializable]
	public class RelevanceSphere : Il2CppSystem.Object
	{
		// Token: 0x06007CDF RID: 31967 RVA: 0x001F5B28 File Offset: 0x001F3D28
		[CallerCount(0)]
		public unsafe RelevanceSphere() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelevanceSphere.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x001F5B74 File Offset: 0x001F3D74
		[CallerCount(0)]
		public unsafe void SetDefault(Transform target, float fRelevance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRelevance;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelevanceSphere.NativeMethodInfoPtr_SetDefault_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x001F5BE0 File Offset: 0x001F3DE0
		// Note: this type is marked as 'beforefieldinit'.
		static RelevanceSphere()
		{
			Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UltimateGameTools.MeshSimplifier", "RelevanceSphere");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr);
			RelevanceSphere.NativeFieldInfoPtr_m_bExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, "m_bExpanded");
			RelevanceSphere.NativeFieldInfoPtr_m_v3Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, "m_v3Position");
			RelevanceSphere.NativeFieldInfoPtr_m_v3Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, "m_v3Rotation");
			RelevanceSphere.NativeFieldInfoPtr_m_v3Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, "m_v3Scale");
			RelevanceSphere.NativeFieldInfoPtr_m_fRelevance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, "m_fRelevance");
			RelevanceSphere.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, 100673255);
			RelevanceSphere.NativeMethodInfoPtr_SetDefault_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr, 100673256);
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00002988 File Offset: 0x00000B88
		public RelevanceSphere(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x001F5C9C File Offset: 0x001F3E9C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RelevanceSphere>.NativeClassPtr));
			}
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x001F5CB0 File Offset: 0x001F3EB0
		// (set) Token: 0x06007CE5 RID: 31973 RVA: 0x001F5CD8 File Offset: 0x001F3ED8
		public unsafe bool m_bExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_bExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_bExpanded)) = value;
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x001F5CFC File Offset: 0x001F3EFC
		// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x001F5D24 File Offset: 0x001F3F24
		public unsafe Vector3 m_v3Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Position)) = value;
			}
		}

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x001F5D48 File Offset: 0x001F3F48
		// (set) Token: 0x06007CE9 RID: 31977 RVA: 0x001F5D70 File Offset: 0x001F3F70
		public unsafe Vector3 m_v3Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Rotation)) = value;
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x06007CEA RID: 31978 RVA: 0x001F5D94 File Offset: 0x001F3F94
		// (set) Token: 0x06007CEB RID: 31979 RVA: 0x001F5DBC File Offset: 0x001F3FBC
		public unsafe Vector3 m_v3Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_v3Scale)) = value;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x06007CEC RID: 31980 RVA: 0x001F5DE0 File Offset: 0x001F3FE0
		// (set) Token: 0x06007CED RID: 31981 RVA: 0x001F5E08 File Offset: 0x001F4008
		public unsafe float m_fRelevance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_fRelevance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelevanceSphere.NativeFieldInfoPtr_m_fRelevance)) = value;
			}
		}

		// Token: 0x04004FE4 RID: 20452
		private static readonly IntPtr NativeFieldInfoPtr_m_bExpanded;

		// Token: 0x04004FE5 RID: 20453
		private static readonly IntPtr NativeFieldInfoPtr_m_v3Position;

		// Token: 0x04004FE6 RID: 20454
		private static readonly IntPtr NativeFieldInfoPtr_m_v3Rotation;

		// Token: 0x04004FE7 RID: 20455
		private static readonly IntPtr NativeFieldInfoPtr_m_v3Scale;

		// Token: 0x04004FE8 RID: 20456
		private static readonly IntPtr NativeFieldInfoPtr_m_fRelevance;

		// Token: 0x04004FE9 RID: 20457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FEA RID: 20458
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Transform_Single_0;
	}
}
