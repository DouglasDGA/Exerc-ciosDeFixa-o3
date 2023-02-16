
namespace ExercíciosDeFixação3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.TpPrincipal = new System.Windows.Forms.TabPage();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLeitura = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lboPessoas = new System.Windows.Forms.ListBox();
            this.TbErros = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnErro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblErro = new System.Windows.Forms.Label();
            this.tbPrincipal.SuspendLayout();
            this.TpPrincipal.SuspendLayout();
            this.TbErros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.TpPrincipal);
            this.tbPrincipal.Controls.Add(this.TbErros);
            this.tbPrincipal.Depth = 0;
            this.tbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(537, 450);
            this.tbPrincipal.TabIndex = 20;
            // 
            // TpPrincipal
            // 
            this.TpPrincipal.BackColor = System.Drawing.Color.Cyan;
            this.TpPrincipal.Controls.Add(this.btnAdd);
            this.TpPrincipal.Controls.Add(this.btnRem);
            this.TpPrincipal.Controls.Add(this.btnEdit);
            this.TpPrincipal.Controls.Add(this.btnLeitura);
            this.TpPrincipal.Controls.Add(this.btnExcluir);
            this.TpPrincipal.Controls.Add(this.materialFlatButton2);
            this.TpPrincipal.Controls.Add(this.txtEmail);
            this.TpPrincipal.Controls.Add(this.materialLabel6);
            this.TpPrincipal.Controls.Add(this.txtTelefone);
            this.TpPrincipal.Controls.Add(this.materialLabel7);
            this.TpPrincipal.Controls.Add(this.materialLabel8);
            this.TpPrincipal.Controls.Add(this.dtNascimento);
            this.TpPrincipal.Controls.Add(this.txtSobrenome);
            this.TpPrincipal.Controls.Add(this.txtNome);
            this.TpPrincipal.Controls.Add(this.materialLabel9);
            this.TpPrincipal.Controls.Add(this.materialLabel10);
            this.TpPrincipal.Controls.Add(this.lboPessoas);
            this.TpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.TpPrincipal.Name = "TpPrincipal";
            this.TpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.TpPrincipal.Size = new System.Drawing.Size(529, 424);
            this.TpPrincipal.TabIndex = 0;
            this.TpPrincipal.Text = "TbPrincipal";
            // 
            // btnAdd
            // 
            this.btnAdd.Depth = 0;
            this.btnAdd.Location = new System.Drawing.Point(287, 355);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRem
            // 
            this.btnRem.Depth = 0;
            this.btnRem.Location = new System.Drawing.Point(145, 355);
            this.btnRem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRem.Name = "btnRem";
            this.btnRem.Primary = true;
            this.btnRem.Size = new System.Drawing.Size(123, 36);
            this.btnRem.TabIndex = 37;
            this.btnRem.Text = "Remover Dados";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Depth = 0;
            this.btnEdit.Location = new System.Drawing.Point(449, 355);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = true;
            this.btnEdit.Size = new System.Drawing.Size(59, 36);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLeitura
            // 
            this.btnLeitura.Depth = 0;
            this.btnLeitura.Location = new System.Drawing.Point(20, 355);
            this.btnLeitura.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Primary = true;
            this.btnLeitura.Size = new System.Drawing.Size(112, 36);
            this.btnLeitura.TabIndex = 35;
            this.btnLeitura.Text = "Inserir Dados";
            this.btnLeitura.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(377, 355);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(66, 36);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(20, 355);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(111, 36);
            this.materialFlatButton2.TabIndex = 32;
            this.materialFlatButton2.Text = "Inserir Dados";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(286, 327);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 30;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(283, 305);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 29;
            this.materialLabel6.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(286, 263);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(222, 20);
            this.txtTelefone.TabIndex = 28;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(283, 241);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(68, 19);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Telefone";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(283, 177);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(146, 19);
            this.materialLabel8.TabIndex = 26;
            this.materialLabel8.Text = "Data de Nascimento";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(286, 199);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(222, 20);
            this.dtNascimento.TabIndex = 25;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(287, 135);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(221, 20);
            this.txtSobrenome.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(287, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 23;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(283, 113);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Sobrenome";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(283, 49);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "Nome";
            // 
            // lboPessoas
            // 
            this.lboPessoas.FormattingEnabled = true;
            this.lboPessoas.Location = new System.Drawing.Point(20, 49);
            this.lboPessoas.Name = "lboPessoas";
            this.lboPessoas.Size = new System.Drawing.Size(248, 303);
            this.lboPessoas.TabIndex = 18;
            this.lboPessoas.SelectedIndexChanged += new System.EventHandler(this.lboPessoas_SelectedIndexChanged);
            // 
            // TbErros
            // 
            this.TbErros.BackColor = System.Drawing.Color.Cyan;
            this.TbErros.Controls.Add(this.tableLayoutPanel1);
            this.TbErros.Location = new System.Drawing.Point(4, 22);
            this.TbErros.Name = "TbErros";
            this.TbErros.Padding = new System.Windows.Forms.Padding(3);
            this.TbErros.Size = new System.Drawing.Size(529, 424);
            this.TbErros.TabIndex = 1;
            this.TbErros.Text = "TbErro";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnErro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblErro, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.42529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.57471F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnErro
            // 
            this.btnErro.Depth = 0;
            this.btnErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErro.Location = new System.Drawing.Point(3, 293);
            this.btnErro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnErro.Name = "btnErro";
            this.btnErro.Primary = true;
            this.btnErro.Size = new System.Drawing.Size(517, 122);
            this.btnErro.TabIndex = 0;
            this.btnErro.Text = "Ok";
            this.btnErro.UseVisualStyleBackColor = true;
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(3, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 55);
            this.lblErro.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.tbPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbPrincipal.ResumeLayout(false);
            this.TpPrincipal.ResumeLayout(false);
            this.TpPrincipal.PerformLayout();
            this.TbErros.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbPrincipal;
        private System.Windows.Forms.TabPage TpPrincipal;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnRem;
        private MaterialSkin.Controls.MaterialRaisedButton btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnLeitura;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.TextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox txtTelefone;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.ListBox lboPessoas;
        private System.Windows.Forms.TabPage TbErros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnErro;
        private System.Windows.Forms.Label lblErro;
    }
}

