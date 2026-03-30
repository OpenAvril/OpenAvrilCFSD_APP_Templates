#ifdef LAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_EXPORTS
#define LAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API __declspec(dllexport)
#else
#define LAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API __declspec(dllimport)
#endif
extern "C"
{
	namespace OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT
	{
		class LAUNCHENABLEFORCONCURRENTTHREADSATCLIENT_API CLIBLaunchEnableForConcurrentThreadsAtCLIENT
		{
		public:
			static void* app_FUNCT_generate_Program();
			static void app_FUNCT_request_Wait_launch(void* obj, unsigned char* bytes);
			static void app_FUNCT_terminate_Progaram();
			static void app_FUNCT_thread_End(void* obj, unsigned char* bytes);
			static unsigned char* app_FUNCT_get_coreId_To_launch(void* obj);
			static bool app_FUNCT_get_Flag_Active(void* obj);
			static bool app_FUNCT_get_Flag_ConcurrentCoreState(void* obj, unsigned char* bytes);
			static bool app_FUNCT_get_Flag_Idle(void* obj);
			static bool app_FUNCT_get_State_launchBit(void* obj);
			static void app_FUNCT_set_Flag_ConcurrentCoreState(void* obj, unsigned char* bytes, bool newValue);

		private:
			static void stat_boot1_CLASS_DEFINE_LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
			static void stat_boot3_CLASS_INITIALISE_LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
			static class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* stat_CLASS_get_ptr_LaunchEnableForConcurrentThreadsAt_CLIENT_Framework();
		};
	}
}