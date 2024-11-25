namespace DemoConcurrencia
{
    partial class frmpedido
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
            splitContainer1 = new SplitContainer();
            lblContadorpedido = new Label();
            btnDisminuirpedido = new Button();
            btnPedir = new Button();
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
            splitContainer1.Panel1.Controls.Add(lblContadorpedido);
            splitContainer1.Panel1.Controls.Add(btnDisminuirpedido);
            splitContainer1.Panel1.Controls.Add(btnPedir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtResultado);
            splitContainer1.Size = new Size(390, 291);
            splitContainer1.SplitterDistance = 130;
            splitContainer1.TabIndex = 0;
            // 
            // lblContadorpedido
            // 
            lblContadorpedido.AutoSize = true;
            lblContadorpedido.Location = new Point(37, 125);
            lblContadorpedido.Name = "lblContadorpedido";
            lblContadorpedido.Size = new Size(13, 15);
            lblContadorpedido.TabIndex = 4;
            lblContadorpedido.Text = "0";
            // 
            // btnDisminuirpedido
            // 
            btnDisminuirpedido.Location = new Point(12, 56);
            btnDisminuirpedido.Name = "btnDisminuirpedido";
            btnDisminuirpedido.Size = new Size(90, 42);
            btnDisminuirpedido.TabIndex = 3;
            btnDisminuirpedido.Text = "Disminuir Pedido";
            btnDisminuirpedido.UseVisualStyleBackColor = true;
            btnDisminuirpedido.Click += btnDisminuirpedido_Click;
            // 
            // btnPedir
            // 
            btnPedir.Location = new Point(12, 12);
            btnPedir.Name = "btnPedir";
            btnPedir.Size = new Size(75, 23);
            btnPedir.TabIndex = 1;
            btnPedir.Text = "Pedir";
            btnPedir.UseVisualStyleBackColor = true;
            btnPedir.Click += btnPedir_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(224, 224, 224);
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(256, 291);
            txtResultado.TabIndex = 2;
            // 
            // frmpedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 291);
            Controls.Add(splitContainer1);
            Name = "frmpedido";
            Text = "Control de pedido";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtResultado;
        private Button btnPedir;
        private Button btnDisminuirpedido;
        private Label lblContadorpedido;
    }
}