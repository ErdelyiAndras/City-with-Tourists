//Date:     2024.02.21.
//Title:    mostly API compatible TextFileReader clone, compatible with C# 8

using System;
using System.IO;
using System.Text;

namespace TextFile;

public class TextFileReader : IDisposable
{
    private readonly StreamReader _reader;
    private const string Delimit = " \t\n\r";

    public TextFileReader()
    {
        _reader = new StreamReader(Console.OpenStandardInput());
    }
    
    public TextFileReader(string filename)
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException($"File '{filename}' does not exist.");
        _reader = new StreamReader(filename);
    }
    
    //Task: 	reading the next character
    //Input:    StreamReader reader -  datachannel to a text file
    //Output:   char ch             -  char
    //          bool l              -  true if the character exists
    //Activity: it uses the Read() method of reader if the text file is not empty
    public bool ReadChar(out char ch)
    {
        char? c = ReadChar();
        ch = c ?? '\0';
        return c is not null;
    }

    public char? ReadChar()
    {
        SkipWhitespace();
        int c = _reader.Read();
        return (c == -1) ? null : (char)c;
    }

    //Task: 	reading the next string that is terminated by whitespace or eof
    //Input:    StreamReader reader -  datachannel to a text file
    //Output:   string str          -  string
    //          bool l              -  true if the string exists
    //Activity: it finds the beginning of the next string overstepping whitespaces, 
    //          and if this string exists, it concatenates its characters bordered by whitespace or eof
    public bool ReadString(out string str)
    {
        string? s = ReadString();
        str = s ?? "";
        return s is not null;
    }

    public string? ReadString()
    {
        SkipWhitespace();
        StringBuilder sb = new StringBuilder();
        bool ok = false;
        int c;
        while ((c = _reader.Read()) != -1 && !Delimit.Contains((char)c))
        {
            ok = true;
            sb.Append((char)c);
        }

        return ok ? sb.ToString() : null;
    }

    //Task: 	reading the next integer that is terminated by white-space or eof
    //Input:    StreamReader reader -  datachannel to a text file
    //Output:   int n               -  integer
    //          bool l              -  true if the string exists
    //Activity: it reads the next string (see ReadString()), and then it will be converted to integer
    public bool ReadInt(out int n)
    {
        int? x = ReadInt();
        n = x ?? 0;
        return x is not null;
    }

    public int? ReadInt()
    {
        string? s = ReadString();
        return s is null ? null : int.Parse(s);
    }

    //Task: 	reading the next bouble number that is terminated by white-space or eof
    //Input:    StreamReader reader -  datachannel to a text file
    //Output:   double a            -  double
    //          bool l              -  true if the string exists
    //Activity: it reads the next string (see ReadString()), and then it will be converted to double
    public bool ReadDouble(out double a)
    {
        double? x = ReadDouble();
        a = x ?? 0.0;
        return x is not null;
    }

    public double? ReadDouble()
    {
        string? s = ReadString();
        return s is null ? null : double.Parse(s);
    }

    //Task: 	reading the next line
    //Input:    StreamReader reader -  datachannel to a text file
    //Output:   string line         -  char
    //          bool l              -  true if the character exists
    //Activity: it uses the ReadLine() method of reader
    public bool ReadLine(out string line)
    {
        string? l = ReadLine();
        line = l ?? "";
        return l is not null;
    }

    public string? ReadLine()
    {
        return _reader.ReadLine();
    }

    private void SkipWhitespace()
    {
        int c = _reader.Peek();
        while (c != -1 && Delimit.Contains((char)c))
        {
            _reader.Read();
            c = _reader.Peek();
        }
    }
    
    ~TextFileReader()
    {
        Dispose();
    }

    public void Close()
    {
        Dispose();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}