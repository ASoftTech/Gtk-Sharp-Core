// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RecentManager : GLib.Object {

		public RecentManager (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_manager_new();

		public RecentManager () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RecentManager)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_recent_manager_new();
		}

		[GLib.Property ("filename")]
		public string Filename {
			get {
				GLib.Value val = GetProperty ("filename");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("size")]
		public int Size {
			get {
				GLib.Value val = GetProperty ("size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			GtkRecentManagerClass class_iface = GetClassStruct (gtype, false);
			class_iface.Changed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				RecentManager __obj = GLib.Object.GetObject (inst, false) as RecentManager;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RecentManager), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Changed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkRecentManagerClass {
			public ChangedNativeDelegate Changed;
			IntPtr GtkRecent1;
			IntPtr GtkRecent2;
			IntPtr GtkRecent3;
			IntPtr GtkRecent4;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkRecentManagerClass> class_structs;

		static GtkRecentManagerClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkRecentManagerClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkRecentManagerClass class_struct = (GtkRecentManagerClass) Marshal.PtrToStructure (class_ptr, typeof (GtkRecentManagerClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkRecentManagerClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_manager_add_full(IntPtr raw, IntPtr uri, IntPtr recent_data);

		public bool AddFull(string uri, Gtk.RecentData recent_data) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_recent_data = GLib.Marshaller.StructureToPtrAlloc (recent_data);
			bool raw_ret = gtk_recent_manager_add_full(Handle, native_uri, native_recent_data);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			Marshal.FreeHGlobal (native_recent_data);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_manager_add_item(IntPtr raw, IntPtr uri);

		public bool AddItem(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gtk_recent_manager_add_item(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_recent_manager_error_quark();

		public static int ErrorQuark() {
			int raw_ret = gtk_recent_manager_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_manager_get_default();

		public static Gtk.RecentManager Default { 
			get {
				IntPtr raw_ret = gtk_recent_manager_get_default();
				Gtk.RecentManager ret = GLib.Object.GetObject(raw_ret) as Gtk.RecentManager;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_manager_get_items(IntPtr raw);

		public Gtk.RecentInfo[] RecentItems { 
			get {
				IntPtr raw_ret = gtk_recent_manager_get_items(Handle);
				Gtk.RecentInfo[] ret = (Gtk.RecentInfo[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gtk.RecentInfo));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_manager_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_recent_manager_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_manager_has_item(IntPtr raw, IntPtr uri);

		public bool HasItem(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool raw_ret = gtk_recent_manager_has_item(Handle, native_uri);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gtk_recent_manager_lookup_item(IntPtr raw, IntPtr uri, out IntPtr error);

		public unsafe Gtk.RecentInfo LookupItem(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_recent_manager_lookup_item(Handle, native_uri, out error);
			Gtk.RecentInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.RecentInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.RecentInfo), false);
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gtk_recent_manager_move_item(IntPtr raw, IntPtr uri, IntPtr new_uri, out IntPtr error);

		public unsafe bool MoveItem(string uri, string new_uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr native_new_uri = GLib.Marshaller.StringToPtrGStrdup (new_uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_manager_move_item(Handle, native_uri, native_new_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			GLib.Marshaller.Free (native_new_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int gtk_recent_manager_purge_items(IntPtr raw, out IntPtr error);

		public unsafe int PurgeItems() {
			IntPtr error = IntPtr.Zero;
			int raw_ret = gtk_recent_manager_purge_items(Handle, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gtk_recent_manager_remove_item(IntPtr raw, IntPtr uri, out IntPtr error);

		public unsafe bool RemoveItem(string uri) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_manager_remove_item(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}