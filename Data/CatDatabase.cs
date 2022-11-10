using SQLite;
using BlazorHybridApp.Models;
using BlazorHybridApp.Data;
using BlazorHybridApp;

public class CatDatabase
{
    SQLiteAsyncConnection Database;

    public CatDatabase()
    {
    }

    async Task Init()
    {
        if (Database is not null) return;

        Database = new SQLiteAsyncConnection(DbConstants.DatabasePath, DbConstants.Flags);
        var result = await Database.CreateTableAsync<Cat>();
    }

    public async Task<List<Cat>> GetItemsAsync()
    {
        await Init();
        return await Database.Table<Cat>().ToListAsync();
    }

    public async Task<Cat> GetItemAsync(int id)
    {
        await Init();
        return await Database.Table<Cat>().Where(i => i.CatID == id).FirstOrDefaultAsync();
    }

    public async Task<int> SaveItemAsync(Cat cat)
    {
        await Init();
        if (cat.CatID != 0)
            return await Database.UpdateAsync(cat);
        else
            return await Database.InsertAsync(cat);
    }

    public async Task<int> DeleteItemAsync(Cat cat)
    {
        await Init();
        return await Database.DeleteAsync(cat);
    }
}