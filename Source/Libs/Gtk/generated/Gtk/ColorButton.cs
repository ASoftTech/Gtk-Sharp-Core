// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ColorButton : Gtk.Button, Gtk.IColorChooser {

		public ColorButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_button_new();

		public ColorButton () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ColorButton)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_color_button_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_button_new_with_color(IntPtr color);

		public ColorButton (Gdk.Color color) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ColorButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("color");
				vals.Add (new GLib.Value (color));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_color = GLib.Marshaller.StructureToPtrAlloc (color);
			Raw = gtk_color_button_new_with_color(native_color);
			Marshal.FreeHGlobal (native_color);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_button_new_with_rgba(IntPtr rgba);

		public ColorButton (Gdk.RGBA rgba) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ColorButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("rgba");
				vals.Add (new GLib.Value (rgba));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_rgba = GLib.Marshaller.StructureToPtrAlloc (rgba);
			Raw = gtk_color_button_new_with_rgba(native_rgba);
			Marshal.FreeHGlobal (native_rgba);
		}

		[GLib.Property ("use-alpha")]
		public bool HasAlpha {
			get {
				GLib.Value val = GetProperty ("use-alpha");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("use-alpha", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_button_get_title(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_button_set_title(IntPtr raw, IntPtr title);

		[GLib.Property ("title")]
		public string Title {
			get  {
				IntPtr raw_ret = gtk_color_button_get_title(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_color_button_set_title(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_button_get_color(IntPtr raw, IntPtr color);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_button_set_color(IntPtr raw, IntPtr value);

		[Obsolete]
		[GLib.Property ("color")]
		public Gdk.Color Color {
			get  {
				Gdk.Color color;
				IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.Color)));
				gtk_color_button_get_color(Handle, native_color);
				color = Gdk.Color.New (native_color);
				Marshal.FreeHGlobal (native_color);
				return color;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gtk_color_button_set_color(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ushort gtk_color_button_get_alpha(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_button_set_alpha(IntPtr raw, ushort alpha);

		[Obsolete]
		[GLib.Property ("alpha")]
		public ushort Alpha {
			get  {
				ushort raw_ret = gtk_color_button_get_alpha(Handle);
				ushort ret = raw_ret;
				return ret;
			}
			set  {
				gtk_color_button_set_alpha(Handle, value);
			}
		}

		[GLib.Property ("show-editor")]
		public bool ShowEditor {
			get {
				GLib.Value val = GetProperty ("show-editor");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("show-editor", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("color-set")]
		public event System.EventHandler ColorSet {
			add {
				this.AddSignalHandler ("color-set", value);
			}
			remove {
				this.RemoveSignalHandler ("color-set", value);
			}
		}

		static ColorSetNativeDelegate ColorSet_cb_delegate;
		static ColorSetNativeDelegate ColorSetVMCallback {
			get {
				if (ColorSet_cb_delegate == null)
					ColorSet_cb_delegate = new ColorSetNativeDelegate (ColorSet_cb);
				return ColorSet_cb_delegate;
			}
		}

		static void OverrideColorSet (GLib.GType gtype)
		{
			OverrideColorSet (gtype, ColorSetVMCallback);
		}

		static void OverrideColorSet (GLib.GType gtype, ColorSetNativeDelegate callback)
		{
			GtkColorButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.ColorSet = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ColorSetNativeDelegate (IntPtr inst);

		static void ColorSet_cb (IntPtr inst)
		{
			try {
				ColorButton __obj = GLib.Object.GetObject (inst, false) as ColorButton;
				__obj.OnColorSet ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ColorButton), ConnectionMethod="OverrideColorSet")]
		protected virtual void OnColorSet ()
		{
			InternalColorSet ();
		}

		private void InternalColorSet ()
		{
			ColorSetNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ColorSet;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkColorButtonClass {
			public ColorSetNativeDelegate ColorSet;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Button)).GetClassSize ();
		static Dictionary<GLib.GType, GtkColorButtonClass> class_structs;

		static GtkColorButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkColorButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkColorButtonClass class_struct = (GtkColorButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkColorButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkColorButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_color_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_add_palette(IntPtr raw, int orientation, int colors_per_line, int n_colors, IntPtr colors);

		public void AddPalette(Gtk.Orientation orientation, int colors_per_line, int n_colors, Gdk.RGBA colors) {
			IntPtr native_colors = GLib.Marshaller.StructureToPtrAlloc (colors);
			gtk_color_chooser_add_palette(Handle, (int) orientation, colors_per_line, n_colors, native_colors);
			Marshal.FreeHGlobal (native_colors);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_get_rgba(IntPtr raw, IntPtr color);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_set_rgba(IntPtr raw, IntPtr value);

		[GLib.Property ("rgba")]
		public Gdk.RGBA Rgba {
			get  {
				Gdk.RGBA color;
				IntPtr native_color = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gdk.RGBA)));
				gtk_color_chooser_get_rgba(Handle, native_color);
				color = Gdk.RGBA.New (native_color);
				Marshal.FreeHGlobal (native_color);
				return color;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gtk_color_chooser_set_rgba(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_color_chooser_get_use_alpha(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_set_use_alpha(IntPtr raw, bool use_alpha);

		[GLib.Property ("use-alpha")]
		public bool UseAlpha {
			get  {
				bool raw_ret = gtk_color_chooser_get_use_alpha(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_color_chooser_set_use_alpha(Handle, value);
			}
		}

		[GLib.Signal("color-activated")]
		public event Gtk.ColorActivatedHandler ColorActivated {
			add {
				this.AddSignalHandler ("color-activated", value, typeof (Gtk.ColorActivatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("color-activated", value);
			}
		}

		static ColorActivatedNativeDelegate ColorActivated_cb_delegate;
		static ColorActivatedNativeDelegate ColorActivatedVMCallback {
			get {
				if (ColorActivated_cb_delegate == null)
					ColorActivated_cb_delegate = new ColorActivatedNativeDelegate (ColorActivated_cb);
				return ColorActivated_cb_delegate;
			}
		}

		static void OverrideColorActivated (GLib.GType gtype)
		{
			OverrideColorActivated (gtype, ColorActivatedVMCallback);
		}

		static void OverrideColorActivated (GLib.GType gtype, ColorActivatedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "color-activated", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ColorActivatedNativeDelegate (IntPtr inst, IntPtr color);

		static void ColorActivated_cb (IntPtr inst, IntPtr color)
		{
			try {
				Gtk.ColorButton __obj = GLib.Object.GetObject (inst, false) as Gtk.ColorButton;
				__obj.OnColorActivated (Gdk.RGBA.New (color));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ColorButton), ConnectionMethod="OverrideColorActivated")]
		protected virtual void OnColorActivated (Gdk.RGBA color)
		{
			InternalColorActivated (color);
		}

		private void InternalColorActivated (Gdk.RGBA color)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (color);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

#endregion
	}
}
