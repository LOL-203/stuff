using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000268 RID: 616
public class WorkshopTextureState : Il2CppSystem.Object
{
	// Token: 0x06002D26 RID: 11558 RVA: 0x000B17EC File Offset: 0x000AF9EC
	[CallerCount(0)]
	public unsafe WorkshopTextureState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002D27 RID: 11559 RVA: 0x000B1838 File Offset: 0x000AFA38
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopTextureState()
	{
		Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopTextureState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr);
		WorkshopTextureState.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr, "texture");
		WorkshopTextureState.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr, "Sprite");
		WorkshopTextureState.NativeFieldInfoPtr_isDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr, "isDone");
		WorkshopTextureState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr, 100666687);
	}

	// Token: 0x06002D28 RID: 11560 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopTextureState(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700102A RID: 4138
	// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000B18B8 File Offset: 0x000AFAB8
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopTextureState>.NativeClassPtr));
		}
	}

	// Token: 0x1700102B RID: 4139
	// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000B18CC File Offset: 0x000AFACC
	// (set) Token: 0x06002D2B RID: 11563 RVA: 0x000B1900 File Offset: 0x000AFB00
	public unsafe Texture texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Texture(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700102C RID: 4140
	// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000B1928 File Offset: 0x000AFB28
	// (set) Token: 0x06002D2D RID: 11565 RVA: 0x000B195C File Offset: 0x000AFB5C
	public unsafe Sprite Sprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_Sprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700102D RID: 4141
	// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000B1984 File Offset: 0x000AFB84
	// (set) Token: 0x06002D2F RID: 11567 RVA: 0x000B19AC File Offset: 0x000AFBAC
	public unsafe bool isDone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_isDone);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureState.NativeFieldInfoPtr_isDone)) = value;
		}
	}

	// Token: 0x04001C9B RID: 7323
	private static readonly IntPtr NativeFieldInfoPtr_texture;

	// Token: 0x04001C9C RID: 7324
	private static readonly IntPtr NativeFieldInfoPtr_Sprite;

	// Token: 0x04001C9D RID: 7325
	private static readonly IntPtr NativeFieldInfoPtr_isDone;

	// Token: 0x04001C9E RID: 7326
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
