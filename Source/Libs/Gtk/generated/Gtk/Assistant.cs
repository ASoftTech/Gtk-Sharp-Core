// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Assistant : Gtk.Window {

		public Assistant (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_new();

		public Assistant () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Assistant)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_assistant_new();
		}

		[GLib.Property ("use-header-bar")]
		public int UseHeaderBar {
			get {
				GLib.Value val = GetProperty ("use-header-bar");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("header-padding")]
		public int HeaderPadding {
			get {
				GLib.Value val = GetProperty ("header-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("content-padding")]
		public int ContentPadding {
			get {
				GLib.Value val = GetProperty ("content-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		public class AssistantChild : Gtk.Container.ContainerChild {
			protected internal AssistantChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("page-type")]
			public Gtk.AssistantPageType PageType {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "page-type");
					Gtk.AssistantPageType ret = (Gtk.AssistantPageType) (Enum) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value((Enum) value);
					parent.ChildSetProperty(child, "page-type", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("title")]
			public new string Title {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "title");
					string ret = (string) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "title", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("header-image")]
			public Gdk.Pixbuf HeaderImage {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "header-image");
					Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "header-image", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("sidebar-image")]
			public Gdk.Pixbuf SidebarImage {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "sidebar-image");
					Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "sidebar-image", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("complete")]
			public bool Complete {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "complete");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "complete", val);
					val.Dispose ();
				}
			}

			[Gtk.ChildProperty ("has-padding")]
			public bool HasPadding {
				get {
					GLib.Value val = parent.ChildGetProperty (child, "has-padding");
					bool ret = (bool) val;
					val.Dispose ();
					return ret;
				}
				set {
					GLib.Value val = new GLib.Value(value);
					parent.ChildSetProperty(child, "has-padding", val);
					val.Dispose ();
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new AssistantChild (this, child);
			}
		}

		[GLib.Signal("escape")]
		public event System.EventHandler Escape {
			add {
				this.AddSignalHandler ("escape", value);
			}
			remove {
				this.RemoveSignalHandler ("escape", value);
			}
		}

		[GLib.Signal("cancel")]
		public event System.EventHandler Cancel {
			add {
				this.AddSignalHandler ("cancel", value);
			}
			remove {
				this.RemoveSignalHandler ("cancel", value);
			}
		}

		[GLib.Signal("prepare")]
		public event Gtk.PrepareHandler Prepare {
			add {
				this.AddSignalHandler ("prepare", value, typeof (Gtk.PrepareArgs));
			}
			remove {
				this.RemoveSignalHandler ("prepare", value);
			}
		}

		[GLib.Signal("close")]
		public event System.EventHandler Close {
			add {
				this.AddSignalHandler ("close", value);
			}
			remove {
				this.RemoveSignalHandler ("close", value);
			}
		}

		[GLib.Signal("apply")]
		public event System.EventHandler Apply {
			add {
				this.AddSignalHandler ("apply", value);
			}
			remove {
				this.RemoveSignalHandler ("apply", value);
			}
		}

		static EscapeNativeDelegate Escape_cb_delegate;
		static EscapeNativeDelegate EscapeVMCallback {
			get {
				if (Escape_cb_delegate == null)
					Escape_cb_delegate = new EscapeNativeDelegate (Escape_cb);
				return Escape_cb_delegate;
			}
		}

		static void OverrideEscape (GLib.GType gtype)
		{
			OverrideEscape (gtype, EscapeVMCallback);
		}

		static void OverrideEscape (GLib.GType gtype, EscapeNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "escape", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EscapeNativeDelegate (IntPtr inst);

		static void Escape_cb (IntPtr inst)
		{
			try {
				Assistant __obj = GLib.Object.GetObject (inst, false) as Assistant;
				__obj.OnEscape ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideEscape")]
		protected virtual void OnEscape ()
		{
			InternalEscape ();
		}

		private void InternalEscape ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PrepareNativeDelegate Prepare_cb_delegate;
		static PrepareNativeDelegate PrepareVMCallback {
			get {
				if (Prepare_cb_delegate == null)
					Prepare_cb_delegate = new PrepareNativeDelegate (Prepare_cb);
				return Prepare_cb_delegate;
			}
		}

		static void OverridePrepare (GLib.GType gtype)
		{
			OverridePrepare (gtype, PrepareVMCallback);
		}

		static void OverridePrepare (GLib.GType gtype, PrepareNativeDelegate callback)
		{
			GtkAssistantClass class_iface = GetClassStruct (gtype, false);
			class_iface.Prepare = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrepareNativeDelegate (IntPtr inst, IntPtr page);

		static void Prepare_cb (IntPtr inst, IntPtr page)
		{
			try {
				Assistant __obj = GLib.Object.GetObject (inst, false) as Assistant;
				__obj.OnPrepare (GLib.Object.GetObject(page) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverridePrepare")]
		protected virtual void OnPrepare (Gtk.Widget page)
		{
			InternalPrepare (page);
		}

		private void InternalPrepare (Gtk.Widget page)
		{
			PrepareNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Prepare;
			if (unmanaged == null) return;

			unmanaged (this.Handle, page == null ? IntPtr.Zero : page.Handle);
		}

		static ApplyNativeDelegate Apply_cb_delegate;
		static ApplyNativeDelegate ApplyVMCallback {
			get {
				if (Apply_cb_delegate == null)
					Apply_cb_delegate = new ApplyNativeDelegate (Apply_cb);
				return Apply_cb_delegate;
			}
		}

		static void OverrideApply (GLib.GType gtype)
		{
			OverrideApply (gtype, ApplyVMCallback);
		}

		static void OverrideApply (GLib.GType gtype, ApplyNativeDelegate callback)
		{
			GtkAssistantClass class_iface = GetClassStruct (gtype, false);
			class_iface.Apply = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ApplyNativeDelegate (IntPtr inst);

		static void Apply_cb (IntPtr inst)
		{
			try {
				Assistant __obj = GLib.Object.GetObject (inst, false) as Assistant;
				__obj.OnApply ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideApply")]
		protected virtual void OnApply ()
		{
			InternalApply ();
		}

		private void InternalApply ()
		{
			ApplyNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Apply;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static CloseNativeDelegate Close_cb_delegate;
		static CloseNativeDelegate CloseVMCallback {
			get {
				if (Close_cb_delegate == null)
					Close_cb_delegate = new CloseNativeDelegate (Close_cb);
				return Close_cb_delegate;
			}
		}

		static void OverrideClose (GLib.GType gtype)
		{
			OverrideClose (gtype, CloseVMCallback);
		}

		static void OverrideClose (GLib.GType gtype, CloseNativeDelegate callback)
		{
			GtkAssistantClass class_iface = GetClassStruct (gtype, false);
			class_iface.Close = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseNativeDelegate (IntPtr inst);

		static void Close_cb (IntPtr inst)
		{
			try {
				Assistant __obj = GLib.Object.GetObject (inst, false) as Assistant;
				__obj.OnClose ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideClose")]
		protected virtual void OnClose ()
		{
			InternalClose ();
		}

		private void InternalClose ()
		{
			CloseNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Close;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static CancelNativeDelegate Cancel_cb_delegate;
		static CancelNativeDelegate CancelVMCallback {
			get {
				if (Cancel_cb_delegate == null)
					Cancel_cb_delegate = new CancelNativeDelegate (Cancel_cb);
				return Cancel_cb_delegate;
			}
		}

		static void OverrideCancel (GLib.GType gtype)
		{
			OverrideCancel (gtype, CancelVMCallback);
		}

		static void OverrideCancel (GLib.GType gtype, CancelNativeDelegate callback)
		{
			GtkAssistantClass class_iface = GetClassStruct (gtype, false);
			class_iface.Cancel = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CancelNativeDelegate (IntPtr inst);

		static void Cancel_cb (IntPtr inst)
		{
			try {
				Assistant __obj = GLib.Object.GetObject (inst, false) as Assistant;
				__obj.OnCancel ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideCancel")]
		protected virtual void OnCancel ()
		{
			InternalCancel ();
		}

		private void InternalCancel ()
		{
			CancelNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Cancel;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkAssistantClass {
			public PrepareNativeDelegate Prepare;
			public ApplyNativeDelegate Apply;
			public CloseNativeDelegate Close;
			public CancelNativeDelegate Cancel;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
			IntPtr GtkReserved5;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Window)).GetClassSize ();
		static Dictionary<GLib.GType, GtkAssistantClass> class_structs;

		static GtkAssistantClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkAssistantClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkAssistantClass class_struct = (GtkAssistantClass) Marshal.PtrToStructure (class_ptr, typeof (GtkAssistantClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkAssistantClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_add_action_widget(IntPtr raw, IntPtr child);

		public void AddActionWidget(Gtk.Widget child) {
			gtk_assistant_add_action_widget(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_append_page(IntPtr raw, IntPtr page);

		public int AppendPage(Gtk.Widget page) {
			int raw_ret = gtk_assistant_append_page(Handle, page == null ? IntPtr.Zero : page.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_commit(IntPtr raw);

		public void Commit() {
			gtk_assistant_commit(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_current_page(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_current_page(IntPtr raw, int page_num);

		public int CurrentPage { 
			get {
				int raw_ret = gtk_assistant_get_current_page(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_assistant_set_current_page(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_n_pages(IntPtr raw);

		public int NPages { 
			get {
				int raw_ret = gtk_assistant_get_n_pages(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_nth_page(IntPtr raw, int page_num);

		public Gtk.Widget GetNthPage(int page_num) {
			IntPtr raw_ret = gtk_assistant_get_nth_page(Handle, page_num);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_assistant_get_page_complete(IntPtr raw, IntPtr page);

		public bool GetPageComplete(Gtk.Widget page) {
			bool raw_ret = gtk_assistant_get_page_complete(Handle, page == null ? IntPtr.Zero : page.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_assistant_get_page_has_padding(IntPtr raw, IntPtr page);

		public bool GetPageHasPadding(Gtk.Widget page) {
			bool raw_ret = gtk_assistant_get_page_has_padding(Handle, page == null ? IntPtr.Zero : page.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_header_image(IntPtr raw, IntPtr page);

		[Obsolete]
		public Gdk.Pixbuf GetPageHeaderImage(Gtk.Widget page) {
			IntPtr raw_ret = gtk_assistant_get_page_header_image(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_side_image(IntPtr raw, IntPtr page);

		[Obsolete]
		public Gdk.Pixbuf GetPageSideImage(Gtk.Widget page) {
			IntPtr raw_ret = gtk_assistant_get_page_side_image(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_title(IntPtr raw, IntPtr page);

		public string GetPageTitle(Gtk.Widget page) {
			IntPtr raw_ret = gtk_assistant_get_page_title(Handle, page == null ? IntPtr.Zero : page.Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_page_type(IntPtr raw, IntPtr page);

		public Gtk.AssistantPageType GetPageType(Gtk.Widget page) {
			int raw_ret = gtk_assistant_get_page_type(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gtk.AssistantPageType ret = (Gtk.AssistantPageType) raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_assistant_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_insert_page(IntPtr raw, IntPtr page, int position);

		public int InsertPage(Gtk.Widget page, int position) {
			int raw_ret = gtk_assistant_insert_page(Handle, page == null ? IntPtr.Zero : page.Handle, position);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_next_page(IntPtr raw);

		public void NextPage() {
			gtk_assistant_next_page(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_prepend_page(IntPtr raw, IntPtr page);

		public int PrependPage(Gtk.Widget page) {
			int raw_ret = gtk_assistant_prepend_page(Handle, page == null ? IntPtr.Zero : page.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_previous_page(IntPtr raw);

		public void PreviousPage() {
			gtk_assistant_previous_page(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_remove_action_widget(IntPtr raw, IntPtr child);

		public void RemoveActionWidget(Gtk.Widget child) {
			gtk_assistant_remove_action_widget(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_remove_page(IntPtr raw, int page_num);

		public void RemovePage(int page_num) {
			gtk_assistant_remove_page(Handle, page_num);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_forward_page_func(IntPtr raw, GtkSharp.AssistantPageFuncNative page_func, IntPtr data, GLib.DestroyNotify destroy);

		public Gtk.AssistantPageFunc ForwardPageFunc { 
			set {
				GtkSharp.AssistantPageFuncWrapper value_wrapper = new GtkSharp.AssistantPageFuncWrapper (value);
				IntPtr data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					data = IntPtr.Zero;
					destroy = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_assistant_set_forward_page_func(Handle, value_wrapper.NativeDelegate, data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_complete(IntPtr raw, IntPtr page, bool complete);

		public void SetPageComplete(Gtk.Widget page, bool complete) {
			gtk_assistant_set_page_complete(Handle, page == null ? IntPtr.Zero : page.Handle, complete);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_has_padding(IntPtr raw, IntPtr page, bool has_padding);

		public void SetPageHasPadding(Gtk.Widget page, bool has_padding) {
			gtk_assistant_set_page_has_padding(Handle, page == null ? IntPtr.Zero : page.Handle, has_padding);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_header_image(IntPtr raw, IntPtr page, IntPtr pixbuf);

		[Obsolete]
		public void SetPageHeaderImage(Gtk.Widget page, Gdk.Pixbuf pixbuf) {
			gtk_assistant_set_page_header_image(Handle, page == null ? IntPtr.Zero : page.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_side_image(IntPtr raw, IntPtr page, IntPtr pixbuf);

		[Obsolete]
		public void SetPageSideImage(Gtk.Widget page, Gdk.Pixbuf pixbuf) {
			gtk_assistant_set_page_side_image(Handle, page == null ? IntPtr.Zero : page.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_title(IntPtr raw, IntPtr page, IntPtr title);

		public void SetPageTitle(Gtk.Widget page, string title) {
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			gtk_assistant_set_page_title(Handle, page == null ? IntPtr.Zero : page.Handle, native_title);
			GLib.Marshaller.Free (native_title);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_type(IntPtr raw, IntPtr page, int type);

		public void SetPageType(Gtk.Widget page, Gtk.AssistantPageType type) {
			gtk_assistant_set_page_type(Handle, page == null ? IntPtr.Zero : page.Handle, (int) type);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_update_buttons_state(IntPtr raw);

		public void UpdateButtonsState() {
			gtk_assistant_update_buttons_state(Handle);
		}

#endregion
	}
}
