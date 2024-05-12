using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace TerrainStitch
{
	// Token: 0x0200061F RID: 1567
	public class TerrainNeighbours : MonoBehaviour
	{
		// Token: 0x06007F36 RID: 32566 RVA: 0x0020247C File Offset: 0x0020067C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainNeighbours.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x002024C0 File Offset: 0x002006C0
		[CallerCount(0)]
		public unsafe void CreateNeighbours()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainNeighbours.NativeMethodInfoPtr_CreateNeighbours_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00202504 File Offset: 0x00200704
		[CallerCount(0)]
		public unsafe TerrainNeighbours() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainNeighbours.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x00202550 File Offset: 0x00200750
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainNeighbours()
		{
			Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TerrainStitch", "TerrainNeighbours");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr);
			TerrainNeighbours.NativeFieldInfoPtr__terrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, "_terrains");
			TerrainNeighbours.NativeFieldInfoPtr__terrainDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, "_terrainDict");
			TerrainNeighbours.NativeFieldInfoPtr_firstPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, "firstPosition");
			TerrainNeighbours.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, 100673579);
			TerrainNeighbours.NativeMethodInfoPtr_CreateNeighbours_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, 100673580);
			TerrainNeighbours.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr, 100673581);
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x0000210C File Offset: 0x0000030C
		public TerrainNeighbours(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x002025F8 File Offset: 0x002007F8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TerrainNeighbours>.NativeClassPtr));
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x06007F3C RID: 32572 RVA: 0x0020260C File Offset: 0x0020080C
		// (set) Token: 0x06007F3D RID: 32573 RVA: 0x00202640 File Offset: 0x00200840
		public unsafe Il2CppReferenceArray<Terrain> _terrains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr__terrains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr__terrains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x06007F3E RID: 32574 RVA: 0x00202668 File Offset: 0x00200868
		// (set) Token: 0x06007F3F RID: 32575 RVA: 0x0020269C File Offset: 0x0020089C
		public unsafe Dictionary<Il2CppStructArray<int>, Terrain> _terrainDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr__terrainDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<Il2CppStructArray<int>, Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr__terrainDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x06007F40 RID: 32576 RVA: 0x002026C4 File Offset: 0x002008C4
		// (set) Token: 0x06007F41 RID: 32577 RVA: 0x002026EC File Offset: 0x002008EC
		public unsafe Vector2 firstPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr_firstPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainNeighbours.NativeFieldInfoPtr_firstPosition)) = value;
			}
		}

		// Token: 0x0400519D RID: 20893
		private static readonly IntPtr NativeFieldInfoPtr__terrains;

		// Token: 0x0400519E RID: 20894
		private static readonly IntPtr NativeFieldInfoPtr__terrainDict;

		// Token: 0x0400519F RID: 20895
		private static readonly IntPtr NativeFieldInfoPtr_firstPosition;

		// Token: 0x040051A0 RID: 20896
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051A1 RID: 20897
		private static readonly IntPtr NativeMethodInfoPtr_CreateNeighbours_Public_Void_0;

		// Token: 0x040051A2 RID: 20898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
