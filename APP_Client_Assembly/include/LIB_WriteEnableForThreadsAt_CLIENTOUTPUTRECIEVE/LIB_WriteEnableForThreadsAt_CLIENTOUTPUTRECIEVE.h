#ifdef LIBWRITEENABLEFORTHREADSATCLIENTOUTPUTRECIEVE_EXPORTS
#define LIBWRITEENABLEFORTHREADSATCLIENTOUTPUTRECIEVE_API __declspec(dllexport)
#else
#define LIBWRITEENABLEFORTHREADSATCLIENTOUTPUTRECIEVE_API __declspec(dllimport)
#endif
extern "C"
{
	namespace OpenAvrilCLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE
	{
		class LIBWRITEENABLEFORTHREADSATCLIENTOUTPUTRECIEVE_API CLIBWriteEnableForThreadsAtCLIENTOUTPUTRECIEVE
		{
		public:
			static void* app_FUNCT_generate_Program();
			static void app_FUNCT_terminate_Program();
			static void app_FUNCT_write_End(void*, unsigned char* bytes);
			static void app_FUNCT_write_Start(void*, unsigned char* bytes);
		private:
			static void stat_boot1_CLASS_DEFINE_Framework();
			static void stat_boot3_CLASS_INITIALISE_Framework();
			static class WriteEnableForThreadsAt_CLIENTOUTPUTRECIEVE_Framework* stat_CLASS_get_ptr_Framework();
		};
	}
}