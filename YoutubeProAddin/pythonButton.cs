using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Desktop.Core.Geoprocessing;
using System.IO;



namespace YoutubeProAddin
{
    internal class pythonButton : Button
    {
        protected override void OnClick()
        {

            //ArcGIS.Desktop.Framework.Dialogs.MessageBox.Show("This is the Python Button");
            string installPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string toolboxPath = Path.Combine(installPath, "youtube_toolbox.pyt\\Tool");

            Geoprocessing.OpenToolDialog(toolboxPath, null);


        }
    }
}
