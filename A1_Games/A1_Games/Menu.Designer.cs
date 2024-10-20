namespace A1_Games
{
    partial class Menu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.ForeColor = Color.CornflowerBlue;
            btnStart.Location = new Point(299, 298);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(224, 57);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(0, 103);
            label1.Name = "label1";
            label1.Size = new Size(822, 95);
            label1.TabIndex = 1;
            label1.Text = "HangMan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(0, 198);
            label2.Name = "label2";
            label2.Size = new Size(822, 43);
            label2.TabIndex = 2;
            label2.Text = "Guess the secret words";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Name = "Menu";
            Size = new Size(822, 519);
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Label label1;
        private Label label2;
    }
}
