namespace proyect_Person
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNOTA1 = new System.Windows.Forms.TextBox();
            this.txtNOTA2 = new System.Windows.Forms.TextBox();
            this.btnINSERTD = new System.Windows.Forms.Button();
            this.btnUPDATED = new System.Windows.Forms.Button();
            this.btnDELETED = new System.Windows.Forms.Button();
            this.dataEstudiante = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota2:";
            // 
            // txtNOTA1
            // 
            this.txtNOTA1.Location = new System.Drawing.Point(155, 96);
            this.txtNOTA1.Name = "txtNOTA1";
            this.txtNOTA1.Size = new System.Drawing.Size(131, 22);
            this.txtNOTA1.TabIndex = 6;
            // 
            // txtNOTA2
            // 
            this.txtNOTA2.Location = new System.Drawing.Point(155, 157);
            this.txtNOTA2.Name = "txtNOTA2";
            this.txtNOTA2.Size = new System.Drawing.Size(131, 22);
            this.txtNOTA2.TabIndex = 7;
            // 
            // btnINSERTD
            // 
            this.btnINSERTD.Location = new System.Drawing.Point(436, 95);
            this.btnINSERTD.Name = "btnINSERTD";
            this.btnINSERTD.Size = new System.Drawing.Size(75, 23);
            this.btnINSERTD.TabIndex = 12;
            this.btnINSERTD.Text = "INSERT";
            this.btnINSERTD.UseVisualStyleBackColor = true;
            this.btnINSERTD.Click += new System.EventHandler(this.btnINSERTD_Click);
            // 
            // btnUPDATED
            // 
            this.btnUPDATED.Location = new System.Drawing.Point(436, 124);
            this.btnUPDATED.Name = "btnUPDATED";
            this.btnUPDATED.Size = new System.Drawing.Size(75, 23);
            this.btnUPDATED.TabIndex = 13;
            this.btnUPDATED.Text = "UPDATE";
            this.btnUPDATED.UseVisualStyleBackColor = true;
            this.btnUPDATED.Click += new System.EventHandler(this.btnUPDATED_Click);
            // 
            // btnDELETED
            // 
            this.btnDELETED.Location = new System.Drawing.Point(436, 157);
            this.btnDELETED.Name = "btnDELETED";
            this.btnDELETED.Size = new System.Drawing.Size(75, 23);
            this.btnDELETED.TabIndex = 14;
            this.btnDELETED.Text = "DELETE";
            this.btnDELETED.UseVisualStyleBackColor = true;
            this.btnDELETED.Click += new System.EventHandler(this.btnDELETED_Click);
            // 
            // dataEstudiante
            // 
            this.dataEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataEstudiante.Location = new System.Drawing.Point(43, 250);
            this.dataEstudiante.Name = "dataEstudiante";
            this.dataEstudiante.RowHeadersWidth = 51;
            this.dataEstudiante.RowTemplate.Height = 24;
            this.dataEstudiante.Size = new System.Drawing.Size(926, 199);
            this.dataEstudiante.TabIndex = 15;
            this.dataEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstudiante_CellClick);
            this.dataEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstudiante_CellContentClick);
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
            this.Column4.HeaderText = "NOTA1";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NOTA2";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SUMA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PROMEDIO";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 655);
            this.Controls.Add(this.dataEstudiante);
            this.Controls.Add(this.btnDELETED);
            this.Controls.Add(this.btnUPDATED);
            this.Controls.Add(this.btnINSERTD);
            this.Controls.Add(this.txtNOTA2);
            this.Controls.Add(this.txtNOTA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNOTA1;
        private System.Windows.Forms.TextBox txtNOTA2;
        private System.Windows.Forms.Button btnINSERTD;
        private System.Windows.Forms.Button btnUPDATED;
        private System.Windows.Forms.Button btnDELETED;
        private System.Windows.Forms.DataGridView dataEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}