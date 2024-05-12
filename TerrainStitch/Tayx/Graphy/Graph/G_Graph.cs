using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tayx.Graphy.Graph
{
	// Token: 0x020008E8 RID: 2280
	public class G_Graph : MonoBehaviour
	{
		// Token: 0x0600B9CD RID: 47565 RVA: 0x002F8B40 File Offset: 0x002F6D40
		[CallerCount(0)]
		public unsafe void UpdateGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_Graph.NativeMethodInfoPtr_UpdateGraph_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x002F8B90 File Offset: 0x002F6D90
		[CallerCount(0)]
		public unsafe void CreatePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_Graph.NativeMethodInfoPtr_CreatePoints_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x002F8BE0 File Offset: 0x002F6DE0
		[CallerCount(0)]
		public unsafe G_Graph() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_Graph>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_Graph.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x002F8C2C File Offset: 0x002F6E2C
		// Note: this type is marked as 'beforefieldinit'.
		static G_Graph()
		{
			Il2CppClassPointerStore<G_Graph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Graph", "G_Graph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_Graph>.NativeClassPtr);
			G_Graph.NativeMethodInfoPtr_UpdateGraph_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Graph>.NativeClassPtr, 100678434);
			G_Graph.NativeMethodInfoPtr_CreatePoints_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Graph>.NativeClassPtr, 100678435);
			G_Graph.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Graph>.NativeClassPtr, 100678436);
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x0000210C File Offset: 0x0000030C
		public G_Graph(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0600B9D2 RID: 47570 RVA: 0x002F8C98 File Offset: 0x002F6E98
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_Graph>.NativeClassPtr));
			}
		}

		// Token: 0x04007741 RID: 30529
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04007742 RID: 30530
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04007743 RID: 30531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
