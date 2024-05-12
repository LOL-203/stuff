using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020001AA RID: 426
public class AnimatedTextureUVs : MonoBehaviour
{
	// Token: 0x06001CFD RID: 7421 RVA: 0x000731A4 File Offset: 0x000713A4
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedTextureUVs.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x000731E8 File Offset: 0x000713E8
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedTextureUVs.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x0007322C File Offset: 0x0007142C
	[CallerCount(0)]
	public unsafe AnimatedTextureUVs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatedTextureUVs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x00073278 File Offset: 0x00071478
	// Note: this type is marked as 'beforefieldinit'.
	static AnimatedTextureUVs()
	{
		Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimatedTextureUVs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr);
		AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, "uvAnimationTileX");
		AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, "uvAnimationTileY");
		AnimatedTextureUVs.NativeFieldInfoPtr_framesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, "framesPerSecond");
		AnimatedTextureUVs.NativeFieldInfoPtr_render = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, "render");
		AnimatedTextureUVs.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, "keyword");
		AnimatedTextureUVs.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, 100665573);
		AnimatedTextureUVs.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, 100665574);
		AnimatedTextureUVs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr, 100665575);
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x0000210C File Offset: 0x0000030C
	public AnimatedTextureUVs(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000A19 RID: 2585
	// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00073348 File Offset: 0x00071548
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimatedTextureUVs>.NativeClassPtr));
		}
	}

	// Token: 0x17000A1A RID: 2586
	// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0007335C File Offset: 0x0007155C
	// (set) Token: 0x06001D04 RID: 7428 RVA: 0x00073384 File Offset: 0x00071584
	public unsafe int uvAnimationTileX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileX);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileX)) = value;
		}
	}

	// Token: 0x17000A1B RID: 2587
	// (get) Token: 0x06001D05 RID: 7429 RVA: 0x000733A8 File Offset: 0x000715A8
	// (set) Token: 0x06001D06 RID: 7430 RVA: 0x000733D0 File Offset: 0x000715D0
	public unsafe int uvAnimationTileY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_uvAnimationTileY)) = value;
		}
	}

	// Token: 0x17000A1C RID: 2588
	// (get) Token: 0x06001D07 RID: 7431 RVA: 0x000733F4 File Offset: 0x000715F4
	// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0007341C File Offset: 0x0007161C
	public unsafe float framesPerSecond
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_framesPerSecond);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_framesPerSecond)) = value;
		}
	}

	// Token: 0x17000A1D RID: 2589
	// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00073440 File Offset: 0x00071640
	// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00073474 File Offset: 0x00071674
	public unsafe Renderer render
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_render);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatedTextureUVs.NativeFieldInfoPtr_render), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000A1E RID: 2590
	// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0007349C File Offset: 0x0007169C
	// (set) Token: 0x06001D0C RID: 7436 RVA: 0x000734BC File Offset: 0x000716BC
	public unsafe static string keyword
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(AnimatedTextureUVs.NativeFieldInfoPtr_keyword, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimatedTextureUVs.NativeFieldInfoPtr_keyword, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04001289 RID: 4745
	private static readonly IntPtr NativeFieldInfoPtr_uvAnimationTileX;

	// Token: 0x0400128A RID: 4746
	private static readonly IntPtr NativeFieldInfoPtr_uvAnimationTileY;

	// Token: 0x0400128B RID: 4747
	private static readonly IntPtr NativeFieldInfoPtr_framesPerSecond;

	// Token: 0x0400128C RID: 4748
	private static readonly IntPtr NativeFieldInfoPtr_render;

	// Token: 0x0400128D RID: 4749
	private static readonly IntPtr NativeFieldInfoPtr_keyword;

	// Token: 0x0400128E RID: 4750
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x0400128F RID: 4751
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

	// Token: 0x04001290 RID: 4752
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
