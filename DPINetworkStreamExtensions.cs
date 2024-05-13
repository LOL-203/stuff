using System;
using Il2CppSystem;
using Onward.Networking;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Networking.IO
{
	// Token: 0x0200127A RID: 4730
	public static class DPINetworkStreamExtensions : Il2CppSystem.Object
	{
		// Token: 0x0601583B RID: 88123 RVA: 0x0056B6A8 File Offset: 0x005698A8
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Il2CppStructArray<Vector2> vecArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vecArray);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601583C RID: 88124 RVA: 0x0056B70C File Offset: 0x0056990C
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Il2CppStructArray<Vector2> vecArray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vecArray);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601583D RID: 88125 RVA: 0x0056B770 File Offset: 0x00569970
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Vector2 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601583E RID: 88126 RVA: 0x0056B7D0 File Offset: 0x005699D0
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Vector2 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601583F RID: 88127 RVA: 0x0056B830 File Offset: 0x00569A30
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Vector3 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015840 RID: 88128 RVA: 0x0056B890 File Offset: 0x00569A90
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Vector3 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015841 RID: 88129 RVA: 0x0056B8F0 File Offset: 0x00569AF0
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Nullable<Vector3> vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vec);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015842 RID: 88130 RVA: 0x0056B954 File Offset: 0x00569B54
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Nullable<Vector3> vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(vec);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015843 RID: 88131 RVA: 0x0056B9B8 File Offset: 0x00569BB8
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Vector4 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015844 RID: 88132 RVA: 0x0056BA18 File Offset: 0x00569C18
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Vector4 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015845 RID: 88133 RVA: 0x0056BA78 File Offset: 0x00569C78
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Color vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Color_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015846 RID: 88134 RVA: 0x0056BAD8 File Offset: 0x00569CD8
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Color vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Color_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015847 RID: 88135 RVA: 0x0056BB38 File Offset: 0x00569D38
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref Quaternion quaternion)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &quaternion;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Quaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015848 RID: 88136 RVA: 0x0056BB98 File Offset: 0x00569D98
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out Quaternion quaternion)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &quaternion;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Quaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015849 RID: 88137 RVA: 0x0056BBF8 File Offset: 0x00569DF8
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref DPIPlayer player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			player = ((intPtr3 == 0) ? null : new DPIPlayer(intPtr3));
		}

		// Token: 0x0601584A RID: 88138 RVA: 0x0056BC7C File Offset: 0x00569E7C
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out DPIPlayer player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			player = ((intPtr3 == 0) ? null : new DPIPlayer(intPtr3));
		}

		// Token: 0x0601584B RID: 88139 RVA: 0x0056BD00 File Offset: 0x00569F00
		[CallerCount(0)]
		public unsafe static void Write(this DPINetworkStream stream, ref OnwardPhotonPlayer player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			player = ((intPtr3 == 0) ? null : new OnwardPhotonPlayer(intPtr3));
		}

		// Token: 0x0601584C RID: 88140 RVA: 0x0056BD84 File Offset: 0x00569F84
		[CallerCount(0)]
		public unsafe static void Read(this DPINetworkStream stream, out OnwardPhotonPlayer player)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			player = ((intPtr3 == 0) ? null : new OnwardPhotonPlayer(intPtr3));
		}

		// Token: 0x0601584D RID: 88141 RVA: 0x0056BE08 File Offset: 0x0056A008
		// Note: this type is marked as 'beforefieldinit'.
		static DPINetworkStreamExtensions()
		{
			Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "DPINetworkStreamExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690939);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690940);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690941);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690942);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690943);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690944);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690945);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690946);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690947);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690948);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690949);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690950);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690951);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690952);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690953);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690954);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690955);
			DPINetworkStreamExtensions.NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr, 100690956);
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x00002988 File Offset: 0x00000B88
		public DPINetworkStreamExtensions(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007941 RID: 31041
		// (get) Token: 0x0601584F RID: 88143 RVA: 0x0056BFA0 File Offset: 0x0056A1A0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPINetworkStreamExtensions>.NativeClassPtr));
			}
		}

		// Token: 0x0400DCB3 RID: 56499
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0;

		// Token: 0x0400DCB4 RID: 56500
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_ArrayOf_Vector2_0;

		// Token: 0x0400DCB5 RID: 56501
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector2_0;

		// Token: 0x0400DCB6 RID: 56502
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector2_0;

		// Token: 0x0400DCB7 RID: 56503
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector3_0;

		// Token: 0x0400DCB8 RID: 56504
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector3_0;

		// Token: 0x0400DCB9 RID: 56505
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0;

		// Token: 0x0400DCBA RID: 56506
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Nullable_1_Vector3_0;

		// Token: 0x0400DCBB RID: 56507
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Vector4_0;

		// Token: 0x0400DCBC RID: 56508
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Vector4_0;

		// Token: 0x0400DCBD RID: 56509
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Color_0;

		// Token: 0x0400DCBE RID: 56510
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Color_0;

		// Token: 0x0400DCBF RID: 56511
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_Quaternion_0;

		// Token: 0x0400DCC0 RID: 56512
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_Quaternion_0;

		// Token: 0x0400DCC1 RID: 56513
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0;

		// Token: 0x0400DCC2 RID: 56514
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_DPIPlayer_0;

		// Token: 0x0400DCC3 RID: 56515
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0;

		// Token: 0x0400DCC4 RID: 56516
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Void_DPINetworkStream_byref_OnwardPhotonPlayer_0;
	}
}
