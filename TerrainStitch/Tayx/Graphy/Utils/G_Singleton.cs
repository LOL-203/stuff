using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tayx.Graphy.Utils
{
	// Token: 0x020008DF RID: 2271
	public class G_Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x0600B929 RID: 47401 RVA: 0x002F6450 File Offset: 0x002F4650
		public unsafe static T Instance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
			}
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x002F6490 File Offset: 0x002F4690
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x002F64D4 File Offset: 0x002F46D4
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x002F6518 File Offset: 0x002F4718
		[CallerCount(0)]
		public unsafe G_Singleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x002F6564 File Offset: 0x002F4764
		// Note: this type is marked as 'beforefieldinit'.
		static G_Singleton()
		{
			Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Utils", "G_Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr);
			G_Singleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, "_instance");
			G_Singleton<T>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, "_lock");
			G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, "_applicationIsQuitting");
			G_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100678382);
			G_Singleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100678383);
			G_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100678384);
			G_Singleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100678385);
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x0000210C File Offset: 0x0000030C
		public G_Singleton(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700420F RID: 16911
		// (get) Token: 0x0600B92F RID: 47407 RVA: 0x002F665B File Offset: 0x002F485B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr));
			}
		}

		// Token: 0x17004210 RID: 16912
		// (get) Token: 0x0600B930 RID: 47408 RVA: 0x002F666C File Offset: 0x002F486C
		// (set) Token: 0x0600B931 RID: 47409 RVA: 0x002F6690 File Offset: 0x002F4890
		public unsafe static T _instance
		{
			get
			{
				IntPtr objectPointer;
				IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__instance, (void*)(&objectPointer));
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__instance = G_Singleton<T>.NativeFieldInfoPtr__instance;
				T value2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = value2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							value2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								value2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						value2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					value2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__instance, (void*)(&value2));
			}
		}

		// Token: 0x17004211 RID: 16913
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x002F6704 File Offset: 0x002F4904
		// (set) Token: 0x0600B933 RID: 47411 RVA: 0x002F672F File Offset: 0x002F492F
		public unsafe static Il2CppSystem.Object _lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_Singleton<T>.NativeFieldInfoPtr__lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004212 RID: 16914
		// (get) Token: 0x0600B934 RID: 47412 RVA: 0x002F6744 File Offset: 0x002F4944
		// (set) Token: 0x0600B935 RID: 47413 RVA: 0x002F6762 File Offset: 0x002F4962
		public unsafe static bool _applicationIsQuitting
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting, (void*)(&value));
			}
		}

		// Token: 0x040076E4 RID: 30436
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040076E5 RID: 30437
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040076E6 RID: 30438
		private static readonly IntPtr NativeFieldInfoPtr__applicationIsQuitting;

		// Token: 0x040076E7 RID: 30439
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040076E8 RID: 30440
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040076E9 RID: 30441
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040076EA RID: 30442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
