// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.NotificationPriorityGType))]
	public enum NotificationPriority {

		Normal,
		Low,
		High,
		Urgent,
	}

	internal class NotificationPriorityGType {
		[DllImport ("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_notification_priority_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_notification_priority_get_type ());
			}
		}
	}
#endregion
}
