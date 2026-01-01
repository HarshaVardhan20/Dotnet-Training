using System.Collections;
using System.Collections.Generic;

namespace GarbageCollector
{
    public class BigBoy: IDisposable
    {
        public ArrayList names { get; set; }

        public BigBoy() { 

        }
        
        public void Dispose()
        {
            names = null;
        }


    }
     class Program
     {
        static void Main()
        {
            //var list = new List<byte[]>();
            //Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));

            //for (int i = 0; i < 99999999; i++) list.Add(new byte[1024]);

            //Console.WriteLine("Allocated");

            //Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));

            //GC.Collect();

            //Console.WriteLine("Total memory: " + GC.GetTotalMemory(forceFullCollection: false));
            BigBoy by = new BigBoy();
            by.names = new ArrayList();
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    by.names.Add(i.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception found");
            }
            finally
            {
                by.Dispose();
                Console.WriteLine("Disposed");
            }


        }
    }
}
