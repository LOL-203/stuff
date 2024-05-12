using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tayx.Graphy.Audio
{
	// Token: 0x020008EF RID: 2287
	public class G_AudioMonitor : MonoBehaviour
	{
		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0600BAA6 RID: 47782 RVA: 0x002FBE50 File Offset: 0x002FA050
		public unsafe Il2CppStructArray<float> Spectrum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002FBEA8 File Offset: 0x002FA0A8
		public unsafe Il2CppStructArray<float> SpectrumHighestValues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0600BAA8 RID: 47784 RVA: 0x002FBF00 File Offset: 0x002FA100
		public unsafe float MaxDB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0600BAA9 RID: 47785 RVA: 0x002FBF50 File Offset: 0x002FA150
		public unsafe bool SpectrumDataAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600BAAA RID: 47786 RVA: 0x002FBFA0 File Offset: 0x002FA1A0
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAAB RID: 47787 RVA: 0x002FBFE4 File Offset: 0x002FA1E4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x002FC028 File Offset: 0x002FA228
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x002FC06C File Offset: 0x002FA26C
		[CallerCount(0)]
		public unsafe void UpdateParameters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x002FC0B0 File Offset: 0x002FA2B0
		[CallerCount(0)]
		public unsafe float lin2dB(float linear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref linear;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_lin2dB_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x002FC114 File Offset: 0x002FA314
		[CallerCount(0)]
		public unsafe float dBNormalized(float db)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref db;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x002FC178 File Offset: 0x002FA378
		[CallerCount(0)]
		public unsafe AudioListener FindAudioListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AudioListener(intPtr2) : null;
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x002FC1D0 File Offset: 0x002FA3D0
		[CallerCount(0)]
		public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadSceneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x002FC238 File Offset: 0x002FA438
		[CallerCount(0)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x002FC27C File Offset: 0x002FA47C
		[CallerCount(0)]
		public unsafe G_AudioMonitor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x002FC2C8 File Offset: 0x002FA4C8
		// Note: this type is marked as 'beforefieldinit'.
		static G_AudioMonitor()
		{
			Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Audio", "G_AudioMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr);
			G_AudioMonitor.NativeFieldInfoPtr_m_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_refValue");
			G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_graphyManager");
			G_AudioMonitor.NativeFieldInfoPtr_m_audioListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_audioListener");
			G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_findAudioListenerInCameraIfNull");
			G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_FFTWindow");
			G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_spectrumSize");
			G_AudioMonitor.NativeFieldInfoPtr_m_spectrum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_spectrum");
			G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_spectrumHighestValues");
			G_AudioMonitor.NativeFieldInfoPtr_m_maxDB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, "m_maxDB");
			G_AudioMonitor.NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678488);
			G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678489);
			G_AudioMonitor.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678490);
			G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678491);
			G_AudioMonitor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678492);
			G_AudioMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678493);
			G_AudioMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678494);
			G_AudioMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678495);
			G_AudioMonitor.NativeMethodInfoPtr_lin2dB_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678496);
			G_AudioMonitor.NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678497);
			G_AudioMonitor.NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678498);
			G_AudioMonitor.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678499);
			G_AudioMonitor.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678500);
			G_AudioMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100678501);
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x0000210C File Offset: 0x0000030C
		public G_AudioMonitor(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170042A0 RID: 17056
		// (get) Token: 0x0600BAB6 RID: 47798 RVA: 0x002FC4C4 File Offset: 0x002FA6C4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr));
			}
		}

		// Token: 0x170042A1 RID: 17057
		// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x002FC4D8 File Offset: 0x002FA6D8
		// (set) Token: 0x0600BAB8 RID: 47800 RVA: 0x002FC4F6 File Offset: 0x002FA6F6
		public unsafe static float m_refValue
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(G_AudioMonitor.NativeFieldInfoPtr_m_refValue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_AudioMonitor.NativeFieldInfoPtr_m_refValue, (void*)(&value));
			}
		}

		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x002FC508 File Offset: 0x002FA708
		// (set) Token: 0x0600BABA RID: 47802 RVA: 0x002FC53C File Offset: 0x002FA73C
		public unsafe GraphyManager m_graphyManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GraphyManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0600BABB RID: 47803 RVA: 0x002FC564 File Offset: 0x002FA764
		// (set) Token: 0x0600BABC RID: 47804 RVA: 0x002FC598 File Offset: 0x002FA798
		public unsafe AudioListener m_audioListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_audioListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AudioListener(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_audioListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0600BABD RID: 47805 RVA: 0x002FC5C0 File Offset: 0x002FA7C0
		// (set) Token: 0x0600BABE RID: 47806 RVA: 0x002FC5E8 File Offset: 0x002FA7E8
		public unsafe GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull)) = value;
			}
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x0600BABF RID: 47807 RVA: 0x002FC60C File Offset: 0x002FA80C
		// (set) Token: 0x0600BAC0 RID: 47808 RVA: 0x002FC634 File Offset: 0x002FA834
		public unsafe FFTWindow m_FFTWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow)) = value;
			}
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x0600BAC1 RID: 47809 RVA: 0x002FC658 File Offset: 0x002FA858
		// (set) Token: 0x0600BAC2 RID: 47810 RVA: 0x002FC680 File Offset: 0x002FA880
		public unsafe int m_spectrumSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize)) = value;
			}
		}

		// Token: 0x170042A7 RID: 17063
		// (get) Token: 0x0600BAC3 RID: 47811 RVA: 0x002FC6A4 File Offset: 0x002FA8A4
		// (set) Token: 0x0600BAC4 RID: 47812 RVA: 0x002FC6D8 File Offset: 0x002FA8D8
		public unsafe Il2CppStructArray<float> m_spectrum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042A8 RID: 17064
		// (get) Token: 0x0600BAC5 RID: 47813 RVA: 0x002FC700 File Offset: 0x002FA900
		// (set) Token: 0x0600BAC6 RID: 47814 RVA: 0x002FC734 File Offset: 0x002FA934
		public unsafe Il2CppStructArray<float> m_spectrumHighestValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042A9 RID: 17065
		// (get) Token: 0x0600BAC7 RID: 47815 RVA: 0x002FC75C File Offset: 0x002FA95C
		// (set) Token: 0x0600BAC8 RID: 47816 RVA: 0x002FC784 File Offset: 0x002FA984
		public unsafe float m_maxDB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_maxDB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_maxDB)) = value;
			}
		}

		// Token: 0x040077BE RID: 30654
		private static readonly IntPtr NativeFieldInfoPtr_m_refValue;

		// Token: 0x040077BF RID: 30655
		private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;

		// Token: 0x040077C0 RID: 30656
		private static readonly IntPtr NativeFieldInfoPtr_m_audioListener;

		// Token: 0x040077C1 RID: 30657
		private static readonly IntPtr NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull;

		// Token: 0x040077C2 RID: 30658
		private static readonly IntPtr NativeFieldInfoPtr_m_FFTWindow;

		// Token: 0x040077C3 RID: 30659
		private static readonly IntPtr NativeFieldInfoPtr_m_spectrumSize;

		// Token: 0x040077C4 RID: 30660
		private static readonly IntPtr NativeFieldInfoPtr_m_spectrum;

		// Token: 0x040077C5 RID: 30661
		private static readonly IntPtr NativeFieldInfoPtr_m_spectrumHighestValues;

		// Token: 0x040077C6 RID: 30662
		private static readonly IntPtr NativeFieldInfoPtr_m_maxDB;

		// Token: 0x040077C7 RID: 30663
		private static readonly IntPtr NativeMethodInfoPtr_get_Spectrum_Public_get_ArrayOf_Single_0;

		// Token: 0x040077C8 RID: 30664
		private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_ArrayOf_Single_0;

		// Token: 0x040077C9 RID: 30665
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0;

		// Token: 0x040077CA RID: 30666
		private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0;

		// Token: 0x040077CB RID: 30667
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040077CC RID: 30668
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077CD RID: 30669
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040077CE RID: 30670
		private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

		// Token: 0x040077CF RID: 30671
		private static readonly IntPtr NativeMethodInfoPtr_lin2dB_Public_Single_Single_0;

		// Token: 0x040077D0 RID: 30672
		private static readonly IntPtr NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0;

		// Token: 0x040077D1 RID: 30673
		private static readonly IntPtr NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0;

		// Token: 0x040077D2 RID: 30674
		private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

		// Token: 0x040077D3 RID: 30675
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040077D4 RID: 30676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
