// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CoreTextFont : Pango.Font {

		public CoreTextFont (IntPtr raw) : base(raw) {}

		protected CoreTextFont() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct PangoCoreTextFontClass {
			IntPtr PangoReserved1;
			IntPtr PangoReserved2;
			IntPtr PangoReserved3;
			IntPtr PangoReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Pango.Font)).GetClassSize ();
		static Dictionary<GLib.GType, PangoCoreTextFontClass> class_structs;

		static PangoCoreTextFontClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, PangoCoreTextFontClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				PangoCoreTextFontClass class_struct = (PangoCoreTextFontClass) Marshal.PtrToStructure (class_ptr, typeof (PangoCoreTextFontClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, PangoCoreTextFontClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_core_text_font_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_core_text_font_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
