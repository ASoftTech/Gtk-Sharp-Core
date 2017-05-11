// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RcStyle : GLib.Object {

		public RcStyle (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_style_new();

		public RcStyle () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RcStyle)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_rc_style_new();
		}

		[DllImport ("gtksharpglue-3")]
		extern static uint gtksharp_gtk_rcstyle_get_name_offset ();

		static uint name_offset = gtksharp_gtk_rcstyle_get_name_offset ();
		public string Name {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + name_offset);
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + name_offset);
					*raw_ptr = GLib.Marshaller.StringToPtrGStrdup (value);
				}
			}
		}

		[DllImport ("gtksharpglue-3")]
		extern static uint gtksharp_gtk_rcstyle_get_font_desc_offset ();

		static uint font_desc_offset = gtksharp_gtk_rcstyle_get_font_desc_offset ();
		public Pango.FontDescription FontDesc {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + font_desc_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Pango.FontDescription), false);
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + font_desc_offset);
					*raw_ptr = value == null ? IntPtr.Zero : value.Handle;
				}
			}
		}

		[DllImport ("gtksharpglue-3")]
		extern static uint gtksharp_gtk_rcstyle_get_xthickness_offset ();

		static uint xthickness_offset = gtksharp_gtk_rcstyle_get_xthickness_offset ();
		public int Xthickness {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + xthickness_offset);
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + xthickness_offset);
					*raw_ptr = value;
				}
			}
		}

		[DllImport ("gtksharpglue-3")]
		extern static uint gtksharp_gtk_rcstyle_get_ythickness_offset ();

		static uint ythickness_offset = gtksharp_gtk_rcstyle_get_ythickness_offset ();
		public int Ythickness {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + ythickness_offset);
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + ythickness_offset);
					*raw_ptr = value;
				}
			}
		}

		static CreateRcStyleNativeDelegate CreateRcStyle_cb_delegate;
		static CreateRcStyleNativeDelegate CreateRcStyleVMCallback {
			get {
				if (CreateRcStyle_cb_delegate == null)
					CreateRcStyle_cb_delegate = new CreateRcStyleNativeDelegate (CreateRcStyle_cb);
				return CreateRcStyle_cb_delegate;
			}
		}

		static void OverrideCreateRcStyle (GLib.GType gtype)
		{
			OverrideCreateRcStyle (gtype, CreateRcStyleVMCallback);
		}

		static void OverrideCreateRcStyle (GLib.GType gtype, CreateRcStyleNativeDelegate callback)
		{
			GtkRcStyleClass class_iface = GetClassStruct (gtype, false);
			class_iface.CreateRcStyle = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateRcStyleNativeDelegate (IntPtr inst);

		static IntPtr CreateRcStyle_cb (IntPtr inst)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				Gtk.RcStyle __result;
				__result = __obj.OnCreateRcStyle ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideCreateRcStyle")]
		protected virtual Gtk.RcStyle OnCreateRcStyle ()
		{
			return InternalCreateRcStyle ();
		}

		private Gtk.RcStyle InternalCreateRcStyle ()
		{
			CreateRcStyleNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CreateRcStyle;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as Gtk.RcStyle;
		}

		static MergeNativeDelegate Merge_cb_delegate;
		static MergeNativeDelegate MergeVMCallback {
			get {
				if (Merge_cb_delegate == null)
					Merge_cb_delegate = new MergeNativeDelegate (Merge_cb);
				return Merge_cb_delegate;
			}
		}

		static void OverrideMerge (GLib.GType gtype)
		{
			OverrideMerge (gtype, MergeVMCallback);
		}

		static void OverrideMerge (GLib.GType gtype, MergeNativeDelegate callback)
		{
			GtkRcStyleClass class_iface = GetClassStruct (gtype, false);
			class_iface.Merge = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void MergeNativeDelegate (IntPtr inst, IntPtr src);

		static void Merge_cb (IntPtr inst, IntPtr src)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				__obj.OnMerge (GLib.Object.GetObject(src) as Gtk.RcStyle);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideMerge")]
		protected virtual void OnMerge (Gtk.RcStyle src)
		{
			InternalMerge (src);
		}

		private void InternalMerge (Gtk.RcStyle src)
		{
			MergeNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Merge;
			if (unmanaged == null) return;

			unmanaged (this.Handle, src == null ? IntPtr.Zero : src.Handle);
		}

		static CreateStyleNativeDelegate CreateStyle_cb_delegate;
		static CreateStyleNativeDelegate CreateStyleVMCallback {
			get {
				if (CreateStyle_cb_delegate == null)
					CreateStyle_cb_delegate = new CreateStyleNativeDelegate (CreateStyle_cb);
				return CreateStyle_cb_delegate;
			}
		}

		static void OverrideCreateStyle (GLib.GType gtype)
		{
			OverrideCreateStyle (gtype, CreateStyleVMCallback);
		}

		static void OverrideCreateStyle (GLib.GType gtype, CreateStyleNativeDelegate callback)
		{
			GtkRcStyleClass class_iface = GetClassStruct (gtype, false);
			class_iface.CreateStyle = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateStyleNativeDelegate (IntPtr inst);

		static IntPtr CreateStyle_cb (IntPtr inst)
		{
			try {
				RcStyle __obj = GLib.Object.GetObject (inst, false) as RcStyle;
				Gtk.Style __result;
				__result = __obj.OnCreateStyle ();
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RcStyle), ConnectionMethod="OverrideCreateStyle")]
		protected virtual Gtk.Style OnCreateStyle ()
		{
			return InternalCreateStyle ();
		}

		private Gtk.Style InternalCreateStyle ()
		{
			CreateStyleNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).CreateStyle;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Object.GetObject(__result) as Gtk.Style;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkRcStyleClass {
			public CreateRcStyleNativeDelegate CreateRcStyle;
			IntPtr Parse;
			public MergeNativeDelegate Merge;
			public CreateStyleNativeDelegate CreateStyle;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkRcStyleClass> class_structs;

		static GtkRcStyleClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkRcStyleClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkRcStyleClass class_struct = (GtkRcStyleClass) Marshal.PtrToStructure (class_ptr, typeof (GtkRcStyleClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkRcStyleClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_style_copy(IntPtr raw);

		[Obsolete]
		public Gtk.RcStyle Copy() {
			IntPtr raw_ret = gtk_rc_style_copy(Handle);
			Gtk.RcStyle ret = GLib.Object.GetObject(raw_ret, true) as Gtk.RcStyle;
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_rc_style_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_rc_style_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}