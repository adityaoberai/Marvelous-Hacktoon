﻿using HackToon.Models.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackToon.Models
{
    public class CharactersAPI
    {
        public CharacterApiResponse Characters { get; set; }
    }

    public class CharactersResponse
    {
        public int Count { get; set; }
        public List<Character> Characters { get; set; }
    }

    public class CharactersPagedResponse : CharactersResponse
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
