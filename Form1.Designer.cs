
namespace WindowsFormsApp1530._03
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gilevavDataSet = new WindowsFormsApp1530._03.gilevavDataSet();
            this.gilevavDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.info_ticketsTableAdapter = new WindowsFormsApp1530._03.gilevavDataSetTableAdapters.info_ticketsTableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.spectacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spectacleTableAdapter = new WindowsFormsApp1530._03.gilevavDataSetTableAdapters.spectacleTableAdapter();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new WindowsFormsApp1530._03.gilevavDataSetTableAdapters.ticketTableAdapter();
            this.codeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gilevavDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gilevavDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.numberofticketsDataGridViewTextBoxColumn,
            this.soldDataGridViewTextBoxColumn,
            this.returnticketsDataGridViewTextBoxColumn,
            this.freeticketsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 44);
            this.dataGridView1.TabIndex = 0;
            // 
            // gilevavDataSet
            // 
            this.gilevavDataSet.DataSetName = "gilevavDataSet";
            this.gilevavDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gilevavDataSetBindingSource
            // 
            this.gilevavDataSetBindingSource.DataSource = this.gilevavDataSet;
            this.gilevavDataSetBindingSource.Position = 0;
            // 
            // infoticketsBindingSource
            // 
            this.infoticketsBindingSource.DataMember = "info_tickets";
            this.infoticketsBindingSource.DataSource = this.gilevavDataSetBindingSource;
            // 
            // info_ticketsTableAdapter
            // 
            this.info_ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // numberofticketsDataGridViewTextBoxColumn
            // 
            this.numberofticketsDataGridViewTextBoxColumn.DataPropertyName = "number_of_tickets";
            this.numberofticketsDataGridViewTextBoxColumn.HeaderText = "number_of_tickets";
            this.numberofticketsDataGridViewTextBoxColumn.Name = "numberofticketsDataGridViewTextBoxColumn";
            // 
            // soldDataGridViewTextBoxColumn
            // 
            this.soldDataGridViewTextBoxColumn.DataPropertyName = "sold";
            this.soldDataGridViewTextBoxColumn.HeaderText = "sold";
            this.soldDataGridViewTextBoxColumn.Name = "soldDataGridViewTextBoxColumn";
            // 
            // returnticketsDataGridViewTextBoxColumn
            // 
            this.returnticketsDataGridViewTextBoxColumn.DataPropertyName = "return_tickets";
            this.returnticketsDataGridViewTextBoxColumn.HeaderText = "return_tickets";
            this.returnticketsDataGridViewTextBoxColumn.Name = "returnticketsDataGridViewTextBoxColumn";
            // 
            // freeticketsDataGridViewTextBoxColumn
            // 
            this.freeticketsDataGridViewTextBoxColumn.DataPropertyName = "free_tickets";
            this.freeticketsDataGridViewTextBoxColumn.HeaderText = "free_tickets";
            this.freeticketsDataGridViewTextBoxColumn.Name = "freeticketsDataGridViewTextBoxColumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(384, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "Таблицы информации по билетам";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn1,
            this.spectacleDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.produserDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.spectacleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(89, 297);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(641, 61);
            this.dataGridView2.TabIndex = 36;
            // 
            // spectacleBindingSource
            // 
            this.spectacleBindingSource.DataMember = "spectacle";
            this.spectacleBindingSource.DataSource = this.gilevavDataSetBindingSource;
            // 
            // spectacleTableAdapter
            // 
            this.spectacleTableAdapter.ClearBeforeFill = true;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // spectacleDataGridViewTextBoxColumn
            // 
            this.spectacleDataGridViewTextBoxColumn.DataPropertyName = "spectacle";
            this.spectacleDataGridViewTextBoxColumn.HeaderText = "spectacle";
            this.spectacleDataGridViewTextBoxColumn.Name = "spectacleDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // produserDataGridViewTextBoxColumn
            // 
            this.produserDataGridViewTextBoxColumn.DataPropertyName = "produser";
            this.produserDataGridViewTextBoxColumn.HeaderText = "produser";
            this.produserDataGridViewTextBoxColumn.Name = "produserDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn2,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.plaseDataGridViewTextBoxColumn,
            this.rowDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ticketBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(133, 140);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(540, 42);
            this.dataGridView3.TabIndex = 37;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "ticket";
            this.ticketBindingSource.DataSource = this.gilevavDataSetBindingSource;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // codeDataGridViewTextBoxColumn2
            // 
            this.codeDataGridViewTextBoxColumn2.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn2.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn2.Name = "codeDataGridViewTextBoxColumn2";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // plaseDataGridViewTextBoxColumn
            // 
            this.plaseDataGridViewTextBoxColumn.DataPropertyName = "plase";
            this.plaseDataGridViewTextBoxColumn.HeaderText = "plase";
            this.plaseDataGridViewTextBoxColumn.Name = "plaseDataGridViewTextBoxColumn";
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "row";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gilevavDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gilevavDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gilevavDataSetBindingSource;
        private gilevavDataSet gilevavDataSet;
        private System.Windows.Forms.BindingSource infoticketsBindingSource;
        private gilevavDataSetTableAdapters.info_ticketsTableAdapter info_ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeticketsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource spectacleBindingSource;
        private gilevavDataSetTableAdapters.spectacleTableAdapter spectacleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private gilevavDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
    }
}

