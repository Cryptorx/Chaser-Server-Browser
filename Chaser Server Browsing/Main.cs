using System;
using System.Windows.Forms;

namespace Chaser_Server_Browsing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GetList_Click(object sender, EventArgs e)
        {
            Servers.Items.Clear();
            Query.Server_List.MasterList List = new Query.Server_List.MasterList();
            foreach(string server in List.GetServers())
            {
                Parse(server);
            }
        }
        private void Parse(string server)
        {
            Query.Query_Server.QueryServer ServerData = new Query.Query_Server.QueryServer();
            string ip = server.Split(':')[0];
            string port = server.Split(':')[1].Split(' ')[0];
            string returndata = ServerData.QueryS(ip, Convert.ToInt32(port));
            string name = returndata.Substring(returndata.IndexOf("hostname")).Split('\\')[1];
            string map = returndata.Substring(returndata.IndexOf("mapname")).Split('\\')[1];
            string players = returndata.Substring(returndata.IndexOf("numplayers")).Split('\\')[1] + "/" + returndata.Substring(returndata.IndexOf("maxplayers")).Split('\\')[1];
            string type = returndata.Substring(returndata.IndexOf("gametype")).Split('\\')[1];
            ListViewItem add = new ListViewItem(new string[] { name, map, players, type, ip, port });
            Servers.Items.Add(add);
        }

        private void Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerlist.Items.Clear();
            string ip = Servers.SelectedItems[0].SubItems[4].Text;
            string port = Servers.SelectedItems[0].SubItems[5].Text;
            Query.Query_Server.QueryServer ServerData = new Query.Query_Server.QueryServer();
            string returndata = ServerData.QueryS(ip, Convert.ToInt32(port));
            string players = returndata.Substring(returndata.IndexOf("numplayers")).Split('\\')[1];

            for (int i = 0; i < Convert.ToInt32(players); i++)
            {
                string player = returndata.Substring(returndata.IndexOf("player_" + i)).Split('\\')[1];
                string ping = returndata.Substring(returndata.IndexOf("ping_" + i)).Split('\\')[1];
                string team = returndata.Substring(returndata.IndexOf("team_" + i)).Split('\\')[1];
                ListViewItem add = new ListViewItem(new string[] { player, ping, team });
                playerlist.Items.Add(add);
            }
        }
    }
}