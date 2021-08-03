using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Community.Models;

namespace Dev_Community.Pages.Manage.Board
{
    public partial class BoardView
    {
        List<Models.Board> boards = new List<Models.Board>();
        protected override async Task OnInitializedAsync()
        {
            boards = await BoardDBService.GetAll();
        }
    }
}
