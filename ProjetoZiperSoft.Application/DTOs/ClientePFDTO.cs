using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoZiperSoft
{
    public class ClientePFDTO
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(50)]
        public string Nome { get; set; }

        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O Email é obrigatório.")]
        //[StringLength(50, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 50 caracteres.")]
        public string Email { get; set; }

        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "O Telefone completo é obrigatório.")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Telefone { get; set; }

        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string Celular { get; set; }

        [MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 1000 caracteres.")]
        public string Observacao { get; set; }

        public string Foto { get; set; }

        public Endereco Endereco { get; set; }
        public int IdEndereco { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public bool Situacao { get; set; }

        [MaxLength(20)]
        [Required]
        public string Rg { get; set; }

        [MaxLength(20)]
        [Required]
        public string Cpf { get; set; }
    }
}
