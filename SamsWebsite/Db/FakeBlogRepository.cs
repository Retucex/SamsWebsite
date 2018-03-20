using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamsWebsite.Models;

namespace SamsWebsite.Db
{
    public class FakeBlogRepository : IBlogRepository
    {
	    static BlogPost bp1;
	    static BlogPost bp2;
	    static BlogComment c1;
	    static BlogComment c2;
	    static BlogComment c3;

		static FakeBlogRepository()
	    {
			bp1 = new BlogPost()
			{
				BlogPostID = 1,

				Title = "Some super engaging blog post!",

				Content = "Hi, I am a random article that makes no sense. " +
					  "Hopefully this ends up larger whatever limit I set for the excerpt " +
					  "size so I can test that functionality. " +
					  "Yes, I could preemtively count the characters and leave myself a comment, " +
					  "but where's the fun in that!? " +
					  "Anyway, this look longer than a tweet, so I should be good. Yea. Sure.",

				Published = new DateTime(2017, 8, 7, 12, 23, 43),

				IsVisible = true,

				Comments = new List<BlogComment>()
			};

			bp2 = new BlogPost()
			{
				BlogPostID = 2,

				Title = "I'm a post with star wars stuff and HTML! WOO!",

				Content = "Did you ever hear the tragedy of Darth Plagueis The Wise? HTML LINEBREAK!!!!<br>" +
						  "I thought not. It’s not a story the Jedi would tell you. NEWLINE CHAR!!\n" +
						  "It’s a Sith legend.  Darth Plagueis was a Dark Lord of the Sith, " +
						  "(strong tag)<strong>so</strong> powerful and so wise he could use the Force to " +
						  "influence the midichlorians to create life… He had such a knowledge of the dark side " +
						  "that he could even keep the ones he cared about from dying. The dark side of the " +
						  "Force is a pathway to many abilities some consider to be unnatural. He became " +
						  "so powerful… the only thing he was afraid of was losing his power, which eventually, " +
						  "of course, he did. Unfortunately, he taught his apprentice everything he knew, then his " +
						  "apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.",

				Published = new DateTime(2017, 7, 7, 15, 5, 19),

				IsVisible = true,

				Comments = new List<BlogComment>()
			};

			c1 = new BlogComment()
			{
				BlogCommentID = 1,
				Author = "SomeUser1",
				Comment = "I'm doing my part!",
				Published = new DateTime(2017, 8, 7, 13, 3, 3),
				BlogPost = bp1
			};

			c2 = new BlogComment()
			{
				BlogCommentID = 2,
				Author = "SomeUser2",
				Comment = "You're SO cool",
				Published = new DateTime(2017, 8, 7, 17, 30, 12),
				BlogPost = bp1

			};

			c3 = new BlogComment()
			{
				BlogCommentID = 3,
				Author = "SomeUser1",
				Comment = "I'm still doing my part! newline\n(strong tag)<strong>go team!</strong>",
				Published = new DateTime(2017, 7, 7, 17, 50, 9),
				BlogPost = bp2

			};

			bp1.Comments.AddRange(new []{c1, c2});
			bp2.Comments.Add(c3);
		}

		public IQueryable<BlogPost> BlogPosts => new List<BlogPost> { bp1, bp2 }.AsQueryable();
	    public IQueryable<BlogComment> BlogComments => new List<BlogComment> { c1, c2, c3 }.AsQueryable();
    }
}
