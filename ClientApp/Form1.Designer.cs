
namespace ClientApp
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
            this.textBox_Query = new System.Windows.Forms.TextBox();
            this.button_Execute = new System.Windows.Forms.Button();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Info = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Exexute_set = new System.Windows.Forms.Button();
            this.button_ExecUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RowFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SortFilter = new System.Windows.Forms.TextBox();
            this.button_FilterExec = new System.Windows.Forms.Button();
            this.button_SortExec = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonPaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Query
            // 
            this.textBox_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Query.Location = new System.Drawing.Point(16, 16);
            this.textBox_Query.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Query.Name = "textBox_Query";
            this.textBox_Query.Size = new System.Drawing.Size(816, 36);
            this.textBox_Query.TabIndex = 0;
            // 
            // button_Execute
            // 
            this.button_Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Execute.Location = new System.Drawing.Point(843, 10);
            this.button_Execute.Margin = new System.Windows.Forms.Padding(4);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(217, 76);
            this.button_Execute.TabIndex = 1;
            this.button_Execute.Text = "Execute DataTable";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Location = new System.Drawing.Point(16, 60);
            this.dataGridView_Results.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.RowHeadersWidth = 51;
            this.dataGridView_Results.Size = new System.Drawing.Size(816, 576);
            this.dataGridView_Results.TabIndex = 2;
            this.dataGridView_Results.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Results_CellLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Info
            // 
            this.toolStripStatusLabel_Info.Name = "toolStripStatusLabel_Info";
            this.toolStripStatusLabel_Info.Size = new System.Drawing.Size(0, 16);
            // 
            // button_Exexute_set
            // 
            this.button_Exexute_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exexute_set.Location = new System.Drawing.Point(843, 95);
            this.button_Exexute_set.Margin = new System.Windows.Forms.Padding(4);
            this.button_Exexute_set.Name = "button_Exexute_set";
            this.button_Exexute_set.Size = new System.Drawing.Size(217, 71);
            this.button_Exexute_set.TabIndex = 4;
            this.button_Exexute_set.Text = "Execute DataSet";
            this.button_Exexute_set.UseVisualStyleBackColor = true;
            this.button_Exexute_set.Click += new System.EventHandler(this.button_Exexute_set_Click);
            // 
            // button_ExecUpdate
            // 
            this.button_ExecUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ExecUpdate.Location = new System.Drawing.Point(843, 192);
            this.button_ExecUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.button_ExecUpdate.Name = "button_ExecUpdate";
            this.button_ExecUpdate.Size = new System.Drawing.Size(217, 49);
            this.button_ExecUpdate.TabIndex = 5;
            this.button_ExecUpdate.Text = "Custom Update";
            this.button_ExecUpdate.UseVisualStyleBackColor = true;
            this.button_ExecUpdate.Click += new System.EventHandler(this.button_ExecUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(843, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр по:";
            // 
            // textBox_RowFilter
            // 
            this.textBox_RowFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_RowFilter.Location = new System.Drawing.Point(843, 287);
            this.textBox_RowFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RowFilter.Name = "textBox_RowFilter";
            this.textBox_RowFilter.Size = new System.Drawing.Size(216, 36);
            this.textBox_RowFilter.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(841, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сортировака по:";
            // 
            // textBox_SortFilter
            // 
            this.textBox_SortFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SortFilter.Location = new System.Drawing.Point(841, 412);
            this.textBox_SortFilter.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SortFilter.Name = "textBox_SortFilter";
            this.textBox_SortFilter.Size = new System.Drawing.Size(216, 36);
            this.textBox_SortFilter.TabIndex = 7;
            // 
            // button_FilterExec
            // 
            this.button_FilterExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_FilterExec.Location = new System.Drawing.Point(843, 332);
            this.button_FilterExec.Margin = new System.Windows.Forms.Padding(4);
            this.button_FilterExec.Name = "button_FilterExec";
            this.button_FilterExec.Size = new System.Drawing.Size(217, 41);
            this.button_FilterExec.TabIndex = 8;
            this.button_FilterExec.Text = "Filter Execute";
            this.button_FilterExec.UseVisualStyleBackColor = true;
            this.button_FilterExec.Click += new System.EventHandler(this.button_FilterExec_Click);
            // 
            // button_SortExec
            // 
            this.button_SortExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SortExec.Location = new System.Drawing.Point(841, 457);
            this.button_SortExec.Margin = new System.Windows.Forms.Padding(4);
            this.button_SortExec.Name = "button_SortExec";
            this.button_SortExec.Size = new System.Drawing.Size(217, 41);
            this.button_SortExec.TabIndex = 8;
            this.button_SortExec.Text = "Sorted Execute";
            this.button_SortExec.UseVisualStyleBackColor = true;
            this.button_SortExec.Click += new System.EventHandler(this.button_SortExec_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(841, 522);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(218, 39);
            this.buttonOpenFile.TabIndex = 9;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaint.Location = new System.Drawing.Point(843, 589);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(214, 47);
            this.buttonPaint.TabIndex = 10;
            this.buttonPaint.Text = "Paint";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 702);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.button_SortExec);
            this.Controls.Add(this.button_FilterExec);
            this.Controls.Add(this.textBox_SortFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_RowFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ExecUpdate);
            this.Controls.Add(this.button_Exexute_set);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView_Results);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.textBox_Query);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Query;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Info;
        private System.Windows.Forms.Button button_Exexute_set;
        private System.Windows.Forms.Button button_ExecUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_RowFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SortFilter;
        private System.Windows.Forms.Button button_FilterExec;
        private System.Windows.Forms.Button button_SortExec;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonPaint;
    }
}

