﻿
namespace Agenda
{
    partial class FormAgenda2
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescrição = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDataInicio2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDataFim2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxNotificação2 = new System.Windows.Forms.ListBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxDescrição = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.salvarNotificação = new System.Windows.Forms.Button();
            this.editarNotificação = new System.Windows.Forms.Button();
            this.excluirNotificação = new System.Windows.Forms.Button();
            this.voltarTela = new System.Windows.Forms.Button();
            this.salvarCompromisso = new System.Windows.Forms.Button();
            this.editarCompromisso = new System.Windows.Forms.Button();
            this.excluirCompromisso = new System.Windows.Forms.Button();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxConvidados = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SalvarEvento = new System.Windows.Forms.Button();
            this.EditarEventos = new System.Windows.Forms.Button();
            this.ExcluirEventos = new System.Windows.Forms.Button();
            this.listBoxConvidados = new System.Windows.Forms.ListBox();
            this.comboBoxTarefa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxLembrete = new System.Windows.Forms.ComboBox();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRepetir = new System.Windows.Forms.ComboBox();
            this.comboBoxTerminar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(14, 38);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(376, 23);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // textBoxDescrição
            // 
            this.textBoxDescrição.Location = new System.Drawing.Point(14, 82);
            this.textBoxDescrição.Multiline = true;
            this.textBoxDescrição.Name = "textBoxDescrição";
            this.textBoxDescrição.Size = new System.Drawing.Size(374, 72);
            this.textBoxDescrição.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // dateTimeDataInicio2
            // 
            this.dateTimeDataInicio2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimeDataInicio2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDataInicio2.Location = new System.Drawing.Point(434, 82);
            this.dateTimeDataInicio2.Name = "dateTimeDataInicio2";
            this.dateTimeDataInicio2.Size = new System.Drawing.Size(140, 23);
            this.dateTimeDataInicio2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inicio do evento";
            // 
            // dateTimePickerDataFim2
            // 
            this.dateTimePickerDataFim2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerDataFim2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataFim2.Location = new System.Drawing.Point(595, 82);
            this.dateTimePickerDataFim2.Name = "dateTimePickerDataFim2";
            this.dateTimePickerDataFim2.Size = new System.Drawing.Size(143, 23);
            this.dateTimePickerDataFim2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fim do evento";
            // 
            // listBoxNotificação2
            // 
            this.listBoxNotificação2.FormattingEnabled = true;
            this.listBoxNotificação2.ItemHeight = 15;
            this.listBoxNotificação2.Location = new System.Drawing.Point(14, 239);
            this.listBoxNotificação2.Name = "listBoxNotificação2";
            this.listBoxNotificação2.Size = new System.Drawing.Size(374, 109);
            this.listBoxNotificação2.TabIndex = 9;
            this.listBoxNotificação2.SelectedIndexChanged += new System.EventHandler(this.listBoxNotificação2_SelectedIndexChanged);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(139, 202);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(110, 23);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // comboBoxDescrição
            // 
            this.comboBoxDescrição.FormattingEnabled = true;
            this.comboBoxDescrição.Location = new System.Drawing.Point(255, 202);
            this.comboBoxDescrição.Name = "comboBoxDescrição";
            this.comboBoxDescrição.Size = new System.Drawing.Size(133, 23);
            this.comboBoxDescrição.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descrição";
            // 
            // salvarNotificação
            // 
            this.salvarNotificação.Location = new System.Drawing.Point(14, 370);
            this.salvarNotificação.Name = "salvarNotificação";
            this.salvarNotificação.Size = new System.Drawing.Size(75, 23);
            this.salvarNotificação.TabIndex = 16;
            this.salvarNotificação.Text = "Salvar";
            this.salvarNotificação.UseVisualStyleBackColor = true;
            this.salvarNotificação.Click += new System.EventHandler(this.salvarNotificação_Click);
            // 
            // editarNotificação
            // 
            this.editarNotificação.Location = new System.Drawing.Point(107, 370);
            this.editarNotificação.Name = "editarNotificação";
            this.editarNotificação.Size = new System.Drawing.Size(75, 23);
            this.editarNotificação.TabIndex = 17;
            this.editarNotificação.Text = "Editar";
            this.editarNotificação.UseVisualStyleBackColor = true;
            this.editarNotificação.Click += new System.EventHandler(this.editarNotificação_Click);
            // 
            // excluirNotificação
            // 
            this.excluirNotificação.Location = new System.Drawing.Point(200, 370);
            this.excluirNotificação.Name = "excluirNotificação";
            this.excluirNotificação.Size = new System.Drawing.Size(75, 23);
            this.excluirNotificação.TabIndex = 18;
            this.excluirNotificação.Text = "Excluir";
            this.excluirNotificação.UseVisualStyleBackColor = true;
            this.excluirNotificação.Click += new System.EventHandler(this.excluirNotificação_Click);
            // 
            // voltarTela
            // 
            this.voltarTela.Location = new System.Drawing.Point(845, 544);
            this.voltarTela.Name = "voltarTela";
            this.voltarTela.Size = new System.Drawing.Size(82, 29);
            this.voltarTela.TabIndex = 19;
            this.voltarTela.Text = "Voltar";
            this.voltarTela.UseVisualStyleBackColor = true;
            this.voltarTela.Click += new System.EventHandler(this.voltarTela_Click);
            // 
            // salvarCompromisso
            // 
            this.salvarCompromisso.Location = new System.Drawing.Point(434, 131);
            this.salvarCompromisso.Name = "salvarCompromisso";
            this.salvarCompromisso.Size = new System.Drawing.Size(75, 23);
            this.salvarCompromisso.TabIndex = 20;
            this.salvarCompromisso.Text = "Salvar";
            this.salvarCompromisso.UseVisualStyleBackColor = true;
            this.salvarCompromisso.Click += new System.EventHandler(this.salvarCompromisso_Click);
            // 
            // editarCompromisso
            // 
            this.editarCompromisso.Location = new System.Drawing.Point(531, 131);
            this.editarCompromisso.Name = "editarCompromisso";
            this.editarCompromisso.Size = new System.Drawing.Size(75, 23);
            this.editarCompromisso.TabIndex = 21;
            this.editarCompromisso.Text = "Editar";
            this.editarCompromisso.UseVisualStyleBackColor = true;
            this.editarCompromisso.Click += new System.EventHandler(this.editarCompromisso_Click);
            // 
            // excluirCompromisso
            // 
            this.excluirCompromisso.Location = new System.Drawing.Point(629, 131);
            this.excluirCompromisso.Name = "excluirCompromisso";
            this.excluirCompromisso.Size = new System.Drawing.Size(75, 23);
            this.excluirCompromisso.TabIndex = 22;
            this.excluirCompromisso.Text = "Excluir";
            this.excluirCompromisso.UseVisualStyleBackColor = true;
            this.excluirCompromisso.Click += new System.EventHandler(this.excluirCompromisso_Click);
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(434, 38);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(529, 23);
            this.textBoxLocal.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Local";
            // 
            // textBoxConvidados
            // 
            this.textBoxConvidados.Location = new System.Drawing.Point(434, 202);
            this.textBoxConvidados.Name = "textBoxConvidados";
            this.textBoxConvidados.Size = new System.Drawing.Size(529, 23);
            this.textBoxConvidados.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Convidados";
            // 
            // SalvarEvento
            // 
            this.SalvarEvento.Location = new System.Drawing.Point(434, 370);
            this.SalvarEvento.Name = "SalvarEvento";
            this.SalvarEvento.Size = new System.Drawing.Size(75, 23);
            this.SalvarEvento.TabIndex = 28;
            this.SalvarEvento.Text = "Salvar";
            this.SalvarEvento.UseVisualStyleBackColor = true;
            this.SalvarEvento.Click += new System.EventHandler(this.SalvarEvento_Click);
            // 
            // EditarEventos
            // 
            this.EditarEventos.Location = new System.Drawing.Point(531, 370);
            this.EditarEventos.Name = "EditarEventos";
            this.EditarEventos.Size = new System.Drawing.Size(75, 23);
            this.EditarEventos.TabIndex = 29;
            this.EditarEventos.Text = "Editar";
            this.EditarEventos.UseVisualStyleBackColor = true;
            this.EditarEventos.Click += new System.EventHandler(this.EditarEventos_Click);
            // 
            // ExcluirEventos
            // 
            this.ExcluirEventos.Location = new System.Drawing.Point(629, 370);
            this.ExcluirEventos.Name = "ExcluirEventos";
            this.ExcluirEventos.Size = new System.Drawing.Size(75, 23);
            this.ExcluirEventos.TabIndex = 30;
            this.ExcluirEventos.Text = "Excluir";
            this.ExcluirEventos.UseVisualStyleBackColor = true;
            this.ExcluirEventos.Click += new System.EventHandler(this.ExcluirEventos_Click);
            // 
            // listBoxConvidados
            // 
            this.listBoxConvidados.FormattingEnabled = true;
            this.listBoxConvidados.ItemHeight = 15;
            this.listBoxConvidados.Location = new System.Drawing.Point(434, 239);
            this.listBoxConvidados.Name = "listBoxConvidados";
            this.listBoxConvidados.Size = new System.Drawing.Size(529, 109);
            this.listBoxConvidados.TabIndex = 31;
            this.listBoxConvidados.SelectedIndexChanged += new System.EventHandler(this.listBoxConvidados_SelectedIndexChanged);
            // 
            // comboBoxTarefa
            // 
            this.comboBoxTarefa.FormattingEnabled = true;
            this.comboBoxTarefa.Location = new System.Drawing.Point(754, 82);
            this.comboBoxTarefa.Name = "comboBoxTarefa";
            this.comboBoxTarefa.Size = new System.Drawing.Size(173, 23);
            this.comboBoxTarefa.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tarefa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Repetir:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 42;
            this.label12.Text = "Terminar em:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "Repetir a cada:";
            // 
            // comboBoxLembrete
            // 
            this.comboBoxLembrete.FormattingEnabled = true;
            this.comboBoxLembrete.Items.AddRange(new object[] {
            "Dia ",
            "Semana ",
            "Mês",
            "Ano"});
            this.comboBoxLembrete.Location = new System.Drawing.Point(301, 442);
            this.comboBoxLembrete.Name = "comboBoxLembrete";
            this.comboBoxLembrete.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLembrete.TabIndex = 48;
            this.comboBoxLembrete.SelectedIndexChanged += new System.EventHandler(this.comboBoxLembrete_SelectedIndexChanged);
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.Location = new System.Drawing.Point(12, 203);
            this.numericUpDownTempo.Name = "numericUpDownTempo";
            this.numericUpDownTempo.Size = new System.Drawing.Size(119, 23);
            this.numericUpDownTempo.TabIndex = 10;
            // 
            // comboBoxRepetir
            // 
            this.comboBoxRepetir.FormattingEnabled = true;
            this.comboBoxRepetir.Location = new System.Drawing.Point(14, 442);
            this.comboBoxRepetir.Name = "comboBoxRepetir";
            this.comboBoxRepetir.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRepetir.TabIndex = 49;
            this.comboBoxRepetir.SelectedIndexChanged += new System.EventHandler(this.comboBoxRepetir_SelectedIndexChanged);
            // 
            // comboBoxTerminar
            // 
            this.comboBoxTerminar.FormattingEnabled = true;
            this.comboBoxTerminar.Location = new System.Drawing.Point(160, 442);
            this.comboBoxTerminar.Name = "comboBoxTerminar";
            this.comboBoxTerminar.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTerminar.TabIndex = 50;
            // 
            // FormAgenda2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(975, 628);
            this.Controls.Add(this.comboBoxTerminar);
            this.Controls.Add(this.comboBoxRepetir);
            this.Controls.Add(this.comboBoxLembrete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTarefa);
            this.Controls.Add(this.listBoxConvidados);
            this.Controls.Add(this.ExcluirEventos);
            this.Controls.Add(this.EditarEventos);
            this.Controls.Add(this.SalvarEvento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxConvidados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.excluirCompromisso);
            this.Controls.Add(this.editarCompromisso);
            this.Controls.Add(this.salvarCompromisso);
            this.Controls.Add(this.voltarTela);
            this.Controls.Add(this.excluirNotificação);
            this.Controls.Add(this.editarNotificação);
            this.Controls.Add(this.salvarNotificação);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDescrição);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.numericUpDownTempo);
            this.Controls.Add(this.listBoxNotificação2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDataFim2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeDataInicio2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDescrição);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitulo);
            this.Name = "FormAgenda2";
            this.Text = "Compromisso";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescrição;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDataInicio2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFim2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxNotificação2;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxDescrição;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button salvarNotificação;
        private System.Windows.Forms.Button editarNotificação;
        private System.Windows.Forms.Button excluirNotificação;
        private System.Windows.Forms.Button voltarTela;
        private System.Windows.Forms.Button salvarCompromisso;
        private System.Windows.Forms.Button editarCompromisso;
        private System.Windows.Forms.Button excluirCompromisso;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxConvidados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SalvarEvento;
        private System.Windows.Forms.Button EditarEventos;
        private System.Windows.Forms.Button ExcluirEventos;
        private System.Windows.Forms.ListBox listBoxConvidados;
        private System.Windows.Forms.ComboBox comboBoxTarefa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxLembrete;
        private System.Windows.Forms.NumericUpDown numericUpDownTempo;
        private System.Windows.Forms.ComboBox comboBoxRepetir;
        private System.Windows.Forms.ComboBox comboBoxTerminar;
    }
}