// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ToolItem : Gtk.Bin, Gtk.IActivatable {

		public ToolItem (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_new();

		public ToolItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToolItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_tool_item_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_visible_horizontal(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_visible_horizontal(IntPtr raw, bool visible_horizontal);

		[GLib.Property ("visible-horizontal")]
		public bool VisibleHorizontal {
			get  {
				bool raw_ret = gtk_tool_item_get_visible_horizontal(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_set_visible_horizontal(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_visible_vertical(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_visible_vertical(IntPtr raw, bool visible_vertical);

		[GLib.Property ("visible-vertical")]
		public bool VisibleVertical {
			get  {
				bool raw_ret = gtk_tool_item_get_visible_vertical(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_set_visible_vertical(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_is_important(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_is_important(IntPtr raw, bool is_important);

		[GLib.Property ("is-important")]
		public bool IsImportant {
			get  {
				bool raw_ret = gtk_tool_item_get_is_important(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tool_item_set_is_important(Handle, value);
			}
		}

		[GLib.Signal("toolbar-reconfigured")]
		public event System.EventHandler ToolbarReconfigured {
			add {
				this.AddSignalHandler ("toolbar-reconfigured", value);
			}
			remove {
				this.RemoveSignalHandler ("toolbar-reconfigured", value);
			}
		}

		[GLib.Signal("create-menu-proxy")]
		public event Gtk.CreateMenuProxyHandler CreateMenuProxy {
			add {
				this.AddSignalHandler ("create-menu-proxy", value, typeof (Gtk.CreateMenuProxyArgs));
			}
			remove {
				this.RemoveSignalHandler ("create-menu-proxy", value);
			}
		}

		static CreateMenuProxyNativeDelegate CreateMenuProxy_cb_delegate;
		static CreateMenuProxyNativeDelegate CreateMenuProxyVMCallback {
			get {
				if (CreateMenuProxy_cb_delegate == null)
					CreateMenuProxy_cb_delegate = new CreateMenuProxyNativeDelegate (CreateMenuProxy_cb);
				return CreateMenuProxy_cb_delegate;
			}
		}

		static void OverrideCreateMenuProxy (GLib.GType gtype)
		{
			OverrideCreateMenuProxy (gtype, CreateMenuProxyVMCallback);
		}

		static void OverrideCreateMenuProxy (GLib.GType gtype, CreateMenuProxyNativeDelegate callback)
		{
			GtkToolItemClass class_iface = GetClassStruct (gtype, false);
			class_iface.CreateMenuProxy = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CreateMenuProxyNativeDelegate (IntPtr inst);

		static bool CreateMenuProxy_cb (IntPtr inst)
		{
			try {
				ToolItem __obj = GLib.Object.GetObject (inst, false) as ToolItem;
				bool __result;
				__result = __obj.OnCreateMenuProxy ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ToolItem), ConnectionMethod="OverrideCreateMenuProxy")]
		protected virtual bool OnCreateMenuProxy ()
		{
			return InternalCreateMenuProxy ();
		}

		private bool InternalCreateMenuProxy ()
		{
			CreateMenuProxyNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CreateMenuProxy;
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static ToolbarReconfiguredNativeDelegate ToolbarReconfigured_cb_delegate;
		static ToolbarReconfiguredNativeDelegate ToolbarReconfiguredVMCallback {
			get {
				if (ToolbarReconfigured_cb_delegate == null)
					ToolbarReconfigured_cb_delegate = new ToolbarReconfiguredNativeDelegate (ToolbarReconfigured_cb);
				return ToolbarReconfigured_cb_delegate;
			}
		}

		static void OverrideToolbarReconfigured (GLib.GType gtype)
		{
			OverrideToolbarReconfigured (gtype, ToolbarReconfiguredVMCallback);
		}

		static void OverrideToolbarReconfigured (GLib.GType gtype, ToolbarReconfiguredNativeDelegate callback)
		{
			GtkToolItemClass class_iface = GetClassStruct (gtype, false);
			class_iface.ToolbarReconfigured = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToolbarReconfiguredNativeDelegate (IntPtr inst);

		static void ToolbarReconfigured_cb (IntPtr inst)
		{
			try {
				ToolItem __obj = GLib.Object.GetObject (inst, false) as ToolItem;
				__obj.OnToolbarReconfigured ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ToolItem), ConnectionMethod="OverrideToolbarReconfigured")]
		protected virtual void OnToolbarReconfigured ()
		{
			InternalToolbarReconfigured ();
		}

		private void InternalToolbarReconfigured ()
		{
			ToolbarReconfiguredNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ToolbarReconfigured;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkToolItemClass {
			public CreateMenuProxyNativeDelegate CreateMenuProxy;
			public ToolbarReconfiguredNativeDelegate ToolbarReconfigured;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkToolItemClass> class_structs;

		static GtkToolItemClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkToolItemClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkToolItemClass class_struct = (GtkToolItemClass) Marshal.PtrToStructure (class_ptr, typeof (GtkToolItemClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkToolItemClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_ellipsize_mode(IntPtr raw);

		public Pango.EllipsizeMode EllipsizeMode { 
			get {
				int raw_ret = gtk_tool_item_get_ellipsize_mode(Handle);
				Pango.EllipsizeMode ret = (Pango.EllipsizeMode) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_expand(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_expand(IntPtr raw, bool expand);

		public new bool Expand { 
			get {
				bool raw_ret = gtk_tool_item_get_expand(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_tool_item_set_expand(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_homogeneous(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_homogeneous(IntPtr raw, bool homogeneous);

		public bool Homogeneous { 
			get {
				bool raw_ret = gtk_tool_item_get_homogeneous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_tool_item_set_homogeneous(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_icon_size(IntPtr raw);

		public Gtk.IconSize IconSize { 
			get {
				int raw_ret = gtk_tool_item_get_icon_size(Handle);
				Gtk.IconSize ret = (Gtk.IconSize) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_orientation(IntPtr raw);

		public Gtk.Orientation Orientation { 
			get {
				int raw_ret = gtk_tool_item_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_get_proxy_menu_item(IntPtr raw, IntPtr menu_item_id);

		public Gtk.Widget GetProxyMenuItem(string menu_item_id) {
			IntPtr native_menu_item_id = GLib.Marshaller.StringToPtrGStrdup (menu_item_id);
			IntPtr raw_ret = gtk_tool_item_get_proxy_menu_item(Handle, native_menu_item_id);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			GLib.Marshaller.Free (native_menu_item_id);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_relief_style(IntPtr raw);

		public Gtk.ReliefStyle ReliefStyle { 
			get {
				int raw_ret = gtk_tool_item_get_relief_style(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern float gtk_tool_item_get_text_alignment(IntPtr raw);

		public float TextAlignment { 
			get {
				float raw_ret = gtk_tool_item_get_text_alignment(Handle);
				float ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_text_orientation(IntPtr raw);

		public Gtk.Orientation TextOrientation { 
			get {
				int raw_ret = gtk_tool_item_get_text_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_get_text_size_group(IntPtr raw);

		public Gtk.SizeGroup TextSizeGroup { 
			get {
				IntPtr raw_ret = gtk_tool_item_get_text_size_group(Handle);
				Gtk.SizeGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.SizeGroup;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tool_item_get_toolbar_style(IntPtr raw);

		public Gtk.ToolbarStyle ToolbarStyle { 
			get {
				int raw_ret = gtk_tool_item_get_toolbar_style(Handle);
				Gtk.ToolbarStyle ret = (Gtk.ToolbarStyle) raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tool_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_item_get_use_drag_window(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_use_drag_window(IntPtr raw, bool use_drag_window);

		public bool UseDragWindow { 
			get {
				bool raw_ret = gtk_tool_item_get_use_drag_window(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_tool_item_set_use_drag_window(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_rebuild_menu(IntPtr raw);

		public void RebuildMenu() {
			gtk_tool_item_rebuild_menu(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_item_retrieve_proxy_menu_item(IntPtr raw);

		public Gtk.Widget RetrieveProxyMenuItem() {
			IntPtr raw_ret = gtk_tool_item_retrieve_proxy_menu_item(Handle);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_set_proxy_menu_item(IntPtr raw, IntPtr menu_item_id, IntPtr menu_item);

		public void SetProxyMenuItem(string menu_item_id, Gtk.Widget menu_item) {
			IntPtr native_menu_item_id = GLib.Marshaller.StringToPtrGStrdup (menu_item_id);
			gtk_tool_item_set_proxy_menu_item(Handle, native_menu_item_id, menu_item == null ? IntPtr.Zero : menu_item.Handle);
			GLib.Marshaller.Free (native_menu_item_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_item_toolbar_reconfigured(IntPtr raw);

		public void EmitToolbarReconfigured() {
			gtk_tool_item_toolbar_reconfigured(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);

		[Obsolete]
		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);

		[Obsolete]
		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_activatable_get_related_action(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_related_action(IntPtr raw, IntPtr action);

		[Obsolete]
		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_activatable_get_use_action_appearance(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);

		[Obsolete]
		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

#endregion
	}
}
