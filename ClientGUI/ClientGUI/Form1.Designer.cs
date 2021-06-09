namespace ClientGUI
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
            this.lbx_message = new System.Windows.Forms.ListBox();
            this.btnCreateConnection = new System.Windows.Forms.Button();
            this.btnCreateConnection2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_message
            // 
            this.lbx_message.FormattingEnabled = true;
            this.lbx_message.Location = new System.Drawing.Point(4, 2);
            this.lbx_message.Name = "lbx_message";
            this.lbx_message.Size = new System.Drawing.Size(350, 303);
            this.lbx_message.TabIndex = 0;
            // 
            // btnCreateConnection
            // 
            this.btnCreateConnection.Location = new System.Drawing.Point(360, 2);
            this.btnCreateConnection.Name = "btnCreateConnection";
            this.btnCreateConnection.Size = new System.Drawing.Size(201, 68);
            this.btnCreateConnection.TabIndex = 1;
            this.btnCreateConnection.Text = "Получить данные с сервера 1";
            this.btnCreateConnection.UseVisualStyleBackColor = true;
            this.btnCreateConnection.Click += new System.EventHandler(this.btnCreateConnection_Click);
            // 
            // btnCreateConnection2
            // 
            this.btnCreateConnection2.Location = new System.Drawing.Point(360, 71);
            this.btnCreateConnection2.Name = "btnCreateConnection2";
            this.btnCreateConnection2.Size = new System.Drawing.Size(201, 81);
            this.btnCreateConnection2.TabIndex = 2;
            this.btnCreateConnection2.Text = "Получить данные с сервера 2";
            this.btnCreateConnection2.UseVisualStyleBackColor = true;
            this.btnCreateConnection2.Click += new System.EventHandler(this.btnCreateConnection2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(360, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 79);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 307);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateConnection2);
            this.Controls.Add(this.btnCreateConnection);
            this.Controls.Add(this.lbx_message);
            this.MaximumSize = new System.Drawing.Size(580, 346);
            this.MinimumSize = new System.Drawing.Size(580, 346);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_message;
        private System.Windows.Forms.Button btnCreateConnection;
        private System.Windows.Forms.Button btnCreateConnection2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

