using System;

namespace DataTransferObjects
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeEdicao { get; set; }
        public DateTime DataDeExclusao { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public bool Excluido { get; set; }
    }
}