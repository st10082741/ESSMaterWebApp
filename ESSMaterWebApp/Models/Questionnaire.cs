using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class Questionnaire
{
    public int QuestionnaireId { get; set; }

    public virtual ICollection<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();
}
