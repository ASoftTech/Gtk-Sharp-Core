// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ScaleButton : Gtk.Button, Gtk.IOrientable {

		public ScaleButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_new(int size, double min, double max, double step, IntPtr[] icons);

		public ScaleButton (Gtk.IconSize size, double min, double max, double step, string[] icons) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ScaleButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("size");
				vals.Add (new GLib.Value (size));
				names.Add ("icons");
				vals.Add (new GLib.Value (icons));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			int cnt_icons = icons == null ? 0 : icons.Length;
			IntPtr[] native_icons = new IntPtr [cnt_icons + 1];
			for (int i = 0; i < cnt_icons; i++)
				native_icons [i] = GLib.Marshaller.StringToPtrGStrdup (icons[i]);
			native_icons [cnt_icons] = IntPtr.Zero;
			Raw = gtk_scale_button_new((int) size, min, max, step, native_icons);
			for (int i = 0; i < native_icons.Length - 1; i++) {
				icons [i] = GLib.Marshaller.Utf8PtrToString (native_icons[i]);
				GLib.Marshaller.Free (native_icons[i]);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_scale_button_get_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scale_button_set_value(IntPtr raw, double value);

		[GLib.Property ("value")]
		public double Value {
			get  {
				double raw_ret = gtk_scale_button_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_scale_button_set_value(Handle, value);
			}
		}

		[GLib.Property ("size")]
		public Gtk.IconSize Size {
			get {
				GLib.Value val = GetProperty ("size");
				Gtk.IconSize ret = (Gtk.IconSize) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("size", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_get_adjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scale_button_set_adjustment(IntPtr raw, IntPtr adjustment);

		[GLib.Property ("adjustment")]
		public Gtk.Adjustment Adjustment {
			get  {
				IntPtr raw_ret = gtk_scale_button_get_adjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_scale_button_set_adjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_scale_button_set_icons(IntPtr raw, IntPtr[] icons);

		[GLib.Property ("icons")]
		public string[] Icons {
			get {
				GLib.Value val = GetProperty ("icons");
				string[] ret = (string[]) val;
				val.Dispose ();
				return ret;
			}
			set  {
				int cnt_value = value == null ? 0 : value.Length;
				IntPtr[] native_value = new IntPtr [cnt_value + 1];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = GLib.Marshaller.StringToPtrGStrdup (value[i]);
				native_value [cnt_value] = IntPtr.Zero;
				gtk_scale_button_set_icons(Handle, native_value);
				for (int i = 0; i < native_value.Length - 1; i++) {
					value [i] = GLib.Marshaller.Utf8PtrToString (native_value[i]);
					GLib.Marshaller.Free (native_value[i]);
				}
			}
		}

		[GLib.Signal("value-changed")]
		public event Gtk.ValueChangedHandler ValueChanged {
			add {
				this.AddSignalHandler ("value-changed", value, typeof (Gtk.ValueChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("value-changed", value);
			}
		}

		[GLib.Signal("popdown")]
		public event System.EventHandler Popdown {
			add {
				this.AddSignalHandler ("popdown", value);
			}
			remove {
				this.RemoveSignalHandler ("popdown", value);
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
				ScaleButton __obj = GLib.Object.GetObject (inst, false) as ScaleButton;
				__obj.OnPoppedUp ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ScaleButton), ConnectionMethod="OverridePoppedUp")]
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

		static PopdownNativeDelegate Popdown_cb_delegate;
		static PopdownNativeDelegate PopdownVMCallback {
			get {
				if (Popdown_cb_delegate == null)
					Popdown_cb_delegate = new PopdownNativeDelegate (Popdown_cb);
				return Popdown_cb_delegate;
			}
		}

		static void OverridePopdown (GLib.GType gtype)
		{
			OverridePopdown (gtype, PopdownVMCallback);
		}

		static void OverridePopdown (GLib.GType gtype, PopdownNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "popdown", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PopdownNativeDelegate (IntPtr inst);

		static void Popdown_cb (IntPtr inst)
		{
			try {
				ScaleButton __obj = GLib.Object.GetObject (inst, false) as ScaleButton;
				__obj.OnPopdown ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ScaleButton), ConnectionMethod="OverridePopdown")]
		protected virtual void OnPopdown ()
		{
			InternalPopdown ();
		}

		private void InternalPopdown ()
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

		static ValueChangedNativeDelegate ValueChanged_cb_delegate;
		static ValueChangedNativeDelegate ValueChangedVMCallback {
			get {
				if (ValueChanged_cb_delegate == null)
					ValueChanged_cb_delegate = new ValueChangedNativeDelegate (ValueChanged_cb);
				return ValueChanged_cb_delegate;
			}
		}

		static void OverrideValueChanged (GLib.GType gtype)
		{
			OverrideValueChanged (gtype, ValueChangedVMCallback);
		}

		static void OverrideValueChanged (GLib.GType gtype, ValueChangedNativeDelegate callback)
		{
			GtkScaleButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.ValueChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueChangedNativeDelegate (IntPtr inst, double value);

		static void ValueChanged_cb (IntPtr inst, double value)
		{
			try {
				ScaleButton __obj = GLib.Object.GetObject (inst, false) as ScaleButton;
				__obj.OnValueChanged (value);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ScaleButton), ConnectionMethod="OverrideValueChanged")]
		protected virtual void OnValueChanged (double value)
		{
			InternalValueChanged (value);
		}

		private void InternalValueChanged (double value)
		{
			ValueChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ValueChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle, value);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkScaleButtonClass {
			public ValueChangedNativeDelegate ValueChanged;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Button)).GetClassSize ();
		static Dictionary<GLib.GType, GtkScaleButtonClass> class_structs;

		static GtkScaleButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkScaleButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkScaleButtonClass class_struct = (GtkScaleButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkScaleButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkScaleButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_get_minus_button(IntPtr raw);

		public Gtk.Widget MinusButton { 
			get {
				IntPtr raw_ret = gtk_scale_button_get_minus_button(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_get_plus_button(IntPtr raw);

		public Gtk.Widget PlusButton { 
			get {
				IntPtr raw_ret = gtk_scale_button_get_plus_button(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_get_popup(IntPtr raw);

		public Gtk.Widget Popup { 
			get {
				IntPtr raw_ret = gtk_scale_button_get_popup(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_scale_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_scale_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}

#endregion
	}
}
