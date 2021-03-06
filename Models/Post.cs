using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")] //Aponta uma chave estrangeira para a tabela de categorias
        public int CategoryId { get; set; }
        public Category Category { get; set; } //Propriedade de navegação
        [ForeignKey("AuthorId")] //Aponta uma chave estrangeira para a tabela de usuários
        public int AuthorId { get; set; }



    }
}