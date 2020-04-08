using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PhotosApi.Model;
//using PhotosApi.API;
using System.Text.RegularExpressions;
using System.IO;

using System.ServiceModel;

namespace MyPhotosGui
{
    public partial class Form1 : Form
    {
     
        // de facut checkbox + button delete + label nume resursa
        Point loc = new Point(50, 80);
        InterfaceWCFClient api = new InterfaceWCFClient();
        
        //resAPI api = new resAPI();
        internal void LoadPhotos(List<resources> r )
        {
            loc = new Point(50, 80);
            PanelBottom.Controls.Clear();
            foreach (var i in r)
            {
                Label l = new Label();
                CheckBox check = new CheckBox();

                check.Checked = false;
                check.Tag = i.path;
                check.Location = new Point(loc.X, loc.Y - 20);
                l.Text = i.path.Split(Path.DirectorySeparatorChar).Last();
                l.Location = new Point(loc.X, loc.Y + 150);
                l.BackColor = Color.White;
                l.Width = 150;
                
                PictureBox p = new PictureBox();

                p.Size = new Size(150, 150);
                p.Location = loc;
                if (i.type == "video")
                {
                    p.Image = new Bitmap(@"..\..\imgs\video.jpg");
                    //p.BackColor = Color.Azure;
                }
                else
                {
                    p.Image = new Bitmap(i.path);
                }
                p.Tag = i.path;
                p.SizeMode = PictureBoxSizeMode.Zoom;
                PanelBottom.Controls.Add(p);
                PanelBottom.Controls.Add(l);
                PanelBottom.Controls.Add(check);

                if (loc.X == 850)
                {
                    loc.X = 50;
                    loc.Y += 250;
                    //LoadMainRes(i.path);
                }
                else
                {
                    loc.X += 200;
                }

            }

        }

        int type = 0; // type = 0 - image, type = 1 - video
        internal void LoadComboBoxAtributes()
        {
            var atr = api.getAllAtributes();
            comboBoxAtr.Items.Clear();
            foreach (var x in atr)
            {
                comboBoxAtr.Items.Add(x);
            }
        }

        internal void loadMain(string path)
        {

            Regex regex = new Regex(@"(\S*avi$)|(\S*mp4$)");
            Match match = regex.Match(path);
            if (match.Success)
            {

                pictureBoxMain.Hide();
                axWindowsMediaPlayerMain.Show();
                axWindowsMediaPlayerMain.Ctlcontrols.stop();

                axWindowsMediaPlayerMain.URL = path;
                type = 1;

                

            }
            else
            {
                axWindowsMediaPlayerMain.Hide();
                axWindowsMediaPlayerMain.Ctlcontrols.stop();
                pictureBoxMain.Show();
                pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxMain.Image = new Bitmap(path);
                pictureBoxMain.Tag = path;
                type = 0;
            }

            var a = api.getAllAtribtuesForResource(path);
            TextBoxResDesc.Text = "";
            foreach (var x in a)
            {
                TextBoxResDesc.Text += x.name + ": " + x.description;
                TextBoxResDesc.Text += Environment.NewLine;
            }


        }

        private void LoadMainRes(object sender, System.EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            loadMain(p.Tag.ToString());
        }

        internal void AddEventHndOnImg()
        {
            foreach(var x in PanelBottom.Controls.OfType<PictureBox>())
            {
                x.Click += new EventHandler(LoadMainRes);
            }

        }


        Form2 addMedia;
        private void BtnAddMedia_Click(object sender, EventArgs e)
        {
            addMedia = new Form2(this);
            addMedia.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            var search = TextBoxSearch.Text;
            List<resources> r = api.getResourcesByQueryAtribute(comboBoxAtr.Text, search);
            LoadPhotos(r);
            AddEventHndOnImg();
            if (r.Count() >= 1)
                loadMain(r[0].path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // done ///
        private void init()
        {
            var r = api.getAllResources();
            axWindowsMediaPlayerMain.Hide();
            if (r.Count() >= 1)
            {
                if (r[0].type == "image")
                {
                    axWindowsMediaPlayerMain.Hide();
                    axWindowsMediaPlayerMain.Ctlcontrols.stop();
                    pictureBoxMain.Show();

                    pictureBoxMain.Image = new Bitmap(r[0].path);
                    pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                    var a = api.getAllAtribtuesForResource(r[0].path);
                    TextBoxResDesc.Text = "";
                    foreach (var x in a)
                    {
                        TextBoxResDesc.Text += x.name + ": " + x.description;
                        TextBoxResDesc.Text += Environment.NewLine;
                    }
                }
                else if (r[0].type == "video")
                {
                    pictureBoxMain.Hide();
                    axWindowsMediaPlayerMain.Show();

                    axWindowsMediaPlayerMain.URL = r[0].path;
                    var a = api.getAllAtribtuesForResource(r[0].path);
                    TextBoxResDesc.Text = "";
                    foreach (var x in a)
                    {
                        TextBoxResDesc.Text += x.name + ": " + x.description;
                        TextBoxResDesc.Text += Environment.NewLine;
                    }
                }
            }
            LoadPhotos(r);
            AddEventHndOnImg();
            LoadComboBoxAtributes();
        }
        public Form1()
        {
            InitializeComponent();

            init();

        }

        private void BtnPhotos_Click(object sender, EventArgs e)
        {
            var r = api.getAllPhotos();
            LoadPhotos(r);
            AddEventHndOnImg();
            if(r.Count() >=1)
                loadMain(r[0].path);
        }

        private void BtnVideos_Click(object sender, EventArgs e)
        {
            var r = api.getAllVideos();
            LoadPhotos(r);
            AddEventHndOnImg();
            if (r.Count() >= 1)
                loadMain(r[0].path);
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            var r = api.getAllResources();
            LoadPhotos(r);
            AddEventHndOnImg();
            if (r.Count() >= 1)
                loadMain(r[0].path);
        }

        Form3 update;
    

        private void axWindowsMediaPlayerMain_Enter(object sender, EventArgs e)
        {
            update = new Form3(this, sender, type);
            update.Show();
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            update = new Form3(this, sender, type);
            update.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            foreach (var x in PanelBottom.Controls.OfType<CheckBox>())
            {
                if(x.Checked == true)
                {
                    paths.Add(x.Tag.ToString());
                }
            }

            api.deleteResources(paths);

            var r = api.getAllResources();
            LoadPhotos(r);
            AddEventHndOnImg();
            if (r.Count() >= 1)
                loadMain(r[0].path);

        }
    }
}
