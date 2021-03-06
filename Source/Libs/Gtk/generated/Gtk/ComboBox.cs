// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ComboBox : Gtk.Bin, Gtk.ICellLayout, Gtk.ICellEditable {

		public ComboBox (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new();

		public ComboBox () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ComboBox)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_combo_box_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new_with_area(IntPtr area);

		public ComboBox (Gtk.CellArea area) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ComboBox)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_combo_box_new_with_area(area == null ? IntPtr.Zero : area.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new_with_area_and_entry(IntPtr area);

		public static ComboBox NewWithAreaAndEntry(Gtk.CellArea area)
		{
			ComboBox result = new ComboBox (gtk_combo_box_new_with_area_and_entry(area == null ? IntPtr.Zero : area.Handle));
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new_with_entry();

		public static ComboBox NewWithEntry()
		{
			ComboBox result = new ComboBox (gtk_combo_box_new_with_entry());
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new_with_model(IntPtr model);

		public ComboBox (Gtk.ITreeModel model) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ComboBox)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (model != null) {
					names.Add ("model");
					vals.Add (new GLib.Value (model));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_combo_box_new_with_model(model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle));
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_new_with_model_and_entry(IntPtr model);

		public static ComboBox NewWithModelAndEntry(Gtk.ITreeModel model)
		{
			ComboBox result = new ComboBox (gtk_combo_box_new_with_model_and_entry(model == null ? IntPtr.Zero : ((model is GLib.Object) ? (model as GLib.Object).Handle : (model as Gtk.TreeModelAdapter).Handle)));
			return result;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_get_model(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_model(IntPtr raw, IntPtr model);

		[GLib.Property ("model")]
		public Gtk.ITreeModel Model {
			get  {
				IntPtr raw_ret = gtk_combo_box_get_model(Handle);
				Gtk.ITreeModel ret = Gtk.TreeModelAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_combo_box_set_model(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as Gtk.TreeModelAdapter).Handle));
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_wrap_width(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_wrap_width(IntPtr raw, int width);

		[GLib.Property ("wrap-width")]
		public int WrapWidth {
			get  {
				int raw_ret = gtk_combo_box_get_wrap_width(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_wrap_width(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_row_span_column(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_row_span_column(IntPtr raw, int row_span);

		[GLib.Property ("row-span-column")]
		public int RowSpanColumn {
			get  {
				int raw_ret = gtk_combo_box_get_row_span_column(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_row_span_column(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_column_span_column(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_column_span_column(IntPtr raw, int column_span);

		[GLib.Property ("column-span-column")]
		public int ColumnSpanColumn {
			get  {
				int raw_ret = gtk_combo_box_get_column_span_column(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_column_span_column(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_active(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_active(IntPtr raw, int index_);

		[GLib.Property ("active")]
		public int Active {
			get  {
				int raw_ret = gtk_combo_box_get_active(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_active(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_combo_box_get_add_tearoffs(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_add_tearoffs(IntPtr raw, bool add_tearoffs);

		[Obsolete]
		[GLib.Property ("add-tearoffs")]
		public bool AddTearoffs {
			get  {
				bool raw_ret = gtk_combo_box_get_add_tearoffs(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_add_tearoffs(Handle, value);
			}
		}

		[GLib.Property ("has-frame")]
		public bool HasFrame {
			get {
				GLib.Value val = GetProperty ("has-frame");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("has-frame", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_get_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_title(IntPtr raw, IntPtr title);

		[Obsolete]
		[GLib.Property ("tearoff-title")]
		public string TearoffTitle {
			get  {
				IntPtr raw_ret = gtk_combo_box_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_combo_box_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("popup-shown")]
		public bool PopupShown {
			get {
				GLib.Value val = GetProperty ("popup-shown");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_button_sensitivity(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_button_sensitivity(IntPtr raw, int sensitivity);

		[GLib.Property ("button-sensitivity")]
		public Gtk.SensitivityType ButtonSensitivity {
			get  {
				int raw_ret = gtk_combo_box_get_button_sensitivity(Handle);
				Gtk.SensitivityType ret = (Gtk.SensitivityType) raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_button_sensitivity(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_combo_box_get_has_entry(IntPtr raw);

		[GLib.Property ("has-entry")]
		public bool HasEntry {
			get  {
				bool raw_ret = gtk_combo_box_get_has_entry(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_entry_text_column(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_entry_text_column(IntPtr raw, int text_column);

		[GLib.Property ("entry-text-column")]
		public int EntryTextColumn {
			get  {
				int raw_ret = gtk_combo_box_get_entry_text_column(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_entry_text_column(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_combo_box_get_id_column(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_id_column(IntPtr raw, int id_column);

		[GLib.Property ("id-column")]
		public int IdColumn {
			get  {
				int raw_ret = gtk_combo_box_get_id_column(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_id_column(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_get_active_id(IntPtr raw);

		[GLib.Property ("active-id")]
		public string ActiveId {
			get  {
				IntPtr raw_ret = gtk_combo_box_get_active_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("active-id", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_combo_box_get_popup_fixed_width(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_popup_fixed_width(IntPtr raw, bool mfixed);

		[GLib.Property ("popup-fixed-width")]
		public bool PopupFixedWidth {
			get  {
				bool raw_ret = gtk_combo_box_get_popup_fixed_width(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_combo_box_set_popup_fixed_width(Handle, value);
			}
		}

		[GLib.Property ("cell-area")]
		public Gtk.CellArea CellArea {
			get {
				GLib.Value val = GetProperty ("cell-area");
				Gtk.CellArea ret = (Gtk.CellArea) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("appears-as-list")]
		public bool AppearsAsList {
			get {
				GLib.Value val = GetProperty ("appears-as-list");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("arrow-size")]
		public int ArrowSize {
			get {
				GLib.Value val = GetProperty ("arrow-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("arrow-scaling")]
		public float ArrowScaling {
			get {
				GLib.Value val = GetProperty ("arrow-scaling");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				GLib.Value val = GetProperty ("shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("popdown")]
		public event Gtk.PoppedDownHandler PoppedDown {
			add {
				this.AddSignalHandler ("popdown", value, typeof (Gtk.PoppedDownArgs));
			}
			remove {
				this.RemoveSignalHandler ("popdown", value);
			}
		}

		[GLib.Signal("format-entry-text")]
		public event Gtk.FormatEntryTextHandler FormatEntryText {
			add {
				this.AddSignalHandler ("format-entry-text", value, typeof (Gtk.FormatEntryTextArgs));
			}
			remove {
				this.RemoveSignalHandler ("format-entry-text", value);
			}
		}

		[GLib.Signal("move-active")]
		public event Gtk.MoveActiveHandler MoveActive {
			add {
				this.AddSignalHandler ("move-active", value, typeof (Gtk.MoveActiveArgs));
			}
			remove {
				this.RemoveSignalHandler ("move-active", value);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				this.AddSignalHandler ("changed", value);
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		[GLib.Signal("popup")]
		public event System.EventHandler PoppedUp {
			add {
				this.AddSignalHandler ("popup", value);
			}
			remove {
				this.RemoveSignalHandler ("popup", value);
			}
		}

		static MoveActiveNativeDelegate MoveActive_cb_delegate;
		static MoveActiveNativeDelegate MoveActiveVMCallback {
			get {
				if (MoveActive_cb_delegate == null)
					MoveActive_cb_delegate = new MoveActiveNativeDelegate (MoveActive_cb);
				return MoveActive_cb_delegate;
			}
		}

		static void OverrideMoveActive (GLib.GType gtype)
		{
			OverrideMoveActive (gtype, MoveActiveVMCallback);
		}

		static void OverrideMoveActive (GLib.GType gtype, MoveActiveNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "move-active", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MoveActiveNativeDelegate (IntPtr inst, int p0);

		static void MoveActive_cb (IntPtr inst, int p0)
		{
			try {
				ComboBox __obj = GLib.Object.GetObject (inst, false) as ComboBox;
				__obj.OnMoveActive ((Gtk.ScrollType) p0);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverrideMoveActive")]
		protected virtual void OnMoveActive (Gtk.ScrollType p0)
		{
			InternalMoveActive (p0);
		}

		private void InternalMoveActive (Gtk.ScrollType p0)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static PoppedUpNativeDelegate PoppedUp_cb_delegate;
		static PoppedUpNativeDelegate PoppedUpVMCallback {
			get {
				if (PoppedUp_cb_delegate == null)
					PoppedUp_cb_delegate = new PoppedUpNativeDelegate (PoppedUp_cb);
				return PoppedUp_cb_delegate;
			}
		}

		static void OverridePoppedUp (GLib.GType gtype)
		{
			OverridePoppedUp (gtype, PoppedUpVMCallback);
		}

		static void OverridePoppedUp (GLib.GType gtype, PoppedUpNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "popup", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PoppedUpNativeDelegate (IntPtr inst);

		static void PoppedUp_cb (IntPtr inst)
		{
			try {
				ComboBox __obj = GLib.Object.GetObject (inst, false) as ComboBox;
				__obj.OnPoppedUp ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverridePoppedUp")]
		protected virtual void OnPoppedUp ()
		{
			InternalPoppedUp ();
		}

		private void InternalPoppedUp ()
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

		static PoppedDownNativeDelegate PoppedDown_cb_delegate;
		static PoppedDownNativeDelegate PoppedDownVMCallback {
			get {
				if (PoppedDown_cb_delegate == null)
					PoppedDown_cb_delegate = new PoppedDownNativeDelegate (PoppedDown_cb);
				return PoppedDown_cb_delegate;
			}
		}

		static void OverridePoppedDown (GLib.GType gtype)
		{
			OverridePoppedDown (gtype, PoppedDownVMCallback);
		}

		static void OverridePoppedDown (GLib.GType gtype, PoppedDownNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "popdown", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool PoppedDownNativeDelegate (IntPtr inst);

		static bool PoppedDown_cb (IntPtr inst)
		{
			try {
				ComboBox __obj = GLib.Object.GetObject (inst, false) as ComboBox;
				bool __result;
				__result = __obj.OnPoppedDown ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverridePoppedDown")]
		protected virtual bool OnPoppedDown ()
		{
			return InternalPoppedDown ();
		}

		private bool InternalPoppedDown ()
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			GtkComboBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.Changed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				ComboBox __obj = GLib.Object.GetObject (inst, false) as ComboBox;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Changed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static FormatEntryTextNativeDelegate FormatEntryText_cb_delegate;
		static FormatEntryTextNativeDelegate FormatEntryTextVMCallback {
			get {
				if (FormatEntryText_cb_delegate == null)
					FormatEntryText_cb_delegate = new FormatEntryTextNativeDelegate (FormatEntryText_cb);
				return FormatEntryText_cb_delegate;
			}
		}

		static void OverrideFormatEntryText (GLib.GType gtype)
		{
			OverrideFormatEntryText (gtype, FormatEntryTextVMCallback);
		}

		static void OverrideFormatEntryText (GLib.GType gtype, FormatEntryTextNativeDelegate callback)
		{
			GtkComboBoxClass class_iface = GetClassStruct (gtype, false);
			class_iface.FormatEntryText = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr FormatEntryTextNativeDelegate (IntPtr inst, IntPtr path);

		static IntPtr FormatEntryText_cb (IntPtr inst, IntPtr path)
		{
			try {
				ComboBox __obj = GLib.Object.GetObject (inst, false) as ComboBox;
				string __result;
				__result = __obj.OnFormatEntryText (GLib.Marshaller.Utf8PtrToString (path));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverrideFormatEntryText")]
		protected virtual string OnFormatEntryText (string path)
		{
			return InternalFormatEntryText (path);
		}

		private string InternalFormatEntryText (string path)
		{
			FormatEntryTextNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).FormatEntryText;
			if (unmanaged == null) return null;

			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr __result = unmanaged (this.Handle, native_path);
			GLib.Marshaller.Free (native_path);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkComboBoxClass {
			public ChangedNativeDelegate Changed;
			public FormatEntryTextNativeDelegate FormatEntryText;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Bin)).GetClassSize ();
		static Dictionary<GLib.GType, GtkComboBoxClass> class_structs;

		static GtkComboBoxClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkComboBoxClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkComboBoxClass class_struct = (GtkComboBoxClass) Marshal.PtrToStructure (class_ptr, typeof (GtkComboBoxClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkComboBoxClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_combo_box_get_active_iter(IntPtr raw, IntPtr iter);

		public bool GetActiveIter(out Gtk.TreeIter iter) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_combo_box_get_active_iter(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_get_popup_accessible(IntPtr raw);

		public Atk.Object PopupAccessible { 
			get {
				IntPtr raw_ret = gtk_combo_box_get_popup_accessible(Handle);
				Atk.Object ret = GLib.Object.GetObject(raw_ret) as Atk.Object;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern GtkSharp.TreeViewRowSeparatorFuncNative gtk_combo_box_get_row_separator_func(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_row_separator_func(IntPtr raw, GtkSharp.TreeViewRowSeparatorFuncNative func, IntPtr data, GLib.DestroyNotify destroy);

		public Gtk.TreeViewRowSeparatorFunc RowSeparatorFunc { 
			get {
				GtkSharp.TreeViewRowSeparatorFuncNative raw_ret = gtk_combo_box_get_row_separator_func(Handle);
				Gtk.TreeViewRowSeparatorFunc ret = GtkSharp.TreeViewRowSeparatorFuncWrapper.GetManagedDelegate (raw_ret);
				return ret;
			}
			set {
				GtkSharp.TreeViewRowSeparatorFuncWrapper value_wrapper = new GtkSharp.TreeViewRowSeparatorFuncWrapper (value);
				IntPtr data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					data = IntPtr.Zero;
					destroy = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_combo_box_set_row_separator_func(Handle, value_wrapper.NativeDelegate, data, destroy);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_combo_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_combo_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_popdown(IntPtr raw);

		public void Popdown() {
			gtk_combo_box_popdown(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_popup(IntPtr raw);

		public void Popup() {
			gtk_combo_box_popup(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_popup_for_device(IntPtr raw, IntPtr device);

		public void PopupForDevice(Gdk.Device device) {
			gtk_combo_box_popup_for_device(Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_combo_box_set_active_id(IntPtr raw, IntPtr active_id);

		public bool SetActiveId(string active_id) {
			IntPtr native_active_id = GLib.Marshaller.StringToPtrGStrdup (active_id);
			bool raw_ret = gtk_combo_box_set_active_id(Handle, native_active_id);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_active_id);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_combo_box_set_active_iter(IntPtr raw, IntPtr iter);

		public void SetActiveIter(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_combo_box_set_active_iter(Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_add_attribute(IntPtr raw, IntPtr cell, IntPtr attribute, int column);

		public void AddAttribute(Gtk.CellRenderer cell, string attribute, int column) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			gtk_cell_layout_add_attribute(Handle, cell == null ? IntPtr.Zero : cell.Handle, native_attribute, column);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear(IntPtr raw);

		public void Clear() {
			gtk_cell_layout_clear(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear_attributes(IntPtr raw, IntPtr cell);

		public void ClearAttributes(Gtk.CellRenderer cell) {
			gtk_cell_layout_clear_attributes(Handle, cell == null ? IntPtr.Zero : cell.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_area(IntPtr raw);

		public Gtk.CellArea Area { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_area(Handle);
				Gtk.CellArea ret = GLib.Object.GetObject(raw_ret) as Gtk.CellArea;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_cells(IntPtr raw);

		public Gtk.CellRenderer[] Cells { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_cells(Handle);
				Gtk.CellRenderer[] ret = (Gtk.CellRenderer[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(Gtk.CellRenderer));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_end(IntPtr raw, IntPtr cell, bool expand);

		public void PackEnd(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_end(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_start(IntPtr raw, IntPtr cell, bool expand);

		public void PackStart(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_start(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_reorder(IntPtr raw, IntPtr cell, int position);

		public void Reorder(Gtk.CellRenderer cell, int position) {
			gtk_cell_layout_reorder(Handle, cell == null ? IntPtr.Zero : cell.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_set_cell_data_func(IntPtr raw, IntPtr cell, GtkSharp.CellLayoutDataFuncNative func, IntPtr func_data, GLib.DestroyNotify destroy);

		public void SetCellDataFunc(Gtk.CellRenderer cell, Gtk.CellLayoutDataFunc func) {
			GtkSharp.CellLayoutDataFuncWrapper func_wrapper = new GtkSharp.CellLayoutDataFuncWrapper (func);
			IntPtr func_data;
			GLib.DestroyNotify destroy;
			if (func == null) {
				func_data = IntPtr.Zero;
				destroy = null;
			} else {
				func_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_cell_layout_set_cell_data_func(Handle, cell == null ? IntPtr.Zero : cell.Handle, func_wrapper.NativeDelegate, func_data, destroy);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_editable_editing_done(IntPtr raw);

		public void FinishEditing() {
			gtk_cell_editable_editing_done(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_editable_remove_widget(IntPtr raw);

		public void RemoveWidget() {
			gtk_cell_editable_remove_widget(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_editable_start_editing(IntPtr raw, IntPtr evnt);

		public void StartEditing(Gdk.Event evnt) {
			gtk_cell_editable_start_editing(Handle, evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[GLib.Signal("remove-widget")]
		public event System.EventHandler WidgetRemoved {
			add {
				this.AddSignalHandler ("remove-widget", value);
			}
			remove {
				this.RemoveSignalHandler ("remove-widget", value);
			}
		}

		[GLib.Signal("editing-done")]
		public event System.EventHandler EditingDone {
			add {
				this.AddSignalHandler ("editing-done", value);
			}
			remove {
				this.RemoveSignalHandler ("editing-done", value);
			}
		}

		static EditingDoneNativeDelegate EditingDone_cb_delegate;
		static EditingDoneNativeDelegate EditingDoneVMCallback {
			get {
				if (EditingDone_cb_delegate == null)
					EditingDone_cb_delegate = new EditingDoneNativeDelegate (EditingDone_cb);
				return EditingDone_cb_delegate;
			}
		}

		static void OverrideEditingDone (GLib.GType gtype)
		{
			OverrideEditingDone (gtype, EditingDoneVMCallback);
		}

		static void OverrideEditingDone (GLib.GType gtype, EditingDoneNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "editing-done", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EditingDoneNativeDelegate (IntPtr inst);

		static void EditingDone_cb (IntPtr inst)
		{
			try {
				Gtk.ComboBox __obj = GLib.Object.GetObject (inst, false) as Gtk.ComboBox;
				__obj.OnEditingDone ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverrideEditingDone")]
		protected virtual void OnEditingDone ()
		{
			InternalEditingDone ();
		}

		private void InternalEditingDone ()
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

		static WidgetRemovedNativeDelegate WidgetRemoved_cb_delegate;
		static WidgetRemovedNativeDelegate WidgetRemovedVMCallback {
			get {
				if (WidgetRemoved_cb_delegate == null)
					WidgetRemoved_cb_delegate = new WidgetRemovedNativeDelegate (WidgetRemoved_cb);
				return WidgetRemoved_cb_delegate;
			}
		}

		static void OverrideWidgetRemoved (GLib.GType gtype)
		{
			OverrideWidgetRemoved (gtype, WidgetRemovedVMCallback);
		}

		static void OverrideWidgetRemoved (GLib.GType gtype, WidgetRemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "remove-widget", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WidgetRemovedNativeDelegate (IntPtr inst);

		static void WidgetRemoved_cb (IntPtr inst)
		{
			try {
				Gtk.ComboBox __obj = GLib.Object.GetObject (inst, false) as Gtk.ComboBox;
				__obj.OnWidgetRemoved ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ComboBox), ConnectionMethod="OverrideWidgetRemoved")]
		protected virtual void OnWidgetRemoved ()
		{
			InternalWidgetRemoved ();
		}

		private void InternalWidgetRemoved ()
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

#endregion
	}
}
