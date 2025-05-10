namespace AppiPokemon
{
    partial class Form1
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
            IBLNombre = new Label();
            IBLPeso = new Label();
            IBLAltura = new Label();
            IBLTipo = new Label();
            btBuscar = new Button();
            btLB = new Button();
            bttxt = new Button();
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            btAG = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IBLNombre
            // 
            IBLNombre.AutoSize = true;
            IBLNombre.BackColor = SystemColors.ActiveCaption;
            IBLNombre.BorderStyle = BorderStyle.FixedSingle;
            IBLNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBLNombre.Location = new Point(67, 51);
            IBLNombre.Name = "IBLNombre";
            IBLNombre.Size = new Size(69, 22);
            IBLNombre.TabIndex = 0;
            IBLNombre.Text = "Nombre";
            // 
            // IBLPeso
            // 
            IBLPeso.AutoSize = true;
            IBLPeso.BackColor = SystemColors.ActiveCaption;
            IBLPeso.BorderStyle = BorderStyle.FixedSingle;
            IBLPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBLPeso.Location = new Point(67, 146);
            IBLPeso.Name = "IBLPeso";
            IBLPeso.Size = new Size(44, 22);
            IBLPeso.TabIndex = 1;
            IBLPeso.Text = "Peso";
            // 
            // IBLAltura
            // 
            IBLAltura.AutoSize = true;
            IBLAltura.BackColor = SystemColors.ActiveCaption;
            IBLAltura.BorderStyle = BorderStyle.FixedSingle;
            IBLAltura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBLAltura.Location = new Point(67, 230);
            IBLAltura.Name = "IBLAltura";
            IBLAltura.Size = new Size(55, 22);
            IBLAltura.TabIndex = 2;
            IBLAltura.Text = "Altura";
            // 
            // IBLTipo
            // 
            IBLTipo.AutoSize = true;
            IBLTipo.BackColor = SystemColors.ActiveCaption;
            IBLTipo.BorderStyle = BorderStyle.FixedSingle;
            IBLTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBLTipo.Location = new Point(67, 312);
            IBLTipo.Name = "IBLTipo";
            IBLTipo.Size = new Size(42, 22);
            IBLTipo.TabIndex = 3;
            IBLTipo.Text = "Tipo";
            // 
            // btBuscar
            // 
            btBuscar.BackColor = SystemColors.Highlight;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscar.Location = new Point(67, 379);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 59);
            btBuscar.TabIndex = 4;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // btLB
            // 
            btLB.BackColor = SystemColors.Highlight;
            btLB.FlatStyle = FlatStyle.Flat;
            btLB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLB.Location = new Point(193, 379);
            btLB.Name = "btLB";
            btLB.Size = new Size(157, 59);
            btLB.TabIndex = 5;
            btLB.Text = "Limpiar Busquedad";
            btLB.UseVisualStyleBackColor = false;
            btLB.Click += btLB_Click;
            // 
            // bttxt
            // 
            bttxt.BackColor = SystemColors.Highlight;
            bttxt.FlatStyle = FlatStyle.Flat;
            bttxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttxt.Location = new Point(378, 379);
            bttxt.Name = "bttxt";
            bttxt.Size = new Size(173, 59);
            bttxt.TabIndex = 6;
            bttxt.Text = "Guardar en archivo txt";
            bttxt.UseVisualStyleBackColor = false;
            bttxt.Click += bttxt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(509, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 292);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(193, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 8;
            // 
            // btAG
            // 
            btAG.BackColor = Color.RosyBrown;
            btAG.FlatStyle = FlatStyle.Flat;
            btAG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAG.Location = new Point(602, 379);
            btAG.Name = "btAG";
            btAG.Size = new Size(134, 53);
            btAG.TabIndex = 9;
            btAG.Text = "Appi gatos";
            btAG.UseVisualStyleBackColor = false;
            btAG.Click += btAG_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btAG);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(bttxt);
            Controls.Add(btLB);
            Controls.Add(btBuscar);
            Controls.Add(IBLTipo);
            Controls.Add(IBLAltura);
            Controls.Add(IBLPeso);
            Controls.Add(IBLNombre);
            Name = "Form1";
            Text = "Pokemon";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IBLNombre;
        private Label IBLPeso;
        private Label IBLAltura;
        private Label IBLTipo;
        private Button btBuscar;
        private Button btLB;
        private Button bttxt;
        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private Button btAG;
    }
}
