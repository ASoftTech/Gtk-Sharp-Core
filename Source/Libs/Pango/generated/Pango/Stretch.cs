// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Pango.StretchGType))]
	public enum Stretch {

		UltraCondensed,
		ExtraCondensed,
		Condensed,
		SemiCondensed,
		Normal,
		SemiExpanded,
		Expanded,
		ExtraExpanded,
		UltraExpanded,
	}

	internal class StretchGType {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_stretch_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (pango_stretch_get_type ());
			}
		}
	}
#endregion
}
