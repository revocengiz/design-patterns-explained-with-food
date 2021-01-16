﻿using System.Collections.Generic;

namespace CreationalPatterns.AbstractFactory {
    public interface IMenu {
        public void PrintDescription();
        public void PrintMenu();
        public List<string> MakeShoppingList();
    }
}
