// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Util : GLib.Object {

		public Util (IntPtr raw) : base(raw) {}

		protected Util() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static AddKeyEventListenerNativeDelegate AddKeyEventListener_cb_delegate;
		static AddKeyEventListenerNativeDelegate AddKeyEventListenerVMCallback {
			get {
				if (AddKeyEventListener_cb_delegate == null)
					AddKeyEventListener_cb_delegate = new AddKeyEventListenerNativeDelegate (AddKeyEventListener_cb);
				return AddKeyEventListener_cb_delegate;
			}
		}

		public delegate uint AddKeyEventListenerDelegate (Atk.KeySnoopFunc listener);
		static AddKeyEventListenerDelegate add_key_event_listener_handler;

		public static AddKeyEventListenerDelegate AddKeyEventListenerHandler {
			set {
				add_key_event_listener_handler = value;
				OverrideAddKeyEventListener ((GLib.GType) typeof (Util), value == null ? null : AddKeyEventListenerVMCallback);
			}
		}

		static void OverrideAddKeyEventListener (GLib.GType gtype, AddKeyEventListenerNativeDelegate callback)
		{
			AtkUtilClass class_iface = GetClassStruct (gtype, false);
			class_iface.AddKeyEventListener = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint AddKeyEventListenerNativeDelegate (AtkSharp.KeySnoopFuncNative listener, IntPtr data);

		static uint AddKeyEventListener_cb (AtkSharp.KeySnoopFuncNative listener, IntPtr data)
		{
			try {
				uint __result;
				AtkSharp.KeySnoopFuncInvoker listener_invoker = new AtkSharp.KeySnoopFuncInvoker (listener, data);
				__result = add_key_event_listener_handler (listener_invoker.Handler);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static GetRootNativeDelegate GetRoot_cb_delegate;
		static GetRootNativeDelegate GetRootVMCallback {
			get {
				if (GetRoot_cb_delegate == null)
					GetRoot_cb_delegate = new GetRootNativeDelegate (GetRoot_cb);
				return GetRoot_cb_delegate;
			}
		}

		public delegate Atk.Object GetRootDelegate ();
		static GetRootDelegate get_root_handler;

		public static GetRootDelegate GetRootHandler {
			set {
				get_root_handler = value;
				OverrideGetRoot ((GLib.GType) typeof (Util), value == null ? null : GetRootVMCallback);
			}
		}

		static void OverrideGetRoot (GLib.GType gtype, GetRootNativeDelegate callback)
		{
			AtkUtilClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetRoot = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetRootNativeDelegate ();

		static IntPtr GetRoot_cb ()
		{
			try {
				Atk.Object __result;
				__result = get_root_handler ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static GetToolkitNameNativeDelegate GetToolkitName_cb_delegate;
		static GetToolkitNameNativeDelegate GetToolkitNameVMCallback {
			get {
				if (GetToolkitName_cb_delegate == null)
					GetToolkitName_cb_delegate = new GetToolkitNameNativeDelegate (GetToolkitName_cb);
				return GetToolkitName_cb_delegate;
			}
		}

		public delegate string GetToolkitNameDelegate ();
		static GetToolkitNameDelegate get_toolkit_name_handler;

		public static GetToolkitNameDelegate GetToolkitNameHandler {
			set {
				get_toolkit_name_handler = value;
				OverrideGetToolkitName ((GLib.GType) typeof (Util), value == null ? null : GetToolkitNameVMCallback);
			}
		}

		static void OverrideGetToolkitName (GLib.GType gtype, GetToolkitNameNativeDelegate callback)
		{
			AtkUtilClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetToolkitName = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetToolkitNameNativeDelegate ();

		static IntPtr GetToolkitName_cb ()
		{
			try {
				string __result;
				__result = get_toolkit_name_handler ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static GetToolkitVersionNativeDelegate GetToolkitVersion_cb_delegate;
		static GetToolkitVersionNativeDelegate GetToolkitVersionVMCallback {
			get {
				if (GetToolkitVersion_cb_delegate == null)
					GetToolkitVersion_cb_delegate = new GetToolkitVersionNativeDelegate (GetToolkitVersion_cb);
				return GetToolkitVersion_cb_delegate;
			}
		}

		public delegate string GetToolkitVersionDelegate ();
		static GetToolkitVersionDelegate get_toolkit_version_handler;

		public static GetToolkitVersionDelegate GetToolkitVersionHandler {
			set {
				get_toolkit_version_handler = value;
				OverrideGetToolkitVersion ((GLib.GType) typeof (Util), value == null ? null : GetToolkitVersionVMCallback);
			}
		}

		static void OverrideGetToolkitVersion (GLib.GType gtype, GetToolkitVersionNativeDelegate callback)
		{
			AtkUtilClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetToolkitVersion = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetToolkitVersionNativeDelegate ();

		static IntPtr GetToolkitVersion_cb ()
		{
			try {
				string __result;
				__result = get_toolkit_version_handler ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct AtkUtilClass {
			IntPtr AddGlobalEventListener;
			IntPtr RemoveGlobalEventListener;
			public AddKeyEventListenerNativeDelegate AddKeyEventListener;
			IntPtr RemoveKeyEventListener;
			public GetRootNativeDelegate GetRoot;
			public GetToolkitNameNativeDelegate GetToolkitName;
			public GetToolkitVersionNativeDelegate GetToolkitVersion;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, AtkUtilClass> class_structs;

		static AtkUtilClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, AtkUtilClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				AtkUtilClass class_struct = (AtkUtilClass) Marshal.PtrToStructure (class_ptr, typeof (AtkUtilClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, AtkUtilClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_util_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = atk_util_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}