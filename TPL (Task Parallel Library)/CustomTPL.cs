using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;// TPL

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

        public void CreateListOfTask()
        {
            var listOfTask = new List<Task>()
            {
                new Task(() => Console.WriteLine("1 task")),
                new Task(() => Console.WriteLine("2 task")),
                new Task(() => Console.WriteLine("3 task")),
            };

            //Parallel.ForEach(listOfTask, x => x.Start());// если в списки были синхронные action,
            //то можно сделать задачу так (чтобы распаллелить ее)

            foreach (var item in listOfTask)
            {
                item.Start();
            }

            Task.WaitAll(listOfTask.ToArray());// waiting for all tasks to complete
        }

        public void ReturnTaskResult()
        {
            #region Method example

            var first = 44;
            var second = 11;

            var task = new Task<int>(() => Sum(first, second));// Task<int> task
            task.Start();

            int result = task.Result;
            Console.WriteLine($"{first} + {second} = {result}");

            #endregion

            #region Class example

            var personTaks = new Task<Person>(() => new Person("Stanislav", 19));
            personTaks.Start();
            var personResult = personTaks.Result;
            Console.WriteLine($"name: {personResult.Name} age: {personResult.Age}");

            #endregion
        }

        private int Sum(int first, int second) => first + second;
        private record class Person(string Name, int Age);// immutable class
    }

    /*
        RunSynchronously() => запускает задачу синхронно
        Task.WaitAny(tasks) => ждет завершения хотя бы одной задачи
    */
}
