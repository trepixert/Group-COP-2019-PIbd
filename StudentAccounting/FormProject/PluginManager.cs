using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace FormProject {
    class PluginManager {
        [ImportMany(typeof(IPlugin))]
        public IEnumerable<IPlugin> Plugins { get; set; }

        public readonly Dictionary<string, Action<int>> Actions = new Dictionary<string, Action<int>>();

        public string[] Headers { get; private set; }

        public PluginManager() {
            AggregateCatalog catalog = new AggregateCatalog();

            var pluginChangeCourse = new AssemblyCatalog(@"C:\Users\Ramis\source\repos\Group-COP-2019-PIbd\StudentAccounting\PluginChangeCourse\bin\Debug\PluginChangeCourse.dll");
            var pluginVidachaStipuhi = new AssemblyCatalog(@"C:\Users\Ramis\source\repos\Group-COP-2019-PIbd\StudentAccounting\PluginVidachaStipuhi\bin\Debug\PluginVidachaStipuhi.dll");
            var pluginReport = new AssemblyCatalog(@"C:\Users\Ramis\source\repos\Group-COP-2019-PIbd\StudentAccounting\PluginReport\bin\Debug\PluginReport.dll");
            catalog.Catalogs.Add(pluginChangeCourse);
            catalog.Catalogs.Add(pluginVidachaStipuhi);
            catalog.Catalogs.Add(pluginReport);

            CompositionContainer container = new CompositionContainer(catalog);

            container.ComposeParts(this);
            if (!Plugins.Any()) return;
            Plugins.ToList().ForEach(p => Actions.Add(p.Name, (id) => p.run(id)));
            Headers = Actions.Keys.ToArray();
        }
    }
}
