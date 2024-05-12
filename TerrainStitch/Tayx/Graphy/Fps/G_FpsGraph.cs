using System;
using Il2CppSystem;
using Tayx.Graphy.Graph;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Fps
{
	// Token: 0x020008E9 RID: 2281
	public class G_FpsGraph : G_Graph
	{
		// Token: 0x0600B9D3 RID: 47571 RVA: 0x002F8CAC File Offset: 0x002F6EAC
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x002F8CF0 File Offset: 0x002F6EF0
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsGraph.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x002F8D34 File Offset: 0x002F6F34
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x002F8D78 File Offset: 0x002F6F78
		[CallerCount(0)]
		public new unsafe void UpdateGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_FpsGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x002F8DC8 File Offset: 0x002F6FC8
		[CallerCount(0)]
		public new unsafe void CreatePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_FpsGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x002F8E18 File Offset: 0x002F7018
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsGraph.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x002F8E5C File Offset: 0x002F705C
		[CallerCount(0)]
		public unsafe G_FpsGraph() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_FpsGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x002F8EA8 File Offset: 0x002F70A8
		// Note: this type is marked as 'beforefieldinit'.
		static G_FpsGraph()
		{
			Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Fps", "G_FpsGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr);
			G_FpsGraph.NativeFieldInfoPtr_m_imageGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_imageGraph");
			G_FpsGraph.NativeFieldInfoPtr_ShaderFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "ShaderFull");
			G_FpsGraph.NativeFieldInfoPtr_ShaderLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "ShaderLight");
			G_FpsGraph.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_graphyManager");
			G_FpsGraph.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_fpsMonitor");
			G_FpsGraph.NativeFieldInfoPtr_m_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_resolution");
			G_FpsGraph.NativeFieldInfoPtr_m_shaderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_shaderGraph");
			G_FpsGraph.NativeFieldInfoPtr_m_fpsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_fpsArray");
			G_FpsGraph.NativeFieldInfoPtr_m_highestFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, "m_highestFps");
			G_FpsGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678437);
			G_FpsGraph.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678438);
			G_FpsGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678439);
			G_FpsGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678440);
			G_FpsGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678441);
			G_FpsGraph.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678442);
			G_FpsGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr, 100678443);
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x002F7570 File Offset: 0x002F5770
		public G_FpsGraph(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0600B9DC RID: 47580 RVA: 0x002F9018 File Offset: 0x002F7218
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_FpsGraph>.NativeClassPtr));
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x0600B9DD RID: 47581 RVA: 0x002F902C File Offset: 0x002F722C
		// (set) Token: 0x0600B9DE RID: 47582 RVA: 0x002F9060 File Offset: 0x002F7260
		public unsafe Image m_imageGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_imageGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_imageGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002F9088 File Offset: 0x002F7288
		// (set) Token: 0x0600B9E0 RID: 47584 RVA: 0x002F90BC File Offset: 0x002F72BC
		public unsafe Shader ShaderFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_ShaderFull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_ShaderFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002F90E4 File Offset: 0x002F72E4
		// (set) Token: 0x0600B9E2 RID: 47586 RVA: 0x002F9118 File Offset: 0x002F7318
		public unsafe Shader ShaderLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_ShaderLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_ShaderLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0600B9E3 RID: 47587 RVA: 0x002F9140 File Offset: 0x002F7340
		// (set) Token: 0x0600B9E4 RID: 47588 RVA: 0x002F9174 File Offset: 0x002F7374
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0600B9E5 RID: 47589 RVA: 0x002F919C File Offset: 0x002F739C
		// (set) Token: 0x0600B9E6 RID: 47590 RVA: 0x002F91D0 File Offset: 0x002F73D0
		public unsafe G_FpsMonitor m_fpsMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_fpsMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_FpsMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x002F91F8 File Offset: 0x002F73F8
		// (set) Token: 0x0600B9E8 RID: 47592 RVA: 0x002F9220 File Offset: 0x002F7420
		public unsafe int m_resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_resolution)) = value;
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002F9244 File Offset: 0x002F7444
		// (set) Token: 0x0600B9EA RID: 47594 RVA: 0x002F9278 File Offset: 0x002F7478
		public unsafe G_GraphShader m_shaderGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_shaderGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_shaderGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x002F92A0 File Offset: 0x002F74A0
		// (set) Token: 0x0600B9EC RID: 47596 RVA: 0x002F92D4 File Offset: 0x002F74D4
		public unsafe Il2CppStructArray<int> m_fpsArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_fpsArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_fpsArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x002F92FC File Offset: 0x002F74FC
		// (set) Token: 0x0600B9EE RID: 47598 RVA: 0x002F9324 File Offset: 0x002F7524
		public unsafe int m_highestFps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_highestFps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_FpsGraph.NativeFieldInfoPtr_m_highestFps)) = value;
			}
		}

		// Token: 0x04007744 RID: 30532
		private static readonly IntPtr NativeFieldInfoPtr_m_imageGraph;

		// Token: 0x04007745 RID: 30533
		private static readonly IntPtr NativeFieldInfoPtr_ShaderFull;

		// Token: 0x04007746 RID: 30534
		private static readonly IntPtr NativeFieldInfoPtr_ShaderLight;

		// Token: 0x04007747 RID: 30535
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x04007748 RID: 30536
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsMonitor;

		// Token: 0x04007749 RID: 30537
		private static readonly IntPtr NativeFieldInfoPtr_m_resolution;

		// Token: 0x0400774A RID: 30538
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraph;

		// Token: 0x0400774B RID: 30539
		private static readonly IntPtr NativeFieldInfoPtr_m_fpsArray;

		// Token: 0x0400774C RID: 30540
		private static readonly IntPtr NativeFieldInfoPtr_m_highestFps;

		// Token: 0x0400774D RID: 30541
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400774E RID: 30542
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400774F RID: 30543
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x04007750 RID: 30544
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0;

		// Token: 0x04007751 RID: 30545
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0;

		// Token: 0x04007752 RID: 30546
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007753 RID: 30547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
