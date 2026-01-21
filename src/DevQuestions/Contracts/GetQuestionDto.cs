namespace DevQuestion.Contracts;

public record GetQuestionDto(string Title, Guid[] tags, int page, int size);
