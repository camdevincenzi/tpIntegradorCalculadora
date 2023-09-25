namespace MiCalculadora
{
    partial class FrmCalculadora
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
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblPrimerOperador = new Label();
            txtPrimerOperador = new TextBox();
            lblOperacion = new Label();
            cmbOperacion = new ComboBox();
            lblSegundoOperador = new Label();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblResult = new Label();
            lblResFinal = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(170, 121);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(173, 69);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            grpSistema.Enter += grpSistema_Enter;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(98, 35);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(15, 35);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(23, 212);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 2;
            lblPrimerOperador.Text = "Primer operador:";
            lblPrimerOperador.Click += lblPrimerOperador_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(23, 249);
            txtPrimerOperador.Multiline = true;
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(158, 29);
            txtPrimerOperador.TabIndex = 3;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(216, 212);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(105, 25);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            lblOperacion.Click += lblOperacion_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(205, 249);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(138, 29);
            cmbOperacion.TabIndex = 5;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(359, 212);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(176, 25);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo operador:";
            lblSegundoOperador.Click += lblSegundoOperador_Click;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(368, 249);
            txtSegundoOperador.Multiline = true;
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(158, 29);
            txtSegundoOperador.TabIndex = 7;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.ControlLightLight;
            btnOperar.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnOperar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnOperar.FlatStyle = FlatStyle.Flat;
            btnOperar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(23, 300);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(158, 34);
            btnOperar.TabIndex = 8;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlLightLight;
            btnLimpiar.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnLimpiar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(199, 300);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 34);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ControlLightLight;
            btnCerrar.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            btnCerrar.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ControlText;
            btnCerrar.Location = new Point(368, 300);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(158, 34);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(23, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(167, 45);
            lblResult.TabIndex = 11;
            lblResult.Text = "Resultado:";
            lblResult.Click += lblResult_Click;
            // 
            // lblResFinal
            // 
            lblResFinal.AutoSize = true;
            lblResFinal.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResFinal.ForeColor = Color.FromArgb(192, 0, 192);
            lblResFinal.Location = new Point(185, 44);
            lblResFinal.Name = "lblResFinal";
            lblResFinal.Size = new Size(0, 40);
            lblResFinal.TabIndex = 12;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(551, 357);
            Controls.Add(lblResFinal);
            Controls.Add(lblResult);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(cmbOperacion);
            Controls.Add(lblOperacion);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(grpSistema);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Camila Devincenzi";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpSistema;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private Label lblPrimerOperador;
        private TextBox txtPrimerOperador;
        private Label lblOperacion;
        private ComboBox cmbOperacion;
        private Label lblSegundoOperador;
        private TextBox txtSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblResult;
        private Label lblResFinal;
    }
}