// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Device : GLib.Object {

		public Device (IntPtr raw) : base(raw) {}

		protected Device() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_display(IntPtr raw);

		[GLib.Property ("display")]
		public Gdk.Display Display {
			get  {
				IntPtr raw_ret = gdk_device_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[GLib.Property ("device-manager")]
		public Gdk.DeviceManager DeviceManager {
			get {
				GLib.Value val = GetProperty ("device-manager");
				Gdk.DeviceManager ret = (Gdk.DeviceManager) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_name(IntPtr raw);

		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = gdk_device_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[GLib.Property ("type")]
		public Gdk.DeviceType Type {
			get {
				GLib.Value val = GetProperty ("type");
				Gdk.DeviceType ret = (Gdk.DeviceType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_associated_device(IntPtr raw);

		[GLib.Property ("associated-device")]
		public Gdk.Device AssociatedDevice {
			get  {
				IntPtr raw_ret = gdk_device_get_associated_device(Handle);
				Gdk.Device ret = GLib.Object.GetObject(raw_ret) as Gdk.Device;
				return ret;
			}
		}

		[GLib.Property ("input-source")]
		public Gdk.InputSource InputSource {
			get {
				GLib.Value val = GetProperty ("input-source");
				Gdk.InputSource ret = (Gdk.InputSource) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("input-mode")]
		public Gdk.InputMode InputMode {
			get {
				GLib.Value val = GetProperty ("input-mode");
				Gdk.InputMode ret = (Gdk.InputMode) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("input-mode", val);
				val.Dispose ();
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_get_has_cursor(IntPtr raw);

		[GLib.Property ("has-cursor")]
		public bool HasCursor {
			get  {
				bool raw_ret = gdk_device_get_has_cursor(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_n_axes(IntPtr raw);

		[GLib.Property ("n-axes")]
		public int NumAxes {
			get  {
				int raw_ret = gdk_device_get_n_axes(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_vendor_id(IntPtr raw);

		[GLib.Property ("vendor-id")]
		public string VendorId {
			get  {
				IntPtr raw_ret = gdk_device_get_vendor_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_product_id(IntPtr raw);

		[GLib.Property ("product-id")]
		public string ProductId {
			get  {
				IntPtr raw_ret = gdk_device_get_product_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_seat(IntPtr raw);

		[GLib.Property ("seat")]
		public Gdk.Seat Seat {
			get  {
				IntPtr raw_ret = gdk_device_get_seat(Handle);
				Gdk.Seat ret = GLib.Object.GetObject(raw_ret) as Gdk.Seat;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("seat", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("num-touches")]
		public uint NumTouches {
			get {
				GLib.Value val = GetProperty ("num-touches");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_axes(IntPtr raw);

		[GLib.Property ("axes")]
		public Gdk.AxisFlags Axes {
			get  {
				int raw_ret = gdk_device_get_axes(Handle);
				Gdk.AxisFlags ret = (Gdk.AxisFlags) raw_ret;
				return ret;
			}
		}

		[GLib.Property ("tool")]
		public Gdk.DeviceTool Tool {
			get {
				GLib.Value val = GetProperty ("tool");
				Gdk.DeviceTool ret = (Gdk.DeviceTool) val;
				val.Dispose ();
				return ret;
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

		[GLib.Signal("tool-changed")]
		public event Gdk.ToolChangedHandler ToolChanged {
			add {
				this.AddSignalHandler ("tool-changed", value, typeof (Gdk.ToolChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("tool-changed", value);
			}
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
			OverrideVirtualMethod (gtype, "changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
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

		static ToolChangedNativeDelegate ToolChanged_cb_delegate;
		static ToolChangedNativeDelegate ToolChangedVMCallback {
			get {
				if (ToolChanged_cb_delegate == null)
					ToolChanged_cb_delegate = new ToolChangedNativeDelegate (ToolChanged_cb);
				return ToolChanged_cb_delegate;
			}
		}

		static void OverrideToolChanged (GLib.GType gtype)
		{
			OverrideToolChanged (gtype, ToolChangedVMCallback);
		}

		static void OverrideToolChanged (GLib.GType gtype, ToolChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "tool-changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToolChangedNativeDelegate (IntPtr inst, IntPtr p0);

		static void ToolChanged_cb (IntPtr inst, IntPtr p0)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnToolChanged (GLib.Object.GetObject(p0) as Gdk.DeviceTool);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideToolChanged")]
		protected virtual void OnToolChanged (Gdk.DeviceTool p0)
		{
			InternalToolChanged (p0);
		}

		private void InternalToolChanged (Gdk.DeviceTool p0)
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

		static GetHistoryNativeDelegate GetHistory_cb_delegate;
		static GetHistoryNativeDelegate GetHistoryVMCallback {
			get {
				if (GetHistory_cb_delegate == null)
					GetHistory_cb_delegate = new GetHistoryNativeDelegate (GetHistory_cb);
				return GetHistory_cb_delegate;
			}
		}

		static void OverrideGetHistory (GLib.GType gtype)
		{
			OverrideGetHistory (gtype, GetHistoryVMCallback);
		}

		static void OverrideGetHistory (GLib.GType gtype, GetHistoryNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetHistory = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetHistoryNativeDelegate (IntPtr inst, IntPtr window, uint start, uint stop, IntPtr events, out int n_events);

		static bool GetHistory_cb (IntPtr inst, IntPtr window, uint start, uint stop, IntPtr events, out int n_events)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				bool __result;
				__result = __obj.OnGetHistory (GLib.Object.GetObject(window) as Gdk.Window, start, stop, Gdk.TimeCoord.New (events), out n_events);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideGetHistory")]
		protected virtual bool OnGetHistory (Gdk.Window window, uint start, uint stop, Gdk.TimeCoord events, out int n_events)
		{
			return InternalGetHistory (window, start, stop, events, out n_events);
		}

		private bool InternalGetHistory (Gdk.Window window, uint start, uint stop, Gdk.TimeCoord events, out int n_events)
		{
			GetHistoryNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetHistory;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr native_events = GLib.Marshaller.StructureToPtrAlloc (events);
			bool __result = unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, start, stop, native_events, out n_events);
			Marshal.FreeHGlobal (native_events);
			return __result;
		}

		static GetStateNativeDelegate GetState_cb_delegate;
		static GetStateNativeDelegate GetStateVMCallback {
			get {
				if (GetState_cb_delegate == null)
					GetState_cb_delegate = new GetStateNativeDelegate (GetState_cb);
				return GetState_cb_delegate;
			}
		}

		static void OverrideGetState (GLib.GType gtype)
		{
			OverrideGetState (gtype, GetStateVMCallback);
		}

		static void OverrideGetState (GLib.GType gtype, GetStateNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetState = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetStateNativeDelegate (IntPtr inst, IntPtr window, out double axes, out int mask);

		static void GetState_cb (IntPtr inst, IntPtr window, out double axes, out int mask)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				Gdk.ModifierType mymask;
				__obj.OnGetState (GLib.Object.GetObject(window) as Gdk.Window, out axes, out mymask);
				mask = (int) mymask;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideGetState")]
		protected virtual void OnGetState (Gdk.Window window, out double axes, out Gdk.ModifierType mask)
		{
			InternalGetState (window, out axes, out mask);
		}

		private void InternalGetState (Gdk.Window window, out double axes, out Gdk.ModifierType mask)
		{
			GetStateNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetState;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			int native_mask;
			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, out axes, out native_mask);
			mask = (Gdk.ModifierType) native_mask;
		}

		static SetWindowCursorNativeDelegate SetWindowCursor_cb_delegate;
		static SetWindowCursorNativeDelegate SetWindowCursorVMCallback {
			get {
				if (SetWindowCursor_cb_delegate == null)
					SetWindowCursor_cb_delegate = new SetWindowCursorNativeDelegate (SetWindowCursor_cb);
				return SetWindowCursor_cb_delegate;
			}
		}

		static void OverrideSetWindowCursor (GLib.GType gtype)
		{
			OverrideSetWindowCursor (gtype, SetWindowCursorVMCallback);
		}

		static void OverrideSetWindowCursor (GLib.GType gtype, SetWindowCursorNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.SetWindowCursor = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetWindowCursorNativeDelegate (IntPtr inst, IntPtr window, IntPtr cursor);

		static void SetWindowCursor_cb (IntPtr inst, IntPtr window, IntPtr cursor)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnSetWindowCursor (GLib.Object.GetObject(window) as Gdk.Window, GLib.Object.GetObject(cursor) as Gdk.Cursor);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideSetWindowCursor")]
		protected virtual void OnSetWindowCursor (Gdk.Window window, Gdk.Cursor cursor)
		{
			InternalSetWindowCursor (window, cursor);
		}

		private void InternalSetWindowCursor (Gdk.Window window, Gdk.Cursor cursor)
		{
			SetWindowCursorNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SetWindowCursor;
			if (unmanaged == null) return;

			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, cursor == null ? IntPtr.Zero : cursor.Handle);
		}

		static WarpNativeDelegate Warp_cb_delegate;
		static WarpNativeDelegate WarpVMCallback {
			get {
				if (Warp_cb_delegate == null)
					Warp_cb_delegate = new WarpNativeDelegate (Warp_cb);
				return Warp_cb_delegate;
			}
		}

		static void OverrideWarp (GLib.GType gtype)
		{
			OverrideWarp (gtype, WarpVMCallback);
		}

		static void OverrideWarp (GLib.GType gtype, WarpNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.Warp = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WarpNativeDelegate (IntPtr inst, IntPtr screen, double x, double y);

		static void Warp_cb (IntPtr inst, IntPtr screen, double x, double y)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnWarp (GLib.Object.GetObject(screen) as Gdk.Screen, x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideWarp")]
		protected virtual void OnWarp (Gdk.Screen screen, double x, double y)
		{
			InternalWarp (screen, x, y);
		}

		private void InternalWarp (Gdk.Screen screen, double x, double y)
		{
			WarpNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Warp;
			if (unmanaged == null) return;

			unmanaged (this.Handle, screen == null ? IntPtr.Zero : screen.Handle, x, y);
		}

		static QueryStateNativeDelegate QueryState_cb_delegate;
		static QueryStateNativeDelegate QueryStateVMCallback {
			get {
				if (QueryState_cb_delegate == null)
					QueryState_cb_delegate = new QueryStateNativeDelegate (QueryState_cb);
				return QueryState_cb_delegate;
			}
		}

		static void OverrideQueryState (GLib.GType gtype)
		{
			OverrideQueryState (gtype, QueryStateVMCallback);
		}

		static void OverrideQueryState (GLib.GType gtype, QueryStateNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.QueryState = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void QueryStateNativeDelegate (IntPtr inst, IntPtr window, IntPtr root_window, IntPtr child_window, out double root_x, out double root_y, out double win_x, out double win_y, out int mask);

		static void QueryState_cb (IntPtr inst, IntPtr window, IntPtr root_window, IntPtr child_window, out double root_x, out double root_y, out double win_x, out double win_y, out int mask)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				Gdk.ModifierType mymask;
				__obj.OnQueryState (GLib.Object.GetObject(window) as Gdk.Window, GLib.Object.GetObject(root_window) as Gdk.Window, GLib.Object.GetObject(child_window) as Gdk.Window, out root_x, out root_y, out win_x, out win_y, out mymask);
				mask = (int) mymask;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideQueryState")]
		protected virtual void OnQueryState (Gdk.Window window, Gdk.Window root_window, Gdk.Window child_window, out double root_x, out double root_y, out double win_x, out double win_y, out Gdk.ModifierType mask)
		{
			InternalQueryState (window, root_window, child_window, out root_x, out root_y, out win_x, out win_y, out mask);
		}

		private void InternalQueryState (Gdk.Window window, Gdk.Window root_window, Gdk.Window child_window, out double root_x, out double root_y, out double win_x, out double win_y, out Gdk.ModifierType mask)
		{
			QueryStateNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).QueryState;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			int native_mask;
			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, root_window == null ? IntPtr.Zero : root_window.Handle, child_window == null ? IntPtr.Zero : child_window.Handle, out root_x, out root_y, out win_x, out win_y, out native_mask);
			mask = (Gdk.ModifierType) native_mask;
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
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.Grab = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GrabNativeDelegate (IntPtr inst, IntPtr window, bool owner_events, int event_mask, IntPtr confine_to, IntPtr cursor, uint time_);

		static int Grab_cb (IntPtr inst, IntPtr window, bool owner_events, int event_mask, IntPtr confine_to, IntPtr cursor, uint time_)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				Gdk.GrabStatus __result;
				__result = __obj.OnGrab (GLib.Object.GetObject(window) as Gdk.Window, owner_events, (Gdk.EventMask) event_mask, GLib.Object.GetObject(confine_to) as Gdk.Window, GLib.Object.GetObject(cursor) as Gdk.Cursor, time_);
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideGrab")]
		protected virtual Gdk.GrabStatus OnGrab (Gdk.Window window, bool owner_events, Gdk.EventMask event_mask, Gdk.Window confine_to, Gdk.Cursor cursor, uint time_)
		{
			return InternalGrab (window, owner_events, event_mask, confine_to, cursor, time_);
		}

		private Gdk.GrabStatus InternalGrab (Gdk.Window window, bool owner_events, Gdk.EventMask event_mask, Gdk.Window confine_to, Gdk.Cursor cursor, uint time_)
		{
			GrabNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Grab;
			if (unmanaged == null) return (Gdk.GrabStatus) 0;

			int __result = unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, owner_events, (int) event_mask, confine_to == null ? IntPtr.Zero : confine_to.Handle, cursor == null ? IntPtr.Zero : cursor.Handle, time_);
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
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.Ungrab = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UngrabNativeDelegate (IntPtr inst, uint time_);

		static void Ungrab_cb (IntPtr inst, uint time_)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnUngrab (time_);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideUngrab")]
		protected virtual void OnUngrab (uint time_)
		{
			InternalUngrab (time_);
		}

		private void InternalUngrab (uint time_)
		{
			UngrabNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Ungrab;
			if (unmanaged == null) return;

			unmanaged (this.Handle, time_);
		}

		static WindowAtPositionNativeDelegate WindowAtPosition_cb_delegate;
		static WindowAtPositionNativeDelegate WindowAtPositionVMCallback {
			get {
				if (WindowAtPosition_cb_delegate == null)
					WindowAtPosition_cb_delegate = new WindowAtPositionNativeDelegate (WindowAtPosition_cb);
				return WindowAtPosition_cb_delegate;
			}
		}

		static void OverrideWindowAtPosition (GLib.GType gtype)
		{
			OverrideWindowAtPosition (gtype, WindowAtPositionVMCallback);
		}

		static void OverrideWindowAtPosition (GLib.GType gtype, WindowAtPositionNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.WindowAtPosition = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr WindowAtPositionNativeDelegate (IntPtr inst, out double win_x, out double win_y, out int mask, bool get_toplevel);

		static IntPtr WindowAtPosition_cb (IntPtr inst, out double win_x, out double win_y, out int mask, bool get_toplevel)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				Gdk.Window __result;
				Gdk.ModifierType mymask;
				__result = __obj.OnWindowAtPosition (out win_x, out win_y, out mymask, get_toplevel);
				mask = (int) mymask;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideWindowAtPosition")]
		protected virtual Gdk.Window OnWindowAtPosition (out double win_x, out double win_y, out Gdk.ModifierType mask, bool get_toplevel)
		{
			return InternalWindowAtPosition (out win_x, out win_y, out mask, get_toplevel);
		}

		private Gdk.Window InternalWindowAtPosition (out double win_x, out double win_y, out Gdk.ModifierType mask, bool get_toplevel)
		{
			WindowAtPositionNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).WindowAtPosition;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			int native_mask;
			IntPtr __result = unmanaged (this.Handle, out win_x, out win_y, out native_mask, get_toplevel);
			mask = (Gdk.ModifierType) native_mask;
			return GLib.Object.GetObject(__result) as Gdk.Window;
		}

		static SelectWindowEventsNativeDelegate SelectWindowEvents_cb_delegate;
		static SelectWindowEventsNativeDelegate SelectWindowEventsVMCallback {
			get {
				if (SelectWindowEvents_cb_delegate == null)
					SelectWindowEvents_cb_delegate = new SelectWindowEventsNativeDelegate (SelectWindowEvents_cb);
				return SelectWindowEvents_cb_delegate;
			}
		}

		static void OverrideSelectWindowEvents (GLib.GType gtype)
		{
			OverrideSelectWindowEvents (gtype, SelectWindowEventsVMCallback);
		}

		static void OverrideSelectWindowEvents (GLib.GType gtype, SelectWindowEventsNativeDelegate callback)
		{
			GdkDeviceClass class_iface = GetClassStruct (gtype, false);
			class_iface.SelectWindowEvents = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectWindowEventsNativeDelegate (IntPtr inst, IntPtr window, int event_mask);

		static void SelectWindowEvents_cb (IntPtr inst, IntPtr window, int event_mask)
		{
			try {
				Device __obj = GLib.Object.GetObject (inst, false) as Device;
				__obj.OnSelectWindowEvents (GLib.Object.GetObject(window) as Gdk.Window, (Gdk.EventMask) event_mask);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gdk.Device), ConnectionMethod="OverrideSelectWindowEvents")]
		protected virtual void OnSelectWindowEvents (Gdk.Window window, Gdk.EventMask event_mask)
		{
			InternalSelectWindowEvents (window, event_mask);
		}

		private void InternalSelectWindowEvents (Gdk.Window window, Gdk.EventMask event_mask)
		{
			SelectWindowEventsNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SelectWindowEvents;
			if (unmanaged == null) return;

			unmanaged (this.Handle, window == null ? IntPtr.Zero : window.Handle, (int) event_mask);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GdkDeviceClass {
			public GetHistoryNativeDelegate GetHistory;
			public GetStateNativeDelegate GetState;
			public SetWindowCursorNativeDelegate SetWindowCursor;
			public WarpNativeDelegate Warp;
			public QueryStateNativeDelegate QueryState;
			public GrabNativeDelegate Grab;
			public UngrabNativeDelegate Ungrab;
			public WindowAtPositionNativeDelegate WindowAtPosition;
			public SelectWindowEventsNativeDelegate SelectWindowEvents;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GdkDeviceClass> class_structs;

		static GdkDeviceClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GdkDeviceClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GdkDeviceClass class_struct = (GdkDeviceClass) Marshal.PtrToStructure (class_ptr, typeof (GdkDeviceClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GdkDeviceClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_get_axis(IntPtr raw, double[] axes, int use, out double value);

		public bool GetAxis(double[] axes, Gdk.AxisUse use, out double value) {
			bool raw_ret = gdk_device_get_axis(Handle, axes, (int) use, out value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_axis_use(IntPtr raw, uint index_);

		public Gdk.AxisUse GetAxisUse(uint index_) {
			int raw_ret = gdk_device_get_axis_use(Handle, index_);
			Gdk.AxisUse ret = (Gdk.AxisUse) raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_get_axis_value(IntPtr raw, out double axes, IntPtr axis_label, out double value);

		public bool GetAxisValue(out double axes, Gdk.Atom axis_label, out double value) {
			bool raw_ret = gdk_device_get_axis_value(Handle, out axes, axis_label == null ? IntPtr.Zero : axis_label.Handle, out value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_device_type(IntPtr raw);

		public Gdk.DeviceType DeviceType { 
			get {
				int raw_ret = gdk_device_get_device_type(Handle);
				Gdk.DeviceType ret = (Gdk.DeviceType) raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_get_key(IntPtr raw, uint index_, out uint keyval, out int modifiers);

		public bool GetKey(uint index_, out uint keyval, out Gdk.ModifierType modifiers) {
			int native_modifiers;
			bool raw_ret = gdk_device_get_key(Handle, index_, out keyval, out native_modifiers);
			bool ret = raw_ret;
			modifiers = (Gdk.ModifierType) native_modifiers;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_last_event_window(IntPtr raw);

		public Gdk.Window LastEventWindow { 
			get {
				IntPtr raw_ret = gdk_device_get_last_event_window(Handle);
				Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_mode(IntPtr raw);

		public Gdk.InputMode Mode { 
			get {
				int raw_ret = gdk_device_get_mode(Handle);
				Gdk.InputMode ret = (Gdk.InputMode) raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_n_keys(IntPtr raw);

		public int NKeys { 
			get {
				int raw_ret = gdk_device_get_n_keys(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_get_position(IntPtr raw, IntPtr screen, out int x, out int y);

		public void GetPosition(Gdk.Screen screen, out int x, out int y) {
			gdk_device_get_position(Handle, screen == null ? IntPtr.Zero : screen.Handle, out x, out y);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_get_position_double(IntPtr raw, IntPtr screen, out double x, out double y);

		public void GetPositionDouble(Gdk.Screen screen, out double x, out double y) {
			gdk_device_get_position_double(Handle, screen == null ? IntPtr.Zero : screen.Handle, out x, out y);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_get_source(IntPtr raw);

		public Gdk.InputSource Source { 
			get {
				int raw_ret = gdk_device_get_source(Handle);
				Gdk.InputSource ret = (Gdk.InputSource) raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_get_state(IntPtr raw, IntPtr window, out double axes, out int mask);

		public void GetState(Gdk.Window window, out double axes, out Gdk.ModifierType mask) {
			int native_mask;
			gdk_device_get_state(Handle, window == null ? IntPtr.Zero : window.Handle, out axes, out native_mask);
			mask = (Gdk.ModifierType) native_mask;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_device_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_window_at_position(IntPtr raw, out int win_x, out int win_y);

		public Gdk.Window GetWindowAtPosition(out int win_x, out int win_y) {
			IntPtr raw_ret = gdk_device_get_window_at_position(Handle, out win_x, out win_y);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_get_window_at_position_double(IntPtr raw, out double win_x, out double win_y);

		public Gdk.Window GetWindowAtPositionDouble(out double win_x, out double win_y) {
			IntPtr raw_ret = gdk_device_get_window_at_position_double(Handle, out win_x, out win_y);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_grab(IntPtr raw, IntPtr window, int grab_ownership, bool owner_events, int event_mask, IntPtr cursor, uint time_);

		[Obsolete]
		public Gdk.GrabStatus Grab(Gdk.Window window, Gdk.GrabOwnership grab_ownership, bool owner_events, Gdk.EventMask event_mask, Gdk.Cursor cursor, uint time_) {
			int raw_ret = gdk_device_grab(Handle, window == null ? IntPtr.Zero : window.Handle, (int) grab_ownership, owner_events, (int) event_mask, cursor == null ? IntPtr.Zero : cursor.Handle, time_);
			Gdk.GrabStatus ret = (Gdk.GrabStatus) raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_grab_info_libgtk_only(IntPtr display, IntPtr device, IntPtr grab_window, out bool owner_events);

		[Obsolete]
		public static bool GrabInfoLibgtkOnly(Gdk.Display display, Gdk.Device device, Gdk.Window grab_window, out bool owner_events) {
			bool raw_ret = gdk_device_grab_info_libgtk_only(display == null ? IntPtr.Zero : display.Handle, device == null ? IntPtr.Zero : device.Handle, grab_window == null ? IntPtr.Zero : grab_window.Handle, out owner_events);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_list_axes(IntPtr raw);

		public Gdk.Atom[] ListAxes() {
			IntPtr raw_ret = gdk_device_list_axes(Handle);
			Gdk.Atom[] ret = (Gdk.Atom[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(Gdk.Atom));
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_list_slave_devices(IntPtr raw);

		public Gdk.Device[] ListSlaveDevices() {
			IntPtr raw_ret = gdk_device_list_slave_devices(Handle);
			Gdk.Device[] ret = (Gdk.Device[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(Gdk.Device));
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_set_axis_use(IntPtr raw, uint index_, int use);

		public void SetAxisUse(uint index_, Gdk.AxisUse use) {
			gdk_device_set_axis_use(Handle, index_, (int) use);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_set_key(IntPtr raw, uint index_, uint keyval, int modifiers);

		public void SetKey(uint index_, uint keyval, Gdk.ModifierType modifiers) {
			gdk_device_set_key(Handle, index_, keyval, (int) modifiers);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_device_set_mode(IntPtr raw, int mode);

		public bool SetMode(Gdk.InputMode mode) {
			bool raw_ret = gdk_device_set_mode(Handle, (int) mode);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_ungrab(IntPtr raw, uint time_);

		[Obsolete]
		public void Ungrab(uint time_) {
			gdk_device_ungrab(Handle, time_);
		}

		[DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_device_warp(IntPtr raw, IntPtr screen, int x, int y);

		public void Warp(Gdk.Screen screen, int x, int y) {
			gdk_device_warp(Handle, screen == null ? IntPtr.Zero : screen.Handle, x, y);
		}

#endregion
	}
}
