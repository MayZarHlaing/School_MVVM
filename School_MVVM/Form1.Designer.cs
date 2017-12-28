namespace School_MVVM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiStudent = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStandard = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCourse = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bbiLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiStudent,
            this.bbiStandard,
            this.bbiCourse,
            this.bbiCommand,
            this.bbiLogOut});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(819, 141);
            this.ribbonControl1.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbonControl1_Merge);
            // 
            // bbiStudent
            // 
            this.bbiStudent.Caption = "Student";
            this.bbiStudent.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiStudent.Glyph")));
            this.bbiStudent.Id = 1;
            this.bbiStudent.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiStudent.LargeGlyph")));
            this.bbiStudent.Name = "bbiStudent";
            // 
            // bbiStandard
            // 
            this.bbiStandard.Caption = "Standard";
            this.bbiStandard.Id = 2;
            this.bbiStandard.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiStandard.LargeGlyph")));
            this.bbiStandard.Name = "bbiStandard";
            // 
            // bbiCourse
            // 
            this.bbiCourse.Caption = "Course";
            this.bbiCourse.Id = 3;
            this.bbiCourse.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCourse.LargeGlyph")));
            this.bbiCourse.Name = "bbiCourse";
            // 
            // bbiCommand
            // 
            this.bbiCommand.Caption = "Command";
            this.bbiCommand.Id = 4;
            this.bbiCommand.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCommand.LargeGlyph")));
            this.bbiCommand.Name = "bbiCommand";
            // 
            // bbiLogOut
            // 
            this.bbiLogOut.Caption = "LogOut";
            this.bbiLogOut.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiLogOut.Glyph")));
            this.bbiLogOut.Id = 5;
            this.bbiLogOut.Name = "bbiLogOut";
            this.bbiLogOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "No(1) High School";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiStudent);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiStandard);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCourse);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCommand);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiLogOut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "School";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterDocumentManagerService(null, false, this.tabbedView1)});
            this.mvvmContext1.ViewModelType = typeof(School_MVVM.ViewModels.MyDbContextViewModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 428);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiStudent;
        private DevExpress.XtraBars.BarButtonItem bbiStandard;
        private DevExpress.XtraBars.BarButtonItem bbiCourse;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.BarButtonItem bbiCommand;
        private DevExpress.XtraBars.BarButtonItem bbiLogOut;
    }
}

