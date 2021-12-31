
namespace monitoreoYojo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.puerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreEquipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estatusConexion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnEnviar);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.nombre);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnChat);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel1.Controls.Add(this.btnApagar);
            this.splitContainer1.Panel1.Controls.Add(this.btnArchivos);
            this.splitContainer1.Panel1.Controls.Add(this.btnDesbloquear);
            this.splitContainer1.Panel1.Controls.Add(this.btnBloquear);
            this.splitContainer1.Panel1.Controls.Add(this.btnDetener);
            this.splitContainer1.Panel1.Controls.Add(this.btnVisualizar);
            this.splitContainer1.Panel1.Controls.Add(this.btnCompartir);
            this.splitContainer1.Panel1.Controls.Add(this.puerto);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nombreEquipo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.estatusConexion);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 749);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(0, 448);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEnviar.Size = new System.Drawing.Size(173, 23);
            this.btnEnviar.TabIndex = 29;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 260);
            this.panel2.TabIndex = 28;
            // 
            // nombre
            // 
            this.nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombre.Location = new System.Drawing.Point(0, 428);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(173, 20);
            this.nombre.TabIndex = 27;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nombre de Usuario:";
            // 
            // btnChat
            // 
            this.btnChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(0, 389);
            this.btnChat.Name = "btnChat";
            this.btnChat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChat.Size = new System.Drawing.Size(173, 23);
            this.btnChat.TabIndex = 24;
            this.btnChat.Text = "Chat";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 366);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(173, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnApagar
            // 
            this.btnApagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(0, 343);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApagar.Size = new System.Drawing.Size(173, 23);
            this.btnApagar.TabIndex = 22;
            this.btnApagar.Text = "Apagar Equipo";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnArchivos
            // 
            this.btnArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivos.FlatAppearance.BorderSize = 0;
            this.btnArchivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.ForeColor = System.Drawing.Color.White;
            this.btnArchivos.Location = new System.Drawing.Point(0, 320);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnArchivos.Size = new System.Drawing.Size(173, 23);
            this.btnArchivos.TabIndex = 20;
            this.btnArchivos.Text = "Transferir Archivos";
            this.btnArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivos.UseVisualStyleBackColor = true;
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesbloquear.FlatAppearance.BorderSize = 0;
            this.btnDesbloquear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloquear.ForeColor = System.Drawing.Color.White;
            this.btnDesbloquear.Location = new System.Drawing.Point(0, 297);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDesbloquear.Size = new System.Drawing.Size(173, 23);
            this.btnDesbloquear.TabIndex = 19;
            this.btnDesbloquear.Text = "Desbloquear Pantalla";
            this.btnDesbloquear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            // 
            // btnBloquear
            // 
            this.btnBloquear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquear.ForeColor = System.Drawing.Color.White;
            this.btnBloquear.Location = new System.Drawing.Point(0, 274);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBloquear.Size = new System.Drawing.Size(173, 23);
            this.btnBloquear.TabIndex = 18;
            this.btnBloquear.Text = "Bloquear Pantalla";
            this.btnBloquear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBloquear.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.White;
            this.btnDetener.Location = new System.Drawing.Point(0, 251);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetener.Size = new System.Drawing.Size(173, 23);
            this.btnDetener.TabIndex = 17;
            this.btnDetener.Text = "Detener";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click_1);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(0, 228);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVisualizar.Size = new System.Drawing.Size(173, 23);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "Visualizar Pantalla";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click_1);
            // 
            // btnCompartir
            // 
            this.btnCompartir.BackColor = System.Drawing.Color.Transparent;
            this.btnCompartir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompartir.FlatAppearance.BorderSize = 0;
            this.btnCompartir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompartir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompartir.ForeColor = System.Drawing.Color.White;
            this.btnCompartir.Location = new System.Drawing.Point(0, 205);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCompartir.Size = new System.Drawing.Size(173, 23);
            this.btnCompartir.TabIndex = 15;
            this.btnCompartir.Text = "Compartir Pantalla";
            this.btnCompartir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompartir.UseVisualStyleBackColor = false;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click_1);
            // 
            // puerto
            // 
            this.puerto.Dock = System.Windows.Forms.DockStyle.Top;
            this.puerto.Location = new System.Drawing.Point(0, 185);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(173, 20);
            this.puerto.TabIndex = 14;
            this.puerto.Text = "8081";
            this.puerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Puerto:";
            // 
            // nombreEquipo
            // 
            this.nombreEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombreEquipo.Location = new System.Drawing.Point(0, 149);
            this.nombreEquipo.Name = "nombreEquipo";
            this.nombreEquipo.Size = new System.Drawing.Size(173, 20);
            this.nombreEquipo.TabIndex = 12;
            this.nombreEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del Equipo (IP):";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 133);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "TEAM YOJO";
            // 
            // estatusConexion
            // 
            this.estatusConexion.AutoSize = true;
            this.estatusConexion.Location = new System.Drawing.Point(54, 9);
            this.estatusConexion.Name = "estatusConexion";
            this.estatusConexion.Size = new System.Drawing.Size(77, 13);
            this.estatusConexion.TabIndex = 2;
            this.estatusConexion.Text = "Desconectado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estatus:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(807, 749);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOFTWARE DE MONITOREO YOJO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCompartir;
        private System.Windows.Forms.TextBox puerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreEquipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label estatusConexion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnviar;
    }
}

