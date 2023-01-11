namespace CsvConverter
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.LoadPatch = new System.Windows.Forms.TextBox();
            this.ListParams = new System.Windows.Forms.ListView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.DeselectTheSelection = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Csv files(*.csv)|*.csv";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Csv files(*.csv)|*.csv";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 761);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.Filter);
            this.splitContainer2.Panel1.Controls.Add(this.Open);
            this.splitContainer2.Panel1.Controls.Add(this.LoadPatch);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ListParams);
            this.splitContainer2.Size = new System.Drawing.Size(504, 761);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фильтр по наименованию";
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(12, 49);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(480, 20);
            this.Filter.TabIndex = 2;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(417, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 2;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // LoadPatch
            // 
            this.LoadPatch.Enabled = false;
            this.LoadPatch.Location = new System.Drawing.Point(12, 5);
            this.LoadPatch.Name = "LoadPatch";
            this.LoadPatch.Size = new System.Drawing.Size(399, 20);
            this.LoadPatch.TabIndex = 1;
            // 
            // ListParams
            // 
            this.ListParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListParams.HideSelection = false;
            this.ListParams.Location = new System.Drawing.Point(0, 0);
            this.ListParams.Name = "ListParams";
            this.ListParams.Size = new System.Drawing.Size(504, 677);
            this.ListParams.TabIndex = 1;
            this.ListParams.UseCompatibleStateImageBehavior = false;
            this.ListParams.View = System.Windows.Forms.View.Details;
            this.ListParams.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListParams_ItemSelectionChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.DeselectTheSelection);
            this.splitContainer3.Panel1.Controls.Add(this.SelectAll);
            this.splitContainer3.Panel1.Controls.Add(this.Save);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listBox2);
            this.splitContainer3.Size = new System.Drawing.Size(500, 761);
            this.splitContainer3.SplitterDistance = 42;
            this.splitContainer3.TabIndex = 0;
            // 
            // DeselectTheSelection
            // 
            this.DeselectTheSelection.Location = new System.Drawing.Point(196, 10);
            this.DeselectTheSelection.Name = "DeselectTheSelection";
            this.DeselectTheSelection.Size = new System.Drawing.Size(187, 23);
            this.DeselectTheSelection.TabIndex = 7;
            this.DeselectTheSelection.Text = "Снять выделение со всего";
            this.DeselectTheSelection.UseVisualStyleBackColor = true;
            this.DeselectTheSelection.Click += new System.EventHandler(this.DeselectTheSelection_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(3, 10);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(187, 22);
            this.SelectAll.TabIndex = 6;
            this.SelectAll.Text = "Выделить всё отфильтрованное";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(413, 10);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(500, 715);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 800);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Конвертер csv";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox LoadPatch;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ListView ListParams;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.Button DeselectTheSelection;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Label label2;
    }
}

