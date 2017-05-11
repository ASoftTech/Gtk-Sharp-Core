// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuBar : Gtk.MenuShell {

		public MenuBar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_bar_new();

		public MenuBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_menu_bar_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_bar_new_from_model(IntPtr model);

		public MenuBar (GLib.MenuModel model) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuBar)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_menu_bar_new_from_model(model == null ? IntPtr.Zero : model.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_menu_bar_get_pack_direction(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_bar_set_pack_direction(IntPtr raw, int pack_dir);

		[GLib.Property ("pack-direction")]
		public Gtk.PackDirection PackDirection {
			get  {
				int raw_ret = gtk_menu_bar_get_pack_direction(Handle);
				Gtk.PackDirection ret = (Gtk.PackDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_menu_bar_set_pack_direction(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_menu_bar_get_child_pack_direction(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_bar_set_child_pack_direction(IntPtr raw, int child_pack_dir);

		[GLib.Property ("child-pack-direction")]
		public Gtk.PackDirection ChildPackDirection {
			get  {
				int raw_ret = gtk_menu_bar_get_child_pack_direction(Handle);
				Gtk.PackDirection ret = (Gtk.PackDirection) raw_ret;
				return ret;
			}
			set  {
				gtk_menu_bar_set_child_pack_direction(Handle, (int) value);
			}
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				GLib.Value val = GetProperty ("shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("internal-padding")]
		public int InternalPadding {
			get {
				GLib.Value val = GetProperty ("internal-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkMenuBarClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.MenuShell)).GetClassSize ();
		static Dictionary<GLib.GType, GtkMenuBarClass> class_structs;

		static GtkMenuBarClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkMenuBarClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkMenuBarClass class_struct = (GtkMenuBarClass) Marshal.PtrToStructure (class_ptr, typeof (GtkMenuBarClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkMenuBarClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_bar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}