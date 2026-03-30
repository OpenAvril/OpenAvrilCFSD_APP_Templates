using System;
using System.Runtime.InteropServices;
using System.Security;
namespace OpenAvrilCFSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class ImportCLIBWriteEnableForThreadsAtCLIENTINPUTACTION
    {
        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?app_FUNCT_generate_Program@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTINPUTACTION@@SAPAXXZ")]
        public static extern IntPtr app_FUNCT_generate_Program();

        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?app_FUNCT_terminate_Program@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTINPUTACTION@@SAXXZ")]
        public static extern void app_FUNCT_terminate_Program();

        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?app_FUNCT_write_End@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTINPUTACTION@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_write_End(IntPtr obj, byte coreId);

        [DllImport("LIBWriteEnableForThreadsAtCLIENTINPUTACTION.dll", EntryPoint = "?app_FUNCT_write_Start@CLIBWriteEnableForThreadsAtCLIENTINPUTACTION@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTINPUTACTION@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_write_Start(IntPtr obj, byte coreId);
    }
}