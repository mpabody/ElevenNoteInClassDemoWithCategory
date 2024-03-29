﻿using ElevenNote.Models.NoteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models.CategoryModels
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public virtual List<NoteListItem> Notes { get; set; }
    }
}
