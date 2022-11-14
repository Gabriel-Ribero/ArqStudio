﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArqStudio.Model
{
    internal class Formulario
    {
        private int idPergunta;
        private int quantPessoasHabitam;
        private int pessoaDeficiente;
        private string descricaoDeficiente;
        private int animaisEstimacao;
        private string quaisAnimais;
        private int pessoaTrabalhaEmCasa;
        private int estiloArquitetonico;
        private int idEndereco;
        private int idUsuario;

        public int IdFormulario { get => idPergunta; set => idPergunta = value; }
        public int QuantPessoasHabitam { get => quantPessoasHabitam; set => quantPessoasHabitam = value; }
        public int PessoasDeficientes { get => pessoaDeficiente; set => pessoaDeficiente = value; }
        public string DescricaoDeficientes { get => descricaoDeficiente; set => descricaoDeficiente = value; }
        public int AnimaisEstimacao { get => animaisEstimacao; set => animaisEstimacao = value; }
        public string DescricaoAnimais { get => quaisAnimais; set => quaisAnimais = value; }
        public int PessoasTrabalhaEmCasa { get => pessoaTrabalhaEmCasa; set => pessoaTrabalhaEmCasa = value; }
        public int EstiloArquitetonico { get => estiloArquitetonico; set => estiloArquitetonico = value; }
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}