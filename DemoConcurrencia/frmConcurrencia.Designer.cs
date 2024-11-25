namespace DemoConcurrencia
{
    partial class frmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnCancelarHilo = new Button();
            btnIniciartarea = new Button();
            btnIniciarHilo = new Button();
            btnSecuencial = new Button();
            txtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(192, 255, 255);
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciartarea);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(472, 340);
            splitContainer1.SplitterDistance = 156;
            splitContainer1.TabIndex = 1;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarHilo.Location = new Point(14, 141);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(117, 37);
            btnCancelarHilo.TabIndex = 4;
            btnCancelarHilo.Text = "Cancelar Proceso";
            btnCancelarHilo.UseVisualStyleBackColor = true;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // btnIniciartarea
            // 
            btnIniciartarea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciartarea.Location = new Point(14, 98);
            btnIniciartarea.Name = "btnIniciartarea";
            btnIniciartarea.Size = new Size(117, 37);
            btnIniciartarea.TabIndex = 3;
            btnIniciartarea.Text = "Iniciar Tarea";
            btnIniciartarea.UseVisualStyleBackColor = true;
            btnIniciartarea.Click += btnIniciartarea_Click;
            // 
            // btnIniciarHilo
            // 
            btnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciarHilo.Location = new Point(14, 56);
            btnIniciarHilo.Name = "btnIniciarHilo";
            btnIniciarHilo.Size = new Size(117, 36);
            btnIniciarHilo.TabIndex = 2;
            btnIniciarHilo.Text = "Iniciar Hilo";
            btnIniciarHilo.UseVisualStyleBackColor = true;
            btnIniciarHilo.Click += btnIniciarHilo_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSecuencial.Location = new Point(14, 6);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(117, 44);
            btnSecuencial.TabIndex = 1;
            btnSecuencial.Text = "Iniciar Sencuencial";
            btnSecuencial.UseVisualStyleBackColor = true;
            btnSecuencial.Click += btnSecuencial_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.InactiveBorder;
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(312, 340);
            txtResultado.TabIndex = 0;
            // 
            // frmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 340);
            Controls.Add(splitContainer1);
            Name = "frmConcurrencia";
            Text = "Demostración de concurrencia";
            Load += frmConcurrencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciartarea;
        private Button btnIniciarHilo;
        private Button btnSecuencial;
        private TextBox txtResultado;
        private Button btnCancelarHilo;
    }
}
