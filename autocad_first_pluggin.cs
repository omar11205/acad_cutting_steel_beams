using autocad_plugin_first;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:CommandClass(typeof(autocad_plugin_first.autocad_first_pluggin))]
namespace autocad_plugin_first
{
    public class autocad_first_pluggin
    {
        [CommandMethod("Hello")]
        public void HelloWorld() {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            
            ed.WriteMessage("Hello Fucking World!! /,,/");
        }
    }
}
