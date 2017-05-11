// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GestureMultiPress : Gtk.GestureSingle {

		public GestureMultiPress (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_multi_press_new(IntPtr widget);

		public GestureMultiPress (Gtk.Widget widget) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GestureMultiPress)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (widget != null) {
					names.Add ("widget");
					vals.Add (new GLib.Value (widget));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_gesture_multi_press_new(widget == null ? IntPtr.Zero : widget.Handle);
		}

		[GLib.Signal("stopped")]
		public event System.EventHandler Stopped {
			add {
				this.AddSignalHandler ("stopped", value);
			}
			remove {
				this.RemoveSignalHandler ("stopped", value);
			}
		}

		[GLib.Signal("pressed")]
		public event Gtk.PressedHandler Pressed {
			add {
				this.AddSignalHandler ("pressed", value, typeof (Gtk.PressedArgs));
			}
			remove {
				this.RemoveSignalHandler ("pressed", value);
			}
		}

		[GLib.Signal("released")]
		public event Gtk.ReleasedHandler Released {
			add {
				this.AddSignalHandler ("released", value, typeof (Gtk.ReleasedArgs));
			}
			remove {
				this.RemoveSignalHandler ("released", value);
			}
		}

		static PressedNativeDelegate Pressed_cb_delegate;
		static PressedNativeDelegate PressedVMCallback {
			get {
				if (Pressed_cb_delegate == null)
					Pressed_cb_delegate = new PressedNativeDelegate (Pressed_cb);
				return Pressed_cb_delegate;
			}
		}

		static void OverridePressed (GLib.GType gtype)
		{
			OverridePressed (gtype, PressedVMCallback);
		}

		static void OverridePressed (GLib.GType gtype, PressedNativeDelegate callback)
		{
			GtkGestureMultiPressClass class_iface = GetClassStruct (gtype, false);
			class_iface.Pressed = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PressedNativeDelegate (IntPtr inst, int n_press, double x, double y);

		static void Pressed_cb (IntPtr inst, int n_press, double x, double y)
		{
			try {
				GestureMultiPress __obj = GLib.Object.GetObject (inst, false) as GestureMultiPress;
				__obj.OnPressed (n_press, x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GestureMultiPress), ConnectionMethod="OverridePressed")]
		protected virtual void OnPressed (int n_press, double x, double y)
		{
			InternalPressed (n_press, x, y);
		}

		private void InternalPressed (int n_press, double x, double y)
		{
			PressedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Pressed;
			if (unmanaged == null) return;

			unmanaged (this.Handle, n_press, x, y);
		}

		static ReleasedNativeDelegate Released_cb_delegate;
		static ReleasedNativeDelegate ReleasedVMCallback {
			get {
				if (Released_cb_delegate == null)
					Released_cb_delegate = new ReleasedNativeDelegate (Released_cb);
				return Released_cb_delegate;
			}
		}

		static void OverrideReleased (GLib.GType gtype)
		{
			OverrideReleased (gtype, ReleasedVMCallback);
		}

		static void OverrideReleased (GLib.GType gtype, ReleasedNativeDelegate callback)
		{
			GtkGestureMultiPressClass class_iface = GetClassStruct (gtype, false);
			class_iface.Released = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReleasedNativeDelegate (IntPtr inst, int n_press, double x, double y);

		static void Released_cb (IntPtr inst, int n_press, double x, double y)
		{
			try {
				GestureMultiPress __obj = GLib.Object.GetObject (inst, false) as GestureMultiPress;
				__obj.OnReleased (n_press, x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GestureMultiPress), ConnectionMethod="OverrideReleased")]
		protected virtual void OnReleased (int n_press, double x, double y)
		{
			InternalReleased (n_press, x, y);
		}

		private void InternalReleased (int n_press, double x, double y)
		{
			ReleasedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Released;
			if (unmanaged == null) return;

			unmanaged (this.Handle, n_press, x, y);
		}

		static StoppedNativeDelegate Stopped_cb_delegate;
		static StoppedNativeDelegate StoppedVMCallback {
			get {
				if (Stopped_cb_delegate == null)
					Stopped_cb_delegate = new StoppedNativeDelegate (Stopped_cb);
				return Stopped_cb_delegate;
			}
		}

		static void OverrideStopped (GLib.GType gtype)
		{
			OverrideStopped (gtype, StoppedVMCallback);
		}

		static void OverrideStopped (GLib.GType gtype, StoppedNativeDelegate callback)
		{
			GtkGestureMultiPressClass class_iface = GetClassStruct (gtype, false);
			class_iface.Stopped = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StoppedNativeDelegate (IntPtr inst);

		static void Stopped_cb (IntPtr inst)
		{
			try {
				GestureMultiPress __obj = GLib.Object.GetObject (inst, false) as GestureMultiPress;
				__obj.OnStopped ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.GestureMultiPress), ConnectionMethod="OverrideStopped")]
		protected virtual void OnStopped ()
		{
			InternalStopped ();
		}

		private void InternalStopped ()
		{
			StoppedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Stopped;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkGestureMultiPressClass {
			public PressedNativeDelegate Pressed;
			public ReleasedNativeDelegate Released;
			public StoppedNativeDelegate Stopped;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=10)]
			private IntPtr[] Padding;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.GestureSingle)).GetClassSize ();
		static Dictionary<GLib.GType, GtkGestureMultiPressClass> class_structs;

		static GtkGestureMultiPressClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkGestureMultiPressClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkGestureMultiPressClass class_struct = (GtkGestureMultiPressClass) Marshal.PtrToStructure (class_ptr, typeof (GtkGestureMultiPressClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkGestureMultiPressClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_gesture_multi_press_get_area(IntPtr raw, IntPtr rect);

		public bool GetArea(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			bool raw_ret = gtk_gesture_multi_press_get_area(Handle, native_rect);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_rect);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_gesture_multi_press_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_gesture_multi_press_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_gesture_multi_press_set_area(IntPtr raw, IntPtr rect);

		public void SetArea(Gdk.Rectangle rect) {
			IntPtr native_rect = GLib.Marshaller.StructureToPtrAlloc (rect);
			gtk_gesture_multi_press_set_area(Handle, native_rect);
			Marshal.FreeHGlobal (native_rect);
		}

#endregion
	}
}
