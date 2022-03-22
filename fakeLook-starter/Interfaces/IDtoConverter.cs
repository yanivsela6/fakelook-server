﻿using fakeLook_models.Models;

namespace fakeLook_starter.Interfaces
{
    public interface IDtoConverter
    {
        public Post DtoPost(Post post);
        public User DtoUser(User user);
        public Comment DtoComment(Comment comment);
        public Tag DtoTag(Tag tag);
        public Like DtoLike(Like like);
        public UserTaggedComment DtoUserTaggedComment(UserTaggedComment userTaggedComment);
        public UserTaggedPost DtoUserTaggedPost(UserTaggedPost userTaggedPost);
    }
}
