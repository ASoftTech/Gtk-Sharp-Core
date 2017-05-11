// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ShortcutsGroup : Gtk.Box {

		public ShortcutsGroup (IntPtr raw) : base(raw) {}

		protected ShortcutsGroup() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("title")]
		public string Title {
			get {
				GLib.Value val = GetProperty ("title");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("view")]
		public string View {
			get {
				GLib.Value val = GetProperty ("view");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("view", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("accel-size-group")]
		public Gtk.SizeGroup AccelSizeGroup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("accel-size-group", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("title-size-group")]
		public Gtk.SizeGroup TitleSizeGroup {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("title-size-group", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("height")]
		public uint Height {
			get {
				GLib.Value val = GetProperty ("height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkShortcutsGroupClass {
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Box)).GetClassSize ();
		static Dictionary<GLib.GType, GtkShortcutsGroupClass> class_structs;

		static GtkShortcutsGroupClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkShortcutsGroupClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkShortcutsGroupClass class_struct = (GtkShortcutsGroupClass) Marshal.PtrToStructure (class_ptr, typeof (GtkShortcutsGroupClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkShortcutsGroupClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_shortcuts_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_shortcuts_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
