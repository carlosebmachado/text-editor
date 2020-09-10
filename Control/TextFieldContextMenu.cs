using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.Menu;

namespace Notepad.Control
{
    class TextFieldContextMenu
    {
        public static ContextMenu Create(Main main)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem;

            //
            menuItem = new MenuItem("Desfazer");
            menuItem.Click += new EventHandler(main.Undo);
            contextMenu.MenuItems.Add(menuItem);
            //
            menuItem = new MenuItem("Refazer");
            menuItem.Click += new EventHandler(main.Redo);
            contextMenu.MenuItems.Add(menuItem);
            //
            menuItem = new MenuItem("Cortar");
            menuItem.Click += new EventHandler(main.Cut);
            contextMenu.MenuItems.Add(menuItem);
            // 
            menuItem = new MenuItem("Copiar");
            menuItem.Click += new EventHandler(main.Copy);
            contextMenu.MenuItems.Add(menuItem);
            //
            menuItem = new MenuItem("Colar");
            menuItem.Click += new EventHandler(main.Paste);
            contextMenu.MenuItems.Add(menuItem);
            //
            menuItem = new MenuItem("Excluir");
            menuItem.Click += new EventHandler(main.Delete);
            contextMenu.MenuItems.Add(menuItem);
            //
            menuItem = new MenuItem("Selecionar Tudo");
            menuItem.Click += new EventHandler(main.SelectAll);
            contextMenu.MenuItems.Add(menuItem);
            //

            return contextMenu;
        }
    }
}
