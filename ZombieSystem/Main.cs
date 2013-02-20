﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZombieSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Application.EnableVisualStyles();
            Program.API.OnWrite += new ZombieAPI.WriteHandler(API_OnWrite);

            boxshow(box_console);
        }

        void API_OnWrite(string msg)
        {
            console.Text += msg;
        }

        void boxshow(Panel p)
        {
            foreach (Control x in Controls)
            {
                if (x.Name.StartsWith("box_"))
                    x.Hide();
            }
            p.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
                switch (listView1.SelectedIndices[0])
                {
                    case 0:
                        boxshow(box_console);
                        break;
                    case 1:
                        boxshow(box_plugins);
                        plugin_init();
                        break;
                }
        }

        private void plugin_init()
        {
            listBox1.Items.Clear();
            foreach (ZombieAPI.jZmPlugin plug in Program.API.Plugins)
            {
                listBox1.Items.Add(plug.Name);
            }
            if (Program.API.Plugins.Length > 0)
                listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZombieAPI.jZmPlugin plug = Program.API.Plugins[listBox1.SelectedIndex];
            plug_name.Text = plug.Name;
            plug_author.Text = "By " + plug.Author;
            plug_desc.Text = plug.Desc;
        }
    }
}