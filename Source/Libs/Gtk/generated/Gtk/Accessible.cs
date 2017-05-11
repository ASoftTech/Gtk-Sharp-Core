// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Accessible : Atk.Object {

		public Accessible (IntPtr raw) : base(raw) {}

		protected Accessible() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accessible_get_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accessible_set_widget(IntPtr raw, IntPtr widget);

		[GLib.Property ("widget")]
		public Gtk.Widget Widget {
			get  {
				IntPtr raw_ret = gtk_accessible_get_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_accessible_set_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		static ConnectWidgetDestroyedNativeDelegate ConnectWidgetDestroyed_cb_delegate;
		static ConnectWidgetDestroyedNativeDelegate ConnectWidgetDestroyedVMCallback {
			get {
				if (ConnectWidgetDestroyed_cb_delegate == null)
					ConnectWidgetDestroyed_cb_delegate = new ConnectWidgetDestroyedNativeDelegate (ConnectWidgetDestroyed_cb);
				return ConnectWidgetDestroyed_cb_delegate;
			}
		}

		static void OverrideConnectWidgetDestroyed (GLib.GType gtype)
		{
			OverrideConnectWidgetDestroyed (gtype, ConnectWidgetDestroyedVMCallback);
		}

		static void OverrideConnectWidgetDestroyed (GLib.GType gtype, ConnectWidgetDestroyedNativeDelegate callback)
		{
			GtkAccessibleClass class_iface = GetClassStruct (gtype, false);
			class_iface.ConnectWidgetDestroyed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectWidgetDestroyedNativeDelegate (IntPtr inst);

		static void ConnectWidgetDestroyed_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnConnectWidgetDestroyed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideConnectWidgetDestroyed")]
		protected virtual void OnConnectWidgetDestroyed ()
		{
			InternalConnectWidgetDestroyed ();
		}

		private void InternalConnectWidgetDestroyed ()
		{
			ConnectWidgetDestroyedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ConnectWidgetDestroyed;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static WidgetSetNativeDelegate WidgetSet_cb_delegate;
		static WidgetSetNativeDelegate WidgetSetVMCallback {
			get {
				if (WidgetSet_cb_delegate == null)
					WidgetSet_cb_delegate = new WidgetSetNativeDelegate (WidgetSet_cb);
				return WidgetSet_cb_delegate;
			}
		}

		static void OverrideWidgetSet (GLib.GType gtype)
		{
			OverrideWidgetSet (gtype, WidgetSetVMCallback);
		}

		static void OverrideWidgetSet (GLib.GType gtype, WidgetSetNativeDelegate callback)
		{
			GtkAccessibleClass class_iface = GetClassStruct (gtype, false);
			class_iface.WidgetSet = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WidgetSetNativeDelegate (IntPtr inst);

		static void WidgetSet_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnWidgetSet ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideWidgetSet")]
		protected virtual void OnWidgetSet ()
		{
			InternalWidgetSet ();
		}

		private void InternalWidgetSet ()
		{
			WidgetSetNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).WidgetSet;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static WidgetUnsetNativeDelegate WidgetUnset_cb_delegate;
		static WidgetUnsetNativeDelegate WidgetUnsetVMCallback {
			get {
				if (WidgetUnset_cb_delegate == null)
					WidgetUnset_cb_delegate = new WidgetUnsetNativeDelegate (WidgetUnset_cb);
				return WidgetUnset_cb_delegate;
			}
		}

		static void OverrideWidgetUnset (GLib.GType gtype)
		{
			OverrideWidgetUnset (gtype, WidgetUnsetVMCallback);
		}

		static void OverrideWidgetUnset (GLib.GType gtype, WidgetUnsetNativeDelegate callback)
		{
			GtkAccessibleClass class_iface = GetClassStruct (gtype, false);
			class_iface.WidgetUnset = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WidgetUnsetNativeDelegate (IntPtr inst);

		static void WidgetUnset_cb (IntPtr inst)
		{
			try {
				Accessible __obj = GLib.Object.GetObject (inst, false) as Accessible;
				__obj.OnWidgetUnset ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Accessible), ConnectionMethod="OverrideWidgetUnset")]
		protected virtual void OnWidgetUnset ()
		{
			InternalWidgetUnset ();
		}

		private void InternalWidgetUnset ()
		{
			WidgetUnsetNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).WidgetUnset;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkAccessibleClass {
			public ConnectWidgetDestroyedNativeDelegate ConnectWidgetDestroyed;
			public WidgetSetNativeDelegate WidgetSet;
			public WidgetUnsetNativeDelegate WidgetUnset;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Atk.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GtkAccessibleClass> class_structs;

		static GtkAccessibleClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkAccessibleClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkAccessibleClass class_struct = (GtkAccessibleClass) Marshal.PtrToStructure (class_ptr, typeof (GtkAccessibleClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkAccessibleClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_accessible_connect_widget_destroyed(IntPtr raw);

		[Obsolete]
		public void ConnectWidgetDestroyed() {
			gtk_accessible_connect_widget_destroyed(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_accessible_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_accessible_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}