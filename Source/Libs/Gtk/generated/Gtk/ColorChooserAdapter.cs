// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ColorChooserAdapter : GLib.GInterfaceAdapter, Gtk.IColorChooser {

		[StructLayout (LayoutKind.Sequential)]
		struct GtkColorChooserInterface {
			public AddPaletteNativeDelegate AddPalette;
			IntPtr ColorActivated;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=12)]
			private IntPtr[] Padding;
		}

		static GtkColorChooserInterface iface;

		static ColorChooserAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (ColorChooserAdapter));
			iface.AddPalette = new AddPaletteNativeDelegate (AddPalette_cb);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AddPaletteNativeDelegate (IntPtr inst, int orientation, int colors_per_line, int n_colors, IntPtr colors);

		static void AddPalette_cb (IntPtr inst, int orientation, int colors_per_line, int n_colors, IntPtr colors)
		{
			try {
				IColorChooserImplementor __obj = GLib.Object.GetObject (inst, false) as IColorChooserImplementor;
				__obj.AddPalette ((Gtk.Orientation) orientation, colors_per_line, n_colors, Gdk.RGBA.New (colors));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		static int class_offset = 2 * IntPtr.Size;

		static void Initialize (IntPtr ptr, IntPtr data)
		{
			IntPtr ifaceptr = new IntPtr (ptr.ToInt64 () + class_offset);
			GtkColorChooserInterface native_iface = (GtkColorChooserInterface) Marshal.PtrToStructure (ifaceptr, typeof (GtkColorChooserInterface));
			native_iface.AddPalette = iface.AddPalette;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
		}

		GLib.Object implementor;

		public ColorChooserAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public ColorChooserAdapter (IColorChooserImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public ColorChooserAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_color_chooser_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_color_chooser_get_type ());

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

		public static IColorChooser GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IColorChooser GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IColorChooserImplementor)
				return new ColorChooserAdapter (obj as IColorChooserImplementor);
			else if (obj as IColorChooser == null)
				return new ColorChooserAdapter (obj.Handle);
			else
				return obj as IColorChooser;
		}

		public IColorChooserImplementor Implementor {
			get {
				return implementor as IColorChooserImplementor;
			}
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
				GLib.Object.GetObject (Handle).AddSignalHandler ("color-activated", value, typeof (Gtk.ColorActivatedArgs));
			}
			remove {
				GLib.Object.GetObject (Handle).RemoveSignalHandler ("color-activated", value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_color_chooser_add_palette(IntPtr raw, int orientation, int colors_per_line, int n_colors, IntPtr colors);

		public void AddPalette(Gtk.Orientation orientation, int colors_per_line, int n_colors, Gdk.RGBA colors) {
			IntPtr native_colors = GLib.Marshaller.StructureToPtrAlloc (colors);
			gtk_color_chooser_add_palette(Handle, (int) orientation, colors_per_line, n_colors, native_colors);
			Marshal.FreeHGlobal (native_colors);
		}

#endregion
	}
}
