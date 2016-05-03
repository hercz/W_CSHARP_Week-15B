namespace WindowsFormsApplication1
{
    partial class Serializer
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previous_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(15, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(360, 20);
            this.name_textBox.TabIndex = 0;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(15, 64);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(360, 20);
            this.address_textBox.TabIndex = 1;
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(15, 103);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(360, 20);
            this.phone_txtbox.TabIndex = 2;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(12, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name:";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(12, 48);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(48, 13);
            this.address_lbl.TabIndex = 4;
            this.address_lbl.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // previous_btn
            // 
            this.previous_btn.Location = new System.Drawing.Point(15, 135);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(75, 23);
            this.previous_btn.TabIndex = 6;
            this.previous_btn.Text = "Previous";
            this.previous_btn.UseVisualStyleBackColor = true;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(96, 135);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(177, 135);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Serializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 168);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.previous_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "Serializer";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox name_textBox;
    }
}

