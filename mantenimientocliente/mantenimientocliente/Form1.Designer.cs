namespace mantenimientocliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.BTAGREGAR = new System.Windows.Forms.Button();
            this.BTMODIFICAR = new System.Windows.Forms.Button();
            this.BTELIMINAR = new System.Windows.Forms.Button();
            this.BTCANCELAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(422, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(153, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(131, 20);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(153, 63);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(131, 20);
            this.txtnom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "APELLIDO";
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(153, 89);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(131, 20);
            this.txtap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DOCUMENTO";
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(153, 115);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(131, 20);
            this.txtdoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "TELEFONO";
            // 
            // txttelf
            // 
            this.txttelf.Location = new System.Drawing.Point(153, 141);
            this.txttelf.Name = "txttelf";
            this.txttelf.Size = new System.Drawing.Size(131, 20);
            this.txttelf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CORREO";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(153, 168);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(131, 20);
            this.txtcorreo.TabIndex = 11;
            // 
            // BTAGREGAR
            // 
            this.BTAGREGAR.Location = new System.Drawing.Point(42, 202);
            this.BTAGREGAR.Name = "BTAGREGAR";
            this.BTAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BTAGREGAR.TabIndex = 13;
            this.BTAGREGAR.Text = "AGREGAR";
            this.BTAGREGAR.UseVisualStyleBackColor = true;
            this.BTAGREGAR.Click += new System.EventHandler(this.BTAGREGAR_Click);
            // 
            // BTMODIFICAR
            // 
            this.BTMODIFICAR.Location = new System.Drawing.Point(123, 202);
            this.BTMODIFICAR.Name = "BTMODIFICAR";
            this.BTMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTMODIFICAR.TabIndex = 14;
            this.BTMODIFICAR.Text = "EDITAR";
            this.BTMODIFICAR.UseVisualStyleBackColor = true;
            this.BTMODIFICAR.Click += new System.EventHandler(this.BTMODIFICAR_Click);
            // 
            // BTELIMINAR
            // 
            this.BTELIMINAR.Location = new System.Drawing.Point(204, 202);
            this.BTELIMINAR.Name = "BTELIMINAR";
            this.BTELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTELIMINAR.TabIndex = 15;
            this.BTELIMINAR.Text = "ELIMINAR";
            this.BTELIMINAR.UseVisualStyleBackColor = true;
            this.BTELIMINAR.Click += new System.EventHandler(this.BTELIMINAR_Click);
            // 
            // BTCANCELAR
            // 
            this.BTCANCELAR.Location = new System.Drawing.Point(123, 231);
            this.BTCANCELAR.Name = "BTCANCELAR";
            this.BTCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.BTCANCELAR.TabIndex = 16;
            this.BTCANCELAR.Text = "CANCELAR";
            this.BTCANCELAR.UseVisualStyleBackColor = true;
            this.BTCANCELAR.Click += new System.EventHandler(this.BTCANCELAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 278);
            this.Controls.Add(this.BTCANCELAR);
            this.Controls.Add(this.BTELIMINAR);
            this.Controls.Add(this.BTMODIFICAR);
            this.Controls.Add(this.BTAGREGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttelf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Button BTAGREGAR;
        private System.Windows.Forms.Button BTMODIFICAR;
        private System.Windows.Forms.Button BTELIMINAR;
        private System.Windows.Forms.Button BTCANCELAR;
    }
}

