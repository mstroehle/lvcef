//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_context_menu_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _on_before_context_menu;
        internal IntPtr _on_context_menu_command;
        internal IntPtr _on_context_menu_dismissed;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int add_ref_delegate(cef_context_menu_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_context_menu_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_refct_delegate(cef_context_menu_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_before_context_menu_delegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_context_menu_command_delegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_context_menu_dismissed_delegate(cef_context_menu_handler_t* self, cef_browser_t* browser, cef_frame_t* frame);
        
        private static int _sizeof;
        
        static cef_context_menu_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_context_menu_handler_t));
        }
        
        internal static cef_context_menu_handler_t* Alloc()
        {
            var ptr = (cef_context_menu_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_context_menu_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_context_menu_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
