namespace School_MVVM.Views.Course
{
    partial class CourseEditView
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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CourseIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CourseNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCourseId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCourseName = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourseId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourseName)).BeginInit();
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
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(661, 141);
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Close";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageUri.Uri = "Close";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Edit Course";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiReset);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CourseIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CourseNameTextEdit);
            this.dataLayoutControl1.DataSource = this.courseBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 141);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(661, 314);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CourseIdTextEdit
            // 
            this.CourseIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courseBindingSource, "CourseId", true));
            this.CourseIdTextEdit.Location = new System.Drawing.Point(79, 12);
            this.CourseIdTextEdit.MenuManager = this.ribbonControl1;
            this.CourseIdTextEdit.Name = "CourseIdTextEdit";
            this.CourseIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CourseIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CourseIdTextEdit.Properties.Mask.EditMask = "N0";
            this.CourseIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CourseIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CourseIdTextEdit.Size = new System.Drawing.Size(570, 20);
            this.CourseIdTextEdit.StyleController = this.dataLayoutControl1;
            this.CourseIdTextEdit.TabIndex = 4;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(School_MVVM.DataModel.Course);
            // 
            // CourseNameTextEdit
            // 
            this.CourseNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.courseBindingSource, "CourseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CourseNameTextEdit.Location = new System.Drawing.Point(79, 36);
            this.CourseNameTextEdit.MenuManager = this.ribbonControl1;
            this.CourseNameTextEdit.Name = "CourseNameTextEdit";
            this.CourseNameTextEdit.Size = new System.Drawing.Size(570, 20);
            this.CourseNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CourseNameTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(661, 314);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCourseId,
            this.ItemForCourseName});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(641, 294);
            // 
            // ItemForCourseId
            // 
            this.ItemForCourseId.Control = this.CourseIdTextEdit;
            this.ItemForCourseId.Location = new System.Drawing.Point(0, 0);
            this.ItemForCourseId.Name = "ItemForCourseId";
            this.ItemForCourseId.Size = new System.Drawing.Size(641, 24);
            this.ItemForCourseId.Text = "Course Id";
            this.ItemForCourseId.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForCourseName
            // 
            this.ItemForCourseName.Control = this.CourseNameTextEdit;
            this.ItemForCourseName.Location = new System.Drawing.Point(0, 24);
            this.ItemForCourseName.Name = "ItemForCourseName";
            this.ItemForCourseName.Size = new System.Drawing.Size(641, 270);
            this.ItemForCourseName.Text = "Course Name";
            this.ItemForCourseName.TextSize = new System.Drawing.Size(64, 13);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(School_MVVM.ViewModels.CourseViewModel), "Close", this.barButtonItem1)});
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(School_MVVM.ViewModels.CourseViewModel);
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 5;
            this.bbiSaveLayout.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // CourseEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CourseEditView";
            this.Size = new System.Drawing.Size(661, 455);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CourseIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourseId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCourseName)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit CourseIdTextEdit;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DevExpress.XtraEditors.TextEdit CourseNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCourseId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCourseName;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
    }
}
