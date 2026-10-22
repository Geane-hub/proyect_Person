namespace proyect_Person
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTITULO = new System.Windows.Forms.TextBox();
            this.txtSALARIO = new System.Windows.Forms.TextBox();
            this.btnINSERTD = new System.Windows.Forms.Button();
            this.btnUPDATED = new System.Windows.Forms.Button();
            this.btnDELETED = new System.Windows.Forms.Button();
            this.dataDocente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Docente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sueldo:";
            // 
            // txtTITULO
            // 
            this.txtTITULO.Location = new System.Drawing.Point(167, 127);
            this.txtTITULO.Name = "txtTITULO";
            this.txtTITULO.Size = new System.Drawing.Size(171, 22);
            this.txtTITULO.TabIndex = 5;
            // 
            // txtSALARIO
            // 
            this.txtSALARIO.Location = new System.Drawing.Point(168, 188);
            this.txtSALARIO.Name = "txtSALARIO";
            this.txtSALARIO.Size = new System.Drawing.Size(131, 22);
            this.txtSALARIO.TabIndex = 6;
            // 
            // btnINSERTD
            // 
            this.btnINSERTD.Location = new System.Drawing.Point(508, 126);
            this.btnINSERTD.Name = "btnINSERTD";
            this.btnINSERTD.Size = new System.Drawing.Size(75, 23);
            this.btnINSERTD.TabIndex = 11;
            this.btnINSERTD.Text = "INSERT";
            this.btnINSERTD.UseVisualStyleBackColor = true;
            this.btnINSERTD.Click += new System.EventHandler(this.btnINSERTD_Click);
            // 
            // btnUPDATED
            // 
            this.btnUPDATED.Location = new System.Drawing.Point(508, 166);
            this.btnUPDATED.Name = "btnUPDATED";
            this.btnUPDATED.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATED.TabIndex = 12;
            this.btnUPDATED.Text = "UPDATE";
            this.btnUPDATED.UseVisualStyleBackColor = true;
            this.btnUPDATED.Click += new System.EventHandler(this.btnUPDATED_Click);
            // 
            // btnDELETED
            // 
            this.btnDELETED.Location = new System.Drawing.Point(508, 205);
            this.btnDELETED.Name = "btnDELETED";
            this.btnDELETED.Size = new System.Drawing.Size(75, 23);
            this.btnDELETED.TabIndex = 13;
            this.btnDELETED.Text = "DELETE";
            this.btnDELETED.UseVisualStyleBackColor = true;
            this.btnDELETED.Click += new System.EventHandler(this.btnDELETED_Click);
            // 
            // dataDocente
            // 
            this.dataDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDocente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataDocente.Location = new System.Drawing.Point(42, 300);
            this.dataDocente.Name = "dataDocente";
            this.dataDocente.RowHeadersWidth = 51;
            this.dataDocente.RowTemplate.Height = 24;
            this.dataDocente.Size = new System.Drawing.Size(928, 270);
            this.dataDocente.TabIndex = 14;
            this.dataDocente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDocente_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CEDULA";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TITULO";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SUELDO";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IESS";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "SUELTO TOTAL";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 645);
            this.Controls.Add(this.dataDocente);
            this.Controls.Add(this.btnDELETED);
            this.Controls.Add(this.btnUPDATED);
            this.Controls.Add(this.btnINSERTD);
            this.Controls.Add(this.txtSALARIO);
            this.Controls.Add(this.txtTITULO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataDocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTITULO;
        private System.Windows.Forms.TextBox txtSALARIO;
        private System.Windows.Forms.Button btnINSERTD;
        private System.Windows.Forms.Button btnUPDATED;
        private System.Windows.Forms.Button btnDELETED;
        private System.Windows.Forms.DataGridView dataDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}