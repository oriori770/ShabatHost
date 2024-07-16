namespace ShabatHost.Views
{
    partial class ShabatHostForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            buttonInsert = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 83);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome dear host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 159);
            label2.Name = "label2";
            label2.Size = new Size(312, 41);
            label2.TabIndex = 1;
            label2.Text = "Insert categories page";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 47);
            textBox1.TabIndex = 2;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(303, 374);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(243, 104);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "insert";
            buttonInsert.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(257, 538);
            listView1.Name = "listView1";
            listView1.Size = new Size(329, 401);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ShabatHost
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 1056);
            Controls.Add(listView1);
            Controls.Add(buttonInsert);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShabatHost";
            Text = "ShabatHost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button buttonInsert;
        private ListView listView1;
    }
}