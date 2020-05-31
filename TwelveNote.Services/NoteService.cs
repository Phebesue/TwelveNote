using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwelveNote.Data;
using TwelveNote.Models;

namespace TwelveNote.Services
{
    public class NoteService
    {
        private readonly Guid _userId;
        public NoteService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateNote(NoteCreate model)
        {
            var entity =
                new Note()
                {
                    OwnerID = _userId,
                    NoteTitle = model.NoteTitle,
                    Content = model.Content,
                    CreatedUTC = DateTimeOffset.Now

                };
            using(var ctx = new ApplicationDbContext())
            {
                ctx.Notes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<NoteItemList> GetNotes()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Notes
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new NoteItemList
                        {
                            NoteId = e.NoteId,
                            NoteTitle = e.NoteTitle,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();

            }
        }
    }
}
