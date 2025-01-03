using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                Body = comment.Body,
                CreatedOn = comment.CreatedOn,
                Title = comment.Title
            };
        }

        public static Comment ToCommentModel(this CreateCommentDto createCommentDto)
        {
            return new Comment
            {
                Body = createCommentDto.Body,
                Title = createCommentDto.Title,
                StockId = createCommentDto.StockId,
            };
        }
    }
}