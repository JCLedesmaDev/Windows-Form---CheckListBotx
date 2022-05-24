namespace CheckListBotx
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textAddCheck = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowCheck = new System.Windows.Forms.Button();
            this.deleteCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique su estado civil";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Solo solin solito",
            "Casado",
            "Con correa",
            "Enchongado"});
            this.checkedListBox1.Location = new System.Drawing.Point(57, 83);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(170, 89);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.getIndexCheckSelected);
            // 
            // textAddCheck
            // 
            this.textAddCheck.Location = new System.Drawing.Point(239, 121);
            this.textAddCheck.Name = "textAddCheck";
            this.textAddCheck.Size = new System.Drawing.Size(124, 22);
            this.textAddCheck.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar opcion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddOption);
            // 
            // ShowCheck
            // 
            this.ShowCheck.Location = new System.Drawing.Point(66, 188);
            this.ShowCheck.Name = "ShowCheck";
            this.ShowCheck.Size = new System.Drawing.Size(75, 48);
            this.ShowCheck.TabIndex = 4;
            this.ShowCheck.Text = "Mostrar opciones";
            this.ShowCheck.UseVisualStyleBackColor = true;
            this.ShowCheck.Click += new System.EventHandler(this.ShowCheck_Click);
            // 
            // deleteCheck
            // 
            this.deleteCheck.Location = new System.Drawing.Point(152, 188);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(75, 48);
            this.deleteCheck.TabIndex = 5;
            this.deleteCheck.Text = "Eliminar opcion";
            this.deleteCheck.UseVisualStyleBackColor = true;
            this.deleteCheck.Click += new System.EventHandler(this.deleteCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Insertar opcion";
           // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.ShowCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAddCheck);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textAddCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowCheck;
        private System.Windows.Forms.Button deleteCheck;
        private System.Windows.Forms.Label label2;
    }
}

