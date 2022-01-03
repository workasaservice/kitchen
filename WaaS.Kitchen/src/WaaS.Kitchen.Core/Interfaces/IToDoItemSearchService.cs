using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaaS.Kitchen.Core.ProjectAggregate;

namespace WaaS.Kitchen.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}
