using System;
using Mapster;
using MediatR;
using TechNotes.Domain.Notes;

namespace TechNotes.Application.Notes.Createnote;

public class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, NoteResponse>
{
  private readonly INoteRepository _noteRepository;

  public CreateNoteCommandHandler(INoteRepository noteRepository)
  {
    _noteRepository = noteRepository;
  }

  public async Task<NoteResponse> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
  {
    var note = new Note
    {
      Title = request.Title,
      Content = request.Content,
      PublishedAt = request.PublishedAt,
      IsPublished = request.IsPublished
    };

    var noteResponse = await _noteRepository.CreateNoteAsync(note);

    return note.Adapt<NoteResponse>();
  }
}


