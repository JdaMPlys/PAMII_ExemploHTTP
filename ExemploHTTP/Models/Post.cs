using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHTTP.Models
{
    public class Post
    {
        //Clicar com o Botão direito, Quick Actions... , Encapsulamento
        private int id;
        public  int Id { get => id; set => id = value; }

        //Escrever prop e alter o nome da propriedade gerada
        public   int UserId { get; set; }
        public string Title { get; set; }
        public  string Body { get; set; }
        //userId
        //id
        //title
        //body
    }
}
