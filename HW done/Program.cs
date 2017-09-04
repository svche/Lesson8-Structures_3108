using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        struct Book
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
            books[0].author = "D_Author";
            books[0].page = 111;
            books[0].id = 1;

            books[1].title = "2_Title";
            books[1].author = "C_Author";
            books[1].page = 222;
            books[1].id = 2;

            books[2].title = "3_Title";
            books[2].author = "B_Author";
            books[2].page = 333;
            books[2].id = 3;

            books[3].title = "4_Title";
            books[3].author = "A_Author";
            books[3].page = 444;
            books[3].id = 4;

            Console.WriteLine("ID\tAUTHOR\t\tTITLE\t\tPAGES");
            Console.WriteLine("----------------------------------------------");

            foreach (Book b in books) Console.WriteLine(b.id + "\t" + b.author + "\t" + b.title + "\t" + "\t" + b.page);
            Console.WriteLine("\n_______________________________________________________________");



/*         Задача 8.3
Для задачи 8.2 вывести отдельно книгу, в которой больше всего страниц */


            int maxPages = books[0].page;
            int indMaxP = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].page > maxPages)
                {
                    maxPages = books[i].page;
                    indMaxP = i;
                }
            }

            Console.WriteLine("\nBook with the most pages is: ");

            Console.WriteLine("\nPAGES\tAUTHOR\t\tTITLE\t\tID");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine(books[indMaxP].page + "\t" + books[indMaxP].author + "\t" +
                             books[indMaxP].title + "\t\t" + books[indMaxP].id);


            //             Задача 8.4
// Отсортировать массив книг по:
//- id
//- количеству страниц
//- алфавиту(по автору)

//- id
            Console.WriteLine("\n\nSorting by ID:");

            Book tmpBid;
            int maxId;
            int indMaxId;

            for (int i = 0; i < books.Length; i++)
            {
                maxId = books[i].id;
                indMaxId = i;

                for (int j = i+1; j < books.Length; j++)
                {
                    if (maxId < books[j].id)
                    {
                        maxId = books[j].id;
                        indMaxId = j;
                    }
                }
                tmpBid = books[indMaxId];
                books[indMaxId] = books[i];
                books[i] = tmpBid;
            }

                Console.WriteLine("\nID\tAUTHOR\t\tTITLE\t\tPAGES");
                Console.WriteLine("----------------------------------------------");

                foreach (Book b in books) Console.WriteLine(b.id + "\t" + b.author + "\t" + b.title + "\t" + "\t" + b.page);

//- количеству страниц
            Console.WriteLine("\n\nSorting by PAGES:");

            int minPages;
            int indMinPages;
            Book tmpBpages;

            for (int i = 0; i <books.Length; i++)
            {
                minPages = books[i].page;
                indMinPages = i;

                for (int j = i; j < books.Length; j++)
                {
                    if (books[j].page < minPages)
                    {
                        minPages = books[j].page;
                        indMinPages = j;
                    }
                }
                tmpBpages = books[indMinPages];
                books[indMinPages] = books[i];
                books[i] = tmpBpages;
            }

            Console.WriteLine("\nPAGES\tAUTHOR\t\tTITLE\t\tID");
            Console.WriteLine("----------------------------------------------");

            foreach (Book b in books) Console.WriteLine(b.page + "\t" + b.author + "\t" + b.title + "\t" + "\t" + b.id);


//- алфавиту(по автору)

            Console.WriteLine("\n\nSorting by AUTHOR:");


            string[] authors = new string[books.Length];
            for (int i = 0; i < books.Length; i++) authors[i] = books[i].author;

            char minAuthor;
            int indMinA;
            string tmpA;

            for (int i = 0; i < authors.Length; i++)
            {
                minAuthor = authors[i][0];
                indMinA = i;

                for (int j = i; j < authors.Length; j++)
                {
                    if (authors[j][0] < minAuthor)
                    {
                        minAuthor = authors[j][0];
                        indMinA = j;
                    }
                }
                tmpA = authors[i];
                authors[i] = authors[indMinA];
                authors[indMinA] = tmpA;
            }

            for (int i = 0; i < books.Length; i++) books[i].author = authors[i];

            Console.WriteLine("\nAUTHOR\t\tPAGES\t\tTITLE\t\tID");
            Console.WriteLine("----------------------------------------------");

            foreach (Book b in books) Console.WriteLine(b.author + "\t" + b.page + "\t" + b.title + "\t" + "\t" + b.id);




            Console.ReadLine();
            }
        }
    }
