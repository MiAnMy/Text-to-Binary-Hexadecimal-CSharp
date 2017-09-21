using System.Text;
using System;

static class HexClass
{
    public static string TextToBinary(string Text)
    {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(Text);
        return BitConverter.ToString(asciiBytes).Replace("-", "");
    }

}