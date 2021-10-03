using Exercicio02.Dados;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio02.Extention;
using Microsoft.EntityFrameworkCore;


namespace Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {



            using (var db = new CidadesContext())
            {
                #region Query
                var postCounts = db.Funcionario.ToList();

                foreach (var postCount in postCounts)
                {
                    Console.WriteLine($"{postCount.Nome} - {postCount.DataNascimento}.");
                    Console.WriteLine();
                }
                #endregion



            }
        }
    }
}
