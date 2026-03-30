using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenAvrilCFSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class ImportCLIBLaunchEnableForConcurrentThreadsAtCLIENT
    {
        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_generate_Program@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAPAXXZ")]
        public static extern IntPtr app_FUNCT_generate_Program();

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_request_Wait_launch@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_request_Wait_launch(IntPtr obj, byte concurrent_CoreId);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_terminate_Progaram@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAXXZ")]
        public static extern void app_FUNCT_terminate_Progaram();

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_thread_End@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAXPAXPAE@Z")]
        public static extern byte app_FUNCT_thread_End(IntPtr obj, byte concurrent_CoreId);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_get_coreId_To_launch@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAPAEPAX@Z")]
        public static extern bool app_FUNCT_get_coreId_To_launch(IntPtr obj);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_get_Flag_Active@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SA_NPAX@Z")]
        public static extern bool app_FUNCT_get_Flag_Active(IntPtr obj);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_get_Flag_ConcurrentCoreState@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SA_NPAXPAE@Z")]
        public static extern bool app_FUNCT_get_Flag_ConcurrentCoreState(IntPtr obj, byte concurrent_CoreId);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_get_Flag_Idle@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SA_NPAX@Z")]
        public static extern bool app_FUNCT_get_Flag_Idle(IntPtr obj);

        [DllImport("LIBLaunchEnableForConcurrentThreadsAtCLIENT.dll", EntryPoint = "?app_FUNCT_set_Flag_ConcurrentCoreState@CLIBLaunchEnableForConcurrentThreadsAtCLIENT@OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT@@SAXPAXPAE_N@Z")]
        public static extern void app_FUNCT_set_Flag_ConcurrentCoreState(IntPtr obj, byte concurrent_CoreId, bool value);
    }
}