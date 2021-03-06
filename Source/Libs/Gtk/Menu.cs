// Gtk.Menu.cs - Gtk Menu class customizations
//
// Author: John Luke <john.luke@gmail.com> 
//
// Copyright (C) 2004 John Luke
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

	public partial class Menu {

		public void Popup ()
		{
			PopupAtPointer (null);
		}

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_set_screen (IntPtr raw, IntPtr screen);

		public new Gdk.Screen Screen {
			get {
				return base.Screen;
			}
			set {
				gtk_menu_set_screen (Handle, value.Handle);
			}
		}

		[DllImport (Global.GtkNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_set_active (IntPtr raw, uint index_);

		public void SetActive (uint index_)
		{
			gtk_menu_set_active (Handle, index_);
		}
	}
}
