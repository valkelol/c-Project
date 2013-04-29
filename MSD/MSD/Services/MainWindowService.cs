using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSD.Services
{
    class MainWindowService
    {
        private Views.MainWindow _mainWindow;

        public MainWindowService()
        {
            _mainWindow = new Views.MainWindow();
            _mainWindow.Show();
        }
    }
}
