﻿namespace USTG_MG.AppWin32
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaridades = new System.Windows.Forms.ToolStripMenuItem();
            this.profissões = new System.Windows.Forms.ToolStripMenuItem();
            this.religiões = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.atividadesExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.Turmas = new System.Windows.Forms.ToolStripMenuItem();
            this.Patentes = new System.Windows.Forms.ToolStripMenuItem();
            this.Contingente = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasEAtrasos = new System.Windows.Forms.ToolStripMenuItem();
            this.justiçaEDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeServiço = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.horasExtras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tAF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripDiversos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.janelas = new System.Windows.Forms.ToolStripMenuItem();
            this.horizonta = new System.Windows.Forms.ToolStripMenuItem();
            this.veritical = new System.Windows.Forms.ToolStripMenuItem();
            this.cascata = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblusuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConfiguracaoTurmaAno = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.atividadesToolStripMenuItem,
            this.toolstripDiversos,
            this.janelas});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.Size = new System.Drawing.Size(586, 25);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolaridades,
            this.profissões,
            this.religiões,
            this.toolStripSeparator2,
            this.atividadesExtras,
            this.Turmas,
            this.Patentes,
            this.Contingente});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(18)))));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // escolaridades
            // 
            this.escolaridades.BackColor = System.Drawing.SystemColors.Control;
            this.escolaridades.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_school_black_36dp;
            this.escolaridades.Name = "escolaridades";
            this.escolaridades.Size = new System.Drawing.Size(167, 22);
            this.escolaridades.Text = "Escolaridades";
            this.escolaridades.Click += new System.EventHandler(this.escolaridades_Click);
            // 
            // profissões
            // 
            this.profissões.BackColor = System.Drawing.SystemColors.Control;
            this.profissões.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_work_black_36dp;
            this.profissões.Name = "profissões";
            this.profissões.Size = new System.Drawing.Size(167, 22);
            this.profissões.Text = "Profissões";
            this.profissões.Click += new System.EventHandler(this.profissões_Click);
            // 
            // religiões
            // 
            this.religiões.BackColor = System.Drawing.SystemColors.Control;
            this.religiões.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_building_41_240;
            this.religiões.Name = "religiões";
            this.religiões.Size = new System.Drawing.Size(167, 22);
            this.religiões.Text = "Religiões";
            this.religiões.Click += new System.EventHandler(this.religiões_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // atividadesExtras
            // 
            this.atividadesExtras.BackColor = System.Drawing.SystemColors.Control;
            this.atividadesExtras.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_task_1_32;
            this.atividadesExtras.Name = "atividadesExtras";
            this.atividadesExtras.Size = new System.Drawing.Size(167, 22);
            this.atividadesExtras.Text = "Atividades Extras";
            this.atividadesExtras.Click += new System.EventHandler(this.atividadesExtras_Click);
            // 
            // Turmas
            // 
            this.Turmas.BackColor = System.Drawing.SystemColors.Control;
            this.Turmas.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_group_black_36dp;
            this.Turmas.Name = "Turmas";
            this.Turmas.Size = new System.Drawing.Size(167, 22);
            this.Turmas.Text = "Turmas";
            this.Turmas.Click += new System.EventHandler(this.Turmas_Click);
            // 
            // Patentes
            // 
            this.Patentes.BackColor = System.Drawing.SystemColors.Control;
            this.Patentes.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_generation_11_32;
            this.Patentes.Name = "Patentes";
            this.Patentes.Size = new System.Drawing.Size(167, 22);
            this.Patentes.Text = "Patentes";
            this.Patentes.Click += new System.EventHandler(this.Patentes_Click);
            // 
            // Contingente
            // 
            this.Contingente.BackColor = System.Drawing.SystemColors.Control;
            this.Contingente.Image = global::USTG_MG.AppWin32.Properties.Resources.users_16x16;
            this.Contingente.Name = "Contingente";
            this.Contingente.Size = new System.Drawing.Size(167, 22);
            this.Contingente.Text = "Contingente";
            this.Contingente.Click += new System.EventHandler(this.Contingente_Click);
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltasEAtrasos,
            this.justiçaEDisciplina,
            this.escalaDeServiço,
            this.toolStripSeparator3,
            this.horasExtras,
            this.toolStripSeparator4,
            this.tAF});
            this.atividadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atividadesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(18)))));
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // faltasEAtrasos
            // 
            this.faltasEAtrasos.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_clipboard_12_32;
            this.faltasEAtrasos.Name = "faltasEAtrasos";
            this.faltasEAtrasos.Size = new System.Drawing.Size(178, 22);
            this.faltasEAtrasos.Text = "Faltas e Atrasos";
            this.faltasEAtrasos.Click += new System.EventHandler(this.faltasEAtrasos_Click);
            // 
            // justiçaEDisciplina
            // 
            this.justiçaEDisciplina.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_gavel_1_32;
            this.justiçaEDisciplina.Name = "justiçaEDisciplina";
            this.justiçaEDisciplina.Size = new System.Drawing.Size(178, 22);
            this.justiçaEDisciplina.Text = "Justiça e Disciplina";
            this.justiçaEDisciplina.Click += new System.EventHandler(this.justiçaEDisciplina_Click);
            // 
            // escalaDeServiço
            // 
            this.escalaDeServiço.Image = global::USTG_MG.AppWin32.Properties.Resources.Military_Man_32;
            this.escalaDeServiço.Name = "escalaDeServiço";
            this.escalaDeServiço.Size = new System.Drawing.Size(178, 22);
            this.escalaDeServiço.Text = "Escala de Serviço";
            this.escalaDeServiço.Click += new System.EventHandler(this.escalaDeServiço_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // horasExtras
            // 
            this.horasExtras.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_access_time_black_36dp;
            this.horasExtras.Name = "horasExtras";
            this.horasExtras.Size = new System.Drawing.Size(178, 22);
            this.horasExtras.Text = "Horas Extras";
            this.horasExtras.Click += new System.EventHandler(this.horasExtras_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // tAF
            // 
            this.tAF.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_clipboard_6_240;
            this.tAF.Name = "tAF";
            this.tAF.Size = new System.Drawing.Size(178, 22);
            this.tAF.Text = "T.A.F";
            this.tAF.Click += new System.EventHandler(this.tAF_Click);
            // 
            // toolstripDiversos
            // 
            this.toolstripDiversos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnConfiguracoes});
            this.toolstripDiversos.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripDiversos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(18)))));
            this.toolstripDiversos.Name = "toolstripDiversos";
            this.toolstripDiversos.Size = new System.Drawing.Size(66, 21);
            this.toolstripDiversos.Text = "Diversos";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_supervised_user_circle_black_36dp;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(154, 22);
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Image = global::USTG_MG.AppWin32.Properties.Resources.iconmonstr_gear_1_32;
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(154, 22);
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // janelas
            // 
            this.janelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizonta,
            this.veritical,
            this.cascata,
            this.toolStripSeparator1,
            this.fecharTodas});
            this.janelas.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.janelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(62)))), ((int)(((byte)(18)))));
            this.janelas.Name = "janelas";
            this.janelas.Size = new System.Drawing.Size(58, 21);
            this.janelas.Text = "Janelas";
            // 
            // horizonta
            // 
            this.horizonta.Name = "horizonta";
            this.horizonta.Size = new System.Drawing.Size(146, 22);
            this.horizonta.Text = "Horizontal";
            this.horizonta.Click += new System.EventHandler(this.horizonta_Click);
            // 
            // veritical
            // 
            this.veritical.Name = "veritical";
            this.veritical.Size = new System.Drawing.Size(146, 22);
            this.veritical.Text = "Veritical";
            this.veritical.Click += new System.EventHandler(this.veritical_Click);
            // 
            // cascata
            // 
            this.cascata.Name = "cascata";
            this.cascata.Size = new System.Drawing.Size(146, 22);
            this.cascata.Text = "Cascata";
            this.cascata.Click += new System.EventHandler(this.cascata_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // fecharTodas
            // 
            this.fecharTodas.Image = global::USTG_MG.AppWin32.Properties.Resources.baseline_cancel_black_36dp;
            this.fecharTodas.Name = "fecharTodas";
            this.fecharTodas.Size = new System.Drawing.Size(146, 22);
            this.fecharTodas.Text = "Fechar Todas";
            this.fecharTodas.Click += new System.EventHandler(this.fecharTodas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblusuarioLogado,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblConfiguracaoTurmaAno});
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(586, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // lblusuarioLogado
            // 
            this.lblusuarioLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblusuarioLogado.Name = "lblusuarioLogado";
            this.lblusuarioLogado.Size = new System.Drawing.Size(20, 17);
            this.lblusuarioLogado.Text = "lbl";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel3.Text = "Turma:";
            // 
            // lblConfiguracaoTurmaAno
            // 
            this.lblConfiguracaoTurmaAno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfiguracaoTurmaAno.Name = "lblConfiguracaoTurmaAno";
            this.lblConfiguracaoTurmaAno.Size = new System.Drawing.Size(20, 17);
            this.lblConfiguracaoTurmaAno.Text = "lbl";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(186)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 17);
            this.panel1.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::USTG_MG.AppWin32.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.Text = "Exército Brasileiro - MG";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Turmas;
        private System.Windows.Forms.ToolStripMenuItem Patentes;
        private System.Windows.Forms.ToolStripMenuItem Contingente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem janelas;
        private System.Windows.Forms.ToolStripMenuItem horizonta;
        private System.Windows.Forms.ToolStripMenuItem veritical;
        private System.Windows.Forms.ToolStripMenuItem cascata;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharTodas;
        private System.Windows.Forms.ToolStripMenuItem escolaridades;
        private System.Windows.Forms.ToolStripMenuItem profissões;
        private System.Windows.Forms.ToolStripMenuItem religiões;
        private System.Windows.Forms.ToolStripMenuItem atividadesExtras;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasEAtrasos;
        private System.Windows.Forms.ToolStripMenuItem justiçaEDisciplina;
        private System.Windows.Forms.ToolStripMenuItem escalaDeServiço;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem horasExtras;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tAF;
        private System.Windows.Forms.ToolStripMenuItem toolstripDiversos;
        private System.Windows.Forms.ToolStripStatusLabel lblusuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnConfiguracoes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblConfiguracaoTurmaAno;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
    }
}

