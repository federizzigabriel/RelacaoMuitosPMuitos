﻿namespace RelacaoMuitosPMuitos.Models
{
    public class Tag
    {
        public int? Id { get; set; }
        public List<PostTag>? PostTags { get; } = new();
    }
}
