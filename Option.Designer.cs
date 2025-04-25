
namespace dsaproject_hashing
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lin = new System.Windows.Forms.Button();
            this.qud = new System.Windows.Forms.Button();
            this.db = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(402, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASH CALCULATOR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the hashing technique";
            // 
            // lin
            // 
            this.lin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lin.Location = new System.Drawing.Point(95, 247);
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(284, 151);
            this.lin.TabIndex = 2;
            this.lin.Text = "LINEAR PROBING";
            this.lin.UseVisualStyleBackColor = false;
            this.lin.Click += new System.EventHandler(this.lin_Click);
            // 
            // qud
            // 
            this.qud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.qud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qud.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.qud.Location = new System.Drawing.Point(473, 247);
            this.qud.Name = "qud";
            this.qud.Size = new System.Drawing.Size(284, 151);
            this.qud.TabIndex = 3;
            this.qud.Text = "QUADRATIC PROBING";
            this.qud.UseVisualStyleBackColor = false;
            this.qud.Click += new System.EventHandler(this.qud_Click);
            // 
            // db
            // 
            this.db.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.db.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.db.Location = new System.Drawing.Point(833, 247);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(284, 151);
            this.db.TabIndex = 4;
            this.db.Text = "DOUBLE HASHING";
            this.db.UseVisualStyleBackColor = false;
            this.db.Click += new System.EventHandler(this.db_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlText;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Location = new System.Drawing.Point(915, 607);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(246, 47);
            this.back.TabIndex = 5;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1221, 703);
            this.Controls.Add(this.back);
            this.Controls.Add(this.db);
            this.Controls.Add(this.qud);
            this.Controls.Add(this.lin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Option";
            this.Text = "Hash Calculator";
            this.Load += new System.EventHandler(this.Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lin;
        private System.Windows.Forms.Button qud;
        private System.Windows.Forms.Button db;
        private System.Windows.Forms.Button back;
    }
}