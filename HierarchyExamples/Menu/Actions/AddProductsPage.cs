﻿using EasyConsole;
using HierarchyExamples.Contracts;
using HierarchyExamples.Menu.Base;

namespace HierarchyExamples.Menu.Actions
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