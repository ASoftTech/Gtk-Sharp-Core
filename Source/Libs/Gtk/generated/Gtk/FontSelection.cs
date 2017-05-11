// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontSelection : Gtk.Box {

		public FontSelection (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_new();

		public FontSelection () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontSelection)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_font_selection_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_font_name(IntPtr raw);

		[Obsolete]
		[GLib.Property ("font-name")]
		public string FontName {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_font_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("font-name", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_preview_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_selection_set_preview_text(IntPtr raw, IntPtr text);

		[Obsolete]
		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_preview_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_selection_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFontSelectionClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Box)).GetClassSize ();
		static Dictionary<GLib.GType, GtkFontSelectionClass> class_structs;

		static GtkFontSelectionClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkFontSelectionClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkFontSelectionClass class_struct = (GtkFontSelectionClass) Marshal.PtrToStructure (class_ptr, typeof (GtkFontSelectionClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkFontSelectionClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_face(IntPtr raw);

		[Obsolete]
		public Pango.FontFace Face { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_face(Handle);
				Pango.FontFace ret = GLib.Object.GetObject(raw_ret) as Pango.FontFace;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_face_list(IntPtr raw);

		[Obsolete]
		public Gtk.Widget FaceList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_face_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_family(IntPtr raw);

		[Obsolete]
		public Pango.FontFamily Family { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_family(Handle);
				Pango.FontFamily ret = GLib.Object.GetObject(raw_ret) as Pango.FontFamily;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_family_list(IntPtr raw);

		[Obsolete]
		public Gtk.Widget FamilyList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_family_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_preview_entry(IntPtr raw);

		[Obsolete]
		public Gtk.Widget PreviewEntry { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_preview_entry(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_font_selection_get_size(IntPtr raw);

		[Obsolete]
		public int Size { 
			get {
				int raw_ret = gtk_font_selection_get_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_size_entry(IntPtr raw);

		[Obsolete]
		public Gtk.Widget SizeEntry { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_size_entry(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_size_list(IntPtr raw);

		[Obsolete]
		public Gtk.Widget SizeList { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_size_list(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_selection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_selection_set_font_name(IntPtr raw, IntPtr fontname);

		[Obsolete]
		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_selection_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}

#endregion
	}
}
