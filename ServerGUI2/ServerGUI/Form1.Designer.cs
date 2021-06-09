namespace ServerGUI
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
            this.btn_ClearInformation = new System.Windows.Forms.Button();
            this.lbx_clientList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_ClearInformation
            // 
            this.btn_ClearInformation.Location = new System.Drawing.Point(3, 3);
            this.btn_ClearInformation.Name = "btn_ClearInformation";
            this.btn_ClearInformation.Size = new System.Drawing.Size(193, 52);
            this.btn_ClearInformation.TabIndex = 1;
            this.btn_ClearInformation.Text = "Очистить данные";
            this.btn_ClearInformation.UseVisualStyleBackColor = true;
            this.btn_ClearInformation.Click += new System.EventHandler(this.btn_ClearInformation_Click);
            // 
            // lbx_clientList
            // 
            this.lbx_clientList.FormattingEnabled = true;
            this.lbx_clientList.Location = new System.Drawing.Point(3, 55);
            this.lbx_clientList.Name = "lbx_clientList";
            this.lbx_clientList.Size = new System.Drawing.Size(193, 277);
            this.lbx_clientList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 332);
            this.Controls.Add(this.lbx_clientList);
            this.Controls.Add(this.btn_ClearInformation);
            this.MaximumSize = new System.Drawing.Size(213, 371);
            this.MinimumSize = new System.Drawing.Size(213, 371);
            this.Name = "Form1";
            this.Text = "Сервер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ClearInformation;
        private System.Windows.Forms.ListBox lbx_clientList;
    }
}

