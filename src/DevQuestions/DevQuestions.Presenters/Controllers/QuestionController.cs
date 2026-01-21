using Contracts;
using DevQuestion.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace DevQuestions.Presenters;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionDto request,CancellationToken cancellationToken)
    {
        return Ok("Question");
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetQuestionDto request, CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid questionId,UpdateQuestionDto request, CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question deleted");
    }

    [HttpPut("{qustion:guid}/solution")]
    public async Task<IActionResult> SelectSolution([FromRoute] Guid questionId,[FromQuery] Guid answerId, CancellationToken cancellationToken)
    {
        return Ok("Solutions selected");
    }

    [HttpPost("{qustion:guid}/answers")]
    public async Task<IActionResult> AddAnswer([FromRoute] Guid questionId,[FromBody] AddAnswerDto addAnswerDto ,CancellationToken cancellationToken)
    {
        return Ok("Answer Added");
    }
}