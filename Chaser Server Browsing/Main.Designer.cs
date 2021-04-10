
namespace Chaser_Server_Browsing
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Servers = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.map = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.players = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetList = new System.Windows.Forms.Button();
            this.playerlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Servers
            // 
            this.Servers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.map,
            this.players,
            this.type,
            this.ip,
            this.port});
            this.Servers.FullRowSelect = true;
            this.Servers.HideSelection = false;
            this.Servers.Location = new System.Drawing.Point(89, 12);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(663, 260);
            this.Servers.TabIndex = 0;
            this.Servers.UseCompatibleStateImageBehavior = false;
            this.Servers.View = System.Windows.Forms.View.Details;
            this.Servers.SelectedIndexChanged += new System.EventHandler(this.Servers_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 161;
            // 
            // map
            // 
            this.map.Text = "Map";
            this.map.Width = 87;
            // 
            // players
            // 
            this.players.Text = "Players";
            this.players.Width = 67;
            // 
            // type
            // 
            this.type.Text = "Game Type";
            this.type.Width = 91;
            // 
            // ip
            // 
            this.ip.Text = "IP";
            this.ip.Width = 100;
            // 
            // port
            // 
            this.port.Text = "Port";
            // 
            // GetList
            // 
            this.GetList.Location = new System.Drawing.Point(13, 12);
            this.GetList.Name = "GetList";
            this.GetList.Size = new System.Drawing.Size(70, 40);
            this.GetList.TabIndex = 1;
            this.GetList.Text = "Get List";
            this.GetList.UseVisualStyleBackColor = true;
            this.GetList.Click += new System.EventHandler(this.GetList_Click);
            // 
            // playerlist
            // 
            this.playerlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.playerlist.HideSelection = false;
            this.playerlist.Location = new System.Drawing.Point(89, 295);
            this.playerlist.Name = "playerlist";
            this.playerlist.Size = new System.Drawing.Size(236, 178);
            this.playerlist.TabIndex = 2;
            this.playerlist.UseCompatibleStateImageBehavior = false;
            this.playerlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ping";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Team";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 485);
            this.Controls.Add(this.playerlist);
            this.Controls.Add(this.GetList);
            this.Controls.Add(this.Servers);
            this.Name = "Main";
            this.Text = "Server List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Servers;
        private System.Windows.Forms.Button GetList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader map;
        private System.Windows.Forms.ColumnHeader players;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ListView playerlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

