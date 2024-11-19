using System;
using System.Collections.Generic;

namespace ESSMaterWebApp.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string QuestionDescription { get; set; } = null!;

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();
}
