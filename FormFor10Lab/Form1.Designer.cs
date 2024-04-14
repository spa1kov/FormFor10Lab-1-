namespace FormFor10Lab
{
    partial class Объём
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Объём));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            B = new TextBox();
            A = new TextBox();
            C = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ForeColor = Color.CornflowerBlue;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += textBox1_TextChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.FlatStyle = FlatStyle.Flat;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // B
            // 
            resources.ApplyResources(B, "B");
            B.Name = "B";
            // 
            // A
            // 
            resources.ApplyResources(A, "A");
            A.Name = "A";
            // 
            // C
            // 
            resources.ApplyResources(C, "C");
            C.Name = "C";
            // 
            // Объём
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(C);
            Controls.Add(A);
            Controls.Add(B);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Объём";
            Load += Объём_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox B;
        private TextBox A;
        private TextBox C;
    }
}