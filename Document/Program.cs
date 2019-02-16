// Code for INFOTC 2040's Document challenge (incomplete)
// By Brandon Buttlar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    public class Document
    {
        public string name, filename;

        public void Init()
        {
            Console.WriteLine("Document\n\nDocument name: ");
        }

        public void Filename()
        {
            name = Console.ReadLine();
            if (name == "0") // Used to test catch
            {
                throw new System.Exception();
            }
            filename = $"{name}.txt";
        }

        public void Exit()
        {
            Console.WriteLine($"{filename} was successfully saved. The document contains [count] characters.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document();

            d.Init();
            try
            {
                d.Filename();
                d.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");
            }

            Console.ReadLine();
        }
    }
}
