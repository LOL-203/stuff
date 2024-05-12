using System;
using Il2CppSystem;
using Tayx.Graphy.Graph;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Audio
{
	// Token: 0x020008ED RID: 2285
	public class G_AudioGraph : G_Graph
	{
		// Token: 0x0600BA63 RID: 47715 RVA: 0x002FAE14 File Offset: 0x002F9014
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x002FAE58 File Offset: 0x002F9058
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x002FAE9C File Offset: 0x002F909C
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x002FAEE0 File Offset: 0x002F90E0
		[CallerCount(0)]
		public new unsafe void UpdateGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_AudioGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x002FAF30 File Offset: 0x002F9130
		[CallerCount(0)]
		public new unsafe void CreatePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_AudioGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x002FAF80 File Offset: 0x002F9180
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x002FAFC4 File Offset: 0x002F91C4
		[CallerCount(0)]
		public unsafe G_AudioGraph() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x002FB010 File Offset: 0x002F9210
		// Note: this type is marked as 'beforefieldinit'.
		static G_AudioGraph()
		{
			Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Audio", "G_AudioGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr);
			G_AudioGraph.NativeFieldInfoPtr_m_imageGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_imageGraph");
			G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_imageGraphHighestValues");
			G_AudioGraph.NativeFieldInfoPtr_ShaderFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "ShaderFull");
			G_AudioGraph.NativeFieldInfoPtr_ShaderLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "ShaderLight");
			G_AudioGraph.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_graphyManager");
			G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_audioMonitor");
			G_AudioGraph.NativeFieldInfoPtr_m_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_resolution");
			G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_shaderGraph");
			G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_shaderGraphHighestValues");
			G_AudioGraph.NativeFieldInfoPtr_m_graphArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_graphArray");
			G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, "m_graphArrayHighestValue");
			G_AudioGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678471);
			G_AudioGraph.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678472);
			G_AudioGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678473);
			G_AudioGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678474);
			G_AudioGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678475);
			G_AudioGraph.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678476);
			G_AudioGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr, 100678477);
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x002F7570 File Offset: 0x002F5770
		public G_AudioGraph(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x002FB1A8 File Offset: 0x002F93A8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_AudioGraph>.NativeClassPtr));
			}
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x0600BA6D RID: 47725 RVA: 0x002FB1BC File Offset: 0x002F93BC
		// (set) Token: 0x0600BA6E RID: 47726 RVA: 0x002FB1F0 File Offset: 0x002F93F0
		public unsafe Image m_imageGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x0600BA6F RID: 47727 RVA: 0x002FB218 File Offset: 0x002F9418
		// (set) Token: 0x0600BA70 RID: 47728 RVA: 0x002FB24C File Offset: 0x002F944C
		public unsafe Image m_imageGraphHighestValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_imageGraphHighestValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x002FB274 File Offset: 0x002F9474
		// (set) Token: 0x0600BA72 RID: 47730 RVA: 0x002FB2A8 File Offset: 0x002F94A8
		public unsafe Shader ShaderFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderFull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x0600BA73 RID: 47731 RVA: 0x002FB2D0 File Offset: 0x002F94D0
		// (set) Token: 0x0600BA74 RID: 47732 RVA: 0x002FB304 File Offset: 0x002F9504
		public unsafe Shader ShaderLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_ShaderLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x0600BA75 RID: 47733 RVA: 0x002FB32C File Offset: 0x002F952C
		// (set) Token: 0x0600BA76 RID: 47734 RVA: 0x002FB360 File Offset: 0x002F9560
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x0600BA77 RID: 47735 RVA: 0x002FB388 File Offset: 0x002F9588
		// (set) Token: 0x0600BA78 RID: 47736 RVA: 0x002FB3BC File Offset: 0x002F95BC
		public unsafe G_AudioMonitor m_audioMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_AudioMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0600BA79 RID: 47737 RVA: 0x002FB3E4 File Offset: 0x002F95E4
		// (set) Token: 0x0600BA7A RID: 47738 RVA: 0x002FB40C File Offset: 0x002F960C
		public unsafe int m_resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_resolution)) = value;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0600BA7B RID: 47739 RVA: 0x002FB430 File Offset: 0x002F9630
		// (set) Token: 0x0600BA7C RID: 47740 RVA: 0x002FB464 File Offset: 0x002F9664
		public unsafe G_GraphShader m_shaderGraph
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraph), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x0600BA7D RID: 47741 RVA: 0x002FB48C File Offset: 0x002F968C
		// (set) Token: 0x0600BA7E RID: 47742 RVA: 0x002FB4C0 File Offset: 0x002F96C0
		public unsafe G_GraphShader m_shaderGraphHighestValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_shaderGraphHighestValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x0600BA7F RID: 47743 RVA: 0x002FB4E8 File Offset: 0x002F96E8
		// (set) Token: 0x0600BA80 RID: 47744 RVA: 0x002FB51C File Offset: 0x002F971C
		public unsafe Il2CppStructArray<float> m_graphArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x0600BA81 RID: 47745 RVA: 0x002FB544 File Offset: 0x002F9744
		// (set) Token: 0x0600BA82 RID: 47746 RVA: 0x002FB578 File Offset: 0x002F9778
		public unsafe Il2CppStructArray<float> m_graphArrayHighestValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioGraph.NativeFieldInfoPtr_m_graphArrayHighestValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007797 RID: 30615
		private static readonly IntPtr NativeFieldInfoPtr_m_imageGraph;

		// Token: 0x04007798 RID: 30616
		private static readonly IntPtr NativeFieldInfoPtr_m_imageGraphHighestValues;

		// Token: 0x04007799 RID: 30617
		private static readonly IntPtr NativeFieldInfoPtr_ShaderFull;

		// Token: 0x0400779A RID: 30618
		private static readonly IntPtr NativeFieldInfoPtr_ShaderLight;

		// Token: 0x0400779B RID: 30619
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x0400779C RID: 30620
		private static readonly IntPtr NativeFieldInfoPtr_m_audioMonitor;

		// Token: 0x0400779D RID: 30621
		private static readonly IntPtr NativeFieldInfoPtr_m_resolution;

		// Token: 0x0400779E RID: 30622
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraph;

		// Token: 0x0400779F RID: 30623
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphHighestValues;

		// Token: 0x040077A0 RID: 30624
		private static readonly IntPtr NativeFieldInfoPtr_m_graphArray;

		// Token: 0x040077A1 RID: 30625
		private static readonly IntPtr NativeFieldInfoPtr_m_graphArrayHighestValue;

		// Token: 0x040077A2 RID: 30626
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040077A3 RID: 30627
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077A4 RID: 30628
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x040077A5 RID: 30629
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0;

		// Token: 0x040077A6 RID: 30630
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0;

		// Token: 0x040077A7 RID: 30631
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040077A8 RID: 30632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
