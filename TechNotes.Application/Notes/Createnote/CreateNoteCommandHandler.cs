
namespace TechNotes.Application.Notes.Createnote;

public class CreateNoteCommandHandler : ICommandHandler<CreateNoteCommand, NoteResponse>
{
  private readonly INoteRepository _noteRepository;

  public CreateNoteCommandHandler(INoteRepository noteRepository)
  {
    _noteRepository = noteRepository;
  }

  public async Task<Result<NoteResponse>> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
  {
    // var note = new Note
    // {
    //   Title = request.Title,
    //   Content = request.Content,
    //   PublishedAt = request.PublishedAt,
    //   IsPublished = request.IsPublished
    // };

    //Como estamos usando mapster podemos ahorrarnos lo de arriba y usar el adapt.
    var note = request.Adapt<Note>();

    var noteResponse = await _noteRepository.CreateNoteAsync(note);

    return noteResponse.Adapt<NoteResponse>();
  }
}


