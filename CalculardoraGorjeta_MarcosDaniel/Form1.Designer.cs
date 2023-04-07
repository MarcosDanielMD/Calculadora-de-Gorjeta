namespace CalculardoraGorjeta_MarcosDaniel
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
            Label labelHamburguer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxEntrada = new GroupBox();
            labelPessoas = new Label();
            labelGorjeta = new Label();
            buttonReset = new Button();
            textBoxValorConta = new TextBox();
            radioButton50 = new RadioButton();
            radioButton40 = new RadioButton();
            radioButton30 = new RadioButton();
            label1 = new Label();
            numericUpDownPessoas = new NumericUpDown();
            buttonCalcular = new Button();
            checkBoxDividirConta = new CheckBox();
            checkBoxTaxaServico = new CheckBox();
            radioButton20 = new RadioButton();
            radioButton15 = new RadioButton();
            radioButton10 = new RadioButton();
            labelValorGorjeta = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            groupBoxFeijoada = new GroupBox();
            buttonFeijoada = new Button();
            labelQuantidade = new Label();
            labelFeijoada = new Label();
            numericUpDownFeijoada = new NumericUpDown();
            groupBoxHamburguer = new GroupBox();
            buttonComprarHb = new Button();
            labelQuantHamb = new Label();
            numericUpDownHamburguer = new NumericUpDown();
            groupBoxBoloChoco = new GroupBox();
            buttonBolo = new Button();
            labelQuantBolo = new Label();
            numericUpDownBoloChoco = new NumericUpDown();
            labelBoloChoco = new Label();
            label6 = new Label();
            label5 = new Label();
            labelValorTotal = new Label();
            groupBoxTotal = new GroupBox();
            Sair = new Button();
            labelHamburguer = new Label();
            groupBoxEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPessoas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBoxFeijoada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFeijoada).BeginInit();
            groupBoxHamburguer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHamburguer).BeginInit();
            groupBoxBoloChoco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoloChoco).BeginInit();
            groupBoxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // labelHamburguer
            // 
            labelHamburguer.AutoSize = true;
            labelHamburguer.Location = new Point(3, 23);
            labelHamburguer.Name = "labelHamburguer";
            labelHamburguer.Size = new Size(90, 20);
            labelHamburguer.TabIndex = 0;
            labelHamburguer.Text = "Preço: R$ 30";
            // 
            // groupBoxEntrada
            // 
            groupBoxEntrada.Controls.Add(labelPessoas);
            groupBoxEntrada.Controls.Add(labelGorjeta);
            groupBoxEntrada.Controls.Add(buttonReset);
            groupBoxEntrada.Controls.Add(textBoxValorConta);
            groupBoxEntrada.Controls.Add(radioButton50);
            groupBoxEntrada.Controls.Add(radioButton40);
            groupBoxEntrada.Controls.Add(radioButton30);
            groupBoxEntrada.Controls.Add(label1);
            groupBoxEntrada.Controls.Add(numericUpDownPessoas);
            groupBoxEntrada.Controls.Add(buttonCalcular);
            groupBoxEntrada.Controls.Add(checkBoxDividirConta);
            groupBoxEntrada.Controls.Add(checkBoxTaxaServico);
            groupBoxEntrada.Controls.Add(radioButton20);
            groupBoxEntrada.Controls.Add(radioButton15);
            groupBoxEntrada.Controls.Add(radioButton10);
            groupBoxEntrada.Controls.Add(labelValorGorjeta);
            groupBoxEntrada.Location = new Point(133, 336);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Size = new Size(352, 276);
            groupBoxEntrada.TabIndex = 0;
            groupBoxEntrada.TabStop = false;
            // 
            // labelPessoas
            // 
            labelPessoas.AutoSize = true;
            labelPessoas.Location = new Point(64, 212);
            labelPessoas.Name = "labelPessoas";
            labelPessoas.Size = new Size(59, 20);
            labelPessoas.TabIndex = 11;
            labelPessoas.Text = "Pessoas";
            labelPessoas.Visible = false;
            // 
            // labelGorjeta
            // 
            labelGorjeta.AutoSize = true;
            labelGorjeta.Location = new Point(6, 76);
            labelGorjeta.Name = "labelGorjeta";
            labelGorjeta.Size = new Size(119, 20);
            labelGorjeta.TabIndex = 8;
            labelGorjeta.Text = "Valor da gorjeta:";
            // 
            // buttonReset
            // 
            buttonReset.ForeColor = Color.Red;
            buttonReset.Location = new Point(129, 235);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 13;
            buttonReset.Text = "Resetar";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // textBoxValorConta
            // 
            textBoxValorConta.Enabled = false;
            textBoxValorConta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxValorConta.Location = new Point(6, 44);
            textBoxValorConta.Name = "textBoxValorConta";
            textBoxValorConta.Size = new Size(125, 31);
            textBoxValorConta.TabIndex = 12;
            // 
            // radioButton50
            // 
            radioButton50.AutoSize = true;
            radioButton50.Location = new Point(129, 122);
            radioButton50.Name = "radioButton50";
            radioButton50.Size = new Size(58, 24);
            radioButton50.TabIndex = 11;
            radioButton50.TabStop = true;
            radioButton50.Text = "50%";
            radioButton50.UseVisualStyleBackColor = true;
            // 
            // radioButton40
            // 
            radioButton40.AutoSize = true;
            radioButton40.Location = new Point(65, 122);
            radioButton40.Name = "radioButton40";
            radioButton40.Size = new Size(58, 24);
            radioButton40.TabIndex = 11;
            radioButton40.TabStop = true;
            radioButton40.Text = "40%";
            radioButton40.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            radioButton30.AutoSize = true;
            radioButton30.Location = new Point(6, 122);
            radioButton30.Name = "radioButton30";
            radioButton30.Size = new Size(58, 24);
            radioButton30.TabIndex = 11;
            radioButton30.TabStop = true;
            radioButton30.Text = "30%";
            radioButton30.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 8;
            label1.Text = "Valor da conta:";
            // 
            // numericUpDownPessoas
            // 
            numericUpDownPessoas.Location = new Point(6, 210);
            numericUpDownPessoas.Name = "numericUpDownPessoas";
            numericUpDownPessoas.Size = new Size(47, 27);
            numericUpDownPessoas.TabIndex = 6;
            numericUpDownPessoas.Visible = false;
            // 
            // buttonCalcular
            // 
            buttonCalcular.ForeColor = Color.DarkCyan;
            buttonCalcular.Location = new Point(240, 235);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(94, 29);
            buttonCalcular.TabIndex = 5;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // checkBoxDividirConta
            // 
            checkBoxDividirConta.AutoSize = true;
            checkBoxDividirConta.Location = new Point(6, 180);
            checkBoxDividirConta.Name = "checkBoxDividirConta";
            checkBoxDividirConta.Size = new Size(123, 24);
            checkBoxDividirConta.TabIndex = 4;
            checkBoxDividirConta.Text = "Dividir conta?";
            checkBoxDividirConta.UseVisualStyleBackColor = true;
            checkBoxDividirConta.CheckedChanged += checkBoxDividirConta_CheckedChanged;
            // 
            // checkBoxTaxaServico
            // 
            checkBoxTaxaServico.AutoSize = true;
            checkBoxTaxaServico.Location = new Point(6, 154);
            checkBoxTaxaServico.Name = "checkBoxTaxaServico";
            checkBoxTaxaServico.Size = new Size(181, 24);
            checkBoxTaxaServico.TabIndex = 3;
            checkBoxTaxaServico.Text = "Incluir taxa de serviço?";
            checkBoxTaxaServico.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            radioButton20.AutoSize = true;
            radioButton20.Location = new Point(129, 96);
            radioButton20.Name = "radioButton20";
            radioButton20.Size = new Size(58, 24);
            radioButton20.TabIndex = 1;
            radioButton20.TabStop = true;
            radioButton20.Text = "20%";
            radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            radioButton15.AutoSize = true;
            radioButton15.Location = new Point(65, 96);
            radioButton15.Name = "radioButton15";
            radioButton15.Size = new Size(58, 24);
            radioButton15.TabIndex = 1;
            radioButton15.TabStop = true;
            radioButton15.Text = "15%";
            radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(6, 96);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(58, 24);
            radioButton10.TabIndex = 1;
            radioButton10.TabStop = true;
            radioButton10.Text = "10%";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // labelValorGorjeta
            // 
            labelValorGorjeta.AutoSize = true;
            labelValorGorjeta.Location = new Point(27, 96);
            labelValorGorjeta.Name = "labelValorGorjeta";
            labelValorGorjeta.Size = new Size(0, 20);
            labelValorGorjeta.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(98, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "Feijoada";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(373, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 1;
            label3.Text = "Hamburguer";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.hamburguer;
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Location = new Point(666, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(221, 173);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, -3);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 1;
            label4.Text = "Bolo de Chocolate";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.bolo_chocolate;
            pictureBox3.Location = new Point(3, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(215, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // groupBoxFeijoada
            // 
            groupBoxFeijoada.Controls.Add(buttonFeijoada);
            groupBoxFeijoada.Controls.Add(labelQuantidade);
            groupBoxFeijoada.Controls.Add(labelFeijoada);
            groupBoxFeijoada.Controls.Add(numericUpDownFeijoada);
            groupBoxFeijoada.Location = new Point(98, 188);
            groupBoxFeijoada.Name = "groupBoxFeijoada";
            groupBoxFeijoada.Size = new Size(221, 129);
            groupBoxFeijoada.TabIndex = 3;
            groupBoxFeijoada.TabStop = false;
            groupBoxFeijoada.Visible = false;
            // 
            // buttonFeijoada
            // 
            buttonFeijoada.ForeColor = Color.LightSeaGreen;
            buttonFeijoada.Location = new Point(6, 79);
            buttonFeijoada.Name = "buttonFeijoada";
            buttonFeijoada.Size = new Size(94, 29);
            buttonFeijoada.TabIndex = 3;
            buttonFeijoada.Text = "Comprar";
            buttonFeijoada.UseVisualStyleBackColor = true;
            buttonFeijoada.Click += buttonFeijoada_Click;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(6, 49);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(90, 20);
            labelQuantidade.TabIndex = 2;
            labelQuantidade.Text = "Quantidade:";
            // 
            // labelFeijoada
            // 
            labelFeijoada.AutoSize = true;
            labelFeijoada.Location = new Point(3, 23);
            labelFeijoada.Name = "labelFeijoada";
            labelFeijoada.Size = new Size(90, 20);
            labelFeijoada.TabIndex = 0;
            labelFeijoada.Text = "Preço: R$ 45";
            // 
            // numericUpDownFeijoada
            // 
            numericUpDownFeijoada.Location = new Point(100, 47);
            numericUpDownFeijoada.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFeijoada.Name = "numericUpDownFeijoada";
            numericUpDownFeijoada.Size = new Size(47, 27);
            numericUpDownFeijoada.TabIndex = 6;
            // 
            // groupBoxHamburguer
            // 
            groupBoxHamburguer.Controls.Add(buttonComprarHb);
            groupBoxHamburguer.Controls.Add(labelQuantHamb);
            groupBoxHamburguer.Controls.Add(numericUpDownHamburguer);
            groupBoxHamburguer.Controls.Add(labelHamburguer);
            groupBoxHamburguer.Location = new Point(376, 188);
            groupBoxHamburguer.Name = "groupBoxHamburguer";
            groupBoxHamburguer.Size = new Size(221, 129);
            groupBoxHamburguer.TabIndex = 4;
            groupBoxHamburguer.TabStop = false;
            groupBoxHamburguer.Visible = false;
            // 
            // buttonComprarHb
            // 
            buttonComprarHb.ForeColor = Color.LightSeaGreen;
            buttonComprarHb.Location = new Point(6, 79);
            buttonComprarHb.Name = "buttonComprarHb";
            buttonComprarHb.Size = new Size(94, 29);
            buttonComprarHb.TabIndex = 3;
            buttonComprarHb.Text = "Comprar";
            buttonComprarHb.UseVisualStyleBackColor = true;
            buttonComprarHb.Click += buttonComprarHb_Click;
            // 
            // labelQuantHamb
            // 
            labelQuantHamb.AutoSize = true;
            labelQuantHamb.Location = new Point(6, 49);
            labelQuantHamb.Name = "labelQuantHamb";
            labelQuantHamb.Size = new Size(90, 20);
            labelQuantHamb.TabIndex = 2;
            labelQuantHamb.Text = "Quantidade:";
            // 
            // numericUpDownHamburguer
            // 
            numericUpDownHamburguer.Location = new Point(102, 47);
            numericUpDownHamburguer.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHamburguer.Name = "numericUpDownHamburguer";
            numericUpDownHamburguer.Size = new Size(47, 27);
            numericUpDownHamburguer.TabIndex = 6;
            // 
            // groupBoxBoloChoco
            // 
            groupBoxBoloChoco.Controls.Add(buttonBolo);
            groupBoxBoloChoco.Controls.Add(labelQuantBolo);
            groupBoxBoloChoco.Controls.Add(numericUpDownBoloChoco);
            groupBoxBoloChoco.Controls.Add(labelBoloChoco);
            groupBoxBoloChoco.Location = new Point(669, 191);
            groupBoxBoloChoco.Name = "groupBoxBoloChoco";
            groupBoxBoloChoco.Size = new Size(221, 129);
            groupBoxBoloChoco.TabIndex = 5;
            groupBoxBoloChoco.TabStop = false;
            groupBoxBoloChoco.Visible = false;
            // 
            // buttonBolo
            // 
            buttonBolo.ForeColor = Color.LightSeaGreen;
            buttonBolo.Location = new Point(6, 79);
            buttonBolo.Name = "buttonBolo";
            buttonBolo.Size = new Size(94, 29);
            buttonBolo.TabIndex = 3;
            buttonBolo.Text = "Comprar";
            buttonBolo.UseVisualStyleBackColor = true;
            buttonBolo.Click += buttonBolo_Click;
            // 
            // labelQuantBolo
            // 
            labelQuantBolo.AutoSize = true;
            labelQuantBolo.Location = new Point(6, 49);
            labelQuantBolo.Name = "labelQuantBolo";
            labelQuantBolo.Size = new Size(90, 20);
            labelQuantBolo.TabIndex = 2;
            labelQuantBolo.Text = "Quantidade:";
            // 
            // numericUpDownBoloChoco
            // 
            numericUpDownBoloChoco.Location = new Point(102, 44);
            numericUpDownBoloChoco.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownBoloChoco.Name = "numericUpDownBoloChoco";
            numericUpDownBoloChoco.Size = new Size(47, 27);
            numericUpDownBoloChoco.TabIndex = 6;
            // 
            // labelBoloChoco
            // 
            labelBoloChoco.AutoSize = true;
            labelBoloChoco.Location = new Point(3, 23);
            labelBoloChoco.Name = "labelBoloChoco";
            labelBoloChoco.Size = new Size(90, 20);
            labelBoloChoco.TabIndex = 0;
            labelBoloChoco.Text = "Preço: R$ 30";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 26);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 8;
            label6.Text = "Valor final da gorjeta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 104);
            label5.Name = "label5";
            label5.Size = new Size(235, 40);
            label5.TabIndex = 8;
            label5.Text = "*Já está dividido pela quantidade \r\nde pessoas selecionadas";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(63, 50);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(0, 28);
            labelValorTotal.TabIndex = 7;
            // 
            // groupBoxTotal
            // 
            groupBoxTotal.Controls.Add(label5);
            groupBoxTotal.Controls.Add(label6);
            groupBoxTotal.Controls.Add(labelValorTotal);
            groupBoxTotal.Location = new Point(612, 412);
            groupBoxTotal.Name = "groupBoxTotal";
            groupBoxTotal.Size = new Size(250, 161);
            groupBoxTotal.TabIndex = 9;
            groupBoxTotal.TabStop = false;
            groupBoxTotal.Visible = false;
            // 
            // Sair
            // 
            Sair.ForeColor = Color.Red;
            Sair.Location = new Point(816, 579);
            Sair.Name = "Sair";
            Sair.Size = new Size(94, 29);
            Sair.TabIndex = 10;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Click += Sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 638);
            Controls.Add(Sair);
            Controls.Add(groupBoxTotal);
            Controls.Add(groupBoxBoloChoco);
            Controls.Add(groupBoxHamburguer);
            Controls.Add(groupBoxFeijoada);
            Controls.Add(groupBoxEntrada);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gorjeta";
            groupBoxEntrada.ResumeLayout(false);
            groupBoxEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPessoas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBoxFeijoada.ResumeLayout(false);
            groupBoxFeijoada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFeijoada).EndInit();
            groupBoxHamburguer.ResumeLayout(false);
            groupBoxHamburguer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHamburguer).EndInit();
            groupBoxBoloChoco.ResumeLayout(false);
            groupBoxBoloChoco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBoloChoco).EndInit();
            groupBoxTotal.ResumeLayout(false);
            groupBoxTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEntrada;
        private CheckBox checkBoxDividirConta;
        private CheckBox checkBoxTaxaServico;
        private RadioButton radioButton20;
        private RadioButton radioButton15;
        private RadioButton radioButton10;
        private Label labelValorGorjeta;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox3;
        private GroupBox groupBoxFeijoada;
        private Button buttonFeijoada;
        private Label labelQuantidade;
        private Label labelFeijoada;
        private GroupBox groupBoxHamburguer;
        private Button buttonComprarHb;
        private Label labelQuantHamb;
        private Label labelHamburguer;
        private GroupBox groupBoxBoloChoco;
        private Button buttonBolo;
        private Label labelQuantBolo;
        private Label labelBoloChoco;
        private Button buttonCalcular;
        private NumericUpDown numericUpDownPessoas;
        private Label label1;
        private TextBox textBoxOV;
        private RadioButton radioButton30;
        private TextBox textBoxValorConta;
        private Button buttonReset;
        private RadioButton radioButton50;
        private RadioButton radioButton40;
        private Label labelGorjeta;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownFeijoada;
        private NumericUpDown numericUpDownHamburguer;
        private NumericUpDown numericUpDownBoloChoco;
        private Label label6;
        private Label label5;
        private Label labelValorTotal;
        private GroupBox groupBoxTotal;
        private Button Sair;
        private Label labelPessoas;
    }
}