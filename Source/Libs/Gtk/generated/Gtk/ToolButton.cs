// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ToolButton : Gtk.ToolItem, Gtk.IActionable {

		public ToolButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_new(IntPtr icon_widget, IntPtr label);

		public ToolButton (Gtk.Widget icon_widget, string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (icon_widget != null) {
					names.Add ("icon_widget");
					vals.Add (new GLib.Value (icon_widget));
				}
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_tool_button_new(icon_widget == null ? IntPtr.Zero : icon_widget.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_new_from_stock(IntPtr stock_id);

		public ToolButton (string stock_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ToolButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("stock_id");
				vals.Add (new GLib.Value (stock_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_tool_button_new_from_stock(native_stock_id);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_tool_button_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_tool_button_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tool_button_get_use_underline(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_use_underline(IntPtr raw, bool use_underline);

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_tool_button_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_tool_button_set_use_underline(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_label_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_label_widget(IntPtr raw, IntPtr label_widget);

		[GLib.Property ("label-widget")]
		public Gtk.Widget LabelWidget {
			get  {
				IntPtr raw_ret = gtk_tool_button_get_label_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_tool_button_set_label_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_stock_id(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_stock_id(IntPtr raw, IntPtr stock_id);

		[Obsolete]
		[GLib.Property ("stock-id")]
		public string StockId {
			get  {
				IntPtr raw_ret = gtk_tool_button_get_stock_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_tool_button_set_stock_id(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_icon_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_icon_name(IntPtr raw, IntPtr icon_name);

		[GLib.Property ("icon-name")]
		public string IconName {
			get  {
				IntPtr raw_ret = gtk_tool_button_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_tool_button_set_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_icon_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tool_button_set_icon_widget(IntPtr raw, IntPtr icon_widget);

		[GLib.Property ("icon-widget")]
		public Gtk.Widget IconWidget {
			get  {
				IntPtr raw_ret = gtk_tool_button_get_icon_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_tool_button_set_icon_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("icon-spacing")]
		public int IconSpacing {
			get {
				GLib.Value val = GetProperty ("icon-spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("icon-spacing", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("clicked")]
		public event System.EventHandler Clicked {
			add {
				this.AddSignalHandler ("clicked", value);
			}
			remove {
				this.RemoveSignalHandler ("clicked", value);
			}
		}

		static ClickedNativeDelegate Clicked_cb_delegate;
		static ClickedNativeDelegate ClickedVMCallback {
			get {
				if (Clicked_cb_delegate == null)
					Clicked_cb_delegate = new ClickedNativeDelegate (Clicked_cb);
				return Clicked_cb_delegate;
			}
		}

		static void OverrideClicked (GLib.GType gtype)
		{
			OverrideClicked (gtype, ClickedVMCallback);
		}

		static void OverrideClicked (GLib.GType gtype, ClickedNativeDelegate callback)
		{
			GtkToolButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Clicked = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ClickedNativeDelegate (IntPtr inst);

		static void Clicked_cb (IntPtr inst)
		{
			try {
				ToolButton __obj = GLib.Object.GetObject (inst, false) as ToolButton;
				__obj.OnClicked ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ToolButton), ConnectionMethod="OverrideClicked")]
		protected virtual void OnClicked ()
		{
			InternalClicked ();
		}

		private void InternalClicked ()
		{
			ClickedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Clicked;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkToolButtonClass {
			public GLib.GType ButtonType;
			public ClickedNativeDelegate Clicked;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.ToolItem)).GetClassSize ();
		static Dictionary<GLib.GType, GtkToolButtonClass> class_structs;

		static GtkToolButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkToolButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkToolButtonClass class_struct = (GtkToolButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkToolButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkToolButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tool_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tool_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_actionable_get_action_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_action_name(IntPtr raw, IntPtr action_name);

		public string ActionName { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_actionable_get_action_target_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_action_target_value(IntPtr raw, IntPtr target_value);

		public GLib.Variant ActionTargetValue { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_target_value(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				gtk_actionable_set_action_target_value(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_detailed_action_name(IntPtr raw, IntPtr detailed_action_name);

		public string DetailedActionName { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_detailed_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

#endregion
	}
}
