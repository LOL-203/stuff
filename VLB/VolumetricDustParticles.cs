using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005F1 RID: 1521
	public class VolumetricDustParticles : MonoBehaviour
	{
		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x001EDA70 File Offset: 0x001EBC70
		// (set) Token: 0x06007AC9 RID: 31433 RVA: 0x001EDAC0 File Offset: 0x001EBCC0
		public unsafe bool isCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06007ACA RID: 31434 RVA: 0x001EDB14 File Offset: 0x001EBD14
		public unsafe bool particlesAreInstantiated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x001EDB64 File Offset: 0x001EBD64
		public unsafe int particlesCurrentCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x001EDBB4 File Offset: 0x001EBDB4
		public unsafe int particlesMaxCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06007ACD RID: 31437 RVA: 0x001EDC04 File Offset: 0x001EBE04
		public unsafe Camera mainCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x001EDC5C File Offset: 0x001EBE5C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x001EDCA0 File Offset: 0x001EBEA0
		[CallerCount(0)]
		public unsafe void InstantiateParticleSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x001EDCE4 File Offset: 0x001EBEE4
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x001EDD28 File Offset: 0x001EBF28
		[CallerCount(0)]
		public unsafe void SetActiveAndPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x001EDD6C File Offset: 0x001EBF6C
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x001EDDB0 File Offset: 0x001EBFB0
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x001EDDF4 File Offset: 0x001EBFF4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x001EDE38 File Offset: 0x001EC038
		[CallerCount(0)]
		public unsafe void SetParticleProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x001EDE7C File Offset: 0x001EC07C
		[CallerCount(0)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x001EDEC0 File Offset: 0x001EC0C0
		[CallerCount(0)]
		public unsafe VolumetricDustParticles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x001EDF0C File Offset: 0x001EC10C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricDustParticles()
		{
			Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricDustParticles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr);
			VolumetricDustParticles.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "alpha");
			VolumetricDustParticles.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "size");
			VolumetricDustParticles.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "direction");
			VolumetricDustParticles.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "speed");
			VolumetricDustParticles.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "density");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMinDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingEnabled");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "<isCulled>k__BackingField");
			VolumetricDustParticles.NativeFieldInfoPtr_isFeatureSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "isFeatureSupported");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Particles");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Renderer");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_NoMainCameraLogged");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_MainCamera");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Master");
			VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673087);
			VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673088);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673089);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673090);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673091);
			VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673092);
			VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673093);
			VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673094);
			VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673095);
			VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673096);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673097);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673098);
			VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673099);
			VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673100);
			VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673101);
			VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100673102);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x0000210C File Offset: 0x0000030C
		public VolumetricDustParticles(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x001EE1BC File Offset: 0x001EC3BC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr));
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06007ADB RID: 31451 RVA: 0x001EE1D0 File Offset: 0x001EC3D0
		// (set) Token: 0x06007ADC RID: 31452 RVA: 0x001EE1F8 File Offset: 0x001EC3F8
		public unsafe float alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha)) = value;
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06007ADD RID: 31453 RVA: 0x001EE21C File Offset: 0x001EC41C
		// (set) Token: 0x06007ADE RID: 31454 RVA: 0x001EE244 File Offset: 0x001EC444
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06007ADF RID: 31455 RVA: 0x001EE268 File Offset: 0x001EC468
		// (set) Token: 0x06007AE0 RID: 31456 RVA: 0x001EE290 File Offset: 0x001EC490
		public unsafe VolumetricDustParticles.Direction direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06007AE1 RID: 31457 RVA: 0x001EE2B4 File Offset: 0x001EC4B4
		// (set) Token: 0x06007AE2 RID: 31458 RVA: 0x001EE2DC File Offset: 0x001EC4DC
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06007AE3 RID: 31459 RVA: 0x001EE300 File Offset: 0x001EC500
		// (set) Token: 0x06007AE4 RID: 31460 RVA: 0x001EE328 File Offset: 0x001EC528
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06007AE5 RID: 31461 RVA: 0x001EE34C File Offset: 0x001EC54C
		// (set) Token: 0x06007AE6 RID: 31462 RVA: 0x001EE374 File Offset: 0x001EC574
		public unsafe float spawnMinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance)) = value;
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06007AE7 RID: 31463 RVA: 0x001EE398 File Offset: 0x001EC598
		// (set) Token: 0x06007AE8 RID: 31464 RVA: 0x001EE3C0 File Offset: 0x001EC5C0
		public unsafe float spawnMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance)) = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06007AE9 RID: 31465 RVA: 0x001EE3E4 File Offset: 0x001EC5E4
		// (set) Token: 0x06007AEA RID: 31466 RVA: 0x001EE40C File Offset: 0x001EC60C
		public unsafe bool cullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled)) = value;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06007AEB RID: 31467 RVA: 0x001EE430 File Offset: 0x001EC630
		// (set) Token: 0x06007AEC RID: 31468 RVA: 0x001EE458 File Offset: 0x001EC658
		public unsafe float cullingMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance)) = value;
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06007AED RID: 31469 RVA: 0x001EE47C File Offset: 0x001EC67C
		// (set) Token: 0x06007AEE RID: 31470 RVA: 0x001EE4A4 File Offset: 0x001EC6A4
		public unsafe bool _isCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x001EE4C8 File Offset: 0x001EC6C8
		// (set) Token: 0x06007AF0 RID: 31472 RVA: 0x001EE4E6 File Offset: 0x001EC6E6
		public unsafe static bool isFeatureSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_isFeatureSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_isFeatureSupported, (void*)(&value));
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06007AF1 RID: 31473 RVA: 0x001EE4F8 File Offset: 0x001EC6F8
		// (set) Token: 0x06007AF2 RID: 31474 RVA: 0x001EE52C File Offset: 0x001EC72C
		public unsafe ParticleSystem m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ParticleSystem(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x001EE554 File Offset: 0x001EC754
		// (set) Token: 0x06007AF4 RID: 31476 RVA: 0x001EE588 File Offset: 0x001EC788
		public unsafe ParticleSystemRenderer m_Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ParticleSystemRenderer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06007AF5 RID: 31477 RVA: 0x001EE5B0 File Offset: 0x001EC7B0
		// (set) Token: 0x06007AF6 RID: 31478 RVA: 0x001EE5CE File Offset: 0x001EC7CE
		public unsafe static bool ms_NoMainCameraLogged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&value));
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06007AF7 RID: 31479 RVA: 0x001EE5E0 File Offset: 0x001EC7E0
		// (set) Token: 0x06007AF8 RID: 31480 RVA: 0x001EE60B File Offset: 0x001EC80B
		public unsafe static Camera ms_MainCamera
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06007AF9 RID: 31481 RVA: 0x001EE620 File Offset: 0x001EC820
		// (set) Token: 0x06007AFA RID: 31482 RVA: 0x001EE654 File Offset: 0x001EC854
		public unsafe VolumetricLightBeam m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VolumetricLightBeam(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04004EA8 RID: 20136
		private static readonly IntPtr NativeFieldInfoPtr_spawnMinDistance;

		// Token: 0x04004EA9 RID: 20137
		private static readonly IntPtr NativeFieldInfoPtr_spawnMaxDistance;

		// Token: 0x04004EAA RID: 20138
		private static readonly IntPtr NativeFieldInfoPtr_cullingEnabled;

		// Token: 0x04004EAB RID: 20139
		private static readonly IntPtr NativeFieldInfoPtr_cullingMaxDistance;

		// Token: 0x04004EAC RID: 20140
		private static readonly IntPtr NativeFieldInfoPtr__isCulled_k__BackingField;

		// Token: 0x04004EAD RID: 20141
		private static readonly IntPtr NativeFieldInfoPtr_isFeatureSupported;

		// Token: 0x04004EAE RID: 20142
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x04004EAF RID: 20143
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		// Token: 0x04004EB0 RID: 20144
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoMainCameraLogged;

		// Token: 0x04004EB1 RID: 20145
		private static readonly IntPtr NativeFieldInfoPtr_ms_MainCamera;

		// Token: 0x04004EB2 RID: 20146
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04004EB3 RID: 20147
		private static readonly IntPtr NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0;

		// Token: 0x04004EB4 RID: 20148
		private static readonly IntPtr NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0;

		// Token: 0x04004EB5 RID: 20149
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0;

		// Token: 0x04004EB6 RID: 20150
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0;

		// Token: 0x04004EB7 RID: 20151
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0;

		// Token: 0x04004EB8 RID: 20152
		private static readonly IntPtr NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0;

		// Token: 0x04004EB9 RID: 20153
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004EBA RID: 20154
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0;

		// Token: 0x04004EBB RID: 20155
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004EBC RID: 20156
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0;

		// Token: 0x04004EBD RID: 20157
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04004EBE RID: 20158
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004EBF RID: 20159
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004EC0 RID: 20160
		private static readonly IntPtr NativeMethodInfoPtr_SetParticleProperties_Private_Void_0;

		// Token: 0x04004EC1 RID: 20161
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x04004EC2 RID: 20162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005F2 RID: 1522
		public enum Direction
		{
			// Token: 0x04004EC4 RID: 20164
			Beam,
			// Token: 0x04004EC5 RID: 20165
			Random
		}
	}
}
