// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.ConverterResultGType))]
	public enum ConverterResult {

		Error,
		Converted = 1,
		Finished = 2,
		Flushed = 3,
	}

	internal class ConverterResultGType {
		[DllImport ("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_converter_result_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_converter_result_get_type ());
			}
		}
	}
#endregion
}
