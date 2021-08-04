using Dev_Community.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Community.Pages.Manage.Board
{
    public class BoardBaseClass : ComponentBase
    {
        [Inject] protected IBoardService BoardDBService { get; set; }
        [Inject] protected NavigationManager Nav { get; set; }
        [Inject] protected IJSRuntime JSRuntime { get; set; }
    }
}
