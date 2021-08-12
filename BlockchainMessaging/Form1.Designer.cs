namespace BlockchainMessaging
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.listWriteBuffer = new System.Windows.Forms.ListView();
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWrite = new System.Windows.Forms.Button();
            this.listReadChain = new System.Windows.Forms.ListView();
            this.columnReadUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReadMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(91, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(281, 369);
            this.txtMessage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message: ";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(12, 409);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(357, 29);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Send Message";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 381);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // listWriteBuffer
            // 
            this.listWriteBuffer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUser,
            this.columnMessage});
            this.listWriteBuffer.HideSelection = false;
            this.listWriteBuffer.Location = new System.Drawing.Point(378, 12);
            this.listWriteBuffer.Name = "listWriteBuffer";
            this.listWriteBuffer.Size = new System.Drawing.Size(410, 385);
            this.listWriteBuffer.TabIndex = 5;
            this.listWriteBuffer.UseCompatibleStateImageBehavior = false;
            this.listWriteBuffer.View = System.Windows.Forms.View.Details;
            // 
            // columnUser
            // 
            this.columnUser.Text = "User";
            this.columnUser.Width = 134;
            // 
            // columnMessage
            // 
            this.columnMessage.Text = "Message";
            this.columnMessage.Width = 272;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(378, 403);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(410, 35);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Mine Block";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // listReadChain
            // 
            this.listReadChain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnReadUser,
            this.columnReadMessage});
            this.listReadChain.HideSelection = false;
            this.listReadChain.Location = new System.Drawing.Point(794, 12);
            this.listReadChain.Name = "listReadChain";
            this.listReadChain.Size = new System.Drawing.Size(493, 385);
            this.listReadChain.TabIndex = 7;
            this.listReadChain.UseCompatibleStateImageBehavior = false;
            this.listReadChain.View = System.Windows.Forms.View.Details;
            // 
            // columnReadUser
            // 
            this.columnReadUser.Text = "User";
            this.columnReadUser.Width = 122;
            // 
            // columnReadMessage
            // 
            this.columnReadMessage.Text = "Message";
            this.columnReadMessage.Width = 365;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(795, 403);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(492, 34);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read Chain";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.listReadChain);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.listWriteBuffer);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Blockchain Message Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ListView listWriteBuffer;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnMessage;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ListView listReadChain;
        private System.Windows.Forms.ColumnHeader columnReadUser;
        private System.Windows.Forms.ColumnHeader columnReadMessage;
        private System.Windows.Forms.Button btnRead;
    }
}

