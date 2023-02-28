
namespace Atv_DS_3
{
    partial class frm_Principal
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
            this.btn_atv_1 = new System.Windows.Forms.Button();
            this.btn_atv_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_atv_1
            // 
            this.btn_atv_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atv_1.Location = new System.Drawing.Point(81, 66);
            this.btn_atv_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_atv_1.Name = "btn_atv_1";
            this.btn_atv_1.Size = new System.Drawing.Size(208, 60);
            this.btn_atv_1.TabIndex = 0;
            this.btn_atv_1.Text = "Atividade 1";
            this.btn_atv_1.UseVisualStyleBackColor = true;
            this.btn_atv_1.Click += new System.EventHandler(this.btn_atv_1_Click);
            // 
            // btn_atv_2
            // 
            this.btn_atv_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atv_2.Location = new System.Drawing.Point(81, 183);
            this.btn_atv_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_atv_2.Name = "btn_atv_2";
            this.btn_atv_2.Size = new System.Drawing.Size(208, 60);
            this.btn_atv_2.TabIndex = 1;
            this.btn_atv_2.Text = "Atividade 2";
            this.btn_atv_2.UseVisualStyleBackColor = true;
            this.btn_atv_2.Click += new System.EventHandler(this.btn_atv_2_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(386, 300);
            this.Controls.Add(this.btn_atv_2);
            this.Controls.Add(this.btn_atv_1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atv_1;
        private System.Windows.Forms.Button btn_atv_2;
    }
}