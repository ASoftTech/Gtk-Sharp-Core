// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.CssProviderErrorGType))]
	public enum CssProviderError {

		Failed,
		Syntax,
		Import,
		Name,
		Deprecated,
		UnknownValue,
	}

	internal class CssProviderErrorGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_css_provider_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_css_provider_error_get_type ());
			}
		}
	}
#endregion
}