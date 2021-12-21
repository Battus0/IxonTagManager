namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OutputfileTags = new System.Windows.Forms.TextBox();
            this.OutputFileFars = new System.Windows.Forms.TextBox();
            this.UAexpertFilebox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(952, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OutputfileTags
            // 
            this.OutputfileTags.Location = new System.Drawing.Point(12, 156);
            this.OutputfileTags.Name = "OutputfileTags";
            this.OutputfileTags.Size = new System.Drawing.Size(155, 20);
            this.OutputfileTags.TabIndex = 2;
            this.OutputfileTags.Text = "OutputFileTags";
            // 
            // OutputFileFars
            // 
            this.OutputFileFars.Location = new System.Drawing.Point(12, 182);
            this.OutputFileFars.Name = "OutputFileFars";
            this.OutputFileFars.Size = new System.Drawing.Size(155, 20);
            this.OutputFileFars.TabIndex = 3;
            this.OutputFileFars.Text = "OutputFileVariables";
            // 
            // UAexpertFilebox
            // 
            this.UAexpertFilebox.Location = new System.Drawing.Point(13, 106);
            this.UAexpertFilebox.Name = "UAexpertFilebox";
            this.UAexpertFilebox.Size = new System.Drawing.Size(281, 20);
            this.UAexpertFilebox.TabIndex = 4;
            this.UAexpertFilebox.Text = "UAexpert File";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UAexpertFilebox);
            this.Controls.Add(this.OutputFileFars);
            this.Controls.Add(this.OutputfileTags);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "tex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox OutputfileTags;
        private System.Windows.Forms.TextBox OutputFileFars;
        private System.Windows.Forms.TextBox UAexpertFilebox;
        private System.Windows.Forms.Button button2;
    }
}

