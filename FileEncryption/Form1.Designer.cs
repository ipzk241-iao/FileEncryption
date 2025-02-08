namespace FileEncryption
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
            this.backgroBgWorkerundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ChooseFIleEncoding = new System.Windows.Forms.Button();
            this.tb_4FileEncoding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_keyEncoding = new System.Windows.Forms.TextBox();
            this.btn_encoding = new System.Windows.Forms.Button();
            this.btn_decoding = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "File";
            // 
            // btn_ChooseFIleEncoding
            // 
            this.btn_ChooseFIleEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ChooseFIleEncoding.Location = new System.Drawing.Point(168, 77);
            this.btn_ChooseFIleEncoding.Name = "btn_ChooseFIleEncoding";
            this.btn_ChooseFIleEncoding.Size = new System.Drawing.Size(54, 22);
            this.btn_ChooseFIleEncoding.TabIndex = 10;
            this.btn_ChooseFIleEncoding.Text = "···";
            this.btn_ChooseFIleEncoding.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ChooseFIleEncoding.UseVisualStyleBackColor = true;
            this.btn_ChooseFIleEncoding.Click += new System.EventHandler(this.btn_ChooseFileEncoding_Click);
            // 
            // tb_4FileEncoding
            // 
            this.tb_4FileEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_4FileEncoding.Location = new System.Drawing.Point(12, 77);
            this.tb_4FileEncoding.Name = "tb_4FileEncoding";
            this.tb_4FileEncoding.Size = new System.Drawing.Size(150, 22);
            this.tb_4FileEncoding.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key";
            // 
            // tb_keyEncoding
            // 
            this.tb_keyEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_keyEncoding.Location = new System.Drawing.Point(12, 127);
            this.tb_keyEncoding.Name = "tb_keyEncoding";
            this.tb_keyEncoding.Size = new System.Drawing.Size(210, 22);
            this.tb_keyEncoding.TabIndex = 7;
            // 
            // btn_encoding
            // 
            this.btn_encoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_encoding.Location = new System.Drawing.Point(12, 155);
            this.btn_encoding.Name = "btn_encoding";
            this.btn_encoding.Size = new System.Drawing.Size(210, 65);
            this.btn_encoding.TabIndex = 6;
            this.btn_encoding.Text = "Encoding";
            this.btn_encoding.UseVisualStyleBackColor = true;
            this.btn_encoding.Click += new System.EventHandler(this.btn_encoding_Click);
            // 
            // btn_decoding
            // 
            this.btn_decoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_decoding.Location = new System.Drawing.Point(12, 226);
            this.btn_decoding.Name = "btn_decoding";
            this.btn_decoding.Size = new System.Drawing.Size(210, 65);
            this.btn_decoding.TabIndex = 12;
            this.btn_decoding.Text = "Decoding";
            this.btn_decoding.UseVisualStyleBackColor = true;
            this.btn_decoding.Click += new System.EventHandler(this.btn_decoding_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Encryption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_decoding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ChooseFIleEncoding);
            this.Controls.Add(this.tb_4FileEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_keyEncoding);
            this.Controls.Add(this.btn_encoding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroBgWorkerundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ChooseFIleEncoding;
        private System.Windows.Forms.TextBox tb_4FileEncoding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_keyEncoding;
        private System.Windows.Forms.Button btn_encoding;
        private System.Windows.Forms.Button btn_decoding;
        private System.Windows.Forms.Label label1;
    }
}

