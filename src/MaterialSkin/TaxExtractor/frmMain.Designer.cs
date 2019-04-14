namespace TaxExtractor
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanel1 = new TaxExtractor.UserControls.MaterialPanel();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClose = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanel4 = new TaxExtractor.UserControls.MaterialPanel();
            this.pnlDetailsList = new System.Windows.Forms.Panel();
            this.lsvDetailsList = new MaterialSkin.Controls.MaterialListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanel3 = new TaxExtractor.UserControls.MaterialPanel();
            this.detailsListDivider = new MaterialSkin.Controls.MaterialDivider();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialPanel2 = new TaxExtractor.UserControls.MaterialPanel();
            this.tblMainPanel.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlDetailsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMainPanel
            // 
            this.tblMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblMainPanel.ColumnCount = 3;
            this.tblMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPanel.Controls.Add(this.pnlSearch, 1, 1);
            this.tblMainPanel.Controls.Add(this.pnlActions, 1, 3);
            this.tblMainPanel.Controls.Add(this.pnlDetailsList, 1, 2);
            this.tblMainPanel.Location = new System.Drawing.Point(1, 65);
            this.tblMainPanel.Name = "tblMainPanel";
            this.tblMainPanel.RowCount = 5;
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPanel.Size = new System.Drawing.Size(798, 434);
            this.tblMainPanel.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtPath);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.materialLabel3);
            this.pnlSearch.Controls.Add(this.materialPanel1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(23, 23);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(752, 74);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Depth = 0;
            this.txtPath.Enabled = false;
            this.txtPath.Hint = "";
            this.txtPath.Location = new System.Drawing.Point(20, 36);
            this.txtPath.MaxLength = 32767;
            this.txtPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.Size = new System.Drawing.Size(634, 23);
            this.txtPath.TabIndex = 7;
            this.txtPath.TabStop = false;
            this.txtPath.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(661, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(74, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(114, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Buscar facturas";
            // 
            // materialPanel1
            // 
            this.materialPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialPanel1.Location = new System.Drawing.Point(0, 12);
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.ShowBottomLine = true;
            this.materialPanel1.ShowLeftLine = true;
            this.materialPanel1.ShowRightLine = true;
            this.materialPanel1.ShowTopLine = true;
            this.materialPanel1.Size = new System.Drawing.Size(752, 62);
            this.materialPanel1.TabIndex = 4;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.btnClose);
            this.pnlActions.Controls.Add(this.materialLabel1);
            this.pnlActions.Controls.Add(this.materialPanel4);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(23, 337);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(752, 74);
            this.pnlActions.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(651, 26);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(571, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = false;
            this.btnClose.Size = new System.Drawing.Size(73, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Acciones";
            // 
            // materialPanel4
            // 
            this.materialPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialPanel4.Location = new System.Drawing.Point(0, 17);
            this.materialPanel4.Name = "materialPanel4";
            this.materialPanel4.ShowBottomLine = true;
            this.materialPanel4.ShowLeftLine = true;
            this.materialPanel4.ShowRightLine = true;
            this.materialPanel4.ShowTopLine = true;
            this.materialPanel4.Size = new System.Drawing.Size(752, 54);
            this.materialPanel4.TabIndex = 5;
            // 
            // pnlDetailsList
            // 
            this.pnlDetailsList.Controls.Add(this.lsvDetailsList);
            this.pnlDetailsList.Controls.Add(this.materialLabel2);
            this.pnlDetailsList.Controls.Add(this.materialPanel3);
            this.pnlDetailsList.Controls.Add(this.detailsListDivider);
            this.pnlDetailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailsList.Location = new System.Drawing.Point(23, 103);
            this.pnlDetailsList.Name = "pnlDetailsList";
            this.pnlDetailsList.Size = new System.Drawing.Size(752, 228);
            this.pnlDetailsList.TabIndex = 0;
            // 
            // lsvDetailsList
            // 
            this.lsvDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDetailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colUuid});
            this.lsvDetailsList.Depth = 0;
            this.lsvDetailsList.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.lsvDetailsList.FullRowSelect = true;
            this.lsvDetailsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvDetailsList.Location = new System.Drawing.Point(16, 35);
            this.lsvDetailsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvDetailsList.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvDetailsList.Name = "lsvDetailsList";
            this.lsvDetailsList.OwnerDraw = true;
            this.lsvDetailsList.Size = new System.Drawing.Size(719, 190);
            this.lsvDetailsList.TabIndex = 6;
            this.lsvDetailsList.UseCompatibleStateImageBehavior = false;
            this.lsvDetailsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            // 
            // colUuid
            // 
            this.colUuid.Text = "UUID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Lista de detalles";
            // 
            // materialPanel3
            // 
            this.materialPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialPanel3.Location = new System.Drawing.Point(0, 20);
            this.materialPanel3.Name = "materialPanel3";
            this.materialPanel3.ShowBottomLine = true;
            this.materialPanel3.ShowLeftLine = true;
            this.materialPanel3.ShowRightLine = true;
            this.materialPanel3.ShowTopLine = true;
            this.materialPanel3.Size = new System.Drawing.Size(752, 208);
            this.materialPanel3.TabIndex = 5;
            // 
            // detailsListDivider
            // 
            this.detailsListDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsListDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.detailsListDivider.Depth = 0;
            this.detailsListDivider.Location = new System.Drawing.Point(2, 224);
            this.detailsListDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.detailsListDivider.Name = "detailsListDivider";
            this.detailsListDivider.Size = new System.Drawing.Size(752, 1);
            this.detailsListDivider.TabIndex = 3;
            this.detailsListDivider.Text = "materialDivider1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dessert (100g serving)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fat (g)";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein (g)";
            this.columnHeader4.Width = 154;
            // 
            // materialPanel2
            // 
            this.materialPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialPanel2.Location = new System.Drawing.Point(0, 65);
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.ShowBottomLine = true;
            this.materialPanel2.ShowLeftLine = true;
            this.materialPanel2.ShowRightLine = true;
            this.materialPanel2.ShowTopLine = false;
            this.materialPanel2.Size = new System.Drawing.Size(800, 434);
            this.materialPanel2.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tblMainPanel);
            this.Controls.Add(this.materialPanel2);
            this.Name = "frmMain";
            this.Text = "Tax Extractor";
            this.tblMainPanel.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlDetailsList.ResumeLayout(false);
            this.pnlDetailsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainPanel;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Panel pnlDetailsList;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnClose;
        private MaterialSkin.Controls.MaterialDivider detailsListDivider;
        private UserControls.MaterialPanel materialPanel1;
        private UserControls.MaterialPanel materialPanel2;
        private UserControls.MaterialPanel materialPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private UserControls.MaterialPanel materialPanel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPath;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialListView lsvDetailsList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colUuid;
    }
}

