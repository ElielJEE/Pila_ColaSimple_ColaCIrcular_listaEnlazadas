
namespace Pilas_ColasSimples_ColasCirculares
{
    partial class FormListaEnlazadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaEnlazadas));
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.btnInsertarFinal = new System.Windows.Forms.Button();
            this.btnInsertarInicio = new System.Windows.Forms.Button();
            this.btnInsertarAntesX = new System.Windows.Forms.Button();
            this.btnInsertarDespuesX = new System.Windows.Forms.Button();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.btnEliminarFinal = new System.Windows.Forms.Button();
            this.btnEliminarDespuesX = new System.Windows.Forms.Button();
            this.btnEliminarInicio = new System.Windows.Forms.Button();
            this.btnEliminarAntesX = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnBusquedaRecursiva = new System.Windows.Forms.Button();
            this.btnBusquedaDesordenada = new System.Windows.Forms.Button();
            this.btnBusquedaOrdenada = new System.Windows.Forms.Button();
            this.gbTracing = new System.Windows.Forms.GroupBox();
            this.btnRecorridoRecursivo = new System.Windows.Forms.Button();
            this.btnRecorridoIterativo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.gbInsert.SuspendLayout();
            this.gbDelete.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbTracing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtHoras);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.txtMarca);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.txtPrecio);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.txtNombre);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(113, 178);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos del Cliente:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(6, 149);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Horas";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(6, 110);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.btnInsertarFinal);
            this.gbInsert.Controls.Add(this.btnInsertarInicio);
            this.gbInsert.Controls.Add(this.btnInsertarAntesX);
            this.gbInsert.Controls.Add(this.btnInsertarDespuesX);
            this.gbInsert.Location = new System.Drawing.Point(131, 12);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(419, 52);
            this.gbInsert.TabIndex = 1;
            this.gbInsert.TabStop = false;
            this.gbInsert.Text = "Inserciones:";
            // 
            // btnInsertarFinal
            // 
            this.btnInsertarFinal.Location = new System.Drawing.Point(336, 19);
            this.btnInsertarFinal.Name = "btnInsertarFinal";
            this.btnInsertarFinal.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarFinal.TabIndex = 8;
            this.btnInsertarFinal.Text = "Insertar Final";
            this.btnInsertarFinal.UseVisualStyleBackColor = true;
            this.btnInsertarFinal.Click += new System.EventHandler(this.btnInsertarFinal_Click);
            // 
            // btnInsertarInicio
            // 
            this.btnInsertarInicio.Location = new System.Drawing.Point(6, 19);
            this.btnInsertarInicio.Name = "btnInsertarInicio";
            this.btnInsertarInicio.Size = new System.Drawing.Size(83, 23);
            this.btnInsertarInicio.TabIndex = 5;
            this.btnInsertarInicio.Text = "Insertar Inicio";
            this.btnInsertarInicio.UseVisualStyleBackColor = true;
            this.btnInsertarInicio.Click += new System.EventHandler(this.btnInsertarInicio_Click);
            // 
            // btnInsertarAntesX
            // 
            this.btnInsertarAntesX.Location = new System.Drawing.Point(223, 19);
            this.btnInsertarAntesX.Name = "btnInsertarAntesX";
            this.btnInsertarAntesX.Size = new System.Drawing.Size(107, 23);
            this.btnInsertarAntesX.TabIndex = 7;
            this.btnInsertarAntesX.Text = "Insertar Antes de X";
            this.btnInsertarAntesX.UseVisualStyleBackColor = true;
            this.btnInsertarAntesX.Click += new System.EventHandler(this.btnInsertarAntesX_Click);
            // 
            // btnInsertarDespuesX
            // 
            this.btnInsertarDespuesX.Location = new System.Drawing.Point(95, 19);
            this.btnInsertarDespuesX.Name = "btnInsertarDespuesX";
            this.btnInsertarDespuesX.Size = new System.Drawing.Size(122, 23);
            this.btnInsertarDespuesX.TabIndex = 6;
            this.btnInsertarDespuesX.Text = "Insertar Despues de X";
            this.btnInsertarDespuesX.UseVisualStyleBackColor = true;
            this.btnInsertarDespuesX.Click += new System.EventHandler(this.btnInsertarDespuesX_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.Controls.Add(this.btnEliminarFinal);
            this.gbDelete.Controls.Add(this.btnEliminarDespuesX);
            this.gbDelete.Controls.Add(this.btnEliminarInicio);
            this.gbDelete.Controls.Add(this.btnEliminarAntesX);
            this.gbDelete.Location = new System.Drawing.Point(131, 70);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(428, 49);
            this.gbDelete.TabIndex = 2;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Eliminaciones:";
            // 
            // btnEliminarFinal
            // 
            this.btnEliminarFinal.Location = new System.Drawing.Point(336, 19);
            this.btnEliminarFinal.Name = "btnEliminarFinal";
            this.btnEliminarFinal.Size = new System.Drawing.Size(83, 23);
            this.btnEliminarFinal.TabIndex = 12;
            this.btnEliminarFinal.Text = "Eliminar Final";
            this.btnEliminarFinal.UseVisualStyleBackColor = true;
            this.btnEliminarFinal.Click += new System.EventHandler(this.btnEliminarFinal_Click);
            // 
            // btnEliminarDespuesX
            // 
            this.btnEliminarDespuesX.Location = new System.Drawing.Point(95, 19);
            this.btnEliminarDespuesX.Name = "btnEliminarDespuesX";
            this.btnEliminarDespuesX.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarDespuesX.TabIndex = 10;
            this.btnEliminarDespuesX.Text = "Eliminar Despues de X";
            this.btnEliminarDespuesX.UseVisualStyleBackColor = true;
            this.btnEliminarDespuesX.Click += new System.EventHandler(this.btnEliminarDespuesX_Click);
            // 
            // btnEliminarInicio
            // 
            this.btnEliminarInicio.Location = new System.Drawing.Point(6, 19);
            this.btnEliminarInicio.Name = "btnEliminarInicio";
            this.btnEliminarInicio.Size = new System.Drawing.Size(83, 23);
            this.btnEliminarInicio.TabIndex = 9;
            this.btnEliminarInicio.Text = "Eliminar Inicio";
            this.btnEliminarInicio.UseVisualStyleBackColor = true;
            this.btnEliminarInicio.Click += new System.EventHandler(this.btnEliminarInicio_Click);
            // 
            // btnEliminarAntesX
            // 
            this.btnEliminarAntesX.Location = new System.Drawing.Point(223, 19);
            this.btnEliminarAntesX.Name = "btnEliminarAntesX";
            this.btnEliminarAntesX.Size = new System.Drawing.Size(107, 23);
            this.btnEliminarAntesX.TabIndex = 11;
            this.btnEliminarAntesX.Text = "Eliminar Antes de X";
            this.btnEliminarAntesX.UseVisualStyleBackColor = true;
            this.btnEliminarAntesX.Click += new System.EventHandler(this.btnEliminarAntesX_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnBusquedaRecursiva);
            this.gbSearch.Controls.Add(this.btnBusquedaDesordenada);
            this.gbSearch.Controls.Add(this.btnBusquedaOrdenada);
            this.gbSearch.Location = new System.Drawing.Point(131, 125);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(346, 47);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Busqueda:";
            // 
            // btnBusquedaRecursiva
            // 
            this.btnBusquedaRecursiva.Location = new System.Drawing.Point(234, 18);
            this.btnBusquedaRecursiva.Name = "btnBusquedaRecursiva";
            this.btnBusquedaRecursiva.Size = new System.Drawing.Size(104, 23);
            this.btnBusquedaRecursiva.TabIndex = 15;
            this.btnBusquedaRecursiva.Text = "Buscar Recursivo";
            this.btnBusquedaRecursiva.UseVisualStyleBackColor = true;
            this.btnBusquedaRecursiva.Click += new System.EventHandler(this.btnBusquedaRecursiva_Click);
            // 
            // btnBusquedaDesordenada
            // 
            this.btnBusquedaDesordenada.Location = new System.Drawing.Point(110, 18);
            this.btnBusquedaDesordenada.Name = "btnBusquedaDesordenada";
            this.btnBusquedaDesordenada.Size = new System.Drawing.Size(118, 23);
            this.btnBusquedaDesordenada.TabIndex = 14;
            this.btnBusquedaDesordenada.Text = "Buscar Desordenado";
            this.btnBusquedaDesordenada.UseVisualStyleBackColor = true;
            this.btnBusquedaDesordenada.Click += new System.EventHandler(this.btnBusquedaDesordenada_Click);
            // 
            // btnBusquedaOrdenada
            // 
            this.btnBusquedaOrdenada.Location = new System.Drawing.Point(6, 18);
            this.btnBusquedaOrdenada.Name = "btnBusquedaOrdenada";
            this.btnBusquedaOrdenada.Size = new System.Drawing.Size(98, 23);
            this.btnBusquedaOrdenada.TabIndex = 13;
            this.btnBusquedaOrdenada.Text = "Buscar Ordenado";
            this.btnBusquedaOrdenada.UseVisualStyleBackColor = true;
            this.btnBusquedaOrdenada.Click += new System.EventHandler(this.btnBusquedaOrdenada_Click);
            // 
            // gbTracing
            // 
            this.gbTracing.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbTracing.Controls.Add(this.btnRecorridoRecursivo);
            this.gbTracing.Controls.Add(this.btnRecorridoIterativo);
            this.gbTracing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbTracing.Location = new System.Drawing.Point(131, 178);
            this.gbTracing.Name = "gbTracing";
            this.gbTracing.Size = new System.Drawing.Size(237, 54);
            this.gbTracing.TabIndex = 4;
            this.gbTracing.TabStop = false;
            this.gbTracing.Text = "Recorrido:";
            // 
            // btnRecorridoRecursivo
            // 
            this.btnRecorridoRecursivo.Location = new System.Drawing.Point(115, 19);
            this.btnRecorridoRecursivo.Name = "btnRecorridoRecursivo";
            this.btnRecorridoRecursivo.Size = new System.Drawing.Size(113, 23);
            this.btnRecorridoRecursivo.TabIndex = 17;
            this.btnRecorridoRecursivo.Text = "Recorrido Recursivo";
            this.btnRecorridoRecursivo.UseVisualStyleBackColor = true;
            this.btnRecorridoRecursivo.Click += new System.EventHandler(this.btnRecorridoRecursivo_Click);
            // 
            // btnRecorridoIterativo
            // 
            this.btnRecorridoIterativo.Location = new System.Drawing.Point(6, 19);
            this.btnRecorridoIterativo.Name = "btnRecorridoIterativo";
            this.btnRecorridoIterativo.Size = new System.Drawing.Size(103, 23);
            this.btnRecorridoIterativo.TabIndex = 16;
            this.btnRecorridoIterativo.Text = "Recorrido Iterativo";
            this.btnRecorridoIterativo.UseVisualStyleBackColor = true;
            this.btnRecorridoIterativo.Click += new System.EventHandler(this.btnRecorridoIterativo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 306);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marca";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Horas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // btnVaciarLista
            // 
            this.btnVaciarLista.Location = new System.Drawing.Point(489, 209);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(70, 23);
            this.btnVaciarLista.TabIndex = 9;
            this.btnVaciarLista.Text = "Vaciar Lista";
            this.btnVaciarLista.UseVisualStyleBackColor = true;
            this.btnVaciarLista.Click += new System.EventHandler(this.btnVaciarLista_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(396, 209);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(87, 23);
            this.btnEliminarCliente.TabIndex = 10;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // FormListaEnlazadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 556);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbTracing);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.gbInsert);
            this.Controls.Add(this.gbData);
            this.Name = "FormListaEnlazadas";
            this.Text = "Lista Enlazada";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbInsert.ResumeLayout(false);
            this.gbDelete.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbTracing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.GroupBox gbTracing;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarFinal;
        private System.Windows.Forms.Button btnInsertarInicio;
        private System.Windows.Forms.Button btnInsertarAntesX;
        private System.Windows.Forms.Button btnInsertarDespuesX;
        private System.Windows.Forms.Button btnEliminarFinal;
        private System.Windows.Forms.Button btnEliminarDespuesX;
        private System.Windows.Forms.Button btnEliminarInicio;
        private System.Windows.Forms.Button btnEliminarAntesX;
        private System.Windows.Forms.Button btnBusquedaRecursiva;
        private System.Windows.Forms.Button btnBusquedaOrdenada;
        private System.Windows.Forms.Button btnBusquedaDesordenada;
        private System.Windows.Forms.Button btnRecorridoRecursivo;
        private System.Windows.Forms.Button btnRecorridoIterativo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Button btnEliminarCliente;
    }
}