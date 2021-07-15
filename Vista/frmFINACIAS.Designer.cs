
namespace Vista
{
    partial class frmFINACIAS
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
            this.gbxBOTONES = new System.Windows.Forms.GroupBox();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.gbxDATOS = new System.Windows.Forms.GroupBox();
            this.nudIMPORTE = new System.Windows.Forms.NumericUpDown();
            this.lblLUGAR = new System.Windows.Forms.Label();
            this.lblHECHO = new System.Windows.Forms.Label();
            this.lblVENCIMIENTO = new System.Windows.Forms.Label();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.lblINGRESO = new System.Windows.Forms.Label();
            this.cbxPENDIENTE = new System.Windows.Forms.CheckBox();
            this.dtpVENCIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.dtpINGRESO = new System.Windows.Forms.DateTimePicker();
            this.tbxNOMBRE = new System.Windows.Forms.TextBox();
            this.dgwLISTAFINANCIAS = new System.Windows.Forms.DataGridView();
            this.gbxBOTONES.SuspendLayout();
            this.gbxDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIMPORTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLISTAFINANCIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBOTONES
            // 
            this.gbxBOTONES.Controls.Add(this.btnGUARDAR);
            this.gbxBOTONES.Controls.Add(this.btnSALIR);
            this.gbxBOTONES.Controls.Add(this.btnELIMINAR);
            this.gbxBOTONES.Controls.Add(this.btnMODIFICAR);
            this.gbxBOTONES.Location = new System.Drawing.Point(644, 12);
            this.gbxBOTONES.Name = "gbxBOTONES";
            this.gbxBOTONES.Size = new System.Drawing.Size(144, 438);
            this.gbxBOTONES.TabIndex = 2;
            this.gbxBOTONES.TabStop = false;
            this.gbxBOTONES.Text = "Acciones";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(12, 17);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(130, 80);
            this.btnGUARDAR.TabIndex = 10;
            this.btnGUARDAR.Text = "Agregar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click_1);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(12, 273);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(130, 80);
            this.btnSALIR.TabIndex = 3;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(12, 187);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(130, 80);
            this.btnELIMINAR.TabIndex = 2;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click_1);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(12, 103);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(130, 80);
            this.btnMODIFICAR.TabIndex = 1;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click_1);
            // 
            // gbxDATOS
            // 
            this.gbxDATOS.Controls.Add(this.nudIMPORTE);
            this.gbxDATOS.Controls.Add(this.lblLUGAR);
            this.gbxDATOS.Controls.Add(this.lblHECHO);
            this.gbxDATOS.Controls.Add(this.lblVENCIMIENTO);
            this.gbxDATOS.Controls.Add(this.lblNOMBRE);
            this.gbxDATOS.Controls.Add(this.lblINGRESO);
            this.gbxDATOS.Controls.Add(this.cbxPENDIENTE);
            this.gbxDATOS.Controls.Add(this.dtpVENCIMIENTO);
            this.gbxDATOS.Controls.Add(this.dtpINGRESO);
            this.gbxDATOS.Controls.Add(this.tbxNOMBRE);
            this.gbxDATOS.Location = new System.Drawing.Point(393, 12);
            this.gbxDATOS.Name = "gbxDATOS";
            this.gbxDATOS.Size = new System.Drawing.Size(245, 438);
            this.gbxDATOS.TabIndex = 11;
            this.gbxDATOS.TabStop = false;
            this.gbxDATOS.Text = "Datos";
            // 
            // nudIMPORTE
            // 
            this.nudIMPORTE.Location = new System.Drawing.Point(119, 281);
            this.nudIMPORTE.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudIMPORTE.Name = "nudIMPORTE";
            this.nudIMPORTE.Size = new System.Drawing.Size(120, 20);
            this.nudIMPORTE.TabIndex = 11;
            // 
            // lblLUGAR
            // 
            this.lblLUGAR.AutoSize = true;
            this.lblLUGAR.Location = new System.Drawing.Point(6, 283);
            this.lblLUGAR.Name = "lblLUGAR";
            this.lblLUGAR.Size = new System.Drawing.Size(42, 13);
            this.lblLUGAR.TabIndex = 9;
            this.lblLUGAR.Text = "Importe";
            // 
            // lblHECHO
            // 
            this.lblHECHO.AutoSize = true;
            this.lblHECHO.Location = new System.Drawing.Point(9, 220);
            this.lblHECHO.Name = "lblHECHO";
            this.lblHECHO.Size = new System.Drawing.Size(75, 13);
            this.lblHECHO.TabIndex = 8;
            this.lblHECHO.Text = "¿Esta Hecho?";
            // 
            // lblVENCIMIENTO
            // 
            this.lblVENCIMIENTO.AutoSize = true;
            this.lblVENCIMIENTO.Location = new System.Drawing.Point(4, 166);
            this.lblVENCIMIENTO.Name = "lblVENCIMIENTO";
            this.lblVENCIMIENTO.Size = new System.Drawing.Size(110, 13);
            this.lblVENCIMIENTO.TabIndex = 7;
            this.lblVENCIMIENTO.Text = "Fecha deVencimiento";
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Location = new System.Drawing.Point(6, 103);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(98, 13);
            this.lblNOMBRE.TabIndex = 6;
            this.lblNOMBRE.Text = "Nombre del Evento";
            // 
            // lblINGRESO
            // 
            this.lblINGRESO.AutoSize = true;
            this.lblINGRESO.Location = new System.Drawing.Point(6, 46);
            this.lblINGRESO.Name = "lblINGRESO";
            this.lblINGRESO.Size = new System.Drawing.Size(90, 13);
            this.lblINGRESO.TabIndex = 5;
            this.lblINGRESO.Text = "Fecha de Ingreso";
            // 
            // cbxPENDIENTE
            // 
            this.cbxPENDIENTE.AutoSize = true;
            this.cbxPENDIENTE.Location = new System.Drawing.Point(165, 220);
            this.cbxPENDIENTE.Name = "cbxPENDIENTE";
            this.cbxPENDIENTE.Size = new System.Drawing.Size(15, 14);
            this.cbxPENDIENTE.TabIndex = 3;
            this.cbxPENDIENTE.UseVisualStyleBackColor = true;
            // 
            // dtpVENCIMIENTO
            // 
            this.dtpVENCIMIENTO.Location = new System.Drawing.Point(120, 160);
            this.dtpVENCIMIENTO.Name = "dtpVENCIMIENTO";
            this.dtpVENCIMIENTO.Size = new System.Drawing.Size(114, 20);
            this.dtpVENCIMIENTO.TabIndex = 2;
            // 
            // dtpINGRESO
            // 
            this.dtpINGRESO.Location = new System.Drawing.Point(120, 40);
            this.dtpINGRESO.Name = "dtpINGRESO";
            this.dtpINGRESO.Size = new System.Drawing.Size(114, 20);
            this.dtpINGRESO.TabIndex = 1;
            // 
            // tbxNOMBRE
            // 
            this.tbxNOMBRE.Location = new System.Drawing.Point(120, 100);
            this.tbxNOMBRE.Name = "tbxNOMBRE";
            this.tbxNOMBRE.Size = new System.Drawing.Size(114, 20);
            this.tbxNOMBRE.TabIndex = 0;
            // 
            // dgwLISTAFINANCIAS
            // 
            this.dgwLISTAFINANCIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLISTAFINANCIAS.Location = new System.Drawing.Point(12, 12);
            this.dgwLISTAFINANCIAS.Name = "dgwLISTAFINANCIAS";
            this.dgwLISTAFINANCIAS.Size = new System.Drawing.Size(374, 425);
            this.dgwLISTAFINANCIAS.TabIndex = 10;
            // 
            // frmFINACIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwLISTAFINANCIAS);
            this.Controls.Add(this.gbxDATOS);
            this.Controls.Add(this.gbxBOTONES);
            this.Name = "frmFINACIAS";
            this.Text = "frmFINACIAS";
            this.gbxBOTONES.ResumeLayout(false);
            this.gbxDATOS.ResumeLayout(false);
            this.gbxDATOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIMPORTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLISTAFINANCIAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBOTONES;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.GroupBox gbxDATOS;
        private System.Windows.Forms.Label lblLUGAR;
        private System.Windows.Forms.Label lblHECHO;
        private System.Windows.Forms.Label lblVENCIMIENTO;
        private System.Windows.Forms.Label lblNOMBRE;
        private System.Windows.Forms.Label lblINGRESO;
        private System.Windows.Forms.CheckBox cbxPENDIENTE;
        private System.Windows.Forms.DateTimePicker dtpVENCIMIENTO;
        private System.Windows.Forms.DateTimePicker dtpINGRESO;
        private System.Windows.Forms.TextBox tbxNOMBRE;
        private System.Windows.Forms.DataGridView dgwLISTAFINANCIAS;
        private System.Windows.Forms.NumericUpDown nudIMPORTE;
    }
}