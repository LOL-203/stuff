using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Events;

namespace Tayx.Graphy
{
	// Token: 0x020008CB RID: 2251
	public class GraphyDebugger : G_Singleton<GraphyDebugger>
	{
		// Token: 0x0600B7BC RID: 47036 RVA: 0x002F06E8 File Offset: 0x002EE8E8
		[CallerCount(0)]
		public unsafe GraphyDebugger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x002F0734 File Offset: 0x002EE934
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x002F0778 File Offset: 0x002EE978
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x002F07BC File Offset: 0x002EE9BC
		[CallerCount(0)]
		public unsafe void AddNewDebugPacket(GraphyDebugger.DebugPacket newDebugPacket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newDebugPacket);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x002F0818 File Offset: 0x002EEA18
		[CallerCount(0)]
		public unsafe void AddNewDebugPacket(int newId, GraphyDebugger.DebugCondition newDebugCondition, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugCondition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMessageType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugBreak;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newCallback);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x002F08D8 File Offset: 0x002EEAD8
		[CallerCount(0)]
		public unsafe void AddNewDebugPacket(int newId, List<GraphyDebugger.DebugCondition> newDebugConditions, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, Action newCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newDebugConditions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMessageType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugBreak;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newCallback);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x002F099C File Offset: 0x002EEB9C
		[CallerCount(0)]
		public unsafe void AddNewDebugPacket(int newId, GraphyDebugger.DebugCondition newDebugCondition, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugCondition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMessageType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugBreak;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newCallbacks);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x002F0A5C File Offset: 0x002EEC5C
		[CallerCount(0)]
		public unsafe void AddNewDebugPacket(int newId, List<GraphyDebugger.DebugCondition> newDebugConditions, GraphyDebugger.MessageType newMessageType, string newMessage, bool newDebugBreak, List<Action> newCallbacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newDebugConditions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMessageType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDebugBreak;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newCallbacks);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x002F0B20 File Offset: 0x002EED20
		[CallerCount(0)]
		public unsafe GraphyDebugger.DebugPacket GetFirstDebugPacketWithId(int packetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref packetId;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GraphyDebugger.DebugPacket(intPtr2) : null;
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x002F0B88 File Offset: 0x002EED88
		[CallerCount(0)]
		public unsafe List<GraphyDebugger.DebugPacket> GetAllDebugPacketsWithId(int packetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref packetId;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<GraphyDebugger.DebugPacket>(intPtr2) : null;
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x002F0BF0 File Offset: 0x002EEDF0
		[CallerCount(0)]
		public unsafe void RemoveFirstDebugPacketWithId(int packetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref packetId;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x002F0C44 File Offset: 0x002EEE44
		[CallerCount(0)]
		public unsafe void RemoveAllDebugPacketsWithId(int packetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref packetId;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x002F0C98 File Offset: 0x002EEE98
		[CallerCount(0)]
		public unsafe void AddCallbackToFirstDebugPacketWithId(Action callback, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x002F0D04 File Offset: 0x002EEF04
		[CallerCount(0)]
		public unsafe void AddCallbackToAllDebugPacketWithId(Action callback, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x002F0D70 File Offset: 0x002EEF70
		[CallerCount(0)]
		public unsafe void CheckDebugPackets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002F0DB4 File Offset: 0x002EEFB4
		[CallerCount(0)]
		public unsafe bool CheckIfConditionIsMet(GraphyDebugger.DebugCondition debugCondition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref debugCondition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x002F0E18 File Offset: 0x002EF018
		[CallerCount(0)]
		public unsafe float GetRequestedValueFromDebugVariable(GraphyDebugger.DebugVariable debugVariable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref debugVariable;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002F0E7C File Offset: 0x002EF07C
		[CallerCount(0)]
		public unsafe void ExecuteOperationsInDebugPacket(GraphyDebugger.DebugPacket debugPacket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugPacket);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x002F0ED8 File Offset: 0x002EF0D8
		// Note: this type is marked as 'beforefieldinit'.
		static GraphyDebugger()
		{
			Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy", "GraphyDebugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr);
			GraphyDebugger.NativeFieldInfoPtr_m_debugPackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "m_debugPackets");
			GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "m_fpsMonitor");
			GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "m_ramMonitor");
			GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "m_audioMonitor");
			GraphyDebugger.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678254);
			GraphyDebugger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678255);
			GraphyDebugger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678256);
			GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678257);
			GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678258);
			GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678259);
			GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678260);
			GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678261);
			GraphyDebugger.NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678262);
			GraphyDebugger.NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678263);
			GraphyDebugger.NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678264);
			GraphyDebugger.NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678265);
			GraphyDebugger.NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678266);
			GraphyDebugger.NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678267);
			GraphyDebugger.NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678268);
			GraphyDebugger.NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678269);
			GraphyDebugger.NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678270);
			GraphyDebugger.NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100678271);
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x002F10C0 File Offset: 0x002EF2C0
		public GraphyDebugger(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x0600B7D0 RID: 47056 RVA: 0x002F10C9 File Offset: 0x002EF2C9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr));
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x0600B7D1 RID: 47057 RVA: 0x002F10DC File Offset: 0x002EF2DC
		// (set) Token: 0x0600B7D2 RID: 47058 RVA: 0x002F1110 File Offset: 0x002EF310
		public unsafe List<GraphyDebugger.DebugPacket> m_debugPackets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_debugPackets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<GraphyDebugger.DebugPacket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_debugPackets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004176 RID: 16758
		// (get) Token: 0x0600B7D3 RID: 47059 RVA: 0x002F1138 File Offset: 0x002EF338
		// (set) Token: 0x0600B7D4 RID: 47060 RVA: 0x002F116C File Offset: 0x002EF36C
		public unsafe G_FpsMonitor m_fpsMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004177 RID: 16759
		// (get) Token: 0x0600B7D5 RID: 47061 RVA: 0x002F1194 File Offset: 0x002EF394
		// (set) Token: 0x0600B7D6 RID: 47062 RVA: 0x002F11C8 File Offset: 0x002EF3C8
		public unsafe G_RamMonitor m_ramMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004178 RID: 16760
		// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x002F11F0 File Offset: 0x002EF3F0
		// (set) Token: 0x0600B7D8 RID: 47064 RVA: 0x002F1224 File Offset: 0x002EF424
		public unsafe G_AudioMonitor m_audioMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040075C6 RID: 30150
		private static readonly IntPtr NativeFieldInfoPtr_m_debugPackets;

		// Token: 0x040075C7 RID: 30151
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;

		// Token: 0x040075C8 RID: 30152
		private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;

		// Token: 0x040075C9 RID: 30153
		private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;

		// Token: 0x040075CA RID: 30154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040075CB RID: 30155
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075CC RID: 30156
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040075CD RID: 30157
		private static readonly IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0;

		// Token: 0x040075CE RID: 30158
		private static readonly IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0;

		// Token: 0x040075CF RID: 30159
		private static readonly IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0;

		// Token: 0x040075D0 RID: 30160
		private static readonly IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0;

		// Token: 0x040075D1 RID: 30161
		private static readonly IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0;

		// Token: 0x040075D2 RID: 30162
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0;

		// Token: 0x040075D3 RID: 30163
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0;

		// Token: 0x040075D4 RID: 30164
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0;

		// Token: 0x040075D5 RID: 30165
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0;

		// Token: 0x040075D6 RID: 30166
		private static readonly IntPtr NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0;

		// Token: 0x040075D7 RID: 30167
		private static readonly IntPtr NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0;

		// Token: 0x040075D8 RID: 30168
		private static readonly IntPtr NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0;

		// Token: 0x040075D9 RID: 30169
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0;

		// Token: 0x040075DA RID: 30170
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0;

		// Token: 0x040075DB RID: 30171
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0;

		// Token: 0x020008CC RID: 2252
		public enum DebugVariable
		{
			// Token: 0x040075DD RID: 30173
			Fps,
			// Token: 0x040075DE RID: 30174
			Fps_Min,
			// Token: 0x040075DF RID: 30175
			Fps_Max,
			// Token: 0x040075E0 RID: 30176
			Fps_Avg,
			// Token: 0x040075E1 RID: 30177
			Ram_Allocated,
			// Token: 0x040075E2 RID: 30178
			Ram_Reserved,
			// Token: 0x040075E3 RID: 30179
			Ram_Mono,
			// Token: 0x040075E4 RID: 30180
			Audio_DB
		}

		// Token: 0x020008CD RID: 2253
		public enum DebugComparer
		{
			// Token: 0x040075E6 RID: 30182
			Less_than,
			// Token: 0x040075E7 RID: 30183
			Equals_or_less_than,
			// Token: 0x040075E8 RID: 30184
			Equals,
			// Token: 0x040075E9 RID: 30185
			Equals_or_greater_than,
			// Token: 0x040075EA RID: 30186
			Greater_than
		}

		// Token: 0x020008CE RID: 2254
		public enum ConditionEvaluation
		{
			// Token: 0x040075EC RID: 30188
			All_conditions_must_be_met,
			// Token: 0x040075ED RID: 30189
			Only_one_condition_has_to_be_met
		}

		// Token: 0x020008CF RID: 2255
		public enum MessageType
		{
			// Token: 0x040075EF RID: 30191
			Log,
			// Token: 0x040075F0 RID: 30192
			Warning,
			// Token: 0x040075F1 RID: 30193
			Error
		}

		// Token: 0x020008D0 RID: 2256
		[Serializable]
		[StructLayout(2)]
		public struct DebugCondition
		{
			// Token: 0x0600B7E1 RID: 47073 RVA: 0x002F12E8 File Offset: 0x002EF4E8
			// Note: this type is marked as 'beforefieldinit'.
			static DebugCondition()
			{
				Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "DebugCondition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr);
				GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, "Variable");
				GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, "Comparer");
				GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, "Value");
			}

			// Token: 0x0600B7E2 RID: 47074 RVA: 0x002F134F File Offset: 0x002EF54F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, ref this));
			}

			// Token: 0x1700417D RID: 16765
			// (get) Token: 0x0600B7E3 RID: 47075 RVA: 0x002F1361 File Offset: 0x002EF561
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr));
				}
			}

			// Token: 0x040075F2 RID: 30194
			private static readonly IntPtr NativeFieldInfoPtr_Variable;

			// Token: 0x040075F3 RID: 30195
			private static readonly IntPtr NativeFieldInfoPtr_Comparer;

			// Token: 0x040075F4 RID: 30196
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040075F5 RID: 30197
			[FieldOffset(0)]
			public GraphyDebugger.DebugVariable Variable;

			// Token: 0x040075F6 RID: 30198
			[FieldOffset(4)]
			public GraphyDebugger.DebugComparer Comparer;

			// Token: 0x040075F7 RID: 30199
			[FieldOffset(8)]
			public float Value;
		}

		// Token: 0x020008D1 RID: 2257
		[Serializable]
		public class DebugPacket : Object
		{
			// Token: 0x17004190 RID: 16784
			// (get) Token: 0x0600B7E4 RID: 47076 RVA: 0x002F1374 File Offset: 0x002EF574
			public unsafe bool Check
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_get_Check_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x0600B7E5 RID: 47077 RVA: 0x002F13C4 File Offset: 0x002EF5C4
			[CallerCount(0)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B7E6 RID: 47078 RVA: 0x002F1408 File Offset: 0x002EF608
			[CallerCount(0)]
			public unsafe void Executed()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Executed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B7E7 RID: 47079 RVA: 0x002F144C File Offset: 0x002EF64C
			[CallerCount(0)]
			public unsafe DebugPacket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B7E8 RID: 47080 RVA: 0x002F1498 File Offset: 0x002EF698
			// Note: this type is marked as 'beforefieldinit'.
			static DebugPacket()
			{
				Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "DebugPacket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr);
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "Active");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "Id");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "ExecuteOnce");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "InitSleepTime");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "ExecuteSleepTime");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "ConditionEvaluation");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "DebugConditions");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "MessageType");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "Message");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "TakeScreenshot");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "ScreenshotFileName");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "DebugBreak");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "UnityEvents");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "Callbacks");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "canBeChecked");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "executed");
				GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, "timePassed");
				GraphyDebugger.DebugPacket.NativeMethodInfoPtr_get_Check_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100678272);
				GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100678273);
				GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Executed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100678274);
				GraphyDebugger.DebugPacket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100678275);
			}

			// Token: 0x0600B7E9 RID: 47081 RVA: 0x00002988 File Offset: 0x00000B88
			public DebugPacket(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x1700417E RID: 16766
			// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x002F1667 File Offset: 0x002EF867
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr));
				}
			}

			// Token: 0x1700417F RID: 16767
			// (get) Token: 0x0600B7EB RID: 47083 RVA: 0x002F1678 File Offset: 0x002EF878
			// (set) Token: 0x0600B7EC RID: 47084 RVA: 0x002F16A0 File Offset: 0x002EF8A0
			public unsafe bool Active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active)) = value;
				}
			}

			// Token: 0x17004180 RID: 16768
			// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002F16C4 File Offset: 0x002EF8C4
			// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x002F16EC File Offset: 0x002EF8EC
			public unsafe int Id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id)) = value;
				}
			}

			// Token: 0x17004181 RID: 16769
			// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002F1710 File Offset: 0x002EF910
			// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x002F1738 File Offset: 0x002EF938
			public unsafe bool ExecuteOnce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce)) = value;
				}
			}

			// Token: 0x17004182 RID: 16770
			// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002F175C File Offset: 0x002EF95C
			// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x002F1784 File Offset: 0x002EF984
			public unsafe float InitSleepTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime)) = value;
				}
			}

			// Token: 0x17004183 RID: 16771
			// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x002F17A8 File Offset: 0x002EF9A8
			// (set) Token: 0x0600B7F4 RID: 47092 RVA: 0x002F17D0 File Offset: 0x002EF9D0
			public unsafe float ExecuteSleepTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime)) = value;
				}
			}

			// Token: 0x17004184 RID: 16772
			// (get) Token: 0x0600B7F5 RID: 47093 RVA: 0x002F17F4 File Offset: 0x002EF9F4
			// (set) Token: 0x0600B7F6 RID: 47094 RVA: 0x002F181C File Offset: 0x002EFA1C
			public unsafe GraphyDebugger.ConditionEvaluation ConditionEvaluation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation)) = value;
				}
			}

			// Token: 0x17004185 RID: 16773
			// (get) Token: 0x0600B7F7 RID: 47095 RVA: 0x002F1840 File Offset: 0x002EFA40
			// (set) Token: 0x0600B7F8 RID: 47096 RVA: 0x002F1874 File Offset: 0x002EFA74
			public unsafe List<GraphyDebugger.DebugCondition> DebugConditions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<GraphyDebugger.DebugCondition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004186 RID: 16774
			// (get) Token: 0x0600B7F9 RID: 47097 RVA: 0x002F189C File Offset: 0x002EFA9C
			// (set) Token: 0x0600B7FA RID: 47098 RVA: 0x002F18C4 File Offset: 0x002EFAC4
			public unsafe GraphyDebugger.MessageType MessageType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType)) = value;
				}
			}

			// Token: 0x17004187 RID: 16775
			// (get) Token: 0x0600B7FB RID: 47099 RVA: 0x002F18E8 File Offset: 0x002EFAE8
			// (set) Token: 0x0600B7FC RID: 47100 RVA: 0x002F1911 File Offset: 0x002EFB11
			public unsafe string Message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004188 RID: 16776
			// (get) Token: 0x0600B7FD RID: 47101 RVA: 0x002F1938 File Offset: 0x002EFB38
			// (set) Token: 0x0600B7FE RID: 47102 RVA: 0x002F1960 File Offset: 0x002EFB60
			public unsafe bool TakeScreenshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot)) = value;
				}
			}

			// Token: 0x17004189 RID: 16777
			// (get) Token: 0x0600B7FF RID: 47103 RVA: 0x002F1984 File Offset: 0x002EFB84
			// (set) Token: 0x0600B800 RID: 47104 RVA: 0x002F19AD File Offset: 0x002EFBAD
			public unsafe string ScreenshotFileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700418A RID: 16778
			// (get) Token: 0x0600B801 RID: 47105 RVA: 0x002F19D4 File Offset: 0x002EFBD4
			// (set) Token: 0x0600B802 RID: 47106 RVA: 0x002F19FC File Offset: 0x002EFBFC
			public unsafe bool DebugBreak
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak)) = value;
				}
			}

			// Token: 0x1700418B RID: 16779
			// (get) Token: 0x0600B803 RID: 47107 RVA: 0x002F1A20 File Offset: 0x002EFC20
			// (set) Token: 0x0600B804 RID: 47108 RVA: 0x002F1A54 File Offset: 0x002EFC54
			public unsafe UnityEvent UnityEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new UnityEvent(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418C RID: 16780
			// (get) Token: 0x0600B805 RID: 47109 RVA: 0x002F1A7C File Offset: 0x002EFC7C
			// (set) Token: 0x0600B806 RID: 47110 RVA: 0x002F1AB0 File Offset: 0x002EFCB0
			public unsafe List<Action> Callbacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700418D RID: 16781
			// (get) Token: 0x0600B807 RID: 47111 RVA: 0x002F1AD8 File Offset: 0x002EFCD8
			// (set) Token: 0x0600B808 RID: 47112 RVA: 0x002F1B00 File Offset: 0x002EFD00
			public unsafe bool canBeChecked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked)) = value;
				}
			}

			// Token: 0x1700418E RID: 16782
			// (get) Token: 0x0600B809 RID: 47113 RVA: 0x002F1B24 File Offset: 0x002EFD24
			// (set) Token: 0x0600B80A RID: 47114 RVA: 0x002F1B4C File Offset: 0x002EFD4C
			public unsafe bool executed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed)) = value;
				}
			}

			// Token: 0x1700418F RID: 16783
			// (get) Token: 0x0600B80B RID: 47115 RVA: 0x002F1B70 File Offset: 0x002EFD70
			// (set) Token: 0x0600B80C RID: 47116 RVA: 0x002F1B98 File Offset: 0x002EFD98
			public unsafe float timePassed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed)) = value;
				}
			}

			// Token: 0x040075F8 RID: 30200
			private static readonly IntPtr NativeFieldInfoPtr_Active;

			// Token: 0x040075F9 RID: 30201
			private static readonly IntPtr NativeFieldInfoPtr_Id;

			// Token: 0x040075FA RID: 30202
			private static readonly IntPtr NativeFieldInfoPtr_ExecuteOnce;

			// Token: 0x040075FB RID: 30203
			private static readonly IntPtr NativeFieldInfoPtr_InitSleepTime;

			// Token: 0x040075FC RID: 30204
			private static readonly IntPtr NativeFieldInfoPtr_ExecuteSleepTime;

			// Token: 0x040075FD RID: 30205
			private static readonly IntPtr NativeFieldInfoPtr_ConditionEvaluation;

			// Token: 0x040075FE RID: 30206
			private static readonly IntPtr NativeFieldInfoPtr_DebugConditions;

			// Token: 0x040075FF RID: 30207
			private static readonly IntPtr NativeFieldInfoPtr_MessageType;

			// Token: 0x04007600 RID: 30208
			private static readonly IntPtr NativeFieldInfoPtr_Message;

			// Token: 0x04007601 RID: 30209
			private static readonly IntPtr NativeFieldInfoPtr_TakeScreenshot;

			// Token: 0x04007602 RID: 30210
			private static readonly IntPtr NativeFieldInfoPtr_ScreenshotFileName;

			// Token: 0x04007603 RID: 30211
			private static readonly IntPtr NativeFieldInfoPtr_DebugBreak;

			// Token: 0x04007604 RID: 30212
			private static readonly IntPtr NativeFieldInfoPtr_UnityEvents;

			// Token: 0x04007605 RID: 30213
			private static readonly IntPtr NativeFieldInfoPtr_Callbacks;

			// Token: 0x04007606 RID: 30214
			private static readonly IntPtr NativeFieldInfoPtr_canBeChecked;

			// Token: 0x04007607 RID: 30215
			private static readonly IntPtr NativeFieldInfoPtr_executed;

			// Token: 0x04007608 RID: 30216
			private static readonly IntPtr NativeFieldInfoPtr_timePassed;

			// Token: 0x04007609 RID: 30217
			private static readonly IntPtr NativeMethodInfoPtr_get_Check_Public_get_Boolean_0;

			// Token: 0x0400760A RID: 30218
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

			// Token: 0x0400760B RID: 30219
			private static readonly IntPtr NativeMethodInfoPtr_Executed_Public_Void_0;

			// Token: 0x0400760C RID: 30220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D2 RID: 2258
		[ObfuscatedName("Tayx.Graphy.GraphyDebugger/<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600B80D RID: 47117 RVA: 0x002F1BBC File Offset: 0x002EFDBC
			[CallerCount(0)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B80E RID: 47118 RVA: 0x002F1C08 File Offset: 0x002EFE08
			[CallerCount(0)]
			public unsafe bool _GetFirstDebugPacketWithId_b__0(GraphyDebugger.DebugPacket x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600B80F RID: 47119 RVA: 0x002F1C70 File Offset: 0x002EFE70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr);
				GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, "packetId");
				GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, 100678276);
				GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, 100678277);
			}

			// Token: 0x0600B810 RID: 47120 RVA: 0x00002988 File Offset: 0x00000B88
			public __c__DisplayClass18_0(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004191 RID: 16785
			// (get) Token: 0x0600B811 RID: 47121 RVA: 0x002F1CD7 File Offset: 0x002EFED7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr));
				}
			}

			// Token: 0x17004192 RID: 16786
			// (get) Token: 0x0600B812 RID: 47122 RVA: 0x002F1CE8 File Offset: 0x002EFEE8
			// (set) Token: 0x0600B813 RID: 47123 RVA: 0x002F1D10 File Offset: 0x002EFF10
			public unsafe int packetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId)) = value;
				}
			}

			// Token: 0x0400760D RID: 30221
			private static readonly IntPtr NativeFieldInfoPtr_packetId;

			// Token: 0x0400760E RID: 30222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400760F RID: 30223
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0;
		}

		// Token: 0x020008D3 RID: 2259
		[ObfuscatedName("Tayx.Graphy.GraphyDebugger/<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Object
		{
			// Token: 0x0600B814 RID: 47124 RVA: 0x002F1D34 File Offset: 0x002EFF34
			[CallerCount(0)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B815 RID: 47125 RVA: 0x002F1D80 File Offset: 0x002EFF80
			[CallerCount(0)]
			public unsafe bool _GetAllDebugPacketsWithId_b__0(GraphyDebugger.DebugPacket x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600B816 RID: 47126 RVA: 0x002F1DE8 File Offset: 0x002EFFE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr);
				GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, "packetId");
				GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, 100678278);
				GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, 100678279);
			}

			// Token: 0x0600B817 RID: 47127 RVA: 0x00002988 File Offset: 0x00000B88
			public __c__DisplayClass19_0(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004193 RID: 16787
			// (get) Token: 0x0600B818 RID: 47128 RVA: 0x002F1E4F File Offset: 0x002F004F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr));
				}
			}

			// Token: 0x17004194 RID: 16788
			// (get) Token: 0x0600B819 RID: 47129 RVA: 0x002F1E60 File Offset: 0x002F0060
			// (set) Token: 0x0600B81A RID: 47130 RVA: 0x002F1E88 File Offset: 0x002F0088
			public unsafe int packetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId)) = value;
				}
			}

			// Token: 0x04007610 RID: 30224
			private static readonly IntPtr NativeFieldInfoPtr_packetId;

			// Token: 0x04007611 RID: 30225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007612 RID: 30226
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0;
		}

		// Token: 0x020008D4 RID: 2260
		[ObfuscatedName("Tayx.Graphy.GraphyDebugger/<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x0600B81B RID: 47131 RVA: 0x002F1EAC File Offset: 0x002F00AC
			[CallerCount(0)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B81C RID: 47132 RVA: 0x002F1EF8 File Offset: 0x002F00F8
			[CallerCount(0)]
			public unsafe bool _RemoveAllDebugPacketsWithId_b__0(GraphyDebugger.DebugPacket x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600B81D RID: 47133 RVA: 0x002F1F60 File Offset: 0x002F0160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr);
				GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, "packetId");
				GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, 100678280);
				GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, 100678281);
			}

			// Token: 0x0600B81E RID: 47134 RVA: 0x00002988 File Offset: 0x00000B88
			public __c__DisplayClass21_0(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004195 RID: 16789
			// (get) Token: 0x0600B81F RID: 47135 RVA: 0x002F1FC7 File Offset: 0x002F01C7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr));
				}
			}

			// Token: 0x17004196 RID: 16790
			// (get) Token: 0x0600B820 RID: 47136 RVA: 0x002F1FD8 File Offset: 0x002F01D8
			// (set) Token: 0x0600B821 RID: 47137 RVA: 0x002F2000 File Offset: 0x002F0200
			public unsafe int packetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId)) = value;
				}
			}

			// Token: 0x04007613 RID: 30227
			private static readonly IntPtr NativeFieldInfoPtr_packetId;

			// Token: 0x04007614 RID: 30228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007615 RID: 30229
			private static readonly IntPtr NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0;
		}

		// Token: 0x020008D5 RID: 2261
		[ObfuscatedName("Tayx.Graphy.GraphyDebugger/<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600B822 RID: 47138 RVA: 0x002F2024 File Offset: 0x002F0224
			[CallerCount(0)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600B823 RID: 47139 RVA: 0x002F2070 File Offset: 0x002F0270
			[CallerCount(0)]
			public unsafe bool _CheckDebugPackets_b__24_0(GraphyDebugger.DebugPacket packet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(packet);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c.NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600B824 RID: 47140 RVA: 0x002F20D8 File Offset: 0x002F02D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr);
				GraphyDebugger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, "<>9");
				GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, "<>9__24_0");
				GraphyDebugger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, 100678283);
				GraphyDebugger.__c.NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, 100678284);
			}

			// Token: 0x0600B825 RID: 47141 RVA: 0x00002988 File Offset: 0x00000B88
			public __c(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004197 RID: 16791
			// (get) Token: 0x0600B826 RID: 47142 RVA: 0x002F2153 File Offset: 0x002F0353
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr));
				}
			}

			// Token: 0x17004198 RID: 16792
			// (get) Token: 0x0600B827 RID: 47143 RVA: 0x002F2164 File Offset: 0x002F0364
			// (set) Token: 0x0600B828 RID: 47144 RVA: 0x002F218F File Offset: 0x002F038F
			public unsafe static GraphyDebugger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphyDebugger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new GraphyDebugger.__c(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphyDebugger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004199 RID: 16793
			// (get) Token: 0x0600B829 RID: 47145 RVA: 0x002F21A4 File Offset: 0x002F03A4
			// (set) Token: 0x0600B82A RID: 47146 RVA: 0x002F21CF File Offset: 0x002F03CF
			public unsafe static Predicate<GraphyDebugger.DebugPacket> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Predicate<GraphyDebugger.DebugPacket>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007616 RID: 30230
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007617 RID: 30231
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04007618 RID: 30232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007619 RID: 30233
			private static readonly IntPtr NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0;
		}
	}
}
