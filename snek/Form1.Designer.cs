namespace snek
{
    partial class Snek
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Screen = new PictureBox();
            tick = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = SystemColors.ActiveCaptionText;
            Screen.Dock = DockStyle.Fill;
            Screen.Location = new Point(0, 0);
            Screen.Name = "Screen";
            Screen.Size = new Size(804, 801);
            Screen.TabIndex = 0;
            Screen.TabStop = false;
            // 
            // tick
            // 
            tick.Enabled = true;
            tick.Interval = 16;
            tick.Tick += tick_Tick;
            // 
            // Snek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 801);
            Controls.Add(Screen);
            Name = "Snek";
            Text = "Snek";
            Load += Snek_Load;
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Screen;
        private System.Windows.Forms.Timer tick;
    }
}
