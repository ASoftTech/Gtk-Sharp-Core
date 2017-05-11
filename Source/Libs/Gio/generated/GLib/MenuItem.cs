// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuItem : GLib.Object {

		public MenuItem (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_new(IntPtr label, IntPtr detailed_action);

		public MenuItem (string label, string detailed_action) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuItem)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			IntPtr native_detailed_action = GLib.Marshaller.StringToPtrGStrdup (detailed_action);
			Raw = g_menu_item_new(native_label, native_detailed_action);
			GLib.Marshaller.Free (native_label);
			GLib.Marshaller.Free (native_detailed_action);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_new_from_model(IntPtr model, int item_index);

		public MenuItem (GLib.MenuModel model, int item_index) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuItem)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = g_menu_item_new_from_model(model == null ? IntPtr.Zero : model.Handle, item_index);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_new_section(IntPtr label, IntPtr section);

		public MenuItem (string label, GLib.MenuModel section) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuItem)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = g_menu_item_new_section(native_label, section == null ? IntPtr.Zero : section.Handle);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_new_submenu(IntPtr label, IntPtr submenu);

		public static MenuItem NewSubmenu(string label, GLib.MenuModel submenu)
		{
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			MenuItem result = new MenuItem (g_menu_item_new_submenu(native_label, submenu == null ? IntPtr.Zero : submenu.Handle));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_get_attribute_value(IntPtr raw, IntPtr attribute, IntPtr expected_type);

		public GLib.Variant GetAttributeValue(string attribute, GLib.VariantType expected_type) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_menu_item_get_attribute_value(Handle, native_attribute, expected_type == null ? IntPtr.Zero : expected_type.Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_get_link(IntPtr raw, IntPtr link);

		public GLib.MenuModel GetLink(string link) {
			IntPtr native_link = GLib.Marshaller.StringToPtrGStrdup (link);
			IntPtr raw_ret = g_menu_item_get_link(Handle, native_link);
			GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
			GLib.Marshaller.Free (native_link);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_action_and_target_value(IntPtr raw, IntPtr action, IntPtr target_value);

		public void SetActionAndTargetValue(string action, GLib.Variant target_value) {
			IntPtr native_action = GLib.Marshaller.StringToPtrGStrdup (action);
			g_menu_item_set_action_and_target_value(Handle, native_action, target_value == null ? IntPtr.Zero : target_value.Handle);
			GLib.Marshaller.Free (native_action);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_attribute_value(IntPtr raw, IntPtr attribute, IntPtr value);

		public void SetAttributeValue(string attribute, GLib.Variant value) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			g_menu_item_set_attribute_value(Handle, native_attribute, value == null ? IntPtr.Zero : value.Handle);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_detailed_action(IntPtr raw, IntPtr detailed_action);

		public string DetailedAction { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_menu_item_set_detailed_action(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_icon(IntPtr raw, IntPtr icon);

		public GLib.IIcon Icon { 
			set {
				g_menu_item_set_icon(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.IconAdapter).Handle));
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_label(IntPtr raw, IntPtr label);

		public string Label { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_menu_item_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_link(IntPtr raw, IntPtr link, IntPtr model);

		public void SetLink(string link, GLib.MenuModel model) {
			IntPtr native_link = GLib.Marshaller.StringToPtrGStrdup (link);
			g_menu_item_set_link(Handle, native_link, model == null ? IntPtr.Zero : model.Handle);
			GLib.Marshaller.Free (native_link);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_section(IntPtr raw, IntPtr section);

		public GLib.MenuModel Section { 
			set {
				g_menu_item_set_section(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_item_set_submenu(IntPtr raw, IntPtr submenu);

		public GLib.MenuModel Submenu { 
			set {
				g_menu_item_set_submenu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

#endregion
	}
}
