// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Seat : GLib.Object {

		public Seat (IntPtr raw) : base(raw) {}

		protected Seat() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static DeviceAddedNativeDelegate DeviceAdded_cb_delegate;
		static DeviceAddedNativeDelegate DeviceAddedVMCallback {
			get {
				if (DeviceAdded_cb_delegate == null)
					DeviceAdded_cb_delegate = new DeviceAddedNativeDelegate (DeviceAdded_cb);
				return DeviceAdded_cb_delegate;
			}
		}

		static void OverrideDeviceAdded (GLib.GType gtype)
		{
			OverrideDeviceAdded (gtype, DeviceAddedVMCallback);
		}

		static void OverrideDeviceAdded (GLib.GType gtype, DeviceAddedNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.DeviceAdded = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceAddedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceAdded_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceAdded (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceAdded")]
		protected virtual void OnDeviceAdded (Gdk.Device device)
		{
			InternalDeviceAdded (device);
		}

		private void InternalDeviceAdded (Gdk.Device device)
		{
			DeviceAddedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DeviceAdded;
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static DeviceRemovedNativeDelegate DeviceRemoved_cb_delegate;
		static DeviceRemovedNativeDelegate DeviceRemovedVMCallback {
			get {
				if (DeviceRemoved_cb_delegate == null)
					DeviceRemoved_cb_delegate = new DeviceRemovedNativeDelegate (DeviceRemoved_cb);
				return DeviceRemoved_cb_delegate;
			}
		}

		static void OverrideDeviceRemoved (GLib.GType gtype)
		{
			OverrideDeviceRemoved (gtype, DeviceRemovedVMCallback);
		}

		static void OverrideDeviceRemoved (GLib.GType gtype, DeviceRemovedNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.DeviceRemoved = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceRemovedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceRemoved_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceRemoved (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceRemoved")]
		protected virtual void OnDeviceRemoved (Gdk.Device device)
		{
			InternalDeviceRemoved (device);
		}

		private void InternalDeviceRemoved (Gdk.Device device)
		{
			DeviceRemovedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DeviceRemoved;
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static DeviceChangedNativeDelegate DeviceChanged_cb_delegate;
		static DeviceChangedNativeDelegate DeviceChangedVMCallback {
			get {
				if (DeviceChanged_cb_delegate == null)
					DeviceChanged_cb_delegate = new DeviceChangedNativeDelegate (DeviceChanged_cb);
				return DeviceChanged_cb_delegate;
			}
		}

		static void OverrideDeviceChanged (GLib.GType gtype)
		{
			OverrideDeviceChanged (gtype, DeviceChangedVMCallback);
		}

		static void OverrideDeviceChanged (GLib.GType gtype, DeviceChangedNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.DeviceChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeviceChangedNativeDelegate (IntPtr inst, IntPtr device);

		static void DeviceChanged_cb (IntPtr inst, IntPtr device)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnDeviceChanged (GLib.Object.GetObject(device) as Gdk.Device);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideDeviceChanged")]
		protected virtual void OnDeviceChanged (Gdk.Device device)
		{
			InternalDeviceChanged (device);
		}

		private void InternalDeviceChanged (Gdk.Device device)
		{
			DeviceChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).DeviceChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle, device == null ? IntPtr.Zero : device.Handle);
		}

		static GetCapabilitiesNativeDelegate GetCapabilities_cb_delegate;
		static GetCapabilitiesNativeDelegate GetCapabilitiesVMCallback {
			get {
				if (GetCapabilities_cb_delegate == null)
					GetCapabilities_cb_delegate = new GetCapabilitiesNativeDelegate (GetCapabilities_cb);
				return GetCapabilities_cb_delegate;
			}
		}

		static void OverrideGetCapabilities (GLib.GType gtype)
		{
			OverrideGetCapabilities (gtype, GetCapabilitiesVMCallback);
		}

		static void OverrideGetCapabilities (GLib.GType gtype, GetCapabilitiesNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetCapabilities = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetCapabilitiesNativeDelegate (IntPtr inst);

		static int GetCapabilities_cb (IntPtr inst)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.SeatCapabilities __result;
				__result = __obj.OnGetCapabilities ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetCapabilities")]
		protected virtual Gdk.SeatCapabilities OnGetCapabilities ()
		{
			return InternalGetCapabilities ();
		}

		private Gdk.SeatCapabilities InternalGetCapabilities ()
		{
			GetCapabilitiesNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetCapabilities;
			if (unmanaged == null) return (Gdk.SeatCapabilities) 0;

			int __result = unmanaged (this.Handle);
			return (Gdk.SeatCapabilities) __result;
		}

		static GrabNativeDelegate Grab_cb_delegate;
		static GrabNativeDelegate GrabVMCallback {
			get {
				if (Grab_cb_delegate == null)
					Grab_cb_delegate = new GrabNativeDelegate (Grab_cb);
				return Grab_cb_delegate;
			}
		}

		static void OverrideGrab (GLib.GType gtype)
		{
			OverrideGrab (gtype, GrabVMCallback);
		}

		static void OverrideGrab (GLib.GType gtype, GrabNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.Grab = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GrabNativeDelegate (IntPtr inst, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data);

		static int Grab_cb (IntPtr inst, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.GrabStatus __result;
				GdkSharp.SeatGrabPrepareFuncInvoker prepare_func_invoker = new GdkSharp.SeatGrabPrepareFuncInvoker (prepare_func, prepare_func_data);
				__result = __obj.OnGrab (GLib.Object.GetObject(window) as Gdk.Window, (Gdk.SeatCapabilities) capabilities, owner_events, GLib.Object.GetObject(cursor) as Gdk.Cursor, Gdk.Event.GetEvent (evnt), prepare_func_invoker.Handler);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGrab")]
		protected virtual Gdk.GrabStatus OnGrab (Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func)
		{
			return InternalGrab (window, capabilities, owner_events, cursor, evnt, prepare_func);
		}

		private Gdk.GrabStatus InternalGrab (Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func)
		{
			GrabNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Grab;
			if (unmanaged == null) return (Gdk.GrabStatus) 0;

			GdkSharp.SeatGrabPrepareFuncWrapper prepare_func_wrapper = new GdkSharp.SeatGrabPrepareFuncWrapper (prepare_func);
			int __result = unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, (int) capabilities, owner_events, cursor == null ? IntPtr.Zero : cursor.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, prepare_func_wrapper.NativeDelegate, IntPtr.Zero);
			return (Gdk.GrabStatus) __result;
		}

		static UngrabNativeDelegate Ungrab_cb_delegate;
		static UngrabNativeDelegate UngrabVMCallback {
			get {
				if (Ungrab_cb_delegate == null)
					Ungrab_cb_delegate = new UngrabNativeDelegate (Ungrab_cb);
				return Ungrab_cb_delegate;
			}
		}

		static void OverrideUngrab (GLib.GType gtype)
		{
			OverrideUngrab (gtype, UngrabVMCallback);
		}

		static void OverrideUngrab (GLib.GType gtype, UngrabNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.Ungrab = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UngrabNativeDelegate (IntPtr inst);

		static void Ungrab_cb (IntPtr inst)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				__obj.OnUngrab ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideUngrab")]
		protected virtual void OnUngrab ()
		{
			InternalUngrab ();
		}

		private void InternalUngrab ()
		{
			UngrabNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Ungrab;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static GetMasterNativeDelegate GetMaster_cb_delegate;
		static GetMasterNativeDelegate GetMasterVMCallback {
			get {
				if (GetMaster_cb_delegate == null)
					GetMaster_cb_delegate = new GetMasterNativeDelegate (GetMaster_cb);
				return GetMaster_cb_delegate;
			}
		}

		static void OverrideGetMaster (GLib.GType gtype)
		{
			OverrideGetMaster (gtype, GetMasterVMCallback);
		}

		static void OverrideGetMaster (GLib.GType gtype, GetMasterNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetMaster = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetMasterNativeDelegate (IntPtr inst, int capability);

		static IntPtr GetMaster_cb (IntPtr inst, int capability)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.Device __result;
				__result = __obj.OnGetMaster ((Gdk.SeatCapabilities) capability);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetMaster")]
		protected virtual Gdk.Device OnGetMaster (Gdk.SeatCapabilities capability)
		{
			return InternalGetMaster (capability);
		}

		private Gdk.Device InternalGetMaster (Gdk.SeatCapabilities capability)
		{
			GetMasterNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetMaster;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, (int) capability);
			return GLib.Object.GetObject(__result) as Gdk.Device;
		}

		static GetSlavesNativeDelegate GetSlaves_cb_delegate;
		static GetSlavesNativeDelegate GetSlavesVMCallback {
			get {
				if (GetSlaves_cb_delegate == null)
					GetSlaves_cb_delegate = new GetSlavesNativeDelegate (GetSlaves_cb);
				return GetSlaves_cb_delegate;
			}
		}

		static void OverrideGetSlaves (GLib.GType gtype)
		{
			OverrideGetSlaves (gtype, GetSlavesVMCallback);
		}

		static void OverrideGetSlaves (GLib.GType gtype, GetSlavesNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetSlaves = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetSlavesNativeDelegate (IntPtr inst, int capabilities);

		static IntPtr GetSlaves_cb (IntPtr inst, int capabilities)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				GLib.List __result;
				__result = __obj.OnGetSlaves ((Gdk.SeatCapabilities) capabilities);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetSlaves")]
		protected virtual GLib.List OnGetSlaves (Gdk.SeatCapabilities capabilities)
		{
			return InternalGetSlaves (capabilities);
		}

		private GLib.List InternalGetSlaves (Gdk.SeatCapabilities capabilities)
		{
			GetSlavesNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetSlaves;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, (int) capabilities);
			return new GLib.List(__result);
		}

		static GetToolNativeDelegate GetTool_cb_delegate;
		static GetToolNativeDelegate GetToolVMCallback {
			get {
				if (GetTool_cb_delegate == null)
					GetTool_cb_delegate = new GetToolNativeDelegate (GetTool_cb);
				return GetTool_cb_delegate;
			}
		}

		static void OverrideGetTool (GLib.GType gtype)
		{
			OverrideGetTool (gtype, GetToolVMCallback);
		}

		static void OverrideGetTool (GLib.GType gtype, GetToolNativeDelegate callback)
		{
			GdkSeatClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetTool = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetToolNativeDelegate (IntPtr inst, ulong serial);

		static IntPtr GetTool_cb (IntPtr inst, ulong serial)
		{
			try {
				Seat __obj = GLib.Object.GetObject (inst, false) as Seat;
				Gdk.DeviceTool __result;
				__result = __obj.OnGetTool (serial);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Seat), ConnectionMethod="OverrideGetTool")]
		protected virtual Gdk.DeviceTool OnGetTool (ulong serial)
		{
			return InternalGetTool (serial);
		}

		private Gdk.DeviceTool InternalGetTool (ulong serial)
		{
			GetToolNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetTool;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, serial);
			return GLib.Object.GetObject(__result) as Gdk.DeviceTool;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkSeatClass {
			public DeviceAddedNativeDelegate DeviceAdded;
			public DeviceRemovedNativeDelegate DeviceRemoved;
			public DeviceChangedNativeDelegate DeviceChanged;
			public GetCapabilitiesNativeDelegate GetCapabilities;
			public GrabNativeDelegate Grab;
			public UngrabNativeDelegate Ungrab;
			public GetMasterNativeDelegate GetMaster;
			public GetSlavesNativeDelegate GetSlaves;
			public GetToolNativeDelegate GetTool;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GdkSeatClass> class_structs;

		static GdkSeatClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkSeatClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkSeatClass class_struct = (GdkSeatClass) Marshal.PtrToStructure (class_ptr, typeof (GdkSeatClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkSeatClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_seat_get_capabilities(IntPtr raw);

		public Gdk.SeatCapabilities Capabilities { 
			get {
				int raw_ret = gdk_seat_get_capabilities(Handle);
				Gdk.SeatCapabilities ret = (Gdk.SeatCapabilities) raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_seat_get_display(IntPtr raw);

		public Gdk.Display Display { 
			get {
				IntPtr raw_ret = gdk_seat_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_seat_get_keyboard(IntPtr raw);

		public Gdk.Device Keyboard { 
			get {
				IntPtr raw_ret = gdk_seat_get_keyboard(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_seat_get_pointer(IntPtr raw);

		public Gdk.Device Pointer { 
			get {
				IntPtr raw_ret = gdk_seat_get_pointer(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_seat_get_slaves(IntPtr raw, int capabilities);

		public GLib.List GetSlaves(Gdk.SeatCapabilities capabilities) {
			IntPtr raw_ret = gdk_seat_get_slaves(Handle, (int) capabilities);
			GLib.List ret = new GLib.List(raw_ret);
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_seat_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_seat_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_seat_grab(IntPtr raw, IntPtr window, int capabilities, bool owner_events, IntPtr cursor, IntPtr evnt, GdkSharp.SeatGrabPrepareFuncNative prepare_func, IntPtr prepare_func_data);

		public Gdk.GrabStatus Grab(Gdk.Window window, Gdk.SeatCapabilities capabilities, bool owner_events, Gdk.Cursor cursor, Gdk.Event evnt, Gdk.SeatGrabPrepareFunc prepare_func) {
			GdkSharp.SeatGrabPrepareFuncWrapper prepare_func_wrapper = new GdkSharp.SeatGrabPrepareFuncWrapper (prepare_func);
			int raw_ret = gdk_seat_grab(Handle, window == null ? IntPtr.Zero : window.Handle, (int) capabilities, owner_events, cursor == null ? IntPtr.Zero : cursor.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, prepare_func_wrapper.NativeDelegate, IntPtr.Zero);
			Gdk.GrabStatus ret = (Gdk.GrabStatus) raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_seat_ungrab(IntPtr raw);

		public void Ungrab() {
			gdk_seat_ungrab(Handle);
		}

#endregion
	}
}
