namespace _3zh
{
    partial class newdataform
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
            listBox1 = new ListBox();
            textname = new TextBox();
            buttonsave = new Button();
            buttoncancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 0;
            // 
            // textname
            // 
            textname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textname.Location = new Point(138, 29);
            textname.Name = "textname";
            textname.Size = new Size(100, 23);
            textname.TabIndex = 1;
            // 
            // buttonsave
            // 
            buttonsave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonsave.Location = new Point(163, 146);
            buttonsave.Name = "buttonsave";
            buttonsave.Size = new Size(75, 23);
            buttonsave.TabIndex = 2;
            buttonsave.Text = "Mentés";
            buttonsave.UseVisualStyleBackColor = true;
            buttonsave.Click += buttonsave_Click;
            // 
            // buttoncancel
            // 
            buttoncancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttoncancel.Location = new Point(163, 175);
            buttoncancel.Name = "buttoncancel";
            buttoncancel.Size = new Size(75, 23);
            buttoncancel.TabIndex = 3;
            buttoncancel.Text = "Mégse";
            buttoncancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Márka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Model neve:";
            // 
            // newdataform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 228);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttoncancel);
            Controls.Add(buttonsave);
            Controls.Add(textname);
            Controls.Add(listBox1);
            Name = "newdataform";
            Text = "newdataform";
            Load += newdataform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textname;
        private Button buttonsave;
        private Button buttoncancel;
        private Label label1;
        private Label label2;
    }
}