// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Atk.TextGranularityGType))]
	public enum TextGranularity {

		Char,
		Word,
		Sentence,
		Line,
		Paragraph,
	}

	internal class TextGranularityGType {
		[DllImport ("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_text_granularity_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (atk_text_granularity_get_type ());
			}
		}
	}
#endregion
}
