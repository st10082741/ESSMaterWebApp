using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class Response
{
    public int ResponseId { get; set; }

    public string? Response1 { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public bool? StronglyDisagree { get; set; }

    public bool? Disagree { get; set; }

    public bool? Neutral { get; set; }

    public bool? Agree { get; set; }

    public bool? StronglyAgree { get; set; }

    public int? ResponseQuestionId { get; set; }

    public int? ResponseQuestionnaireId { get; set; }

    public virtual Question? ResponseQuestion { get; set; }

    public virtual Questionnaire? ResponseQuestionnaire { get; set; }
}
