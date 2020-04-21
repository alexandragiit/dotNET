namespace MyPhotosGui
{
    partial class Form2
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
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.BtnGetPath = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDesc = new System.Windows.Forms.Label();
            this.BtnAddAtr = new System.Windows.Forms.Button();
            this.PanelAtributes = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxPath.Location = new System.Drawing.Point(142, 42);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(378, 23);
            this.TextBoxPath.TabIndex = 0;
            // 
            // BtnGetPath
            // 
            this.BtnGetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnGetPath.Location = new System.Drawing.Point(545, 37);
            this.BtnGetPath.Name = "BtnGetPath";
            this.BtnGetPath.Size = new System.Drawing.Size(111, 33);
            this.BtnGetPath.TabIndex = 1;
            this.BtnGetPath.Text = "find media";
            this.BtnGetPath.UseVisualStyleBackColor = true;
            this.BtnGetPath.Click += new System.EventHandler(this.BtnGetPath_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelName.Location = new System.Drawing.Point(139, 371);
            this.LabelName.Name = "LabelName";
            this.LabelName.Padding = new System.Windows.Forms.Padding(22, 5, 22, 5);
            this.LabelName.Size = new System.Drawing.Size(91, 27);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "name:";
            // 
            // LabelDesc
            // 
            this.LabelDesc.AutoSize = true;
            this.LabelDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelDesc.Location = new System.Drawing.Point(139, 418);
            this.LabelDesc.Name = "LabelDesc";
            this.LabelDesc.Padding = new System.Windows.Forms.Padding(5);
            this.LabelDesc.Size = new System.Drawing.Size(91, 27);
            this.LabelDesc.TabIndex = 3;
            this.LabelDesc.Text = "description:";
            // 
            // BtnAddAtr
            // 
            this.BtnAddAtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAddAtr.Location = new System.Drawing.Point(142, 466);
            this.BtnAddAtr.Name = "BtnAddAtr";
            this.BtnAddAtr.Size = new System.Drawing.Size(187, 33);
            this.BtnAddAtr.TabIndex = 4;
            this.BtnAddAtr.Text = "add new atribute";
            this.BtnAddAtr.UseVisualStyleBackColor = true;
            this.BtnAddAtr.Click += new System.EventHandler(this.BtnAddAtr_Click);
            // 
            // PanelAtributes
            // 
            this.PanelAtributes.Location = new System.Drawing.Point(142, 86);
            this.PanelAtributes.Name = "PanelAtributes";
            this.PanelAtributes.Size = new System.Drawing.Size(514, 265);
            this.PanelAtributes.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(251, 370);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(405, 26);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDesc.Location = new System.Drawing.Point(251, 418);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(405, 26);
            this.textBoxDesc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(545, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.PanelAtributes);
            this.Controls.Add(this.BtnAddAtr);
            this.Controls.Add(this.LabelDesc);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.BtnGetPath);
            this.Controls.Add(this.TextBoxPath);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Button BtnGetPath;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDesc;
        private System.Windows.Forms.Button BtnAddAtr;
        private System.Windows.Forms.Panel PanelAtributes;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button button1;
    }
}