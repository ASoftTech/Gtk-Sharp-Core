// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Misc : Gtk.Widget {

		public Misc (IntPtr raw) : base(raw) {}

		protected Misc() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("xalign")]
		public float Xalign {
			get {
				GLib.Value val = GetProperty ("xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("yalign")]
		public float Yalign {
			get {
				GLib.Value val = GetProperty ("yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("yalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("xpad")]
		public int Xpad {
			get {
				GLib.Value val = GetProperty ("xpad");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("xpad", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("ypad")]
		public int Ypad {
			get {
				GLib.Value val = GetProperty ("ypad");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("ypad", val);
				val.Dispose ();
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkMiscClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Widget)).GetClassSize ();
		static Dictionary<GLib.GType, GtkMiscClass> class_structs;

		static GtkMiscClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkMiscClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkMiscClass class_struct = (GtkMiscClass) Marshal.PtrToStructure (class_ptr, typeof (GtkMiscClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkMiscClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_misc_get_alignment(IntPtr raw, out float xalign, out float yalign);

		[Obsolete]
		public void GetAlignment(out float xalign, out float yalign) {
			gtk_misc_get_alignment(Handle, out xalign, out yalign);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_misc_get_padding(IntPtr raw, out int xpad, out int ypad);

		[Obsolete]
		public void GetPadding(out int xpad, out int ypad) {
			gtk_misc_get_padding(Handle, out xpad, out ypad);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_misc_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_misc_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_misc_set_alignment(IntPtr raw, float xalign, float yalign);

		[Obsolete]
		public void SetAlignment(float xalign, float yalign) {
			gtk_misc_set_alignment(Handle, xalign, yalign);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_misc_set_padding(IntPtr raw, int xpad, int ypad);

		[Obsolete]
		public void SetPadding(int xpad, int ypad) {
			gtk_misc_set_padding(Handle, xpad, ypad);
		}

#endregion
	}
}
