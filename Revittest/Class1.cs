﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace Revittest
{
    [Transaction(TransactionMode.Manual)]
    public class Class1  : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData , ref string message, ElementSet elements
            )
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;
          
            return Result.Succeeded;

        }
    }
}
