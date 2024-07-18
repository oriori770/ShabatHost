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
            textBoxInsert = new TextBox();
            buttonInsert = new Button();
            listBoxCategories = new ListBox();
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
            // textBoxInsert
            // 
            textBoxInsert.Location = new Point(204, 277);
            textBoxInsert.Name = "textBoxInsert";
            textBoxInsert.Size = new Size(470, 47);
            textBoxInsert.TabIndex = 2;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(303, 374);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(243, 104);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // listBoxCategories
            // 
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 41;
            listBoxCategories.Location = new Point(246, 525);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(365, 209);
            listBoxCategories.TabIndex = 5;
            // 
            // ShabatHostForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 1056);
            Controls.Add(listBoxCategories);
            Controls.Add(buttonInsert);
            Controls.Add(textBoxInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ShabatHostForm";
            Text = "ShabatHost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxInsert;
        private Button buttonInsert;
        private ListBox listBoxCategories;
    }
}