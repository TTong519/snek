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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = SystemColors.ActiveCaptionText;
            Screen.ErrorImage = null;
            Screen.Location = new Point(0, 0);
            Screen.Name = "Screen";
            Screen.Size = new Size(400, 400);
            Screen.TabIndex = 0;
            Screen.TabStop = false;
            Screen.Click += Screen_Click;
            // 
            // tick
            // 
            tick.Enabled = true;
            tick.Interval = 200;
            tick.Tick += tick_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // Snek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 481);
            Controls.Add(Screen);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Snek";
            Text = "Snek";
            Load += Snek_Load;
            KeyDown += Snek_KeyDown;
            PreviewKeyDown += Snek_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Screen;
        private System.Windows.Forms.Timer tick;
        private Label label1;
        private Label label2;
    }
}
