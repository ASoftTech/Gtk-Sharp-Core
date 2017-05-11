// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VScrollbar : Gtk.Scrollbar {

		public VScrollbar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vscrollbar_new(IntPtr adjustment);

		public VScrollbar (Gtk.Adjustment adjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VScrollbar)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (adjustment != null) {
					names.Add ("adjustment");
					vals.Add (new GLib.Value (adjustment));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_vscrollbar_new(adjustment == null ? IntPtr.Zero : adjustment.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkVScrollbarClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Scrollbar)).GetClassSize ();
		static Dictionary<GLib.GType, GtkVScrollbarClass> class_structs;

		static GtkVScrollbarClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkVScrollbarClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkVScrollbarClass class_struct = (GtkVScrollbarClass) Marshal.PtrToStructure (class_ptr, typeof (GtkVScrollbarClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkVScrollbarClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vscrollbar_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_vscrollbar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
