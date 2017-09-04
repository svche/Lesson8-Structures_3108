using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        public struct Book
        {
            public string title;
            public string author;
            public int page;
            public int id;
        }

        static void Main(string[] args)
        {
            /*
            Задача 8.1
  Создать структуру "Книга" со следующими полями:
            -название;
            -автор;
            -количество страниц;
            -идентификационный номер.
     Объявить и проинициализировать четыре статические структуры.
  Вывести их на экран. */

            /*
            Console.Write("How many books do you have?: ");
            int countofBooks = int.Parse(Console.ReadLine());

            Book[] books = new Book[countofBooks];
            
            for (int i = 0; i < countofBooks; i++)
            {
                Console.Write("\nEnter the title_book {0}: ", (i + 1));
                books[i].title = Console.ReadLine();

                Console.Write("Enter the author_book {0}: ", (i + 1));
                books[i].author = Console.ReadLine();

                Console.Write("Enter the pages number_book {0}: ", (i + 1));
                books[i].page = int.Parse(Console.ReadLine());

                Console.Write("Enter the id_book {0}: ", (i + 1));
                books[i].id = int.Parse(Console.ReadLine());
            }

           foreach (Book tmpBook in books)
            {
                Console.WriteLine("-------------NEW BOOK--------------");
                Console.WriteLine("Book title : {0}", tmpBook.title);
                Console.WriteLine("Book author : {0}", tmpBook.author);
                Console.WriteLine("Book pages_number : {0}", tmpBook.page);
                Console.WriteLine("Book id : {0}", tmpBook.id);
            }
            */


            /* Задача 8.2
  Объявить массив из четырех книг.Ввести их с клавиатуры.
  Вывести в виде таблицы
  id Autor      Title Page Count */

            
            Book[] books = new Book[4];

            books[0].title = "1_Title";
            books[0].author = "1_Author";
            books[0].page = 111;
            books[0].id = 1;

            books[1].title = "2_Title";
            books[1].author = "2_Author";
            books[1].page = 222;
            books[1].id = 2;

            books[2].title = "3_Title";
            books[2].author = "3_Author";
            books[2].page = 33377;
            books[2].id = 3;

            books[3].title = "4_Title";
            books[3].author = "4_Author";
            books[3].page = 444;
            books[3].id = 4;

            Console.WriteLine("ID\tAUTHOR\t\tTITLE\t\tPAGES");

            foreach (Book b in books) Console.WriteLine(b.id + "\t" + b.author + "\t" + b.title + "\t" + "\t" + b.page);



            /*         Задача 8.3
            Для задачи 8.2 вывести отдельно книгу, в которой больше всего страниц */


            int maxPages = books[0].page;
            int numMax = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].page < maxPages)
                {
                    numMax = i;
                    maxPages = books[i].page;
                }
            }
           


            Console.WriteLine("\nBook with the most pages is: ");

            Console.WriteLine("\nID\tAUTHOR\t\tTITLE\t\tPAGES");

            Console.WriteLine(books[numMax].id + "\t" + books[numMax].author + "\t" + 
                             books[numMax].title + "\t\t" + books[numMax].page);


            /*            Задача 8.4
              Отсортировать массив книг по:
                 -id
                 - 2 количеству страниц
                 -3 алфавиту(по автору)
            */

            /*
            int maxPages;
            int indMax;
            Book tmpBook;

            for (int i = 0; i < books.Length; i++)
            {
                maxPages = books[i].page;
                indMax = i;

                for (int j = i; j < books.Length; j++)
                {
                    if (books[j].page > maxPages)
                    {
                        maxPages = books[j].page;
                        indMax = j;
                    }
                }
                tmpBook = books[i];
                books[i] = books[indMax];
                books[indMax] = tmpBook;
            }
            Console.WriteLine();
            */


            Console.ReadLine();
        }
    }
}
