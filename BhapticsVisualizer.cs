using System;
using Bhaptics.Tact.Unity;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000531 RID: 1329
public class BhapticsVisualizer : MonoBehaviour
{
	// Token: 0x06006C8E RID: 27790 RVA: 0x001B3C3C File Offset: 0x001B1E3C
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsVisualizer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C8F RID: 27791 RVA: 0x001B3C80 File Offset: 0x001B1E80
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsVisualizer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C90 RID: 27792 RVA: 0x001B3CC4 File Offset: 0x001B1EC4
	[CallerCount(0)]
	public unsafe BhapticsVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C91 RID: 27793 RVA: 0x001B3D10 File Offset: 0x001B1F10
	// Note: this type is marked as 'beforefieldinit'.
	static BhapticsVisualizer()
	{
		Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BhapticsVisualizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr);
		BhapticsVisualizer.NativeFieldInfoPtr_visualFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr, "visualFeedback");
		BhapticsVisualizer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr, 100671907);
		BhapticsVisualizer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr, 100671908);
		BhapticsVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr, 100671909);
	}

	// Token: 0x06006C92 RID: 27794 RVA: 0x0000210C File Offset: 0x0000030C
	public BhapticsVisualizer(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170026A3 RID: 9891
	// (get) Token: 0x06006C93 RID: 27795 RVA: 0x001B3D90 File Offset: 0x001B1F90
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BhapticsVisualizer>.NativeClassPtr));
		}
	}

	// Token: 0x170026A4 RID: 9892
	// (get) Token: 0x06006C94 RID: 27796 RVA: 0x001B3DA4 File Offset: 0x001B1FA4
	// (set) Token: 0x06006C95 RID: 27797 RVA: 0x001B3DD8 File Offset: 0x001B1FD8
	public unsafe Il2CppReferenceArray<VisualFeedback> visualFeedback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsVisualizer.NativeFieldInfoPtr_visualFeedback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<VisualFeedback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsVisualizer.NativeFieldInfoPtr_visualFeedback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400456D RID: 17773
	private static readonly IntPtr NativeFieldInfoPtr_visualFeedback;

	// Token: 0x0400456E RID: 17774
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400456F RID: 17775
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04004570 RID: 17776
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
