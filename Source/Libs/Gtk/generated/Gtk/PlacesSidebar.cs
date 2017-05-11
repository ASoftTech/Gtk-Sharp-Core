// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PlacesSidebar : Gtk.ScrolledWindow {

		public PlacesSidebar (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_places_sidebar_new();

		public PlacesSidebar () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PlacesSidebar)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_places_sidebar_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_places_sidebar_get_location(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_location(IntPtr raw, IntPtr location);

		[GLib.Property ("location")]
		public GLib.IFile Location {
			get  {
				IntPtr raw_ret = gtk_places_sidebar_get_location(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_places_sidebar_set_location(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.FileAdapter).Handle));
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_places_sidebar_get_open_flags(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_open_flags(IntPtr raw, int flags);

		[GLib.Property ("open-flags")]
		public Gtk.PlacesOpenFlags OpenFlags {
			get  {
				int raw_ret = gtk_places_sidebar_get_open_flags(Handle);
				Gtk.PlacesOpenFlags ret = (Gtk.PlacesOpenFlags) raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_open_flags(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_recent(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_recent(IntPtr raw, bool show_recent);

		[GLib.Property ("show-recent")]
		public bool ShowRecent {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_recent(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_recent(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_desktop(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_desktop(IntPtr raw, bool show_desktop);

		[GLib.Property ("show-desktop")]
		public bool ShowDesktop {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_desktop(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_desktop(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_connect_to_server(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_connect_to_server(IntPtr raw, bool show_connect_to_server);

		[Obsolete]
		[GLib.Property ("show-connect-to-server")]
		public bool ShowConnectToServer {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_connect_to_server(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_connect_to_server(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_enter_location(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_enter_location(IntPtr raw, bool show_enter_location);

		[GLib.Property ("show-enter-location")]
		public bool ShowEnterLocation {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_enter_location(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_enter_location(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_local_only(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_local_only(IntPtr raw, bool local_only);

		[GLib.Property ("local-only")]
		public bool LocalOnly {
			get  {
				bool raw_ret = gtk_places_sidebar_get_local_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_local_only(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_trash(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_trash(IntPtr raw, bool show_trash);

		[GLib.Property ("show-trash")]
		public bool ShowTrash {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_trash(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_trash(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_places_sidebar_get_show_other_locations(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_show_other_locations(IntPtr raw, bool show_other_locations);

		[GLib.Property ("show-other-locations")]
		public bool ShowOtherLocations {
			get  {
				bool raw_ret = gtk_places_sidebar_get_show_other_locations(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_places_sidebar_set_show_other_locations(Handle, value);
			}
		}

		[GLib.Property ("populate-all")]
		public bool PopulateAll {
			get {
				GLib.Value val = GetProperty ("populate-all");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("populate-all", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("populate-popup")]
		public event Gtk.PopulatePopupHandler PopulatePopup {
			add {
				this.AddSignalHandler ("populate-popup", value, typeof (Gtk.PopulatePopupArgs));
			}
			remove {
				this.RemoveSignalHandler ("populate-popup", value);
			}
		}

		[GLib.Signal("open-location")]
		public event Gtk.OpenLocationHandler OpenLocation {
			add {
				this.AddSignalHandler ("open-location", value, typeof (Gtk.OpenLocationArgs));
			}
			remove {
				this.RemoveSignalHandler ("open-location", value);
			}
		}

		[GLib.Signal("show-connect-to-server")]
		public event System.EventHandler ShowedConnectToServer {
			add {
				this.AddSignalHandler ("show-connect-to-server", value);
			}
			remove {
				this.RemoveSignalHandler ("show-connect-to-server", value);
			}
		}

		[GLib.Signal("show-enter-location")]
		public event System.EventHandler ShowEnteredLocation {
			add {
				this.AddSignalHandler ("show-enter-location", value);
			}
			remove {
				this.RemoveSignalHandler ("show-enter-location", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int DragActionRequestedSignalDelegate (IntPtr inst, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr gch);

		static int DragActionRequestedSignalCallback (IntPtr inst, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr gch)
		{
			Gtk.DragActionRequestedArgs args = new Gtk.DragActionRequestedArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[3];
				args.Args[0] = GLib.Object.GetObject(arg0) as Gdk.DragContext;
				args.Args[1] = GLib.FileAdapter.GetObject (arg1, false);
				if (arg2 == IntPtr.Zero)
					args.Args[2] = null;
				else {
					args.Args[2] = new GLib.List(arg2);
				}
				Gtk.DragActionRequestedHandler handler = (Gtk.DragActionRequestedHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				return (int) ((Gdk.DragAction) args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.DragActionRequestedHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("drag-action-requested")]
		public event Gtk.DragActionRequestedHandler DragActionRequested {
			add {
				this.AddSignalHandler ("drag-action-requested", value, new DragActionRequestedSignalDelegate(DragActionRequestedSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("drag-action-requested", value);
			}
		}

		[GLib.Signal("show-other-locations-with-flags")]
		public event Gtk.ShowOtherLocationsWithFlagsHandler ShowOtherLocationsWithFlags {
			add {
				this.AddSignalHandler ("show-other-locations-with-flags", value, typeof (Gtk.ShowOtherLocationsWithFlagsArgs));
			}
			remove {
				this.RemoveSignalHandler ("show-other-locations-with-flags", value);
			}
		}

		[GLib.Signal("unmount")]
		public event Gtk.UnmountHandler Unmount {
			add {
				this.AddSignalHandler ("unmount", value, typeof (Gtk.UnmountArgs));
			}
			remove {
				this.RemoveSignalHandler ("unmount", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DragPerformDropSignalDelegate (IntPtr inst, IntPtr arg0, IntPtr arg1, int arg2, IntPtr gch);

		static void DragPerformDropSignalCallback (IntPtr inst, IntPtr arg0, IntPtr arg1, int arg2, IntPtr gch)
		{
			Gtk.DragPerformDropArgs args = new Gtk.DragPerformDropArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[3];
				args.Args[0] = GLib.FileAdapter.GetObject (arg0, false);
				if (arg1 == IntPtr.Zero)
					args.Args[1] = null;
				else {
					args.Args[1] = new GLib.List(arg1);
				}
				args.Args[2] = (Gdk.DragAction) arg2;
				Gtk.DragPerformDropHandler handler = (Gtk.DragPerformDropHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.Signal("drag-perform-drop")]
		public event Gtk.DragPerformDropHandler DragPerformDrop {
			add {
				this.AddSignalHandler ("drag-perform-drop", value, new DragPerformDropSignalDelegate(DragPerformDropSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("drag-perform-drop", value);
			}
		}

		[GLib.Signal("drag-action-ask")]
		public event Gtk.DragActionAskHandler DragActionAsk {
			add {
				this.AddSignalHandler ("drag-action-ask", value, typeof (Gtk.DragActionAskArgs));
			}
			remove {
				this.RemoveSignalHandler ("drag-action-ask", value);
			}
		}

		[GLib.Signal("mount")]
		public event Gtk.MountHandler Mount {
			add {
				this.AddSignalHandler ("mount", value, typeof (Gtk.MountArgs));
			}
			remove {
				this.RemoveSignalHandler ("mount", value);
			}
		}

		[GLib.Signal("show-error-message")]
		public event Gtk.ShowErrorMessageHandler ShowErrorMessage {
			add {
				this.AddSignalHandler ("show-error-message", value, typeof (Gtk.ShowErrorMessageArgs));
			}
			remove {
				this.RemoveSignalHandler ("show-error-message", value);
			}
		}

		[GLib.Signal("show-other-locations")]
		public event System.EventHandler ShowedOtherLocations {
			add {
				this.AddSignalHandler ("show-other-locations", value);
			}
			remove {
				this.RemoveSignalHandler ("show-other-locations", value);
			}
		}

		static OpenLocationNativeDelegate OpenLocation_cb_delegate;
		static OpenLocationNativeDelegate OpenLocationVMCallback {
			get {
				if (OpenLocation_cb_delegate == null)
					OpenLocation_cb_delegate = new OpenLocationNativeDelegate (OpenLocation_cb);
				return OpenLocation_cb_delegate;
			}
		}

		static void OverrideOpenLocation (GLib.GType gtype)
		{
			OverrideOpenLocation (gtype, OpenLocationVMCallback);
		}

		static void OverrideOpenLocation (GLib.GType gtype, OpenLocationNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.OpenLocation = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OpenLocationNativeDelegate (IntPtr inst, IntPtr location, int open_flags);

		static void OpenLocation_cb (IntPtr inst, IntPtr location, int open_flags)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnOpenLocation (GLib.FileAdapter.GetObject (location, false), (Gtk.PlacesOpenFlags) open_flags);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideOpenLocation")]
		protected virtual void OnOpenLocation (GLib.IFile location, Gtk.PlacesOpenFlags open_flags)
		{
			InternalOpenLocation (location, open_flags);
		}

		private void InternalOpenLocation (GLib.IFile location, Gtk.PlacesOpenFlags open_flags)
		{
			OpenLocationNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).OpenLocation;
			if (unmanaged == null) return;

			unmanaged (this.Handle, location == null ? IntPtr.Zero : ((location is GLib.Object) ? (location as GLib.Object).Handle : (location as GLib.FileAdapter).Handle), (int) open_flags);
		}

		static PopulatePopupNativeDelegate PopulatePopup_cb_delegate;
		static PopulatePopupNativeDelegate PopulatePopupVMCallback {
			get {
				if (PopulatePopup_cb_delegate == null)
					PopulatePopup_cb_delegate = new PopulatePopupNativeDelegate (PopulatePopup_cb);
				return PopulatePopup_cb_delegate;
			}
		}

		static void OverridePopulatePopup (GLib.GType gtype)
		{
			OverridePopulatePopup (gtype, PopulatePopupVMCallback);
		}

		static void OverridePopulatePopup (GLib.GType gtype, PopulatePopupNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.PopulatePopup = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopulatePopupNativeDelegate (IntPtr inst, IntPtr menu, IntPtr selected_item, IntPtr selected_volume);

		static void PopulatePopup_cb (IntPtr inst, IntPtr menu, IntPtr selected_item, IntPtr selected_volume)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnPopulatePopup (GLib.Object.GetObject(menu) as Gtk.Menu, GLib.FileAdapter.GetObject (selected_item, false), GLib.VolumeAdapter.GetObject (selected_volume, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverridePopulatePopup")]
		protected virtual void OnPopulatePopup (Gtk.Menu menu, GLib.IFile selected_item, GLib.IVolume selected_volume)
		{
			InternalPopulatePopup (menu, selected_item, selected_volume);
		}

		private void InternalPopulatePopup (Gtk.Menu menu, GLib.IFile selected_item, GLib.IVolume selected_volume)
		{
			PopulatePopupNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).PopulatePopup;
			if (unmanaged == null) return;

			unmanaged (this.Handle, menu == null ? IntPtr.Zero : menu.Handle, selected_item == null ? IntPtr.Zero : ((selected_item is GLib.Object) ? (selected_item as GLib.Object).Handle : (selected_item as GLib.FileAdapter).Handle), selected_volume == null ? IntPtr.Zero : ((selected_volume is GLib.Object) ? (selected_volume as GLib.Object).Handle : (selected_volume as GLib.VolumeAdapter).Handle));
		}

		static ShowErrorMessageNativeDelegate ShowErrorMessage_cb_delegate;
		static ShowErrorMessageNativeDelegate ShowErrorMessageVMCallback {
			get {
				if (ShowErrorMessage_cb_delegate == null)
					ShowErrorMessage_cb_delegate = new ShowErrorMessageNativeDelegate (ShowErrorMessage_cb);
				return ShowErrorMessage_cb_delegate;
			}
		}

		static void OverrideShowErrorMessage (GLib.GType gtype)
		{
			OverrideShowErrorMessage (gtype, ShowErrorMessageVMCallback);
		}

		static void OverrideShowErrorMessage (GLib.GType gtype, ShowErrorMessageNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowErrorMessage = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowErrorMessageNativeDelegate (IntPtr inst, IntPtr primary, IntPtr secondary);

		static void ShowErrorMessage_cb (IntPtr inst, IntPtr primary, IntPtr secondary)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnShowErrorMessage (GLib.Marshaller.Utf8PtrToString (primary), GLib.Marshaller.Utf8PtrToString (secondary));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideShowErrorMessage")]
		protected virtual void OnShowErrorMessage (string primary, string secondary)
		{
			InternalShowErrorMessage (primary, secondary);
		}

		private void InternalShowErrorMessage (string primary, string secondary)
		{
			ShowErrorMessageNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowErrorMessage;
			if (unmanaged == null) return;

			IntPtr native_primary = GLib.Marshaller.StringToPtrGStrdup (primary);
			IntPtr native_secondary = GLib.Marshaller.StringToPtrGStrdup (secondary);
			unmanaged (this.Handle, native_primary, native_secondary);
			GLib.Marshaller.Free (native_primary);
			GLib.Marshaller.Free (native_secondary);
		}

		static ShowedConnectToServerNativeDelegate ShowedConnectToServer_cb_delegate;
		static ShowedConnectToServerNativeDelegate ShowedConnectToServerVMCallback {
			get {
				if (ShowedConnectToServer_cb_delegate == null)
					ShowedConnectToServer_cb_delegate = new ShowedConnectToServerNativeDelegate (ShowedConnectToServer_cb);
				return ShowedConnectToServer_cb_delegate;
			}
		}

		static void OverrideShowedConnectToServer (GLib.GType gtype)
		{
			OverrideShowedConnectToServer (gtype, ShowedConnectToServerVMCallback);
		}

		static void OverrideShowedConnectToServer (GLib.GType gtype, ShowedConnectToServerNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowedConnectToServer = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowedConnectToServerNativeDelegate (IntPtr inst);

		static void ShowedConnectToServer_cb (IntPtr inst)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnShowedConnectToServer ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideShowedConnectToServer")]
		protected virtual void OnShowedConnectToServer ()
		{
			InternalShowedConnectToServer ();
		}

		private void InternalShowedConnectToServer ()
		{
			ShowedConnectToServerNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowedConnectToServer;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DragActionRequestedNativeDelegate DragActionRequested_cb_delegate;
		static DragActionRequestedNativeDelegate DragActionRequestedVMCallback {
			get {
				if (DragActionRequested_cb_delegate == null)
					DragActionRequested_cb_delegate = new DragActionRequestedNativeDelegate (DragActionRequested_cb);
				return DragActionRequested_cb_delegate;
			}
		}

		static void OverrideDragActionRequested (GLib.GType gtype)
		{
			OverrideDragActionRequested (gtype, DragActionRequestedVMCallback);
		}

		static void OverrideDragActionRequested (GLib.GType gtype, DragActionRequestedNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.DragActionRequested = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int DragActionRequestedNativeDelegate (IntPtr inst, IntPtr context, IntPtr dest_file, IntPtr source_file_list);

		static int DragActionRequested_cb (IntPtr inst, IntPtr context, IntPtr dest_file, IntPtr source_file_list)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				Gdk.DragAction __result;
				__result = __obj.OnDragActionRequested (GLib.Object.GetObject(context) as Gdk.DragContext, GLib.FileAdapter.GetObject (dest_file, false), new GLib.List(source_file_list));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideDragActionRequested")]
		protected virtual Gdk.DragAction OnDragActionRequested (Gdk.DragContext context, GLib.IFile dest_file, GLib.List source_file_list)
		{
			return InternalDragActionRequested (context, dest_file, source_file_list);
		}

		private Gdk.DragAction InternalDragActionRequested (Gdk.DragContext context, GLib.IFile dest_file, GLib.List source_file_list)
		{
			DragActionRequestedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DragActionRequested;
			if (unmanaged == null) return (Gdk.DragAction) 0;

			int __result = unmanaged (this.Handle, context == null ? IntPtr.Zero : context.Handle, dest_file == null ? IntPtr.Zero : ((dest_file is GLib.Object) ? (dest_file as GLib.Object).Handle : (dest_file as GLib.FileAdapter).Handle), source_file_list == null ? IntPtr.Zero : source_file_list.Handle);
			return (Gdk.DragAction) __result;
		}

		static DragActionAskNativeDelegate DragActionAsk_cb_delegate;
		static DragActionAskNativeDelegate DragActionAskVMCallback {
			get {
				if (DragActionAsk_cb_delegate == null)
					DragActionAsk_cb_delegate = new DragActionAskNativeDelegate (DragActionAsk_cb);
				return DragActionAsk_cb_delegate;
			}
		}

		static void OverrideDragActionAsk (GLib.GType gtype)
		{
			OverrideDragActionAsk (gtype, DragActionAskVMCallback);
		}

		static void OverrideDragActionAsk (GLib.GType gtype, DragActionAskNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.DragActionAsk = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int DragActionAskNativeDelegate (IntPtr inst, int actions);

		static int DragActionAsk_cb (IntPtr inst, int actions)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				Gdk.DragAction __result;
				__result = __obj.OnDragActionAsk ((Gdk.DragAction) actions);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideDragActionAsk")]
		protected virtual Gdk.DragAction OnDragActionAsk (Gdk.DragAction actions)
		{
			return InternalDragActionAsk (actions);
		}

		private Gdk.DragAction InternalDragActionAsk (Gdk.DragAction actions)
		{
			DragActionAskNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DragActionAsk;
			if (unmanaged == null) return (Gdk.DragAction) 0;

			int __result = unmanaged (this.Handle, (int) actions);
			return (Gdk.DragAction) __result;
		}

		static DragPerformDropNativeDelegate DragPerformDrop_cb_delegate;
		static DragPerformDropNativeDelegate DragPerformDropVMCallback {
			get {
				if (DragPerformDrop_cb_delegate == null)
					DragPerformDrop_cb_delegate = new DragPerformDropNativeDelegate (DragPerformDrop_cb);
				return DragPerformDrop_cb_delegate;
			}
		}

		static void OverrideDragPerformDrop (GLib.GType gtype)
		{
			OverrideDragPerformDrop (gtype, DragPerformDropVMCallback);
		}

		static void OverrideDragPerformDrop (GLib.GType gtype, DragPerformDropNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.DragPerformDrop = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DragPerformDropNativeDelegate (IntPtr inst, IntPtr dest_file, IntPtr source_file_list, int action);

		static void DragPerformDrop_cb (IntPtr inst, IntPtr dest_file, IntPtr source_file_list, int action)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnDragPerformDrop (GLib.FileAdapter.GetObject (dest_file, false), new GLib.List(source_file_list), (Gdk.DragAction) action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideDragPerformDrop")]
		protected virtual void OnDragPerformDrop (GLib.IFile dest_file, GLib.List source_file_list, Gdk.DragAction action)
		{
			InternalDragPerformDrop (dest_file, source_file_list, action);
		}

		private void InternalDragPerformDrop (GLib.IFile dest_file, GLib.List source_file_list, Gdk.DragAction action)
		{
			DragPerformDropNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DragPerformDrop;
			if (unmanaged == null) return;

			unmanaged (this.Handle, dest_file == null ? IntPtr.Zero : ((dest_file is GLib.Object) ? (dest_file as GLib.Object).Handle : (dest_file as GLib.FileAdapter).Handle), source_file_list == null ? IntPtr.Zero : source_file_list.Handle, (int) action);
		}

		static ShowEnteredLocationNativeDelegate ShowEnteredLocation_cb_delegate;
		static ShowEnteredLocationNativeDelegate ShowEnteredLocationVMCallback {
			get {
				if (ShowEnteredLocation_cb_delegate == null)
					ShowEnteredLocation_cb_delegate = new ShowEnteredLocationNativeDelegate (ShowEnteredLocation_cb);
				return ShowEnteredLocation_cb_delegate;
			}
		}

		static void OverrideShowEnteredLocation (GLib.GType gtype)
		{
			OverrideShowEnteredLocation (gtype, ShowEnteredLocationVMCallback);
		}

		static void OverrideShowEnteredLocation (GLib.GType gtype, ShowEnteredLocationNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowEnteredLocation = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowEnteredLocationNativeDelegate (IntPtr inst);

		static void ShowEnteredLocation_cb (IntPtr inst)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnShowEnteredLocation ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideShowEnteredLocation")]
		protected virtual void OnShowEnteredLocation ()
		{
			InternalShowEnteredLocation ();
		}

		private void InternalShowEnteredLocation ()
		{
			ShowEnteredLocationNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowEnteredLocation;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ShowedOtherLocationsNativeDelegate ShowedOtherLocations_cb_delegate;
		static ShowedOtherLocationsNativeDelegate ShowedOtherLocationsVMCallback {
			get {
				if (ShowedOtherLocations_cb_delegate == null)
					ShowedOtherLocations_cb_delegate = new ShowedOtherLocationsNativeDelegate (ShowedOtherLocations_cb);
				return ShowedOtherLocations_cb_delegate;
			}
		}

		static void OverrideShowedOtherLocations (GLib.GType gtype)
		{
			OverrideShowedOtherLocations (gtype, ShowedOtherLocationsVMCallback);
		}

		static void OverrideShowedOtherLocations (GLib.GType gtype, ShowedOtherLocationsNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowedOtherLocations = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowedOtherLocationsNativeDelegate (IntPtr inst);

		static void ShowedOtherLocations_cb (IntPtr inst)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnShowedOtherLocations ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideShowedOtherLocations")]
		protected virtual void OnShowedOtherLocations ()
		{
			InternalShowedOtherLocations ();
		}

		private void InternalShowedOtherLocations ()
		{
			ShowedOtherLocationsNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowedOtherLocations;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ShowOtherLocationsWithFlagsNativeDelegate ShowOtherLocationsWithFlags_cb_delegate;
		static ShowOtherLocationsWithFlagsNativeDelegate ShowOtherLocationsWithFlagsVMCallback {
			get {
				if (ShowOtherLocationsWithFlags_cb_delegate == null)
					ShowOtherLocationsWithFlags_cb_delegate = new ShowOtherLocationsWithFlagsNativeDelegate (ShowOtherLocationsWithFlags_cb);
				return ShowOtherLocationsWithFlags_cb_delegate;
			}
		}

		static void OverrideShowOtherLocationsWithFlags (GLib.GType gtype)
		{
			OverrideShowOtherLocationsWithFlags (gtype, ShowOtherLocationsWithFlagsVMCallback);
		}

		static void OverrideShowOtherLocationsWithFlags (GLib.GType gtype, ShowOtherLocationsWithFlagsNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowOtherLocationsWithFlags = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowOtherLocationsWithFlagsNativeDelegate (IntPtr inst, int open_flags);

		static void ShowOtherLocationsWithFlags_cb (IntPtr inst, int open_flags)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnShowOtherLocationsWithFlags ((Gtk.PlacesOpenFlags) open_flags);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideShowOtherLocationsWithFlags")]
		protected virtual void OnShowOtherLocationsWithFlags (Gtk.PlacesOpenFlags open_flags)
		{
			InternalShowOtherLocationsWithFlags (open_flags);
		}

		private void InternalShowOtherLocationsWithFlags (Gtk.PlacesOpenFlags open_flags)
		{
			ShowOtherLocationsWithFlagsNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowOtherLocationsWithFlags;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) open_flags);
		}

		static MountNativeDelegate Mount_cb_delegate;
		static MountNativeDelegate MountVMCallback {
			get {
				if (Mount_cb_delegate == null)
					Mount_cb_delegate = new MountNativeDelegate (Mount_cb);
				return Mount_cb_delegate;
			}
		}

		static void OverrideMount (GLib.GType gtype)
		{
			OverrideMount (gtype, MountVMCallback);
		}

		static void OverrideMount (GLib.GType gtype, MountNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.Mount = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MountNativeDelegate (IntPtr inst, IntPtr mount_operation);

		static void Mount_cb (IntPtr inst, IntPtr mount_operation)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnMount (GLib.Object.GetObject(mount_operation) as GLib.MountOperation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideMount")]
		protected virtual void OnMount (GLib.MountOperation mount_operation)
		{
			InternalMount (mount_operation);
		}

		private void InternalMount (GLib.MountOperation mount_operation)
		{
			MountNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Mount;
			if (unmanaged == null) return;

			unmanaged (this.Handle, mount_operation == null ? IntPtr.Zero : mount_operation.Handle);
		}

		static UnmountNativeDelegate Unmount_cb_delegate;
		static UnmountNativeDelegate UnmountVMCallback {
			get {
				if (Unmount_cb_delegate == null)
					Unmount_cb_delegate = new UnmountNativeDelegate (Unmount_cb);
				return Unmount_cb_delegate;
			}
		}

		static void OverrideUnmount (GLib.GType gtype)
		{
			OverrideUnmount (gtype, UnmountVMCallback);
		}

		static void OverrideUnmount (GLib.GType gtype, UnmountNativeDelegate callback)
		{
			GtkPlacesSidebarClass class_iface = GetClassStruct (gtype, false);
			class_iface.Unmount = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UnmountNativeDelegate (IntPtr inst, IntPtr unmount_operation);

		static void Unmount_cb (IntPtr inst, IntPtr unmount_operation)
		{
			try {
				PlacesSidebar __obj = GLib.Object.GetObject (inst, false) as PlacesSidebar;
				__obj.OnUnmount (GLib.Object.GetObject(unmount_operation) as GLib.MountOperation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.PlacesSidebar), ConnectionMethod="OverrideUnmount")]
		protected virtual void OnUnmount (GLib.MountOperation unmount_operation)
		{
			InternalUnmount (unmount_operation);
		}

		private void InternalUnmount (GLib.MountOperation unmount_operation)
		{
			UnmountNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Unmount;
			if (unmanaged == null) return;

			unmanaged (this.Handle, unmount_operation == null ? IntPtr.Zero : unmount_operation.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkPlacesSidebarClass {
			public OpenLocationNativeDelegate OpenLocation;
			public PopulatePopupNativeDelegate PopulatePopup;
			public ShowErrorMessageNativeDelegate ShowErrorMessage;
			public ShowedConnectToServerNativeDelegate ShowedConnectToServer;
			public DragActionRequestedNativeDelegate DragActionRequested;
			public DragActionAskNativeDelegate DragActionAsk;
			public DragPerformDropNativeDelegate DragPerformDrop;
			public ShowEnteredLocationNativeDelegate ShowEnteredLocation;
			public ShowedOtherLocationsNativeDelegate ShowedOtherLocations;
			public ShowOtherLocationsWithFlagsNativeDelegate ShowOtherLocationsWithFlags;
			public MountNativeDelegate Mount;
			public UnmountNativeDelegate Unmount;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ScrolledWindow)).GetClassSize ();
		static Dictionary<GLib.GType, GtkPlacesSidebarClass> class_structs;

		static GtkPlacesSidebarClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkPlacesSidebarClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkPlacesSidebarClass class_struct = (GtkPlacesSidebarClass) Marshal.PtrToStructure (class_ptr, typeof (GtkPlacesSidebarClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkPlacesSidebarClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_add_shortcut(IntPtr raw, IntPtr location);

		public void AddShortcut(GLib.IFile location) {
			gtk_places_sidebar_add_shortcut(Handle, location == null ? IntPtr.Zero : ((location is GLib.Object) ? (location as GLib.Object).Handle : (location as GLib.FileAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_places_sidebar_get_nth_bookmark(IntPtr raw, int n);

		public GLib.IFile GetNthBookmark(int n) {
			IntPtr raw_ret = gtk_places_sidebar_get_nth_bookmark(Handle, n);
			GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_places_sidebar_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_places_sidebar_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_places_sidebar_list_shortcuts(IntPtr raw);

		public GLib.SList ListShortcuts() {
			IntPtr raw_ret = gtk_places_sidebar_list_shortcuts(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_remove_shortcut(IntPtr raw, IntPtr location);

		public void RemoveShortcut(GLib.IFile location) {
			gtk_places_sidebar_remove_shortcut(Handle, location == null ? IntPtr.Zero : ((location is GLib.Object) ? (location as GLib.Object).Handle : (location as GLib.FileAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_places_sidebar_set_drop_targets_visible(IntPtr raw, bool visible, IntPtr context);

		public void SetDropTargetsVisible(bool visible, Gdk.DragContext context) {
			gtk_places_sidebar_set_drop_targets_visible(Handle, visible, context == null ? IntPtr.Zero : context.Handle);
		}

#endregion
	}
}
