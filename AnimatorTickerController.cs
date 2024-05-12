using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000C2 RID: 194
public class AnimatorTickerController : MonoBehaviour
{
	// Token: 0x06000C1D RID: 3101 RVA: 0x00031590 File Offset: 0x0002F790
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x000315D4 File Offset: 0x0002F7D4
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00031618 File Offset: 0x0002F818
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0003165C File Offset: 0x0002F85C
	[CallerCount(0)]
	public unsafe void Add(AnimatorTicker ticker)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ticker);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr_Add_Public_Void_AnimatorTicker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x000316B8 File Offset: 0x0002F8B8
	[CallerCount(0)]
	public unsafe void Remove(AnimatorTicker ticker)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ticker);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr_Remove_Public_Void_AnimatorTicker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00031714 File Offset: 0x0002F914
	[CallerCount(0)]
	public unsafe AnimatorTickerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorTickerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00031760 File Offset: 0x0002F960
	// Note: this type is marked as 'beforefieldinit'.
	static AnimatorTickerController()
	{
		Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnimatorTickerController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr);
		AnimatorTickerController.NativeFieldInfoPtr_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, "Singleton");
		AnimatorTickerController.NativeFieldInfoPtr_AllTickers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, "AllTickers");
		AnimatorTickerController.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664240);
		AnimatorTickerController.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664241);
		AnimatorTickerController.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664242);
		AnimatorTickerController.NativeMethodInfoPtr_Add_Public_Void_AnimatorTicker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664243);
		AnimatorTickerController.NativeMethodInfoPtr_Remove_Public_Void_AnimatorTicker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664244);
		AnimatorTickerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr, 100664245);
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0000210C File Offset: 0x0000030C
	public AnimatorTickerController(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00031830 File Offset: 0x0002FA30
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnimatorTickerController>.NativeClassPtr));
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00031844 File Offset: 0x0002FA44
	// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0003186F File Offset: 0x0002FA6F
	public unsafe static AnimatorTickerController Singleton
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AnimatorTickerController.NativeFieldInfoPtr_Singleton, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AnimatorTickerController(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnimatorTickerController.NativeFieldInfoPtr_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00031884 File Offset: 0x0002FA84
	// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000318B8 File Offset: 0x0002FAB8
	public unsafe List<AnimatorTicker> AllTickers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTickerController.NativeFieldInfoPtr_AllTickers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AnimatorTicker>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorTickerController.NativeFieldInfoPtr_AllTickers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000756 RID: 1878
	private static readonly IntPtr NativeFieldInfoPtr_Singleton;

	// Token: 0x04000757 RID: 1879
	private static readonly IntPtr NativeFieldInfoPtr_AllTickers;

	// Token: 0x04000758 RID: 1880
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x04000759 RID: 1881
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x0400075A RID: 1882
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

	// Token: 0x0400075B RID: 1883
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_AnimatorTicker_0;

	// Token: 0x0400075C RID: 1884
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_AnimatorTicker_0;

	// Token: 0x0400075D RID: 1885
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
