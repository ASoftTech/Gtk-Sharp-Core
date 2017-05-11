// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FontChooserAdapter : GLib.GInterfaceAdapter, Gtk.IFontChooser {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkFontChooserIface {
			public GetFontFamilyNativeDelegate GetFontFamily;
			public GetFontFaceNativeDelegate GetFontFace;
			public GetFontSizeNativeDelegate GetFontSize;
			public SetFilterFuncNativeDelegate SetFilterFunc;
			IntPtr FontActivated;
			public SetFontMapNativeDelegate SetFontMap;
			public GetFontMapNativeDelegate GetFontMap;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=10)]
			private IntPtr[] Padding;
		}

		static GtkFontChooserIface iface;

		static FontChooserAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (FontChooserAdapter));
			iface.GetFontFamily = new GetFontFamilyNativeDelegate (GetFontFamily_cb);
			iface.GetFontFace = new GetFontFaceNativeDelegate (GetFontFace_cb);
			iface.GetFontSize = new GetFontSizeNativeDelegate (GetFontSize_cb);
			iface.SetFilterFunc = new SetFilterFuncNativeDelegate (SetFilterFunc_cb);
			iface.SetFontMap = new SetFontMapNativeDelegate (SetFontMap_cb);
			iface.GetFontMap = new GetFontMapNativeDelegate (GetFontMap_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetFontFamilyNativeDelegate (IntPtr inst);

		static IntPtr GetFontFamily_cb (IntPtr inst)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				Pango.FontFamily __result;
				__result = __obj.FontFamily;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetFontFaceNativeDelegate (IntPtr inst);

		static IntPtr GetFontFace_cb (IntPtr inst)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				Pango.FontFace __result;
				__result = __obj.FontFace;
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetFontSizeNativeDelegate (IntPtr inst);

		static int GetFontSize_cb (IntPtr inst)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				int __result;
				__result = __obj.FontSize;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetFilterFuncNativeDelegate (IntPtr inst, GtkSharp.FontFilterFuncNative filter, IntPtr user_data, GLib.DestroyNotify destroy);

		static void SetFilterFunc_cb (IntPtr inst, GtkSharp.FontFilterFuncNative filter, IntPtr user_data, GLib.DestroyNotify destroy)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				GtkSharp.FontFilterFuncInvoker filter_invoker = new GtkSharp.FontFilterFuncInvoker (filter, user_data, destroy);
				__obj.FilterFunc = filter_invoker.Handler;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetFontMapNativeDelegate (IntPtr inst, IntPtr fontmap);

		static void SetFontMap_cb (IntPtr inst, IntPtr fontmap)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				__obj.FontMap = GLib.Object.GetObject(fontmap) as Pango.FontMap;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetFontMapNativeDelegate (IntPtr inst);

		static IntPtr GetFontMap_cb (IntPtr inst)
		{
			try {
				IFontChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IFontChooserImplementor;
				Pango.FontMap __result;
				__result = __obj.FontMap;
				return __result == null ? IntPtr.Zero : __result.Handle;
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
			GtkFontChooserIface native_iface = (GtkFontChooserIface) Marshal.PtrToStructure (ifaceptr, typeof (GtkFontChooserIface));
			native_iface.GetFontFamily = iface.GetFontFamily;
			native_iface.GetFontFace = iface.GetFontFace;
			native_iface.GetFontSize = iface.GetFontSize;
			native_iface.SetFilterFunc = iface.SetFilterFunc;
			native_iface.SetFontMap = iface.SetFontMap;
			native_iface.GetFontMap = iface.GetFontMap;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public FontChooserAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public FontChooserAdapter (IFontChooserImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public FontChooserAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_font_chooser_get_type ());

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

		public static IFontChooser GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IFontChooser GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IFontChooserImplementor)
				return new FontChooserAdapter (obj as IFontChooserImplementor);
			else if (obj as IFontChooser == null)
				return new FontChooserAdapter (obj.Handle);
			else
				return obj as IFontChooser;
		}

		public IFontChooserImplementor Implementor {
			get {
				return implementor as IFontChooserImplementor;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font(IntPtr raw, IntPtr fontname);

		[GLib.Property ("font")]
		public string Font {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_font(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_desc(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font_desc(IntPtr raw, IntPtr font_desc);

		[GLib.Property ("font-desc")]
		public Pango.FontDescription FontDesc {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_font_desc(Handle);
				Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
				return ret;
			}
			set  {
				gtk_font_chooser_set_font_desc(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_preview_text(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_preview_text(IntPtr raw, IntPtr text);

		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_chooser_get_preview_text(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_chooser_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_chooser_get_show_preview_entry(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_show_preview_entry(IntPtr raw, bool show_preview_entry);

		[GLib.Property ("show-preview-entry")]
		public bool ShowPreviewEntry {
			get  {
				bool raw_ret = gtk_font_chooser_get_show_preview_entry(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_font_chooser_set_show_preview_entry(Handle, value);
			}
		}

		[GLib.Signal("font-activated")]
		public event Gtk.FontActivatedHandler FontActivated {
			add {
				GLib.Object.GetObject (Handle).AddSignalHandler ("font-activated", value, typeof (Gtk.FontActivatedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("font-activated", value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_face(IntPtr raw);

		public Pango.FontFace FontFace { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_face(Handle);
				Pango.FontFace ret = GLib.Object.GetObject(raw_ret) as Pango.FontFace;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_family(IntPtr raw);

		public Pango.FontFamily FontFamily { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_family(Handle);
				Pango.FontFamily ret = GLib.Object.GetObject(raw_ret) as Pango.FontFamily;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_chooser_get_font_map(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_font_map(IntPtr raw, IntPtr fontmap);

		public Pango.FontMap FontMap { 
			get {
				IntPtr raw_ret = gtk_font_chooser_get_font_map(Handle);
				Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
				return ret;
			}
			set {
				gtk_font_chooser_set_font_map(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_font_chooser_get_font_size(IntPtr raw);

		public int FontSize { 
			get {
				int raw_ret = gtk_font_chooser_get_font_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_chooser_set_filter_func(IntPtr raw, GtkSharp.FontFilterFuncNative filter, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.FontFilterFunc FilterFunc { 
			set {
				GtkSharp.FontFilterFuncWrapper value_wrapper = new GtkSharp.FontFilterFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_font_chooser_set_filter_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

#endregion
	}
}
