using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanSimpleProject.Core.Entities
{
    public class IdeaItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public int Number { get; set; }
        public int IdeaMainId { get; set; }
        public IdeaMain Ideamain;

    }
}
