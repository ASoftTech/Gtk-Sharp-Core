// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void LaunchedHandler(object o, LaunchedArgs args);

	public class LaunchedArgs : GLib.SignalArgs {
		public GLib.IAppInfo Info{
			get {
				return GLib.AppInfoAdapter.GetObject (Args [0] as GLib.Object);
			}
		}

		public GLib.Variant PlatformData{
			get {
				return (GLib.Variant) Args [1];
			}
		}

	}
}
