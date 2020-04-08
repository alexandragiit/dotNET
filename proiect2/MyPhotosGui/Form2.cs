using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotosApi.Model;
//using PhotosApi.API;
using System.Text.RegularExpressions;

namespace MyPhotosGui
{
    public partial class Form2 : Form
    {
        resAPI api = new resAPI();
        Form1 f;
        public Form2(Form1 f)
        {
            InitializeComponent();
            currentAtrCount = ShowAtributesOnMainPanel()*2;
            this.f = f;
        }

        Point lastPoz = new Point(0, 0);
        int currentAtrCount = 0;

       

        private int ShowAtributesOnMainPanel()
        {
            var cnt = 0;
            
            var atr = api.getAllAtributes() ;
                
            foreach(var x in atr)
            {
                cnt += 1;
                Label l = new Label();
                l.Text = x;
                l.Location = lastPoz;
                PanelAtributes.Controls.Add(l);

                lastPoz.X += 100;
                TextBox t = new TextBox();
                t.Location = lastPoz;
                PanelAtributes.Controls.Add(t);
                lastPoz.Y += 25;
                lastPoz.X = 0;
            }

            
            return cnt;
        }

        private void BtnGetPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Video Files(*.jpg; *.jpeg; *.gif; *.bmp; *.avi; *.mp4; *.flv)|*.jpg; *.jpeg; *.gif; *.bmp; *.avi; *.mp4; *.flv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                var r = api.getAllResources();
                var exists = 0;
                foreach(var i in r)
                {
                    if(i.path == open.FileName)
                    {
                        exists = 1;
                        MessageBox.Show("Resursa exista deja in aplicatie!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if(exists == 0) 
                    TextBoxPath.Text = open.FileName;
            }
        }

        private void SaveImage()
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        
        // save button
        private void button1_Click(object sender, EventArgs e)
        {
            // save button
            string name, desc, type;
            if (TextBoxPath.Text == "")
            {
                MessageBox.Show("Empty path!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

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
                Regex regex = new Regex(@"(\S*avi$)|(\S*mp4$)");
                Match match = regex.Match(TextBoxPath.Text);

                if (match.Success)
                {
                    type = "video";
                }
                else
                {
                    type = "image";
                }

                // salvez in bd imagini/video + atributele lor
                api.saveResources(TextBoxPath.Text, type, atrib);

                // reload photos in app
                var r = api.getAllResources();
                f.LoadPhotos(r);
                f.LoadComboBoxAtributes();
                f.AddEventHndOnImg();

                Hide();
            }
        }
    }


}
