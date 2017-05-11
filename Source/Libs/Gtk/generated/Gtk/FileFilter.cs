// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FileFilter : GLib.InitiallyUnowned {

		public FileFilter (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_new();

		public FileFilter () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileFilter)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_file_filter_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_new_from_gvariant(IntPtr variant);

		public FileFilter (GLib.Variant variant) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FileFilter)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_file_filter_new_from_gvariant(variant == null ? IntPtr.Zero : variant.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFileFilterClass {
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.InitiallyUnowned)).GetClassSize ();
		static Dictionary<GLib.GType, GtkFileFilterClass> class_structs;

		static GtkFileFilterClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkFileFilterClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkFileFilterClass class_struct = (GtkFileFilterClass) Marshal.PtrToStructure (class_ptr, typeof (GtkFileFilterClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkFileFilterClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_filter_add_custom(IntPtr raw, int needed, GtkSharp.FileFilterFuncNative func, IntPtr data, GLib.DestroyNotify notify);

		public void AddCustom(Gtk.FileFilterFlags needed, Gtk.FileFilterFunc func) {
			GtkSharp.FileFilterFuncWrapper func_wrapper = new GtkSharp.FileFilterFuncWrapper (func);
			IntPtr data;
			GLib.DestroyNotify notify;
			if (func == null) {
				data = IntPtr.Zero;
				notify = null;
			} else {
				data = (IntPtr) GCHandle.Alloc (func_wrapper);
				notify = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_file_filter_add_custom(Handle, (int) needed, func_wrapper.NativeDelegate, data, notify);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_filter_add_mime_type(IntPtr raw, IntPtr mime_type);

		public void AddMimeType(string mime_type) {
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			gtk_file_filter_add_mime_type(Handle, native_mime_type);
			GLib.Marshaller.Free (native_mime_type);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_filter_add_pattern(IntPtr raw, IntPtr pattern);

		public void AddPattern(string pattern) {
			IntPtr native_pattern = GLib.Marshaller.StringToPtrGStrdup (pattern);
			gtk_file_filter_add_pattern(Handle, native_pattern);
			GLib.Marshaller.Free (native_pattern);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_filter_add_pixbuf_formats(IntPtr raw);

		public void AddPixbufFormats() {
			gtk_file_filter_add_pixbuf_formats(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_file_filter_filter(IntPtr raw, IntPtr filter_info);

		public bool Filter(Gtk.FileFilterInfo filter_info) {
			IntPtr native_filter_info = GLib.Marshaller.StructureToPtrAlloc (filter_info);
			bool raw_ret = gtk_file_filter_filter(Handle, native_filter_info);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_filter_info);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_get_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_file_filter_set_name(IntPtr raw, IntPtr name);

		public string Name { 
			get {
				IntPtr raw_ret = gtk_file_filter_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_file_filter_set_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_file_filter_get_needed(IntPtr raw);

		public Gtk.FileFilterFlags Needed { 
			get {
				int raw_ret = gtk_file_filter_get_needed(Handle);
				Gtk.FileFilterFlags ret = (Gtk.FileFilterFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_file_filter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_to_gvariant(IntPtr raw);

		public GLib.Variant ToGvariant() {
			IntPtr raw_ret = gtk_file_filter_to_gvariant(Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			return ret;
		}

#endregion
	}
}