using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlperAzureApp.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlperAzureApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _myDbContext;

        public List<Post> Posts { get; set; }

        public IndexModel(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public void OnGet()
        {
            Posts = _myDbContext.Posts.ToList();
        }

        public async Task<PageResult> OnPost(string newPostContent)
        {
            await _myDbContext.Posts.AddAsync(new Post
            {
                Content = newPostContent
            });

            await _myDbContext.SaveChangesAsync();
            
            Posts = _myDbContext.Posts.ToList();

            return Page();
        }

        public async Task<IActionResult> OnPostClearPostsAsync()
        {
             _myDbContext.Posts.RemoveRange(_myDbContext.Posts);
           
            await _myDbContext.SaveChangesAsync();
          
            return RedirectToPage();
        }
    }
}
