// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MessageDialog : Gtk.Dialog {

		public MessageDialog (IntPtr raw) : base(raw) {}

		protected MessageDialog() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("message-border")]
		public int MessageBorder {
			get {
				GLib.Value val = GetProperty ("message-border");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("message-type")]
		public Gtk.MessageType MessageType {
			get {
				GLib.Value val = GetProperty ("message-type");
				Gtk.MessageType ret = (Gtk.MessageType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("message-type", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				GLib.Value val = GetProperty ("text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("use-markup")]
		public bool UseMarkup {
			get {
				GLib.Value val = GetProperty ("use-markup");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("use-markup", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("secondary-text")]
		public string SecondaryText {
			get {
				GLib.Value val = GetProperty ("secondary-text");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("secondary-text", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("secondary-use-markup")]
		public bool SecondaryUseMarkup {
			get {
				GLib.Value val = GetProperty ("secondary-use-markup");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("secondary-use-markup", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_message_dialog_get_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_message_dialog_set_image(IntPtr raw, IntPtr image);

		[Obsolete]
		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_message_dialog_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_message_dialog_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_message_dialog_get_message_area(IntPtr raw);

		[GLib.Property ("message-area")]
		public Gtk.Widget MessageArea {
			get  {
				IntPtr raw_ret = gtk_message_dialog_get_message_area(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkMessageDialogClass {
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Dialog)).GetClassSize ();
		static Dictionary<GLib.GType, GtkMessageDialogClass> class_structs;

		static GtkMessageDialogClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkMessageDialogClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkMessageDialogClass class_struct = (GtkMessageDialogClass) Marshal.PtrToStructure (class_ptr, typeof (GtkMessageDialogClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkMessageDialogClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_message_dialog_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_message_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_message_dialog_set_markup(IntPtr raw, IntPtr str);

		public string Markup { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_message_dialog_set_markup(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

#endregion
	}
}
