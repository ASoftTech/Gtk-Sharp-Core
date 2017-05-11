// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AboutDialog : Gtk.Dialog {

		public AboutDialog (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_new();

		public AboutDialog () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (AboutDialog)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_about_dialog_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_program_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_program_name(IntPtr raw, IntPtr name);

		[GLib.Property ("program-name")]
		public string ProgramName {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_program_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_program_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_version(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_version(IntPtr raw, IntPtr version);

		[GLib.Property ("version")]
		public string Version {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_version(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_version(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_copyright(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_copyright(IntPtr raw, IntPtr copyright);

		[GLib.Property ("copyright")]
		public string Copyright {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_copyright(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_copyright(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_comments(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_comments(IntPtr raw, IntPtr comments);

		[GLib.Property ("comments")]
		public string Comments {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_comments(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_comments(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_license(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_license(IntPtr raw, IntPtr license);

		[GLib.Property ("license")]
		public string License {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_license(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_license(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_about_dialog_get_license_type(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_license_type(IntPtr raw, int license_type);

		[GLib.Property ("license-type")]
		public Gtk.License LicenseType {
			get  {
				int raw_ret = gtk_about_dialog_get_license_type(Handle);
				Gtk.License ret = (Gtk.License) raw_ret;
				return ret;
			}
			set  {
				gtk_about_dialog_set_license_type(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_website(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_website(IntPtr raw, IntPtr website);

		[GLib.Property ("website")]
		public string Website {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_website(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_website(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_website_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_website_label(IntPtr raw, IntPtr website_label);

		[GLib.Property ("website-label")]
		public string WebsiteLabel {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_website_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_website_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_authors(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_authors(IntPtr raw, IntPtr[] authors);

		[GLib.Property ("authors")]
		public string[] Authors {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_authors(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
			set  {
				int cnt_value = value == null ? 0 : value.Length;
				IntPtr[] native_value = new IntPtr [cnt_value + 1];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = GLib.Marshaller.StringToPtrGStrdup (value[i]);
				native_value [cnt_value] = IntPtr.Zero;
				gtk_about_dialog_set_authors(Handle, native_value);
				for (int i = 0; i < native_value.Length - 1; i++) {
					value [i] = GLib.Marshaller.Utf8PtrToString (native_value[i]);
					GLib.Marshaller.Free (native_value[i]);
				}
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_documenters(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_documenters(IntPtr raw, IntPtr[] documenters);

		[GLib.Property ("documenters")]
		public string[] Documenters {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_documenters(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
			set  {
				int cnt_value = value == null ? 0 : value.Length;
				IntPtr[] native_value = new IntPtr [cnt_value + 1];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = GLib.Marshaller.StringToPtrGStrdup (value[i]);
				native_value [cnt_value] = IntPtr.Zero;
				gtk_about_dialog_set_documenters(Handle, native_value);
				for (int i = 0; i < native_value.Length - 1; i++) {
					value [i] = GLib.Marshaller.Utf8PtrToString (native_value[i]);
					GLib.Marshaller.Free (native_value[i]);
				}
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_artists(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_artists(IntPtr raw, IntPtr[] artists);

		[GLib.Property ("artists")]
		public string[] Artists {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_artists(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
			set  {
				int cnt_value = value == null ? 0 : value.Length;
				IntPtr[] native_value = new IntPtr [cnt_value + 1];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = GLib.Marshaller.StringToPtrGStrdup (value[i]);
				native_value [cnt_value] = IntPtr.Zero;
				gtk_about_dialog_set_artists(Handle, native_value);
				for (int i = 0; i < native_value.Length - 1; i++) {
					value [i] = GLib.Marshaller.Utf8PtrToString (native_value[i]);
					GLib.Marshaller.Free (native_value[i]);
				}
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_translator_credits(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_translator_credits(IntPtr raw, IntPtr translator_credits);

		[GLib.Property ("translator-credits")]
		public string TranslatorCredits {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_translator_credits(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_translator_credits(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_logo(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_logo(IntPtr raw, IntPtr logo);

		[GLib.Property ("logo")]
		public Gdk.Pixbuf Logo {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_logo(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
			set  {
				gtk_about_dialog_set_logo(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_logo_icon_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_logo_icon_name(IntPtr raw, IntPtr icon_name);

		[GLib.Property ("logo-icon-name")]
		public string LogoIconName {
			get  {
				IntPtr raw_ret = gtk_about_dialog_get_logo_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_about_dialog_set_logo_icon_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_about_dialog_get_wrap_license(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_set_wrap_license(IntPtr raw, bool wrap_license);

		[GLib.Property ("wrap-license")]
		public bool WrapLicense {
			get  {
				bool raw_ret = gtk_about_dialog_get_wrap_license(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_about_dialog_set_wrap_license(Handle, value);
			}
		}

		[GLib.Signal("activate-link")]
		public event Gtk.ActivateLinkHandler ActivateLink {
			add {
				this.AddSignalHandler ("activate-link", value, typeof (Gtk.ActivateLinkArgs));
			}
			remove {
				this.RemoveSignalHandler ("activate-link", value);
			}
		}

		static ActivateLinkNativeDelegate ActivateLink_cb_delegate;
		static ActivateLinkNativeDelegate ActivateLinkVMCallback {
			get {
				if (ActivateLink_cb_delegate == null)
					ActivateLink_cb_delegate = new ActivateLinkNativeDelegate (ActivateLink_cb);
				return ActivateLink_cb_delegate;
			}
		}

		static void OverrideActivateLink (GLib.GType gtype)
		{
			OverrideActivateLink (gtype, ActivateLinkVMCallback);
		}

		static void OverrideActivateLink (GLib.GType gtype, ActivateLinkNativeDelegate callback)
		{
			GtkAboutDialogClass class_iface = GetClassStruct (gtype, false);
			class_iface.ActivateLink = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ActivateLinkNativeDelegate (IntPtr inst, IntPtr uri);

		static bool ActivateLink_cb (IntPtr inst, IntPtr uri)
		{
			try {
				AboutDialog __obj = GLib.Object.GetObject (inst, false) as AboutDialog;
				bool __result;
				__result = __obj.OnActivateLink (GLib.Marshaller.Utf8PtrToString (uri));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.AboutDialog), ConnectionMethod="OverrideActivateLink")]
		protected virtual bool OnActivateLink (string uri)
		{
			return InternalActivateLink (uri);
		}

		private bool InternalActivateLink (string uri)
		{
			ActivateLinkNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ActivateLink;
			if (unmanaged == null) return false;

			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			bool __result = unmanaged (this.Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
			return __result;
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkAboutDialogClass {
			public ActivateLinkNativeDelegate ActivateLink;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Dialog)).GetClassSize ();
		static Dictionary<GLib.GType, GtkAboutDialogClass> class_structs;

		static GtkAboutDialogClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkAboutDialogClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkAboutDialogClass class_struct = (GtkAboutDialogClass) Marshal.PtrToStructure (class_ptr, typeof (GtkAboutDialogClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkAboutDialogClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_about_dialog_add_credit_section(IntPtr raw, IntPtr section_name, IntPtr people);

		public void AddCreditSection(string section_name, string people) {
			IntPtr native_section_name = GLib.Marshaller.StringToPtrGStrdup (section_name);
			IntPtr native_people = GLib.Marshaller.StringToPtrGStrdup (people);
			gtk_about_dialog_add_credit_section(Handle, native_section_name, native_people);
			GLib.Marshaller.Free (native_section_name);
			GLib.Marshaller.Free (native_people);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_about_dialog_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_about_dialog_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
