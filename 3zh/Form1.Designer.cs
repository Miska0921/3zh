namespace _3zh
{
    partial class Form1
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            buttonData = new Button();
            buttonNew = new Button();
            buttonmodel = new Button();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 326);
            panel1.TabIndex = 0;
            // 
            // buttonData
            // 
            buttonData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonData.Location = new Point(12, 344);
            buttonData.Name = "buttonData";
            buttonData.Size = new Size(91, 57);
            buttonData.TabIndex = 1;
            buttonData.Text = "Eladó járművek";
            buttonData.UseVisualStyleBackColor = true;
            buttonData.Click += buttonData_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonNew.Location = new Point(125, 344);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(91, 57);
            buttonNew.TabIndex = 2;
            buttonNew.Text = "Új jármű felvétele";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonmodel
            // 
            buttonmodel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonmodel.Location = new Point(521, 344);
            buttonmodel.Name = "buttonmodel";
            buttonmodel.Size = new Size(95, 57);
            buttonmodel.TabIndex = 3;
            buttonmodel.Text = "Új model felvétele";
            buttonmodel.UseVisualStyleBackColor = true;
            buttonmodel.Click += buttonmodel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 413);
            Controls.Add(buttonmodel);
            Controls.Add(buttonNew);
            Controls.Add(buttonData);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button buttonData;
        private Button buttonNew;
        private Button buttonmodel;
    }
}