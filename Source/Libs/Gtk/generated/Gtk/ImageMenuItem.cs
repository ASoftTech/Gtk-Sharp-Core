// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ImageMenuItem : Gtk.MenuItem {

		public ImageMenuItem (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new();

		public ImageMenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_image_menu_item_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new_from_stock(IntPtr stock_id, IntPtr accel_group);

		public ImageMenuItem (string stock_id, Gtk.AccelGroup accel_group) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("accel_group");
				vals.Add (new GLib.Value (accel_group));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_image_menu_item_new_from_stock(native_stock_id, accel_group == null ? IntPtr.Zero : accel_group.Handle);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_image(IntPtr raw, IntPtr image);

		[Obsolete]
		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_image_menu_item_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_image_menu_item_get_use_stock(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_use_stock(IntPtr raw, bool use_stock);

		[Obsolete]
		[GLib.Property ("use-stock")]
		public bool UseStock {
			get  {
				bool raw_ret = gtk_image_menu_item_get_use_stock(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_use_stock(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_image_menu_item_get_always_show_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_always_show_image(IntPtr raw, bool always_show);

		[Obsolete]
		[GLib.Property ("always-show-image")]
		public bool AlwaysShowImage {
			get  {
				bool raw_ret = gtk_image_menu_item_get_always_show_image(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_always_show_image(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_accel_group(IntPtr raw, IntPtr accel_group);

		[Obsolete]
		[GLib.Property ("accel-group")]
		public Gtk.AccelGroup AccelGroup {
			set  {
				gtk_image_menu_item_set_accel_group(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkImageMenuItemClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.MenuItem)).GetClassSize ();
		static Dictionary<GLib.GType, GtkImageMenuItemClass> class_structs;

		static GtkImageMenuItemClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkImageMenuItemClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkImageMenuItemClass class_struct = (GtkImageMenuItemClass) Marshal.PtrToStructure (class_ptr, typeof (GtkImageMenuItemClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkImageMenuItemClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_image_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
