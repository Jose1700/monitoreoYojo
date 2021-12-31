
namespace monitoreoYojo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.listMensaje = new System.Windows.Forms.ListBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(0, 179);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(155, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // listMensaje
            // 
            this.listMensaje.FormattingEnabled = true;
            this.listMensaje.Location = new System.Drawing.Point(0, 0);
            this.listMensaje.Name = "listMensaje";
            this.listMensaje.Size = new System.Drawing.Size(155, 173);
            this.listMensaje.TabIndex = 2;
            this.listMensaje.SelectedIndexChanged += new System.EventHandler(this.listMensaje_SelectedIndexChanged);
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(0, 202);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChat.Size = new System.Drawing.Size(155, 23);
            this.btnChat.TabIndex = 25;
            this.btnChat.Text = "Enviar";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(155, 225);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.listMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.ListBox listMensaje;
        private System.Windows.Forms.Button btnChat;
    }
}