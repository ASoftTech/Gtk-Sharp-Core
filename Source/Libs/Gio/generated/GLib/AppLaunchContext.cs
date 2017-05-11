// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AppLaunchContext : GLib.Object {

		public AppLaunchContext (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_launch_context_new();

		public AppLaunchContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppLaunchContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_app_launch_context_new();
		}

		[GLib.Signal("launched")]
		public event GLib.LaunchedHandler Launched {
			add {
				this.AddSignalHandler ("launched", value, typeof (GLib.LaunchedArgs));
			}
			remove {
				this.RemoveSignalHandler ("launched", value);
			}
		}

		[GLib.Signal("launch-failed")]
		public event GLib.LaunchedFailedHandler LaunchedFailed {
			add {
				this.AddSignalHandler ("launch-failed", value, typeof (GLib.LaunchedFailedArgs));
			}
			remove {
				this.RemoveSignalHandler ("launch-failed", value);
			}
		}

		static GetDisplayNativeDelegate GetDisplay_cb_delegate;
		static GetDisplayNativeDelegate GetDisplayVMCallback {
			get {
				if (GetDisplay_cb_delegate == null)
					GetDisplay_cb_delegate = new GetDisplayNativeDelegate (GetDisplay_cb);
				return GetDisplay_cb_delegate;
			}
		}

		static void OverrideGetDisplay (GLib.GType gtype)
		{
			OverrideGetDisplay (gtype, GetDisplayVMCallback);
		}

		static void OverrideGetDisplay (GLib.GType gtype, GetDisplayNativeDelegate callback)
		{
			GAppLaunchContextClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetDisplay = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetDisplayNativeDelegate (IntPtr inst, IntPtr info, IntPtr files);

		static IntPtr GetDisplay_cb (IntPtr inst, IntPtr info, IntPtr files)
		{
			try {
				AppLaunchContext __obj = GLib.Object.GetObject (inst, false) as AppLaunchContext;
				string __result;
				__result = __obj.OnGetDisplay (GLib.AppInfoAdapter.GetObject (info, false), new GLib.List(files));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.AppLaunchContext), ConnectionMethod="OverrideGetDisplay")]
		protected virtual string OnGetDisplay (GLib.IAppInfo info, GLib.List files)
		{
			return InternalGetDisplay (info, files);
		}

		private string InternalGetDisplay (GLib.IAppInfo info, GLib.List files)
		{
			GetDisplayNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetDisplay;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, info == null ? IntPtr.Zero : ((info is GLib.Object) ? (info as GLib.Object).Handle : (info as GLib.AppInfoAdapter).Handle), files == null ? IntPtr.Zero : files.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static GetStartupNotifyIdNativeDelegate GetStartupNotifyId_cb_delegate;
		static GetStartupNotifyIdNativeDelegate GetStartupNotifyIdVMCallback {
			get {
				if (GetStartupNotifyId_cb_delegate == null)
					GetStartupNotifyId_cb_delegate = new GetStartupNotifyIdNativeDelegate (GetStartupNotifyId_cb);
				return GetStartupNotifyId_cb_delegate;
			}
		}

		static void OverrideGetStartupNotifyId (GLib.GType gtype)
		{
			OverrideGetStartupNotifyId (gtype, GetStartupNotifyIdVMCallback);
		}

		static void OverrideGetStartupNotifyId (GLib.GType gtype, GetStartupNotifyIdNativeDelegate callback)
		{
			GAppLaunchContextClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetStartupNotifyId = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStartupNotifyIdNativeDelegate (IntPtr inst, IntPtr info, IntPtr files);

		static IntPtr GetStartupNotifyId_cb (IntPtr inst, IntPtr info, IntPtr files)
		{
			try {
				AppLaunchContext __obj = GLib.Object.GetObject (inst, false) as AppLaunchContext;
				string __result;
				__result = __obj.OnGetStartupNotifyId (GLib.AppInfoAdapter.GetObject (info, false), new GLib.List(files));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.AppLaunchContext), ConnectionMethod="OverrideGetStartupNotifyId")]
		protected virtual string OnGetStartupNotifyId (GLib.IAppInfo info, GLib.List files)
		{
			return InternalGetStartupNotifyId (info, files);
		}

		private string InternalGetStartupNotifyId (GLib.IAppInfo info, GLib.List files)
		{
			GetStartupNotifyIdNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetStartupNotifyId;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, info == null ? IntPtr.Zero : ((info is GLib.Object) ? (info as GLib.Object).Handle : (info as GLib.AppInfoAdapter).Handle), files == null ? IntPtr.Zero : files.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static LaunchedFailedNativeDelegate LaunchedFailed_cb_delegate;
		static LaunchedFailedNativeDelegate LaunchedFailedVMCallback {
			get {
				if (LaunchedFailed_cb_delegate == null)
					LaunchedFailed_cb_delegate = new LaunchedFailedNativeDelegate (LaunchedFailed_cb);
				return LaunchedFailed_cb_delegate;
			}
		}

		static void OverrideLaunchedFailed (GLib.GType gtype)
		{
			OverrideLaunchedFailed (gtype, LaunchedFailedVMCallback);
		}

		static void OverrideLaunchedFailed (GLib.GType gtype, LaunchedFailedNativeDelegate callback)
		{
			GAppLaunchContextClass class_iface = GetClassStruct (gtype, false);
			class_iface.LaunchedFailed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LaunchedFailedNativeDelegate (IntPtr inst, IntPtr startup_notify_id);

		static void LaunchedFailed_cb (IntPtr inst, IntPtr startup_notify_id)
		{
			try {
				AppLaunchContext __obj = GLib.Object.GetObject (inst, false) as AppLaunchContext;
				__obj.OnLaunchedFailed (GLib.Marshaller.Utf8PtrToString (startup_notify_id));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.AppLaunchContext), ConnectionMethod="OverrideLaunchedFailed")]
		protected virtual void OnLaunchedFailed (string startup_notify_id)
		{
			InternalLaunchedFailed (startup_notify_id);
		}

		private void InternalLaunchedFailed (string startup_notify_id)
		{
			LaunchedFailedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).LaunchedFailed;
			if (unmanaged == null) return;

			IntPtr native_startup_notify_id = GLib.Marshaller.StringToPtrGStrdup (startup_notify_id);
			unmanaged (this.Handle, native_startup_notify_id);
			GLib.Marshaller.Free (native_startup_notify_id);
		}

		static LaunchedNativeDelegate Launched_cb_delegate;
		static LaunchedNativeDelegate LaunchedVMCallback {
			get {
				if (Launched_cb_delegate == null)
					Launched_cb_delegate = new LaunchedNativeDelegate (Launched_cb);
				return Launched_cb_delegate;
			}
		}

		static void OverrideLaunched (GLib.GType gtype)
		{
			OverrideLaunched (gtype, LaunchedVMCallback);
		}

		static void OverrideLaunched (GLib.GType gtype, LaunchedNativeDelegate callback)
		{
			GAppLaunchContextClass class_iface = GetClassStruct (gtype, false);
			class_iface.Launched = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LaunchedNativeDelegate (IntPtr inst, IntPtr info, IntPtr platform_data);

		static void Launched_cb (IntPtr inst, IntPtr info, IntPtr platform_data)
		{
			try {
				AppLaunchContext __obj = GLib.Object.GetObject (inst, false) as AppLaunchContext;
				__obj.OnLaunched (GLib.AppInfoAdapter.GetObject (info, false), new GLib.Variant(platform_data));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.AppLaunchContext), ConnectionMethod="OverrideLaunched")]
		protected virtual void OnLaunched (GLib.IAppInfo info, GLib.Variant platform_data)
		{
			InternalLaunched (info, platform_data);
		}

		private void InternalLaunched (GLib.IAppInfo info, GLib.Variant platform_data)
		{
			LaunchedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Launched;
			if (unmanaged == null) return;

			unmanaged (this.Handle, info == null ? IntPtr.Zero : ((info is GLib.Object) ? (info as GLib.Object).Handle : (info as GLib.AppInfoAdapter).Handle), platform_data == null ? IntPtr.Zero : platform_data.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GAppLaunchContextClass {
			public GetDisplayNativeDelegate GetDisplay;
			public GetStartupNotifyIdNativeDelegate GetStartupNotifyId;
			public LaunchedFailedNativeDelegate LaunchedFailed;
			public LaunchedNativeDelegate Launched;
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GAppLaunchContextClass> class_structs;

		static GAppLaunchContextClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GAppLaunchContextClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GAppLaunchContextClass class_struct = (GAppLaunchContextClass) Marshal.PtrToStructure (class_ptr, typeof (GAppLaunchContextClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GAppLaunchContextClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_launch_context_get_display(IntPtr raw, IntPtr info, IntPtr files);

		public string GetDisplay(GLib.IAppInfo info, GLib.List files) {
			IntPtr raw_ret = g_app_launch_context_get_display(Handle, info == null ? IntPtr.Zero : ((info is GLib.Object) ? (info as GLib.Object).Handle : (info as GLib.AppInfoAdapter).Handle), files == null ? IntPtr.Zero : files.Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_launch_context_get_environment(IntPtr raw);

		public string Environment { 
			get {
				IntPtr raw_ret = g_app_launch_context_get_environment(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_launch_context_get_startup_notify_id(IntPtr raw, IntPtr info, IntPtr files);

		public string GetStartupNotifyId(GLib.IAppInfo info, GLib.List files) {
			IntPtr raw_ret = g_app_launch_context_get_startup_notify_id(Handle, info == null ? IntPtr.Zero : ((info is GLib.Object) ? (info as GLib.Object).Handle : (info as GLib.AppInfoAdapter).Handle), files == null ? IntPtr.Zero : files.Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_app_launch_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_app_launch_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_app_launch_context_launch_failed(IntPtr raw, IntPtr startup_notify_id);

		public void LaunchFailed(string startup_notify_id) {
			IntPtr native_startup_notify_id = GLib.Marshaller.StringToPtrGStrdup (startup_notify_id);
			g_app_launch_context_launch_failed(Handle, native_startup_notify_id);
			GLib.Marshaller.Free (native_startup_notify_id);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_app_launch_context_setenv(IntPtr raw, IntPtr variable, IntPtr value);

		public void Setenv(string variable, string value) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			g_app_launch_context_setenv(Handle, native_variable, native_value);
			GLib.Marshaller.Free (native_variable);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_app_launch_context_unsetenv(IntPtr raw, IntPtr variable);

		public void Unsetenv(string variable) {
			IntPtr native_variable = GLib.Marshaller.StringToPtrGStrdup (variable);
			g_app_launch_context_unsetenv(Handle, native_variable);
			GLib.Marshaller.Free (native_variable);
		}

#endregion
	}
}
