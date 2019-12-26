using Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTestProject
{
    public class PluginManager
    {
        [ImportMany(typeof(IPlugin))]
        public IEnumerable<IPlugin> Plugins { get; set; }

        public readonly Dictionary<string, Action<int>> Actions = new Dictionary<string, Action<int>>();

        public string[] Headers { get; private set; }

        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            var pluginChangeDate = new AssemblyCatalog(@"D:\trepixert\Group-COP-2019-PIbd\SomeForm\bin\Debug\Plugins\PluginChangeDate.dll");
            var pluginChangeProfiles = new AssemblyCatalog(@"D:\trepixert\Group-COP-2019-PIbd\SomeForm\bin\Debug\Plugins\PluginChangeProfiles.dll");
            var pluginReport = new AssemblyCatalog(@"D:\trepixert\Group-COP-2019-PIbd\SomeForm\bin\Debug\Plugins\PluginReport.dll");
            catalog.Catalogs.Add(pluginChangeDate);
            catalog.Catalogs.Add(pluginChangeProfiles);
            catalog.Catalogs.Add(pluginReport);

            CompositionContainer container = new CompositionContainer(catalog);

            container.ComposeParts(this);
            if (!Plugins.Any()) return;
            Plugins.ToList().ForEach(p => Actions.Add(p.Name, (id) => p.Run(id)));
            Headers = Actions.Keys.ToArray();
        }
    }
}
