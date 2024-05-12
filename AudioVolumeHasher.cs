using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200013F RID: 319
public class AudioVolumeHasher : MonoBehaviour
{
	// Token: 0x0600148F RID: 5263 RVA: 0x000534BC File Offset: 0x000516BC
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00053500 File Offset: 0x00051700
	[CallerCount(0)]
	public unsafe bool HasNullData<TVolume>(Dictionary<Vector3Int, Il2CppArrayBase<TVolume>> volumeDictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(volumeDictionary);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.MethodInfoStoreGeneric_HasNullData_Private_Boolean_Dictionary_2_Vector3Int_ArrayOf_TVolume_0<TVolume>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00053568 File Offset: 0x00051768
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x000535AC File Offset: 0x000517AC
	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<AreaReverb> GetAllReverbsAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr_GetAllReverbsAtPosition_Public_ArrayOf_AreaReverb_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaReverb>(intPtr2) : null;
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00053614 File Offset: 0x00051814
	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<AreaMuffle> GetAllMufflesAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr_GetAllMufflesAtPosition_Public_ArrayOf_AreaMuffle_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaMuffle>(intPtr2) : null;
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x0005367C File Offset: 0x0005187C
	[CallerCount(0)]
	public unsafe Il2CppReferenceArray<AreaGlobalAmbient> GetAllGlobalAmbientsAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr_GetAllGlobalAmbientsAtPosition_Public_ArrayOf_AreaGlobalAmbient_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaGlobalAmbient>(intPtr2) : null;
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x000536E4 File Offset: 0x000518E4
	[CallerCount(0)]
	public unsafe AudioVolumeHasher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioVolumeHasher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00053730 File Offset: 0x00051930
	// Note: this type is marked as 'beforefieldinit'.
	static AudioVolumeHasher()
	{
		Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioVolumeHasher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr);
		AudioVolumeHasher.NativeFieldInfoPtr_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "Singleton");
		AudioVolumeHasher.NativeFieldInfoPtr__cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_cellSize");
		AudioVolumeHasher.NativeFieldInfoPtr__inverseCellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_inverseCellSize");
		AudioVolumeHasher.NativeFieldInfoPtr__displayCellPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_displayCellPositions");
		AudioVolumeHasher.NativeFieldInfoPtr__defaultReverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_defaultReverb");
		AudioVolumeHasher.NativeFieldInfoPtr__defaultMuffle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_defaultMuffle");
		AudioVolumeHasher.NativeFieldInfoPtr__defaultGlobalAmbient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_defaultGlobalAmbient");
		AudioVolumeHasher.NativeFieldInfoPtr__bakedReverbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_bakedReverbs");
		AudioVolumeHasher.NativeFieldInfoPtr__bakedMuffles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_bakedMuffles");
		AudioVolumeHasher.NativeFieldInfoPtr__bakedGlobalAmbients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_bakedGlobalAmbients");
		AudioVolumeHasher.NativeFieldInfoPtr__reverbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_reverbs");
		AudioVolumeHasher.NativeFieldInfoPtr__muffles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_muffles");
		AudioVolumeHasher.NativeFieldInfoPtr__globalAmbients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_globalAmbients");
		AudioVolumeHasher.NativeFieldInfoPtr__emptyReverbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_emptyReverbs");
		AudioVolumeHasher.NativeFieldInfoPtr__emptyMuffles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_emptyMuffles");
		AudioVolumeHasher.NativeFieldInfoPtr__emptyGlobalAmbients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, "_emptyGlobalAmbients");
		AudioVolumeHasher.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665009);
		AudioVolumeHasher.NativeMethodInfoPtr_HasNullData_Private_Boolean_Dictionary_2_Vector3Int_ArrayOf_TVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665010);
		AudioVolumeHasher.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665011);
		AudioVolumeHasher.NativeMethodInfoPtr_GetAllReverbsAtPosition_Public_ArrayOf_AreaReverb_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665012);
		AudioVolumeHasher.NativeMethodInfoPtr_GetAllMufflesAtPosition_Public_ArrayOf_AreaMuffle_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665013);
		AudioVolumeHasher.NativeMethodInfoPtr_GetAllGlobalAmbientsAtPosition_Public_ArrayOf_AreaGlobalAmbient_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665014);
		AudioVolumeHasher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr, 100665015);
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x0000210C File Offset: 0x0000030C
	public AudioVolumeHasher(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x06001498 RID: 5272 RVA: 0x0005392C File Offset: 0x00051B2C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr));
		}
	}

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x06001499 RID: 5273 RVA: 0x00053940 File Offset: 0x00051B40
	// (set) Token: 0x0600149A RID: 5274 RVA: 0x0005396B File Offset: 0x00051B6B
	public unsafe static AudioVolumeHasher Singleton
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioVolumeHasher.NativeFieldInfoPtr_Singleton, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AudioVolumeHasher(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioVolumeHasher.NativeFieldInfoPtr_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006FB RID: 1787
	// (get) Token: 0x0600149B RID: 5275 RVA: 0x00053980 File Offset: 0x00051B80
	// (set) Token: 0x0600149C RID: 5276 RVA: 0x000539A8 File Offset: 0x00051BA8
	public unsafe float _cellSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__cellSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__cellSize)) = value;
		}
	}

	// Token: 0x170006FC RID: 1788
	// (get) Token: 0x0600149D RID: 5277 RVA: 0x000539CC File Offset: 0x00051BCC
	// (set) Token: 0x0600149E RID: 5278 RVA: 0x000539F4 File Offset: 0x00051BF4
	public unsafe float _inverseCellSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__inverseCellSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__inverseCellSize)) = value;
		}
	}

	// Token: 0x170006FD RID: 1789
	// (get) Token: 0x0600149F RID: 5279 RVA: 0x00053A18 File Offset: 0x00051C18
	// (set) Token: 0x060014A0 RID: 5280 RVA: 0x00053A40 File Offset: 0x00051C40
	public unsafe bool _displayCellPositions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__displayCellPositions);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__displayCellPositions)) = value;
		}
	}

	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00053A64 File Offset: 0x00051C64
	// (set) Token: 0x060014A2 RID: 5282 RVA: 0x00053A98 File Offset: 0x00051C98
	public unsafe AreaReverb _defaultReverb
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultReverb);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AreaReverb(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultReverb), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006FF RID: 1791
	// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00053AC0 File Offset: 0x00051CC0
	// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00053AF4 File Offset: 0x00051CF4
	public unsafe AreaMuffle _defaultMuffle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultMuffle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AreaMuffle(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultMuffle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000700 RID: 1792
	// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00053B1C File Offset: 0x00051D1C
	// (set) Token: 0x060014A6 RID: 5286 RVA: 0x00053B50 File Offset: 0x00051D50
	public unsafe AreaGlobalAmbient _defaultGlobalAmbient
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultGlobalAmbient);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AreaGlobalAmbient(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__defaultGlobalAmbient), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000701 RID: 1793
	// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00053B78 File Offset: 0x00051D78
	// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00053BAC File Offset: 0x00051DAC
	public unsafe List<AreaVolumeHash> _bakedReverbs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedReverbs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AreaVolumeHash>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedReverbs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000702 RID: 1794
	// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00053BD4 File Offset: 0x00051DD4
	// (set) Token: 0x060014AA RID: 5290 RVA: 0x00053C08 File Offset: 0x00051E08
	public unsafe List<AreaVolumeHash> _bakedMuffles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedMuffles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AreaVolumeHash>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedMuffles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000703 RID: 1795
	// (get) Token: 0x060014AB RID: 5291 RVA: 0x00053C30 File Offset: 0x00051E30
	// (set) Token: 0x060014AC RID: 5292 RVA: 0x00053C64 File Offset: 0x00051E64
	public unsafe List<AreaVolumeHash> _bakedGlobalAmbients
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedGlobalAmbients);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AreaVolumeHash>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__bakedGlobalAmbients), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000704 RID: 1796
	// (get) Token: 0x060014AD RID: 5293 RVA: 0x00053C8C File Offset: 0x00051E8C
	// (set) Token: 0x060014AE RID: 5294 RVA: 0x00053CC0 File Offset: 0x00051EC0
	public unsafe Dictionary<Vector3Int, Il2CppReferenceArray<AreaReverb>> _reverbs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__reverbs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<Vector3Int, Il2CppReferenceArray<AreaReverb>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__reverbs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000705 RID: 1797
	// (get) Token: 0x060014AF RID: 5295 RVA: 0x00053CE8 File Offset: 0x00051EE8
	// (set) Token: 0x060014B0 RID: 5296 RVA: 0x00053D1C File Offset: 0x00051F1C
	public unsafe Dictionary<Vector3Int, Il2CppReferenceArray<AreaMuffle>> _muffles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__muffles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<Vector3Int, Il2CppReferenceArray<AreaMuffle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__muffles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000706 RID: 1798
	// (get) Token: 0x060014B1 RID: 5297 RVA: 0x00053D44 File Offset: 0x00051F44
	// (set) Token: 0x060014B2 RID: 5298 RVA: 0x00053D78 File Offset: 0x00051F78
	public unsafe Dictionary<Vector3Int, Il2CppReferenceArray<AreaGlobalAmbient>> _globalAmbients
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__globalAmbients);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<Vector3Int, Il2CppReferenceArray<AreaGlobalAmbient>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__globalAmbients), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000707 RID: 1799
	// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00053DA0 File Offset: 0x00051FA0
	// (set) Token: 0x060014B4 RID: 5300 RVA: 0x00053DD4 File Offset: 0x00051FD4
	public unsafe Il2CppReferenceArray<AreaReverb> _emptyReverbs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyReverbs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaReverb>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyReverbs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000708 RID: 1800
	// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00053DFC File Offset: 0x00051FFC
	// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00053E30 File Offset: 0x00052030
	public unsafe Il2CppReferenceArray<AreaMuffle> _emptyMuffles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyMuffles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaMuffle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyMuffles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000709 RID: 1801
	// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00053E58 File Offset: 0x00052058
	// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00053E8C File Offset: 0x0005208C
	public unsafe Il2CppReferenceArray<AreaGlobalAmbient> _emptyGlobalAmbients
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyGlobalAmbients);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<AreaGlobalAmbient>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioVolumeHasher.NativeFieldInfoPtr__emptyGlobalAmbients), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D27 RID: 3367
	private static readonly IntPtr NativeFieldInfoPtr_Singleton;

	// Token: 0x04000D28 RID: 3368
	private static readonly IntPtr NativeFieldInfoPtr__cellSize;

	// Token: 0x04000D29 RID: 3369
	private static readonly IntPtr NativeFieldInfoPtr__inverseCellSize;

	// Token: 0x04000D2A RID: 3370
	private static readonly IntPtr NativeFieldInfoPtr__displayCellPositions;

	// Token: 0x04000D2B RID: 3371
	private static readonly IntPtr NativeFieldInfoPtr__defaultReverb;

	// Token: 0x04000D2C RID: 3372
	private static readonly IntPtr NativeFieldInfoPtr__defaultMuffle;

	// Token: 0x04000D2D RID: 3373
	private static readonly IntPtr NativeFieldInfoPtr__defaultGlobalAmbient;

	// Token: 0x04000D2E RID: 3374
	private static readonly IntPtr NativeFieldInfoPtr__bakedReverbs;

	// Token: 0x04000D2F RID: 3375
	private static readonly IntPtr NativeFieldInfoPtr__bakedMuffles;

	// Token: 0x04000D30 RID: 3376
	private static readonly IntPtr NativeFieldInfoPtr__bakedGlobalAmbients;

	// Token: 0x04000D31 RID: 3377
	private static readonly IntPtr NativeFieldInfoPtr__reverbs;

	// Token: 0x04000D32 RID: 3378
	private static readonly IntPtr NativeFieldInfoPtr__muffles;

	// Token: 0x04000D33 RID: 3379
	private static readonly IntPtr NativeFieldInfoPtr__globalAmbients;

	// Token: 0x04000D34 RID: 3380
	private static readonly IntPtr NativeFieldInfoPtr__emptyReverbs;

	// Token: 0x04000D35 RID: 3381
	private static readonly IntPtr NativeFieldInfoPtr__emptyMuffles;

	// Token: 0x04000D36 RID: 3382
	private static readonly IntPtr NativeFieldInfoPtr__emptyGlobalAmbients;

	// Token: 0x04000D37 RID: 3383
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

	// Token: 0x04000D38 RID: 3384
	private static readonly IntPtr NativeMethodInfoPtr_HasNullData_Private_Boolean_Dictionary_2_Vector3Int_ArrayOf_TVolume_0;

	// Token: 0x04000D39 RID: 3385
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x04000D3A RID: 3386
	private static readonly IntPtr NativeMethodInfoPtr_GetAllReverbsAtPosition_Public_ArrayOf_AreaReverb_Vector3_0;

	// Token: 0x04000D3B RID: 3387
	private static readonly IntPtr NativeMethodInfoPtr_GetAllMufflesAtPosition_Public_ArrayOf_AreaMuffle_Vector3_0;

	// Token: 0x04000D3C RID: 3388
	private static readonly IntPtr NativeMethodInfoPtr_GetAllGlobalAmbientsAtPosition_Public_ArrayOf_AreaGlobalAmbient_Vector3_0;

	// Token: 0x04000D3D RID: 3389
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000140 RID: 320
	private sealed class MethodInfoStoreGeneric_HasNullData_Private_Boolean_Dictionary_2_Vector3Int_ArrayOf_TVolume_0<TVolume>
	{
		// Token: 0x04000D3E RID: 3390
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AudioVolumeHasher.NativeMethodInfoPtr_HasNullData_Private_Boolean_Dictionary_2_Vector3Int_ArrayOf_TVolume_0, Il2CppClassPointerStore<AudioVolumeHasher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TVolume>.NativeClassPtr))
		}))));
	}
}
