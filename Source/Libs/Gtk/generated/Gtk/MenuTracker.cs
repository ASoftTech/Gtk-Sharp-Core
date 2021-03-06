// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuTracker : GLib.Opaque {

		public MenuTracker(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tracker_new(IntPtr observer, IntPtr model, bool with_separators, bool merge_sections, bool mac_os_mode, IntPtr action_namespace, GtkSharp.MenuTrackerInsertFuncNative insert_func, GtkSharp.MenuTrackerRemoveFuncNative remove_func, IntPtr user_data);

		public MenuTracker (Gtk.IActionObservable observer, GLib.MenuModel model, bool with_separators, bool merge_sections, bool mac_os_mode, string action_namespace, Gtk.MenuTrackerInsertFunc insert_func, Gtk.MenuTrackerRemoveFunc remove_func) 
		{
			IntPtr native_action_namespace = GLib.Marshaller.StringToPtrGStrdup (action_namespace);
			GtkSharp.MenuTrackerInsertFuncWrapper insert_func_wrapper = new GtkSharp.MenuTrackerInsertFuncWrapper (insert_func);
			GtkSharp.MenuTrackerRemoveFuncWrapper remove_func_wrapper = new GtkSharp.MenuTrackerRemoveFuncWrapper (remove_func);
			Raw = gtk_menu_tracker_new(observer == null ? IntPtr.Zero : ((observer is GLib.Object) ? (observer as GLib.Object).Handle : (observer as Gtk.ActionObservableAdapter).Handle), model == null ? IntPtr.Zero : model.Handle, with_separators, merge_sections, mac_os_mode, native_action_namespace, insert_func_wrapper.NativeDelegate, remove_func_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_action_namespace);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_tracker_new_for_item_link(IntPtr item, IntPtr link_name, bool merge_sections, bool mac_os_mode, GtkSharp.MenuTrackerInsertFuncNative insert_func, GtkSharp.MenuTrackerRemoveFuncNative remove_func, IntPtr user_data);

		public MenuTracker (Gtk.MenuTrackerItem item, string link_name, bool merge_sections, bool mac_os_mode, Gtk.MenuTrackerInsertFunc insert_func, Gtk.MenuTrackerRemoveFunc remove_func) 
		{
			IntPtr native_link_name = GLib.Marshaller.StringToPtrGStrdup (link_name);
			GtkSharp.MenuTrackerInsertFuncWrapper insert_func_wrapper = new GtkSharp.MenuTrackerInsertFuncWrapper (insert_func);
			GtkSharp.MenuTrackerRemoveFuncWrapper remove_func_wrapper = new GtkSharp.MenuTrackerRemoveFuncWrapper (remove_func);
			Raw = gtk_menu_tracker_new_for_item_link(item == null ? IntPtr.Zero : item.Handle, native_link_name, merge_sections, mac_os_mode, insert_func_wrapper.NativeDelegate, remove_func_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_link_name);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_tracker_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gtk_menu_tracker_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_menu_tracker_free (handle);
				return false;
			}
		}

		~MenuTracker ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
