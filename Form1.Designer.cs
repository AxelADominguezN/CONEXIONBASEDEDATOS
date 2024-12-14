namespace CONEXIONBASEDEDATOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VACANOMBRE = new System.Windows.Forms.TextBox();
            this.VACAESTADO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GUARDARDATOS = new System.Windows.Forms.Button();
            this.TXTRAZA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BSALIR = new System.Windows.Forms.Button();
            this.BELIMINAR = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BLIMPIAR = new System.Windows.Forms.Button();
            this.IDLIST = new System.Windows.Forms.ListBox();
            this.BMODIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DE LA VACA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "RAZA DE LA VACA";
            // 
            // VACANOMBRE
            // 
            this.VACANOMBRE.Location = new System.Drawing.Point(134, 78);
            this.VACANOMBRE.Name = "VACANOMBRE";
            this.VACANOMBRE.Size = new System.Drawing.Size(224, 23);
            this.VACANOMBRE.TabIndex = 6;
            // 
            // VACAESTADO
            // 
            this.VACAESTADO.Location = new System.Drawing.Point(134, 189);
            this.VACAESTADO.Name = "VACAESTADO";
            this.VACAESTADO.Size = new System.Drawing.Size(224, 23);
            this.VACAESTADO.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ESTADO DE LA VACA";
            // 
            // GUARDARDATOS
            // 
            this.GUARDARDATOS.Location = new System.Drawing.Point(29, 234);
            this.GUARDARDATOS.Name = "GUARDARDATOS";
            this.GUARDARDATOS.Size = new System.Drawing.Size(127, 49);
            this.GUARDARDATOS.TabIndex = 12;
            this.GUARDARDATOS.Text = "GUARDAR";
            this.GUARDARDATOS.UseVisualStyleBackColor = true;
            this.GUARDARDATOS.Click += new System.EventHandler(this.GUARDARDATOS_Click);
            // 
            // TXTRAZA
            // 
            this.TXTRAZA.Location = new System.Drawing.Point(134, 131);
            this.TXTRAZA.Name = "TXTRAZA";
            this.TXTRAZA.Size = new System.Drawing.Size(224, 23);
            this.TXTRAZA.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(497, 374);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BSALIR
            // 
            this.BSALIR.Location = new System.Drawing.Point(108, 345);
            this.BSALIR.Name = "BSALIR";
            this.BSALIR.Size = new System.Drawing.Size(127, 49);
            this.BSALIR.TabIndex = 16;
            this.BSALIR.Text = "SALIR";
            this.BSALIR.UseVisualStyleBackColor = true;
            this.BSALIR.Click += new System.EventHandler(this.BSALIR_Click);
            // 
            // BELIMINAR
            // 
            this.BELIMINAR.Location = new System.Drawing.Point(29, 289);
            this.BELIMINAR.Name = "BELIMINAR";
            this.BELIMINAR.Size = new System.Drawing.Size(127, 49);
            this.BELIMINAR.TabIndex = 17;
            this.BELIMINAR.Text = "ELIMINAR";
            this.BELIMINAR.UseVisualStyleBackColor = true;
            this.BELIMINAR.Click += new System.EventHandler(this.BELIMINAR_Click);
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(134, 37);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(112, 23);
            this.TXTID.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // BLIMPIAR
            // 
            this.BLIMPIAR.Location = new System.Drawing.Point(198, 289);
            this.BLIMPIAR.Name = "BLIMPIAR";
            this.BLIMPIAR.Size = new System.Drawing.Size(127, 49);
            this.BLIMPIAR.TabIndex = 20;
            this.BLIMPIAR.Text = "LIMPIAR";
            this.BLIMPIAR.UseVisualStyleBackColor = true;
            this.BLIMPIAR.Click += new System.EventHandler(this.BLIMPIAR_Click);
            // 
            // IDLIST
            // 
            this.IDLIST.FormattingEnabled = true;
            this.IDLIST.ItemHeight = 15;
            this.IDLIST.Location = new System.Drawing.Point(385, 12);
            this.IDLIST.Name = "IDLIST";
            this.IDLIST.Size = new System.Drawing.Size(112, 379);
            this.IDLIST.TabIndex = 21;
            this.IDLIST.SelectedIndexChanged += new System.EventHandler(this.IDLIST_SelectedIndexChanged);
            // 
            // BMODIFICAR
            // 
            this.BMODIFICAR.Location = new System.Drawing.Point(198, 234);
            this.BMODIFICAR.Name = "BMODIFICAR";
            this.BMODIFICAR.Size = new System.Drawing.Size(127, 49);
            this.BMODIFICAR.TabIndex = 22;
            this.BMODIFICAR.Text = "MODIFICAR";
            this.BMODIFICAR.UseVisualStyleBackColor = true;
            this.BMODIFICAR.Click += new System.EventHandler(this.BMODIFICAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 406);
            this.Controls.Add(this.BMODIFICAR);
            this.Controls.Add(this.IDLIST);
            this.Controls.Add(this.BLIMPIAR);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BELIMINAR);
            this.Controls.Add(this.BSALIR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTRAZA);
            this.Controls.Add(this.GUARDARDATOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VACAESTADO);
            this.Controls.Add(this.VACANOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox VACANOMBRE;
        private TextBox VACAESTADO;
        private Label label3;
        private Button GUARDARDATOS;
        private TextBox TXTRAZA;
        private Button BSALIR;
        private Button BELIMINAR;
        private TextBox TXTID;
        private Label label4;
        private Button BLIMPIAR;
        private ListBox IDLIST;
        private Button BMODIFICAR;
        private DataGridView dataGridView1;
    }
}