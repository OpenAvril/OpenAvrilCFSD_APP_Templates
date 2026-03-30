using OpenTK.Graphics.OpenGL;
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenAvrilCFSD
{
    [SuppressUnmanagedCodeSecurity]
    public static class ImportCLIBConcurrentServerIO
    {
        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_flip_Input_DoubleBuffer@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAX@Z")]
        public static extern void app_FUNCT_flip_Input_DoubleBuffer(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_generate_Program@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAPAXXZ")]
        public static extern IntPtr app_FUNCT_generate_Program();

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_select_set_Intput_Subset@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAXPAE@Z")]
        public static extern void app_FUNCT_select_set_Intput_Subset(IntPtr obj, byte bytes);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_terminate_Program@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAX@Z")]
        public static extern void app_FUNCT_terminate_Program();

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_pop_From_Stack_Of_Output@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAX@Z")]
        public static extern void app_FUNCT_pop_From_Stack_Of_Output(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?app_FUNCT_push_To_STACK_Of_Input@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAX@Z")]
        public static extern void app_FUNCT_push_To_STACK_Of_Input(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_get_flag_isStackLoaded_Server_InputAction@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SA_NPAX@Z")]
        public static extern bool dyn_REG_get_flag_isStackLoaded_Server_InputAction(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_get_flag_isStackLoaded_Server_OutputSend@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SA_NPAX@Z")]
        public static extern bool dyn_REG_get_flag_isStackLoaded_Server_OutputSend(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_get_flag_IsInitialised_OpenAvrilConcurrency@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SA_NPAX@Z")]
        public static extern bool dyn_REG_get_flag_IsInitialised_OpenAvrilConcurrency(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_get_ptr_PraiseEventId@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAPAEPAX@Z")]
        public static extern byte dyn_REG_get_ptr_PraiseEventId(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_get_ptr_output_Value@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAPAEPAX@Z")]
        public static extern byte dyn_REG_get_ptr_output_Value(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_set_Item_input_Value_A@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAXPAE@Z")]
        public static extern void dyn_REG_set_Item_input_Value_A(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_set_Item_input_Value_B@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAXPAE@Z")]
        public static extern void dyn_REG_set_Item_input_Value_B(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_REG_set_PraiseEventId@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAXPAXPAE@Z")]
        public static extern void dyn_REG_set_PraiseEventId(IntPtr obj, byte praiseEventId);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_PGM_get_program_WriteEnableStack_ServerInputAction@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAPAXPAX@Z")]
        public static extern IntPtr dyn_PGM_get_program_WriteEnableStack_ServerInputAction(IntPtr obj);

        [DllImport("LIBConcurrentIOServer.dll", EntryPoint = "?dyn_PGM_get_program_WriteEnableStack_ServerOutputRecieve@CLIBConcurrentServerIO@OpenAvrilConcurrency@@SAPAXPAX@Z")]
        public static extern IntPtr dyn_PGM_get_program_WriteEnableStack_ServerOutputRecieve(IntPtr obj);
    }
}