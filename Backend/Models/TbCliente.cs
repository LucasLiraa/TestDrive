using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbAgendamento = new HashSet<TbAgendamento>();
        }

        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_login")]
        public int IdLogin { get; set; }
        [Required]
        [Column("nm_cliente", TypeName = "varchar(100)")]
        public string NmCliente { get; set; }
        [Column("nr_cpf")]
        public string NrCpf { get; set; }
        [Column("nr_cnh")]
        public string NrCnh { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime? DtNascimento { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(255)")]
        public string DsEndereco { get; set; }
        [Column("nr_celular")]
        public string NrCelular { get; set; }
        [Column("bt_deficiente")]
        public bool BtDeficiente { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbCliente))]
        public virtual TbLogin IdLoginNavigation { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
    }
}
