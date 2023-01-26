using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistraPessoa.Api.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("ID")]
        public ulong Id {get; set; }
    }
}