namespace RentACar
{
    partial class Cars
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
            this.components = new System.ComponentModel.Container();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.carsTableAdapter = new RentACar.RentACarDataSetTableAdapters.CarsTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFueld = new System.Windows.Forms.ComboBox();
            this.fuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTransmission = new System.Windows.Forms.ComboBox();
            this.transmisionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsTableAdapter = new RentACar.RentACarDataSetTableAdapters.ModelsTableAdapter();
            this.seriesTableAdapter = new RentACar.RentACarDataSetTableAdapters.SeriesTableAdapter();
            this.transmisionsTableAdapter = new RentACar.RentACarDataSetTableAdapters.TransmisionsTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fuelsTableAdapter = new RentACar.RentACarDataSetTableAdapters.FuelsTableAdapter();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transmisionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelNameDataGridViewTextBoxColumn,
            this.SerieName,
            this.yearDataGridViewTextBoxColumn,
            this.transmissionNameDataGridViewTextBoxColumn,
            this.FuelsName,
            this.idDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn,
            this.serieIdDataGridViewTextBoxColumn,
            this.transmissionIdDataGridViewTextBoxColumn,
            this.fuelIdDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.carsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(885, 332);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(382, 52);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 1;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DataSource = this.modelsBindingSource;
            this.comboBoxModel.DisplayMember = "Name";
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(34, 51);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.ValueMember = "Id";
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // comboBoxFueld
            // 
            this.comboBoxFueld.DataSource = this.fuelsBindingSource;
            this.comboBoxFueld.DisplayMember = "Name";
            this.comboBoxFueld.FormattingEnabled = true;
            this.comboBoxFueld.Location = new System.Drawing.Point(673, 51);
            this.comboBoxFueld.Name = "comboBoxFueld";
            this.comboBoxFueld.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFueld.TabIndex = 3;
            this.comboBoxFueld.ValueMember = "Id";
            this.comboBoxFueld.SelectedIndexChanged += new System.EventHandler(this.comboBoxfueld_SelectedIndexChanged);
            // 
            // fuelsBindingSource
            // 
            this.fuelsBindingSource.DataMember = "Fuels";
            this.fuelsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.DataSource = this.seriesBindingSource;
            this.comboBoxSeries.DisplayMember = "Name";
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(208, 51);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeries.TabIndex = 4;
            this.comboBoxSeries.ValueMember = "Id";
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.rentACarDataSet;
            // 
            // comboBoxTransmission
            // 
            this.comboBoxTransmission.DataSource = this.transmisionsBindingSource;
            this.comboBoxTransmission.DisplayMember = "Name";
            this.comboBoxTransmission.FormattingEnabled = true;
            this.comboBoxTransmission.Location = new System.Drawing.Point(518, 49);
            this.comboBoxTransmission.Name = "comboBoxTransmission";
            this.comboBoxTransmission.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTransmission.TabIndex = 5;
            this.comboBoxTransmission.ValueMember = "Id";
            // 
            // transmisionsBindingSource
            // 
            this.transmisionsBindingSource.DataMember = "Transmisions";
            this.transmisionsBindingSource.DataSource = this.rentACarDataSet;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // transmisionsTableAdapter
            // 
            this.transmisionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(813, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Elave Et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(421, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(15, 13);
            this.label.TabIndex = 7;
            this.label.Text = "iL";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(250, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seriya";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(554, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Suret qutusu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(698, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yanacaq novu";
            // 
            // fuelsTableAdapter
            // 
            this.fuelsTableAdapter.ClearBeforeFill = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // SerieName
            // 
            this.SerieName.DataPropertyName = "SerieName";
            this.SerieName.HeaderText = "SerieName";
            this.SerieName.Name = "SerieName";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // transmissionNameDataGridViewTextBoxColumn
            // 
            this.transmissionNameDataGridViewTextBoxColumn.DataPropertyName = "TransmissionName";
            this.transmissionNameDataGridViewTextBoxColumn.HeaderText = "TransmissionName";
            this.transmissionNameDataGridViewTextBoxColumn.Name = "transmissionNameDataGridViewTextBoxColumn";
            // 
            // FuelsName
            // 
            this.FuelsName.DataPropertyName = "FuelsName";
            this.FuelsName.HeaderText = "FuelsName";
            this.FuelsName.Name = "FuelsName";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // serieIdDataGridViewTextBoxColumn
            // 
            this.serieIdDataGridViewTextBoxColumn.DataPropertyName = "SerieId";
            this.serieIdDataGridViewTextBoxColumn.HeaderText = "SerieId";
            this.serieIdDataGridViewTextBoxColumn.Name = "serieIdDataGridViewTextBoxColumn";
            this.serieIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // transmissionIdDataGridViewTextBoxColumn
            // 
            this.transmissionIdDataGridViewTextBoxColumn.DataPropertyName = "TransmissionId";
            this.transmissionIdDataGridViewTextBoxColumn.HeaderText = "TransmissionId";
            this.transmissionIdDataGridViewTextBoxColumn.Name = "transmissionIdDataGridViewTextBoxColumn";
            this.transmissionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fuelIdDataGridViewTextBoxColumn
            // 
            this.fuelIdDataGridViewTextBoxColumn.DataPropertyName = "FuelId";
            this.fuelIdDataGridViewTextBoxColumn.HeaderText = "FuelId";
            this.fuelIdDataGridViewTextBoxColumn.Name = "fuelIdDataGridViewTextBoxColumn";
            this.fuelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxTransmission);
            this.Controls.Add(this.comboBoxSeries);
            this.Controls.Add(this.comboBoxFueld);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.dataGridView);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transmisionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private RentACarDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxFueld;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.ComboBox comboBoxTransmission;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private RentACarDataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private RentACarDataSetTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.BindingSource fuelsBindingSource;
        private System.Windows.Forms.BindingSource transmisionsBindingSource;
        private RentACarDataSetTableAdapters.TransmisionsTableAdapter transmisionsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private RentACarDataSetTableAdapters.FuelsTableAdapter fuelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelIdDataGridViewTextBoxColumn;
    }
}