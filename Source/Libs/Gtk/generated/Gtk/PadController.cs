// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PadController : Gtk.EventController {

		public PadController (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pad_controller_new(IntPtr window, IntPtr group, IntPtr pad);

		public PadController (Gtk.Window window, GLib.IActionGroup group, Gdk.Device pad) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PadController)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (window != null) {
					names.Add ("pad");
					vals.Add (new GLib.Value (pad));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_pad_controller_new(window == null ? IntPtr.Zero : window.Handle, group == null ? IntPtr.Zero : ((group is GLib.Object) ? (group as GLib.Object).Handle : (group as GLib.ActionGroupAdapter).Handle), pad == null ? IntPtr.Zero : pad.Handle);
		}

		[GLib.Property ("action-group")]
		public GLib.IActionGroup ActionGroup {
			get {
				GLib.Value val = GetProperty ("action-group");
				GLib.IActionGroup ret = GLib.ActionGroupAdapter.GetObject ((GLib.Object) val);
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("pad")]
		public Gdk.Device Pad {
			get {
				GLib.Value val = GetProperty ("pad");
				Gdk.Device ret = (Gdk.Device) val;
				val.Dispose ();
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkPadControllerClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.EventController)).GetClassSize ();
		static Dictionary<GLib.GType, GtkPadControllerClass> class_structs;

		static GtkPadControllerClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkPadControllerClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkPadControllerClass class_struct = (GtkPadControllerClass) Marshal.PtrToStructure (class_ptr, typeof (GtkPadControllerClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkPadControllerClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pad_controller_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_pad_controller_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_pad_controller_set_action(IntPtr raw, int type, int index, int mode, IntPtr label, IntPtr action_name);

		public void SetAction(Gtk.PadActionType type, int index, int mode, string label, string action_name) {
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			IntPtr native_action_name = GLib.Marshaller.StringToPtrGStrdup (action_name);
			gtk_pad_controller_set_action(Handle, (int) type, index, mode, native_label, native_action_name);
			GLib.Marshaller.Free (native_label);
			GLib.Marshaller.Free (native_action_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_pad_controller_set_action_entries(IntPtr raw, IntPtr entries, int n_entries);

		public void SetActionEntries(Gtk.PadActionEntry entries, int n_entries) {
			IntPtr native_entries = GLib.Marshaller.StructureToPtrAlloc (entries);
			gtk_pad_controller_set_action_entries(Handle, native_entries, n_entries);
			Marshal.FreeHGlobal (native_entries);
		}

#endregion
	}
}
