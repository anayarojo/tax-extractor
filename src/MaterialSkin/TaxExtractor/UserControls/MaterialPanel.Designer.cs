namespace TaxExtractor.UserControls
{
    partial class MaterialPanel
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bottomDivider = new MaterialSkin.Controls.MaterialDivider();
            this.leftDivider = new MaterialSkin.Controls.MaterialDivider();
            this.rightDivider = new MaterialSkin.Controls.MaterialDivider();
            this.topDivider = new MaterialSkin.Controls.MaterialDivider();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bottomDivider
            // 
            this.bottomDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bottomDivider.Depth = 0;
            this.bottomDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomDivider.Location = new System.Drawing.Point(0, 149);
            this.bottomDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.bottomDivider.Name = "bottomDivider";
            this.bottomDivider.Size = new System.Drawing.Size(150, 1);
            this.bottomDivider.TabIndex = 0;
            this.bottomDivider.Text = "materialDivider1";
            // 
            // leftDivider
            // 
            this.leftDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.leftDivider.Depth = 0;
            this.leftDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftDivider.Location = new System.Drawing.Point(0, 0);
            this.leftDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.leftDivider.Name = "leftDivider";
            this.leftDivider.Size = new System.Drawing.Size(1, 149);
            this.leftDivider.TabIndex = 1;
            this.leftDivider.Text = "materialDivider2";
            // 
            // rightDivider
            // 
            this.rightDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightDivider.Depth = 0;
            this.rightDivider.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightDivider.Location = new System.Drawing.Point(149, 0);
            this.rightDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightDivider.Name = "rightDivider";
            this.rightDivider.Size = new System.Drawing.Size(1, 149);
            this.rightDivider.TabIndex = 2;
            this.rightDivider.Text = "materialDivider3";
            // 
            // topDivider
            // 
            this.topDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topDivider.Depth = 0;
            this.topDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.topDivider.Location = new System.Drawing.Point(1, 0);
            this.topDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.topDivider.Name = "topDivider";
            this.topDivider.Size = new System.Drawing.Size(148, 1);
            this.topDivider.TabIndex = 3;
            this.topDivider.Text = "materialDivider4";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(1, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(148, 148);
            this.mainPanel.TabIndex = 4;
            // 
            // MaterialPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topDivider);
            this.Controls.Add(this.rightDivider);
            this.Controls.Add(this.leftDivider);
            this.Controls.Add(this.bottomDivider);
            this.Name = "MaterialPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider bottomDivider;
        private MaterialSkin.Controls.MaterialDivider leftDivider;
        private MaterialSkin.Controls.MaterialDivider rightDivider;
        private MaterialSkin.Controls.MaterialDivider topDivider;
        private System.Windows.Forms.Panel mainPanel;
    }
}
