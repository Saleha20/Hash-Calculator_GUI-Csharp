
namespace dsaproject_hashing
{
    partial class Input
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Input));
            this.size = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.addedvalues = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enterbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(477, 110);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(167, 26);
            this.size.TabIndex = 0;
            this.size.TextChanged += new System.EventHandler(this.size_TextChanged);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(477, 184);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(167, 26);
            this.value.TabIndex = 1;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the size of table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADDED VALUES";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(735, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(207, 42);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(775, 310);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 41);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(775, 390);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(167, 41);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.next.Location = new System.Drawing.Point(907, 616);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(252, 48);
            this.next.TabIndex = 8;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // addedvalues
            // 
            this.addedvalues.FormattingEnabled = true;
            this.addedvalues.ItemHeight = 20;
            this.addedvalues.Location = new System.Drawing.Point(411, 293);
            this.addedvalues.Name = "addedvalues";
            this.addedvalues.Size = new System.Drawing.Size(290, 164);
            this.addedvalues.TabIndex = 9;
            this.addedvalues.SelectedIndexChanged += new System.EventHandler(this.addedvalues_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "HASH CALCULATOR";
            // 
            // enterbtn
            // 
            this.enterbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbtn.Location = new System.Drawing.Point(814, 513);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(199, 41);
            this.enterbtn.TabIndex = 11;
            this.enterbtn.Text = "Enter";
            this.enterbtn.UseVisualStyleBackColor = false;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(663, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please fill all the fields then press the enter button to continue";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1221, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addedvalues);
            this.Controls.Add(this.next);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Input";
            this.Text = "Hash Calculator";
            this.Load += new System.EventHandler(this.Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ListBox addedvalues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Label label5;
    }
}