using System;
using ConverterApp.Models;
namespace ConverterApp
{
    class Converter
    {
        static void Main(string[] args)
        {
            var fullName = Console.ReadLine();
            //string text = "Tomasz Szumski";
            string binaryValue2 = Models.Converter.StringToBinary2(fullName);
            Console.WriteLine($"Text: {fullName}\nBinary: {binaryValue2}");

            //result of binary conversion "0101010001101111011011010110000101110011011110100010000001010011011110100111010101101101011100110110101101101001";
                                         
            var ascii = Console.ReadLine();
            string textFromBinary = Models.Converter.BinaryToString(ascii);
            Console.WriteLine($"Binary: {ascii}\nText: {textFromBinary}");

            //string text = "Tomasz Szumski";
            var text = Console.ReadLine();

            string Hexvalue= Models.Converter.StringToHex2(text);

            //Output the Hexadecimal conversion
            Console.WriteLine(Hexvalue);

            //result of hex conversion "546F6D61737A20537A756D736B69";
            var hexadecimalValue = Console.ReadLine();
            string textFromHex = Models.Converter.HexToString(hexadecimalValue);

            Console.WriteLine($"HEX: {hexadecimalValue}\nText: {textFromHex}");

            //ascii text
            var name = Console.ReadLine();

            //Output the Base64 encoded string
            string nameBase64Encoded = Models.Converter.StringToBase64(name);
            Console.WriteLine(nameBase64Encoded);
            Console.ReadKey();

            //Output the decoded Base64 string
            string nameBase64Decoded = Models.Converter.Base64ToString(nameBase64Encoded);
            Console.WriteLine(nameBase64Decoded);

            Console.ReadKey();



           

           

        }
    }
}
