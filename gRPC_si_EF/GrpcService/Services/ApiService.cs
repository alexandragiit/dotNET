using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PostComment;
using PostComment.APIStatic;

namespace GrpcService.Services
{
    public class ApiService : Api.ApiBase
    {
        private readonly ILogger<ApiService> _logger;

        public ApiService(ILogger<ApiService> logger)
        {
            _logger = logger;
        }

        public override Task<Response> AddPost(Post post, ServerCallContext context)
        {
            Response output = new Response();

            PostComment.Comment c = new PostComment.Comment();
            PostComment.Post p = new PostComment.Post();
            p.PostId = post.PostId;
            p.Description = post.Description;
            p.Domain = post.Domain;
            p.Date = post.Date;
        
            List<PostComment.Comment> cList = new List<PostComment.Comment>();
           
            foreach (var i in post.Comments)
            {
                c.Text = i.Text;
                c.PostPostId = i.PostPostId;
                c.CommentId = i.CommentId;
                //c.Post = i.Post;

                cList.Add(c);
            }

            bool resp = API.AddPost(p);
            output.Resp = resp;

            return Task.FromResult(output);
        }
    }
}
