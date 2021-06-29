using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SimpleTypes();
            VarTypes();
            BitTypes();

        }
        static void SimpleTypes()
        {
            byte b = 120;
            sbyte sb = -120;
            int i = -1222;
            uint ui = 1222;
            long l = -999999999;
            ulong ul = 99999999;
            float f = 3.5f;
            double d = 3.5;
            decimal de = 99.99m;
            char ch = 'a';
            string s = "line";
            int[] vs = new int[1];
            int[,] vs1 = new int[1, 1];
            int[,,] vs2 = new int[1, 1, 1];
            long[,,,] vs3 = new long[1, 1, 1, 1];

            byte columnIndex = 1;
            WriteWithColumn("b", b, columnIndex);
            WriteWithColumn("sb", sb, columnIndex);
            WriteWithColumn("i", i, columnIndex);
            WriteWithColumn("ui", ui, columnIndex);
            WriteWithColumn("l", l, columnIndex);
            WriteWithColumn("ul", ul, columnIndex);
            WriteWithColumn("f", f, columnIndex);
            WriteWithColumn("d", d, columnIndex);

            WriteWithColumn("de", de, columnIndex);
            WriteWithColumn("ch", ch, columnIndex);
            WriteWithColumn("s", s, columnIndex);
            WriteWithColumn("vs", vs, columnIndex);
            WriteWithColumn("vs1", vs1, columnIndex);
            WriteWithColumn("vs2", vs2, columnIndex);
            WriteWithColumn("vs3", vs3, columnIndex);



        }
        static void WriteWithColumn(string objName, object obj, byte columnIndex)
        {
            Console.CursorLeft = (columnIndex - 1) * 30;
            Console.WriteLine($"{objName}: {obj.GetType()}");
        }
        static void VarTypes()
        {
            var b = 120;
            var sb = -120;
            var i = -1222;
            var ui = 1222;
            var l = -999999999999999999;
            var ul = 999999999ul;
            var f = 3.5;
            var d = 3.5;
            var de = 99.99m;
            var ch = 'a';
            var s = "line";
            var vs = new int[1];
            int[,] vs1 = new int[1, 1];
            int[,,] vs2 = new int[1, 1, 1];
            long[,,,] vs3 = new long[1, 1, 1, 1];
            System.Int64 xxx = 12;

            byte columnIndex = 2;
            Console.CursorTop = 0;
            WriteWithColumn("b", b, columnIndex);
            WriteWithColumn("sb", sb, columnIndex);
            WriteWithColumn("i", i, columnIndex);
            WriteWithColumn("ui", ui, columnIndex);
            WriteWithColumn("l", l, columnIndex);
            WriteWithColumn("ul", ul, columnIndex);
            WriteWithColumn("f", f, columnIndex);
            WriteWithColumn("d", d, columnIndex);

            WriteWithColumn("de", de, columnIndex);
            WriteWithColumn("ch", ch, columnIndex);
            WriteWithColumn("s", s, columnIndex);
            WriteWithColumn("vs", vs, columnIndex);
            WriteWithColumn("vs1", vs1, columnIndex);
            WriteWithColumn("vs2", vs2, columnIndex);
            WriteWithColumn("vs3", vs3, columnIndex);
            WriteWithColumn("xxx", xxx, columnIndex);
        }
        static void BitTypes()
        {
            var bin = 0b1111111111111111111111111111111111111111111111111111111111111110;  // ob - префикс - bit
            int hex = 0xffff;   // 0x - префикс - hex

            Console.WriteLine(bin);
            Console.WriteLine(hex);
        }
    }
}
