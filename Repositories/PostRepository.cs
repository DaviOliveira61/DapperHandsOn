using BaltaDataAccessHandsOn.Models;
using Dapper;

namespace BaltaDataAccessHandsOn.Repositories
{
    public class PostRepository : Repository<Post>
    {
        public List<Post> GetWithTag()
        {
            var query = @"
                SELECT 
                    [Post].*,
                    [Tag].*
                FROM
                    [Post]
                LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
                LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]";
            var posts = new List<Post>();
            var items = Database.Connection.Query<Post, Tag, Post>(
                query,
                (post, tag) =>
                {
                    var pst = posts.FirstOrDefault(x => x.Id == post.Id);
                    if (pst == null)
                    {
                        pst = post;
                        if (post != null)
                            pst.Tags.Add(tag);

                        posts.Add(pst);
                    }
                    else
                        pst.Tags.Add(tag);


                    return post;
                }, splitOn: "Id");
            return posts;
        }
        public void LinkPostAndTag(int postID, int tagID)
        {
            var verifyPostTag = GetWithTag();
            // List<int> userId = new List<int>();
            List<int> tagId = new List<int>();
            foreach (var post in verifyPostTag)
            {
                if (post.Id == postID)
                {
                    foreach (var tags in post.Tags)
                    {
                        if (tags != null)
                            tagId.Add(tags.Id);
                    }
                }
            }

            if (tagId.Contains(tagID) == false || tagId == null)
            {
                var repository = new Repository<PostTag>();
                var postTag = new PostTag
                {
                    PostId = postID,
                    TagId = tagID
                };
                repository.Create(postTag);
                Console.WriteLine("Post was linked successfully!");
            }
            else
            {
                Console.WriteLine("The post had this tag.");
            }
        }

        // public void Update(Post post)
        // {

        // }
    }
}