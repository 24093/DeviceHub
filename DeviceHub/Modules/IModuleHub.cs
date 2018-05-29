using System;
using System.Collections.Generic;
using System.IO;

namespace Alkl.DeviceHub.Modules
{
    public interface IModuleHub
    {
        string ModulePath { get; set; }

        void ReloadModules();
    }

    public class ModuleHub : IModuleHub
    {
        private List<IModule> _modules;

        public ModuleHub()
        {
            _modules = new List<IModule>();
        }

        public string ModulePath { get; set; }

        public void ReloadModules()
        {
            if (!File.Exists(ModulePath))
                throw new FileNotFoundException("module path not found", ModulePath);

            var di = new DirectoryInfo(ModulePath);

            foreach (var file in di.GetFiles("Alkl.DeviceHub.Modules.*"))
            {

            }
        }
    }
}