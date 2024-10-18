namespace cerebral_cartography
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCircle = new Button();
            SuspendLayout();
            // 
            // btnAddCircle
            // 
            btnAddCircle.Location = new Point(12, 12);
            btnAddCircle.Name = "btnAddCircle";
            btnAddCircle.Size = new Size(75, 23);
            btnAddCircle.TabIndex = 0;
            btnAddCircle.Text = "Insert Title";
            btnAddCircle.UseVisualStyleBackColor = true;
            btnAddCircle.Click += btnAddCircle_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(735, 316);
            Controls.Add(btnAddCircle);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddCircle;
    }
}
