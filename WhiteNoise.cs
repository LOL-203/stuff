using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000347 RID: 839
public class WhiteNoise : MonoBehaviour
{
	// Token: 0x0600422E RID: 16942 RVA: 0x0010AF04 File Offset: 0x00109104
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteNoise.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x0010AF48 File Offset: 0x00109148
	[CallerCount(0)]
	public unsafe WhiteNoise() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhiteNoise.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x0010AF94 File Offset: 0x00109194
	// Note: this type is marked as 'beforefieldinit'.
	static WhiteNoise()
	{
		Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WhiteNoise");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr);
		WhiteNoise.NativeFieldInfoPtr_refreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, "refreshRate");
		WhiteNoise.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, "image");
		WhiteNoise.NativeFieldInfoPtr_noiseImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, "noiseImages");
		WhiteNoise.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, "count");
		WhiteNoise.NativeFieldInfoPtr_lastSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, "lastSprite");
		WhiteNoise.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, 100668584);
		WhiteNoise.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr, 100668585);
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x0000210C File Offset: 0x0000030C
	public WhiteNoise(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001774 RID: 6004
	// (get) Token: 0x06004232 RID: 16946 RVA: 0x0010B050 File Offset: 0x00109250
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WhiteNoise>.NativeClassPtr));
		}
	}

	// Token: 0x17001775 RID: 6005
	// (get) Token: 0x06004233 RID: 16947 RVA: 0x0010B064 File Offset: 0x00109264
	// (set) Token: 0x06004234 RID: 16948 RVA: 0x0010B08C File Offset: 0x0010928C
	public unsafe float refreshRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_refreshRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_refreshRate)) = value;
		}
	}

	// Token: 0x17001776 RID: 6006
	// (get) Token: 0x06004235 RID: 16949 RVA: 0x0010B0B0 File Offset: 0x001092B0
	// (set) Token: 0x06004236 RID: 16950 RVA: 0x0010B0E4 File Offset: 0x001092E4
	public unsafe Image image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Image(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001777 RID: 6007
	// (get) Token: 0x06004237 RID: 16951 RVA: 0x0010B10C File Offset: 0x0010930C
	// (set) Token: 0x06004238 RID: 16952 RVA: 0x0010B140 File Offset: 0x00109340
	public unsafe Il2CppReferenceArray<Sprite> noiseImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_noiseImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_noiseImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001778 RID: 6008
	// (get) Token: 0x06004239 RID: 16953 RVA: 0x0010B168 File Offset: 0x00109368
	// (set) Token: 0x0600423A RID: 16954 RVA: 0x0010B190 File Offset: 0x00109390
	public unsafe float count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_count)) = value;
		}
	}

	// Token: 0x17001779 RID: 6009
	// (get) Token: 0x0600423B RID: 16955 RVA: 0x0010B1B4 File Offset: 0x001093B4
	// (set) Token: 0x0600423C RID: 16956 RVA: 0x0010B1E8 File Offset: 0x001093E8
	public unsafe Sprite lastSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_lastSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WhiteNoise.NativeFieldInfoPtr_lastSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04002A76 RID: 10870
	private static readonly IntPtr NativeFieldInfoPtr_refreshRate;

	// Token: 0x04002A77 RID: 10871
	private static readonly IntPtr NativeFieldInfoPtr_image;

	// Token: 0x04002A78 RID: 10872
	private static readonly IntPtr NativeFieldInfoPtr_noiseImages;

	// Token: 0x04002A79 RID: 10873
	private static readonly IntPtr NativeFieldInfoPtr_count;

	// Token: 0x04002A7A RID: 10874
	private static readonly IntPtr NativeFieldInfoPtr_lastSprite;

	// Token: 0x04002A7B RID: 10875
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04002A7C RID: 10876
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
