using MSD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSD.Controllers
{
    class ApplicationController : IApplicationController
    {
        private MainWindowService _mainWindowService;

        public ApplicationController()
        {
            _mainWindowService = new MainWindowService();
        }

    }
}
