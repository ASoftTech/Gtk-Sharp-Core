// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontSelectionDialog : Gtk.Dialog {

		public FontSelectionDialog (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_new(IntPtr title);

		public FontSelectionDialog (string title) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontSelectionDialog)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("title");
				vals.Add (new GLib.Value (title));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			Raw = gtk_font_selection_dialog_new(native_title);
			GLib.Marshaller.Free (native_title);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFontSelectionDialogClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Dialog)).GetClassSize ();
		static Dictionary<GLib.GType, GtkFontSelectionDialogClass> class_structs;

		static GtkFontSelectionDialogClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkFontSelectionDialogClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkFontSelectionDialogClass class_struct = (GtkFontSelectionDialogClass) Marshal.PtrToStructure (class_ptr, typeof (GtkFontSelectionDialogClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkFontSelectionDialogClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_cancel_button(IntPtr raw);

		[Obsolete]
		public Gtk.Button CancelButton { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_cancel_button(Handle);
				Gtk.Button ret = GLib.Object.GetObject(raw_ret) as Gtk.Button;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_font_name(IntPtr raw);

		[Obsolete]
		public string FontName { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_font_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_font_selection(IntPtr raw);

		[Obsolete]
		public Gtk.Widget FontSelection { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_font_selection(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_ok_button(IntPtr raw);

		[Obsolete]
		public Gtk.Button OkButton { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_ok_button(Handle);
				Gtk.Button ret = GLib.Object.GetObject(raw_ret) as Gtk.Button;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_preview_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_selection_dialog_set_preview_text(IntPtr raw, IntPtr text);

		[Obsolete]
		public string PreviewText { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_preview_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_selection_dialog_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_dialog_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_font_selection_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_selection_dialog_set_font_name(IntPtr raw, IntPtr fontname);

		[Obsolete]
		public bool SetFontName(string fontname) {
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_selection_dialog_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}

#endregion
	}
}
