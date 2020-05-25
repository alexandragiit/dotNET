namespace MyPhotosGui
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.PanelAtributes = new System.Windows.Forms.Panel();
            this.BtnAddAtr = new System.Windows.Forms.Button();
            this.LabelDesc = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(548, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDesc.Location = new System.Drawing.Point(254, 392);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(405, 26);
            this.textBoxDesc.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(254, 344);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(405, 26);
            this.textBoxName.TabIndex = 13;
            // 
            // PanelAtributes
            // 
            this.PanelAtributes.Location = new System.Drawing.Point(145, 60);
            this.PanelAtributes.Name = "PanelAtributes";
            this.PanelAtributes.Size = new System.Drawing.Size(514, 265);
            this.PanelAtributes.TabIndex = 12;
            // 
            // BtnAddAtr
            // 
            this.BtnAddAtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAddAtr.Location = new System.Drawing.Point(145, 440);
            this.BtnAddAtr.Name = "BtnAddAtr";
            this.BtnAddAtr.Size = new System.Drawing.Size(187, 33);
            this.BtnAddAtr.TabIndex = 11;
            this.BtnAddAtr.Text = "add new atribute";
            this.BtnAddAtr.UseVisualStyleBackColor = true;
            this.BtnAddAtr.Click += new System.EventHandler(this.BtnAddAtr_Click);
            // 
            // LabelDesc
            // 
            this.LabelDesc.AutoSize = true;
            this.LabelDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelDesc.Location = new System.Drawing.Point(142, 392);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Padding = new System.Windows.Forms.Padding(5);
            this.LabelDesc.Size = new System.Drawing.Size(91, 27);
            this.LabelDesc.TabIndex = 10;
            this.LabelDesc.Text = "description:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelName.Location = new System.Drawing.Point(142, 345);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.LabelName.Size = new System.Drawing.Size(91, 27);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "name:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.PanelAtributes);
            this.Controls.Add(this.BtnAddAtr);
            this.Controls.Add(this.LabelDesc);
            this.Controls.Add(this.LabelName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel PanelAtributes;
        private System.Windows.Forms.Button BtnAddAtr;
        private System.Windows.Forms.Label LabelDesc;
        private System.Windows.Forms.Label LabelName;
    }
}