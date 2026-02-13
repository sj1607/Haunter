using Haunter.UserControls;

namespace Haunter.Classes
{
    public class BO3
    {
        public void Cbuf_AddText(string cmd)
        {
            try
            {
                Home.console.CallVoid(0x8263A6A0U, new object[] { 0, cmd });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
