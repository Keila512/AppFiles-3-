namespace AppFiles_3_
{
    partial class Form1
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
            this.btnSequential = new System.Windows.Forms.Button();
            this.btnDirect = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSequential
            // 
            this.btnSequential.Location = new System.Drawing.Point(332, 41);
            this.btnSequential.Name = "btnSequential";
            this.btnSequential.Size = new System.Drawing.Size(107, 23);
            this.btnSequential.TabIndex = 0;
            this.btnSequential.Text = "SEQUENTIAL";
            this.btnSequential.UseVisualStyleBackColor = true;
            this.btnSequential.Click += new System.EventHandler(this.btnSequential_Click);
            // 
            // btnDirect
            // 
            this.btnDirect.Location = new System.Drawing.Point(640, 41);
            this.btnDirect.Name = "btnDirect";
            this.btnDirect.Size = new System.Drawing.Size(75, 23);
            this.btnDirect.TabIndex = 1;
            this.btnDirect.Text = "DIRECT";
            this.btnDirect.UseVisualStyleBackColor = true;
            this.btnDirect.Click += new System.EventHandler(this.btnDirect_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(500, 41);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 2;
            this.btnIndex.Text = "INDEX";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(30, 41);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(30, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(721, 276);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnDirect);
            this.Controls.Add(this.btnSequential);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSequential;
        private System.Windows.Forms.Button btnDirect;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox listBox1;
    }
}

