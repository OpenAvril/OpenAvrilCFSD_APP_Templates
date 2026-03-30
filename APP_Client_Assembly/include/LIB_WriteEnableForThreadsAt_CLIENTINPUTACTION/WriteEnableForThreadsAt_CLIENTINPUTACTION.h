#pragma once
namespace OpenAvrilCLIBWriteEnableForThreadsAtCLIENTINPUTACTION
{
    class WriteEnableForThreadsAt_CLIENTINPUTACTION
    {
    public:
        WriteEnableForThreadsAt_CLIENTINPUTACTION();
        virtual ~WriteEnableForThreadsAt_CLIENTINPUTACTION();
        static void boot0_CLASS_DECLAIRE_WriteEnableForThreadsAt_CLIENTINPUTACTION();
        static void boot1_CLASS_DEFINE_WriteEnableForThreadsAt_CLIENTINPUTACTION();
        static void boot3_CLASS_INITIALISE_WriteEnableForThreadsAt_CLIENTINPUTACTION();
        static void boot0_REG_DECLAIRE_WriteEnableForThreadsAt_CLIENTINPUTACTION();
        void boot1_REG_DEFINE_WriteEnableForThreadsAt_CLIENTINPUTACTION(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj);
        void boot2_REG_SUBSTANTIATE_WriteEnableForThreadsAt_CLIENTINPUTACTION(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj);
        void boot3_REG_INITIALISE_WriteEnableForThreadsAt_CLIENTINPUTACTION(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj);
        void boot4_PGM_INSTANTIATE_WriteEnableForThreadsAt_CLIENTINPUTACTION(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj);
        void dyn_app_FUNCT_write_End(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, uint8_t coreId);
        void dyn_app_FUNCT_write_Start(class WriteEnableForThreadsAt_CLIENTINPUTACTION_Framework* obj, uint8_t coreId);
        class WriteEnableForThreadsAt_CLIENTINPUTACTION_Global* dyn_CLASS_get_ptr_Global();
        class WriteEnableForThreadsAt_CLIENTINPUTACTION_Control* dyn_CLASS_get_ptr_WriteEnable_Control();
        static class WriteEnableForThreadsAt_CLIENTINPUTACTION_Global* _stat_CLASS_ptr_Global;
        static class WriteEnableForThreadsAt_CLIENTINPUTACTION_Control* _stat_CLASS_ptr_WriteEnable_Control;
        static void stat_CLASS_boot1_DEFINE_Global();
        static void stat_CLASS_boot1_DEFINE_WriteEnable_Control();
        static void stat_CLASS_boot3_INITIALISE_Global();
        static void stat_CLASS_boot3_INITIALISE_WriteEnable_Control();
        static class WriteEnableForThreadsAt_CLIENTINPUTACTION_Global* stat_CLASS_get_ptr_Global();
        static class WriteEnableForThreadsAt_CLIENTINPUTACTION_Control* stat_CLASS_get_ptr_WriteEnable_Control();
    };
}