using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext context;

        public CommandRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task CreateCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            await context.AddAsync(command);
        }

        public void DeleteCommand(Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            context.Commands.Remove(command);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await context.Commands.ToListAsync();
        }

        public async Task<Command> GetCommandById(int id)
        {
            return await context.Commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}