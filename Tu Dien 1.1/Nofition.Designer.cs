namespace Tu_Dien_1._1
{
    partial class Nofition
    {  /// <summary>
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
            this.components = new System.ComponentModel.Container();
            this.lbVoca = new System.Windows.Forms.Label();
            this.lbMean = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbCheckChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVoca
            // 
            this.lbVoca.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoca.ForeColor = System.Drawing.Color.Red;
            this.lbVoca.Location = new System.Drawing.Point(21, 11);
            this.lbVoca.Name = "lbVoca";
            this.lbVoca.Size = new System.Drawing.Size(261, 50);
            this.lbVoca.TabIndex = 0;
            this.lbVoca.TextChanged += new System.EventHandler(this.lbVoca_TextChanged);
            // 
            // lbMean
            // 
            this.lbMean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMean.ForeColor = System.Drawing.Color.White;
            this.lbMean.Location = new System.Drawing.Point(21, 71);
            this.lbMean.Name = "lbMean";
            this.lbMean.Size = new System.Drawing.Size(261, 44);
            this.lbMean.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbCheckChange
            // 
            this.lbCheckChange.AutoSize = true;
            this.lbCheckChange.ForeColor = System.Drawing.Color.White;
            this.lbCheckChange.Location = new System.Drawing.Point(152, 79);
            this.lbCheckChange.Name = "lbCheckChange";
            this.lbCheckChange.Size = new System.Drawing.Size(35, 13);
            this.lbCheckChange.TabIndex = 2;
            this.lbCheckChange.Text = "label1";
            this.lbCheckChange.Visible = false;
            this.lbCheckChange.TextChanged += new System.EventHandler(this.lbCheckChange_TextChanged);
            // 
            // Nofition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(294, 124);
            this.Controls.Add(this.lbCheckChange);
            this.Controls.Add(this.lbMean);
            this.Controls.Add(this.lbVoca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nofition";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nofition";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Nofition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVoca;
        private System.Windows.Forms.Label lbMean;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbCheckChange;
    }
}