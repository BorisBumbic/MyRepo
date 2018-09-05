using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy
{
    public class App
    {
        DataAccess dataaccess = new DataAccess();

        public void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.WriteLine("Välkommen till huvudmenyn");
            ShowAllBlogPosts();

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) Gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en bloggpost");
            Console.WriteLine("c) Lägg till en rad.");
            Console.WriteLine("d) Ta bort en post.");
            Console.WriteLine("e) Bind ihop en tag och ");

            var command = Console.ReadKey().Key;

            switch(command)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: InsertNewRow(); break;
                case ConsoleKey.D: RemovePost(); break;
                case ConsoleKey.E: TagConnector(); break;
            }

        }

        private void TagConnector()
        {
            Console.Clear();
            Console.WriteLine("Skriv in namnet på den Tag du vill använda.");
            string tagName = Console.ReadLine();
            Console.WriteLine("Skriv in namnet på den Blogpost du vill använda.");
            string BPName = Console.ReadLine();

            dataaccess.AssignTag(tagName, BPName);

            PageMainMenu();

        }

        private void RemovePost()
        {
            Console.Clear();
            Console.WriteLine("Skriv in namnet på den post du vill radera.");
            string titel = Console.ReadLine();

            dataaccess.DeleteRow(titel);

            PageMainMenu();

        }

        private void InsertNewRow()
        {
            Console.Clear();
            Console.WriteLine("Skriv in titeln");
            string titel = Console.ReadLine();
            Console.WriteLine("Skriv in författarens namn.");
            string author = Console.ReadLine();

            dataaccess.AddNewRow(titel, author);

            PageMainMenu();
        }

        private void PageUpdatePost()
        {
            Console.Clear();

            ShowAllBlogPosts();
            Console.Write("Vilken bloggpost vill du uppdatera?");
            int postId = int.Parse(Console.ReadLine());

            BlogPost post = dataaccess.GetBlogPostById(postId);

            Console.WriteLine("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();
            post.Title = newTitle;

            dataaccess.UpdateBlogPost(post);

            Console.WriteLine("Bloggposten uppdaterad. Tryck på valfri knapp för att komma till huvudmenyn");
            Console.ReadKey();
            PageMainMenu(); 
        }

        private void ShowAllBlogPosts()
        {
            Console.Clear();
            List<BlogPost> allPosts = dataaccess.GetAllBlogPost();

            foreach (BlogPost bp in allPosts)
            {
                Console.WriteLine(bp.Id.ToString().PadRight(10) + bp.Title.PadRight(30) + bp.Author.PadRight(30));
            }
        }
    }
}
