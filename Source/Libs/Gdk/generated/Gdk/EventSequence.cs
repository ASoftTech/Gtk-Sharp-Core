// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class EventSequence : GLib.Opaque {

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_sequence_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_event_sequence_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public EventSequence(IntPtr raw) : base(raw) {}

#endregion
	}
}