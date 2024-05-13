using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Onward.GameVariants;
using Onward.Player;
using Onward.UI;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using _Game.GameVariants.Objectives;

namespace DPI.Networking.IO
{
	// Token: 0x02001270 RID: 4720
	public class DPINetworkStream : Object
	{
		// Token: 0x1700792E RID: 31022
		// (get) Token: 0x0601577D RID: 87933 RVA: 0x00567114 File Offset: 0x00565314
		// (set) Token: 0x0601577E RID: 87934 RVA: 0x00567164 File Offset: 0x00565364
		public unsafe bool IsReading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_IsReading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_set_IsReading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700792F RID: 31023
		// (get) Token: 0x0601577F RID: 87935 RVA: 0x005671B8 File Offset: 0x005653B8
		public unsafe bool IsWriting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_IsWriting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x00567208 File Offset: 0x00565408
		[CallerCount(0)]
		public unsafe int RoundBitsToByte(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bits;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_RoundBitsToByte_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17007930 RID: 31024
		// (get) Token: 0x06015781 RID: 87937 RVA: 0x0056726C File Offset: 0x0056546C
		public unsafe int ByteWriteLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_ByteWriteLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17007931 RID: 31025
		// (get) Token: 0x06015782 RID: 87938 RVA: 0x005672BC File Offset: 0x005654BC
		public unsafe int ByteReadLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_ByteReadLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17007932 RID: 31026
		// (get) Token: 0x06015783 RID: 87939 RVA: 0x0056730C File Offset: 0x0056550C
		// (set) Token: 0x06015784 RID: 87940 RVA: 0x0056735C File Offset: 0x0056555C
		public unsafe int BitsWritePos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_BitsWritePos_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_set_BitsWritePos_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007933 RID: 31027
		// (get) Token: 0x06015785 RID: 87941 RVA: 0x005673B0 File Offset: 0x005655B0
		// (set) Token: 0x06015786 RID: 87942 RVA: 0x00567400 File Offset: 0x00565600
		public unsafe int BitsReadPos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_BitsReadPos_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_set_BitsReadPos_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007934 RID: 31028
		// (get) Token: 0x06015787 RID: 87943 RVA: 0x00567454 File Offset: 0x00565654
		public unsafe Il2CppStructArray<byte> Buffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_Buffer_Public_get_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<byte>(intPtr2) : null;
			}
		}

		// Token: 0x06015788 RID: 87944 RVA: 0x005674AC File Offset: 0x005656AC
		[CallerCount(0)]
		public unsafe DPINetworkStream() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015789 RID: 87945 RVA: 0x005674F8 File Offset: 0x005656F8
		[CallerCount(0)]
		public unsafe DPINetworkStream(DPINetworkStreamType streamType, int bufferSizeInBytes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref streamType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSizeInBytes;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStreamType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601578A RID: 87946 RVA: 0x00567568 File Offset: 0x00565768
		[CallerCount(0)]
		public unsafe void Init(DPINetworkStreamType streamType, Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref streamType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Init_Private_Void_DPINetworkStreamType_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601578B RID: 87947 RVA: 0x005675D4 File Offset: 0x005657D4
		[CallerCount(0)]
		public unsafe void Reset(DPINetworkStreamType streamType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref streamType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Reset_Public_Void_DPINetworkStreamType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601578C RID: 87948 RVA: 0x00567628 File Offset: 0x00565828
		[CallerCount(0)]
		public unsafe void ChangeStreamType(DPINetworkStreamType streamType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref streamType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_ChangeStreamType_Public_Void_DPINetworkStreamType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601578D RID: 87949 RVA: 0x0056767C File Offset: 0x0056587C
		[CallerCount(0)]
		public unsafe void Reset(ArraySegment<byte> arraySegment, DPINetworkStreamType streamType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arraySegment));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref streamType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Reset_Public_Void_ArraySegment_1_Byte_DPINetworkStreamType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601578E RID: 87950 RVA: 0x005676F0 File Offset: 0x005658F0
		[CallerCount(0)]
		public unsafe ArraySegment<byte> ToArraySegment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new ArraySegment<byte>(intPtr);
		}

		// Token: 0x0601578F RID: 87951 RVA: 0x0056773C File Offset: 0x0056593C
		[CallerCount(0)]
		public unsafe ArraySegment<byte> ToArraySegment(int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new ArraySegment<byte>(intPtr);
		}

		// Token: 0x06015790 RID: 87952 RVA: 0x005677AC File Offset: 0x005659AC
		[CallerCount(0)]
		public unsafe void SeekToMarker(LocationMarker marker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref marker;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_SeekToMarker_Public_Void_LocationMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015791 RID: 87953 RVA: 0x00567800 File Offset: 0x00565A00
		[CallerCount(0)]
		public unsafe LocationMarker CreateMarker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_CreateMarker_Public_LocationMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015792 RID: 87954 RVA: 0x00567850 File Offset: 0x00565A50
		[CallerCount(0)]
		public unsafe void AppendStream(DPINetworkStream otherStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_AppendStream_Public_Void_DPINetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015793 RID: 87955 RVA: 0x005678AC File Offset: 0x00565AAC
		[CallerCount(0)]
		public unsafe void AppendRestToOtherStream(DPINetworkStream destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_AppendRestToOtherStream_Public_Void_DPINetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17007935 RID: 31029
		// (get) Token: 0x06015794 RID: 87956 RVA: 0x00567908 File Offset: 0x00565B08
		// (set) Token: 0x06015795 RID: 87957 RVA: 0x00567958 File Offset: 0x00565B58
		public unsafe bool CreatedByPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_get_CreatedByPool_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_set_CreatedByPool_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x005679AC File Offset: 0x00565BAC
		[CallerCount(0)]
		public unsafe void ReturnedToPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_ReturnedToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015797 RID: 87959 RVA: 0x005679F0 File Offset: 0x00565BF0
		[CallerCount(0)]
		public unsafe void Write(ref bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015798 RID: 87960 RVA: 0x00567A48 File Offset: 0x00565C48
		[CallerCount(0)]
		public unsafe void Read(out bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x00567AA0 File Offset: 0x00565CA0
		[CallerCount(0)]
		public unsafe void Write(ref byte value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579A RID: 87962 RVA: 0x00567B08 File Offset: 0x00565D08
		[CallerCount(0)]
		public unsafe void Read(out byte value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579B RID: 87963 RVA: 0x00567B70 File Offset: 0x00565D70
		[CallerCount(0)]
		public unsafe void Write(ref sbyte value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579C RID: 87964 RVA: 0x00567BD8 File Offset: 0x00565DD8
		[CallerCount(0)]
		public unsafe void Read(out sbyte value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579D RID: 87965 RVA: 0x00567C40 File Offset: 0x00565E40
		[CallerCount(0)]
		public unsafe void Write(ref ushort value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579E RID: 87966 RVA: 0x00567CA8 File Offset: 0x00565EA8
		[CallerCount(0)]
		public unsafe void Read(out ushort value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601579F RID: 87967 RVA: 0x00567D10 File Offset: 0x00565F10
		[CallerCount(0)]
		public unsafe void Write(ref short value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A0 RID: 87968 RVA: 0x00567D78 File Offset: 0x00565F78
		[CallerCount(0)]
		public unsafe void Read(out short value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int16_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A1 RID: 87969 RVA: 0x00567DE0 File Offset: 0x00565FE0
		[CallerCount(0)]
		public unsafe void Write(ref char value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A2 RID: 87970 RVA: 0x00567E48 File Offset: 0x00566048
		[CallerCount(0)]
		public unsafe void Read(out char value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A3 RID: 87971 RVA: 0x00567EB0 File Offset: 0x005660B0
		[CallerCount(0)]
		public unsafe void Write(ref uint value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A4 RID: 87972 RVA: 0x00567F18 File Offset: 0x00566118
		[CallerCount(0)]
		public unsafe void Read(out uint value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A5 RID: 87973 RVA: 0x00567F80 File Offset: 0x00566180
		[CallerCount(0)]
		public unsafe void Write(ref int value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A6 RID: 87974 RVA: 0x00567FE8 File Offset: 0x005661E8
		[CallerCount(0)]
		public unsafe void Read(out int value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A7 RID: 87975 RVA: 0x00568050 File Offset: 0x00566250
		[CallerCount(0)]
		public unsafe void Write(ref ulong value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A8 RID: 87976 RVA: 0x005680B8 File Offset: 0x005662B8
		[CallerCount(0)]
		public unsafe void Read(out ulong value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157A9 RID: 87977 RVA: 0x00568120 File Offset: 0x00566320
		[CallerCount(0)]
		public unsafe void Write(ref long value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AA RID: 87978 RVA: 0x00568188 File Offset: 0x00566388
		[CallerCount(0)]
		public unsafe void Read(out long value, [Optional] int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AB RID: 87979 RVA: 0x005681F0 File Offset: 0x005663F0
		[CallerCount(0)]
		public unsafe void Write(ref float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AC RID: 87980 RVA: 0x00568248 File Offset: 0x00566448
		[CallerCount(0)]
		public unsafe void Read(out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x005682A0 File Offset: 0x005664A0
		[CallerCount(0)]
		public unsafe void Write(ref double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x005682F8 File Offset: 0x005664F8
		[CallerCount(0)]
		public unsafe void Read(out double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x00568350 File Offset: 0x00566550
		[CallerCount(0)]
		public unsafe void Write(ref DPIQuaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIQuaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x005683A8 File Offset: 0x005665A8
		[CallerCount(0)]
		public unsafe void Read(out DPIQuaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIQuaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B1 RID: 87985 RVA: 0x00568400 File Offset: 0x00566600
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B2 RID: 87986 RVA: 0x0056845C File Offset: 0x0056665C
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B3 RID: 87987 RVA: 0x005684B8 File Offset: 0x005666B8
		[CallerCount(0)]
		public unsafe void Write(ref ArraySegment<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B4 RID: 87988 RVA: 0x00568514 File Offset: 0x00566714
		[CallerCount(0)]
		public unsafe void WriteWithoutLeadingArrayLength(ref ArraySegment<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_WriteWithoutLeadingArrayLength_Public_Void_byref_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B5 RID: 87989 RVA: 0x00568570 File Offset: 0x00566770
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x005685CC File Offset: 0x005667CC
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x00568628 File Offset: 0x00566828
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x00568684 File Offset: 0x00566884
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157B9 RID: 87993 RVA: 0x005686E0 File Offset: 0x005668E0
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStringArray value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new Il2CppStringArray(intPtr3));
		}

		// Token: 0x060157BA RID: 87994 RVA: 0x0056875C File Offset: 0x0056695C
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStringArray value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new Il2CppStringArray(intPtr3));
		}

		// Token: 0x060157BB RID: 87995 RVA: 0x005687D8 File Offset: 0x005669D8
		[CallerCount(0)]
		public unsafe void Write(ref DPIVector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIVector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157BC RID: 87996 RVA: 0x00568830 File Offset: 0x00566A30
		[CallerCount(0)]
		public unsafe void Read(out DPIVector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIVector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157BD RID: 87997 RVA: 0x00568888 File Offset: 0x00566A88
		[CallerCount(0)]
		public unsafe void Write(ref Dictionary<int, Il2CppStructArray<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new Dictionary(intPtr3));
		}

		// Token: 0x060157BE RID: 87998 RVA: 0x00568904 File Offset: 0x00566B04
		[CallerCount(0)]
		public unsafe void Read(out Dictionary<int, Il2CppStructArray<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new Dictionary(intPtr3));
		}

		// Token: 0x060157BF RID: 87999 RVA: 0x00568980 File Offset: 0x00566B80
		[CallerCount(0)]
		public unsafe void Write(ref string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			value = IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060157C0 RID: 88000 RVA: 0x005689F4 File Offset: 0x00566BF4
		[CallerCount(0)]
		public unsafe void Read(out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			value = IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060157C1 RID: 88001 RVA: 0x00568A68 File Offset: 0x00566C68
		[CallerCount(0)]
		public unsafe void Write(ref DPIHashtable hashtable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			hashtable = ((intPtr3 == 0) ? null : new DPIHashtable(intPtr3));
		}

		// Token: 0x060157C2 RID: 88002 RVA: 0x00568AE4 File Offset: 0x00566CE4
		[CallerCount(0)]
		public unsafe void ReadPooled(out DPIHashtable hashtable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_ReadPooled_Public_Void_byref_DPIHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			hashtable = ((intPtr3 == 0) ? null : new DPIHashtable(intPtr3));
		}

		// Token: 0x060157C3 RID: 88003 RVA: 0x00568B60 File Offset: 0x00566D60
		[CallerCount(0)]
		public unsafe void Read(out DPIHashtable hashtable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			hashtable = ((intPtr3 == 0) ? null : new DPIHashtable(intPtr3));
		}

		// Token: 0x060157C4 RID: 88004 RVA: 0x00568BDC File Offset: 0x00566DDC
		[CallerCount(0)]
		public unsafe void Write<TWrite>(ref TWrite value) where TWrite : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.MethodInfoStoreGeneric_Write_Public_Void_byref_TWrite_0<TWrite>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new TWrite(intPtr3));
		}

		// Token: 0x060157C5 RID: 88005 RVA: 0x00568C58 File Offset: 0x00566E58
		[CallerCount(0)]
		public unsafe void Read<TRead>(out TRead value) where TRead : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.MethodInfoStoreGeneric_Read_Public_Void_byref_TRead_0<TRead>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			value = ((intPtr3 == 0) ? null : new TRead(intPtr3));
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x00568CD4 File Offset: 0x00566ED4
		[CallerCount(0)]
		public unsafe void Write(ref OnwardMap value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_OnwardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157C7 RID: 88007 RVA: 0x00568D2C File Offset: 0x00566F2C
		[CallerCount(0)]
		public unsafe void Read(out OnwardMap value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_OnwardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157C8 RID: 88008 RVA: 0x00568D84 File Offset: 0x00566F84
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<OnwardMap> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_OnwardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157C9 RID: 88009 RVA: 0x00568DE0 File Offset: 0x00566FE0
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<OnwardMap> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_OnwardMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x00568E3C File Offset: 0x0056703C
		[CallerCount(0)]
		public unsafe void Write(ref Faction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CB RID: 88011 RVA: 0x00568E94 File Offset: 0x00567094
		[CallerCount(0)]
		public unsafe void Read(out Faction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CC RID: 88012 RVA: 0x00568EEC File Offset: 0x005670EC
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<Faction> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CD RID: 88013 RVA: 0x00568F48 File Offset: 0x00567148
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<Faction> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CE RID: 88014 RVA: 0x00568FA4 File Offset: 0x005671A4
		[CallerCount(0)]
		public unsafe void Write(ref GameVariantPlayStyle value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantPlayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157CF RID: 88015 RVA: 0x00568FFC File Offset: 0x005671FC
		[CallerCount(0)]
		public unsafe void Read(out GameVariantPlayStyle value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantPlayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D0 RID: 88016 RVA: 0x00569054 File Offset: 0x00567254
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<GameVariantPlayStyle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D1 RID: 88017 RVA: 0x005690B0 File Offset: 0x005672B0
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<GameVariantPlayStyle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D2 RID: 88018 RVA: 0x0056910C File Offset: 0x0056730C
		[CallerCount(0)]
		public unsafe void Write(ref GameVariantTypes value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D3 RID: 88019 RVA: 0x00569164 File Offset: 0x00567364
		[CallerCount(0)]
		public unsafe void Read(out GameVariantTypes value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D4 RID: 88020 RVA: 0x005691BC File Offset: 0x005673BC
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<GameVariantTypes> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D5 RID: 88021 RVA: 0x00569218 File Offset: 0x00567418
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<GameVariantTypes> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D6 RID: 88022 RVA: 0x00569274 File Offset: 0x00567474
		[CallerCount(0)]
		public unsafe void Write(ref UplinkState value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UplinkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D7 RID: 88023 RVA: 0x005692CC File Offset: 0x005674CC
		[CallerCount(0)]
		public unsafe void Read(out UplinkState value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UplinkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x00569324 File Offset: 0x00567524
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<UplinkState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_UplinkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157D9 RID: 88025 RVA: 0x00569380 File Offset: 0x00567580
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<UplinkState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_UplinkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x005693DC File Offset: 0x005675DC
		[CallerCount(0)]
		public unsafe void Write(ref ClassLoadout.AmmoType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x00569434 File Offset: 0x00567634
		[CallerCount(0)]
		public unsafe void Read(out ClassLoadout.AmmoType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x0056948C File Offset: 0x0056768C
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<ClassLoadout.AmmoType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x005694E8 File Offset: 0x005676E8
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<ClassLoadout.AmmoType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x00569544 File Offset: 0x00567744
		[CallerCount(0)]
		public unsafe void Write(ref SoldierClass value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_SoldierClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157DF RID: 88031 RVA: 0x0056959C File Offset: 0x0056779C
		[CallerCount(0)]
		public unsafe void Read(out SoldierClass value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_SoldierClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E0 RID: 88032 RVA: 0x005695F4 File Offset: 0x005677F4
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<SoldierClass> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_SoldierClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E1 RID: 88033 RVA: 0x00569650 File Offset: 0x00567850
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<SoldierClass> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_SoldierClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E2 RID: 88034 RVA: 0x005696AC File Offset: 0x005678AC
		[CallerCount(0)]
		public unsafe void Write(ref Interactable_Openable.State value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E3 RID: 88035 RVA: 0x00569704 File Offset: 0x00567904
		[CallerCount(0)]
		public unsafe void Read(out Interactable_Openable.State value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x0056975C File Offset: 0x0056795C
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<Interactable_Openable.State> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x005697B8 File Offset: 0x005679B8
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<Interactable_Openable.State> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x00569814 File Offset: 0x00567A14
		[CallerCount(0)]
		public unsafe void Write(ref Pickup.ItemType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E7 RID: 88039 RVA: 0x0056986C File Offset: 0x00567A6C
		[CallerCount(0)]
		public unsafe void Read(out Pickup.ItemType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E8 RID: 88040 RVA: 0x005698C4 File Offset: 0x00567AC4
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<Pickup.ItemType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157E9 RID: 88041 RVA: 0x00569920 File Offset: 0x00567B20
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<Pickup.ItemType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_ItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157EA RID: 88042 RVA: 0x0056997C File Offset: 0x00567B7C
		[CallerCount(0)]
		public unsafe void Write(ref HandBaseState value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_HandBaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157EB RID: 88043 RVA: 0x005699D4 File Offset: 0x00567BD4
		[CallerCount(0)]
		public unsafe void Read(out HandBaseState value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_HandBaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157EC RID: 88044 RVA: 0x00569A2C File Offset: 0x00567C2C
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<HandBaseState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_HandBaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x00569A88 File Offset: 0x00567C88
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<HandBaseState> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_HandBaseState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x00569AE4 File Offset: 0x00567CE4
		[CallerCount(0)]
		public unsafe void Write(ref MapVoteButtonType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_MapVoteButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x00569B3C File Offset: 0x00567D3C
		[CallerCount(0)]
		public unsafe void Read(out MapVoteButtonType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_MapVoteButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x00569B94 File Offset: 0x00567D94
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<MapVoteButtonType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MapVoteButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F1 RID: 88049 RVA: 0x00569BF0 File Offset: 0x00567DF0
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<MapVoteButtonType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MapVoteButtonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x00569C4C File Offset: 0x00567E4C
		[CallerCount(0)]
		public unsafe void Write(ref DamageLibrary.MaterialType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F3 RID: 88051 RVA: 0x00569CA4 File Offset: 0x00567EA4
		[CallerCount(0)]
		public unsafe void Read(out DamageLibrary.MaterialType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F4 RID: 88052 RVA: 0x00569CFC File Offset: 0x00567EFC
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<DamageLibrary.MaterialType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F5 RID: 88053 RVA: 0x00569D58 File Offset: 0x00567F58
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<DamageLibrary.MaterialType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F6 RID: 88054 RVA: 0x00569DB4 File Offset: 0x00567FB4
		[CallerCount(0)]
		public unsafe void Write(ref WeaponName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F7 RID: 88055 RVA: 0x00569E0C File Offset: 0x0056800C
		[CallerCount(0)]
		public unsafe void Read(out WeaponName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x00569E64 File Offset: 0x00568064
		[CallerCount(0)]
		public unsafe void Write(ref Il2CppStructArray<WeaponName> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157F9 RID: 88057 RVA: 0x00569EC0 File Offset: 0x005680C0
		[CallerCount(0)]
		public unsafe void Read(out Il2CppStructArray<WeaponName> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060157FA RID: 88058 RVA: 0x00569F1C File Offset: 0x0056811C
		// Note: this type is marked as 'beforefieldinit'.
		static DPINetworkStream()
		{
			Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "DPINetworkStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr);
			DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "DPI_NETWORK_PROFILER");
			DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER_DEEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "DPI_NETWORK_PROFILER_DEEP");
			DPINetworkStream.NativeFieldInfoPtr_BITS_IN_BYTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "BITS_IN_BYTE");
			DPINetworkStream.NativeFieldInfoPtr__IsReading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "<IsReading>k__BackingField");
			DPINetworkStream.NativeFieldInfoPtr__profiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "_profiler");
			DPINetworkStream.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "_buffer");
			DPINetworkStream.NativeFieldInfoPtr__writeBitsPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "_writeBitsPosition");
			DPINetworkStream.NativeFieldInfoPtr__readBitsPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "_readBitsPosition");
			DPINetworkStream.NativeFieldInfoPtr__CreatedByPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "<CreatedByPool>k__BackingField");
			DPINetworkStream.NativeFieldInfoPtr__stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "_stringBuilder");
			DPINetworkStream.NativeMethodInfoPtr_get_IsReading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690800);
			DPINetworkStream.NativeMethodInfoPtr_set_IsReading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690801);
			DPINetworkStream.NativeMethodInfoPtr_get_IsWriting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690802);
			DPINetworkStream.NativeMethodInfoPtr_RoundBitsToByte_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690803);
			DPINetworkStream.NativeMethodInfoPtr_get_ByteWriteLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690804);
			DPINetworkStream.NativeMethodInfoPtr_get_ByteReadLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690805);
			DPINetworkStream.NativeMethodInfoPtr_get_BitsWritePos_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690806);
			DPINetworkStream.NativeMethodInfoPtr_set_BitsWritePos_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690807);
			DPINetworkStream.NativeMethodInfoPtr_get_BitsReadPos_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690808);
			DPINetworkStream.NativeMethodInfoPtr_set_BitsReadPos_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690809);
			DPINetworkStream.NativeMethodInfoPtr_get_Buffer_Public_get_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690810);
			DPINetworkStream.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690811);
			DPINetworkStream.NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStreamType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690812);
			DPINetworkStream.NativeMethodInfoPtr_Init_Private_Void_DPINetworkStreamType_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690813);
			DPINetworkStream.NativeMethodInfoPtr_Reset_Public_Void_DPINetworkStreamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690814);
			DPINetworkStream.NativeMethodInfoPtr_ChangeStreamType_Public_Void_DPINetworkStreamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690815);
			DPINetworkStream.NativeMethodInfoPtr_Reset_Public_Void_ArraySegment_1_Byte_DPINetworkStreamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690816);
			DPINetworkStream.NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690817);
			DPINetworkStream.NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690818);
			DPINetworkStream.NativeMethodInfoPtr_SeekToMarker_Public_Void_LocationMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690819);
			DPINetworkStream.NativeMethodInfoPtr_CreateMarker_Public_LocationMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690820);
			DPINetworkStream.NativeMethodInfoPtr_AppendStream_Public_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690821);
			DPINetworkStream.NativeMethodInfoPtr_AppendRestToOtherStream_Public_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690822);
			DPINetworkStream.NativeMethodInfoPtr_get_CreatedByPool_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690823);
			DPINetworkStream.NativeMethodInfoPtr_set_CreatedByPool_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690824);
			DPINetworkStream.NativeMethodInfoPtr_ReturnedToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690825);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690826);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690827);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690828);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690829);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690830);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690831);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690832);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690833);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690834);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690835);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690836);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690837);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690838);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690839);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690840);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690841);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690842);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690843);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690844);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690845);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690846);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690847);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690848);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690849);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690850);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690851);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690852);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690853);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690854);
			DPINetworkStream.NativeMethodInfoPtr_WriteWithoutLeadingArrayLength_Public_Void_byref_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690855);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690856);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690857);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690858);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690859);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690860);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690861);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690862);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIVector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690863);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690864);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690865);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690866);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690867);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_DPIHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690868);
			DPINetworkStream.NativeMethodInfoPtr_ReadPooled_Public_Void_byref_DPIHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690869);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_DPIHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690870);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_TWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690871);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_TRead_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690872);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_OnwardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690873);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_OnwardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690874);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_OnwardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690875);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_OnwardMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690876);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690877);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690878);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690879);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690880);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantPlayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690881);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantPlayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690882);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690883);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690884);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690885);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690886);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690887);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690888);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_UplinkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690889);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_UplinkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690890);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_UplinkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690891);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_UplinkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690892);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690893);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690894);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690895);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690896);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_SoldierClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690897);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_SoldierClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690898);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_SoldierClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690899);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_SoldierClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690900);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690901);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690902);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690903);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690904);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690905);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690906);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690907);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690908);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_HandBaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690909);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_HandBaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690910);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_HandBaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690911);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_HandBaseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690912);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_MapVoteButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690913);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_MapVoteButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690914);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MapVoteButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690915);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MapVoteButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690916);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690917);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690918);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690919);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690920);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690921);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690922);
			DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690923);
			DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, 100690924);
		}

		// Token: 0x060157FB RID: 88059 RVA: 0x00002988 File Offset: 0x00000B88
		public DPINetworkStream(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007923 RID: 31011
		// (get) Token: 0x060157FC RID: 88060 RVA: 0x0056A9D8 File Offset: 0x00568BD8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr));
			}
		}

		// Token: 0x17007924 RID: 31012
		// (get) Token: 0x060157FD RID: 88061 RVA: 0x0056A9EC File Offset: 0x00568BEC
		// (set) Token: 0x060157FE RID: 88062 RVA: 0x0056AA0C File Offset: 0x00568C0C
		public unsafe static string DPI_NETWORK_PROFILER
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007925 RID: 31013
		// (get) Token: 0x060157FF RID: 88063 RVA: 0x0056AA24 File Offset: 0x00568C24
		// (set) Token: 0x06015800 RID: 88064 RVA: 0x0056AA44 File Offset: 0x00568C44
		public unsafe static string DPI_NETWORK_PROFILER_DEEP
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER_DEEP, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DPINetworkStream.NativeFieldInfoPtr_DPI_NETWORK_PROFILER_DEEP, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007926 RID: 31014
		// (get) Token: 0x06015801 RID: 88065 RVA: 0x0056AA5C File Offset: 0x00568C5C
		// (set) Token: 0x06015802 RID: 88066 RVA: 0x0056AA7A File Offset: 0x00568C7A
		public unsafe static int BITS_IN_BYTE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DPINetworkStream.NativeFieldInfoPtr_BITS_IN_BYTE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DPINetworkStream.NativeFieldInfoPtr_BITS_IN_BYTE, (void*)(&value));
			}
		}

		// Token: 0x17007927 RID: 31015
		// (get) Token: 0x06015803 RID: 88067 RVA: 0x0056AA8C File Offset: 0x00568C8C
		// (set) Token: 0x06015804 RID: 88068 RVA: 0x0056AAB4 File Offset: 0x00568CB4
		public unsafe bool _IsReading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__IsReading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__IsReading_k__BackingField)) = value;
			}
		}

		// Token: 0x17007928 RID: 31016
		// (get) Token: 0x06015805 RID: 88069 RVA: 0x0056AAD8 File Offset: 0x00568CD8
		// (set) Token: 0x06015806 RID: 88070 RVA: 0x0056AB0C File Offset: 0x00568D0C
		public unsafe DPINetworkStream.Profiler _profiler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__profiler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPINetworkStream.Profiler(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__profiler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007929 RID: 31017
		// (get) Token: 0x06015807 RID: 88071 RVA: 0x0056AB34 File Offset: 0x00568D34
		// (set) Token: 0x06015808 RID: 88072 RVA: 0x0056AB68 File Offset: 0x00568D68
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<byte>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700792A RID: 31018
		// (get) Token: 0x06015809 RID: 88073 RVA: 0x0056AB90 File Offset: 0x00568D90
		// (set) Token: 0x0601580A RID: 88074 RVA: 0x0056ABB8 File Offset: 0x00568DB8
		public unsafe int _writeBitsPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__writeBitsPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__writeBitsPosition)) = value;
			}
		}

		// Token: 0x1700792B RID: 31019
		// (get) Token: 0x0601580B RID: 88075 RVA: 0x0056ABDC File Offset: 0x00568DDC
		// (set) Token: 0x0601580C RID: 88076 RVA: 0x0056AC04 File Offset: 0x00568E04
		public unsafe int _readBitsPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__readBitsPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__readBitsPosition)) = value;
			}
		}

		// Token: 0x1700792C RID: 31020
		// (get) Token: 0x0601580D RID: 88077 RVA: 0x0056AC28 File Offset: 0x00568E28
		// (set) Token: 0x0601580E RID: 88078 RVA: 0x0056AC50 File Offset: 0x00568E50
		public unsafe bool _CreatedByPool_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__CreatedByPool_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__CreatedByPool_k__BackingField)) = value;
			}
		}

		// Token: 0x1700792D RID: 31021
		// (get) Token: 0x0601580F RID: 88079 RVA: 0x0056AC74 File Offset: 0x00568E74
		// (set) Token: 0x06015810 RID: 88080 RVA: 0x0056ACA8 File Offset: 0x00568EA8
		public unsafe StringBuilder _stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new StringBuilder(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.NativeFieldInfoPtr__stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400DC0E RID: 56334
		private static readonly IntPtr NativeFieldInfoPtr_DPI_NETWORK_PROFILER;

		// Token: 0x0400DC0F RID: 56335
		private static readonly IntPtr NativeFieldInfoPtr_DPI_NETWORK_PROFILER_DEEP;

		// Token: 0x0400DC10 RID: 56336
		private static readonly IntPtr NativeFieldInfoPtr_BITS_IN_BYTE;

		// Token: 0x0400DC11 RID: 56337
		private static readonly IntPtr NativeFieldInfoPtr__IsReading_k__BackingField;

		// Token: 0x0400DC12 RID: 56338
		private static readonly IntPtr NativeFieldInfoPtr__profiler;

		// Token: 0x0400DC13 RID: 56339
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x0400DC14 RID: 56340
		private static readonly IntPtr NativeFieldInfoPtr__writeBitsPosition;

		// Token: 0x0400DC15 RID: 56341
		private static readonly IntPtr NativeFieldInfoPtr__readBitsPosition;

		// Token: 0x0400DC16 RID: 56342
		private static readonly IntPtr NativeFieldInfoPtr__CreatedByPool_k__BackingField;

		// Token: 0x0400DC17 RID: 56343
		private static readonly IntPtr NativeFieldInfoPtr__stringBuilder;

		// Token: 0x0400DC18 RID: 56344
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReading_Public_get_Boolean_0;

		// Token: 0x0400DC19 RID: 56345
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReading_Private_set_Void_Boolean_0;

		// Token: 0x0400DC1A RID: 56346
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWriting_Public_get_Boolean_0;

		// Token: 0x0400DC1B RID: 56347
		private static readonly IntPtr NativeMethodInfoPtr_RoundBitsToByte_Public_Int32_Int32_0;

		// Token: 0x0400DC1C RID: 56348
		private static readonly IntPtr NativeMethodInfoPtr_get_ByteWriteLength_Public_get_Int32_0;

		// Token: 0x0400DC1D RID: 56349
		private static readonly IntPtr NativeMethodInfoPtr_get_ByteReadLength_Public_get_Int32_0;

		// Token: 0x0400DC1E RID: 56350
		private static readonly IntPtr NativeMethodInfoPtr_get_BitsWritePos_Public_get_Int32_0;

		// Token: 0x0400DC1F RID: 56351
		private static readonly IntPtr NativeMethodInfoPtr_set_BitsWritePos_Public_set_Void_Int32_0;

		// Token: 0x0400DC20 RID: 56352
		private static readonly IntPtr NativeMethodInfoPtr_get_BitsReadPos_Public_get_Int32_0;

		// Token: 0x0400DC21 RID: 56353
		private static readonly IntPtr NativeMethodInfoPtr_set_BitsReadPos_Public_set_Void_Int32_0;

		// Token: 0x0400DC22 RID: 56354
		private static readonly IntPtr NativeMethodInfoPtr_get_Buffer_Public_get_ArrayOf_Byte_0;

		// Token: 0x0400DC23 RID: 56355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400DC24 RID: 56356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStreamType_Int32_0;

		// Token: 0x0400DC25 RID: 56357
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_DPINetworkStreamType_ArrayOf_Byte_0;

		// Token: 0x0400DC26 RID: 56358
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_DPINetworkStreamType_0;

		// Token: 0x0400DC27 RID: 56359
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStreamType_Public_Void_DPINetworkStreamType_0;

		// Token: 0x0400DC28 RID: 56360
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_ArraySegment_1_Byte_DPINetworkStreamType_0;

		// Token: 0x0400DC29 RID: 56361
		private static readonly IntPtr NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_0;

		// Token: 0x0400DC2A RID: 56362
		private static readonly IntPtr NativeMethodInfoPtr_ToArraySegment_Public_ArraySegment_1_Byte_Int32_Int32_0;

		// Token: 0x0400DC2B RID: 56363
		private static readonly IntPtr NativeMethodInfoPtr_SeekToMarker_Public_Void_LocationMarker_0;

		// Token: 0x0400DC2C RID: 56364
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_LocationMarker_0;

		// Token: 0x0400DC2D RID: 56365
		private static readonly IntPtr NativeMethodInfoPtr_AppendStream_Public_Void_DPINetworkStream_0;

		// Token: 0x0400DC2E RID: 56366
		private static readonly IntPtr NativeMethodInfoPtr_AppendRestToOtherStream_Public_Void_DPINetworkStream_0;

		// Token: 0x0400DC2F RID: 56367
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatedByPool_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400DC30 RID: 56368
		private static readonly IntPtr NativeMethodInfoPtr_set_CreatedByPool_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400DC31 RID: 56369
		private static readonly IntPtr NativeMethodInfoPtr_ReturnedToPool_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400DC32 RID: 56370
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Boolean_0;

		// Token: 0x0400DC33 RID: 56371
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Boolean_0;

		// Token: 0x0400DC34 RID: 56372
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Byte_Int32_0;

		// Token: 0x0400DC35 RID: 56373
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Byte_Int32_0;

		// Token: 0x0400DC36 RID: 56374
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_SByte_Int32_0;

		// Token: 0x0400DC37 RID: 56375
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_SByte_Int32_0;

		// Token: 0x0400DC38 RID: 56376
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_UInt16_Int32_0;

		// Token: 0x0400DC39 RID: 56377
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_UInt16_Int32_0;

		// Token: 0x0400DC3A RID: 56378
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Int16_Int32_0;

		// Token: 0x0400DC3B RID: 56379
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Int16_Int32_0;

		// Token: 0x0400DC3C RID: 56380
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Char_Int32_0;

		// Token: 0x0400DC3D RID: 56381
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Char_Int32_0;

		// Token: 0x0400DC3E RID: 56382
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_UInt32_Int32_0;

		// Token: 0x0400DC3F RID: 56383
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_UInt32_Int32_0;

		// Token: 0x0400DC40 RID: 56384
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Int32_Int32_0;

		// Token: 0x0400DC41 RID: 56385
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Int32_Int32_0;

		// Token: 0x0400DC42 RID: 56386
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_UInt64_Int32_0;

		// Token: 0x0400DC43 RID: 56387
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_UInt64_Int32_0;

		// Token: 0x0400DC44 RID: 56388
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Int64_Int32_0;

		// Token: 0x0400DC45 RID: 56389
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Int64_Int32_0;

		// Token: 0x0400DC46 RID: 56390
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Single_0;

		// Token: 0x0400DC47 RID: 56391
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Single_0;

		// Token: 0x0400DC48 RID: 56392
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Double_0;

		// Token: 0x0400DC49 RID: 56393
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Double_0;

		// Token: 0x0400DC4A RID: 56394
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_DPIQuaternion_0;

		// Token: 0x0400DC4B RID: 56395
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_DPIQuaternion_0;

		// Token: 0x0400DC4C RID: 56396
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Byte_0;

		// Token: 0x0400DC4D RID: 56397
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Byte_0;

		// Token: 0x0400DC4E RID: 56398
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArraySegment_1_Byte_0;

		// Token: 0x0400DC4F RID: 56399
		private static readonly IntPtr NativeMethodInfoPtr_WriteWithoutLeadingArrayLength_Public_Void_byref_ArraySegment_1_Byte_0;

		// Token: 0x0400DC50 RID: 56400
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Int32_0;

		// Token: 0x0400DC51 RID: 56401
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Int32_0;

		// Token: 0x0400DC52 RID: 56402
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Boolean_0;

		// Token: 0x0400DC53 RID: 56403
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Boolean_0;

		// Token: 0x0400DC54 RID: 56404
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_0;

		// Token: 0x0400DC55 RID: 56405
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_0;

		// Token: 0x0400DC56 RID: 56406
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_DPIVector3_0;

		// Token: 0x0400DC57 RID: 56407
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_DPIVector3_0;

		// Token: 0x0400DC58 RID: 56408
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0;

		// Token: 0x0400DC59 RID: 56409
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Dictionary_2_Int32_ArrayOf_Int32_0;

		// Token: 0x0400DC5A RID: 56410
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_String_0;

		// Token: 0x0400DC5B RID: 56411
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_String_0;

		// Token: 0x0400DC5C RID: 56412
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_DPIHashtable_0;

		// Token: 0x0400DC5D RID: 56413
		private static readonly IntPtr NativeMethodInfoPtr_ReadPooled_Public_Void_byref_DPIHashtable_0;

		// Token: 0x0400DC5E RID: 56414
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_DPIHashtable_0;

		// Token: 0x0400DC5F RID: 56415
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_TWrite_0;

		// Token: 0x0400DC60 RID: 56416
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_TRead_0;

		// Token: 0x0400DC61 RID: 56417
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_OnwardMap_0;

		// Token: 0x0400DC62 RID: 56418
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_OnwardMap_0;

		// Token: 0x0400DC63 RID: 56419
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_OnwardMap_0;

		// Token: 0x0400DC64 RID: 56420
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_OnwardMap_0;

		// Token: 0x0400DC65 RID: 56421
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_Faction_0;

		// Token: 0x0400DC66 RID: 56422
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_Faction_0;

		// Token: 0x0400DC67 RID: 56423
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_Faction_0;

		// Token: 0x0400DC68 RID: 56424
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_Faction_0;

		// Token: 0x0400DC69 RID: 56425
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantPlayStyle_0;

		// Token: 0x0400DC6A RID: 56426
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantPlayStyle_0;

		// Token: 0x0400DC6B RID: 56427
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0;

		// Token: 0x0400DC6C RID: 56428
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantPlayStyle_0;

		// Token: 0x0400DC6D RID: 56429
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_GameVariantTypes_0;

		// Token: 0x0400DC6E RID: 56430
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_GameVariantTypes_0;

		// Token: 0x0400DC6F RID: 56431
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_GameVariantTypes_0;

		// Token: 0x0400DC70 RID: 56432
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_GameVariantTypes_0;

		// Token: 0x0400DC71 RID: 56433
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_UplinkState_0;

		// Token: 0x0400DC72 RID: 56434
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_UplinkState_0;

		// Token: 0x0400DC73 RID: 56435
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_UplinkState_0;

		// Token: 0x0400DC74 RID: 56436
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_UplinkState_0;

		// Token: 0x0400DC75 RID: 56437
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_AmmoType_0;

		// Token: 0x0400DC76 RID: 56438
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_AmmoType_0;

		// Token: 0x0400DC77 RID: 56439
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_AmmoType_0;

		// Token: 0x0400DC78 RID: 56440
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_AmmoType_0;

		// Token: 0x0400DC79 RID: 56441
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_SoldierClass_0;

		// Token: 0x0400DC7A RID: 56442
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_SoldierClass_0;

		// Token: 0x0400DC7B RID: 56443
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_SoldierClass_0;

		// Token: 0x0400DC7C RID: 56444
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_SoldierClass_0;

		// Token: 0x0400DC7D RID: 56445
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_State_0;

		// Token: 0x0400DC7E RID: 56446
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_State_0;

		// Token: 0x0400DC7F RID: 56447
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_State_0;

		// Token: 0x0400DC80 RID: 56448
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_State_0;

		// Token: 0x0400DC81 RID: 56449
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ItemType_0;

		// Token: 0x0400DC82 RID: 56450
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ItemType_0;

		// Token: 0x0400DC83 RID: 56451
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_ItemType_0;

		// Token: 0x0400DC84 RID: 56452
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_ItemType_0;

		// Token: 0x0400DC85 RID: 56453
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_HandBaseState_0;

		// Token: 0x0400DC86 RID: 56454
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_HandBaseState_0;

		// Token: 0x0400DC87 RID: 56455
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_HandBaseState_0;

		// Token: 0x0400DC88 RID: 56456
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_HandBaseState_0;

		// Token: 0x0400DC89 RID: 56457
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_MapVoteButtonType_0;

		// Token: 0x0400DC8A RID: 56458
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_MapVoteButtonType_0;

		// Token: 0x0400DC8B RID: 56459
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MapVoteButtonType_0;

		// Token: 0x0400DC8C RID: 56460
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MapVoteButtonType_0;

		// Token: 0x0400DC8D RID: 56461
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_MaterialType_0;

		// Token: 0x0400DC8E RID: 56462
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_MaterialType_0;

		// Token: 0x0400DC8F RID: 56463
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_MaterialType_0;

		// Token: 0x0400DC90 RID: 56464
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_MaterialType_0;

		// Token: 0x0400DC91 RID: 56465
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_WeaponName_0;

		// Token: 0x0400DC92 RID: 56466
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_WeaponName_0;

		// Token: 0x0400DC93 RID: 56467
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_byref_ArrayOf_WeaponName_0;

		// Token: 0x0400DC94 RID: 56468
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_byref_ArrayOf_WeaponName_0;

		// Token: 0x02001271 RID: 4721
		public class Profiler : Object
		{
			// Token: 0x1700793A RID: 31034
			// (get) Token: 0x06015811 RID: 88081 RVA: 0x0056ACD0 File Offset: 0x00568ED0
			public unsafe int CurrentDepth
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x06015812 RID: 88082 RVA: 0x0056AD20 File Offset: 0x00568F20
			[CallerCount(0)]
			public unsafe Profiler(DPINetworkStream networkStream) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015813 RID: 88083 RVA: 0x0056AD84 File Offset: 0x00568F84
			[CallerCount(0)]
			public unsafe void BeginProfileSample()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_BeginProfileSample_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015814 RID: 88084 RVA: 0x0056ADC8 File Offset: 0x00568FC8
			[CallerCount(0)]
			public unsafe void EndProfileSample(Object value, Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_EndProfileSample_Public_Void_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015815 RID: 88085 RVA: 0x0056AE3C File Offset: 0x0056903C
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015816 RID: 88086 RVA: 0x0056AE80 File Offset: 0x00569080
			[CallerCount(0)]
			public unsafe void AppendFromOtherNetworkStream(DPINetworkStream otherStream)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherStream);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_AppendFromOtherNetworkStream_Public_Void_DPINetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015817 RID: 88087 RVA: 0x0056AEDC File Offset: 0x005690DC
			[CallerCount(0)]
			public unsafe DPINetworkStream.Profiler.ScopeData PopScopeGetSizeInBits(out DPINetworkStream.Profiler.ScopeData currentScopeData, out int sizeBits)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &currentScopeData;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sizeBits;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_PopScopeGetSizeInBits_Private_ScopeData_byref_ScopeData_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06015818 RID: 88088 RVA: 0x0056AF54 File Offset: 0x00569154
			[CallerCount(0)]
			public unsafe void SuppressSamples(bool suppress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref suppress;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStream.Profiler.NativeMethodInfoPtr_SuppressSamples_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06015819 RID: 88089 RVA: 0x0056AFA8 File Offset: 0x005691A8
			// Note: this type is marked as 'beforefieldinit'.
			static Profiler()
			{
				Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr, "Profiler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr);
				DPINetworkStream.Profiler.NativeFieldInfoPtr__networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, "_networkStream");
				DPINetworkStream.Profiler.NativeFieldInfoPtr__scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, "_scopes");
				DPINetworkStream.Profiler.NativeFieldInfoPtr__suppressSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, "_suppressSamples");
				DPINetworkStream.Profiler.NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690925);
				DPINetworkStream.Profiler.NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690926);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_BeginProfileSample_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690927);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_EndProfileSample_Public_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690928);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690929);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_AppendFromOtherNetworkStream_Public_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690930);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_PopScopeGetSizeInBits_Private_ScopeData_byref_ScopeData_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690931);
				DPINetworkStream.Profiler.NativeMethodInfoPtr_SuppressSamples_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, 100690932);
			}

			// Token: 0x0601581A RID: 88090 RVA: 0x00002988 File Offset: 0x00000B88
			public Profiler(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17007936 RID: 31030
			// (get) Token: 0x0601581B RID: 88091 RVA: 0x0056B0AF File Offset: 0x005692AF
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr));
				}
			}

			// Token: 0x17007937 RID: 31031
			// (get) Token: 0x0601581C RID: 88092 RVA: 0x0056B0C0 File Offset: 0x005692C0
			// (set) Token: 0x0601581D RID: 88093 RVA: 0x0056B0F4 File Offset: 0x005692F4
			public unsafe DPINetworkStream _networkStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__networkStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new DPINetworkStream(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17007938 RID: 31032
			// (get) Token: 0x0601581E RID: 88094 RVA: 0x0056B11C File Offset: 0x0056931C
			// (set) Token: 0x0601581F RID: 88095 RVA: 0x0056B150 File Offset: 0x00569350
			public unsafe Stack<DPINetworkStream.Profiler.ScopeData> _scopes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__scopes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Stack<DPINetworkStream.Profiler.ScopeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17007939 RID: 31033
			// (get) Token: 0x06015820 RID: 88096 RVA: 0x0056B178 File Offset: 0x00569378
			// (set) Token: 0x06015821 RID: 88097 RVA: 0x0056B1A0 File Offset: 0x005693A0
			public unsafe bool _suppressSamples
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__suppressSamples);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DPINetworkStream.Profiler.NativeFieldInfoPtr__suppressSamples)) = value;
				}
			}

			// Token: 0x0400DC95 RID: 56469
			private static readonly IntPtr NativeFieldInfoPtr__networkStream;

			// Token: 0x0400DC96 RID: 56470
			private static readonly IntPtr NativeFieldInfoPtr__scopes;

			// Token: 0x0400DC97 RID: 56471
			private static readonly IntPtr NativeFieldInfoPtr__suppressSamples;

			// Token: 0x0400DC98 RID: 56472
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDepth_Public_get_Int32_0;

			// Token: 0x0400DC99 RID: 56473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DPINetworkStream_0;

			// Token: 0x0400DC9A RID: 56474
			private static readonly IntPtr NativeMethodInfoPtr_BeginProfileSample_Public_Void_0;

			// Token: 0x0400DC9B RID: 56475
			private static readonly IntPtr NativeMethodInfoPtr_EndProfileSample_Public_Void_Object_Type_0;

			// Token: 0x0400DC9C RID: 56476
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400DC9D RID: 56477
			private static readonly IntPtr NativeMethodInfoPtr_AppendFromOtherNetworkStream_Public_Void_DPINetworkStream_0;

			// Token: 0x0400DC9E RID: 56478
			private static readonly IntPtr NativeMethodInfoPtr_PopScopeGetSizeInBits_Private_ScopeData_byref_ScopeData_byref_Int32_0;

			// Token: 0x0400DC9F RID: 56479
			private static readonly IntPtr NativeMethodInfoPtr_SuppressSamples_Public_Void_Boolean_0;

			// Token: 0x02001272 RID: 4722
			[StructLayout(2)]
			public struct ScopeData
			{
				// Token: 0x06015822 RID: 88098 RVA: 0x0056B1C4 File Offset: 0x005693C4
				// Note: this type is marked as 'beforefieldinit'.
				static ScopeData()
				{
					Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DPINetworkStream.Profiler>.NativeClassPtr, "ScopeData");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr);
					DPINetworkStream.Profiler.ScopeData.NativeFieldInfoPtr_ProfilingDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr, "ProfilingDataIndex");
					DPINetworkStream.Profiler.ScopeData.NativeFieldInfoPtr_InitialReadWritePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr, "InitialReadWritePos");
				}

				// Token: 0x06015823 RID: 88099 RVA: 0x0056B217 File Offset: 0x00569417
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr, ref this));
				}

				// Token: 0x1700793B RID: 31035
				// (get) Token: 0x06015824 RID: 88100 RVA: 0x0056B229 File Offset: 0x00569429
				[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
				public static Type Il2CppType
				{
					get
					{
						return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPINetworkStream.Profiler.ScopeData>.NativeClassPtr));
					}
				}

				// Token: 0x0400DCA0 RID: 56480
				private static readonly IntPtr NativeFieldInfoPtr_ProfilingDataIndex;

				// Token: 0x0400DCA1 RID: 56481
				private static readonly IntPtr NativeFieldInfoPtr_InitialReadWritePos;

				// Token: 0x0400DCA2 RID: 56482
				[FieldOffset(0)]
				public int ProfilingDataIndex;

				// Token: 0x0400DCA3 RID: 56483
				[FieldOffset(4)]
				public int InitialReadWritePos;
			}
		}

		// Token: 0x02001273 RID: 4723
		private sealed class MethodInfoStoreGeneric_Write_Public_Void_byref_TWrite_0<TWrite>
		{
			// Token: 0x0400DCA4 RID: 56484
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DPINetworkStream.NativeMethodInfoPtr_Write_Public_Void_byref_TWrite_0, Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TWrite>.NativeClassPtr))
			}))));
		}

		// Token: 0x02001274 RID: 4724
		private sealed class MethodInfoStoreGeneric_Read_Public_Void_byref_TRead_0<TRead>
		{
			// Token: 0x0400DCA5 RID: 56485
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DPINetworkStream.NativeMethodInfoPtr_Read_Public_Void_byref_TRead_0, Il2CppClassPointerStore<DPINetworkStream>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRead>.NativeClassPtr))
			}))));
		}
	}
}
