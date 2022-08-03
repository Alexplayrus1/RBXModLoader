using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace rbxModLoader
{
    public partial class Form1 : Form
    {
        public static string GetNewestDirectory(string path)
        {
            var directory = new DirectoryInfo(path).GetDirectories().OrderByDescending(o => o.CreationTime).FirstOrDefault();
            return directory.Name;
        }
        static string GetRobloxVersion()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string roblox_version_path = userProfile + @"\AppData\Local\Roblox\Versions\";

            string roblox_newest_version = GetNewestDirectory(roblox_version_path);

            string roblox_newest_version_path = roblox_version_path + roblox_newest_version;

            Thread.Sleep(2000);

            return roblox_newest_version_path;
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gamebanana.com/sounds/62581");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statuslabel.Text = "Getting the latest Roblox version";
            var rbxver = GetRobloxVersion();
            statuslabel.Text = "Overwriting ouch.ogg";
            File.Copy(@"Resources\ouch.ogg", Path.Combine(rbxver, "content/sounds/ouch.ogg"), true);
            statuslabel.Text = "Bring Back Oof Sound has been successfully installed!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gamebanana.com/mods/301305");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statuslabel.Text = "Getting the latest Roblox version";
            var rbxver = GetRobloxVersion();
            statuslabel.Text = "Overwriting ArrowCursor.png";
            File.Copy(@"Resources\oldrobloxcursor\ArrowCursor.png", Path.Combine(rbxver, "content/textures/Cursors/KeyBoardMouse/ArrowCursor.png"), true);
            statuslabel.Text = "Overwriting ArrowFarCursor.png";
            File.Copy(@"Resources\oldrobloxcursor\ArrowFarCursor.png", Path.Combine(rbxver, "content/textures/Cursors/KeyBoardMouse/ArrowFarCursor.png"), true);
            statuslabel.Text = "Overwriting IBeamCursor.png";
            File.Copy(@"Resources\oldrobloxcursor\IBeamCursor.png", Path.Combine(rbxver, "content/textures/Cursors/KeyBoardMouse/IBeamCursor.png"), true);
            statuslabel.Text = "Old mouse cursor has been successfully installed!";
        }
    }
}
