// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TlsPassword : GLib.Object {

		public TlsPassword (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_password_new(int flags, IntPtr description);

		public TlsPassword (GLib.TlsPasswordFlags flags, string description) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TlsPassword)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("flags");
				vals.Add (new GLib.Value (flags));
				names.Add ("description");
				vals.Add (new GLib.Value (description));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_description = GLib.Marshaller.StringToPtrGStrdup (description);
			Raw = g_tls_password_new((int) flags, native_description);
			GLib.Marshaller.Free (native_description);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_tls_password_get_flags(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_tls_password_set_flags(IntPtr raw, int flags);

		[GLib.Property ("flags")]
		public GLib.TlsPasswordFlags Flags {
			get  {
				int raw_ret = g_tls_password_get_flags(Handle);
				GLib.TlsPasswordFlags ret = (GLib.TlsPasswordFlags) raw_ret;
				return ret;
			}
			set  {
				g_tls_password_set_flags(Handle, (int) value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_password_get_description(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_tls_password_set_description(IntPtr raw, IntPtr description);

		[GLib.Property ("description")]
		public string Description {
			get  {
				IntPtr raw_ret = g_tls_password_get_description(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_tls_password_set_description(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_password_get_warning(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_tls_password_set_warning(IntPtr raw, IntPtr warning);

		[GLib.Property ("warning")]
		public string Warning {
			get  {
				IntPtr raw_ret = g_tls_password_get_warning(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_tls_password_set_warning(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		static GetValueNativeDelegate GetValue_cb_delegate;
		static GetValueNativeDelegate GetValueVMCallback {
			get {
				if (GetValue_cb_delegate == null)
					GetValue_cb_delegate = new GetValueNativeDelegate (GetValue_cb);
				return GetValue_cb_delegate;
			}
		}

		static void OverrideGetValue (GLib.GType gtype)
		{
			OverrideGetValue (gtype, GetValueVMCallback);
		}

		static void OverrideGetValue (GLib.GType gtype, GetValueNativeDelegate callback)
		{
			GTlsPasswordClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetValue = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate byte GetValueNativeDelegate (IntPtr inst, out UIntPtr length);

		static byte GetValue_cb (IntPtr inst, out UIntPtr length)
		{
			try {
				TlsPassword __obj = GLib.Object.GetObject (inst, false) as TlsPassword;
				byte __result;
				ulong mylength;
				__result = __obj.OnGetValue (out mylength);
				length = new UIntPtr (mylength);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsPassword), ConnectionMethod="OverrideGetValue")]
		protected virtual byte OnGetValue (out ulong length)
		{
			return InternalGetValue (out length);
		}

		private byte InternalGetValue (out ulong length)
		{
			GetValueNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetValue;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			UIntPtr native_length;
			byte __result = unmanaged (this.Handle, out native_length);
			length = (ulong) native_length;
			return __result;
		}

		static SetValueNativeDelegate SetValue_cb_delegate;
		static SetValueNativeDelegate SetValueVMCallback {
			get {
				if (SetValue_cb_delegate == null)
					SetValue_cb_delegate = new SetValueNativeDelegate (SetValue_cb);
				return SetValue_cb_delegate;
			}
		}

		static void OverrideSetValue (GLib.GType gtype)
		{
			OverrideSetValue (gtype, SetValueVMCallback);
		}

		static void OverrideSetValue (GLib.GType gtype, SetValueNativeDelegate callback)
		{
			GTlsPasswordClass class_iface = GetClassStruct (gtype, false);
			class_iface.SetValue = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetValueNativeDelegate (IntPtr inst, out byte value, IntPtr length, GLib.DestroyNotify destroy);

		static void SetValue_cb (IntPtr inst, out byte value, IntPtr length, GLib.DestroyNotify destroy)
		{
			try {
				TlsPassword __obj = GLib.Object.GetObject (inst, false) as TlsPassword;
				__obj.OnSetValue (out value, (long) length, destroy);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsPassword), ConnectionMethod="OverrideSetValue")]
		protected virtual void OnSetValue (out byte value, long length, GLib.DestroyNotify destroy)
		{
			InternalSetValue (out value, length, destroy);
		}

		private void InternalSetValue (out byte value, long length, GLib.DestroyNotify destroy)
		{
			SetValueNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).SetValue;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, out value, new IntPtr (length), destroy);
		}

		static GetDefaultWarningNativeDelegate GetDefaultWarning_cb_delegate;
		static GetDefaultWarningNativeDelegate GetDefaultWarningVMCallback {
			get {
				if (GetDefaultWarning_cb_delegate == null)
					GetDefaultWarning_cb_delegate = new GetDefaultWarningNativeDelegate (GetDefaultWarning_cb);
				return GetDefaultWarning_cb_delegate;
			}
		}

		static void OverrideGetDefaultWarning (GLib.GType gtype)
		{
			OverrideGetDefaultWarning (gtype, GetDefaultWarningVMCallback);
		}

		static void OverrideGetDefaultWarning (GLib.GType gtype, GetDefaultWarningNativeDelegate callback)
		{
			GTlsPasswordClass class_iface = GetClassStruct (gtype, false);
			class_iface.GetDefaultWarning = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetDefaultWarningNativeDelegate (IntPtr inst);

		static IntPtr GetDefaultWarning_cb (IntPtr inst)
		{
			try {
				TlsPassword __obj = GLib.Object.GetObject (inst, false) as TlsPassword;
				string __result;
				__result = __obj.OnGetDefaultWarning ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.TlsPassword), ConnectionMethod="OverrideGetDefaultWarning")]
		protected virtual string OnGetDefaultWarning ()
		{
			return InternalGetDefaultWarning ();
		}

		private string InternalGetDefaultWarning ()
		{
			GetDefaultWarningNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).GetDefaultWarning;
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GTlsPasswordClass {
			public GetValueNativeDelegate GetValue;
			public SetValueNativeDelegate SetValue;
			public GetDefaultWarningNativeDelegate GetDefaultWarning;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			private IntPtr[] Padding;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GTlsPasswordClass> class_structs;

		static GTlsPasswordClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GTlsPasswordClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GTlsPasswordClass class_struct = (GTlsPasswordClass) Marshal.PtrToStructure (class_ptr, typeof (GTlsPasswordClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GTlsPasswordClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_tls_password_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_tls_password_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_tls_password_get_value(IntPtr raw, out UIntPtr length);

		public byte GetValue(out ulong length) {
			UIntPtr native_length;
			byte raw_ret = g_tls_password_get_value(Handle, out native_length);
			byte ret = raw_ret;
			length = (ulong) native_length;
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_tls_password_set_value(IntPtr raw, out byte value, IntPtr length);

		public byte SetValue(long length) {
			byte value;
			g_tls_password_set_value(Handle, out value, new IntPtr (length));
			return value;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_tls_password_set_value_full(IntPtr raw, out byte value, IntPtr length, GLib.DestroyNotify destroy);

		public byte SetValueFull(long length, GLib.DestroyNotify destroy) {
			byte value;
			g_tls_password_set_value_full(Handle, out value, new IntPtr (length), destroy);
			return value;
		}

#endregion
	}
}
