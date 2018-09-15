namespace RegistryBook
{
    partial class RegistryBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textE_name = new DevExpress.XtraEditors.TextEdit();
            this.textE_lastname = new DevExpress.XtraEditors.TextEdit();
            this.textE_gsm = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.calender = new DevExpress.XtraEditors.DateEdit();
            this.updateButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.grid_registry = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_backup = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_id_main = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_name_main = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_lastname_main = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_gsm_main = new DevExpress.XtraGrid.Columns.GridColumn();
            this.copyButton = new DevExpress.XtraEditors.SimpleButton();
            this.grid_id_backup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_name_backup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_lastname_backup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_gsm_backup = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.textE_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_lastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_gsm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_registry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_backup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gsm";
            // 
            // textE_name
            // 
            this.textE_name.Location = new System.Drawing.Point(28, 50);
            this.textE_name.Name = "textE_name";
            this.textE_name.Size = new System.Drawing.Size(100, 22);
            this.textE_name.TabIndex = 3;
            // 
            // textE_lastname
            // 
            this.textE_lastname.Location = new System.Drawing.Point(28, 114);
            this.textE_lastname.Name = "textE_lastname";
            this.textE_lastname.Size = new System.Drawing.Size(100, 22);
            this.textE_lastname.TabIndex = 4;
            // 
            // textE_gsm
            // 
            this.textE_gsm.Location = new System.Drawing.Point(28, 165);
            this.textE_gsm.Name = "textE_gsm";
            this.textE_gsm.Size = new System.Drawing.Size(100, 22);
            this.textE_gsm.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(31, 219);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 61);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // calender
            // 
            this.calender.EditValue = null;
            this.calender.Location = new System.Drawing.Point(28, 490);
            this.calender.Name = "calender";
            this.calender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calender.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calender.Size = new System.Drawing.Size(112, 22);
            this.calender.TabIndex = 8;
            // 
            // updateButton1
            // 
            this.updateButton1.Location = new System.Drawing.Point(31, 310);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(100, 61);
            this.updateButton1.TabIndex = 9;
            this.updateButton1.Text = "Update";
            this.updateButton1.Click += new System.EventHandler(this.updateButton1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(31, 409);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 61);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // grid_registry
            // 
            this.grid_registry.Location = new System.Drawing.Point(181, 5);
            this.grid_registry.MainView = this.gridView1;
            this.grid_registry.Name = "grid_registry";
            this.grid_registry.Size = new System.Drawing.Size(684, 242);
            this.grid_registry.TabIndex = 11;
            this.grid_registry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grid_id_main,
            this.grid_name_main,
            this.grid_lastname_main,
            this.grid_gsm_main});
            this.gridView1.GridControl = this.grid_registry;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // grid_backup
            // 
            this.grid_backup.Location = new System.Drawing.Point(181, 306);
            this.grid_backup.MainView = this.gridView2;
            this.grid_backup.Name = "grid_backup";
            this.grid_backup.Size = new System.Drawing.Size(684, 235);
            this.grid_backup.TabIndex = 12;
            this.grid_backup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grid_id_backup,
            this.grid_name_backup,
            this.grid_lastname_backup,
            this.grid_gsm_backup});
            this.gridView2.GridControl = this.grid_backup;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // grid_id_main
            // 
            this.grid_id_main.Caption = "Id";
            this.grid_id_main.FieldName = "Id";
            this.grid_id_main.Name = "grid_id_main";
            // 
            // grid_name_main
            // 
            this.grid_name_main.Caption = "Name";
            this.grid_name_main.FieldName = "Name";
            this.grid_name_main.Name = "grid_name_main";
            this.grid_name_main.Visible = true;
            this.grid_name_main.VisibleIndex = 1;
            // 
            // grid_lastname_main
            // 
            this.grid_lastname_main.Caption = "Lastname";
            this.grid_lastname_main.FieldName = "Lastname";
            this.grid_lastname_main.Name = "grid_lastname_main";
            this.grid_lastname_main.Visible = true;
            this.grid_lastname_main.VisibleIndex = 2;
            // 
            // grid_gsm_main
            // 
            this.grid_gsm_main.Caption = "Gsm";
            this.grid_gsm_main.FieldName = "Gsm";
            this.grid_gsm_main.Name = "grid_gsm_main";
            this.grid_gsm_main.Visible = true;
            this.grid_gsm_main.VisibleIndex = 3;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(469, 253);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(100, 47);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "Copy(Down)";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // grid_id_backup
            // 
            this.grid_id_backup.Caption = "Id";
            this.grid_id_backup.FieldName = "ID";
            this.grid_id_backup.Name = "grid_id_backup";
            // 
            // grid_name_backup
            // 
            this.grid_name_backup.Caption = "Name";
            this.grid_name_backup.FieldName = "NAME";
            this.grid_name_backup.Name = "grid_name_backup";
            this.grid_name_backup.Visible = true;
            this.grid_name_backup.VisibleIndex = 1;
            // 
            // grid_lastname_backup
            // 
            this.grid_lastname_backup.Caption = "Lastname";
            this.grid_lastname_backup.FieldName = "LASTNAME";
            this.grid_lastname_backup.Name = "grid_lastname_backup";
            this.grid_lastname_backup.Visible = true;
            this.grid_lastname_backup.VisibleIndex = 2;
            // 
            // grid_gsm_backup
            // 
            this.grid_gsm_backup.Caption = "Gsm";
            this.grid_gsm_backup.FieldName = "GSM";
            this.grid_gsm_backup.Name = "grid_gsm_backup";
            this.grid_gsm_backup.Visible = true;
            this.grid_gsm_backup.VisibleIndex = 3;
            // 
            // RegistryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 564);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.grid_backup);
            this.Controls.Add(this.grid_registry);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton1);
            this.Controls.Add(this.calender);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textE_gsm);
            this.Controls.Add(this.textE_lastname);
            this.Controls.Add(this.textE_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistryBook";
            this.Text = "RegistryBook";
            this.Load += new System.EventHandler(this.RegistryBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textE_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_lastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_gsm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_registry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_backup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textE_name;
        private DevExpress.XtraEditors.TextEdit textE_lastname;
        private DevExpress.XtraEditors.TextEdit textE_gsm;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.DateEdit calender;
        private DevExpress.XtraEditors.SimpleButton updateButton1;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraGrid.GridControl grid_registry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_backup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn grid_id_main;
        private DevExpress.XtraGrid.Columns.GridColumn grid_name_main;
        private DevExpress.XtraGrid.Columns.GridColumn grid_lastname_main;
        private DevExpress.XtraGrid.Columns.GridColumn grid_gsm_main;
        private DevExpress.XtraGrid.Columns.GridColumn grid_id_backup;
        private DevExpress.XtraGrid.Columns.GridColumn grid_name_backup;
        private DevExpress.XtraGrid.Columns.GridColumn grid_lastname_backup;
        private DevExpress.XtraGrid.Columns.GridColumn grid_gsm_backup;
        private DevExpress.XtraEditors.SimpleButton copyButton;
    }
}

