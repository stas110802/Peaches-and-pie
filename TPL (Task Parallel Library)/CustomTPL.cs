using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPega.TPL__Task_Parallel_Library_
{
    public class CustomTPL
    {
        public CustomTPL()
        {

        }

        public void CreateTask()
        {
            var task = new Task(() =>
            {
                Console.WriteLine("Hello from task:3");
                Thread.Sleep(1000);
                Console.WriteLine("Im love jpega");
                Thread.Sleep(1000);
            });
            task.Start();// start the task
            task.Wait();// waiting for end

            Console.WriteLine($"is completed successfully: {task.IsCompletedSuccessfully}");            
            Console.WriteLine($"id: {task.Id}");            
        }

        public void CreateTwoTask()
        {
            var firstTask = new Task(() =>
            {
                Console.WriteLine("Task 1 is executed");
                Thread.Sleep(5000);
                Console.WriteLine($"Task 1 is finished {DateTime.UtcNow.ToLongTimeString()}");;
            });
            firstTask.Start();

            var secondTask = new Task(() =>
            {
                Console.WriteLine("Task 2 is executed");
                Thread.Sleep(2500);
                Console.WriteLine($"Task 2 is finished {DateTime.UtcNow.ToLongTimeString()}");
            });           
            secondTask.Start();

            firstTask.Wait();
            secondTask.Wait();
        }

        public void CreateOfList()
        {

        }
    }
    /*
        RunSynchronously() => запускает задачу синхронно
    */
}
