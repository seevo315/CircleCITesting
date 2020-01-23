using System;
using System.Collections.Generic;

namespace SLABuilderModels
{
    public class SLADocument
    {
        public string Title { get; set; }
        public SLAAuthor Author { get; set; }
        public string Application { get; set; }  //additional dto
        public DateTime CreateDate { get; set; } = System.DateTime.UtcNow;
        public bool IsActive { get; set; } = false;
        public List<SLODocument> SLOs { get; set; }       //additional dto

    }

}
