using System;
using System.Runtime.InteropServices;
using System.Security;
namespace OpenAvrilCFSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class ImportCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE
    {
        [DllImport("LIB_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.dll", EntryPoint = "?app_FUNCT_generate_Program@CLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@@SAPAXXZ")]
        public static extern IntPtr app_FUNCT_generate_Program();

        [DllImport("LIB_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.dll", EntryPoint = "?app_FUNCT_terminate_Program@CLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@@SAXXZ")]
        public static extern void app_FUNCT_terminate_Program();

        [DllImport("LIB_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.dll", EntryPoint = "?app_FUNCT_write_End@CLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_write_End(IntPtr obj, byte coreId);

        [DllImport("LIB_WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE.dll", EntryPoint = "?app_FUNCT_write_Start@CLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@OpenAvrilCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_write_Start(IntPtr obj, byte coreId);
    }
}