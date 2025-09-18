namespace CRUD
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            btnSalvar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            localizar = new Label();
            button1 = new Button();
            listView1 = new ListView();
            btnAtualizar = new Button();
            label4 = new Label();
            txtID = new TextBox();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(36, 362);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 31);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 101);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 3;
            label2.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(50, 136);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 179);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 6;
            label3.Text = "E-mail:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 7;
            // 
            // localizar
            // 
            localizar.AutoSize = true;
            localizar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            localizar.Location = new Point(298, 22);
            localizar.Name = "localizar";
            localizar.Size = new Size(115, 32);
            localizar.TabIndex = 8;
            localizar.Text = "Localizar";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(620, 57);
            button1.Name = "button1";
            button1.Size = new Size(152, 58);
            button1.TabIndex = 9;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(298, 136);
            listView1.Name = "listView1";
            listView1.Size = new Size(462, 175);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(36, 399);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(104, 31);
            btnAtualizar.TabIndex = 11;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 257);
            label4.Name = "label4";
            label4.Size = new Size(47, 32);
            label4.TabIndex = 12;
            label4.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(50, 292);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 13;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(157, 378);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(104, 31);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletar);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(btnAtualizar);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(localizar);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label3;
        private TextBox textBox1;
        private Label localizar;
        private Button button1;
        private ListView listView1;
        private Button btnAtualizar;
        private Label label4;
        private TextBox txtID;
        private Button btnDeletar;
    }
}
