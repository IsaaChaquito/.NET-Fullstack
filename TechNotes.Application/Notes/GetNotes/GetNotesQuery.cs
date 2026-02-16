
using MediatR;
using TechNotes.Domain.Abstractions;

namespace TechNotes.Application.Notes.GetNotes;

public class GetNotesQuery : IRequest<Result<List<NoteResponse>>>
{

}
