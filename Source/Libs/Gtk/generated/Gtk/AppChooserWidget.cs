// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AppChooserWidget : Gtk.Box, Gtk.IAppChooser {

		public AppChooserWidget (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_widget_new(IntPtr content_type);

		public AppChooserWidget (string content_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AppChooserWidget)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_content_type = GLib.Marshaller.StringToPtrGStrdup (content_type);
			Raw = gtk_app_chooser_widget_new(native_content_type);
			GLib.Marshaller.Free (native_content_type);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_app_chooser_widget_get_show_default(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_show_default(IntPtr raw, bool setting);

		[GLib.Property ("show-default")]
		public bool ShowDefault {
			get  {
				bool raw_ret = gtk_app_chooser_widget_get_show_default(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_widget_set_show_default(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_app_chooser_widget_get_show_recommended(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_show_recommended(IntPtr raw, bool setting);

		[GLib.Property ("show-recommended")]
		public bool ShowRecommended {
			get  {
				bool raw_ret = gtk_app_chooser_widget_get_show_recommended(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_widget_set_show_recommended(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_app_chooser_widget_get_show_fallback(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_show_fallback(IntPtr raw, bool setting);

		[GLib.Property ("show-fallback")]
		public bool ShowFallback {
			get  {
				bool raw_ret = gtk_app_chooser_widget_get_show_fallback(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_widget_set_show_fallback(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_app_chooser_widget_get_show_other(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_show_other(IntPtr raw, bool setting);

		[GLib.Property ("show-other")]
		public bool ShowOther {
			get  {
				bool raw_ret = gtk_app_chooser_widget_get_show_other(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_widget_set_show_other(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_app_chooser_widget_get_show_all(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_show_all(IntPtr raw, bool setting);

		[GLib.Property ("show-all")]
		public bool ShowAll {
			get  {
				bool raw_ret = gtk_app_chooser_widget_get_show_all(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_app_chooser_widget_set_show_all(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_widget_get_default_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_widget_set_default_text(IntPtr raw, IntPtr text);

		[GLib.Property ("default-text")]
		public string DefaultText {
			get  {
				IntPtr raw_ret = gtk_app_chooser_widget_get_default_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_app_chooser_widget_set_default_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Signal("application-activated")]
		public event Gtk.ApplicationActivatedHandler ApplicationActivated {
			add {
				this.AddSignalHandler ("application-activated", value, typeof (Gtk.ApplicationActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("application-activated", value);
			}
		}

		[GLib.Signal("application-selected")]
		public event Gtk.ApplicationSelectedHandler ApplicationSelected {
			add {
				this.AddSignalHandler ("application-selected", value, typeof (Gtk.ApplicationSelectedArgs));
			}
			remove {
				this.RemoveSignalHandler ("application-selected", value);
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

		static ApplicationSelectedNativeDelegate ApplicationSelected_cb_delegate;
		static ApplicationSelectedNativeDelegate ApplicationSelectedVMCallback {
			get {
				if (ApplicationSelected_cb_delegate == null)
					ApplicationSelected_cb_delegate = new ApplicationSelectedNativeDelegate (ApplicationSelected_cb);
				return ApplicationSelected_cb_delegate;
			}
		}

		static void OverrideApplicationSelected (GLib.GType gtype)
		{
			OverrideApplicationSelected (gtype, ApplicationSelectedVMCallback);
		}

		static void OverrideApplicationSelected (GLib.GType gtype, ApplicationSelectedNativeDelegate callback)
		{
			GtkAppChooserWidgetClass class_iface = GetClassStruct (gtype, false);
			class_iface.ApplicationSelected = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ApplicationSelectedNativeDelegate (IntPtr inst, IntPtr app_info);

		static void ApplicationSelected_cb (IntPtr inst, IntPtr app_info)
		{
			try {
				AppChooserWidget __obj = GLib.Object.GetObject (inst, false) as AppChooserWidget;
				__obj.OnApplicationSelected (GLib.AppInfoAdapter.GetObject (app_info, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AppChooserWidget), ConnectionMethod="OverrideApplicationSelected")]
		protected virtual void OnApplicationSelected (GLib.IAppInfo app_info)
		{
			InternalApplicationSelected (app_info);
		}

		private void InternalApplicationSelected (GLib.IAppInfo app_info)
		{
			ApplicationSelectedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ApplicationSelected;
			if (unmanaged == null) return;

			unmanaged (this.Handle, app_info == null ? IntPtr.Zero : ((app_info is GLib.Object) ? (app_info as GLib.Object).Handle : (app_info as GLib.AppInfoAdapter).Handle));
		}

		static ApplicationActivatedNativeDelegate ApplicationActivated_cb_delegate;
		static ApplicationActivatedNativeDelegate ApplicationActivatedVMCallback {
			get {
				if (ApplicationActivated_cb_delegate == null)
					ApplicationActivated_cb_delegate = new ApplicationActivatedNativeDelegate (ApplicationActivated_cb);
				return ApplicationActivated_cb_delegate;
			}
		}

		static void OverrideApplicationActivated (GLib.GType gtype)
		{
			OverrideApplicationActivated (gtype, ApplicationActivatedVMCallback);
		}

		static void OverrideApplicationActivated (GLib.GType gtype, ApplicationActivatedNativeDelegate callback)
		{
			GtkAppChooserWidgetClass class_iface = GetClassStruct (gtype, false);
			class_iface.ApplicationActivated = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ApplicationActivatedNativeDelegate (IntPtr inst, IntPtr app_info);

		static void ApplicationActivated_cb (IntPtr inst, IntPtr app_info)
		{
			try {
				AppChooserWidget __obj = GLib.Object.GetObject (inst, false) as AppChooserWidget;
				__obj.OnApplicationActivated (GLib.AppInfoAdapter.GetObject (app_info, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AppChooserWidget), ConnectionMethod="OverrideApplicationActivated")]
		protected virtual void OnApplicationActivated (GLib.IAppInfo app_info)
		{
			InternalApplicationActivated (app_info);
		}

		private void InternalApplicationActivated (GLib.IAppInfo app_info)
		{
			ApplicationActivatedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ApplicationActivated;
			if (unmanaged == null) return;

			unmanaged (this.Handle, app_info == null ? IntPtr.Zero : ((app_info is GLib.Object) ? (app_info as GLib.Object).Handle : (app_info as GLib.AppInfoAdapter).Handle));
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
			GtkAppChooserWidgetClass class_iface = GetClassStruct (gtype, false);
			class_iface.PopulatePopup = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopulatePopupNativeDelegate (IntPtr inst, IntPtr menu, IntPtr app_info);

		static void PopulatePopup_cb (IntPtr inst, IntPtr menu, IntPtr app_info)
		{
			try {
				AppChooserWidget __obj = GLib.Object.GetObject (inst, false) as AppChooserWidget;
				__obj.OnPopulatePopup (GLib.Object.GetObject(menu) as Gtk.Menu, GLib.AppInfoAdapter.GetObject (app_info, false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AppChooserWidget), ConnectionMethod="OverridePopulatePopup")]
		protected virtual void OnPopulatePopup (Gtk.Menu menu, GLib.IAppInfo app_info)
		{
			InternalPopulatePopup (menu, app_info);
		}

		private void InternalPopulatePopup (Gtk.Menu menu, GLib.IAppInfo app_info)
		{
			PopulatePopupNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).PopulatePopup;
			if (unmanaged == null) return;

			unmanaged (this.Handle, menu == null ? IntPtr.Zero : menu.Handle, app_info == null ? IntPtr.Zero : ((app_info is GLib.Object) ? (app_info as GLib.Object).Handle : (app_info as GLib.AppInfoAdapter).Handle));
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkAppChooserWidgetClass {
			public ApplicationSelectedNativeDelegate ApplicationSelected;
			public ApplicationActivatedNativeDelegate ApplicationActivated;
			public PopulatePopupNativeDelegate PopulatePopup;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=16)]
			private IntPtr[] Padding;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Box)).GetClassSize ();
		static Dictionary<GLib.GType, GtkAppChooserWidgetClass> class_structs;

		static GtkAppChooserWidgetClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkAppChooserWidgetClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkAppChooserWidgetClass class_struct = (GtkAppChooserWidgetClass) Marshal.PtrToStructure (class_ptr, typeof (GtkAppChooserWidgetClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkAppChooserWidgetClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_widget_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_widget_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_get_app_info(IntPtr raw);

		public GLib.IAppInfo AppInfo { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_app_info(Handle);
				GLib.IAppInfo ret = GLib.AppInfoAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_app_chooser_get_content_type(IntPtr raw);

		public string ContentType { 
			get {
				IntPtr raw_ret = gtk_app_chooser_get_content_type(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_app_chooser_refresh(IntPtr raw);

		public void Refresh() {
			gtk_app_chooser_refresh(Handle);
		}

#endregion
	}
}
