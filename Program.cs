using System;

namespace crianca_educada
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Não pode digitar palavrão >:( :");
             string palavapo = Console.ReadLine();

             palavapo = palavapo.Replace("chato","@?#*!")
                                .Replace("chata","!@#$!")
                                .Replace("bobo","%$#@")
                                .Replace("boba","@#$%")
                                .Replace("feio","@#$*")
                                .Replace("feia","?!%#")
                                .Replace("boboca","?!%#!#")
                                .Replace("bocó","*&#$")
                                .Replace("tonto","#$%%$")
                                .Replace("tonta","**@#$")
                                .Replace("palerma","#$%!?*")
                                .Replace("paspalho","%#$@*?!@")
                                .Replace("paspalha","$#%$#%@!")
                                .Replace("tantã", "@#!$!")
                                .Replace("panaca","$##$%!")
                                .Replace("pentelho","*&#%$@*¨")
                                .Replace("pentelha","¨*#@%$#*")
                                .Replace("burro","$%#*!")
                                .Replace("burra","!*#%$")
                                .Replace("besta","%$#&¨@");
            Console.WriteLine( $"não pode falar {palavapo} é mal educado");
            Console.ReadKey();
                                
        }
    }
}
