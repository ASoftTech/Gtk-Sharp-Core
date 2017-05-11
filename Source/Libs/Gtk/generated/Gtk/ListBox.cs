// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ListBox : Gtk.Container {

		public ListBox (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_new();

		public ListBox () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ListBox)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_list_box_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_list_box_get_selection_mode(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_selection_mode(IntPtr raw, int mode);

		[GLib.Property ("selection-mode")]
		public Gtk.SelectionMode SelectionMode {
			get  {
				int raw_ret = gtk_list_box_get_selection_mode(Handle);
				Gtk.SelectionMode ret = (Gtk.SelectionMode) raw_ret;
				return ret;
			}
			set  {
				gtk_list_box_set_selection_mode(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_list_box_get_activate_on_single_click(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_activate_on_single_click(IntPtr raw, bool single);

		[GLib.Property ("activate-on-single-click")]
		public bool ActivateOnSingleClick {
			get  {
				bool raw_ret = gtk_list_box_get_activate_on_single_click(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_list_box_set_activate_on_single_click(Handle, value);
			}
		}

		[GLib.Signal("move-cursor")]
		public event Gtk.MoveCursorHandler MoveCursor {
			add {
				this.AddSignalHandler ("move-cursor", value, typeof (Gtk.MoveCursorArgs));
			}
			remove {
				this.RemoveSignalHandler ("move-cursor", value);
			}
		}

		[GLib.Signal("unselect-all")]
		public event System.EventHandler UnselectedAll {
			add {
				this.AddSignalHandler ("unselect-all", value);
			}
			remove {
				this.RemoveSignalHandler ("unselect-all", value);
			}
		}

		[GLib.Signal("toggle-cursor-row")]
		public event System.EventHandler ToggleCursorRow {
			add {
				this.AddSignalHandler ("toggle-cursor-row", value);
			}
			remove {
				this.RemoveSignalHandler ("toggle-cursor-row", value);
			}
		}

		[GLib.Signal("row-selected")]
		public event Gtk.RowSelectedHandler RowSelected {
			add {
				this.AddSignalHandler ("row-selected", value, typeof (Gtk.RowSelectedArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-selected", value);
			}
		}

		[GLib.Signal("row-activated")]
		public event Gtk.ListRowActivatedHandler ListRowActivated {
			add {
				this.AddSignalHandler ("row-activated", value, typeof (Gtk.ListRowActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-activated", value);
			}
		}

		[GLib.Signal("select-all")]
		public event System.EventHandler SelectedAll {
			add {
				this.AddSignalHandler ("select-all", value);
			}
			remove {
				this.RemoveSignalHandler ("select-all", value);
			}
		}

		[GLib.Signal("selected-rows-changed")]
		public event System.EventHandler SelectedRowsChanged {
			add {
				this.AddSignalHandler ("selected-rows-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("selected-rows-changed", value);
			}
		}

		[GLib.Signal("activate-cursor-row")]
		public event System.EventHandler ActivateCursorRow {
			add {
				this.AddSignalHandler ("activate-cursor-row", value);
			}
			remove {
				this.RemoveSignalHandler ("activate-cursor-row", value);
			}
		}

		static RowSelectedNativeDelegate RowSelected_cb_delegate;
		static RowSelectedNativeDelegate RowSelectedVMCallback {
			get {
				if (RowSelected_cb_delegate == null)
					RowSelected_cb_delegate = new RowSelectedNativeDelegate (RowSelected_cb);
				return RowSelected_cb_delegate;
			}
		}

		static void OverrideRowSelected (GLib.GType gtype)
		{
			OverrideRowSelected (gtype, RowSelectedVMCallback);
		}

		static void OverrideRowSelected (GLib.GType gtype, RowSelectedNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.RowSelected = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RowSelectedNativeDelegate (IntPtr inst, IntPtr row);

		static void RowSelected_cb (IntPtr inst, IntPtr row)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnRowSelected (GLib.Object.GetObject(row) as Gtk.ListBoxRow);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideRowSelected")]
		protected virtual void OnRowSelected (Gtk.ListBoxRow row)
		{
			InternalRowSelected (row);
		}

		private void InternalRowSelected (Gtk.ListBoxRow row)
		{
			RowSelectedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).RowSelected;
			if (unmanaged == null) return;

			unmanaged (this.Handle, row == null ? IntPtr.Zero : row.Handle);
		}

		static ListRowActivatedNativeDelegate ListRowActivated_cb_delegate;
		static ListRowActivatedNativeDelegate ListRowActivatedVMCallback {
			get {
				if (ListRowActivated_cb_delegate == null)
					ListRowActivated_cb_delegate = new ListRowActivatedNativeDelegate (ListRowActivated_cb);
				return ListRowActivated_cb_delegate;
			}
		}

		static void OverrideListRowActivated (GLib.GType gtype)
		{
			OverrideListRowActivated (gtype, ListRowActivatedVMCallback);
		}

		static void OverrideListRowActivated (GLib.GType gtype, ListRowActivatedNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.ListRowActivated = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ListRowActivatedNativeDelegate (IntPtr inst, IntPtr row);

		static void ListRowActivated_cb (IntPtr inst, IntPtr row)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnListRowActivated (GLib.Object.GetObject(row) as Gtk.ListBoxRow);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideListRowActivated")]
		protected virtual void OnListRowActivated (Gtk.ListBoxRow row)
		{
			InternalListRowActivated (row);
		}

		private void InternalListRowActivated (Gtk.ListBoxRow row)
		{
			ListRowActivatedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ListRowActivated;
			if (unmanaged == null) return;

			unmanaged (this.Handle, row == null ? IntPtr.Zero : row.Handle);
		}

		static ActivateCursorRowNativeDelegate ActivateCursorRow_cb_delegate;
		static ActivateCursorRowNativeDelegate ActivateCursorRowVMCallback {
			get {
				if (ActivateCursorRow_cb_delegate == null)
					ActivateCursorRow_cb_delegate = new ActivateCursorRowNativeDelegate (ActivateCursorRow_cb);
				return ActivateCursorRow_cb_delegate;
			}
		}

		static void OverrideActivateCursorRow (GLib.GType gtype)
		{
			OverrideActivateCursorRow (gtype, ActivateCursorRowVMCallback);
		}

		static void OverrideActivateCursorRow (GLib.GType gtype, ActivateCursorRowNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.ActivateCursorRow = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateCursorRowNativeDelegate (IntPtr inst);

		static void ActivateCursorRow_cb (IntPtr inst)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnActivateCursorRow ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideActivateCursorRow")]
		protected virtual void OnActivateCursorRow ()
		{
			InternalActivateCursorRow ();
		}

		private void InternalActivateCursorRow ()
		{
			ActivateCursorRowNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ActivateCursorRow;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ToggleCursorRowNativeDelegate ToggleCursorRow_cb_delegate;
		static ToggleCursorRowNativeDelegate ToggleCursorRowVMCallback {
			get {
				if (ToggleCursorRow_cb_delegate == null)
					ToggleCursorRow_cb_delegate = new ToggleCursorRowNativeDelegate (ToggleCursorRow_cb);
				return ToggleCursorRow_cb_delegate;
			}
		}

		static void OverrideToggleCursorRow (GLib.GType gtype)
		{
			OverrideToggleCursorRow (gtype, ToggleCursorRowVMCallback);
		}

		static void OverrideToggleCursorRow (GLib.GType gtype, ToggleCursorRowNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.ToggleCursorRow = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleCursorRowNativeDelegate (IntPtr inst);

		static void ToggleCursorRow_cb (IntPtr inst)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnToggleCursorRow ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideToggleCursorRow")]
		protected virtual void OnToggleCursorRow ()
		{
			InternalToggleCursorRow ();
		}

		private void InternalToggleCursorRow ()
		{
			ToggleCursorRowNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ToggleCursorRow;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static MoveCursorNativeDelegate MoveCursor_cb_delegate;
		static MoveCursorNativeDelegate MoveCursorVMCallback {
			get {
				if (MoveCursor_cb_delegate == null)
					MoveCursor_cb_delegate = new MoveCursorNativeDelegate (MoveCursor_cb);
				return MoveCursor_cb_delegate;
			}
		}

		static void OverrideMoveCursor (GLib.GType gtype)
		{
			OverrideMoveCursor (gtype, MoveCursorVMCallback);
		}

		static void OverrideMoveCursor (GLib.GType gtype, MoveCursorNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.MoveCursor = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MoveCursorNativeDelegate (IntPtr inst, int step, int count);

		static void MoveCursor_cb (IntPtr inst, int step, int count)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnMoveCursor ((Gtk.MovementStep) step, count);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideMoveCursor")]
		protected virtual void OnMoveCursor (Gtk.MovementStep step, int count)
		{
			InternalMoveCursor (step, count);
		}

		private void InternalMoveCursor (Gtk.MovementStep step, int count)
		{
			MoveCursorNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).MoveCursor;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) step, count);
		}

		static SelectedRowsChangedNativeDelegate SelectedRowsChanged_cb_delegate;
		static SelectedRowsChangedNativeDelegate SelectedRowsChangedVMCallback {
			get {
				if (SelectedRowsChanged_cb_delegate == null)
					SelectedRowsChanged_cb_delegate = new SelectedRowsChangedNativeDelegate (SelectedRowsChanged_cb);
				return SelectedRowsChanged_cb_delegate;
			}
		}

		static void OverrideSelectedRowsChanged (GLib.GType gtype)
		{
			OverrideSelectedRowsChanged (gtype, SelectedRowsChangedVMCallback);
		}

		static void OverrideSelectedRowsChanged (GLib.GType gtype, SelectedRowsChangedNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.SelectedRowsChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectedRowsChangedNativeDelegate (IntPtr inst);

		static void SelectedRowsChanged_cb (IntPtr inst)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnSelectedRowsChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideSelectedRowsChanged")]
		protected virtual void OnSelectedRowsChanged ()
		{
			InternalSelectedRowsChanged ();
		}

		private void InternalSelectedRowsChanged ()
		{
			SelectedRowsChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SelectedRowsChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static SelectedAllNativeDelegate SelectedAll_cb_delegate;
		static SelectedAllNativeDelegate SelectedAllVMCallback {
			get {
				if (SelectedAll_cb_delegate == null)
					SelectedAll_cb_delegate = new SelectedAllNativeDelegate (SelectedAll_cb);
				return SelectedAll_cb_delegate;
			}
		}

		static void OverrideSelectedAll (GLib.GType gtype)
		{
			OverrideSelectedAll (gtype, SelectedAllVMCallback);
		}

		static void OverrideSelectedAll (GLib.GType gtype, SelectedAllNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.SelectedAll = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectedAllNativeDelegate (IntPtr inst);

		static void SelectedAll_cb (IntPtr inst)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnSelectedAll ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideSelectedAll")]
		protected virtual void OnSelectedAll ()
		{
			InternalSelectedAll ();
		}

		private void InternalSelectedAll ()
		{
			SelectedAllNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SelectedAll;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static UnselectedAllNativeDelegate UnselectedAll_cb_delegate;
		static UnselectedAllNativeDelegate UnselectedAllVMCallback {
			get {
				if (UnselectedAll_cb_delegate == null)
					UnselectedAll_cb_delegate = new UnselectedAllNativeDelegate (UnselectedAll_cb);
				return UnselectedAll_cb_delegate;
			}
		}

		static void OverrideUnselectedAll (GLib.GType gtype)
		{
			OverrideUnselectedAll (gtype, UnselectedAllVMCallback);
		}

		static void OverrideUnselectedAll (GLib.GType gtype, UnselectedAllNativeDelegate callback)
		{
			GtkListBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.UnselectedAll = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UnselectedAllNativeDelegate (IntPtr inst);

		static void UnselectedAll_cb (IntPtr inst)
		{
			try {
				ListBox __obj = GLib.Object.GetObject (inst, false) as ListBox;
				__obj.OnUnselectedAll ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListBox), ConnectionMethod="OverrideUnselectedAll")]
		protected virtual void OnUnselectedAll ()
		{
			InternalUnselectedAll ();
		}

		private void InternalUnselectedAll ()
		{
			UnselectedAllNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).UnselectedAll;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkListBoxClass {
			public RowSelectedNativeDelegate RowSelected;
			public ListRowActivatedNativeDelegate ListRowActivated;
			public ActivateCursorRowNativeDelegate ActivateCursorRow;
			public ToggleCursorRowNativeDelegate ToggleCursorRow;
			public MoveCursorNativeDelegate MoveCursor;
			public SelectedRowsChangedNativeDelegate SelectedRowsChanged;
			public SelectedAllNativeDelegate SelectedAll;
			public UnselectedAllNativeDelegate UnselectedAll;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Container)).GetClassSize ();
		static Dictionary<GLib.GType, GtkListBoxClass> class_structs;

		static GtkListBoxClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkListBoxClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkListBoxClass class_struct = (GtkListBoxClass) Marshal.PtrToStructure (class_ptr, typeof (GtkListBoxClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkListBoxClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_drag_highlight_row(IntPtr raw, IntPtr row);

		public void DragHighlightRow(Gtk.ListBoxRow row) {
			gtk_list_box_drag_highlight_row(Handle, row == null ? IntPtr.Zero : row.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_drag_unhighlight_row(IntPtr raw);

		public void DragUnhighlightRow() {
			gtk_list_box_drag_unhighlight_row(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_adjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_adjustment(IntPtr raw, IntPtr adjustment);

		public Gtk.Adjustment Adjustment { 
			get {
				IntPtr raw_ret = gtk_list_box_get_adjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set {
				gtk_list_box_set_adjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_row_at_index(IntPtr raw, int index_);

		public Gtk.ListBoxRow GetRowAtIndex(int index_) {
			IntPtr raw_ret = gtk_list_box_get_row_at_index(Handle, index_);
			Gtk.ListBoxRow ret = GLib.Object.GetObject(raw_ret) as Gtk.ListBoxRow;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_row_at_y(IntPtr raw, int y);

		public Gtk.ListBoxRow GetRowAtY(int y) {
			IntPtr raw_ret = gtk_list_box_get_row_at_y(Handle, y);
			Gtk.ListBoxRow ret = GLib.Object.GetObject(raw_ret) as Gtk.ListBoxRow;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_selected_row(IntPtr raw);

		public Gtk.ListBoxRow SelectedRow { 
			get {
				IntPtr raw_ret = gtk_list_box_get_selected_row(Handle);
				Gtk.ListBoxRow ret = GLib.Object.GetObject(raw_ret) as Gtk.ListBoxRow;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_selected_rows(IntPtr raw);

		public GLib.List SelectedRows { 
			get {
				IntPtr raw_ret = gtk_list_box_get_selected_rows(Handle);
				GLib.List ret = new GLib.List(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_list_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_insert(IntPtr raw, IntPtr child, int position);

		public void Insert(Gtk.Widget child, int position) {
			gtk_list_box_insert(Handle, child == null ? IntPtr.Zero : child.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_invalidate_filter(IntPtr raw);

		public void InvalidateFilter() {
			gtk_list_box_invalidate_filter(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_invalidate_headers(IntPtr raw);

		public void InvalidateHeaders() {
			gtk_list_box_invalidate_headers(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_invalidate_sort(IntPtr raw);

		public void InvalidateSort() {
			gtk_list_box_invalidate_sort(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_prepend(IntPtr raw, IntPtr child);

		public void Prepend(Gtk.Widget child) {
			gtk_list_box_prepend(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_select_all(IntPtr raw);

		public void SelectAll() {
			gtk_list_box_select_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_select_row(IntPtr raw, IntPtr row);

		public void SelectRow(Gtk.ListBoxRow row) {
			gtk_list_box_select_row(Handle, row == null ? IntPtr.Zero : row.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_selected_foreach(IntPtr raw, GtkSharp.ListBoxForeachFuncNative func, IntPtr data);

		public void SelectedForeach(Gtk.ListBoxForeachFunc func) {
			GtkSharp.ListBoxForeachFuncWrapper func_wrapper = new GtkSharp.ListBoxForeachFuncWrapper (func);
			gtk_list_box_selected_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_filter_func(IntPtr raw, GtkSharp.ListBoxFilterFuncNative filter_func, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.ListBoxFilterFunc FilterFunc { 
			set {
				GtkSharp.ListBoxFilterFuncWrapper value_wrapper = new GtkSharp.ListBoxFilterFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_list_box_set_filter_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_header_func(IntPtr raw, GtkSharp.ListBoxUpdateHeaderFuncNative update_header, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.ListBoxUpdateHeaderFunc HeaderFunc { 
			set {
				GtkSharp.ListBoxUpdateHeaderFuncWrapper value_wrapper = new GtkSharp.ListBoxUpdateHeaderFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_list_box_set_header_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_placeholder(IntPtr raw, IntPtr placeholder);

		public Gtk.Widget Placeholder { 
			set {
				gtk_list_box_set_placeholder(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_set_sort_func(IntPtr raw, GtkSharp.ListBoxSortFuncNative sort_func, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.ListBoxSortFunc SortFunc { 
			set {
				GtkSharp.ListBoxSortFuncWrapper value_wrapper = new GtkSharp.ListBoxSortFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_list_box_set_sort_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_unselect_all(IntPtr raw);

		public void UnselectAll() {
			gtk_list_box_unselect_all(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_box_unselect_row(IntPtr raw, IntPtr row);

		public void UnselectRow(Gtk.ListBoxRow row) {
			gtk_list_box_unselect_row(Handle, row == null ? IntPtr.Zero : row.Handle);
		}

#endregion
	}
}
