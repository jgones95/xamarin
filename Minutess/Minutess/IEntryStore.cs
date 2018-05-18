using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Minutess
{
    public interface IEntryStore
    {
        Task<List<Entry>> ReadAsync();
        Task WriteAsync(Entry entry);
        Task DeleteAsync(Entry entry);

    }
}
