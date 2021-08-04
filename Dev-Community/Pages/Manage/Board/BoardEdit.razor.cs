using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Community.Pages.Manage.Board
{
    public partial class BoardEdit
    {
        [Parameter] public int Seq { get; set; } = 400;

        Models.Board board = new Models.Board();
        protected override async Task OnInitializedAsync()
        {
            if (Seq != 400)
            {
                board = await BoardDBService.Get(Seq);
            }
        }

        private void Btn_Cancel_Click()
        {
            //JSRuntime.InvokeAsync("alert", "");

            Nav.NavigateTo("Manage/Board/View");
        }
    }
}
