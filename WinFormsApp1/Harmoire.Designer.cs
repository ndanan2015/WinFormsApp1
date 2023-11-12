namespace WinFormsApp1
{
    partial class Harmoire
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
            groupBox1 = new GroupBox();
            button_jdb = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.harmoire;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Location = new Point(514, -8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 471);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button_jdb
            // 
            button_jdb.BackColor = SystemColors.ButtonFace;
            button_jdb.Location = new Point(388, 106);
            button_jdb.Name = "button_jdb";
            button_jdb.Size = new Size(75, 23);
            button_jdb.TabIndex = 0;
            button_jdb.UseVisualStyleBackColor = false;
            button_jdb.Click += button_jdb_Click;
            // 
            // Harmoire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 501);
            Controls.Add(button_jdb);
            Controls.Add(groupBox1);
            Name = "Harmoire";
            Text = "Harmoire";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_jdb;
    }
}