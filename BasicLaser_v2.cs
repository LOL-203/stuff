using System;
using Il2CppSystem;
using Onward.AddressableTools;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

// Token: 0x020004ED RID: 1261
public class BasicLaser_v2 : MonoBehaviour
{
	// Token: 0x1700246C RID: 9324
	// (get) Token: 0x06006638 RID: 26168 RVA: 0x0019AE14 File Offset: 0x00199014
	// (set) Token: 0x06006639 RID: 26169 RVA: 0x0019AE64 File Offset: 0x00199064
	public unsafe bool BeamVisible
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_get_BeamVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_set_BeamVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x0600663A RID: 26170 RVA: 0x0019AEB8 File Offset: 0x001990B8
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600663B RID: 26171 RVA: 0x0019AEFC File Offset: 0x001990FC
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600663C RID: 26172 RVA: 0x0019AF40 File Offset: 0x00199140
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600663D RID: 26173 RVA: 0x0019AF84 File Offset: 0x00199184
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600663E RID: 26174 RVA: 0x0019AFC8 File Offset: 0x001991C8
	[CallerCount(0)]
	public unsafe void SetAsInfrared()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_SetAsInfrared_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600663F RID: 26175 RVA: 0x0019B00C File Offset: 0x0019920C
	[CallerCount(0)]
	public unsafe void DoUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_DoUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006640 RID: 26176 RVA: 0x0019B050 File Offset: 0x00199250
	[CallerCount(0)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006641 RID: 26177 RVA: 0x0019B094 File Offset: 0x00199294
	[CallerCount(0)]
	public unsafe void UpdateNightVisionStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_UpdateNightVisionStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006642 RID: 26178 RVA: 0x0019B0D8 File Offset: 0x001992D8
	[CallerCount(0)]
	public unsafe void SetLineColor(Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref c;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_SetLineColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006643 RID: 26179 RVA: 0x0019B12C File Offset: 0x0019932C
	[CallerCount(0)]
	public unsafe void SetLineTexture(Texture t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_SetLineTexture_Private_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006644 RID: 26180 RVA: 0x0019B188 File Offset: 0x00199388
	[CallerCount(0)]
	public unsafe void LoadTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_LoadTextures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006645 RID: 26181 RVA: 0x0019B1CC File Offset: 0x001993CC
	[CallerCount(0)]
	public unsafe void UnloadTextures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_UnloadTextures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006646 RID: 26182 RVA: 0x0019B210 File Offset: 0x00199410
	[CallerCount(0)]
	public unsafe void OnLaserTextureLoaded(AsyncOperationHandle<Texture> handle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_OnLaserTextureLoaded_Private_Void_AsyncOperationHandle_1_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006647 RID: 26183 RVA: 0x0019B270 File Offset: 0x00199470
	[CallerCount(0)]
	public unsafe void RefreshLaserTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_RefreshLaserTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006648 RID: 26184 RVA: 0x0019B2B4 File Offset: 0x001994B4
	[CallerCount(0)]
	public unsafe void SetLineWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr_SetLineWidth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006649 RID: 26185 RVA: 0x0019B2F8 File Offset: 0x001994F8
	[CallerCount(0)]
	public unsafe BasicLaser_v2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicLaser_v2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600664A RID: 26186 RVA: 0x0019B344 File Offset: 0x00199544
	// Note: this type is marked as 'beforefieldinit'.
	static BasicLaser_v2()
	{
		Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasicLaser_v2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr);
		BasicLaser_v2.NativeFieldInfoPtr_DOT_OFFSET_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "DOT_OFFSET_DISTANCE");
		BasicLaser_v2.NativeFieldInfoPtr_StartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "StartPoint");
		BasicLaser_v2.NativeFieldInfoPtr_LaserMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserMask");
		BasicLaser_v2.NativeFieldInfoPtr_LaserOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserOn");
		BasicLaser_v2.NativeFieldInfoPtr_UseUVPan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "UseUVPan");
		BasicLaser_v2.NativeFieldInfoPtr_EndFlareOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "EndFlareOffset");
		BasicLaser_v2.NativeFieldInfoPtr_SourceFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "SourceFlare");
		BasicLaser_v2.NativeFieldInfoPtr_EndFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "EndFlare");
		BasicLaser_v2.NativeFieldInfoPtr_EndFlareBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "EndFlareBillboard");
		BasicLaser_v2.NativeFieldInfoPtr_AddSourceLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "AddSourceLight");
		BasicLaser_v2.NativeFieldInfoPtr_AddEndLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "AddEndLight");
		BasicLaser_v2.NativeFieldInfoPtr_MenuLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "MenuLaser");
		BasicLaser_v2.NativeFieldInfoPtr_LaserColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserColor");
		BasicLaser_v2.NativeFieldInfoPtr_LaserTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserTexture");
		BasicLaser_v2.NativeFieldInfoPtr_LaserTextureNV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserTextureNV");
		BasicLaser_v2.NativeFieldInfoPtr_Loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "Loader");
		BasicLaser_v2.NativeFieldInfoPtr_TexScrollX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "TexScrollX");
		BasicLaser_v2.NativeFieldInfoPtr_TexScrollY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "TexScrollY");
		BasicLaser_v2.NativeFieldInfoPtr_UVTexScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "UVTexScale");
		BasicLaser_v2.NativeFieldInfoPtr_SeparateNVAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "SeparateNVAnimation");
		BasicLaser_v2.NativeFieldInfoPtr_TexScrollX_NV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "TexScrollX_NV");
		BasicLaser_v2.NativeFieldInfoPtr_TexScrollY_NV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "TexScrollY_NV");
		BasicLaser_v2.NativeFieldInfoPtr_UVTexScale_NV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "UVTexScale_NV");
		BasicLaser_v2.NativeFieldInfoPtr_LASER_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LASER_DIST");
		BasicLaser_v2.NativeFieldInfoPtr__currentLaserWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "_currentLaserWidth");
		BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "DEFAULT_LASER_WIDTH");
		BasicLaser_v2.NativeFieldInfoPtr_NIGHT_TIME_WIDTH_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "NIGHT_TIME_WIDTH_MULTIPLIER");
		BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH_NIGHT_VISION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "DEFAULT_LASER_WIDTH_NIGHT_VISION");
		BasicLaser_v2.NativeFieldInfoPtr_SectionDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "SectionDetail");
		BasicLaser_v2.NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "lineRenderer");
		BasicLaser_v2.NativeFieldInfoPtr_ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "ray");
		BasicLaser_v2.NativeFieldInfoPtr_EndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "EndPos");
		BasicLaser_v2.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "hit");
		BasicLaser_v2.NativeFieldInfoPtr_LaserDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LaserDir");
		BasicLaser_v2.NativeFieldInfoPtr_StartLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "StartLight");
		BasicLaser_v2.NativeFieldInfoPtr_EndLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "EndLight");
		BasicLaser_v2.NativeFieldInfoPtr_hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "hasInit");
		BasicLaser_v2.NativeFieldInfoPtr_OnInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "OnInit");
		BasicLaser_v2.NativeFieldInfoPtr_ManuallyRegisterDynamics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "ManuallyRegisterDynamics");
		BasicLaser_v2.NativeFieldInfoPtr_LoadTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LoadTexture");
		BasicLaser_v2.NativeFieldInfoPtr_LoadTextureNV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "LoadTextureNV");
		BasicLaser_v2.NativeFieldInfoPtr_MaskID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "MaskID");
		BasicLaser_v2.NativeFieldInfoPtr_ColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "ColorID");
		BasicLaser_v2.NativeFieldInfoPtr_ShaderMaskProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "ShaderMaskProp");
		BasicLaser_v2.NativeFieldInfoPtr_ShaderColorProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "ShaderColorProp");
		BasicLaser_v2.NativeFieldInfoPtr__infraredLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "_infraredLaser");
		BasicLaser_v2.NativeFieldInfoPtr__BeamVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "<BeamVisible>k__BackingField");
		BasicLaser_v2.NativeFieldInfoPtr_BeamWidthAffectedByNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, "BeamWidthAffectedByNight");
		BasicLaser_v2.NativeMethodInfoPtr_get_BeamVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671439);
		BasicLaser_v2.NativeMethodInfoPtr_set_BeamVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671440);
		BasicLaser_v2.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671441);
		BasicLaser_v2.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671442);
		BasicLaser_v2.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671443);
		BasicLaser_v2.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671444);
		BasicLaser_v2.NativeMethodInfoPtr_SetAsInfrared_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671445);
		BasicLaser_v2.NativeMethodInfoPtr_DoUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671446);
		BasicLaser_v2.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671447);
		BasicLaser_v2.NativeMethodInfoPtr_UpdateNightVisionStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671448);
		BasicLaser_v2.NativeMethodInfoPtr_SetLineColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671449);
		BasicLaser_v2.NativeMethodInfoPtr_SetLineTexture_Private_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671450);
		BasicLaser_v2.NativeMethodInfoPtr_LoadTextures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671451);
		BasicLaser_v2.NativeMethodInfoPtr_UnloadTextures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671452);
		BasicLaser_v2.NativeMethodInfoPtr_OnLaserTextureLoaded_Private_Void_AsyncOperationHandle_1_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671453);
		BasicLaser_v2.NativeMethodInfoPtr_RefreshLaserTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671454);
		BasicLaser_v2.NativeMethodInfoPtr_SetLineWidth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671455);
		BasicLaser_v2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr, 100671456);
	}

	// Token: 0x0600664B RID: 26187 RVA: 0x0000210C File Offset: 0x0000030C
	public BasicLaser_v2(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700243B RID: 9275
	// (get) Token: 0x0600664C RID: 26188 RVA: 0x0019B89C File Offset: 0x00199A9C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BasicLaser_v2>.NativeClassPtr));
		}
	}

	// Token: 0x1700243C RID: 9276
	// (get) Token: 0x0600664D RID: 26189 RVA: 0x0019B8B0 File Offset: 0x00199AB0
	// (set) Token: 0x0600664E RID: 26190 RVA: 0x0019B8CE File Offset: 0x00199ACE
	public unsafe static float DOT_OFFSET_DISTANCE
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_DOT_OFFSET_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_DOT_OFFSET_DISTANCE, (void*)(&value));
		}
	}

	// Token: 0x1700243D RID: 9277
	// (get) Token: 0x0600664F RID: 26191 RVA: 0x0019B8E0 File Offset: 0x00199AE0
	// (set) Token: 0x06006650 RID: 26192 RVA: 0x0019B914 File Offset: 0x00199B14
	public unsafe Transform StartPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_StartPoint);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_StartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700243E RID: 9278
	// (get) Token: 0x06006651 RID: 26193 RVA: 0x0019B93C File Offset: 0x00199B3C
	// (set) Token: 0x06006652 RID: 26194 RVA: 0x0019B964 File Offset: 0x00199B64
	public unsafe LayerMask LaserMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserMask)) = value;
		}
	}

	// Token: 0x1700243F RID: 9279
	// (get) Token: 0x06006653 RID: 26195 RVA: 0x0019B988 File Offset: 0x00199B88
	// (set) Token: 0x06006654 RID: 26196 RVA: 0x0019B9B0 File Offset: 0x00199BB0
	public unsafe bool LaserOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserOn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserOn)) = value;
		}
	}

	// Token: 0x17002440 RID: 9280
	// (get) Token: 0x06006655 RID: 26197 RVA: 0x0019B9D4 File Offset: 0x00199BD4
	// (set) Token: 0x06006656 RID: 26198 RVA: 0x0019B9FC File Offset: 0x00199BFC
	public unsafe bool UseUVPan
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UseUVPan);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UseUVPan)) = value;
		}
	}

	// Token: 0x17002441 RID: 9281
	// (get) Token: 0x06006657 RID: 26199 RVA: 0x0019BA20 File Offset: 0x00199C20
	// (set) Token: 0x06006658 RID: 26200 RVA: 0x0019BA48 File Offset: 0x00199C48
	public unsafe float EndFlareOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlareOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlareOffset)) = value;
		}
	}

	// Token: 0x17002442 RID: 9282
	// (get) Token: 0x06006659 RID: 26201 RVA: 0x0019BA6C File Offset: 0x00199C6C
	// (set) Token: 0x0600665A RID: 26202 RVA: 0x0019BAA0 File Offset: 0x00199CA0
	public unsafe Renderer SourceFlare
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SourceFlare);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SourceFlare), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002443 RID: 9283
	// (get) Token: 0x0600665B RID: 26203 RVA: 0x0019BAC8 File Offset: 0x00199CC8
	// (set) Token: 0x0600665C RID: 26204 RVA: 0x0019BAFC File Offset: 0x00199CFC
	public unsafe Renderer EndFlare
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlare);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlare), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002444 RID: 9284
	// (get) Token: 0x0600665D RID: 26205 RVA: 0x0019BB24 File Offset: 0x00199D24
	// (set) Token: 0x0600665E RID: 26206 RVA: 0x0019BB58 File Offset: 0x00199D58
	public unsafe LensFlareBillboard EndFlareBillboard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlareBillboard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LensFlareBillboard(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndFlareBillboard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002445 RID: 9285
	// (get) Token: 0x0600665F RID: 26207 RVA: 0x0019BB80 File Offset: 0x00199D80
	// (set) Token: 0x06006660 RID: 26208 RVA: 0x0019BBA8 File Offset: 0x00199DA8
	public unsafe bool AddSourceLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_AddSourceLight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_AddSourceLight)) = value;
		}
	}

	// Token: 0x17002446 RID: 9286
	// (get) Token: 0x06006661 RID: 26209 RVA: 0x0019BBCC File Offset: 0x00199DCC
	// (set) Token: 0x06006662 RID: 26210 RVA: 0x0019BBF4 File Offset: 0x00199DF4
	public unsafe bool AddEndLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_AddEndLight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_AddEndLight)) = value;
		}
	}

	// Token: 0x17002447 RID: 9287
	// (get) Token: 0x06006663 RID: 26211 RVA: 0x0019BC18 File Offset: 0x00199E18
	// (set) Token: 0x06006664 RID: 26212 RVA: 0x0019BC40 File Offset: 0x00199E40
	public unsafe bool MenuLaser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_MenuLaser);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_MenuLaser)) = value;
		}
	}

	// Token: 0x17002448 RID: 9288
	// (get) Token: 0x06006665 RID: 26213 RVA: 0x0019BC64 File Offset: 0x00199E64
	// (set) Token: 0x06006666 RID: 26214 RVA: 0x0019BC8C File Offset: 0x00199E8C
	public unsafe Color LaserColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserColor)) = value;
		}
	}

	// Token: 0x17002449 RID: 9289
	// (get) Token: 0x06006667 RID: 26215 RVA: 0x0019BCB0 File Offset: 0x00199EB0
	// (set) Token: 0x06006668 RID: 26216 RVA: 0x0019BCE4 File Offset: 0x00199EE4
	public unsafe AssetReference LaserTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AssetReference(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700244A RID: 9290
	// (get) Token: 0x06006669 RID: 26217 RVA: 0x0019BD0C File Offset: 0x00199F0C
	// (set) Token: 0x0600666A RID: 26218 RVA: 0x0019BD40 File Offset: 0x00199F40
	public unsafe AssetReference LaserTextureNV
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserTextureNV);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AssetReference(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserTextureNV), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700244B RID: 9291
	// (get) Token: 0x0600666B RID: 26219 RVA: 0x0019BD68 File Offset: 0x00199F68
	// (set) Token: 0x0600666C RID: 26220 RVA: 0x0019BD9C File Offset: 0x00199F9C
	public unsafe VisualLoader Loader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_Loader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VisualLoader(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_Loader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700244C RID: 9292
	// (get) Token: 0x0600666D RID: 26221 RVA: 0x0019BDC4 File Offset: 0x00199FC4
	// (set) Token: 0x0600666E RID: 26222 RVA: 0x0019BDEC File Offset: 0x00199FEC
	public unsafe float TexScrollX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollX);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollX)) = value;
		}
	}

	// Token: 0x1700244D RID: 9293
	// (get) Token: 0x0600666F RID: 26223 RVA: 0x0019BE10 File Offset: 0x0019A010
	// (set) Token: 0x06006670 RID: 26224 RVA: 0x0019BE38 File Offset: 0x0019A038
	public unsafe float TexScrollY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollY)) = value;
		}
	}

	// Token: 0x1700244E RID: 9294
	// (get) Token: 0x06006671 RID: 26225 RVA: 0x0019BE5C File Offset: 0x0019A05C
	// (set) Token: 0x06006672 RID: 26226 RVA: 0x0019BE84 File Offset: 0x0019A084
	public unsafe Vector2 UVTexScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UVTexScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UVTexScale)) = value;
		}
	}

	// Token: 0x1700244F RID: 9295
	// (get) Token: 0x06006673 RID: 26227 RVA: 0x0019BEA8 File Offset: 0x0019A0A8
	// (set) Token: 0x06006674 RID: 26228 RVA: 0x0019BED0 File Offset: 0x0019A0D0
	public unsafe bool SeparateNVAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SeparateNVAnimation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SeparateNVAnimation)) = value;
		}
	}

	// Token: 0x17002450 RID: 9296
	// (get) Token: 0x06006675 RID: 26229 RVA: 0x0019BEF4 File Offset: 0x0019A0F4
	// (set) Token: 0x06006676 RID: 26230 RVA: 0x0019BF1C File Offset: 0x0019A11C
	public unsafe float TexScrollX_NV
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollX_NV);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollX_NV)) = value;
		}
	}

	// Token: 0x17002451 RID: 9297
	// (get) Token: 0x06006677 RID: 26231 RVA: 0x0019BF40 File Offset: 0x0019A140
	// (set) Token: 0x06006678 RID: 26232 RVA: 0x0019BF68 File Offset: 0x0019A168
	public unsafe float TexScrollY_NV
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollY_NV);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_TexScrollY_NV)) = value;
		}
	}

	// Token: 0x17002452 RID: 9298
	// (get) Token: 0x06006679 RID: 26233 RVA: 0x0019BF8C File Offset: 0x0019A18C
	// (set) Token: 0x0600667A RID: 26234 RVA: 0x0019BFB4 File Offset: 0x0019A1B4
	public unsafe Vector2 UVTexScale_NV
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UVTexScale_NV);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_UVTexScale_NV)) = value;
		}
	}

	// Token: 0x17002453 RID: 9299
	// (get) Token: 0x0600667B RID: 26235 RVA: 0x0019BFD8 File Offset: 0x0019A1D8
	// (set) Token: 0x0600667C RID: 26236 RVA: 0x0019BFF6 File Offset: 0x0019A1F6
	public unsafe static float LASER_DIST
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_LASER_DIST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_LASER_DIST, (void*)(&value));
		}
	}

	// Token: 0x17002454 RID: 9300
	// (get) Token: 0x0600667D RID: 26237 RVA: 0x0019C008 File Offset: 0x0019A208
	// (set) Token: 0x0600667E RID: 26238 RVA: 0x0019C030 File Offset: 0x0019A230
	public unsafe float _currentLaserWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__currentLaserWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__currentLaserWidth)) = value;
		}
	}

	// Token: 0x17002455 RID: 9301
	// (get) Token: 0x0600667F RID: 26239 RVA: 0x0019C054 File Offset: 0x0019A254
	// (set) Token: 0x06006680 RID: 26240 RVA: 0x0019C072 File Offset: 0x0019A272
	public unsafe static float DEFAULT_LASER_WIDTH
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH, (void*)(&value));
		}
	}

	// Token: 0x17002456 RID: 9302
	// (get) Token: 0x06006681 RID: 26241 RVA: 0x0019C084 File Offset: 0x0019A284
	// (set) Token: 0x06006682 RID: 26242 RVA: 0x0019C0A2 File Offset: 0x0019A2A2
	public unsafe static float NIGHT_TIME_WIDTH_MULTIPLIER
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_NIGHT_TIME_WIDTH_MULTIPLIER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_NIGHT_TIME_WIDTH_MULTIPLIER, (void*)(&value));
		}
	}

	// Token: 0x17002457 RID: 9303
	// (get) Token: 0x06006683 RID: 26243 RVA: 0x0019C0B4 File Offset: 0x0019A2B4
	// (set) Token: 0x06006684 RID: 26244 RVA: 0x0019C0D2 File Offset: 0x0019A2D2
	public unsafe static float DEFAULT_LASER_WIDTH_NIGHT_VISION
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH_NIGHT_VISION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_DEFAULT_LASER_WIDTH_NIGHT_VISION, (void*)(&value));
		}
	}

	// Token: 0x17002458 RID: 9304
	// (get) Token: 0x06006685 RID: 26245 RVA: 0x0019C0E4 File Offset: 0x0019A2E4
	// (set) Token: 0x06006686 RID: 26246 RVA: 0x0019C10C File Offset: 0x0019A30C
	public unsafe int SectionDetail
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SectionDetail);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_SectionDetail)) = value;
		}
	}

	// Token: 0x17002459 RID: 9305
	// (get) Token: 0x06006687 RID: 26247 RVA: 0x0019C130 File Offset: 0x0019A330
	// (set) Token: 0x06006688 RID: 26248 RVA: 0x0019C164 File Offset: 0x0019A364
	public unsafe LineRenderer lineRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_lineRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_lineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700245A RID: 9306
	// (get) Token: 0x06006689 RID: 26249 RVA: 0x0019C18C File Offset: 0x0019A38C
	// (set) Token: 0x0600668A RID: 26250 RVA: 0x0019C1B4 File Offset: 0x0019A3B4
	public unsafe Ray ray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ray);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ray)) = value;
		}
	}

	// Token: 0x1700245B RID: 9307
	// (get) Token: 0x0600668B RID: 26251 RVA: 0x0019C1D8 File Offset: 0x0019A3D8
	// (set) Token: 0x0600668C RID: 26252 RVA: 0x0019C200 File Offset: 0x0019A400
	public unsafe Vector3 EndPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndPos)) = value;
		}
	}

	// Token: 0x1700245C RID: 9308
	// (get) Token: 0x0600668D RID: 26253 RVA: 0x0019C224 File Offset: 0x0019A424
	// (set) Token: 0x0600668E RID: 26254 RVA: 0x0019C24C File Offset: 0x0019A44C
	public unsafe RaycastHit hit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_hit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_hit)) = value;
		}
	}

	// Token: 0x1700245D RID: 9309
	// (get) Token: 0x0600668F RID: 26255 RVA: 0x0019C270 File Offset: 0x0019A470
	// (set) Token: 0x06006690 RID: 26256 RVA: 0x0019C298 File Offset: 0x0019A498
	public unsafe Vector3 LaserDir
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserDir);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LaserDir)) = value;
		}
	}

	// Token: 0x1700245E RID: 9310
	// (get) Token: 0x06006691 RID: 26257 RVA: 0x0019C2BC File Offset: 0x0019A4BC
	// (set) Token: 0x06006692 RID: 26258 RVA: 0x0019C2F0 File Offset: 0x0019A4F0
	public unsafe Light StartLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_StartLight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Light(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_StartLight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700245F RID: 9311
	// (get) Token: 0x06006693 RID: 26259 RVA: 0x0019C318 File Offset: 0x0019A518
	// (set) Token: 0x06006694 RID: 26260 RVA: 0x0019C34C File Offset: 0x0019A54C
	public unsafe Light EndLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndLight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Light(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_EndLight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002460 RID: 9312
	// (get) Token: 0x06006695 RID: 26261 RVA: 0x0019C374 File Offset: 0x0019A574
	// (set) Token: 0x06006696 RID: 26262 RVA: 0x0019C39C File Offset: 0x0019A59C
	public unsafe bool hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_hasInit)) = value;
		}
	}

	// Token: 0x17002461 RID: 9313
	// (get) Token: 0x06006697 RID: 26263 RVA: 0x0019C3C0 File Offset: 0x0019A5C0
	// (set) Token: 0x06006698 RID: 26264 RVA: 0x0019C3F4 File Offset: 0x0019A5F4
	public unsafe Action OnInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_OnInit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_OnInit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002462 RID: 9314
	// (get) Token: 0x06006699 RID: 26265 RVA: 0x0019C41C File Offset: 0x0019A61C
	// (set) Token: 0x0600669A RID: 26266 RVA: 0x0019C444 File Offset: 0x0019A644
	public unsafe bool ManuallyRegisterDynamics
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ManuallyRegisterDynamics);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ManuallyRegisterDynamics)) = value;
		}
	}

	// Token: 0x17002463 RID: 9315
	// (get) Token: 0x0600669B RID: 26267 RVA: 0x0019C468 File Offset: 0x0019A668
	// (set) Token: 0x0600669C RID: 26268 RVA: 0x0019C49A File Offset: 0x0019A69A
	public AsyncOperationHandle<Texture> LoadTexture
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LoadTexture);
			return new AsyncOperationHandle<Texture>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Texture>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LoadTexture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Texture>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002464 RID: 9316
	// (get) Token: 0x0600669D RID: 26269 RVA: 0x0019C4D0 File Offset: 0x0019A6D0
	// (set) Token: 0x0600669E RID: 26270 RVA: 0x0019C502 File Offset: 0x0019A702
	public AsyncOperationHandle<Texture> LoadTextureNV
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LoadTextureNV);
			return new AsyncOperationHandle<Texture>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<Texture>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_LoadTextureNV), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<Texture>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002465 RID: 9317
	// (get) Token: 0x0600669F RID: 26271 RVA: 0x0019C538 File Offset: 0x0019A738
	// (set) Token: 0x060066A0 RID: 26272 RVA: 0x0019C560 File Offset: 0x0019A760
	public unsafe int MaskID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_MaskID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_MaskID)) = value;
		}
	}

	// Token: 0x17002466 RID: 9318
	// (get) Token: 0x060066A1 RID: 26273 RVA: 0x0019C584 File Offset: 0x0019A784
	// (set) Token: 0x060066A2 RID: 26274 RVA: 0x0019C5AC File Offset: 0x0019A7AC
	public unsafe int ColorID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ColorID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_ColorID)) = value;
		}
	}

	// Token: 0x17002467 RID: 9319
	// (get) Token: 0x060066A3 RID: 26275 RVA: 0x0019C5D0 File Offset: 0x0019A7D0
	// (set) Token: 0x060066A4 RID: 26276 RVA: 0x0019C5F0 File Offset: 0x0019A7F0
	public unsafe static string ShaderMaskProp
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_ShaderMaskProp, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_ShaderMaskProp, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002468 RID: 9320
	// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0019C608 File Offset: 0x0019A808
	// (set) Token: 0x060066A6 RID: 26278 RVA: 0x0019C628 File Offset: 0x0019A828
	public unsafe static string ShaderColorProp
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(BasicLaser_v2.NativeFieldInfoPtr_ShaderColorProp, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BasicLaser_v2.NativeFieldInfoPtr_ShaderColorProp, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002469 RID: 9321
	// (get) Token: 0x060066A7 RID: 26279 RVA: 0x0019C640 File Offset: 0x0019A840
	// (set) Token: 0x060066A8 RID: 26280 RVA: 0x0019C668 File Offset: 0x0019A868
	public unsafe bool _infraredLaser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__infraredLaser);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__infraredLaser)) = value;
		}
	}

	// Token: 0x1700246A RID: 9322
	// (get) Token: 0x060066A9 RID: 26281 RVA: 0x0019C68C File Offset: 0x0019A88C
	// (set) Token: 0x060066AA RID: 26282 RVA: 0x0019C6B4 File Offset: 0x0019A8B4
	public unsafe bool _BeamVisible_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__BeamVisible_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr__BeamVisible_k__BackingField)) = value;
		}
	}

	// Token: 0x1700246B RID: 9323
	// (get) Token: 0x060066AB RID: 26283 RVA: 0x0019C6D8 File Offset: 0x0019A8D8
	// (set) Token: 0x060066AC RID: 26284 RVA: 0x0019C700 File Offset: 0x0019A900
	public unsafe bool BeamWidthAffectedByNight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_BeamWidthAffectedByNight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicLaser_v2.NativeFieldInfoPtr_BeamWidthAffectedByNight)) = value;
		}
	}

	// Token: 0x04004092 RID: 16530
	private static readonly IntPtr NativeFieldInfoPtr_DOT_OFFSET_DISTANCE;

	// Token: 0x04004093 RID: 16531
	private static readonly IntPtr NativeFieldInfoPtr_StartPoint;

	// Token: 0x04004094 RID: 16532
	private static readonly IntPtr NativeFieldInfoPtr_LaserMask;

	// Token: 0x04004095 RID: 16533
	private static readonly IntPtr NativeFieldInfoPtr_LaserOn;

	// Token: 0x04004096 RID: 16534
	private static readonly IntPtr NativeFieldInfoPtr_UseUVPan;

	// Token: 0x04004097 RID: 16535
	private static readonly IntPtr NativeFieldInfoPtr_EndFlareOffset;

	// Token: 0x04004098 RID: 16536
	private static readonly IntPtr NativeFieldInfoPtr_SourceFlare;

	// Token: 0x04004099 RID: 16537
	private static readonly IntPtr NativeFieldInfoPtr_EndFlare;

	// Token: 0x0400409A RID: 16538
	private static readonly IntPtr NativeFieldInfoPtr_EndFlareBillboard;

	// Token: 0x0400409B RID: 16539
	private static readonly IntPtr NativeFieldInfoPtr_AddSourceLight;

	// Token: 0x0400409C RID: 16540
	private static readonly IntPtr NativeFieldInfoPtr_AddEndLight;

	// Token: 0x0400409D RID: 16541
	private static readonly IntPtr NativeFieldInfoPtr_MenuLaser;

	// Token: 0x0400409E RID: 16542
	private static readonly IntPtr NativeFieldInfoPtr_LaserColor;

	// Token: 0x0400409F RID: 16543
	private static readonly IntPtr NativeFieldInfoPtr_LaserTexture;

	// Token: 0x040040A0 RID: 16544
	private static readonly IntPtr NativeFieldInfoPtr_LaserTextureNV;

	// Token: 0x040040A1 RID: 16545
	private static readonly IntPtr NativeFieldInfoPtr_Loader;

	// Token: 0x040040A2 RID: 16546
	private static readonly IntPtr NativeFieldInfoPtr_TexScrollX;

	// Token: 0x040040A3 RID: 16547
	private static readonly IntPtr NativeFieldInfoPtr_TexScrollY;

	// Token: 0x040040A4 RID: 16548
	private static readonly IntPtr NativeFieldInfoPtr_UVTexScale;

	// Token: 0x040040A5 RID: 16549
	private static readonly IntPtr NativeFieldInfoPtr_SeparateNVAnimation;

	// Token: 0x040040A6 RID: 16550
	private static readonly IntPtr NativeFieldInfoPtr_TexScrollX_NV;

	// Token: 0x040040A7 RID: 16551
	private static readonly IntPtr NativeFieldInfoPtr_TexScrollY_NV;

	// Token: 0x040040A8 RID: 16552
	private static readonly IntPtr NativeFieldInfoPtr_UVTexScale_NV;

	// Token: 0x040040A9 RID: 16553
	private static readonly IntPtr NativeFieldInfoPtr_LASER_DIST;

	// Token: 0x040040AA RID: 16554
	private static readonly IntPtr NativeFieldInfoPtr__currentLaserWidth;

	// Token: 0x040040AB RID: 16555
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_LASER_WIDTH;

	// Token: 0x040040AC RID: 16556
	private static readonly IntPtr NativeFieldInfoPtr_NIGHT_TIME_WIDTH_MULTIPLIER;

	// Token: 0x040040AD RID: 16557
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_LASER_WIDTH_NIGHT_VISION;

	// Token: 0x040040AE RID: 16558
	private static readonly IntPtr NativeFieldInfoPtr_SectionDetail;

	// Token: 0x040040AF RID: 16559
	private static readonly IntPtr NativeFieldInfoPtr_lineRenderer;

	// Token: 0x040040B0 RID: 16560
	private static readonly IntPtr NativeFieldInfoPtr_ray;

	// Token: 0x040040B1 RID: 16561
	private static readonly IntPtr NativeFieldInfoPtr_EndPos;

	// Token: 0x040040B2 RID: 16562
	private static readonly IntPtr NativeFieldInfoPtr_hit;

	// Token: 0x040040B3 RID: 16563
	private static readonly IntPtr NativeFieldInfoPtr_LaserDir;

	// Token: 0x040040B4 RID: 16564
	private static readonly IntPtr NativeFieldInfoPtr_StartLight;

	// Token: 0x040040B5 RID: 16565
	private static readonly IntPtr NativeFieldInfoPtr_EndLight;

	// Token: 0x040040B6 RID: 16566
	private static readonly IntPtr NativeFieldInfoPtr_hasInit;

	// Token: 0x040040B7 RID: 16567
	private static readonly IntPtr NativeFieldInfoPtr_OnInit;

	// Token: 0x040040B8 RID: 16568
	private static readonly IntPtr NativeFieldInfoPtr_ManuallyRegisterDynamics;

	// Token: 0x040040B9 RID: 16569
	private static readonly IntPtr NativeFieldInfoPtr_LoadTexture;

	// Token: 0x040040BA RID: 16570
	private static readonly IntPtr NativeFieldInfoPtr_LoadTextureNV;

	// Token: 0x040040BB RID: 16571
	private static readonly IntPtr NativeFieldInfoPtr_MaskID;

	// Token: 0x040040BC RID: 16572
	private static readonly IntPtr NativeFieldInfoPtr_ColorID;

	// Token: 0x040040BD RID: 16573
	private static readonly IntPtr NativeFieldInfoPtr_ShaderMaskProp;

	// Token: 0x040040BE RID: 16574
	private static readonly IntPtr NativeFieldInfoPtr_ShaderColorProp;

	// Token: 0x040040BF RID: 16575
	private static readonly IntPtr NativeFieldInfoPtr__infraredLaser;

	// Token: 0x040040C0 RID: 16576
	private static readonly IntPtr NativeFieldInfoPtr__BeamVisible_k__BackingField;

	// Token: 0x040040C1 RID: 16577
	private static readonly IntPtr NativeFieldInfoPtr_BeamWidthAffectedByNight;

	// Token: 0x040040C2 RID: 16578
	private static readonly IntPtr NativeMethodInfoPtr_get_BeamVisible_Public_get_Boolean_0;

	// Token: 0x040040C3 RID: 16579
	private static readonly IntPtr NativeMethodInfoPtr_set_BeamVisible_Public_set_Void_Boolean_0;

	// Token: 0x040040C4 RID: 16580
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040040C5 RID: 16581
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	// Token: 0x040040C6 RID: 16582
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040040C7 RID: 16583
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040040C8 RID: 16584
	private static readonly IntPtr NativeMethodInfoPtr_SetAsInfrared_Public_Void_0;

	// Token: 0x040040C9 RID: 16585
	private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Private_Void_0;

	// Token: 0x040040CA RID: 16586
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	// Token: 0x040040CB RID: 16587
	private static readonly IntPtr NativeMethodInfoPtr_UpdateNightVisionStatus_Private_Void_0;

	// Token: 0x040040CC RID: 16588
	private static readonly IntPtr NativeMethodInfoPtr_SetLineColor_Private_Void_Color_0;

	// Token: 0x040040CD RID: 16589
	private static readonly IntPtr NativeMethodInfoPtr_SetLineTexture_Private_Void_Texture_0;

	// Token: 0x040040CE RID: 16590
	private static readonly IntPtr NativeMethodInfoPtr_LoadTextures_Public_Void_0;

	// Token: 0x040040CF RID: 16591
	private static readonly IntPtr NativeMethodInfoPtr_UnloadTextures_Public_Void_0;

	// Token: 0x040040D0 RID: 16592
	private static readonly IntPtr NativeMethodInfoPtr_OnLaserTextureLoaded_Private_Void_AsyncOperationHandle_1_Texture_0;

	// Token: 0x040040D1 RID: 16593
	private static readonly IntPtr NativeMethodInfoPtr_RefreshLaserTexture_Private_Void_0;

	// Token: 0x040040D2 RID: 16594
	private static readonly IntPtr NativeMethodInfoPtr_SetLineWidth_Private_Void_0;

	// Token: 0x040040D3 RID: 16595
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
