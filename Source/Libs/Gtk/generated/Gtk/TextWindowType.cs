// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.TextWindowTypeGType))]
	public enum TextWindowType {

		Private,
		Widget,
		Text,
		Left,
		Right,
		Top,
		Bottom,
	}

	internal class TextWindowTypeGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_window_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_text_window_type_get_type ());
			}
		}
	}
#endregion
}
