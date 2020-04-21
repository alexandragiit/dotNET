using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyPhotosGui
{
    public partial class Form3 : Form
    {
        //resAPI api = new resAPI();
        InterfaceWCFClient api = new InterfaceWCFClient();
        Form1 f;
        Object sender;
        int type;
        public Form3(Form1 f, Object s, int t)
        {
            InitializeComponent();
            sender = s;
            type = t;
            this.f = f;
            ShowInitialAtributes();
        }
        Point lastPoz = new Point(0, 0);
        int currentAtrCount = 0;
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void ShowInitialAtributes()
        {
            
            if(type == 0)
            {
                //PictureBox p = (PictureBox)sender;
                PictureBox p = (PictureBox)f.Controls.Find("pictureBoxMain", true)[0];
                var a = api.getAllAtribtuesForResource(p.Tag.ToString());
                foreach (var x in a)
                {

                    Label l = new Label();
                    l.Text = x.name;
                    l.Location = lastPoz;
                    PanelAtributes.Controls.Add(l);

                    lastPoz.X += 100;
                    TextBox t = new TextBox();
                    t.Text = x.description;
                    t.Location = lastPoz;
                    PanelAtributes.Controls.Add(t);
                    lastPoz.Y += 25;
                    lastPoz.X = 0;
                }

            }
            else
            {
                //AxWMPLib.AxWindowsMediaPlayer p = (AxWMPLib.AxWindowsMediaPlayer)sender;
                AxWMPLib.AxWindowsMediaPlayer p = (AxWMPLib.AxWindowsMediaPlayer)f.Controls.Find("axWindowsMediaPlayerMain", true)[0];
                var a = api.getAllAtribtuesForResource(p.URL);
                foreach (var x in a)
                {
                    Label l = new Label();
                    l.Text = x.name;
                    l.Location = lastPoz;
                    PanelAtributes.Controls.Add(l);

                    lastPoz.X += 100;
                    TextBox t = new TextBox();
                    t.Text = x.description;
                    t.Location = lastPoz;
                    PanelAtributes.Controls.Add(t);
                    lastPoz.Y += 25;
                    lastPoz.X = 0;
                }
            }

 

        }
        
        
        private void ShowAtributesOnAdd()
        {
            Label lbl = new Label();
            lbl.Text = textBoxName.Text;
            lbl.Location = lastPoz;

            lastPoz.X += 100;
            TextBox txt = new TextBox();
            txt.Text = textBoxDesc.Text;
            txt.Location = lastPoz;
            lastPoz.Y += 25;
            lastPoz.X = 0;

            PanelAtributes.Controls.Add(lbl);
            PanelAtributes.Controls.Add(txt);

        }

        private void BtnAddAtr_Click(object sender, EventArgs e)
        {
            ShowAtributesOnAdd();
        }

        private void button1_Click(object s, EventArgs e)
        {
            // save button
            string name, desc;

            List<string> atrib = new List<string>();
            for (var i = 0; i < PanelAtributes.Controls.Count; i += 2)
            {
                name = PanelAtributes.Controls[i].Text;
                desc = PanelAtributes.Controls[i + 1].Text;
                if (name != "" && desc != "")
                {
                    atrib.Add(name);
                    atrib.Add(desc);
                }
            }

            if (type == 0)
            {
                //PictureBox p = (PictureBox)sender;
                PictureBox p = (PictureBox)f.Controls.Find("pictureBoxMain", true)[0];
                api.updateResource(p.Tag.ToString(), atrib);
                f.loadMain(p.Tag.ToString());

            }
            else
            {
                //AxWMPLib.AxWindowsMediaPlayer p = (AxWMPLib.AxWindowsMediaPlayer)sender; axWindowsMediaPlayerMain
                AxWMPLib.AxWindowsMediaPlayer p = (AxWMPLib.AxWindowsMediaPlayer)f.Controls.Find("axWindowsMediaPlayerMain", true)[0];
                api.updateResource(p.URL, atrib);
                f.loadMain(p.URL);
            }

            // salvez in bd imagini/video + atributele lor
            // api.saveResources(TextBoxPath.Text, type, atrib);
            //api.updateResource()
            // reload photos in app
            var r = api.getAllResources();
            f.LoadPhotos(r);
            f.LoadComboBoxAtributes();
            f.AddEventHndOnImg();
            

            Hide();

        }
    }
}
