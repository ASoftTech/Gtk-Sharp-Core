// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class HeaderBar : Gtk.Container {

		public HeaderBar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_new();

		public HeaderBar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HeaderBar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_header_bar_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_get_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_title(IntPtr raw, IntPtr title);

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_get_subtitle(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_subtitle(IntPtr raw, IntPtr subtitle);

		[GLib.Property ("subtitle")]
		public string Subtitle {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_subtitle(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_subtitle(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_get_custom_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_custom_title(IntPtr raw, IntPtr title_widget);

		[GLib.Property ("custom-title")]
		public Gtk.Widget CustomTitle {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_custom_title(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_header_bar_set_custom_title(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("spacing")]
		public int Spacing {
			get {
				GLib.Value val = GetProperty ("spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("spacing", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_header_bar_get_show_close_button(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_show_close_button(IntPtr raw, bool setting);

		[GLib.Property ("show-close-button")]
		public bool ShowCloseButton {
			get  {
				bool raw_ret = gtk_header_bar_get_show_close_button(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_header_bar_set_show_close_button(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_get_decoration_layout(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_decoration_layout(IntPtr raw, IntPtr layout);

		[GLib.Property ("decoration-layout")]
		public string DecorationLayout {
			get  {
				IntPtr raw_ret = gtk_header_bar_get_decoration_layout(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_header_bar_set_decoration_layout(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("decoration-layout-set")]
		public bool DecorationLayoutSet {
			get {
				GLib.Value val = GetProperty ("decoration-layout-set");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("decoration-layout-set", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_header_bar_get_has_subtitle(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_set_has_subtitle(IntPtr raw, bool setting);

		[GLib.Property ("has-subtitle")]
		public bool HasSubtitle {
			get  {
				bool raw_ret = gtk_header_bar_get_has_subtitle(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_header_bar_set_has_subtitle(Handle, value);
			}
		}

		public class HeaderBarChild : Gtk.Container.ContainerChild {
			protected internal HeaderBarChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("pack-type")]
			public Gtk.PackType PackType {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "pack-type");
					Gtk.PackType ret = (Gtk.PackType) (Enum) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value((Enum) value);
					parent.ChildSetProperty(child, "pack-type", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("position")]
			public int Position {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "position");
					int ret = (int) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "position", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new HeaderBarChild (this, child);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkHeaderBarClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Container)).GetClassSize ();
		static Dictionary<GLib.GType, GtkHeaderBarClass> class_structs;

		static GtkHeaderBarClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkHeaderBarClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkHeaderBarClass class_struct = (GtkHeaderBarClass) Marshal.PtrToStructure (class_ptr, typeof (GtkHeaderBarClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkHeaderBarClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_header_bar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_header_bar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_pack_end(IntPtr raw, IntPtr child);

		public void PackEnd(Gtk.Widget child) {
			gtk_header_bar_pack_end(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_header_bar_pack_start(IntPtr raw, IntPtr child);

		public void PackStart(Gtk.Widget child) {
			gtk_header_bar_pack_start(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

#endregion
	}
}
