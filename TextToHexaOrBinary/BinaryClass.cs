using System.Text;
using System.Linq;
using System;

static class BinaryClass
 {
    public static string TextToBinary(string Text)
    {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(Text);
        return string.Join("",asciiBytes.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
    }

}