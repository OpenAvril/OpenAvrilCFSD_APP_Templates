#pragma once
namespace OpenAvrilCLIBLaunchEnableForConcurrentThreadsAtCLIENT
{
    class LaunchEnableForConcurrentThreadsAt_CLIENT
    {
    public:
        LaunchEnableForConcurrentThreadsAt_CLIENT();
        virtual ~LaunchEnableForConcurrentThreadsAt_CLIENT();
        void app_thread_Start(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, uint8_t concurrentThreadID);
        void app_thread_End(class LaunchEnableForConcurrentThreadsAt_CLIENT_Framework* obj, uint8_t concurrentThreadID);
        static void boot0_CLASS_DECLAIRE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        static void boot1_CLASS_DEFINE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        static void boot3_CLASS_INITIALISE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        static void boot0_REG_DECLAIRE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        void boot1_REG_DEFINE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        void boot2_REG_SUBSTANTIATE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        void boot3_REG_INITIALISE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        void boot4_PGM_INSTANTIATE_LaunchEnableForConcurrentThreadsAt_CLIENT();
        class LaunchEnableForConcurrentThreadsAt_CLIENT_Global* dyn_CLASS_get_ptr_Global();
        class LaunchEnableForConcurrentThreadsAt_CLIENT_Control* dyn_CLASS_get_ptr_LaunchConcurrency_Control();
    private:
        static class LaunchEnableForConcurrentThreadsAt_CLIENT_Global* _stat_CLASS_ptr_Global;
        static class LaunchEnableForConcurrentThreadsAt_CLIENT_Control* _stat_CLASS_ptr_LaunchConcurrency_Control;
        static void stat_CLASS_boot1_DEFINE_Global();
        static void stat_CLASS_boot1_DEFINE_WriteEnable_Control();
        static void stat_CLASS_boot3_INITIALISE_Global();
        static void stat_CLASS_boot3_INITIALISE_LaunchConcurrency_Control();
        static class LaunchEnableForConcurrentThreadsAt_CLIENT_Global* stat_CLASS_get_ptr_Global();
        static class LaunchEnableForConcurrentThreadsAt_CLIENT_Control* stat_CLASS_get_ptr_LaunchConcurrency_Control();
    };
}