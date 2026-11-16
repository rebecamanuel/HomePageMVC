using System;

namespace projetoNovo.Models;

public class Produto
{
     public string? Nome {get; set;}

     public int Id {get; set;}

     public decimal Preco {get; set;}

     public Produto(string nome, int id, decimal preco)
     {
      Nome=nome;
      Id=id;    
      Preco=preco;
     }
}
