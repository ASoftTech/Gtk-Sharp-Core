// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.SubprocessFlagsGType))]
	public enum SubprocessFlags {

		None,
		StdinPipe = 1 << 0,
		StdinInherit = 1 << 1,
		StdoutPipe = 1 << 2,
		StdoutSilence = 1 << 3,
		StderrPipe = 1 << 4,
		StderrSilence = 1 << 5,
		StderrMerge = 1 << 6,
		InheritFds = 1 << 7,
	}

	internal class SubprocessFlagsGType {
		[DllImport ("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_subprocess_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_subprocess_flags_get_type ());
			}
		}
	}
#endregion
}
