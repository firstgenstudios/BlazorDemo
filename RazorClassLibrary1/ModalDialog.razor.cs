using Microsoft.AspNetCore.Components.Web;

namespace RazorClassLibrary1
{
    public partial class ModalDialog
    {
        private string NewItem;
        private List<string> Items = new List<string>();
        private bool showDialog = false;
        private void OpenDialog()
        {
            showDialog = true;
        }

        private void DialogCancelHandler(MouseEventArgs e)
        {
            NewItem = "";
            showDialog = false;
        }

        private void DialogOkHandler(MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(NewItem))
            {
                Items.Add(NewItem);
                NewItem = "";
            };
            showDialog = false;
        }
    }
}