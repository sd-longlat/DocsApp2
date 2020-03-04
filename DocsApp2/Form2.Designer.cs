namespace DocsApp2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelTill = new System.Windows.Forms.Label();
            this.labelBrunch = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTill
            // 
            this.labelTill.AutoSize = true;
            this.labelTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTill.Location = new System.Drawing.Point(12, 40);
            this.labelTill.Name = "labelTill";
            this.labelTill.Size = new System.Drawing.Size(85, 26);
            this.labelTill.TabIndex = 0;
            this.labelTill.Text = "Касса: ";
            // 
            // labelBrunch
            // 
            this.labelBrunch.AutoSize = true;
            this.labelBrunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBrunch.Location = new System.Drawing.Point(12, 9);
            this.labelBrunch.Name = "labelBrunch";
            this.labelBrunch.Size = new System.Drawing.Size(105, 26);
            this.labelBrunch.TabIndex = 1;
            this.labelBrunch.Text = "Филиал: ";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(12, 71);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(97, 26);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "Кассир: ";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(476, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(75, 26);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Дата: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelBrunch);
            this.Controls.Add(this.labelTill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTill;
        private System.Windows.Forms.Label labelBrunch;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Timer timer1;
    }
}