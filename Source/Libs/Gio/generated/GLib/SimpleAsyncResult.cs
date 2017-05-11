// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SimpleAsyncResult : GLib.Object, GLib.IAsyncResult {

		public SimpleAsyncResult (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_new(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr source_tag);

		public SimpleAsyncResult (GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr source_tag) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SimpleAsyncResult)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			Raw = g_simple_async_result_new(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, source_tag);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_new_from_error(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);

		public static SimpleAsyncResult NewFromError(GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr error)
		{
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			SimpleAsyncResult result = new SimpleAsyncResult (g_simple_async_result_new_from_error(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error));
			return result;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_new_take_error(IntPtr source_object, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);

		public static SimpleAsyncResult NewTakeError(GLib.Object source_object, GLib.AsyncReadyCallback cb, IntPtr error)
		{
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			SimpleAsyncResult result = new SimpleAsyncResult (g_simple_async_result_new_take_error(source_object == null ? IntPtr.Zero : source_object.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error));
			return result;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GSimpleAsyncResultClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GSimpleAsyncResultClass> class_structs;

		static GSimpleAsyncResultClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GSimpleAsyncResultClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GSimpleAsyncResultClass class_struct = (GSimpleAsyncResultClass) Marshal.PtrToStructure (class_ptr, typeof (GSimpleAsyncResultClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GSimpleAsyncResultClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_complete(IntPtr raw);

		[Obsolete]
		public void Complete() {
			g_simple_async_result_complete(Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_complete_in_idle(IntPtr raw);

		[Obsolete]
		public void CompleteInIdle() {
			g_simple_async_result_complete_in_idle(Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_simple_async_result_get_op_res_gboolean(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_op_res_gboolean(IntPtr raw, bool op_res);

		[Obsolete]
		public bool OpResGboolean { 
			get {
				bool raw_ret = g_simple_async_result_get_op_res_gboolean(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				g_simple_async_result_set_op_res_gboolean(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_get_op_res_gpointer(IntPtr raw);

		[Obsolete]
		public IntPtr OpResGpointer { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_op_res_gpointer(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_get_op_res_gssize(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_op_res_gssize(IntPtr raw, IntPtr op_res);

		[Obsolete]
		public long OpResGssize { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_op_res_gssize(Handle);
				long ret = (long) raw_ret;
				return ret;
			}
			set {
				g_simple_async_result_set_op_res_gssize(Handle, new IntPtr (value));
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_get_source_tag(IntPtr raw);

		[Obsolete]
		public IntPtr SourceTag { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_source_tag(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_simple_async_result_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_simple_async_result_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_simple_async_result_is_valid(IntPtr result, IntPtr source, IntPtr source_tag);

		[Obsolete]
		public static bool IsValid(GLib.IAsyncResult result, GLib.Object source, IntPtr source_tag) {
			bool raw_ret = g_simple_async_result_is_valid(result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), source == null ? IntPtr.Zero : source.Handle, source_tag);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_simple_async_result_propagate_error(IntPtr raw, out IntPtr dest);

		[Obsolete]
		public unsafe bool PropagateError() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_simple_async_result_propagate_error(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_run_in_thread(IntPtr raw, GLibSharp.SimpleAsyncThreadFuncNative func, int io_priority, IntPtr cancellable);

		[Obsolete]
		public void RunInThread(GLib.SimpleAsyncThreadFunc func, int io_priority, GLib.Cancellable cancellable) {
			GLibSharp.SimpleAsyncThreadFuncWrapper func_wrapper = new GLibSharp.SimpleAsyncThreadFuncWrapper (func);
			g_simple_async_result_run_in_thread(Handle, func_wrapper.NativeDelegate, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_check_cancellable(IntPtr raw, IntPtr check_cancellable);

		public GLib.Cancellable CheckCancellable { 
			set {
				g_simple_async_result_set_check_cancellable(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_error_va(IntPtr raw, int domain, int code, IntPtr format, IntPtr args);

		[Obsolete]
		public void SetErrorVa(int domain, int code, string format, IntPtr args) {
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			g_simple_async_result_set_error_va(Handle, domain, code, native_format, args);
			GLib.Marshaller.Free (native_format);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_from_error(IntPtr raw, IntPtr error);

		[Obsolete]
		public IntPtr FromError { 
			set {
				g_simple_async_result_set_from_error(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_handle_cancellation(IntPtr raw, bool handle_cancellation);

		[Obsolete]
		public bool HandleCancellation { 
			set {
				g_simple_async_result_set_handle_cancellation(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_set_op_res_gpointer(IntPtr raw, IntPtr op_res, GLib.DestroyNotify destroy_op_res);

		[Obsolete]
		public void SetOpResGpointer(IntPtr op_res, GLib.DestroyNotify destroy_op_res) {
			g_simple_async_result_set_op_res_gpointer(Handle, op_res, destroy_op_res);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_result_take_error(IntPtr raw, IntPtr error);

		[Obsolete]
		public void TakeError(IntPtr error) {
			g_simple_async_result_take_error(Handle, error);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_report_gerror_in_idle(IntPtr objekt, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);

		[Obsolete]
		public static void ReportGerrorInIdle(GLib.Object objekt, GLib.AsyncReadyCallback cb, IntPtr error) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_simple_async_report_gerror_in_idle(objekt == null ? IntPtr.Zero : objekt.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_simple_async_report_take_gerror_in_idle(IntPtr objekt, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data, IntPtr error);

		[Obsolete]
		public static void ReportTakeGerrorInIdle(GLib.Object objekt, GLib.AsyncReadyCallback cb, IntPtr error) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_simple_async_report_take_gerror_in_idle(objekt == null ? IntPtr.Zero : objekt.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero, error);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_async_result_get_source_object(IntPtr raw);

		public GLib.Object SourceObject { 
			get {
				IntPtr raw_ret = g_async_result_get_source_object(Handle);
				GLib.Object ret = GLib.Object.GetObject (raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_async_result_get_user_data(IntPtr raw);

		public IntPtr UserData { 
			get {
				IntPtr raw_ret = g_async_result_get_user_data(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_async_result_is_tagged(IntPtr raw, IntPtr source_tag);

		public bool IsTagged(IntPtr source_tag) {
			bool raw_ret = g_async_result_is_tagged(Handle, source_tag);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_async_result_legacy_propagate_error(IntPtr raw, out IntPtr error);

		public bool LegacyPropagateError() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_async_result_legacy_propagate_error(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
