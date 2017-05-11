// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class StreamableContentAdapter : GLib.GInterfaceAdapter, Atk.IStreamableContent {

		[StructLayout (LayoutKind.Sequential)]
		struct AtkStreamableContentIface {
			public GetNMimeTypesNativeDelegate GetNMimeTypes;
			public GetMimeTypeNativeDelegate GetMimeType;
			public GetStreamNativeDelegate GetStream;
			public GetUriNativeDelegate GetUri;
			private AtkSharp.FunctionNative pad2;
			public Atk.Function Pad2 {
				get {
					return AtkSharp.FunctionWrapper.GetManagedDelegate (pad2);
				}
			}
			private AtkSharp.FunctionNative pad3;
			public Atk.Function Pad3 {
				get {
					return AtkSharp.FunctionWrapper.GetManagedDelegate (pad3);
				}
			}
		}

		static AtkStreamableContentIface iface;

		static StreamableContentAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (StreamableContentAdapter));
			iface.GetNMimeTypes = new GetNMimeTypesNativeDelegate (GetNMimeTypes_cb);
			iface.GetMimeType = new GetMimeTypeNativeDelegate (GetMimeType_cb);
			iface.GetStream = new GetStreamNativeDelegate (GetStream_cb);
			iface.GetUri = new GetUriNativeDelegate (GetUri_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNMimeTypesNativeDelegate (IntPtr inst);

		static int GetNMimeTypes_cb (IntPtr inst)
		{
			try {
				IStreamableContentImplementor __obj = GLib.Object.GetObject (inst, false) as IStreamableContentImplementor;
				int __result;
				__result = __obj.NMimeTypes;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetMimeTypeNativeDelegate (IntPtr inst, int i);

		static IntPtr GetMimeType_cb (IntPtr inst, int i)
		{
			try {
				IStreamableContentImplementor __obj = GLib.Object.GetObject (inst, false) as IStreamableContentImplementor;
				string __result;
				__result = __obj.GetMimeType (i);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetStreamNativeDelegate (IntPtr inst, IntPtr mime_type);

		static IntPtr GetStream_cb (IntPtr inst, IntPtr mime_type)
		{
			try {
				IStreamableContentImplementor __obj = GLib.Object.GetObject (inst, false) as IStreamableContentImplementor;
				IntPtr __result;
				__result = __obj.GetStream (GLib.Marshaller.Utf8PtrToString (mime_type));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetUriNativeDelegate (IntPtr inst, IntPtr mime_type);

		static IntPtr GetUri_cb (IntPtr inst, IntPtr mime_type)
		{
			try {
				IStreamableContentImplementor __obj = GLib.Object.GetObject (inst, false) as IStreamableContentImplementor;
				string __result;
				__result = __obj.GetUri (GLib.Marshaller.Utf8PtrToString (mime_type));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			AtkStreamableContentIface native_iface = (AtkStreamableContentIface) Marshal.PtrToStructure (ifaceptr, typeof (AtkStreamableContentIface));
			native_iface.GetNMimeTypes = iface.GetNMimeTypes;
			native_iface.GetMimeType = iface.GetMimeType;
			native_iface.GetStream = iface.GetStream;
			native_iface.GetUri = iface.GetUri;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public StreamableContentAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public StreamableContentAdapter (IStreamableContentImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public StreamableContentAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_streamable_content_get_type();

		private static GLib.GType _gtype = new GLib.GType (atk_streamable_content_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IStreamableContent GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IStreamableContent GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IStreamableContentImplementor)
				return new StreamableContentAdapter (obj as IStreamableContentImplementor);
			else if (obj as IStreamableContent == null)
				return new StreamableContentAdapter (obj.Handle);
			else
				return obj as IStreamableContent;
		}

		public IStreamableContentImplementor Implementor {
			get {
				return implementor as IStreamableContentImplementor;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_streamable_content_get_mime_type(IntPtr raw, int i);

		public string GetMimeType(int i) {
			IntPtr raw_ret = atk_streamable_content_get_mime_type(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_streamable_content_get_n_mime_types(IntPtr raw);

		public int NMimeTypes { 
			get {
				int raw_ret = atk_streamable_content_get_n_mime_types(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_streamable_content_get_stream(IntPtr raw, IntPtr mime_type);

		public IntPtr GetStream(string mime_type) {
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			IntPtr raw_ret = atk_streamable_content_get_stream(Handle, native_mime_type);
			IntPtr ret = raw_ret;
			GLib.Marshaller.Free (native_mime_type);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_streamable_content_get_uri(IntPtr raw, IntPtr mime_type);

		public string GetUri(string mime_type) {
			IntPtr native_mime_type = GLib.Marshaller.StringToPtrGStrdup (mime_type);
			IntPtr raw_ret = atk_streamable_content_get_uri(Handle, native_mime_type);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_mime_type);
			return ret;
		}

#endregion
	}
}
