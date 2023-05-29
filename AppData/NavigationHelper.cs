using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ali_Diplom
{
    internal class NavigationHelper
    {
       
        
            private Window _mainWindow;
            private Frame _mainFrame;

            public NavigationHelper(Window mainWindow)
            {
                _mainWindow = mainWindow;
                _mainFrame = _mainWindow.Content as Frame;
            }

           

            public void NavigateToWindow(Window window)
            {
                window.ShowDialog();
            }

            

           
        
    }
}
