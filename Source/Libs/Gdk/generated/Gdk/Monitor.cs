// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Monitor : GLib.Object {

		public Monitor (IntPtr raw) : base(raw) {}

		protected Monitor() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_monitor_get_display(IntPtr raw);

		[GLib.Property ("display")]
		public Gdk.Display Display {
			get  {
				IntPtr raw_ret = gdk_monitor_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_monitor_get_manufacturer(IntPtr raw);

		[GLib.Property ("manufacturer")]
		public string Manufacturer {
			get  {
				IntPtr raw_ret = gdk_monitor_get_manufacturer(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_monitor_get_model(IntPtr raw);

		[GLib.Property ("model")]
		public string Model {
			get  {
				IntPtr raw_ret = gdk_monitor_get_model(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_monitor_get_scale_factor(IntPtr raw);

		[GLib.Property ("scale-factor")]
		public int ScaleFactor {
			get  {
				int raw_ret = gdk_monitor_get_scale_factor(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[GLib.Property ("geometry")]
		public Gdk.Rectangle Geometry {
			get {
				GLib.Value val = GetProperty ("geometry");
				Gdk.Rectangle ret = (Gdk.Rectangle) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("workarea")]
		public Gdk.Rectangle Workarea {
			get {
				GLib.Value val = GetProperty ("workarea");
				Gdk.Rectangle ret = (Gdk.Rectangle) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_monitor_get_width_mm(IntPtr raw);

		[GLib.Property ("width-mm")]
		public int WidthMm {
			get  {
				int raw_ret = gdk_monitor_get_width_mm(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_monitor_get_height_mm(IntPtr raw);

		[GLib.Property ("height-mm")]
		public int HeightMm {
			get  {
				int raw_ret = gdk_monitor_get_height_mm(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_monitor_get_refresh_rate(IntPtr raw);

		[GLib.Property ("refresh-rate")]
		public int RefreshRate {
			get  {
				int raw_ret = gdk_monitor_get_refresh_rate(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_monitor_get_subpixel_layout(IntPtr raw);

		[GLib.Property ("subpixel-layout")]
		public Gdk.SubpixelLayout SubpixelLayout {
			get  {
				int raw_ret = gdk_monitor_get_subpixel_layout(Handle);
				Gdk.SubpixelLayout ret = (Gdk.SubpixelLayout) raw_ret;
				return ret;
			}
		}

		[GLib.Signal("invalidate")]
		public event System.EventHandler Invalidate {
			add {
				this.AddSignalHandler ("invalidate", value);
			}
			remove {
				this.RemoveSignalHandler ("invalidate", value);
			}
		}

		static InvalidateNativeDelegate Invalidate_cb_delegate;
		static InvalidateNativeDelegate InvalidateVMCallback {
			get {
				if (Invalidate_cb_delegate == null)
					Invalidate_cb_delegate = new InvalidateNativeDelegate (Invalidate_cb);
				return Invalidate_cb_delegate;
			}
		}

		static void OverrideInvalidate (GLib.GType gtype)
		{
			OverrideInvalidate (gtype, InvalidateVMCallback);
		}

		static void OverrideInvalidate (GLib.GType gtype, InvalidateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "invalidate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void InvalidateNativeDelegate (IntPtr inst);

		static void Invalidate_cb (IntPtr inst)
		{
			try {
				Monitor __obj = GLib.Object.GetObject (inst, false) as Monitor;
				__obj.OnInvalidate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Monitor), ConnectionMethod="OverrideInvalidate")]
		protected virtual void OnInvalidate ()
		{
			InternalInvalidate ();
		}

		private void InternalInvalidate ()
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

		static GetWorkareaNativeDelegate GetWorkarea_cb_delegate;
		static GetWorkareaNativeDelegate GetWorkareaVMCallback {
			get {
				if (GetWorkarea_cb_delegate == null)
					GetWorkarea_cb_delegate = new GetWorkareaNativeDelegate (GetWorkarea_cb);
				return GetWorkarea_cb_delegate;
			}
		}

		static void OverrideGetWorkarea (GLib.GType gtype)
		{
			OverrideGetWorkarea (gtype, GetWorkareaVMCallback);
		}

		static void OverrideGetWorkarea (GLib.GType gtype, GetWorkareaNativeDelegate callback)
		{
			GdkMonitorClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetWorkarea = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetWorkareaNativeDelegate (IntPtr inst, IntPtr geometry);

		static void GetWorkarea_cb (IntPtr inst, IntPtr geometry)
		{
			try {
				Monitor __obj = GLib.Object.GetObject (inst, false) as Monitor;
				__obj.OnGetWorkarea ((Gdk.Rectangle) Marshal.PtrToStructure (geometry, typeof (Gdk.Rectangle)));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Monitor), ConnectionMethod="OverrideGetWorkarea")]
		protected virtual void OnGetWorkarea (Gdk.Rectangle geometry)
		{
			InternalGetWorkarea (geometry);
		}

		private void InternalGetWorkarea (Gdk.Rectangle geometry)
		{
			GetWorkareaNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetWorkarea;
			if (unmanaged == null) return;

			IntPtr native_geometry = GLib.Marshaller.StructureToPtrAlloc (geometry);
			unmanaged (this.Handle, native_geometry);
			Marshal.FreeHGlobal (native_geometry);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkMonitorClass {
			public GetWorkareaNativeDelegate GetWorkarea;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GdkMonitorClass> class_structs;

		static GdkMonitorClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkMonitorClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkMonitorClass class_struct = (GdkMonitorClass) Marshal.PtrToStructure (class_ptr, typeof (GdkMonitorClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkMonitorClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_monitor_get_geometry(IntPtr raw, IntPtr geometry);

		public void GetGeometry(Gdk.Rectangle geometry) {
			IntPtr native_geometry = GLib.Marshaller.StructureToPtrAlloc (geometry);
			gdk_monitor_get_geometry(Handle, native_geometry);
			Marshal.FreeHGlobal (native_geometry);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_monitor_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_monitor_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_monitor_get_workarea(IntPtr raw, IntPtr workarea);

		public void GetWorkarea(Gdk.Rectangle workarea) {
			IntPtr native_workarea = GLib.Marshaller.StructureToPtrAlloc (workarea);
			gdk_monitor_get_workarea(Handle, native_workarea);
			Marshal.FreeHGlobal (native_workarea);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_monitor_is_primary(IntPtr raw);

		public bool IsPrimary { 
			get {
				bool raw_ret = gdk_monitor_is_primary(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
