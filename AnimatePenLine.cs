using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000344 RID: 836
public class AnimatePenLine : MonoBehaviour
{
	// Token: 0x0600420D RID: 16909 RVA: 0x0010A7E0 File Offset: 0x001089E0
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePenLine.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x0010A824 File Offset: 0x00108A24
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePenLine.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x0010A868 File Offset: 0x00108A68
	[CallerCount(0)]
	public unsafe AnimatePenLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatePenLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x0010A8B4 File Offset: 0x00108AB4
	// Note: this type is marked as 'beforefieldinit'.
	static AnimatePenLine()
	{
		Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimatePenLine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr);
		AnimatePenLine.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, "line");
		AnimatePenLine.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, "mat");
		AnimatePenLine.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, "offset");
		AnimatePenLine.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, 100668576);
		AnimatePenLine.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, 100668577);
		AnimatePenLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr, 100668578);
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x0000210C File Offset: 0x0000030C
	public AnimatePenLine(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001769 RID: 5993
	// (get) Token: 0x06004212 RID: 16914 RVA: 0x0010A95C File Offset: 0x00108B5C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimatePenLine>.NativeClassPtr));
		}
	}

	// Token: 0x1700176A RID: 5994
	// (get) Token: 0x06004213 RID: 16915 RVA: 0x0010A970 File Offset: 0x00108B70
	// (set) Token: 0x06004214 RID: 16916 RVA: 0x0010A9A4 File Offset: 0x00108BA4
	public unsafe LineRenderer line
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_line);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700176B RID: 5995
	// (get) Token: 0x06004215 RID: 16917 RVA: 0x0010A9CC File Offset: 0x00108BCC
	// (set) Token: 0x06004216 RID: 16918 RVA: 0x0010AA00 File Offset: 0x00108C00
	public unsafe Material mat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_mat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Material(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700176C RID: 5996
	// (get) Token: 0x06004217 RID: 16919 RVA: 0x0010AA28 File Offset: 0x00108C28
	// (set) Token: 0x06004218 RID: 16920 RVA: 0x0010AA50 File Offset: 0x00108C50
	public unsafe Vector2 offset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_offset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatePenLine.NativeFieldInfoPtr_offset)) = value;
		}
	}

	// Token: 0x04002A66 RID: 10854
	private static readonly IntPtr NativeFieldInfoPtr_line;

	// Token: 0x04002A67 RID: 10855
	private static readonly IntPtr NativeFieldInfoPtr_mat;

	// Token: 0x04002A68 RID: 10856
	private static readonly IntPtr NativeFieldInfoPtr_offset;

	// Token: 0x04002A69 RID: 10857
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04002A6A RID: 10858
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04002A6B RID: 10859
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
