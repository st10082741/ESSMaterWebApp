using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class Diagnosis
{
    public int DiagnosisId { get; set; }

    public string? AssessmentDetails { get; set; }

    public int? DiagnosisQuestionnaireId { get; set; }

    public virtual Questionnaire? DiagnosisQuestionnaire { get; set; }
}
