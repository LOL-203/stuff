using System;
using Il2CppSystem;
using Tayx.Graphy.Graph;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.Ram
{
	// Token: 0x020008E4 RID: 2276
	public class G_RamGraph : G_Graph
	{
		// Token: 0x0600B960 RID: 47456 RVA: 0x002F718C File Offset: 0x002F538C
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x002F71D0 File Offset: 0x002F53D0
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x002F7214 File Offset: 0x002F5414
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x002F7258 File Offset: 0x002F5458
		[CallerCount(0)]
		public new unsafe void UpdateGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_RamGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x002F72A8 File Offset: 0x002F54A8
		[CallerCount(0)]
		public new unsafe void CreatePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), G_RamGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x002F72F8 File Offset: 0x002F54F8
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x002F733C File Offset: 0x002F553C
		[CallerCount(0)]
		public unsafe G_RamGraph() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x002F7388 File Offset: 0x002F5588
		// Note: this type is marked as 'beforefieldinit'.
		static G_RamGraph()
		{
			Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Ram", "G_RamGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr);
			G_RamGraph.NativeFieldInfoPtr_m_imageAllocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_imageAllocated");
			G_RamGraph.NativeFieldInfoPtr_m_imageReserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_imageReserved");
			G_RamGraph.NativeFieldInfoPtr_m_imageMono = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_imageMono");
			G_RamGraph.NativeFieldInfoPtr_ShaderFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "ShaderFull");
			G_RamGraph.NativeFieldInfoPtr_ShaderLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "ShaderLight");
			G_RamGraph.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_graphyManager");
			G_RamGraph.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_ramMonitor");
			G_RamGraph.NativeFieldInfoPtr_m_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_resolution");
			G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_shaderGraphAllocated");
			G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_shaderGraphReserved");
			G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_shaderGraphMono");
			G_RamGraph.NativeFieldInfoPtr_m_allocatedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_allocatedArray");
			G_RamGraph.NativeFieldInfoPtr_m_reservedArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_reservedArray");
			G_RamGraph.NativeFieldInfoPtr_m_monoArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_monoArray");
			G_RamGraph.NativeFieldInfoPtr_m_highestMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, "m_highestMemory");
			G_RamGraph.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678407);
			G_RamGraph.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678408);
			G_RamGraph.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678409);
			G_RamGraph.NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678410);
			G_RamGraph.NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678411);
			G_RamGraph.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678412);
			G_RamGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr, 100678413);
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x002F7570 File Offset: 0x002F5770
		public G_RamGraph(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x0600B969 RID: 47465 RVA: 0x002F7579 File Offset: 0x002F5779
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_RamGraph>.NativeClassPtr));
			}
		}

		// Token: 0x17004225 RID: 16933
		// (get) Token: 0x0600B96A RID: 47466 RVA: 0x002F758C File Offset: 0x002F578C
		// (set) Token: 0x0600B96B RID: 47467 RVA: 0x002F75C0 File Offset: 0x002F57C0
		public unsafe Image m_imageAllocated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageAllocated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageAllocated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004226 RID: 16934
		// (get) Token: 0x0600B96C RID: 47468 RVA: 0x002F75E8 File Offset: 0x002F57E8
		// (set) Token: 0x0600B96D RID: 47469 RVA: 0x002F761C File Offset: 0x002F581C
		public unsafe Image m_imageReserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageReserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageReserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x0600B96E RID: 47470 RVA: 0x002F7644 File Offset: 0x002F5844
		// (set) Token: 0x0600B96F RID: 47471 RVA: 0x002F7678 File Offset: 0x002F5878
		public unsafe Image m_imageMono
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageMono);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_imageMono), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x0600B970 RID: 47472 RVA: 0x002F76A0 File Offset: 0x002F58A0
		// (set) Token: 0x0600B971 RID: 47473 RVA: 0x002F76D4 File Offset: 0x002F58D4
		public unsafe Shader ShaderFull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderFull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x0600B972 RID: 47474 RVA: 0x002F76FC File Offset: 0x002F58FC
		// (set) Token: 0x0600B973 RID: 47475 RVA: 0x002F7730 File Offset: 0x002F5930
		public unsafe Shader ShaderLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_ShaderLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700422A RID: 16938
		// (get) Token: 0x0600B974 RID: 47476 RVA: 0x002F7758 File Offset: 0x002F5958
		// (set) Token: 0x0600B975 RID: 47477 RVA: 0x002F778C File Offset: 0x002F598C
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700422B RID: 16939
		// (get) Token: 0x0600B976 RID: 47478 RVA: 0x002F77B4 File Offset: 0x002F59B4
		// (set) Token: 0x0600B977 RID: 47479 RVA: 0x002F77E8 File Offset: 0x002F59E8
		public unsafe G_RamMonitor m_ramMonitor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_ramMonitor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_RamMonitor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700422C RID: 16940
		// (get) Token: 0x0600B978 RID: 47480 RVA: 0x002F7810 File Offset: 0x002F5A10
		// (set) Token: 0x0600B979 RID: 47481 RVA: 0x002F7838 File Offset: 0x002F5A38
		public unsafe int m_resolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_resolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_resolution)) = value;
			}
		}

		// Token: 0x1700422D RID: 16941
		// (get) Token: 0x0600B97A RID: 47482 RVA: 0x002F785C File Offset: 0x002F5A5C
		// (set) Token: 0x0600B97B RID: 47483 RVA: 0x002F7890 File Offset: 0x002F5A90
		public unsafe G_GraphShader m_shaderGraphAllocated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphAllocated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x0600B97C RID: 47484 RVA: 0x002F78B8 File Offset: 0x002F5AB8
		// (set) Token: 0x0600B97D RID: 47485 RVA: 0x002F78EC File Offset: 0x002F5AEC
		public unsafe G_GraphShader m_shaderGraphReserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphReserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x0600B97E RID: 47486 RVA: 0x002F7914 File Offset: 0x002F5B14
		// (set) Token: 0x0600B97F RID: 47487 RVA: 0x002F7948 File Offset: 0x002F5B48
		public unsafe G_GraphShader m_shaderGraphMono
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new G_GraphShader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_shaderGraphMono), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x002F7970 File Offset: 0x002F5B70
		// (set) Token: 0x0600B981 RID: 47489 RVA: 0x002F79A4 File Offset: 0x002F5BA4
		public unsafe Il2CppStructArray<float> m_allocatedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_allocatedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_allocatedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x002F79CC File Offset: 0x002F5BCC
		// (set) Token: 0x0600B983 RID: 47491 RVA: 0x002F7A00 File Offset: 0x002F5C00
		public unsafe Il2CppStructArray<float> m_reservedArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_reservedArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_reservedArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x0600B984 RID: 47492 RVA: 0x002F7A28 File Offset: 0x002F5C28
		// (set) Token: 0x0600B985 RID: 47493 RVA: 0x002F7A5C File Offset: 0x002F5C5C
		public unsafe Il2CppStructArray<float> m_monoArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_monoArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_monoArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x002F7A84 File Offset: 0x002F5C84
		// (set) Token: 0x0600B987 RID: 47495 RVA: 0x002F7AAC File Offset: 0x002F5CAC
		public unsafe float m_highestMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_highestMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamGraph.NativeFieldInfoPtr_m_highestMemory)) = value;
			}
		}

		// Token: 0x04007703 RID: 30467
		private static readonly IntPtr NativeFieldInfoPtr_m_imageAllocated;

		// Token: 0x04007704 RID: 30468
		private static readonly IntPtr NativeFieldInfoPtr_m_imageReserved;

		// Token: 0x04007705 RID: 30469
		private static readonly IntPtr NativeFieldInfoPtr_m_imageMono;

		// Token: 0x04007706 RID: 30470
		private static readonly IntPtr NativeFieldInfoPtr_ShaderFull;

		// Token: 0x04007707 RID: 30471
		private static readonly IntPtr NativeFieldInfoPtr_ShaderLight;

		// Token: 0x04007708 RID: 30472
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x04007709 RID: 30473
		private static readonly IntPtr NativeFieldInfoPtr_m_ramMonitor;

		// Token: 0x0400770A RID: 30474
		private static readonly IntPtr NativeFieldInfoPtr_m_resolution;

		// Token: 0x0400770B RID: 30475
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphAllocated;

		// Token: 0x0400770C RID: 30476
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphReserved;

		// Token: 0x0400770D RID: 30477
		private static readonly IntPtr NativeFieldInfoPtr_m_shaderGraphMono;

		// Token: 0x0400770E RID: 30478
		private static readonly IntPtr NativeFieldInfoPtr_m_allocatedArray;

		// Token: 0x0400770F RID: 30479
		private static readonly IntPtr NativeFieldInfoPtr_m_reservedArray;

		// Token: 0x04007710 RID: 30480
		private static readonly IntPtr NativeFieldInfoPtr_m_monoArray;

		// Token: 0x04007711 RID: 30481
		private static readonly IntPtr NativeFieldInfoPtr_m_highestMemory;

		// Token: 0x04007712 RID: 30482
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007713 RID: 30483
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007714 RID: 30484
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x04007715 RID: 30485
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGraph_Protected_Virtual_Void_0;

		// Token: 0x04007716 RID: 30486
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoints_Protected_Virtual_Void_0;

		// Token: 0x04007717 RID: 30487
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007718 RID: 30488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
