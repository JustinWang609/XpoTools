namespace XpoTools
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
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUB_SYS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_ENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_S_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_E_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXT_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTXT_USR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRANCH_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpCollection1
            // 
            this.xpCollection1.LoadingEnabled = false;
            this.xpCollection1.ObjectType = typeof(XpoTools.master.PXXT_CODE);
            this.xpCollection1.Session = this.session1;
            // 
            // session1
            // 
            this.session1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.None;
            this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.session1.TrackPropertiesModifications = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(600, 377);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUB_SYS,
            this.colDATA_TYPE,
            this.colCODE,
            this.colCODE_CNAME,
            this.colCODE_ENAME,
            this.colVALID_S_DATE,
            this.colVALID_E_DATE,
            this.colTXT_STATUS,
            this.colEXE_TIME,
            this.colTXT_USR_ID,
            this.colBRANCH_CODE,
            this.colrowid});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSUB_SYS
            // 
            this.colSUB_SYS.FieldName = "SUB_SYS";
            this.colSUB_SYS.Name = "colSUB_SYS";
            this.colSUB_SYS.Visible = true;
            this.colSUB_SYS.VisibleIndex = 0;
            // 
            // colDATA_TYPE
            // 
            this.colDATA_TYPE.FieldName = "DATA_TYPE";
            this.colDATA_TYPE.Name = "colDATA_TYPE";
            this.colDATA_TYPE.Visible = true;
            this.colDATA_TYPE.VisibleIndex = 1;
            // 
            // colCODE
            // 
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 2;
            // 
            // colCODE_CNAME
            // 
            this.colCODE_CNAME.FieldName = "CODE_CNAME";
            this.colCODE_CNAME.Name = "colCODE_CNAME";
            this.colCODE_CNAME.Visible = true;
            this.colCODE_CNAME.VisibleIndex = 3;
            // 
            // colCODE_ENAME
            // 
            this.colCODE_ENAME.FieldName = "CODE_ENAME";
            this.colCODE_ENAME.Name = "colCODE_ENAME";
            this.colCODE_ENAME.Visible = true;
            this.colCODE_ENAME.VisibleIndex = 4;
            // 
            // colVALID_S_DATE
            // 
            this.colVALID_S_DATE.FieldName = "VALID_S_DATE";
            this.colVALID_S_DATE.Name = "colVALID_S_DATE";
            this.colVALID_S_DATE.Visible = true;
            this.colVALID_S_DATE.VisibleIndex = 5;
            // 
            // colVALID_E_DATE
            // 
            this.colVALID_E_DATE.FieldName = "VALID_E_DATE";
            this.colVALID_E_DATE.Name = "colVALID_E_DATE";
            this.colVALID_E_DATE.Visible = true;
            this.colVALID_E_DATE.VisibleIndex = 6;
            // 
            // colTXT_STATUS
            // 
            this.colTXT_STATUS.FieldName = "TXT_STATUS";
            this.colTXT_STATUS.Name = "colTXT_STATUS";
            this.colTXT_STATUS.Visible = true;
            this.colTXT_STATUS.VisibleIndex = 7;
            // 
            // colEXE_TIME
            // 
            this.colEXE_TIME.FieldName = "EXE_TIME";
            this.colEXE_TIME.Name = "colEXE_TIME";
            this.colEXE_TIME.Visible = true;
            this.colEXE_TIME.VisibleIndex = 8;
            // 
            // colTXT_USR_ID
            // 
            this.colTXT_USR_ID.FieldName = "TXT_USR_ID";
            this.colTXT_USR_ID.Name = "colTXT_USR_ID";
            this.colTXT_USR_ID.Visible = true;
            this.colTXT_USR_ID.VisibleIndex = 9;
            // 
            // colBRANCH_CODE
            // 
            this.colBRANCH_CODE.FieldName = "BRANCH_CODE";
            this.colBRANCH_CODE.Name = "colBRANCH_CODE";
            this.colBRANCH_CODE.Visible = true;
            this.colBRANCH_CODE.VisibleIndex = 10;
            // 
            // colrowid
            // 
            this.colrowid.FieldName = "rowid";
            this.colrowid.Name = "colrowid";
            this.colrowid.Visible = true;
            this.colrowid.VisibleIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(93, 395);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "query all";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 395);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(174, 395);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(75, 23);
            this.btnQuery1.TabIndex = 3;
            this.btnQuery1.Text = "query 1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnQuery1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.Xpo.Session session1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUB_SYS;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_ENAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_S_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_E_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colTXT_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colEXE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colTXT_USR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBRANCH_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colrowid;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnQuery1;
    }
}

