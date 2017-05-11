// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MountOperation : GLib.Object {

		public MountOperation (IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_operation_new();

		public MountOperation () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MountOperation)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_mount_operation_new();
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_operation_get_username(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_username(IntPtr raw, IntPtr username);

		[GLib.Property ("username")]
		public string Username {
			get  {
				IntPtr raw_ret = g_mount_operation_get_username(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_mount_operation_set_username(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_operation_get_password(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_password(IntPtr raw, IntPtr password);

		[GLib.Property ("password")]
		public string Password {
			get  {
				IntPtr raw_ret = g_mount_operation_get_password(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_mount_operation_set_password(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_mount_operation_get_anonymous(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_anonymous(IntPtr raw, bool anonymous);

		[GLib.Property ("anonymous")]
		public bool Anonymous {
			get  {
				bool raw_ret = g_mount_operation_get_anonymous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_mount_operation_set_anonymous(Handle, value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_operation_get_domain(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_domain(IntPtr raw, IntPtr domain);

		[GLib.Property ("domain")]
		public string Domain {
			get  {
				IntPtr raw_ret = g_mount_operation_get_domain(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				g_mount_operation_set_domain(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_mount_operation_get_password_save(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_password_save(IntPtr raw, int save);

		[GLib.Property ("password-save")]
		public GLib.PasswordSave PasswordSave {
			get  {
				int raw_ret = g_mount_operation_get_password_save(Handle);
				GLib.PasswordSave ret = (GLib.PasswordSave) raw_ret;
				return ret;
			}
			set  {
				g_mount_operation_set_password_save(Handle, (int) value);
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_mount_operation_get_choice(IntPtr raw);

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_set_choice(IntPtr raw, int choice);

		[GLib.Property ("choice")]
		public int Choice {
			get  {
				int raw_ret = g_mount_operation_get_choice(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				g_mount_operation_set_choice(Handle, value);
			}
		}

		[GLib.Signal("reply")]
		public event GLib.ReplyHandler Reply {
			add {
				this.AddSignalHandler ("reply", value, typeof (GLib.ReplyArgs));
			}
			remove {
				this.RemoveSignalHandler ("reply", value);
			}
		}

		[GLib.Signal("ask-password")]
		public event GLib.AskPasswordHandler AskPassword {
			add {
				this.AddSignalHandler ("ask-password", value, typeof (GLib.AskPasswordArgs));
			}
			remove {
				this.RemoveSignalHandler ("ask-password", value);
			}
		}

		[GLib.Signal("aborted")]
		public event System.EventHandler Aborted {
			add {
				this.AddSignalHandler ("aborted", value);
			}
			remove {
				this.RemoveSignalHandler ("aborted", value);
			}
		}

		[GLib.Signal("ask-question")]
		public event GLib.AskQuestionHandler AskQuestion {
			add {
				this.AddSignalHandler ("ask-question", value, typeof (GLib.AskQuestionArgs));
			}
			remove {
				this.RemoveSignalHandler ("ask-question", value);
			}
		}

		[GLib.Signal("show-unmount-progress")]
		public event GLib.ShowUnmountProgressHandler ShowUnmountProgress {
			add {
				this.AddSignalHandler ("show-unmount-progress", value, typeof (GLib.ShowUnmountProgressArgs));
			}
			remove {
				this.RemoveSignalHandler ("show-unmount-progress", value);
			}
		}

		[GLib.Signal("show-processes")]
		public event GLib.ShowProcessesHandler ShowProcesses {
			add {
				this.AddSignalHandler ("show-processes", value, typeof (GLib.ShowProcessesArgs));
			}
			remove {
				this.RemoveSignalHandler ("show-processes", value);
			}
		}

		static AskPasswordNativeDelegate AskPassword_cb_delegate;
		static AskPasswordNativeDelegate AskPasswordVMCallback {
			get {
				if (AskPassword_cb_delegate == null)
					AskPassword_cb_delegate = new AskPasswordNativeDelegate (AskPassword_cb);
				return AskPassword_cb_delegate;
			}
		}

		static void OverrideAskPassword (GLib.GType gtype)
		{
			OverrideAskPassword (gtype, AskPasswordVMCallback);
		}

		static void OverrideAskPassword (GLib.GType gtype, AskPasswordNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.AskPassword = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AskPasswordNativeDelegate (IntPtr inst, IntPtr message, IntPtr default_user, IntPtr default_domain, int flags);

		static void AskPassword_cb (IntPtr inst, IntPtr message, IntPtr default_user, IntPtr default_domain, int flags)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnAskPassword (GLib.Marshaller.Utf8PtrToString (message), GLib.Marshaller.Utf8PtrToString (default_user), GLib.Marshaller.Utf8PtrToString (default_domain), (GLib.AskPasswordFlags) flags);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideAskPassword")]
		protected virtual void OnAskPassword (string message, string default_user, string default_domain, GLib.AskPasswordFlags flags)
		{
			InternalAskPassword (message, default_user, default_domain, flags);
		}

		private void InternalAskPassword (string message, string default_user, string default_domain, GLib.AskPasswordFlags flags)
		{
			AskPasswordNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).AskPassword;
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			IntPtr native_default_user = GLib.Marshaller.StringToPtrGStrdup (default_user);
			IntPtr native_default_domain = GLib.Marshaller.StringToPtrGStrdup (default_domain);
			unmanaged (this.Handle, native_message, native_default_user, native_default_domain, (int) flags);
			GLib.Marshaller.Free (native_message);
			GLib.Marshaller.Free (native_default_user);
			GLib.Marshaller.Free (native_default_domain);
		}

		static AskQuestionNativeDelegate AskQuestion_cb_delegate;
		static AskQuestionNativeDelegate AskQuestionVMCallback {
			get {
				if (AskQuestion_cb_delegate == null)
					AskQuestion_cb_delegate = new AskQuestionNativeDelegate (AskQuestion_cb);
				return AskQuestion_cb_delegate;
			}
		}

		static void OverrideAskQuestion (GLib.GType gtype)
		{
			OverrideAskQuestion (gtype, AskQuestionVMCallback);
		}

		static void OverrideAskQuestion (GLib.GType gtype, AskQuestionNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.AskQuestion = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AskQuestionNativeDelegate (IntPtr inst, IntPtr message, IntPtr[] choices);

		static void AskQuestion_cb (IntPtr inst, IntPtr message, IntPtr[] choices)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnAskQuestion (GLib.Marshaller.Utf8PtrToString (message), GLib.Marshaller.Utf8PtrToString (choices));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideAskQuestion")]
		protected virtual void OnAskQuestion (string message, string[] choices)
		{
			InternalAskQuestion (message, choices);
		}

		private void InternalAskQuestion (string message, string[] choices)
		{
			AskQuestionNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).AskQuestion;
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			int cnt_choices = choices == null ? 0 : choices.Length;
			IntPtr[] native_choices = new IntPtr [cnt_choices];
			for (int i = 0; i < cnt_choices; i++)
				native_choices [i] = GLib.Marshaller.StringToPtrGStrdup (choices[i]);
			unmanaged (this.Handle, native_message, native_choices);
			GLib.Marshaller.Free (native_message);
			for (int i = 0; i < native_choices.Length; i++) {
				choices [i] = GLib.Marshaller.Utf8PtrToString (native_choices[i]);
				GLib.Marshaller.Free (native_choices[i]);
			}
		}

		static ReplyNativeDelegate Reply_cb_delegate;
		static ReplyNativeDelegate ReplyVMCallback {
			get {
				if (Reply_cb_delegate == null)
					Reply_cb_delegate = new ReplyNativeDelegate (Reply_cb);
				return Reply_cb_delegate;
			}
		}

		static void OverrideReply (GLib.GType gtype)
		{
			OverrideReply (gtype, ReplyVMCallback);
		}

		static void OverrideReply (GLib.GType gtype, ReplyNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.Reply = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReplyNativeDelegate (IntPtr inst, int result);

		static void Reply_cb (IntPtr inst, int result)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnReply ((GLib.MountOperationResult) result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideReply")]
		protected virtual void OnReply (GLib.MountOperationResult result)
		{
			InternalReply (result);
		}

		private void InternalReply (GLib.MountOperationResult result)
		{
			ReplyNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Reply;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) result);
		}

		static AbortedNativeDelegate Aborted_cb_delegate;
		static AbortedNativeDelegate AbortedVMCallback {
			get {
				if (Aborted_cb_delegate == null)
					Aborted_cb_delegate = new AbortedNativeDelegate (Aborted_cb);
				return Aborted_cb_delegate;
			}
		}

		static void OverrideAborted (GLib.GType gtype)
		{
			OverrideAborted (gtype, AbortedVMCallback);
		}

		static void OverrideAborted (GLib.GType gtype, AbortedNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.Aborted = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AbortedNativeDelegate (IntPtr inst);

		static void Aborted_cb (IntPtr inst)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnAborted ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideAborted")]
		protected virtual void OnAborted ()
		{
			InternalAborted ();
		}

		private void InternalAborted ()
		{
			AbortedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Aborted;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ShowProcessesNativeDelegate ShowProcesses_cb_delegate;
		static ShowProcessesNativeDelegate ShowProcessesVMCallback {
			get {
				if (ShowProcesses_cb_delegate == null)
					ShowProcesses_cb_delegate = new ShowProcessesNativeDelegate (ShowProcesses_cb);
				return ShowProcesses_cb_delegate;
			}
		}

		static void OverrideShowProcesses (GLib.GType gtype)
		{
			OverrideShowProcesses (gtype, ShowProcessesVMCallback);
		}

		static void OverrideShowProcesses (GLib.GType gtype, ShowProcessesNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowProcesses = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowProcessesNativeDelegate (IntPtr inst, IntPtr message, IntPtr processes, IntPtr[] choices);

		static void ShowProcesses_cb (IntPtr inst, IntPtr message, IntPtr processes, IntPtr[] choices)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnShowProcesses (GLib.Marshaller.Utf8PtrToString (message), processes, GLib.Marshaller.Utf8PtrToString (choices));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideShowProcesses")]
		protected virtual void OnShowProcesses (string message, IntPtr processes, string[] choices)
		{
			InternalShowProcesses (message, processes, choices);
		}

		private void InternalShowProcesses (string message, IntPtr processes, string[] choices)
		{
			ShowProcessesNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowProcesses;
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			int cnt_choices = choices == null ? 0 : choices.Length;
			IntPtr[] native_choices = new IntPtr [cnt_choices];
			for (int i = 0; i < cnt_choices; i++)
				native_choices [i] = GLib.Marshaller.StringToPtrGStrdup (choices[i]);
			unmanaged (this.Handle, native_message, processes, native_choices);
			GLib.Marshaller.Free (native_message);
			for (int i = 0; i < native_choices.Length; i++) {
				choices [i] = GLib.Marshaller.Utf8PtrToString (native_choices[i]);
				GLib.Marshaller.Free (native_choices[i]);
			}
		}

		static ShowUnmountProgressNativeDelegate ShowUnmountProgress_cb_delegate;
		static ShowUnmountProgressNativeDelegate ShowUnmountProgressVMCallback {
			get {
				if (ShowUnmountProgress_cb_delegate == null)
					ShowUnmountProgress_cb_delegate = new ShowUnmountProgressNativeDelegate (ShowUnmountProgress_cb);
				return ShowUnmountProgress_cb_delegate;
			}
		}

		static void OverrideShowUnmountProgress (GLib.GType gtype)
		{
			OverrideShowUnmountProgress (gtype, ShowUnmountProgressVMCallback);
		}

		static void OverrideShowUnmountProgress (GLib.GType gtype, ShowUnmountProgressNativeDelegate callback)
		{
			GMountOperationClass class_iface = GetClassStruct (gtype, false);
			class_iface.ShowUnmountProgress = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ShowUnmountProgressNativeDelegate (IntPtr inst, IntPtr message, long time_left, long bytes_left);

		static void ShowUnmountProgress_cb (IntPtr inst, IntPtr message, long time_left, long bytes_left)
		{
			try {
				MountOperation __obj = GLib.Object.GetObject (inst, false) as MountOperation;
				__obj.OnShowUnmountProgress (GLib.Marshaller.Utf8PtrToString (message), time_left, bytes_left);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MountOperation), ConnectionMethod="OverrideShowUnmountProgress")]
		protected virtual void OnShowUnmountProgress (string message, long time_left, long bytes_left)
		{
			InternalShowUnmountProgress (message, time_left, bytes_left);
		}

		private void InternalShowUnmountProgress (string message, long time_left, long bytes_left)
		{
			ShowUnmountProgressNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ShowUnmountProgress;
			if (unmanaged == null) return;

			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			unmanaged (this.Handle, native_message, time_left, bytes_left);
			GLib.Marshaller.Free (native_message);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GMountOperationClass {
			public AskPasswordNativeDelegate AskPassword;
			public AskQuestionNativeDelegate AskQuestion;
			public ReplyNativeDelegate Reply;
			public AbortedNativeDelegate Aborted;
			public ShowProcessesNativeDelegate ShowProcesses;
			public ShowUnmountProgressNativeDelegate ShowUnmountProgress;
			IntPtr GReserved1;
			IntPtr GReserved2;
			IntPtr GReserved3;
			IntPtr GReserved4;
			IntPtr GReserved5;
			IntPtr GReserved6;
			IntPtr GReserved7;
			IntPtr GReserved8;
			IntPtr GReserved9;
		}

		static uint class_offset = ((GLib.GType) typeof (GLib.Object)).GetClassSize ();
		static Dictionary<GLib.GType, GMountOperationClass> class_structs;

		static GMountOperationClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GMountOperationClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GMountOperationClass class_struct = (GMountOperationClass) Marshal.PtrToStructure (class_ptr, typeof (GMountOperationClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GMountOperationClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_mount_operation_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_mount_operation_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_mount_operation_reply(IntPtr raw, int result);

		public void EmitReply(GLib.MountOperationResult result) {
			g_mount_operation_reply(Handle, (int) result);
		}

#endregion
	}
}