using Haunter.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Haunter.Classes
{
    public class WAW
    {
        public void Cbuf_AddText(string cmd)
        {
            try
            {
                Home.console.CallVoid(2183593736U, new object[] { 0, cmd });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to send the command to the game. Make sure the game is running and connected.\n\nError details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        /* Read only arrays */

        private static readonly string[] idNames = new string[] { "=== Side Arm ===", "Nambu", "Walther P38", "Tokarev TT - 33", ".357 Magnum", "=== SMG ===", "Thompson", "MP40", "Type 100", "PPSh-41", "=== AR ===", "SVT-40", "Gewehr 43", "M1 Garand", "M1A1 Carbine", "STG-44", "=== LMG ===", "Browning M1919", "MG42", "DP-28", "=== Heavy / Launchers ===", "M2 Flamethrower", "M9A1 Bazooka", "=== Snipers ===", "Springfield", "Mosin-Nagant", "Arisaka", "Kar98k", "PTRS-41", "=== Shotguns ===", "M1897 Trench Gun", "Double-Barreled Shotgun", "=== Specialty Rifles / Others ===", "Type 99", "FG-42", "BAR", "DP - 28", "=== Grenades ===", "MINE BETTY", "SATCHEL CHARGE", "=== Grenades & Chemical ===", "FRAG", "Molotov Cocktail", "Smoke", "Tabun Gas", "N° 74 ST", "Signal Flare", "=== Perks ===", "Bomb Squad", "Bandolier", "Camouflage", "Fireworks", "Flak Jacket", "Stopping Power", "Double Tap", "Sleight of Hand", "Overkill", "Juggernaut", "Toss Back", "Shades", "Gas Mask", "Iron Lungs", "Dead Silence", "Extreme Conditioning", "Second Chance", "Martyrdom", "Depp Impact", "Steady Aim", "Fireproof", "Reconnaissance", "Greased Bearings", "Water Cooler", "Ordnance Training", "Leadfoot", "Coxial Machine Gun", "Primary Grenades x2", "Special Grenades x2", "Satchel Charge x2", "Bouncing Betty x2", "M9A1 Bazooka x2", "M2 Flamethrower", "===  Attachments  ===", "None", "Grenade Launcher", "Grip", "Attachment", "=== Others ===", "Close Assaut", "Sniper", "Create a Class", "Challenges", "Clantag" };

        // -1 represents a separator in the comboBox
        private static readonly int[] ids = new int[] { -1, 1, 2, 3, 4, -1, 10, 11, 12, 13, -1, 20, 21, 22, 23, 24, -1, 40, 41, 42, -1, 50, 55, -1, 60, 61, 62, 63, 64, -1, 70, 71, -1, 80, 81, 82, 83, -1, 91, 92, -1, 100, 101, 102, 103, 104, 105, -1, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 180, 182, 184, 185, 186, 187, -1, 190, 191, 192, 193, -1, 195, 196, 197, 198, 201 };


        public static IReadOnlyList<string> Names => idNames;
        public static IReadOnlyList<int> Ids => ids;

        public void SendItem(RadioButton rb, int statId, int id)
        {
            if (rb.Checked)
                Cbuf_AddText($"statSet {statId} {id}");
        }

    }
}
