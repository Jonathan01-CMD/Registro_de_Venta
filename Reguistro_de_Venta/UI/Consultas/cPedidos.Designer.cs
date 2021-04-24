
namespace Reguistro_de_Venta.UI.Consultas
{
    partial class cPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cPedidos));
            this.FiltroCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InactivoRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivoRadioButton = new System.Windows.Forms.RadioButton();
            this.TodoRadioButton = new System.Windows.Forms.RadioButton();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroCheckBox
            // 
            this.FiltroCheckBox.AutoSize = true;
            this.FiltroCheckBox.Location = new System.Drawing.Point(12, 23);
            this.FiltroCheckBox.Name = "FiltroCheckBox";
            this.FiltroCheckBox.Size = new System.Drawing.Size(113, 19);
            this.FiltroCheckBox.TabIndex = 0;
            this.FiltroCheckBox.Text = "Usar Filtro Fecha";
            this.FiltroCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(52, 50);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(119, 23);
            this.FiltroComboBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(190, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(122, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(190, 50);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(432, 23);
            this.DescripcionTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InactivoRadioButton);
            this.groupBox2.Controls.Add(this.ActivoRadioButton);
            this.groupBox2.Controls.Add(this.TodoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(646, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EsActivo?";
            // 
            // InactivoRadioButton
            // 
            this.InactivoRadioButton.AutoSize = true;
            this.InactivoRadioButton.Location = new System.Drawing.Point(3, 51);
            this.InactivoRadioButton.Name = "InactivoRadioButton";
            this.InactivoRadioButton.Size = new System.Drawing.Size(67, 19);
            this.InactivoRadioButton.TabIndex = 2;
            this.InactivoRadioButton.TabStop = true;
            this.InactivoRadioButton.Text = "Inactivo";
            this.InactivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivoRadioButton
            // 
            this.ActivoRadioButton.AutoSize = true;
            this.ActivoRadioButton.Location = new System.Drawing.Point(3, 31);
            this.ActivoRadioButton.Name = "ActivoRadioButton";
            this.ActivoRadioButton.Size = new System.Drawing.Size(59, 19);
            this.ActivoRadioButton.TabIndex = 1;
            this.ActivoRadioButton.TabStop = true;
            this.ActivoRadioButton.Text = "Activo";
            this.ActivoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodoRadioButton
            // 
            this.TodoRadioButton.AutoSize = true;
            this.TodoRadioButton.Location = new System.Drawing.Point(3, 13);
            this.TodoRadioButton.Name = "TodoRadioButton";
            this.TodoRadioButton.Size = new System.Drawing.Size(51, 19);
            this.TodoRadioButton.TabIndex = 0;
            this.TodoRadioButton.TabStop = true;
            this.TodoRadioButton.Text = "Todo";
            this.TodoRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(735, 10);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(72, 65);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(795, 410);
            this.dataGridView1.TabIndex = 7;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.Location = new System.Drawing.Point(14, 495);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(110, 28);
            this.ImprimirButton.TabIndex = 8;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // cPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 523);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroCheckBox);
            this.Name = "cPedidos";
            this.Text = "Consulta de Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton InactivoRadioButton;
        private System.Windows.Forms.RadioButton ActivoRadioButton;
        private System.Windows.Forms.RadioButton TodoRadioButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImprimirButton;
    }
}