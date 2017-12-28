namespace School_MVVM.Views.Course
{
    partial class StudentEditView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.StudentIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.standardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForStudentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStudentName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStudentName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 141);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 1;
            this.bbiSave.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "SaveAndClose";
            this.bbiSaveAndClose.Id = 2;
            this.bbiSaveAndClose.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "SaveAndNew";
            this.bbiSaveAndNew.Id = 3;
            this.bbiSaveAndNew.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 4;
            this.bbiReset.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Edit Student";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Save";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Delete";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiClose);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Close";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.StudentIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StudentNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit1);
            this.dataLayoutControl1.Controls.Add(this.textEdit4);
            this.dataLayoutControl1.DataSource = this.studentBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(758, 320);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            this.dataLayoutControl1.Click += new System.EventHandler(this.dataLayoutControl1_Click);
            // 
            // StudentIdTextEdit
            // 
            this.StudentIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "StudentId", true));
            this.StudentIdTextEdit.Location = new System.Drawing.Point(83, 12);
            this.StudentIdTextEdit.MenuManager = this.ribbonControl1;
            this.StudentIdTextEdit.Name = "StudentIdTextEdit";
            this.StudentIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StudentIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StudentIdTextEdit.Properties.Mask.EditMask = "N0";
            this.StudentIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.StudentIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.StudentIdTextEdit.Size = new System.Drawing.Size(663, 20);
            this.StudentIdTextEdit.StyleController = this.dataLayoutControl1;
            this.StudentIdTextEdit.TabIndex = 4;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(School_MVVM.DataModel.Student);
            // 
            // StudentNameTextEdit
            // 
            this.StudentNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentBindingSource, "StudentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StudentNameTextEdit.Location = new System.Drawing.Point(83, 36);
            this.StudentNameTextEdit.MenuManager = this.ribbonControl1;
            this.StudentNameTextEdit.Name = "StudentNameTextEdit";
            this.StudentNameTextEdit.Size = new System.Drawing.Size(663, 20);
            this.StudentNameTextEdit.StyleController = this.dataLayoutControl1;
            this.StudentNameTextEdit.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.standardBindingSource, "StandardId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.Location = new System.Drawing.Point(95, 90);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StandardId", "Standard Id", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Students", "Students", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.textEdit1.Properties.DataSource = this.standardBindingSource;
            this.textEdit1.Properties.DisplayMember = "StandardId";
            this.textEdit1.Properties.NullText = "";
            this.textEdit1.Properties.PopupSizeable = false;
            this.textEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.textEdit1.Properties.ValueMember = "StandardId";
            this.textEdit1.Size = new System.Drawing.Size(639, 20);
            this.textEdit1.StyleController = this.dataLayoutControl1;
            this.textEdit1.TabIndex = 6;
            // 
            // standardBindingSource
            // 
            this.standardBindingSource.DataSource = typeof(School_MVVM.DataModel.Standard);
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courseBindingSource, "CourseId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit4.Location = new System.Drawing.Point(95, 156);
            this.textEdit4.MenuManager = this.ribbonControl1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseId", "Course Id", 70, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseName", "Course Name", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Students", "Students", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.textEdit4.Properties.DataSource = this.courseBindingSource;
            this.textEdit4.Properties.DisplayMember = "CourseId";
            this.textEdit4.Properties.NullText = "";
            this.textEdit4.Properties.ValueMember = "CourseName";
            this.textEdit4.Size = new System.Drawing.Size(639, 20);
            this.textEdit4.StyleController = this.dataLayoutControl1;
            this.textEdit4.TabIndex = 9;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(School_MVVM.DataModel.Course);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(758, 320);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForStudentId,
            this.ItemForStudentName,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(738, 300);
            // 
            // ItemForStudentId
            // 
            this.ItemForStudentId.Control = this.StudentIdTextEdit;
            this.ItemForStudentId.Location = new System.Drawing.Point(0, 0);
            this.ItemForStudentId.Name = "ItemForStudentId";
            this.ItemForStudentId.Size = new System.Drawing.Size(738, 24);
            this.ItemForStudentId.Text = "Student Id";
            this.ItemForStudentId.TextSize = new System.Drawing.Size(68, 13);
            // 
            // ItemForStudentName
            // 
            this.ItemForStudentName.Control = this.StudentNameTextEdit;
            this.ItemForStudentName.Location = new System.Drawing.Point(0, 24);
            this.ItemForStudentName.Name = "ItemForStudentName";
            this.ItemForStudentName.Size = new System.Drawing.Size(738, 24);
            this.ItemForStudentName.Text = "Student Name";
            this.ItemForStudentName.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlGroup3.Name = "innerAutoGeneratedGroup1";
            this.layoutControlGroup3.Size = new System.Drawing.Size(738, 66);
            this.layoutControlGroup3.Text = "Standard";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForStandard.StandardId";
            this.layoutControlItem1.Size = new System.Drawing.Size(714, 24);
            this.layoutControlItem1.Text = "Standard Id";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 114);
            this.layoutControlGroup4.Name = "innerAutoGeneratedGroup2";
            this.layoutControlGroup4.Size = new System.Drawing.Size(738, 186);
            this.layoutControlGroup4.Text = "Course";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit4;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "ItemForCourse.CourseId";
            this.layoutControlItem4.Size = new System.Drawing.Size(714, 144);
            this.layoutControlItem4.Text = "Course Id";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(68, 13);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.StudentViewModel), "Close", this.bbiClose)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(School_MVVM.ViewModels.StudentViewModel);
            // 
            // StudentEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "StudentEditView";
            this.Size = new System.Drawing.Size(758, 461);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStudentName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit StudentIdTextEdit;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DevExpress.XtraEditors.TextEdit StudentNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStudentId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStudentName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private System.Windows.Forms.BindingSource standardBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DevExpress.XtraEditors.LookUpEdit textEdit1;
        private DevExpress.XtraEditors.LookUpEdit textEdit4;
    }
}
