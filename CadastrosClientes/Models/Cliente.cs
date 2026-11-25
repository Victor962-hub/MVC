using System.ComponentModel.DataAnnotations;

namespace CadastrosClientes.Models;

public class Cliente
{
    public int? Id {get; set; }

    [Required]          // Campo Obrigatório
    [StringLength(100)] // Tamanho Máximo do texto em caracter

    public string Nome {get; set; } = string.Empty;

    [StringLength(14)]
    public string? CPF {get; set; } // ? = Aceita Tudo

    [EmailAddress]      // Identifica que o campo é e-mail
    [StringLength(150)] // Tamnho máximo do campo com 150 caractares
    public string? Email {get; set; }

    [Phone]             // Phone = Permitir Colocar +55 ou +44 e entre outros
    [StringLength(20)]
    public string? Telefone {get; set; }

    [StringLength(200)]
    public string? Endereco {get; set; }

    [StringLength(100)]
    public string? Cidade {get; set; }

    [StringLength(2)]
    public string? UF {get; set; }

    [DataType(DataType.Date)]   //Idebtifica que o Campo é data e mostra somente DATA
    [Display(Name = "Data de Nascimento")]  // Mostra o Campo ao Usuário de outra Forma
    public DateTime? DataNascimento {get; set; }
    public bool Ativo {get; set; } = true;

}
