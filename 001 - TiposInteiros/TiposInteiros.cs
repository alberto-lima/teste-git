using System;

namespace _001___TiposInteiros
{
    class TiposInteiros
    {
        static void Main(string[] args)
        {
            int idade = 15; 
            Console.WriteLine("// Tipo int faz parte do System.int32");
            Console.WriteLine($"Tipo int idade: {idade}");
            Console.WriteLine();

            long wLong = 1000;
            Console.WriteLine("// Tipo long faz parte do System.Int64, é maoir que o int aceita e -/+ 207 milhoes");
            Console.WriteLine($"Tipo long: {wLong}");
            Console.WriteLine();

            char wchar = 'S';
            Console.WriteLine("// Tipo CHAR ou System.Char, apenas 1 caractrer");
            Console.WriteLine($"Tipo char: {wchar}");
            Console.WriteLine();

            byte wbyte = 0xff;
            Console.WriteLine("// Tipo byte recebe conteúdo de um byte e são 8 bite, decimal de 0 até 255");
            Console.WriteLine("// Não aceita negatigo");
            Console.WriteLine($"Tipo byte: {wbyte}");
            Console.WriteLine();

            short wShort = 0xff;
            Console.WriteLine("// Tipo short faz parte do System.Int16");
            Console.WriteLine($"Tipo short: {wShort}");
            Console.WriteLine();

            sbyte wSbyte = -127;
            Console.WriteLine("// Tipo short faz parte do System.sbyte");
            Console.WriteLine($"Tipo sbyte: {wSbyte}");
            Console.WriteLine();

            ushort wUshort = 127;
            Console.WriteLine("// Tipo short faz parte do System.sbyte");
            Console.WriteLine($"Tipo ushort: {wUshort}");
            Console.WriteLine();

            uint wUInt = 1500;
            Console.WriteLine("// Tipo short faz parte do System.Uint32, aceita apenas positivos");
            Console.WriteLine($"Tipo uint: {wUInt}");
            Console.WriteLine();

            ulong wULong = 7_000_000_000;
            Console.WriteLine("// Tipo short faz parte do System.Uint32, aceita apenas positivos");
            Console.WriteLine($"Tipo ulong: {wULong}");
            Console.WriteLine();





            Console.ReadLine();
        }
    }
}
