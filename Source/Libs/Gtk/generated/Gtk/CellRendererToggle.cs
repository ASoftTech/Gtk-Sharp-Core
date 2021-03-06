// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CellRendererToggle : Gtk.CellRenderer {

		public CellRendererToggle (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_toggle_new();

		public CellRendererToggle () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererToggle)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_cell_renderer_toggle_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_renderer_toggle_get_active(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_renderer_toggle_set_active(IntPtr raw, bool setting);

		[GLib.Property ("active")]
		public bool Active {
			get  {
				bool raw_ret = gtk_cell_renderer_toggle_get_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_cell_renderer_toggle_set_active(Handle, value);
			}
		}

		[GLib.Property ("inconsistent")]
		public bool Inconsistent {
			get {
				GLib.Value val = GetProperty ("inconsistent");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("inconsistent", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_renderer_toggle_get_activatable(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_renderer_toggle_set_activatable(IntPtr raw, bool setting);

		[GLib.Property ("activatable")]
		public bool Activatable {
			get  {
				bool raw_ret = gtk_cell_renderer_toggle_get_activatable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_cell_renderer_toggle_set_activatable(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_renderer_toggle_get_radio(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_renderer_toggle_set_radio(IntPtr raw, bool radio);

		[GLib.Property ("radio")]
		public bool Radio {
			get  {
				bool raw_ret = gtk_cell_renderer_toggle_get_radio(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_cell_renderer_toggle_set_radio(Handle, value);
			}
		}

		[GLib.Property ("indicator-size")]
		public int IndicatorSize {
			get {
				GLib.Value val = GetProperty ("indicator-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("indicator-size", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("toggled")]
		public event Gtk.ToggledHandler Toggled {
			add {
				this.AddSignalHandler ("toggled", value, typeof (Gtk.ToggledArgs));
			}
			remove {
				this.RemoveSignalHandler ("toggled", value);
			}
		}

		static ToggledNativeDelegate Toggled_cb_delegate;
		static ToggledNativeDelegate ToggledVMCallback {
			get {
				if (Toggled_cb_delegate == null)
					Toggled_cb_delegate = new ToggledNativeDelegate (Toggled_cb);
				return Toggled_cb_delegate;
			}
		}

		static void OverrideToggled (GLib.GType gtype)
		{
			OverrideToggled (gtype, ToggledVMCallback);
		}

		static void OverrideToggled (GLib.GType gtype, ToggledNativeDelegate callback)
		{
			GtkCellRendererToggleClass class_iface = GetClassStruct (gtype, false);
			class_iface.Toggled = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggledNativeDelegate (IntPtr inst, IntPtr path);

		static void Toggled_cb (IntPtr inst, IntPtr path)
		{
			try {
				CellRendererToggle __obj = GLib.Object.GetObject (inst, false) as CellRendererToggle;
				__obj.OnToggled (GLib.Marshaller.Utf8PtrToString (path));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CellRendererToggle), ConnectionMethod="OverrideToggled")]
		protected virtual void OnToggled (string path)
		{
			InternalToggled (path);
		}

		private void InternalToggled (string path)
		{
			ToggledNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Toggled;
			if (unmanaged == null) return;

			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			unmanaged (this.Handle, native_path);
			GLib.Marshaller.Free (native_path);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkCellRendererToggleClass {
			public ToggledNativeDelegate Toggled;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.CellRenderer)).GetClassSize ();
		static Dictionary<GLib.GType, GtkCellRendererToggleClass> class_structs;

		static GtkCellRendererToggleClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkCellRendererToggleClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkCellRendererToggleClass class_struct = (GtkCellRendererToggleClass) Marshal.PtrToStructure (class_ptr, typeof (GtkCellRendererToggleClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkCellRendererToggleClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_toggle_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_renderer_toggle_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
