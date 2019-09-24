﻿using ConsoleTableExt;
using EasyConsole;
using HierarchyExamples.Contracts;
using HierarchyExamples.Helpers.Menu.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HierarchyExamples.Helpers.Menu.Actions
{

    public class AddProductsPage : ActionMenuPage
    {
        public AddProductsPage(IDataService dataService, Program program)
            : base(dataService, "Add Producs to category", program)
        {
        }

        public override void Display()
        {
            if (CurrentParentID.HasValue)
            {
                DataService.AddProducts(CurrentParentID);

                Input.ReadString("Products added");
            }
            else
            {
                Input.ReadString("You must choose category first");
            }

            Program.NavigateTo<DisplayCategory>();
        }

    }
}
