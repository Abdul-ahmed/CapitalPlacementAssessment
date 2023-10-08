using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CapitalPlacementAssessment.Models // Note: actual namespace depends on the project name.
{
    public class ProgramDetail
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string? Summary { get; set; }
        public string Description { get; set; }
        public string? KeySkills { get; set; }
        public string? Benefits { get; set; }
        public string? ApplicationCriteria { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string? Duration { get; set; }
        public string Location { get; set; }
        public string? MinQualification { get; set; }
        public string? MaxQualification { get; set; }
    }
}