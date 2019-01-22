using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloggy.Domain;

namespace Bloggy
{
    public class DataAccess
    {

        string conString = @"Server=(localdb)\mssqllocaldb;Database=BlogDB";

        public List<BlogPost> GetAllBlogPost()

        {

            string sql = @"select Id, Title, Author
                            from BlogPost";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                var result = new List<BlogPost>();

                while (reader.Read())
                {

                    var bp = new BlogPost();

                    int id = reader.GetSqlInt32(0).Value;
                    string title = reader.GetSqlString(1).Value;
                    string author = reader.GetSqlString(2).Value;

                    bp.Id = id;
                    bp.Title = title;
                    bp.Author = author;

                    result.Add(bp);

                }

                return result;
            }

        }

        private void Apa()
        {
            throw new NotImplementedException();
        }


        internal BlogPost GetBlogPostById(int postId)
        {
            string sql = @"select Id, Title, Author
                            from BlogPost
                             where Id=@Idk";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Idk", postId));

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();



                var bp = new BlogPost();

                int id = reader.GetSqlInt32(0).Value;
                string title = reader.GetSqlString(1).Value;
                string author = reader.GetSqlString(2).Value;

                bp.Id = id;
                bp.Title = title;
                bp.Author = author;
                return bp;
            }

        }

        public void UpdateBlogPost(BlogPost post)
        {
            string sql = @"update BlogPost
                            set Title=@Title where Id=@Id";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", post.Id));
                command.Parameters.Add(new SqlParameter("Title", post.Title));
                command.ExecuteNonQuery();

            }
        }

        public void AddNewRow(string title, string author)
        {

            string sql = @"INSERT INTO BlogPost(Title, Author)
                            VALUES(@title, @author)";


            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                connection.Open();
                command.Parameters.Add(new SqlParameter("title", title));
                command.Parameters.Add(new SqlParameter("author", author));
                command.ExecuteNonQuery();

            }

        }

        
        public void DeleteRow(string title)
        {
            string sql = @"DELETE FROM BlogPost
                           WHERE BlogPost.Title = @title";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                connection.Open();
                command.Parameters.Add(new SqlParameter("title", title));
                command.ExecuteNonQuery();
            }
        }

        public void AssignTag(string tagName, string blogPostName)
        {
            string sql = @"INSERT INTO TagsToBP(TagId, BPId)
                            VALUES((select id from Tags where Tags.Name = @Name ) , 
							(select id from BlogPost where BlogPost.Title = @Title))";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Name", tagName));
                command.Parameters.Add(new SqlParameter("Title", blogPostName));
                command.ExecuteNonQuery();
            }
        }

    }
}